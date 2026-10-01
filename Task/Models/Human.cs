namespace Task.Models;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Human(string name, string surname, string email, int age)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Age = age;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"{Name} {Surname}, Age: {Age}, Email: {Email}");
    }
}