namespace Task;
using Task.Models;

class Program
{
    static void Main(string[] args)
    {
        Director tarantino = new Director("Quentin", "Tarantino", "quentin@film.com", 61, "A Band Apart");
        Actor[] actorsList = new Actor[]
            {
                new Actor("Brad", "Pitt", "brad@hollywood.com", 60, "University of Missouri"),
                new Actor("Christoph", "Waltz", "waltz@cinema.com", 66, "Max Reinhardt Seminar")
            };

            Video[] videosList = new Video[]
            {
                new Video("terry","davis","terrytheterrible@gmail.com",43 ),
                new Video("linus","torvalds","arch@gmail.com",31)
            };

            Film myFilm = new Film(tarantino, actorsList, videosList);
    }
}