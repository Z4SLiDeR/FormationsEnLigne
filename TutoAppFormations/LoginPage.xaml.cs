namespace TutoAppFormations;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		//HttpClient client = new HttpClient();
  //      var RestURL = "http://10.0.2.2:5098/Login?pseudo=" + pseudo.Text + "&pass=" + pass.Text;
		//client.BaseAddress = new Uri(RestURL);
		//HttpResponseMessage response = await client.GetAsync(RestURL);
		//var content = await response.Content.ReadAsStringAsync(); 
		
		// dans le cas d'utilisation de l'API

		if (pseudo.Text == "jeremy" && pass.Text == "1234")
		{
			await Navigation.PushAsync(new MainPage());
		}
		else
		{
			await DisplayAlert("Erreur", "Pseudo ou mot de passe incorrect", "OK");
		}
    }
}