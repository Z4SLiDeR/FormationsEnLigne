namespace TutoAppFormations
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        public async void LoadDataFromAPI()
        {
            HttpClient client = new HttpClient();
            //var RestURL = "http://localhost:5098/Categorie";
            var RestURL = "http://10.0.2.2:5098/Categorie";
            client.BaseAddress = new Uri(RestURL);
            HttpResponseMessage response = await client.GetAsync(RestURL);
            var content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<List<Categorie>>(content);
            lv.ItemsSource = Items;
        }
    }

}
