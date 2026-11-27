using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Assingment05
{
    internal class Program
    {
        class Book 
        {
            private string password = "secret";
            internal int copiesInStock = 5;
            public string title ;
            public Genre genre;
        }

        enum Genre {Fiction, NonFiction, Science };
        static void Main(string[] args)
        {
            Book book = new Book();
           
            #region Question 1
            //Console.WriteLine(book.password); // it cant access this var because it private in anothe scope
            #endregion

            #region Question 2
            //Console.WriteLine(book.copiesInStock); //it accessed in same project
            #endregion

            #region Question 3
            //book.title = "Clean Code";
            //Console.WriteLine(book.title);//Accessed from any where 
            #endregion

            #region Question 4
            //Genre genre = genre.Science;
            //Console.WriteLine(book.genre);
            #endregion

            #region Question 5
            //int value1 = (int)genre.Fiction;
            //int value2 = (int)genre.NonFiction;
            //int value3 = (int)genre.Science;
            //Console.WriteLine(value1);
            //Console.WriteLine(value2);
            //Console.WriteLine(value3);
            #endregion

            #region Question 6
            //int genreNumber = 1;
            //Genre genreValue = (genre)genreNumber;
            //Console.WriteLine(genreValue);
            #endregion

            #region Question 7
            //Genre genre = genre.Fiction;
            //string value = genre.ToString();
            //Console.WriteLine(value);
            #endregion

            #region Question 8
            //string genreText = "Science";
            //Genre genre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(genre);
            #endregion

            #region Question 9
            //Genre genre;
            //string genreText = "Mystery";
            //bool isValid;

            //isValid = Enum.TryParse<Genre>(genreText, out genre)
            //          && Enum.IsDefined(typeof(Genre), genre);

            //if (isValid)
            //{
            //    Console.WriteLine(genre);
            //}
            //else
            //{
            //    Console.WriteLine("Unknown genre");
            //}
            #endregion
        }
    }
}
