using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Session_07
{
    public class StringManipulator
    {

        public string Text { get; set; }

        public virtual string Manipulate()
        {

            return string.Empty;
        }

    }

    public class StringConvert : StringManipulator
    {


        public override string Manipulate()
        {

            decimal dec;
            int integer;
            if (Decimal.TryParse(Text, out dec))
            {
                string binary;
                int num = Convert.ToInt32(dec);
                binary = "";
                while (num > 1)
                {

                    int remainder = num % 2;
                    binary = Convert.ToString(remainder) + binary;
                    num /= 2;
                }
                binary = Convert.ToString(num) + binary;
                string mess = "The number is decimal and the binary is :" + binary;
                return mess;
                }
            else if (int.TryParse(Text, out integer))
            {
                string binary = Convert.ToString(integer);
                //str.Append("The number is integer and the binary is :" + binary);
                //message.Messages = str.ToString();
                string mess = "The number is integer and the binary is :" + binary;
                return mess;
            }
            else
            {
                string mess = "Wrong input!";
                return mess;
                
                
            }

         
        }
    }

    public class StringReverse : StringManipulator
    {

        public override string Manipulate()
        {
            char[] charArray = Text.ToCharArray();

            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            string mess = "The reversed text is :" + reversedString;
            return mess;
        }

    }

    public class StringUppercase : StringManipulator
    {

        public override string Manipulate()
        {
            
            int max = 0;
            int wordnumber = 0;
            string[] result = Text.Split(" ");
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length > max)
                {
                    max = result[i].Length;
                    wordnumber = i;
                }
            }
            string upperCaseWord = result[wordnumber];
            string mess = "The new text is :" + upperCaseWord.ToUpper();

            return mess;
        }
    }
}
