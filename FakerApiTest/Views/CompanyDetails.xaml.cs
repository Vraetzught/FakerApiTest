namespace FakerApiTest.Views;

public partial class CompanyDetails : ContentPage
{
    public CompanyDetails(CompanyDetailsViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}