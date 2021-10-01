namespace JokesWebApp.Models
{
    public class Joke
    {
        // These section corresponds to the properties of the current class:
        public int Id { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set; }

        // Constructor:
        public Joke()
        {

        }
    }
}
