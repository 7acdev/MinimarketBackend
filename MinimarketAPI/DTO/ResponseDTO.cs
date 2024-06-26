namespace Minimarket.DTO;

public class ResponseDTO<T>
{
    public bool? Success { get; set; }

    public string? Message { get; set; }

    public T? Result { get; set; }
}