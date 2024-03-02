namespace FakerApiTest.Views;

public partial class CompanyView : ContentPage
{
    public CompanyView(CompanyViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}