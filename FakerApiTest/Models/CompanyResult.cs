namespace FakerApiTest.Models;

public class CompanyResult
{
    public string status { get; set; }
    public int code { get; set; }
    public int total { get; set; }
    public List<Company> data { get; set; }
}