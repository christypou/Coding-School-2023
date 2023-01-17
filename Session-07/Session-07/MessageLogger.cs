using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class MessageLogger
    {

        public Message[] messages = new Message[10000];


        public void ReadAll()
        {
            foreach (var item in messages)
            {
                Console.WriteLine(item);
            }
        }
        public void Clear()
        {
            messages = new Message[10000];
        }
        public void Write(Message message)
        {

        }


    }
}
