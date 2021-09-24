using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using ConversionBack;

namespace MCommon
{
	// Token: 0x02000015 RID: 21
	internal class ImageScanOpenCV
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00007388 File Offset: 0x00005588
		public static Bitmap GetImage(string path)
		{
			return new Bitmap(path);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000073A8 File Offset: 0x000055A8
		public static Bitmap Find(string main, string sub, double percent = 0.9)
		{
			Bitmap image = ImageScanOpenCV.GetImage(main);
			Bitmap image2 = ImageScanOpenCV.GetImage(sub);
			return ImageScanOpenCV.Find(main, sub, percent);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000073EC File Offset: 0x000055EC
		public static Bitmap Find(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
		{
			object[] parameters = new object[]
			{
				mainBitmap,
				subBitmap,
				percent
			};
			return (Bitmap)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(24624, 528, 55, parameters);
		}

		// Token: 0x06000064 RID: 100
		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		// Token: 0x06000065 RID: 101 RVA: 0x00007454 File Offset: 0x00005654
		public static Point? FindOutPoint(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
		{
			object[] parameters = new object[]
			{
				mainBitmap,
				subBitmap,
				percent
			};
			return (Point?)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(25152, 704, 56, parameters);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000074BC File Offset: 0x000056BC
		public static List<Point> FindOutPoints(Bitmap mainBitmap, Bitmap subBitmap, double percent = 0.9)
		{
			object[] parameters = new object[]
			{
				mainBitmap,
				subBitmap,
				percent
			};
			return (List<Point>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(25856, 544, 57, parameters);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007524 File Offset: 0x00005724
		public static List<Point> FindColor(Bitmap mainBitmap, Color color)
		{
			int num = color.ToArgb();
			List<Point> list = new List<Point>();
			try
			{
				for (int i = 0; i < mainBitmap.Width; i++)
				{
					for (int j = 0; j < mainBitmap.Height; j++)
					{
						bool flag = num.Equals(mainBitmap.GetPixel(i, j).ToArgb());
						bool flag2 = flag;
						if (flag2)
						{
							list.Add(new Point(i, j));
						}
					}
				}
			}
			finally
			{
				bool flag3 = mainBitmap != null;
				if (flag3)
				{
					((IDisposable)mainBitmap).Dispose();
				}
			}
			return list;
		}
	}
}
