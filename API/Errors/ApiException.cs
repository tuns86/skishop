namespace API.Errors;

public class ApiException : ApiRespone
{
    public ApiException(int tatusCode, string message = null, string details = null ) : base
	(tatusCode, message)
    {
		Details = details;
    }

	public string Details { get; set; }
}