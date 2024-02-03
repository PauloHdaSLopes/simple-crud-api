namespace API.Controllers;

using API.Models;
using API.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PersonsController : ControllerBase
{

    private readonly IRepository<Person> _repo;

    public PersonsController(IRepository<Person> repo)
    {
        _repo = repo;
    }

    [HttpPost(Name = "AddPerson")]
    public async Task<IActionResult> AddPerson([FromBody] Person person)
    {   
        _repo.Create(person);
        await _repo.saveAll();
        return Ok();
    }

    [HttpGet(Name = "GetPersons")]
    public async Task<IActionResult> GetPersons()
    {
        var personFromRepo = await _repo.ReadAll();
        
        return Ok(personFromRepo);
    }

    [HttpGet("{id}", Name = "GetUser")]
    public async Task<IActionResult> GetPerson(int id)
    {
        var personFromRepo = await _repo.Read(id);

        return Ok(personFromRepo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePerson(int id, [FromBody] Person person)
    {
        var personFromRepo = await _repo.Read(id);

        personFromRepo.CPF = person.CPF;
        personFromRepo.Nome = person.Nome;
        personFromRepo.Nascimento = person.Nascimento;
        personFromRepo.Renda = person.Renda;
        
        if(await _repo.saveAll())
            return Ok();

        throw new Exception($"Updating user {id} failed on save!");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var personFromRepo = await _repo.Read(id);
        
        _repo.Delete(personFromRepo);

        await _repo.saveAll();

        return Ok();
    }

}
