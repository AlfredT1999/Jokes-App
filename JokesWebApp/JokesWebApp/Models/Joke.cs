using System.ComponentModel.DataAnnotations;

namespace JokesWebApp.Models
{
    public class Joke
    {
        // These section corresponds to the properties of the current class:
        public int Id { get; set; }

        [Display(Name = "The Joke")]
        public string JokeQuestion { get; set; }

        [Display(Name = "The Answer To The Joke")]
        public string JokeAnswer { get; set; }

        // Constructor:
        public Joke()
        {

        }
    }
}
