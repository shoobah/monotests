
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Alignment alignment1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label label1;
	private global::Gtk.Button button1;
	private global::Gtk.Entry entry1;
	private global::Gtk.SpinButton spinbutton1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Testlåda");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-color-picker", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.BorderWidth = ((uint)(1));
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		// Container child alignment1.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w1.X = 92;
		w1.Y = 73;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		// Container child button1.Gtk.Container+ContainerChild
		global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w3 = new global::Gtk.HBox ();
		w3.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w4 = new global::Gtk.Image ();
		w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-about", global::Gtk.IconSize.Menu);
		w3.Add (w4);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w6 = new global::Gtk.Label ();
		w6.LabelProp = global::Mono.Unix.Catalog.GetString ("_Yes");
		w6.UseUnderline = true;
		w3.Add (w6);
		w2.Add (w3);
		this.button1.Add (w2);
		this.fixed1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
		w10.X = 15;
		w10.Y = 65;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w11.X = 18;
		w11.Y = 13;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.spinbutton1 = new global::Gtk.SpinButton (0, 100, 1);
		this.spinbutton1.CanFocus = true;
		this.spinbutton1.Name = "spinbutton1";
		this.spinbutton1.Adjustment.PageIncrement = 10;
		this.spinbutton1.ClimbRate = 1;
		this.spinbutton1.Numeric = true;
		this.fixed1.Add (this.spinbutton1);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.spinbutton1]));
		w12.X = 187;
		w12.Y = 11;
		this.alignment1.Add (this.fixed1);
		this.Add (this.alignment1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 552;
		this.DefaultHeight = 339;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler (this.YesClicked);
	}
}
