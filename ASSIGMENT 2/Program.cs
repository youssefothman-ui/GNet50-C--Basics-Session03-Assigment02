using System.Text;

namespace ASSIGMENT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 - String ToUpper
            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion


            #region Q2
            // Declare two separate strings with the same literal.
            // Use ReferenceEquals() to check if they point to the same object.

            //string str1 = "Clean Code";
            //string str2 = "Clean Code";

            //Console.WriteLine(ReferenceEquals(str1, str2));
            #endregion


            #region Q3
            // Create a StringBuilder, Append "Book List",
            // then Append " - Updated" onto the same object.

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine(sb);
            #endregion



            #region Q4
            // Using the StringBuilder above, Replace "Book List" with "Library".

            //sb.Replace("Book List", "Library");

            //Console.WriteLine(sb);
            #endregion


            #region Q5
            // Given title = "Clean Code" and pages = 464,
            // build the sentence using the + operator.

            //string title = "Clean Code";
            //int pages = 464;

            //string sentence = "Book: " + title + ", Pages: " + pages;

            //Console.WriteLine(sentence);
            #endregion


            #region Q6
            // Build the same sentence using string interpolation ($"...").

            //string sentence2 = $"Book: {title}, Pages: {pages}";

            //Console.WriteLine(sentence2);
            #endregion




            #region Q7
            // Build the same sentence using string.Format().

            //string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);

            //Console.WriteLine(sentence3);
            #endregion

            #region Q8
            // Given pages = 464, write an if/else statement.
            // Print "Long Book" if pages > 300, otherwise "Short Book".

            //int pages = 464;

            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion


            #region Q9
            // Given pages = 464 and isAvailable = true,
            // print the message only if both conditions are true using &&.

            // int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion


            #region Q10
            // Given title = "Refactoring", write a switch statement.
            // Clean Code: Great choice!
            // Refactoring: Nice pick!
            // Anything else: Never heard of it.

            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion






        }
    }
}
