using CommunityToolkit.Maui.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Application.Current.MainPage.ShowPopupAsync<SomePopup>(new SomePopup());
    }
}

