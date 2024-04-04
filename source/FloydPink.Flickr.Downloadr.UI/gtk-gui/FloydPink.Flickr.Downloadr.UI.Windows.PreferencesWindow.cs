
// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr.UI.Windows
{
	public partial class PreferencesWindow
	{
		private global::Gtk.VBox vbox9;

		private global::Gtk.Fixed fixed3;

		private global::Gtk.Label label3;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Alignment alignment4;

		private global::Gtk.VBox vbox11;

		private global::Gtk.VBox vbox12;

		private global::Gtk.Label labelFilename;

		private global::Gtk.Label labelDownloadLocation;

		private global::Gtk.Label labelDownloadSize;

		private global::Gtk.Label labelMetadata;

		private global::Gtk.Label label9;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label labelLogLocation;

		private global::Gtk.Label labelLogLevel;

		private global::Gtk.Label labelDonation;

		private global::Gtk.Label labelUpdate;

		private global::Gtk.Label labelCacheSize;

		private global::Gtk.Label labelCacheLocation;

		private global::Gtk.Label labelLocation;

		private global::Gtk.Label labelTags;

		private global::Gtk.Label labelSafetyLevel;

		private global::Gtk.Label labelPhotosPerPage;

		private global::Gtk.Label labelAlbumSearchName;

		private global::Gtk.VBox vbox13;

		private global::Gtk.HBox hbox3;

		private global::Gtk.RadioButton radioPhotoId;

		private global::Gtk.RadioButton radioOriginalOrder;

		private global::Gtk.RadioButton radioPhotoTitle;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Entry entryDownloadLocation;

		private global::Gtk.Button buttonDownloadLocation;

		private global::Gtk.ComboBox comboboxDownloadSize;

		private global::Gtk.HBox hbox8;

		private global::Gtk.CheckButton checkbuttonTags;

		private global::Gtk.CheckButton checkbuttonDescription;

		private global::Gtk.HBox hbox9;

		private global::Gtk.CheckButton checkbuttonTitle;

		private global::Gtk.Fixed fixed5;

		private global::Gtk.Label labelRestartRequired;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Entry entryLogLocation;

		private global::Gtk.Button buttonLogLocation;

		private global::Gtk.ComboBox comboboxLogLevel;

		private global::Gtk.CheckButton checkbuttonDonate;

		private global::Gtk.HBox hbox10;

		private global::Gtk.CheckButton checkbuttonUpdate;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label labelCacheSizeValue;

		private global::Gtk.Button buttonEmptyCache;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Entry entryCacheLocation;

		private global::Gtk.Button buttonCacheLocation;

		private global::Gtk.CheckButton checkbuttonLocation;

		private global::Gtk.HBox hbox6;

		private global::Gtk.RadioButton radioTagsInternal;

		private global::Gtk.RadioButton radioTagsOriginal;

		private global::Gtk.ComboBox comboboxSafetyLevel;

		private global::Gtk.ComboBox comboboxPhotosPerPage;

		private global::Gtk.Entry entryAlbumSearchName;

		private global::Gtk.Alignment alignment3;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Button buttonDefaults;

		private global::Gtk.Button buttonSave;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget FloydPink.Flickr.Downloadr.UI.Windows.PreferencesWindow
			this.HeightRequest = 510;
			this.Name = "FloydPink.Flickr.Downloadr.UI.Windows.PreferencesWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Preferences - flickr downloadr");
			this.Icon = global::Gdk.Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.UI.Assets.icon.png");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child FloydPink.Flickr.Downloadr.UI.Windows.PreferencesWindow.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.vbox9.Add(this.fixed3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.fixed3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0.05F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<big><b><u>Preferences</u></b></big>");
			this.label3.UseMarkup = true;
			this.vbox9.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label3]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment4 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment4.Name = "alignment4";
			this.hbox1.Add(this.alignment4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment4]));
			w3.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox11 = new global::Gtk.VBox();
			this.vbox11.Name = "vbox11";
			this.vbox11.Homogeneous = true;
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Homogeneous = true;
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelFilename = new global::Gtk.Label();
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Xalign = 0F;
			this.labelFilename.LabelProp = global::Mono.Unix.Catalog.GetString("Filename:");
			this.vbox12.Add(this.labelFilename);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelFilename]));
			w4.Position = 0;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelDownloadLocation = new global::Gtk.Label();
			this.labelDownloadLocation.Name = "labelDownloadLocation";
			this.labelDownloadLocation.Xalign = 0F;
			this.labelDownloadLocation.LabelProp = global::Mono.Unix.Catalog.GetString("Download Location:");
			this.vbox12.Add(this.labelDownloadLocation);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelDownloadLocation]));
			w5.Position = 1;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelDownloadSize = new global::Gtk.Label();
			this.labelDownloadSize.Name = "labelDownloadSize";
			this.labelDownloadSize.Xalign = 0F;
			this.labelDownloadSize.LabelProp = global::Mono.Unix.Catalog.GetString("Download Size:");
			this.vbox12.Add(this.labelDownloadSize);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelDownloadSize]));
			w6.Position = 2;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelMetadata = new global::Gtk.Label();
			this.labelMetadata.Name = "labelMetadata";
			this.labelMetadata.Xalign = 0F;
			this.labelMetadata.LabelProp = global::Mono.Unix.Catalog.GetString("Metadata:");
			this.vbox12.Add(this.labelMetadata);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelMetadata]));
			w7.Position = 3;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.vbox12.Add(this.label9);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label9]));
			w8.Position = 4;
			// Container child vbox12.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox12.Add(this.fixed1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.fixed1]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 5;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelLogLocation = new global::Gtk.Label();
			this.labelLogLocation.Name = "labelLogLocation";
			this.labelLogLocation.Xalign = 0F;
			this.labelLogLocation.LabelProp = global::Mono.Unix.Catalog.GetString("Log Location: <span color=\"red\">*</span>");
			this.labelLogLocation.UseMarkup = true;
			this.vbox12.Add(this.labelLogLocation);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelLogLocation]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelLogLevel = new global::Gtk.Label();
			this.labelLogLevel.Name = "labelLogLevel";
			this.labelLogLevel.Xalign = 0F;
			this.labelLogLevel.LabelProp = global::Mono.Unix.Catalog.GetString("Log Level:");
			this.vbox12.Add(this.labelLogLevel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelLogLevel]));
			w11.PackType = ((global::Gtk.PackType)(1));
			w11.Position = 7;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelDonation = new global::Gtk.Label();
			this.labelDonation.Name = "labelDonation";
			this.labelDonation.Xalign = 0F;
			this.labelDonation.LabelProp = global::Mono.Unix.Catalog.GetString("Donation Request:");
			this.vbox12.Add(this.labelDonation);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelDonation]));
			w12.PackType = ((global::Gtk.PackType)(1));
			w12.Position = 8;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelUpdate = new global::Gtk.Label();
			this.labelUpdate.Name = "labelUpdate";
			this.labelUpdate.Xalign = 0F;
			this.labelUpdate.LabelProp = global::Mono.Unix.Catalog.GetString("Update Notification:");
			this.vbox12.Add(this.labelUpdate);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelUpdate]));
			w13.PackType = ((global::Gtk.PackType)(1));
			w13.Position = 9;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelCacheSize = new global::Gtk.Label();
			this.labelCacheSize.Name = "labelCacheSize";
			this.labelCacheSize.Xalign = 0F;
			this.labelCacheSize.LabelProp = global::Mono.Unix.Catalog.GetString("Cache Size:");
			this.vbox12.Add(this.labelCacheSize);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelCacheSize]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 10;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelCacheLocation = new global::Gtk.Label();
			this.labelCacheLocation.Name = "labelCacheLocation";
			this.labelCacheLocation.Xalign = 0F;
			this.labelCacheLocation.LabelProp = global::Mono.Unix.Catalog.GetString("Cache Location: <span color=\"red\">*</span>");
			this.labelCacheLocation.UseMarkup = true;
			this.vbox12.Add(this.labelCacheLocation);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelCacheLocation]));
			w15.PackType = ((global::Gtk.PackType)(1));
			w15.Position = 11;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelLocation = new global::Gtk.Label();
			this.labelLocation.Name = "labelLocation";
			this.labelLocation.Xalign = 0F;
			this.labelLocation.LabelProp = global::Mono.Unix.Catalog.GetString("Location:");
			this.vbox12.Add(this.labelLocation);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelLocation]));
			w16.PackType = ((global::Gtk.PackType)(1));
			w16.Position = 12;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelTags = new global::Gtk.Label();
			this.labelTags.Name = "labelTags";
			this.labelTags.Xalign = 0F;
			this.labelTags.LabelProp = global::Mono.Unix.Catalog.GetString("Tags:");
			this.vbox12.Add(this.labelTags);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelTags]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 13;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelSafetyLevel = new global::Gtk.Label();
			this.labelSafetyLevel.Name = "labelSafetyLevel";
			this.labelSafetyLevel.Xalign = 0F;
			this.labelSafetyLevel.LabelProp = global::Mono.Unix.Catalog.GetString("Safety Level:");
			this.vbox12.Add(this.labelSafetyLevel);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelSafetyLevel]));
			w18.PackType = ((global::Gtk.PackType)(1));
			w18.Position = 14;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelPhotosPerPage = new global::Gtk.Label();
			this.labelPhotosPerPage.Name = "labelPhotosPerPage";
			this.labelPhotosPerPage.Xalign = 0F;
			this.labelPhotosPerPage.LabelProp = global::Mono.Unix.Catalog.GetString("Photos Per Page:");
			this.vbox12.Add(this.labelPhotosPerPage);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelPhotosPerPage]));
			w19.PackType = ((global::Gtk.PackType)(1));
			w19.Position = 15;
			// Container child vbox12.Gtk.Box+BoxChild
			this.labelAlbumSearchName = new global::Gtk.Label();
			this.labelAlbumSearchName.Name = "labelAlbumSearchName";
			this.labelAlbumSearchName.Xalign = 0F;
			this.labelAlbumSearchName.LabelProp = global::Mono.Unix.Catalog.GetString("Search for Album Name:");
			this.vbox12.Add(this.labelAlbumSearchName);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.labelAlbumSearchName]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 16;
			this.vbox11.Add(this.vbox12);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.vbox12]));
			w21.Position = 0;
			w21.Expand = false;
			this.hbox1.Add(this.vbox11);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox11]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Homogeneous = true;
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radioPhotoId = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Photo ID"));
			this.radioPhotoId.CanFocus = true;
			this.radioPhotoId.Name = "radioPhotoId";
			this.radioPhotoId.DrawIndicator = true;
			this.radioPhotoId.UseUnderline = true;
			this.radioPhotoId.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox3.Add(this.radioPhotoId);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.radioPhotoId]));
			w23.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radioOriginalOrder = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Original Order"));
			this.radioOriginalOrder.CanFocus = true;
			this.radioOriginalOrder.Name = "radioOriginalOrder";
			this.radioOriginalOrder.DrawIndicator = true;
			this.radioOriginalOrder.UseUnderline = true;
			this.radioOriginalOrder.Group = this.radioPhotoId.Group;
			this.hbox3.Add(this.radioOriginalOrder);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.radioOriginalOrder]));
			w24.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.radioPhotoTitle = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Photo Title"));
			this.radioPhotoTitle.CanFocus = true;
			this.radioPhotoTitle.Name = "radioPhotoTitle";
			this.radioPhotoTitle.DrawIndicator = true;
			this.radioPhotoTitle.UseUnderline = true;
			this.radioPhotoTitle.Group = this.radioPhotoId.Group;
			this.hbox3.Add(this.radioPhotoTitle);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.radioPhotoTitle]));
			w25.Position = 2;
			this.vbox13.Add(this.hbox3);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox3]));
			w26.Position = 0;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryDownloadLocation = new global::Gtk.Entry();
			this.entryDownloadLocation.CanFocus = true;
			this.entryDownloadLocation.Name = "entryDownloadLocation";
			this.entryDownloadLocation.IsEditable = false;
			this.entryDownloadLocation.InvisibleChar = '●';
			this.hbox4.Add(this.entryDownloadLocation);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryDownloadLocation]));
			w27.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonDownloadLocation = new global::Gtk.Button();
			this.buttonDownloadLocation.WidthRequest = 0;
			this.buttonDownloadLocation.CanFocus = true;
			this.buttonDownloadLocation.Name = "buttonDownloadLocation";
			this.buttonDownloadLocation.UseUnderline = true;
			this.buttonDownloadLocation.Label = global::Mono.Unix.Catalog.GetString("...");
			this.hbox4.Add(this.buttonDownloadLocation);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonDownloadLocation]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox13.Add(this.hbox4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox4]));
			w29.Position = 1;
			w29.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.comboboxDownloadSize = global::Gtk.ComboBox.NewText();
			this.comboboxDownloadSize.AppendText(global::Mono.Unix.Catalog.GetString("Medium"));
			this.comboboxDownloadSize.AppendText(global::Mono.Unix.Catalog.GetString("Large"));
			this.comboboxDownloadSize.AppendText(global::Mono.Unix.Catalog.GetString("Original"));
			this.comboboxDownloadSize.Name = "comboboxDownloadSize";
			this.vbox13.Add(this.comboboxDownloadSize);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.comboboxDownloadSize]));
			w30.Position = 2;
			w30.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Homogeneous = true;
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.checkbuttonTags = new global::Gtk.CheckButton();
			this.checkbuttonTags.CanFocus = true;
			this.checkbuttonTags.Name = "checkbuttonTags";
			this.checkbuttonTags.Label = global::Mono.Unix.Catalog.GetString("Tags");
			this.checkbuttonTags.DrawIndicator = true;
			this.checkbuttonTags.UseUnderline = true;
			this.hbox8.Add(this.checkbuttonTags);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.checkbuttonTags]));
			w31.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.checkbuttonDescription = new global::Gtk.CheckButton();
			this.checkbuttonDescription.CanFocus = true;
			this.checkbuttonDescription.Name = "checkbuttonDescription";
			this.checkbuttonDescription.Label = global::Mono.Unix.Catalog.GetString("Description");
			this.checkbuttonDescription.DrawIndicator = true;
			this.checkbuttonDescription.UseUnderline = true;
			this.hbox8.Add(this.checkbuttonDescription);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.checkbuttonDescription]));
			w32.Position = 1;
			this.vbox13.Add(this.hbox8);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox8]));
			w33.Position = 3;
			w33.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Homogeneous = true;
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.checkbuttonTitle = new global::Gtk.CheckButton();
			this.checkbuttonTitle.CanFocus = true;
			this.checkbuttonTitle.Name = "checkbuttonTitle";
			this.checkbuttonTitle.Label = global::Mono.Unix.Catalog.GetString("Title");
			this.checkbuttonTitle.DrawIndicator = true;
			this.checkbuttonTitle.UseUnderline = true;
			this.hbox9.Add(this.checkbuttonTitle);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.checkbuttonTitle]));
			w34.Position = 0;
			// Container child hbox9.Gtk.Box+BoxChild
			this.fixed5 = new global::Gtk.Fixed();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.hbox9.Add(this.fixed5);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.fixed5]));
			w35.Position = 1;
			this.vbox13.Add(this.hbox9);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox9]));
			w36.Position = 4;
			w36.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.labelRestartRequired = new global::Gtk.Label();
			this.labelRestartRequired.Name = "labelRestartRequired";
			this.labelRestartRequired.Xalign = 1F;
			this.labelRestartRequired.LabelProp = global::Mono.Unix.Catalog.GetString("<span color=\"red\">*</span> Requires Restart");
			this.labelRestartRequired.UseMarkup = true;
			this.vbox13.Add(this.labelRestartRequired);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.labelRestartRequired]));
			w37.PackType = ((global::Gtk.PackType)(1));
			w37.Position = 5;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.entryLogLocation = new global::Gtk.Entry();
			this.entryLogLocation.CanFocus = true;
			this.entryLogLocation.Name = "entryLogLocation";
			this.entryLogLocation.IsEditable = false;
			this.entryLogLocation.InvisibleChar = '●';
			this.hbox11.Add(this.entryLogLocation);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.entryLogLocation]));
			w38.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.buttonLogLocation = new global::Gtk.Button();
			this.buttonLogLocation.CanFocus = true;
			this.buttonLogLocation.Name = "buttonLogLocation";
			this.buttonLogLocation.UseUnderline = true;
			this.buttonLogLocation.Label = global::Mono.Unix.Catalog.GetString("...");
			this.hbox11.Add(this.buttonLogLocation);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonLogLocation]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			this.vbox13.Add(this.hbox11);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox11]));
			w40.PackType = ((global::Gtk.PackType)(1));
			w40.Position = 6;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.comboboxLogLevel = global::Gtk.ComboBox.NewText();
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Off"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Fatal"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Error"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Warn"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Info"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("Debug"));
			this.comboboxLogLevel.AppendText(global::Mono.Unix.Catalog.GetString("All"));
			this.comboboxLogLevel.Name = "comboboxLogLevel";
			this.vbox13.Add(this.comboboxLogLevel);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.comboboxLogLevel]));
			w41.PackType = ((global::Gtk.PackType)(1));
			w41.Position = 7;
			w41.Expand = false;
			w41.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.checkbuttonDonate = new global::Gtk.CheckButton();
			this.checkbuttonDonate.CanFocus = true;
			this.checkbuttonDonate.Name = "checkbuttonDonate";
			this.checkbuttonDonate.Label = global::Mono.Unix.Catalog.GetString("Suppress donation requests (I have already donated)");
			this.checkbuttonDonate.DrawIndicator = true;
			this.checkbuttonDonate.UseUnderline = true;
			this.vbox13.Add(this.checkbuttonDonate);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.checkbuttonDonate]));
			w42.PackType = ((global::Gtk.PackType)(1));
			w42.Position = 8;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.checkbuttonUpdate = new global::Gtk.CheckButton();
			this.checkbuttonUpdate.CanFocus = true;
			this.checkbuttonUpdate.Name = "checkbuttonUpdate";
			this.checkbuttonUpdate.Label = global::Mono.Unix.Catalog.GetString("Check for updates automatically");
			this.checkbuttonUpdate.DrawIndicator = true;
			this.checkbuttonUpdate.UseUnderline = true;
			this.hbox10.Add(this.checkbuttonUpdate);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.checkbuttonUpdate]));
			w43.Position = 0;
			this.vbox13.Add(this.hbox10);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox10]));
			w44.PackType = ((global::Gtk.PackType)(1));
			w44.Position = 9;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelCacheSizeValue = new global::Gtk.Label();
			this.labelCacheSizeValue.Name = "labelCacheSizeValue";
			this.labelCacheSizeValue.LabelProp = global::Mono.Unix.Catalog.GetString("0 KB");
			this.hbox7.Add(this.labelCacheSizeValue);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelCacheSizeValue]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonEmptyCache = new global::Gtk.Button();
			this.buttonEmptyCache.WidthRequest = 100;
			this.buttonEmptyCache.HeightRequest = 0;
			this.buttonEmptyCache.CanFocus = true;
			this.buttonEmptyCache.Name = "buttonEmptyCache";
			this.buttonEmptyCache.UseUnderline = true;
			this.buttonEmptyCache.Label = global::Mono.Unix.Catalog.GetString("Empty Cache");
			this.hbox7.Add(this.buttonEmptyCache);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonEmptyCache]));
			w46.Position = 1;
			w46.Expand = false;
			w46.Fill = false;
			w46.Padding = ((uint)(5));
			this.vbox13.Add(this.hbox7);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox7]));
			w47.PackType = ((global::Gtk.PackType)(1));
			w47.Position = 10;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entryCacheLocation = new global::Gtk.Entry();
			this.entryCacheLocation.CanFocus = true;
			this.entryCacheLocation.Name = "entryCacheLocation";
			this.entryCacheLocation.IsEditable = false;
			this.entryCacheLocation.InvisibleChar = '●';
			this.hbox5.Add(this.entryCacheLocation);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entryCacheLocation]));
			w48.Position = 0;
			// Container child hbox5.Gtk.Box+BoxChild
			this.buttonCacheLocation = new global::Gtk.Button();
			this.buttonCacheLocation.CanFocus = true;
			this.buttonCacheLocation.Name = "buttonCacheLocation";
			this.buttonCacheLocation.UseUnderline = true;
			this.buttonCacheLocation.Label = global::Mono.Unix.Catalog.GetString("...");
			this.hbox5.Add(this.buttonCacheLocation);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.buttonCacheLocation]));
			w49.Position = 1;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox13.Add(this.hbox5);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox5]));
			w50.PackType = ((global::Gtk.PackType)(1));
			w50.Position = 11;
			w50.Expand = false;
			w50.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.checkbuttonLocation = new global::Gtk.CheckButton();
			this.checkbuttonLocation.CanFocus = true;
			this.checkbuttonLocation.Name = "checkbuttonLocation";
			this.checkbuttonLocation.Label = global::Mono.Unix.Catalog.GetString("Capture Location metadata (tags must be \'Original\')");
			this.checkbuttonLocation.DrawIndicator = true;
			this.checkbuttonLocation.UseUnderline = true;
			this.vbox13.Add(this.checkbuttonLocation);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.checkbuttonLocation]));
			w51.PackType = ((global::Gtk.PackType)(1));
			w51.Position = 12;
			w51.Expand = false;
			w51.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Homogeneous = true;
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.radioTagsInternal = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Internal"));
			this.radioTagsInternal.CanFocus = true;
			this.radioTagsInternal.Name = "radioTagsInternal";
			this.radioTagsInternal.DrawIndicator = true;
			this.radioTagsInternal.UseUnderline = true;
			this.radioTagsInternal.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox6.Add(this.radioTagsInternal);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.radioTagsInternal]));
			w52.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.radioTagsOriginal = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Original (Slower download)"));
			this.radioTagsOriginal.CanFocus = true;
			this.radioTagsOriginal.Name = "radioTagsOriginal";
			this.radioTagsOriginal.DrawIndicator = true;
			this.radioTagsOriginal.UseUnderline = true;
			this.radioTagsOriginal.Group = this.radioTagsInternal.Group;
			this.hbox6.Add(this.radioTagsOriginal);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.radioTagsOriginal]));
			w53.Position = 1;
			this.vbox13.Add(this.hbox6);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.hbox6]));
			w54.PackType = ((global::Gtk.PackType)(1));
			w54.Position = 13;
			w54.Expand = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.comboboxSafetyLevel = global::Gtk.ComboBox.NewText();
			this.comboboxSafetyLevel.AppendText(global::Mono.Unix.Catalog.GetString("Safe"));
			this.comboboxSafetyLevel.AppendText(global::Mono.Unix.Catalog.GetString("Moderate"));
			this.comboboxSafetyLevel.AppendText(global::Mono.Unix.Catalog.GetString("Restricted"));
			this.comboboxSafetyLevel.Name = "comboboxSafetyLevel";
			this.vbox13.Add(this.comboboxSafetyLevel);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.comboboxSafetyLevel]));
			w55.PackType = ((global::Gtk.PackType)(1));
			w55.Position = 14;
			w55.Expand = false;
			w55.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.comboboxPhotosPerPage = global::Gtk.ComboBox.NewText();
			this.comboboxPhotosPerPage.AppendText(global::Mono.Unix.Catalog.GetString("25"));
			this.comboboxPhotosPerPage.AppendText(global::Mono.Unix.Catalog.GetString("50"));
			this.comboboxPhotosPerPage.AppendText(global::Mono.Unix.Catalog.GetString("75"));
			this.comboboxPhotosPerPage.AppendText(global::Mono.Unix.Catalog.GetString("100"));
			this.comboboxPhotosPerPage.Name = "comboboxPhotosPerPage";
			this.vbox13.Add(this.comboboxPhotosPerPage);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.comboboxPhotosPerPage]));
			w56.PackType = ((global::Gtk.PackType)(1));
			w56.Position = 15;
			w56.Expand = false;
			w56.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.entryAlbumSearchName = new global::Gtk.Entry();
			this.entryAlbumSearchName.CanFocus = true;
			this.entryAlbumSearchName.Name = "entryAlbumSearchName";
			this.entryAlbumSearchName.IsEditable = true;
			this.entryAlbumSearchName.InvisibleChar = '●';
			this.vbox13.Add(this.entryAlbumSearchName);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.entryAlbumSearchName]));
			w57.PackType = ((global::Gtk.PackType)(1));
			w57.Position = 16;
			this.hbox1.Add(this.vbox13);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox13]));
			w58.Position = 2;
			w58.Expand = false;
			w58.Fill = false;
			w58.Padding = ((uint)(10));
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment3 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment3.Name = "alignment3";
			this.hbox1.Add(this.alignment3);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.alignment3]));
			w59.PackType = ((global::Gtk.PackType)(1));
			w59.Position = 3;
			this.vbox9.Add(this.hbox1);
			global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox1]));
			w60.Position = 2;
			w60.Padding = ((uint)(10));
			// Container child vbox9.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.WidthRequest = 80;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Cancel");
			this.hbox2.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonCancel]));
			w61.Position = 0;
			w61.Expand = false;
			w61.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonDefaults = new global::Gtk.Button();
			this.buttonDefaults.WidthRequest = 80;
			this.buttonDefaults.CanFocus = true;
			this.buttonDefaults.Name = "buttonDefaults";
			this.buttonDefaults.UseUnderline = true;
			this.buttonDefaults.Label = global::Mono.Unix.Catalog.GetString("Defaults");
			this.hbox2.Add(this.buttonDefaults);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonDefaults]));
			w62.Position = 1;
			w62.Expand = false;
			w62.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.WidthRequest = 80;
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Save");
			this.hbox2.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSave]));
			w63.Position = 2;
			w63.Expand = false;
			w63.Fill = false;
			this.vbox9.Add(this.hbox2);
			global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hbox2]));
			w64.Position = 3;
			w64.Expand = false;
			w64.Fill = false;
			w64.Padding = ((uint)(5));
			this.Add(this.vbox9);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 736;
			this.DefaultHeight = 807;
			this.Show();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
			this.buttonDownloadLocation.Clicked += new global::System.EventHandler(this.buttonDownloadLocationClick);
			this.radioTagsInternal.Clicked += new global::System.EventHandler(this.tagPreferenceChanged);
			this.radioTagsOriginal.Clicked += new global::System.EventHandler(this.tagPreferenceChanged);
			this.buttonCacheLocation.Clicked += new global::System.EventHandler(this.buttonCacheLocationClick);
			this.buttonEmptyCache.Clicked += new global::System.EventHandler(this.buttonEmptyCacheClick);
			this.buttonLogLocation.Clicked += new global::System.EventHandler(this.buttonLogLocationClick);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.buttonCancelClick);
			this.buttonDefaults.Clicked += new global::System.EventHandler(this.buttonDefaultsClick);
			this.buttonSave.Clicked += new global::System.EventHandler(this.buttonSaveClick);
		}
	}
}
