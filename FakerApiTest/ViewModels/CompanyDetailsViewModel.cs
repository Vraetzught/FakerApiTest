namespace FakerApiTest.ViewModels;

[QueryProperty(nameof(Models.Company), "Company")]
public partial class CompanyDetailsViewModel : BaseViewModel
{
    [ObservableProperty] Company company;
}