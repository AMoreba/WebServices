using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServicee
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //sort the numbers in increasing order
        public string sort(string n)
        {
            //remove the commas
            String[] arrayNums = n.Split(',');
            int arraylength = arrayNums.Length;
            int[] numsArray = new int[arraylength];
            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = Convert.ToInt32(arrayNums[i]);
            }

            //call the function again till the commas are gone
            Array.Sort(numsArray);

            //sort the numbers and seperate them by commas
            String result = "";
            for (int i = 0; i < arraylength; i++)
            {
                if (i == arraylength - 1)
                {
                    result = result + numsArray[i].ToString();
                }
                else
                {
                    result = result + numsArray[i].ToString() + ",";
                }
            }
            return result;
        }

        //convert to C
        public int f2c(int f)
        {
            int c = Convert.ToInt32((f - 32) * 0.56);
            return c;
        }

        //convert to F
        public int c2f(int c)
        {
            int f = Convert.ToInt32((c * 1.8) + 32);
            return f;
        }
        
    }
}
