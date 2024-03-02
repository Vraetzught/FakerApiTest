namespace FakerApiTest.Models;

public class Location
{
    public int id { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string zipcode { get; set; }
    public string country { get; set; }
    public string county_code { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
}