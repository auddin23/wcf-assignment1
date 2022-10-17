using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_assignment1_AAU
{

    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

   //Prime Number
        public string Check_Prime(int n)
            //fix this not right
        {
            int i;
            int m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    break;
                }
                if (i > m)
                {
                    return "Number is  Prime";
                }
                else
                {
                    return "Number is Prime";
                }
            }
            return "Number is not Prime";
        }



        //Sum of Digits
        public int Sum_Digit(int n)
        {
            int sum = 0, m;
            
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            return sum;
        }

        //Reverse String

        public string Reverse_String (string stringToReverse)
        {
            char[] characters = stringToReverse.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);

        }

        //Print HTML Tags
        public string Print_Tag(string tag, string data)
        {
            //<h1>Hello World</h1>
            //string.Format("<{1}>{2}</{1}>", tag, data);
            return string.Concat("<",tag,">", data,"</" ,tag,">");
        }

        //Sort data Asc-Dsc
        public int[] sorting(string sortType, int[] data)
        {
            
                Array.Sort(data);
      
            if (sortType == "Descending")
            {
                Array.Reverse(data);
            }
  
            return data;
    
        }
    }


}
