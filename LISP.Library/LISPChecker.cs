using System.Text.RegularExpressions;

namespace LISP.Library
{
    public class LISPChecker
    {
        public static bool IsLispValid(string input)
        {
          
            //Exit early if open and closed parenthesis count doesn't match
            if (input.Where(x => (x == '(')).Count() != input.Where(x => (x == ')')).Count()) 
                return false;


            //Remove the characters and leave the parentheses
            string parentheses = string.Empty;
            foreach (char c in input)
            {
                if (c == '(' || c == ')')
                    parentheses += c;
            }

            //Remove each matching pair of parentheses.
            //If all parentheses are closed correctly the parentheses string will be empty.
            string lastString = string.Empty;
            while(parentheses.Length != lastString.Length)
            {
                lastString = parentheses;
                parentheses = parentheses.Replace("()", string.Empty);
            }

            return (parentheses.Length==0);
        }
    }
}