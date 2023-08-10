using System;

namespace WebApplication1.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? GitHubURL { get; set; }
        public string? PublicURL { get; set; }
        public string? Summary { get; set; }
    }
}