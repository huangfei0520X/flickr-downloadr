
// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr.UI.Widgets
{
	public partial class PreviewPhotoWidget
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Image imagePreview;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label labelCaption;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FloydPink.Flickr.Downloadr.UI.Widgets.PreviewPhotoWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "FloydPink.Flickr.Downloadr.UI.Widgets.PreviewPhotoWidget";
			// Container child FloydPink.Flickr.Downloadr.UI.Widgets.PreviewPhotoWidget.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.imagePreview = new global::Gtk.Image ();
			this.imagePreview.Name = "imagePreview";
			this.imagePreview.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("FloydPink.Flickr.Downloadr.UI.Assets.icon.png");
			this.vbox1.Add (this.imagePreview);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.imagePreview]));
			w1.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelCaption = new global::Gtk.Label ();
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.LabelProp = global::Mono.Unix.Catalog.GetString ("PhotoCaption");
			this.labelCaption.UseMarkup = true;
			this.hbox1.Add (this.labelCaption);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelCaption]));
			w2.Position = 0;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
