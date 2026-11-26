using System.Diagnostics;

namespace Assignment04
{
    internal class Program
    {

       static void PrintWelcomeMessage()
        {

            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title) 
        {
            Console.WriteLine("Book title: "+ title); 
        }

        static void AddBonusPages(int pages) 
        {
            pages += 50;
            Console.WriteLine(pages);
        }

        static void ApplyDiscount(double[] prices) 
        {
            prices[0] -= 5;
            Console.WriteLine(prices[0]);
        }

        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
            Console.WriteLine(pages);
        }

        static void ReplaceArray(ref double[] prices)
        {
            double[] newPrices = { 10.0, 12.5, 15.0 };
            prices = newPrices;
        }

        static bool TryGetPrice(string title, out double price)
        {
            price = 25.5;
            if (title=="Clean Code")
            {
                return true;
            }
            price = 0;
            return false;            
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Book Title: {title} Pages: {pages}");
        }

        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
           
        }


        static void Main(string[] args)
        {
            #region Question 1
            //double[] prices = new double[] { 25.5, 40.0, 33.75 };
            //Console.Write(prices[1]);
            #endregion

            #region Question 2
            //int[,] shelfCopies = new int [,] { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfCopies[1,0]);
            #endregion

            #region Question 3
            //PrintWelcomeMessage();
            #endregion

            #region Question 4
            //PrintBookTitle("Clean Code");
            #endregion

            #region Question 5
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages); // pages still 400 because we send a copy of variable
            #endregion

            #region Question 6
            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]); // it changes in the origial variable becaues arry sent by ref
            #endregion

            #region Question 7
            //int pages = 400;
            //AddBonusPagesByRef(ref pages);
            //Console.WriteLine(pages); // by ref it changes in the original variable
            #endregion

            #region Question 8
            //double[] prices = { 25.5, 40.0 };
            //ReplaceArray(ref prices);
            //Console.WriteLine(prices.Length);
            #endregion

            #region Question 9
            //if (TryGetPrice("Clean Code", out double price))
            //{
            //    Console.WriteLine(price);
            //}
            #endregion

            #region Question 10
            //PrintBookInfo("Clean Code");
            //PrintBookInfo("Clean Code",400);
            #endregion

            #region Question 11
            //PrintBookInfo(pages:400,title:"Clean Code");
            #endregion

            #region Question 12
            //PrintAllTitles("Clean Code", "C# in Depth", "Refactoring");
            #endregion
        }
    }
}
