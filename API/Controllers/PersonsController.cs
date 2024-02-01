namespace API.Controllers;

using API.Models;
using Microsoft.AspNetCore.Mvc;
using Namespace;

[ApiController]
[Route("[controller]")]
public class PersonsController : ControllerBase
{
    private readonly IRepository _repo;
    public PersonsController(IRepository repo)
    {
        _repo = repo;
    }
    [HttpGet(Name = "GetPersons")]
    public async Task<IActionResult> GetPersons()
    {

    }
}
