// This file has been generated by the GUI designer. Do not modify.
using Gdk;
using Gtk;
using Mono.Unix;
using Stetic;
using Image = Gtk.Image;

namespace FloydPink.Flickr.Downloadr {
    public partial class AboutWindow {
        private Alignment alignment1;
        private Alignment alignment2;
        private Alignment alignment6;
        private Alignment alignment7;
        private Button buttonClose;
        private EventBox eventboxHyperlink;
        private HBox hbox5;
        private HBox hbox6;
        private HBox hbox7;
        private Image image2;
        private Label labelLink;
        private Label labelVersion;
        private VBox vbox3;
        private VBox vbox4;
        private VBox vbox5;

        protected virtual void Build() {
            Gui.Initialize(this);
            // Widget FloydPink.Flickr.Downloadr.AboutWindow
            WidthRequest = 360;
            HeightRequest = 220;
            Name = "FloydPink.Flickr.Downloadr.AboutWindow";
            Title = Catalog.GetString("About - flickr downloadr");
            Icon = Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.Assets.icon.png");
            TypeHint = ((WindowTypeHint) (1));
            WindowPosition = ((WindowPosition) (3));
            Modal = true;
            Resizable = false;
            AllowGrow = false;
            // Container child FloydPink.Flickr.Downloadr.AboutWindow.Gtk.Container+ContainerChild
            this.vbox3 = new VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.vbox4 = new VBox();
            this.vbox4.Name = "vbox4";
            this.vbox4.Homogeneous = true;
            this.vbox4.Spacing = 6;
            // Container child vbox4.Gtk.Box+BoxChild
            this.hbox7 = new HBox();
            this.hbox7.Name = "hbox7";
            this.hbox7.Spacing = 6;
            // Container child hbox7.Gtk.Box+BoxChild
            this.alignment6 = new Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment6.Name = "alignment6";
            this.hbox7.Add(this.alignment6);
            var w1 = ((Box.BoxChild) (this.hbox7[this.alignment6]));
            w1.Position = 0;
            // Container child hbox7.Gtk.Box+BoxChild
            this.image2 = new Image();
            this.image2.Name = "image2";
            this.image2.Pixbuf = Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.Assets.logo-Small-About.png");
            this.hbox7.Add(this.image2);
            var w2 = ((Box.BoxChild) (this.hbox7[this.image2]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox7.Gtk.Box+BoxChild
            this.alignment7 = new Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment7.Name = "alignment7";
            this.hbox7.Add(this.alignment7);
            var w3 = ((Box.BoxChild) (this.hbox7[this.alignment7]));
            w3.Position = 2;
            this.vbox4.Add(this.hbox7);
            var w4 = ((Box.BoxChild) (this.vbox4[this.hbox7]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox4.Gtk.Box+BoxChild
            this.labelVersion = new Label();
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.LabelProp = Catalog.GetString("flickr downloadr");
            this.labelVersion.UseMarkup = true;
            this.vbox4.Add(this.labelVersion);
            var w5 = ((Box.BoxChild) (this.vbox4[this.labelVersion]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox3.Add(this.vbox4);
            var w6 = ((Box.BoxChild) (this.vbox3[this.vbox4]));
            w6.Position = 0;
            // Container child vbox3.Gtk.Box+BoxChild
            this.vbox5 = new VBox();
            this.vbox5.Name = "vbox5";
            this.vbox5.Homogeneous = true;
            this.vbox5.Spacing = 6;
            // Container child vbox5.Gtk.Box+BoxChild
            this.hbox6 = new HBox();
            this.hbox6.Name = "hbox6";
            this.hbox6.Spacing = 6;
            // Container child hbox6.Gtk.Box+BoxChild
            this.alignment1 = new Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment1.Name = "alignment1";
            this.hbox6.Add(this.alignment1);
            var w7 = ((Box.BoxChild) (this.hbox6[this.alignment1]));
            w7.Position = 0;
            // Container child hbox6.Gtk.Box+BoxChild
            this.eventboxHyperlink = new EventBox();
            this.eventboxHyperlink.Name = "eventboxHyperlink";
            // Container child eventboxHyperlink.Gtk.Container+ContainerChild
            this.labelLink = new Label();
            this.labelLink.Name = "labelLink";
            this.labelLink.LabelProp =
                Catalog.GetString("<b><big><span color=\"blue\">http://flickrdownloadr.com</span></big></b>");
            this.labelLink.UseMarkup = true;
            this.labelLink.UseUnderline = true;
            this.eventboxHyperlink.Add(this.labelLink);
            this.hbox6.Add(this.eventboxHyperlink);
            var w9 = ((Box.BoxChild) (this.hbox6[this.eventboxHyperlink]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child hbox6.Gtk.Box+BoxChild
            this.alignment2 = new Alignment(0.5F, 0.5F, 1F, 1F);
            this.alignment2.Name = "alignment2";
            this.hbox6.Add(this.alignment2);
            var w10 = ((Box.BoxChild) (this.hbox6[this.alignment2]));
            w10.Position = 2;
            this.vbox5.Add(this.hbox6);
            var w11 = ((Box.BoxChild) (this.vbox5[this.hbox6]));
            w11.Position = 1;
            w11.Expand = false;
            w11.Fill = false;
            // Container child vbox5.Gtk.Box+BoxChild
            this.hbox5 = new HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Homogeneous = true;
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.buttonClose = new Button();
            this.buttonClose.WidthRequest = 50;
            this.buttonClose.CanFocus = true;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.UseUnderline = true;
            this.buttonClose.Label = Catalog.GetString("Close");
            this.hbox5.Add(this.buttonClose);
            var w12 = ((Box.BoxChild) (this.hbox5[this.buttonClose]));
            w12.Position = 2;
            w12.Expand = false;
            w12.Fill = false;
            this.vbox5.Add(this.hbox5);
            var w13 = ((Box.BoxChild) (this.vbox5[this.hbox5]));
            w13.Position = 2;
            w13.Expand = false;
            w13.Fill = false;
            this.vbox3.Add(this.vbox5);
            var w14 = ((Box.BoxChild) (this.vbox3[this.vbox5]));
            w14.Position = 1;
            Add(this.vbox3);
            if ((Child != null)) {
                Child.ShowAll();
            }
            DefaultWidth = 400;
            DefaultHeight = 300;
            Show();
            this.eventboxHyperlink.ButtonPressEvent += eventboxHyperlinkClicked;
            this.buttonClose.Clicked += buttonCloseClick;
        }
    }
}
