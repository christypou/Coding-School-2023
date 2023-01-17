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
            Message message = new Message();
            StringBuilder str=new StringBuilder();
            switch (request.Action)
            {
                case ActionEnum.Convert:
                    decimal dec;
                    int integer;
                    if (Decimal.TryParse(request.Input, out dec))
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
                        ActionResponse response1 = new ActionResponse(Guid.NewGuid(), binary, request.RequestId);
                        str.Append("The number is decimal and the binary is :" + binary);
                        message.Messages=str.ToString();
                        return response1;
                    }
                    else if(int.TryParse(request.Input, out integer))
                    {
                        string binary = Convert.ToString(integer);
                        ActionResponse response2 = new ActionResponse(Guid.NewGuid(), binary, request.RequestId);
                        str.Append("The number is integer and the binary is :" + binary);
                        message.Messages = str.ToString();
                        return response2;
                    }
                    else
                    {
                      
                        return null;
                        str.Append("Wrong input!");
                        message.Messages = str.ToString();
                    }
                   
                    break;
                case ActionEnum.Uppercase:
                    int max = 0;
                    int wordnumber = 0;
                    string[] result = request.Input.Split(" ");
                    for (int i = 0; i < result.Length; i++)
                    {
                        if (result[i].Length > max)
                        {
                            max = result[i].Length;
                            wordnumber = i;
                        }
                    }
                    string upperCaseWord = result[wordnumber];
                    ActionResponse response3 = new ActionResponse(Guid.NewGuid(),upperCaseWord.ToUpper(), request.RequestId);
                    str.Append("The new text is :" + upperCaseWord);
                    message.Messages = str.ToString();
                    return response3;
                    break;
                case ActionEnum.Reverse:
                    char[] charArray = request.Input.ToCharArray();

                    string reversedString = String.Empty;

                    for (int i = charArray.Length - 1; i > -1; i--)
                    {
                        reversedString += charArray[i];
                    }
                    ActionResponse response4 = new ActionResponse(Guid.NewGuid(),reversedString, request.RequestId);
                    str.Append("The reversed text is :" + reversedString);
                    message.Messages = str.ToString();
                    return response4;
                    break;
                default:
                    return null;
                    break;
                    
            }
            
        }
    }

}
