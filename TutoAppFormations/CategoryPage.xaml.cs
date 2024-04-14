using Newtonsoft.Json;

namespace TutoAppFormations;

public partial class CategoryPage : ContentPage
{
	Categorie cat;
	public CategoryPage(Categorie c)
	{
		this.cat = c;
		InitializeComponent();
        noCoursesError.IsVisible = false;

        LoadFromMauiAsset(c.Title.ToLower());
    }

     async void LoadFromMauiAsset(string catName)
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(catName + ".json");
            using var reader = new StreamReader(stream);
            var content = reader.ReadToEnd();
            var Items = JsonConvert.DeserializeObject<List<Formation>>(content);
            lv.ItemsSource = Items;
        }
        catch (Exception ex)
        {
            lv.ItemsSource = null;
            noCoursesError.IsVisible = true;
        }

    }

    private async void lv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
       await Navigation.PushAsync(new CoursePage((Formation)e.SelectedItem));
    }
}