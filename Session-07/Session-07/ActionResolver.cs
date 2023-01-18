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
                        
                        return null;
                      

                        break;
                    case ActionEnum.Uppercase:
                        response.Output = Uppercase(request.Input);
                        
                        return null;
                        break;
                    case ActionEnum.Reverse:
                        response.Output = Reverse(request.Input);
                        
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

        private void Log(string text)
        {

            Message message = new Message(text);
            Logger.Write(message);
        }
    }

}
