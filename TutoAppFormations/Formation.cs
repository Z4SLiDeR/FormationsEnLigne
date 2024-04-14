namespace TutoAppFormations
{
    public class Formation
    {
        public string Title { get; set; }

        public int Price { get; set; }

        public string Desc { get; set; }

        public string Image { get; set; }
        public string Tag { get; set; }
        public string FullTitle => $"{Title} ({Tag})";
    }
}
