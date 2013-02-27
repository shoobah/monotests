using System;
using Gtk;

namespace Test1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}

		private void DoStuff ()
		{

		}
	}
}
