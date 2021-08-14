using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace VogCodeChallenge.QuestionClass
{
    public static class QuestionClass
    {
      static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

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
                

    public static object TESTModule(object o)
        {
            int result; float floatValue;
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result) && 
                                            (result >= 1) && (result <= 4)):
                     result = result * 2;                    
                    return result;

                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result)
                                            &&(result > 4 )):
                     result = result * 3;                  
                    return result;

                case TypeCode.String when (int.TryParse(Convert.ToString(o), out result) 
                                            && result < 1):
                    throw new ArgumentOutOfRangeException();
                                     
                case TypeCode.String when (float.TryParse(Convert.ToString(o), out floatValue) && 
                            (floatValue.Equals(1.0f)) || (floatValue.Equals(2.0f))):
                    floatValue = 3.0f;
                   return floatValue;
                   
                case TypeCode.String:

                    return o.ToString().ToUpper();
                default:
                    return o;
                
            }
        }
      
    }

}
