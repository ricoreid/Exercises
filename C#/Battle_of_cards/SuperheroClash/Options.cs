using System;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Serialization;

namespace SuperheroClash
{
	public class Options
	{
		private readonly List<string> MainMenu = new List<string>() 
        { "Play with friend",
          "Play with computer",
          "Game rules",
          "Quit" 
        };
		public Options() {}


		public void MainMenuOptions()
        {
            for (int i = 0; i < MainMenu.Count; i++)
            {
                Console.WriteLine("{0}) {1}", i+1, MainMenu[i]);
            }
        }
	}
}


