using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;

namespace maxcare
{
	// Token: 0x020000A0 RID: 160
	public partial class fViewChrome : Form
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x00002C50 File Offset: 0x00000E50
		public fViewChrome()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			fViewChrome.remote = this;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000B9F84 File Offset: 0x000B8184
		private void ChangeLanguage()
		{
			Language.GetValue(this);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x000B9FA0 File Offset: 0x000B81A0
		public void AddChromeIntoPanel(IntPtr MainWindowHandle, int indexDevice, int width, int heigh, int x = -10, int y = -30)
		{
			base.Invoke(new MethodInvoker(delegate()
			{
				User32Helper.SetParent(MainWindowHandle, (from Control h in this.panelListDevice.Controls
				where h.Tag.Equals(indexDevice)
				select h).FirstOrDefault<Control>().Handle);
				User32Helper.MoveWindow(MainWindowHandle, x, y, width, heigh, true);
			}));
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x000BA020 File Offset: 0x000B8220
		public void RemovePanelDevice(int indexDevice)
		{
			Control ctr = this.panelListDevice.Controls[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0b1dsQlJQVDA9")))))))) + indexDevice.ToString()];
			this.panelListDevice.Invoke(new MethodInvoker(delegate()
			{
				this.panelListDevice.Controls.Remove(ctr);
			}));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000BA0D0 File Offset: 0x000B82D0
		public void AddPanelDevice(int indexDevice, int width, int heigh)
		{
			Panel panel = new Panel();
			panel.Name = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0b1dsQlJQVDA9")))))))) + indexDevice.ToString();
			panel.Tag = indexDevice;
			panel.Size = new Size(width, heigh);
			panel.BackColor = Color.White;
			panel.BorderStyle = BorderStyle.FixedSingle;
			base.Invoke(new MethodInvoker(delegate()
			{
				this.panelListDevice.Controls.Add(panel);
			}));
			for (int i = 0; i < 10; i++)
			{
				bool flag = this.panelListDevice.Controls[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0b1dsQlJQVDA9")))))))) + indexDevice.ToString()] != null;
				if (flag)
				{
					break;
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000BA274 File Offset: 0x000B8474
		private void TurnOffDevice(object sender, EventArgs e)
		{
			this.RemovePanelDevice(Convert.ToInt32((sender as PictureBox).Name.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa2MyRm5QVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))))));
		}

		// Token: 0x0400059B RID: 1435
		public static fViewChrome remote;
	}
}
