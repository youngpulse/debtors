using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Debtors.Domain
{
	public class ItemInfo
	{
		public int Id { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public string Text { get; set; }
		public string Color { get; set; }
		public int A { get; set; }
		public int R { get; set; }
		public int G { get; set; }
		public int B { get; set; }
		HatchStyle pattern;
		Color patternColor;

		public ItemInfo()
		{ }

		public ItemInfo(DateTime startTime, DateTime endTime, string text, Color color)
		{
			StartTime = startTime;
			EndTime = endTime;
			Text = text;
			A = color.A;
			R = color.R;
			G = color.G;
			B = color.B;
		}

		public ItemInfo (DateTime startTime, DateTime endTime, string text, Color color, int id)
			:this(startTime, endTime,text,color)
		{
			Id =id;
		}
	}
}
