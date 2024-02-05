using Microsoft.Extensions.Caching.Memory;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Core.CrossCuttingConcerns.Caching.Microsoft;
public class MemoryCacheManager : ICacheManager
{
	IMemoryCache _memoryCache;

	public MemoryCacheManager(IMemoryCache memoryCache)
	{
		_memoryCache = memoryCache;
	}

	public void Add(string key, object value, int duration)
	{
		_memoryCache.Set(key,value,TimeSpan.FromMinutes(duration));
	}

	public T Get<T>(string key)
	{
		return _memoryCache.Get<T>(key);
	}

	public object Get(string key)
	{
		return _memoryCache.Get(key);
	}

	public bool IsAdd(string key)
	{
		return _memoryCache.TryGetValue(key, out _);
	}

	public void Remove(string key)
	{
		_memoryCache.Remove(key);
	}

	public void RemoveByPattern(string pattern)
	{
		var fieldInfo = typeof(MemoryCache).GetField("_coherentState", BindingFlags.Instance | BindingFlags.NonPublic);
		var propertyInfo = fieldInfo.FieldType.GetProperty("EntriesCollection", BindingFlags.Instance | BindingFlags.NonPublic);
		var value = fieldInfo.GetValue(_memoryCache);
		var cacheEntriesCollectionDefinition = propertyInfo;
		var cacheEntriesCollection = cacheEntriesCollectionDefinition.GetValue(value) as dynamic;
		List<ICacheEntry> cacheCollectionValues = new List<ICacheEntry>();

		foreach (var cacheItem in cacheEntriesCollection)
		{
			ICacheEntry cacheItemValue = cacheItem.GetType().GetProperty("Value").GetValue(cacheItem, null);
			cacheCollectionValues.Add(cacheItemValue);
		}

		var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
		var keysToRemove = cacheCollectionValues.Where(d => regex.IsMatch(d.Key.ToString())).Select(d => d.Key).ToList();

		foreach (var key in keysToRemove)
		{
			_memoryCache.Remove(key);
		}
	}
}