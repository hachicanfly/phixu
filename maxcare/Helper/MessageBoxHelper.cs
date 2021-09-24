using System;
using System.Text;
using System.Windows.Forms;

namespace maxcare.Helper
{
	// Token: 0x020001A1 RID: 417
	public class MessageBoxHelper
	{
		// Token: 0x06001206 RID: 4614 RVA: 0x00412E58 File Offset: 0x00411058
		public static void ShowMessageBox(object s, int type = 1)
		{
			switch (type)
			{
			case 1:
				MessageBox.Show(s.ToString(), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk="))))))))), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				break;
			case 2:
				MessageBox.Show(s.ToString(), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk="))))))))), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				break;
			case 3:
				MessageBox.Show(s.ToString(), Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk="))))))))), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				break;
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00412FD0 File Offset: 0x004111D0
		public static DialogResult ShowMessageBoxWithQuestion(string content)
		{
			return MessageBox.Show(content, Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2NWSklVa2hPVnpWS1VqQjRSV0l4WXpSUVVUMDk="))))))))), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}
