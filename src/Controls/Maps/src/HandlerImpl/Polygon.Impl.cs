﻿#nullable enable
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Maps;

namespace Microsoft.Maui.Controls.Maps
{
	public partial class Polygon : IGeoPathMapElement, IFilledMapElement
	{
		public Paint? Fill => FillColor?.AsPaint();
	}
}
