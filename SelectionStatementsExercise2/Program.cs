namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
           FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I dislike math");
                    break;
                case "science":
                    Console.WriteLine("science rules");
                    break;
                case "pe":
                case "p.e.":
                    Console.WriteLine("P.E. is awesome");
                    break;
                case "History":
                    Console.WriteLine("History is my favorite too");
                    break;
                case "English":
                    Console.WriteLine("English is important");
                    break;
                default:
                    Console.WriteLine("I like that one too");
                    break;
            }
        }
    }
}