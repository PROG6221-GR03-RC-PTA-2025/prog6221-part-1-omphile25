using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_chatbot1
{
    class Chatbot
    {

        // Dictionary to store chatbot Q&A
        public static readonly Dictionary<string, string> chatbotResponses = new Dictionary<string, string>()
    {
        { "how are you?", "I'm just a bot, but I'm here to help!" },
        { "what's your purpose?", "My purpose is to help you learn about cybersecurity and stay safe online." },
        { "what can i ask about?", "You can ask me about topics like password safety, phishing, safe browsing, suspicious links, VPNs, ransomware, and more!" },
        { "password safety", "Use strong passwords with a mix of uppercase, lowercase, numbers, and symbols." },
        { "phishing", "Be cautious of emails or messages requesting personal information. Verify sender identities." },
        { "safe browsing", "Safe browsing involves practices like avoiding suspicious websites, not clicking on untrusted links, and using an updated browser with security features. Use secure websites (HTTPS) and avoid entering sensitive data on public Wi-Fi." },
        { "what should i do if i suspect a phishing email?", "If you suspect a phishing email, do not click on any links or download attachments. Report the email to your IT department or email provider, and delete it immediately." },
        { "how can i create a strong password?", "A strong password should include a mix of uppercase and lowercase letters, numbers, and symbols. Make sure it’s at least 12 characters long and avoid common words." },
    };
        // Chatbot interaction
        public void StartChat()
        {
            // Welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=============================================================================");
            Console.WriteLine(" Welcome to the Cybersecurity Awareness Bot");
            Console.WriteLine("=============================================================================");
            Console.ResetColor();

            // Request user name with a nice header
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Bot: Please enter your name: ");
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User:");
            string userName = Console.ReadLine()?.Trim();
            
            // Validate that the user provides a name
            while (string.IsNullOrEmpty(userName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Bot: Name cannot be empty. Please enter your name.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("User:");
                Console.ResetColor();

                userName = Console.ReadLine()?.Trim();
                Console.WriteLine("================================================================================");

            }
            // Handle user input
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n Bot: Hello, {userName}! Welcome to the Cybersecurity Awareness Bot. I am here to help you stay safe online.");
            Console.WriteLine(" Bot: You can ask me about topics like password safety, phishing, and safe browsing.");
            Console.WriteLine(" Bot: Type 'exit' to end the chat.\n");
            Console.ResetColor();

            // Ask casual questions before moving on to cybersecurity topics
            AskCasualQuestions();

            // Chat loop for cybersecurity-related questions
            while (true)
            {
                // User input with a styled prompt
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bot: Ask me something about cybersecurity: ");
                Console.ResetColor();

                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Bot: Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }
                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(" Bot: Goodbye! Stay safe online and remember to always verify emails before clicking links.");
                    Console.ResetColor();
                    break;
                }

                // Handle response based on user input
                var responseHandler = new ResponseHandler();
                responseHandler.HandleResponse(userInput);
            }
        }
        // Method to ask casual questions like "How are you?"
        private void AskCasualQuestions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("User: ");
            Console.ResetColor();

            string response = Console.ReadLine()?.Trim().ToLower();
            if (string.IsNullOrEmpty(response))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: I'm just a bot, thank you for asking!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Bot: I'm glad to hear you're {response}! Let's dive into cybersecurity.");
            }
            Console.ResetColor();
        }
    }

}
        
    

