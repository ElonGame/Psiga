
// This file has been generated by the GUI designer. Do not modify.
namespace Psiga
{
	public partial class TreeviewPaneWidget
	{
		private global::Gtk.HPaned hpaned3;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeview;
		
		private global::Gtk.VBox rightPane;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Psiga.TreeviewPaneWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Psiga.TreeviewPaneWidget";
			// Container child Psiga.TreeviewPaneWidget.Gtk.Container+ContainerChild
			this.hpaned3 = new global::Gtk.HPaned ();
			this.hpaned3.CanFocus = true;
			this.hpaned3.Name = "hpaned3";
			this.hpaned3.Position = 466;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview = new global::Gtk.TreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.GtkScrolledWindow.Add (this.treeview);
			this.hpaned3.Add (this.GtkScrolledWindow);
			global::Gtk.Paned.PanedChild w2 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.GtkScrolledWindow]));
			w2.Resize = false;
			// Container child hpaned3.Gtk.Paned+PanedChild
			this.rightPane = new global::Gtk.VBox ();
			this.rightPane.Name = "rightPane";
			this.rightPane.Spacing = 6;
			this.hpaned3.Add (this.rightPane);
			this.Add (this.hpaned3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}