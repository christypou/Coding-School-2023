using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // “Convert” you must check if the Input is a decimal number and convert it to binary.
            // ...
            //decimal dec;
            //int integer;
            //if (Decimal.TryParse(request.Input, out dec))
            //{
            //    string binary;
            //    int num = Convert.ToInt32(dec);
            //    binary = "";
            //    while (num > 1)
            //    {

            //        int remainder = num % 2;
            //        binary = Convert.ToString(remainder) + binary;
            //        num /= 2;
            //    }
            //    binary = Convert.ToString(num) + binary;
            //str.Append("The number is decimal and the binary is :" + binary);
            //message.Messages=str.ToString();

            //}
            //else if(int.TryParse(request.Input, out integer))
            //{
            //    string binary = Convert.ToString(integer);
            //    //str.Append("The number is integer and the binary is :" + binary);
            //    //message.Messages = str.ToString();
            //    return null;
            //}
            //else
            //{

            //    return null;
            //    //str.Append("Wrong input!");
            //    //message.Messages = str.ToString();
            //}

            return string.Empty;
        }
    }

    public class StringReverse : StringManipulator
    {

        public override string Manipulate()
        {
            //char[] charArray = request.Input.ToCharArray();

            //string reversedString = String.Empty;

            //for (int i = charArray.Length - 1; i > -1; i--)
            //{
            //    reversedString += charArray[i];
            //}
            //str.Append("The reversed text is :" + reversedString);
            //message.Messages = str.ToString();
            return string.Empty;
        }

    }

    public class StringUppercase : StringManipulator
    {

        public override string Manipulate()
        {
            //int max = 0;
            //int wordnumber = 0;
            //string[] result = request.Input.Split(" ");
            //for (int i = 0; i < result.Length; i++)
            //{
            //    if (result[i].Length > max)
            //    {
            //        max = result[i].Length;
            //        wordnumber = i;
            //    }
            //}
            //string upperCaseWord = result[wordnumber];
            //str.Append("The new text is :" + upperCaseWord);
            //message.Messages = str.ToString();
            return string.Empty;
        }
    }
}
