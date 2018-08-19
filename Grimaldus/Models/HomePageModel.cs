namespace Grimaldus.Models
{
    public class HomePageModel
    {
        public ProjectDescriptionModel[] ProjectDescriptionModels => new[]
        {
            new ProjectDescriptionModel
            {
                Title = "Project 'X' naming",
                Description = "What is a 'Grimaldus'? Do you dare Google it? Click 'Learn More' to see where I get these names from.",
                PlayButton = new ButtonModel
                {
                    Link = "/Projects/ProjectNaming",
                    Text = "Learn more",
                    OpenInNewTab = false
                }
            },
            new ProjectDescriptionModel
            {
                Title = "Project Grimaldus",
                Subtitle = "This website!",
                Tags = new[] {"ASP.NET Core", "C#"},
                Description = "Click 'Learn More' to see the why I've made this website as well as some of the technical aspects of it",
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