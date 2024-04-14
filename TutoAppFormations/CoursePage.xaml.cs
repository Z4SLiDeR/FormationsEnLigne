namespace TutoAppFormations;

public partial class CoursePage : ContentPage
{
	Formation course;
	public List<string> Items = new List<string>();
	public CoursePage(Formation c)
	{
		this.course = c;
		InitializeComponent();

		Items.Add("Chapitre 1");
		Items.Add("Price: ");
		Items.Add("Description: ");
		lv.ItemsSource = Items;
	}
}