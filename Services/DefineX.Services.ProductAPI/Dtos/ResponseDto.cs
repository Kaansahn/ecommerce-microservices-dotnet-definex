using System;

namespace DefineX.Services.ProductAPI.Dtos;

public class ResponseDto
{
    //Enables standard format for all API responses.
    public bool IsSuccess { get; set; } = true;
    public object Result { get; set; }
    public string DisplayMessage { get; set; } = "";
    public List<string> ErrorMessages { get; set; }
}
