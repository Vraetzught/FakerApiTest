namespace FakerApiTest.ViewModels;

public partial class CompanyViewModel : BaseViewModel
{
    HttpClient HttpClient;
    
    [ObservableProperty] private CompanyResult companyResult;
    
    public CompanyViewModel()
    {
        HttpClient = new();
        Title = "Companies";
        CompanyResult = new();
        GetCompanies();
    }

    [RelayCommand]
    public async void GetCompanies()
    {
        var url = "https://fakerapi.it/api/v1/companies?_quantity=12";
        var response = await HttpClient.GetStringAsync(url);
        if (!string.IsNullOrEmpty(response))
            CompanyResult = JsonSerializer.Deserialize<CompanyResult>(response);
    }

    [RelayCommand]
    async Task ShowDetails(Company company)
    {
        if (company == null) return;
        await Shell.Current.GoToAsync(nameof(CompanyDetails), true, new Dictionary<string, object>
        {
            {"Company", company}
        });
    }
}