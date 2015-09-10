using System;
using System.Collections.Generic;
using Poisk.Common;

namespace Poisk.Views
{
    /// <summary>
    /// This class handles displaying information to the user and prompting user for input.
    /// </summary>
    internal class Display
    {
        /// <summary>
        /// Displays a message on screen.
        /// </summary>
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            System.Threading.Thread.Sleep(1000);
        }

        /// <summary>
        /// Prompts a player to respond with a valid response and return said response.
        /// </summary>
        /// <returns></returns>
        public string PromptUserForValidResponse(List<string> validResponses)
        {
            var response = "";
            while (!validResponses.Contains(response))
            {
                response = GetResponseFromUser();
            }
            PlayChime(Chime.High);
            return response;
        }

        /// <summary>
        /// Prompts the user with a provided message and requires a non-empty response.
        /// </summary>
        public string PromptUserForNonEmptyStringResponse(string message, bool playSuccessChime = false)
        {
            var response = "";
            while (string.IsNullOrEmpty(response))
            {
                Console.WriteLine(message);
                response = GetResponseFromUser();
            }

            if (playSuccessChime)
                PlayChime(Chime.High);

            return response;
        }

        /// <summary>
        /// Prompts the user for input and returns the response.
        /// </summary>
        /// <returns></returns>
        private string GetResponseFromUser()
        {
            PlayChime(Chime.Medium);
            Console.Write("> ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Plays a beep based on the given chime.
        /// </summary>
        private void PlayChime(Chime chime)
        {
            switch (chime)
            {
                case Chime.High:
                    Console.Beep(392, 500);
                    break;
                case Chime.Medium:
                    Console.Beep(262, 500);
                    break;
                case Chime.Low:
                    Console.Beep(220, 500);
                    break;
            }
        }
    }
}
