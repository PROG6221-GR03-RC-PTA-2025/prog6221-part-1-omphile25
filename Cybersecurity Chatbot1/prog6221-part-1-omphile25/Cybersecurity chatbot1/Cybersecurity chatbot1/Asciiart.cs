using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_chatbot1
{
    class Asciiart
    {

        public static void Display()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
|-----------------------------------------------|
|   ██████╗ ██████╗ ███████╗████████╗███████╗   |
|   ██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔════╝   |
|   ██████╔╝██████╔╝█████╗     ██║   █████╗     |
|   ██╔═══╝ ██╔═══╝ ██╔══╝     ██║   ██╔══╝     |
|   ██║     ██║     ███████╗   ██║   ███████╗   |
|   ╚═╝     ╚═╝     ╚══════╝   ╚═╝   ╚══════╝   |
|   Cybersecurity Awareness Bot                 |
|   Protect Yourself, Stay Vigilant! 🛡️         |
|------------------------------------------------|

        ");
            Console.ResetColor();
            Console.WriteLine();

        }
    }
}
