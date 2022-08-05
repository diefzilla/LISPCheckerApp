namespace LISP.Library
{
    public class LISPChecker
    {
        public static bool IsLispValid(string input)
        {
            int openCount = input.Where(x => (x == '(')).Count();
            int closedCount = input.Where(x => (x == ')')).Count();

            //Exit early if open and closed parenthesis count doesn't match
            if (closedCount != openCount) return false;

            string inputStore = string.Empty;
            while(input.Length != inputStore.Length)
            {
                inputStore = input;
                input = input.Replace("()", string.Empty);
            }
            

            return (input.Length==0);
        }
    }
}