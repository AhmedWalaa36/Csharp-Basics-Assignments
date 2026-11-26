using System.Runtime.ConstrainedExecution;

namespace Assignment
{

    class Book
    {
          public  string Title ;
           public int Pages  ;
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region Question 01

            //object book01 = new Book();

            //((Book)book01).Title = "Journy To The Center Of The Earth ";
            //((Book)book01).Pages = 350;

            //Console.WriteLine(((Book)book01).Title);
            //Console.WriteLine(((Book)book01).Pages);

            #endregion

            #region Question 02 
            //Console.WriteLine(book01.Pages.ToString());
            //Console.WriteLine(book01.Equals(book01));
            //Console.WriteLine(book01.GetHashCode());
            //Console.WriteLine(book01.GetType()); //Return the name of namespace and class
            #endregion

            #region Question 03
            //int pages = Convert.ToInt32("464");  
            #endregion

            #region Question 04
            //int x = 10;
            //int y = 0;
            //try
            //{
            //    int z = x / y;
            //    Console.WriteLine(z);
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally 
            //{
            //    Console.WriteLine("End!");
            //}
            #endregion

            #region Qusetion 05
            //int pages = 300;
            //double value = pages;

            #endregion

            #region Question 06
            //double price = 49.99;
            //int variable = (int)price;

            #endregion

            #region Question 07
            //string pagesText = "464";
            //int variable = Convert.ToInt32(pagesText);

            #endregion

            #region Question 08
            //string yearText = "2023";
            //int variable = int.Parse(yearText);


            //string badText = "abc";
            //int var2;

            //bool result = int.TryParse(badText, out var2); // return bool 
            //if (!result)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //else
            //{
            //    Console.WriteLine(var2);
            //}
            #endregion

            #region Question 09
            int pages = 464;
            string variable = pages.ToString();
            Console.WriteLine(variable.GetType());
            #endregion

            #region Question 10
            //int copies = 100;
            //object objCopies = copies;
            //int newCopies =(int)objCopies;
            //Console.WriteLine(newCopies);
            //Console.WriteLine(objCopies);
            #endregion
        }
    }
}