
// This file has been generated by the GUI designer. Do not modify.
namespace Psiga
{
	public partial class SubtexturesWindow
	{
		private global::Psiga.SubtexturesWidget subtextureswidget1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Psiga.SubtexturesWindow
			this.Name = "Psiga.SubtexturesWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("SubtexturesWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Psiga.SubtexturesWindow.Gtk.Container+ContainerChild
			this.subtextureswidget1 = new global::Psiga.SubtexturesWidget ();
			this.subtextureswidget1.Events = ((global::Gdk.EventMask)(256));
			this.subtextureswidget1.Name = "subtextureswidget1";
			this.Add (this.subtextureswidget1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 856;
			this.DefaultHeight = 617;
			this.Show ();
		}
	}
}