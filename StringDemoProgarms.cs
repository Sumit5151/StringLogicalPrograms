using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLogicalPrograms
{
    internal class StringDemoProgarms
    {


        public void ReverseEachWord()
        {
            string str = "Welcome in Pune City";

            var stringArray = str.Split(' ');

            for (int i = 0; i < stringArray.Length; i++)
            {
                ReverseString(stringArray[i]);
                Console.Write(" ");
            }
        }

        public void ReverseString(string str)
        {            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }



        public void PrintTheCharacterWhichOccursOneTime()
        {
            string str = "Hello World";           

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {

                    if(str[i] == str[j])
                    {
                        count++;
                    }
                }

                if(count == 1)
                {
                    Console.Write(str[i]);
                }

            }
        }




    }
}
