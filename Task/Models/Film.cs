namespace Task.Models;

public class Film
{
    public Director director { get; set; }
    public Actor[] actor { get; set; }
    public Video[] videos { get; set; }
}