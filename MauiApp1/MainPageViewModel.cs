using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _buttonEnabled = false;

    [ObservableProperty]
    private string _buttonText = "Disabled";

    [RelayCommand]
    private void OnButtonClicked()
    {
        ButtonEnabled = !ButtonEnabled;
        ButtonText = ButtonEnabled ? "Enabled" : "Diabled";
    }

    [RelayCommand]
    private async void DisplayAlert()
    {
        await Application.Current.MainPage.DisplayAlert("", "Other Button Clicked", "OK");
    }

}
