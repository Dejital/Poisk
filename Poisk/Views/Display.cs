using System;
using System.Collections.Generic;

namespace Poisk.Views
{
    /// <summary>
    /// This class handles displaying information to the user and prompting user for input.
    /// </summary>
    internal class Display
    {
        public Display()
        {
            ShowGreeting();
            PlayerName = GetPlayerName();
        }
        
        /// <summary>
        /// The player character's name.
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        /// Prompts a player to respond with a valid response and return said response.
        /// </summary>
        /// <returns></returns>
        public string PromptForValidResponse(List<string> validResponses)
        {
            var response = "";
            while (!validResponses.Contains(response))
            {
                response = GetNonEmptyStringResponse("");
            }
            Console.Beep(392, 500);
            return response;
        }

        /// <summary>
        /// Displays a message on screen.
        /// </summary>
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            System.Threading.Thread.Sleep(1000);
        }

        private void ShowGreeting()
        {
            Console.WriteLine("Welcome to Poisk.");
        }

        private string GetPlayerName()
        {
            var response = GetNonEmptyStringResponse("What is your name?");
            Console.Beep(392, 500);
            return response;
        }

        /// <summary>
        /// Prompts the user with a provided message and requires a non-empty response.
        /// </summary>
        private string GetNonEmptyStringResponse(string message)
        {
            var response = "";
            while (string.IsNullOrEmpty(response))
            {
                Console.Beep(262, 500);
                Console.Write(GetPromptMessage(message));
                response = Console.ReadLine();
            }
            return response;
        }

        /// <summary>
        /// Returns a prompt with an included message, if specified.
        /// </summary>
        private string GetPromptMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
                return GetPromptMessage();

            return message + "\n" + GetPromptMessage();
        }

        /// <summary>
        /// Returns a prompt with no message.
        /// </summary>
        private string GetPromptMessage()
        {
            return "> ";
        }
    }
}
