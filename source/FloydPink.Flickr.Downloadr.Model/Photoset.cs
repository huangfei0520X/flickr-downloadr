﻿namespace FloydPink.Flickr.Downloadr.Model {
    public class Photoset : IGridWidgetItem {
        public Photoset(string id, string primary, string secret, string server, int farm, int photos, int videos, string title,
                        string description) {
            Id = id;
            Primary = primary;
            Secret = secret;
            Server = server;
            Farm = farm;
            Photos = photos;
            Videos = videos;
            Title = title;
            Description = description;
        }

        public string Id { get; private set; }
        public string Primary { get; private set; }
        public string Secret { get; private set; }
        public string Server { get; private set; }
        public int Farm { get; private set; }
        public int Photos { get; private set; }
        public int Videos { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string WidgetThumbnailUrl {
            get {
                return string.Format("https://farm{0}.staticflickr.com/{1}/{2}_{3}_q.jpg", 
                this.Farm, this.Server, this.Primary,this.Secret);
            }
        }
    }
}
