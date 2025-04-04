using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Cybersecurity_chatbot1
{
    class VoiceGreetingHandler
    {
        public static void PlayVoiceGreeting()
        {
            string audioFilePath = Path.Combine("Omphile.wav"); // Path to the audio file
            try
            {
                using (SoundPlayer player = new SoundPlayer(audioFilePath))
                {
                    player.Load();
                    player.PlaySync(); // Play the audio file
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("⚠️ Voice greeting could not be played: " + e.Message);
            }
        }
    }
}


   