using CommunityToolkit.Maui.Markup;

namespace MauiApp1;

public class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		BindingContext = vm;

		Content = new ScrollView
		{
			Content = new VerticalStackLayout
			{
				Children =
				{
					new Button
					{
						Text = "Toggle ther button enabled"
					}
					.BindCommand(nameof(vm.ButtonClickedCommand)),


					// This button works as expected and is disabled at startup
					//new Button()
					//.BindCommand(nameof(vm.DisplayAlertCommand))
					//.Bind(Button.TextProperty, nameof(vm.ButtonText))
					//.Bind(Button.IsEnabledProperty, nameof(vm.ButtonEnabled)),
					
					// This button is enabled at startup but the text still reads "Disabled"
					// On first click of the toggle button, this text changes to "Enabled" and the Button is still enabled
					// Everything works as expected on subsequest pressess of the toggle button.
					new Button ()
					.Bind(Button.TextProperty, nameof(vm.ButtonText))
					.Bind(Button.IsEnabledProperty, nameof(vm.ButtonEnabled))
					.BindCommand(nameof(vm.DisplayAlertCommand)),
				}
			}
		};
	}
}