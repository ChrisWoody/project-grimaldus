namespace Grimaldus.Models
{
    public class ProjectDescriptionModel
    {
        public string Title { get; set; }
        public string PathToImage { get; set; }
        public string Subtitle { get; set; }
        public string[] Tags { get; set; }
        public string Description { get; set; }
        public ButtonModel PlayButton { get; set; }
        public ButtonModel InfoButton { get; set; }
    }
}