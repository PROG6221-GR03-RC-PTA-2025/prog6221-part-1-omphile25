﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_chatbot1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            // Display ASCII art
            Asciiart.Display();
            // Play voice greeting
            VoiceGreetingHandler.PlayVoiceGreeting();

            // Start chatbot interaction
            var chatbot = new Chatbot();
            chatbot.StartChat();

        }
    }
}
