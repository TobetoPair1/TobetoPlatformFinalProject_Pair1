namespace Core.Entities
{
    
        public interface IEntityTimestamps
        {
        //classların içi private interface içi public default değerleri
            DateTime CreatedDate { get; set; }
            DateTime? UpdatedDate { get; set; }
            DateTime? DeletedDate { get; set; }
        }
    
}
