namespace Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;

public class ValidationExceptionModel
{
    public string? Property { get; set; }
    public IEnumerable<string>? Errors { get; set; }
}