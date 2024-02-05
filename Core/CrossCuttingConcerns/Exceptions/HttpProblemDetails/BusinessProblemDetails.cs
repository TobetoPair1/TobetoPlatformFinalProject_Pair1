using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;
public class BusinessProblemDetails : ProblemDetails
{
    public BusinessProblemDetails(string detail, string title)
    {
        Title = title;
        Detail = detail;
        Status = StatusCodes.Status401Unauthorized;
        Type = "Business_Exception";
    }
}