
// This file has been generated by the GUI designer. Do not modify.

public partial class PackageViewerWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action convertAction;
	
	private global::Gtk.Action ViewAction;
	
	private global::Gtk.ToggleAction subtexturesAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar;
	
	private global::Psiga.PackageWidget packagewidget1;
	
	private global::Gtk.Statusbar statusbar;
	
	private global::Gtk.ProgressBar progressbar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget PackageViewerWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Select Transistor Package Directory"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Select Transistor Data Directory");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("Export All Textures For Editing"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Export All Files For Editing");
		w1.Add (this.saveAction, null);
		this.convertAction = new global::Gtk.Action ("convertAction", global::Mono.Unix.Catalog.GetString ("Convert Directory To Package"), null, "gtk-convert");
		this.convertAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Convert Files To Package");
		w1.Add (this.convertAction, null);
		this.ViewAction = new global::Gtk.Action ("ViewAction", global::Mono.Unix.Catalog.GetString ("View"), null, null);
		this.ViewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("View");
		w1.Add (this.ViewAction, null);
		this.subtexturesAction = new global::Gtk.ToggleAction ("subtexturesAction", global::Mono.Unix.Catalog.GetString ("Subtextures"), null, null);
		this.subtexturesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Subtextures");
		w1.Add (this.subtexturesAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "PackageViewerWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Psiga Package Viewer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child PackageViewerWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='convertAction' action='convertAction'/></menu><menu name='ViewAction' action='ViewAction'><menuitem name='subtexturesAction' action='subtexturesAction'/></menu></menubar></ui>");
		this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar")));
		this.menubar.Name = "menubar";
		this.vbox1.Add (this.menubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.packagewidget1 = new global::Psiga.PackageWidget ();
		this.packagewidget1.Events = ((global::Gdk.EventMask)(256));
		this.packagewidget1.Name = "packagewidget1";
		this.vbox1.Add (this.packagewidget1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.packagewidget1]));
		w3.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar = new global::Gtk.Statusbar ();
		this.statusbar.Name = "statusbar";
		this.statusbar.Spacing = 6;
		// Container child statusbar.Gtk.Box+BoxChild
		this.progressbar = new global::Gtk.ProgressBar ();
		this.progressbar.Name = "progressbar";
		this.statusbar.Add (this.progressbar);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.statusbar [this.progressbar]));
		w4.Position = 1;
		this.vbox1.Add (this.statusbar);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1550;
		this.DefaultHeight = 718;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
