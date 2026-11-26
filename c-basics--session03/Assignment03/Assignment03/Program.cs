using System.Collections.Specialized;
using System.Text;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            #region Question 01
            //string title = "clean code";
            //string upperTitle =  title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question 02
            //string variable1 = "Clean Code";
            //string variable2 = "Clean Code";
            //Console.WriteLine(variable1.);
            #endregion

            #region Question 03
            //StringBuilder sb=new StringBuilder();
            //sb.Append("Book List");
            //sb.Append("-Updated");
            //Console.WriteLine(sb);
            #endregion

            #region Question 04
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion

            #region Question 05
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book : "+ title +", Pages  " + pages);
            #endregion

            #region Question 06
            //Console.WriteLine($"Book : {title}, Pages : {pages}");
            #endregion

            #region Question 07
            //Console.WriteLine(string.Format("Book : {0} ,Pages {1}", title, pages));
            #endregion

            #region Question 08
            //int pages = 464;
            //if (pages > 300 )
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question 09
            //int pages = 464;
            //bool isAvailable = true;
            //if (isAvailable && pages > 300)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question 10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great Choice");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice Pick");
            //        break;
            //    default: 
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question 11
            //int pages = 464;
            //string sizeLabel = (pages > 300) ?  "long Book" :  "Small Book"; //returns a value
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Question 12
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Question 13
            //int counter = 0;
            //while (counter < books.Length)
            //{
            //    Console.WriteLine(books[counter]);
            //    counter++;

            //}
            #endregion

            #region Question 14
            //short counter = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    counter++;

            //} while (counter < 3);
            #endregion

            #region Question 15
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question 16
            //foreach(string book in books)
            //{
            //    Console.WriteLine(book);
            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region Question 17
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(book);

            //}
            #endregion

            #region Question 18
            //void PrintFirstBook()
            //{
            //    if (books.Length == 0)
            //    {
            //        return;
            //    }
            //        Console.WriteLine(books[0]);
            //}
            //PrintFirstBook();
            #endregion
        }
    }
}