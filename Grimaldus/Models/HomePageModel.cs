namespace Grimaldus.Models
{
    public class HomePageModel
    {
        public ProjectDescriptionModel[] ProjectDescriptionModels => new[]
        {
            new ProjectDescriptionModel
            {
                Title = "Project Sicarious",
                PathToImage = "images/project-sicarius-example.png",
                Subtitle = "A 2D WebGL game made in Unity",
                Tags = new[] {"Game", "C#", "Unity", "Web GL"},
                Description = "Play as an angel who has to take out the invading demons",
                PlayButton = new ButtonModel
                {
                    Link = "https://chriswood.blob.core.windows.net/project-sicarius/index.html",
                    Text = "Play"
                },
                InfoButton = new ButtonModel
                {
                    Link = "https://github.com/ChrisWoody/project-sicarius",
                    Text = "View Source Code"
                }
            },
        };
    }
}