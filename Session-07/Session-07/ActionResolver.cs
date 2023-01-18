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
            Log("Program started");
            try
            {
                switch (request.Action)
                {
                    case ActionEnum.Convert:
                        Log("Convert");
                        response.Output = Convert(request.Input);
                        Log(response.Output);
                        break;
                    case ActionEnum.Uppercase:
                        Log("Uppercase");
                        response.Output = Uppercase(request.Input);
                        Log(response.Output);
                        break;
                    case ActionEnum.Reverse:
                        Log("Reverse");
                        response.Output = Reverse(request.Input);
                        Log(response.Output);
                        break;
                    default:
                        Log("Something went wrong!");
                        break;

                }
            }
            catch (Exception ex) {
                Log(ex.Message);
            }
            finally {
                Log("Programm end");
            }
            return response; ;
        }


        public string Convert(string input)
        {

            StringConvert convert = new StringConvert();
            convert.Text = input;

            return convert.Manipulate();
        }

        public string Uppercase(string input)
        {
            StringUppercase upperCase= new StringUppercase();
            upperCase.Text = input;
            return upperCase.Manipulate();
           }

        public string Reverse(string input)
        {

            StringReverse reverse = new StringReverse();
            reverse.Text = input;
            return reverse.Manipulate();
        }

        private void Log(string text)
        {

            Message message = new Message(text);
            Logger.Write(message);
        }
    }

}
