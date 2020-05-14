using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//Ascii for title words retrieved from http://www.network-science.de/ascii/
namespace No_Edge
{
	class Program
	{
		static void Main(string[] args)
		{
			WindowWidth = 100;
			Title = "No Edge";
			Game currentGame = new Game();
			currentGame.TitleScreen();
		}
	}
}
