using System;
using System.Text;
using System.Windows.Forms;
using MCommon;

namespace maxcare.Helper
{
	// Token: 0x02000193 RID: 403
	internal class DatagridviewHelper
	{
		// Token: 0x060011CB RID: 4555 RVA: 0x00411A9C File Offset: 0x0040FC9C
		public static void SetStatusDataGridViewWithWait(DataGridView dgv, int row, string colName, int timeWait = 0, string status = "Đợi {time} giây...")
		{
			try
			{
				int time_start = Environment.TickCount;
				while ((Environment.TickCount - time_start) / 1000 - timeWait < 0)
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status.Replace("{time}", (timeWait - (Environment.TickCount - time_start) / 1000).ToString());
					}));
					Common.DelayTime(0.5);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00411B8C File Offset: 0x0040FD8C
		public static void SetStatusDataGridViewWithWait(DataGridView dgv, int row, string colName, int timeWait = 0, int timeStart = 0, string status = "Đợi {time} giây...")
		{
			try
			{
				int time_start = Environment.TickCount;
				while ((Environment.TickCount - time_start) / 1000 - timeWait < 0)
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status.Replace("{time}", (timeStart - (Environment.TickCount - time_start) / 1000).ToString());
					}));
					Common.DelayTime(0.5);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00411C78 File Offset: 0x0040FE78
		public static string GetStatusDataGridView(DataGridView dgv, int row, int col)
		{
			string output = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				bool flag = dgv.Rows[row].Cells[col].Value != null;
				if (flag)
				{
					try
					{
						output = dgv.Rows[row].Cells[col].Value.ToString();
					}
					catch
					{
						dgv.Invoke(new MethodInvoker(delegate()
						{
							output = dgv.Rows[row].Cells[col].Value.ToString();
						}));
					}
				}
			}
			catch
			{
			}
			return output;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00411DDC File Offset: 0x0040FFDC
		public static string GetStatusDataGridView(DataGridView dgv, int row, string colName)
		{
			string output = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				bool flag = dgv.Rows[row].Cells[colName].Value != null;
				if (flag)
				{
					try
					{
						output = dgv.Rows[row].Cells[colName].Value.ToString();
					}
					catch
					{
						dgv.Invoke(new MethodInvoker(delegate()
						{
							output = dgv.Rows[row].Cells[colName].Value.ToString();
						}));
					}
				}
			}
			catch
			{
			}
			return output;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00411F40 File Offset: 0x00410140
		public static void SetStatusDataGridView(DataGridView dgv, int row, int col, object status)
		{
			try
			{
				try
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[col].Value = status;
					}));
				}
				catch
				{
					dgv.Rows[row].Cells[col].Value = status;
				}
			}
			catch
			{
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0041201C File Offset: 0x0041021C
		public static void SetStatusDataGridView(DataGridView dgv, int row, string colName, object status)
		{
			try
			{
				try
				{
					dgv.Invoke(new MethodInvoker(delegate()
					{
						dgv.Rows[row].Cells[colName].Value = status;
					}));
				}
				catch
				{
					dgv.Rows[row].Cells[colName].Value = status;
				}
			}
			catch
			{
			}
		}
	}
}
