
//In your program.cs file, create a List<Movie> and store at least 10 movies there.
using Movie_Database;
using Circle;

List<Movie> movies = new List<Movie>()
{
    new Movie ("Everything Everywhere All at Once","drama"),
    new Movie ("The Big Lebowski","comedy"),
    new Movie ("A Monster Calls","drama"),
    new Movie ("The Shape of Water","romance"),
    new Movie ("Pacific Rim","sci-fi"),
    new Movie ("Soul","drama"),
    new Movie ("Requiem for a Dream","animated"),
    new Movie ("Coco","animated"),
    new Movie ("MidSommar","horror"),
    new Movie("Shawshank Redemption", "drama"),
    new Movie("The Dark Knight", "action"),
    new Movie("Run Hide Fight", "action"),
    new Movie("Zootopia", "animated"),
    new Movie("How to Train Your Dragon", "animated"),
    new Movie("Terminal List", "action"),
    new Movie("Instant Family", "drama"),
    new Movie("La Misma Luna", "drama"),
    new Movie("Pilgrim's Progress", "animated"),
    new Movie("Insanity of God", "historical"),
    new Movie("Swiss Family Robinson", "adventure"),
    new Movie("Harriet", "historical"),
    new Movie("The Green Book", "historical"),
    new Movie("News of the World", "drama"),
    new Movie("Lord of the Rings", "adventure"),
    new Movie("The Princess Bride", "adventure"),
    new Movie("Big Hero 6", "animated"),
    new Movie("Little Women", "historical"),
    new Movie("Avengers: Endgame", "adventure"),
    new Movie("Wednesday", "action"),
    new Movie("Grease", "romance"),
    new Movie("Carter", "action"),
    new Movie("White Noise", "drama"),
    new Movie("Spider Head", "sci-fi")
};

List<Movie> distinctCategories = movies.GroupBy(x => x.Category).Select(x => x.First()).OrderBy(y => y.Category).ToList();
bool runProgram = true;
while (runProgram)
{
    //list of catergories in alphabetical order.
    foreach (Movie movie in distinctCategories)
    {
        Console.WriteLine(movie.Category);
    }
    string category = "";
    while (true)
    {
        Console.WriteLine("Please enter a category:");
        category = Console.ReadLine().ToLower().Trim();

        if (!distinctCategories.Any(x => x.Category == category))
        {
            Console.WriteLine("Please check spacing and spelling.");
        }
        else
        {
            break;
        }
    }


    List<string> titles = new List<string>();
    foreach (Movie c in movies)
    {
        if (c.Category == category)
        {
            titles.Add(c.Title);
        }

    }
    titles.Sort();
    foreach (string title in titles)
    {
        Console.WriteLine(title);
    }
    runProgram = Validator.GetContinue();
    Console.Clear();
}




