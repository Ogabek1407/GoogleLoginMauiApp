using GoogleLogon.ViewModels;

namespace GoogleLogon.Pages;

public partial class SignIn : ContentPage
{
    public SignIn(RegistrationViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}