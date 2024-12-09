using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.CrossCuttingConcerns.Exceptions.HttpProblemDetails;

public class BusinessProblemDetails : ProblemDetails
{
    public BusinessProblemDetails(string detail)
    {
        Title = "Rule Validation";
        Detail = detail;
        Status = StatusCodes.Status400BadRequest;
        Type = "https://example.com/problems/business";

    }
}