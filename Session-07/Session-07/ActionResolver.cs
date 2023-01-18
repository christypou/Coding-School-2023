using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Session_07
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
            Logger = new MessageLogger();
        }
        public ActionResponse Execute(ActionRequest request)
        {
            ActionResponse response = new ActionResponse();
            response.RequestId = request.RequestId;
            response.ResponseID = Guid.NewGuid();
            try
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        response.Output = Convert(request.Input);
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
                        return null;
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

                        break;
                    case ActionEnum.Uppercase:
                        response.Output = Uppercase(request.Input);
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
                        return null;
                        break;
                    case ActionEnum.Reverse:
                        response.Output = Reverse(request.Input);
                        //char[] charArray = request.Input.ToCharArray();

                        //string reversedString = String.Empty;

                        //for (int i = charArray.Length - 1; i > -1; i--)
                        //{
                        //    reversedString += charArray[i];
                        //}
                        //str.Append("The reversed text is :" + reversedString);
                        //message.Messages = str.ToString();
                        return null;
                        break;
                    default:
                        return null;
                        break;

                }
            }
            catch (Exception ex) { }
            finally { }
            return null;
        }


        public string Convert(string input)
        {

            StringConvert convert = new StringConvert();
            convert.Text = input;

            return convert.Manipulate();
        }

        public string Uppercase(string input)
        {
            // “Uppercase” you must check if the Input is a string and has more than
            // one words(separated by a space), then find the longest word in the
            // Input string and convert it to uppercase.



            return input.ToUpper();
        }

        public string Reverse(string input)
        {
            // “Reverse” you must check if the Input is a string and reverse it.

            return string.Empty;

        }
    }

}
