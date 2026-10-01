namespace Task.Models;

public class Director : Human
{
  

    public string CompanyName { get; set; }
    
    public Director(string name, string surname, string email, int age, string companyName) : base(name, surname, email, age)
    {
        CompanyName = companyName;
    }
    
}