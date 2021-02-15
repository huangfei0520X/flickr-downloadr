﻿using System;
using Gtk;

namespace FloydPink.Flickr.Downloadr
{
	public class MessageBox
	{
		public static ResponseType Show(Window window, string message, ButtonsType buttons, MessageType type)
		{
			MessageDialog md = new MessageDialog (window, DialogFlags.DestroyWithParent, type, buttons, message);
			var result = (ResponseType)md.Run ();
			md.Destroy();
			return result;
		}
	}
}
