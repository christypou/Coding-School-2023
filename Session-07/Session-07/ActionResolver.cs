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
        

        public ActionResponse Execute(ActionRequest request)
        {
            switch (request.Action)
            {
                case ActionEnum.Convert:
                    int number;
                    bool success = int.TryParse(request.Input, out number);
                    if (success)
                    {
                        //Console.WriteLine($"Converted '{value}' to {number}.");
                        ActionResponse response3 = new ActionResponse(number, request.RequestID);
                        return response3;
                    }
                    else
                    {
                        //Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
                        return null;
                    }
                    
                    return null;
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
                    ActionResponse response = new ActionResponse(upperCaseWord.ToUpper(), request.RequestID);
                    return response;
                    break;
                case ActionEnum.Reverse:
                    char[] charArray = request.Input.ToCharArray();

                    string reversedString = String.Empty;

                    for (int i = charArray.Length - 1; i > -1; i--)
                    {
                        reversedString += charArray[i];
                    }
                    ActionResponse response2 = new ActionResponse(reversedString, request.RequestID);
                    return response2;
                    break;
                default:
                    return null;
                    break;
                    
            }
            
        }
    }

}
