﻿using System;

namespace Poisk.Views
{
    /// <summary>
    /// This class handles displaying information to the user and prompting user for input.
    /// </summary>
    class Display
    {
        public Display()
        {
            PlayerName = GetPlayerName();
        }
        
        /// <summary>
        /// The player character's name.
        /// </summary>
        public string PlayerName { get; set; }

        private string GetPlayerName()
        {
            var name = "";
            while (string.IsNullOrEmpty(name))
            {
                var message = GetPromptMessage("What is your name?");
                Console.Write(message);
                name = Console.ReadLine();
            }
            return name;
        }

        private string GetPromptMessage(string message)
        {
            return message + "\n> ";
        }
    }
}