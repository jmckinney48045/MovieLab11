using System;

namespace MovieLab11
{

    public class Movie
    {
        private string _title;
        private string _category;
        public Movie(string title, Category category)
        {
            _title = title;
            _category = category;
        }
        public string GetTitle()
        {

            return _title;
        }
        public Category GetCategory()
        {
            return _category;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var movieApp = "Movie List Application";
            var movieList = new List<Movies>();

            movieList.Add(new Movies("It", Category.horror));
            movieList.Add(new Movies("Poltergeist", Category.horror));
            movieList.Add(new Movies("Scream", Category.horror));
            movieList.Add(new Movies("Friday the 13th", Category.horror));
            movieList.Add(new Movies("Nightmare on Elm Street", Category.horror));
            movieList.Add(new Movies("Schindler's List", Category.drama));
            movieList.Add(new Movies("Citizen Kane", Category.drama));
            movieList.Add(new Movies("The Godfather", Category.drama));
            movieList.Add(new Movies("The Dark Knight", Category.drama));
            movieList.Add(new Movies("A Star is Born", Category.drama));
            movieList.Add(new Movies("Finding Nemo", Category.animated));
            movieList.Add(new Movies("Inside Out", Category.animated));
            movieList.Add(new Movies("Wreck It Ralph", Category.animated));
            movieList.Add(new Movies("The Princess and the Frog", Category.animated));
            movieList.Add(new Movies("Megamind", Category.animated));
            movieList.Add(new Movies("Terminator", Category.scifi));
            movieList.Add(new Movies("12 Monkeys", Category.scifi));
            movieList.Add(new Movies("The Planet of the Apes", Category.scifi));
            movieList.Add(new Movies("Star Trek: First Contact", Category.scifi));
            movieList.Add(new Movies("Contact", Category.scifi));


            Console.WriteLine($"Welcome to the {movieApp} !");
            Console.WriteLine("There are 20 movies in this list. ");

            do
            {
                Category movieType;
                bool valid;
                do
                {
                    Console.WriteLine("What category are you interested in? \nPlease choose: \n(1) {Category.animated}, \n(2) {Cateogry.horror}, \n(3) {Category.drama}, \n(4) {Category.scifi}");
                    valid = Category.TryParse(Console.ReadLine(), out movieType);
                }
                while (!valid);
                Console.WriteLine(Movie.GetTitle());
                {
                    if (Movie.GetCategory() == movieType)
                        Console.WriteLine(Movie.GetTitle());
                }
                Console.WriteLine("Would you like to continue? y/n");

            } while (Console.ReadLine() == "y");

        }
    }

    internal class Movies
    {
        private string v;
        private Category horror;

        public Movies(string v, Category horror)
        {
            this.v = v;
            this.horror = horror;
        }
    }

    public enum Category
    {
        animated = 1,
        horror = 2,
        drama = 3,
        scifi = 4,
    }

}  







