namespace Grimaldus.Models
{
    public class HomePageModel
    {
        public ProjectDescriptionModel[] ProjectDescriptionModels => new[]
        {
            new ProjectDescriptionModel
            {
                Title = "Project Grimaldus",
                Subtitle = "This website!",
                Tags = new[] {"ASP.NET Core", "C#"},
                Description = "Click 'Learn More' to see the technical side of website (i.e. CI, CD, Hosting, SSL)",
                PlayButton = new ButtonModel
                {
                    Link = "/Projects/ProjectGrimaldus",
                    Text = "Learn More",
                    OpenInNewTab = false
                },
                InfoButton = new ButtonModel
                {
                    Link = "https://github.com/ChrisWoody/project-grimaldus",
                    Text = "View Source Code",
                    OpenInNewTab = true
                }
            },
            new ProjectDescriptionModel
            {
                Title = "Project Sicarius",
                PathToImage = "images/project-sicarius-example.png",
                Subtitle = "A 2D WebGL game made in Unity",
                Tags = new[] {"Game", "C#", "Unity", "Web GL"},
                Description = "Play as an angel who has to take out the invading demons",
                PlayButton = new ButtonModel
                {
                    Link = "https://chriswood.blob.core.windows.net/project-sicarius/index.html",
                    Text = "Play",
                    OpenInNewTab = true
                },
                InfoButton = new ButtonModel
                {
                    Link = "https://github.com/ChrisWoody/project-sicarius",
                    Text = "View Source Code",
                    OpenInNewTab = true
                }
            },
        };
    }
}