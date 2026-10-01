namespace Task.Models;

public  class Actor : Human
{
    

    public string university { get; set; }
    
    public Actor(string name, string surname, string email, int age, string university) : base(name, surname, email, age)
    {
        this.university = university;
    }
    
    public void Study()
    {
        Console.WriteLine($"{Name} is studying at {university}.");
    }
    
}