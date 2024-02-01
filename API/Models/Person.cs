namespace API.Models;

public class Person
{
    public int Id { get; set; }
    public string CPF { get; set; }
    public string Nome { get; set; }
    public DateTime Nascimento { get; set; }
    public Decimal Renda { get; set; }    
}
