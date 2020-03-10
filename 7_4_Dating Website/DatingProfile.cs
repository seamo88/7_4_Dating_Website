using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4_Dating_Website
{
    class DatingProfile
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        //.........................................................................

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }
        //.........................................................................
        public void WriteBio(string text)
        { bio = text; }

        public void AddToInbox(Messages messages)
        { myMessages.Add(messages); }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessages()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)

                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }
}
            

           


    

