using System;
using Gtk;
using Newtonsoft.Json;
using Test1;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void YesClicked (object sender, EventArgs e)
	{
		var thing=new poco(){number=spinbutton1.Value, text=entry1.Text};
		label1.Text=JsonConvert.SerializeObject(thing);
	}


}
