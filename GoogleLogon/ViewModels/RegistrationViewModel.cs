using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GoogleLogon.ViewModels;

public partial class RegistrationViewModel : ObservableObject
{

    [RelayCommand]
    public void Tap()
    {
        Console.WriteLine("1111");
    }
}
