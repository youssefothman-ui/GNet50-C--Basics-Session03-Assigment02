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

             string title = "Clean Code";
            int pages = 464;

            string sentence = "Book: " + title + ", Pages: " + pages;

            Console.WriteLine(sentence);
            #endregion



        }
    }
}
