using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	private int i;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		i=0;
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnClick (object sender, EventArgs e)
	{
		progressbar1.Pulse();
		i++;
		progressbar1.Text=i.ToString();
	}

}
