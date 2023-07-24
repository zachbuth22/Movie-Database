using Movie_Database;
using Circle_Lab;

Console.WriteLine("Hello, Welcome to the Movie Database!");

List<Movie> listMovie = new List<Movie>
{
    new Movie("A Bug's Life", "Animated"),
    new Movie("There Will Be Blood", "Drama"),
    new Movie("Interstellar", "Sci-Fi"),
    new Movie("The Ring", "Animated"),
    new Movie("Lincoln", "Drama"),
    new Movie("The Hills Have Eyes", "Horror"),
    new Movie("Oppenheimer", "Drama"),
    new Movie("Finding Nemo", "Animated"),
    new Movie("Alien", "Sci-fi"),
    new Movie("Final Destination", "Horror"),
};

bool runProgram = true;
while (runProgram)
{

    Console.WriteLine("Enter a category");
    string input = Console.ReadLine().ToLower().Trim();
    List<Movie> Movie = listMovie.Where(m => m.Category.ToLower() == input).ToList();
    foreach (Movie m in Movie)
    {
        Console.WriteLine(m.Title);
    }
    runProgram = Validator.GetContinue();
}