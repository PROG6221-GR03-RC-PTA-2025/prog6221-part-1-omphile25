using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cybersecurity_chatbot1
{
    class ResponseHandler
    {
        // Handle responses to the user's input
        public void HandleResponse(string userInput)
        {
            if (Chatbot.chatbotResponses.ContainsKey(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Bot: {Chatbot.chatbotResponses[userInput]}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bot: Sorry, I didn't understand that. Please ask about cybersecurity topics.");
                Console.ResetColor();
            }
        }

        // Simulated typing effect with slight delay
        private void TypeEffect(string message, int delay)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();

        }

    }
}
