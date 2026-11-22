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

            string str1 = "Clean Code";
            string str2 = "Clean Code";

            Console.WriteLine(ReferenceEquals(str1, str2));
            #endregion




        }
    }
}
