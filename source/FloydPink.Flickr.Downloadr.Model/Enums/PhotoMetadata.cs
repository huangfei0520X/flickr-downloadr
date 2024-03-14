﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FloydPink.Flickr.Downloadr.Model.Enums
{
  public static class PhotoMetadata
  {
    public static readonly string Tags = "Tags";
    public static readonly string Description = "Description";
    public static readonly string Title = "Title";
    public static readonly string Location = "Location";

    public static List<string> GetItems()
    {
      return typeof(PhotoMetadata).GetFields(BindingFlags.Public | BindingFlags.Static).
        Select(field => field.GetValue(null).ToString()).ToList();
    }
  }
}
