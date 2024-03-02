namespace FakerApiTest.Models;

public class Company
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string country { get; set; }
    public List<Location> addresses { get; set; }
    public string website { get; set; }
    public string image { get; set; }
}