namespace TutoAppFormations;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Uri uri = new Uri("https://www.google.com");
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}