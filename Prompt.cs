using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace No_Edge
{
	class Prompt
	{
		public string Text;
		public string Options;

		public Prompt(string promptText, string promptOptions)
		{
			Text = promptText;
			Options = promptOptions;
		}

		public void RunPrompt()
		{
			Write(Text);
			Write(Options);
		}
	}
}