namespace Task.Models;

public class Film
{
    
    public Director director { get; set; }
    public Actor[] Actors { get; set; }
    public Video[] Videos { get; set; }
    
    public Film(Director director, Actor[] actors, Video[] videos)
    {
        this.director = director;
        Actors = actors;
        Videos = videos;
    }
    
    
    
    
    
}

