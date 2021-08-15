using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace VogCodeChallenge.QuestionClass
{
    public static class QuestionClass
    {
        //Q7: Iterating through the NamesList items without using ForEach/For loops
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
        
        //this method iterate through the nameList and return all values within it
        public static void DisplayName()
        {
            int i = 0;
            Console.WriteLine("Names in the list includes:");
            do
            {
                Console.WriteLine(i+1 + ". " +NamesList[i]);
                i++;
            } while (i < NamesList.Count); ;
        }

        //Q8: TESTModule (using switch statement)
        public static object TESTModule(object o)
        {
            int result; float floatValue;
            switch (Type.GetTypeCode(o.GetType()))
            {
                //integer values from 1-4 (multiply by 2)
                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result) && 
                                            (result >= 1) && (result <= 4)):
                     result = result * 2;                    
                    return result;

                //integer values greater than 4 (multiply by 3)
                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result)
                                            &&(result > 4 )):
                     result = result * 3;                  
                    return result;

                //integer value less than 1 (throw exception)
                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result) 
                                            && result < 1):
                    throw new ArgumentOutOfRangeException();
                
                 //float values of 1.0f $ 2.0f (return 3.0f)
                case TypeCode.String when (float.TryParse(Convert.ToString(o), out floatValue) && 
                            (floatValue.Equals(1.0f)) || (floatValue.Equals(2.0f))):
                    floatValue = 3.0f;
                   return floatValue;

                //string values (convert to upper case)
                case TypeCode.String:

                    return o.ToString().ToUpper();

                //others (return value)
                default:
                    return o;
                
            }
        }
      
    }

}
