
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button button2;
	private global::Gtk.ProgressBar progressbar1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.WidthRequest = 149;
		this.button2.HeightRequest = 27;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w1.X = 10;
		w1.Y = 8;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.progressbar1 = new global::Gtk.ProgressBar ();
		this.progressbar1.TooltipMarkup = "Progress";
		this.progressbar1.Name = "progressbar1";
		this.progressbar1.Text = global::Mono.Unix.Catalog.GetString ("progress");
		this.progressbar1.Ellipsize = ((global::Pango.EllipsizeMode)(2));
		this.fixed1.Add (this.progressbar1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.progressbar1]));
		w2.X = 10;
		w2.Y = 44;
		this.alignment1.Add (this.fixed1);
		this.Add (this.alignment1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 552;
		this.DefaultHeight = 339;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.OnClick);
	}
}
