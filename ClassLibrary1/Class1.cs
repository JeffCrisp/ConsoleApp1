using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace ClassLibrary1
{
    public class Class1
    {
        private int _maxNumber = 0;
        public  Class1(int maxNumber)
        {
            
            _maxNumber = maxNumber;

        }

        public string RTNINfo()
        {

            //return all the way up to int.maxvalue
            //add a unit test where it doesn't break the 3 and 5 case so it will return fizz, buzz;
          
            JObject rtn = new JObject();
            string line = string.Empty;

            for (int x = 1; x <= _maxNumber; x++)
            {
                bool mod = false;

                if ((x % 3) == 0)
                {
                    line = "Fizz";

                    mod = true;


                }

                if ((x % 5) == 0)
                {
                   
               
                    if (line != string.Empty)
                    {
                        line = line + " " + "Buzz";

                    }
                    else
                    {

                        line = "Buzz";
                    }

                mod = true;
            }
                   
                  
               if(mod == false)
                {
                    line = x.ToString();
                   
                }

                rtn.Add(new JProperty(x.ToString(),line));
                mod = false;
                line = string.Empty;

        }

            return JsonConvert.SerializeObject(rtn);


        }


    }
}
