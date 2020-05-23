using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RPGConsoleTry.Game
{
    public class GameService
    {
        public void StartGame()
        {
            // Variables
            //*********************************************************************************************
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var currentAdventure = new Adventures.Adventure();
            //*********************************************************************************************

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    currentAdventure = JsonConvert.DeserializeObject<Adventures.Adventure>(fi.ReadToEnd());
                }

                Console.WriteLine($"Adventure   : {currentAdventure.Title}");
                Console.WriteLine($"Description : {currentAdventure.Description}");
                Console.ReadKey();
            }

        }
    }
}
