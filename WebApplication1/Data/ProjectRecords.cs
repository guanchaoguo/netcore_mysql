using WebApplication1.Models;

namespace WebApplication1.Data
{
	public class ProjectRecords
	{
		private static readonly List<Project> projects = new List<Project>();

		private static readonly Project jofer = new Project();
		private static readonly Project pub = new Project();

		public ProjectRecords()
		{
			jofer.ID = 1;
			jofer.Name = "Jofer";
			jofer.PublicURL = "www.jofer.com";
			jofer.Summary = "Jofer Summary";

			pub.ID = 2;
			pub.Name = "PUB";
			pub.PublicURL = "www.pub.com";
			pub.Summary = "PUB Summary";

			projects.Add(jofer);
			projects.Add(pub);
		}

		public List<Project> GetProjectRecords()
		{
			return projects;
		}
	}
}
