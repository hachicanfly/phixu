using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maxcare.Helper
{
	// Token: 0x02000191 RID: 401
	public class CollectionHelper
	{
		// Token: 0x060011C2 RID: 4546 RVA: 0x00411520 File Offset: 0x0040F720
		public static bool ComparyTwoList(List<string> lst1, List<string> lst2)
		{
			List<string> source = lst1.Except(lst2).ToList<string>();
			List<string> source2 = lst2.Except(lst1).ToList<string>();
			return !source.Any<string>() && !source2.Any<string>();
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00015EB0 File Offset: 0x000140B0
		public static List<string> ShuffleList(List<string> lst)
		{
			string value = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			int i = lst.Count;
			while (i != 0)
			{
				int index = Base.rd.Next(0, lst.Count);
				i--;
				value = lst[i];
				lst[i] = lst[index];
				lst[index] = value;
			}
			return lst;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00411588 File Offset: 0x0040F788
		public static List<string> CloneList(List<string> lstFrom)
		{
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < lstFrom.Count; i++)
				{
					list.Add(lstFrom[i]);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00411608 File Offset: 0x0040F808
		public static List<List<string>> SplitList(List<string> lstInput, int numberOfItemPerList)
		{
			List<List<string>> list = new List<List<string>>();
			try
			{
				int num = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstInput.Count * 1.0 / (double)numberOfItemPerList)));
				for (int i = 0; i < num; i++)
				{
					list.Add(lstInput.GetRange(numberOfItemPerList * i, (numberOfItemPerList * i + numberOfItemPerList <= lstInput.Count) ? numberOfItemPerList : (lstInput.Count % numberOfItemPerList)));
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x004116F4 File Offset: 0x0040F8F4
		public static string ConvertListToString(List<string> lstInput, string separatorString = "\r\n")
		{
			return string.Join(separatorString, lstInput);
		}
	}
}
