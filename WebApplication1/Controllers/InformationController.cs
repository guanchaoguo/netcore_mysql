using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class InformationController
{
    private InformationRecords informationRecords;

    public InformationController(MySqlConnection connection)
    {
        informationRecords = new InformationRecords(connection);
    }


    [HttpGet]
    public IEnumerable<Information> Get()
    {
        List<Information> information = informationRecords.GetInformationRecords().Result;

        return Enumerable
            .Range(0, information.Count)
            .Select(index => new Information
            {
                Name = information[index].Name,
                Title = information[index].Title,
                Summary = information[index].Summary
            });
    }
}