using System;
using System.Text;
using System.Windows.Forms;

namespace maxcare
{
	// Token: 0x020000D4 RID: 212
	public class Language
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x0017389C File Offset: 0x00171A9C
		public static string GetValue(string key)
		{
			return key;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x001738B8 File Offset: 0x00171AB8
		public static void GetValue(Control control)
		{
			control.Text = Language.GetValue(control.Text);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x001738E4 File Offset: 0x00171AE4
		public static void GetValue(ToolStripItem control)
		{
			control.Text = Language.GetValue(control.Text);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00173910 File Offset: 0x00171B10
		public static void GetValue(DataGridViewColumn control)
		{
			control.HeaderText = Language.GetValue(control.HeaderText);
		}

		// Token: 0x04000C6A RID: 3178
		public static string data = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
	}
}
