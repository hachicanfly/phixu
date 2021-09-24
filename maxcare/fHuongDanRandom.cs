using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using maxcare.Properties;

namespace maxcare
{
	// Token: 0x020000EB RID: 235
	public partial class fHuongDanRandom : Form
	{
		// Token: 0x06000981 RID: 2433 RVA: 0x00002F87 File Offset: 0x00001187
		public fHuongDanRandom()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
			this.LoadDgv();
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0019840C File Offset: 0x0019660C
		private void ChangeLanguage()
		{
			Language.GetValue(this.bunifuCustomLabel1);
			foreach (object obj in this.dgv.Columns)
			{
				DataGridViewColumn control = (DataGridViewColumn)obj;
				Language.GetValue(control);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00198498 File Offset: 0x00196698
		private void LoadDgv()
		{
			Random random = new Random();
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVkdhRkpRVkRBOQ==")))))))),
				Resources.icon11
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVldhRkpRVkRBOQ==")))))))),
				Resources.icon12
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NtVnNhRkpRVkRBOQ==")))))))),
				Resources.icon13
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMUdhRkpRVkRBOQ==")))))))),
				Resources.icon14
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMVdhRkpRVkRBOQ==")))))))),
				Resources.icon15
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMXNhRkpRVkRBOQ==")))))))),
				Resources.icon16
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrMHhhRkpRVkRBOQ==")))))))),
				Resources.icon17
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1NrNUdhRkpRVkRBOQ==")))))))),
				Resources.icon18
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wS1UxcEJQVDA9")))))))),
				Resources.icon19
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1UxcEJQVDA9")))))))),
				Resources.icon20
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wSk1HTldhRkpRVkRBOQ==")))))))),
				Resources.icon21
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1RtTldhRkpRVkRBOQ==")))))))),
				Resources.icon22
			});
			this.dgv.Rows.Add(new object[]
			{
				this.dgv.RowCount + 1,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wT1JtTlZkSEJqUjFFOQ==")))))))),
				Resources.icon23
			});
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00069C18 File Offset: 0x00067E18
		private void FConfigGenneral_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00069C18 File Offset: 0x00067E18
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0005CE3C File Offset: 0x0005B03C
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
