using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    ProjectRecords projectRecords = new ProjectRecords();

    [HttpGet]
    public IEnumerable<Project> Get()
    {
        List<Project> projects = projectRecords.GetProjectRecords();

        return Enumerable.Range(0, projects.Count).Select(index => new Project
        {
            ID = projects[index].ID,
            Name = projects[index].Name,
            GitHubURL = projects[index].GitHubURL,
            PublicURL = projects[index].PublicURL,
            Summary = projects[index].Summary
        })
        .ToArray();
    }
}
