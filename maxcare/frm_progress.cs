using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using maxcare.Helper;
using MetroFramework.Controls;

namespace maxcare
{
	// Token: 0x020000F8 RID: 248
	public partial class frm_progress : Form
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x0000306E File Offset: 0x0000126E
		public frm_progress()
		{
			this.InitializeComponent();
			this.ChangeLanguage();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x001CD478 File Offset: 0x001CB678
		private void ChangeLanguage()
		{
			Language.GetValue(this.lblproccess);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x001CD498 File Offset: 0x001CB698
		private void frm_progress_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = File.Exists(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck5GQlJQVDA9")))))))),
					Base.softname,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
					Base.softname,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMWQyTkhUa0pRVkRBOQ=="))))))))
				}));
				if (flag)
				{
					File.Delete(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck5GQlJQVDA9")))))))),
						Base.softname,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
						Base.softname,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMWQyTkhUa0pRVkRBOQ=="))))))))
					}));
				}
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string str = Base.hostname + Base.softname;
				bool flag2 = InternetConnection.IsConnectedToInternet();
				if (flag2)
				{
					Uri uri = new Uri(str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))) + Base.softname + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMWQyTkhUa0pRVkRBOQ==")))))))));
					this.StartDownload(uri, string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck5GQlJQVDA9")))))))),
						Base.softname,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
						Base.softname,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMWQyTkhUa0pRVkRBOQ=="))))))))
					}));
				}
				else
				{
					MessageBoxHelper.ShowMessageBox(Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqQTFNbVZyYkVaYU1rVTBWRE5HTmxOVldYZFRWV016VWtoU1RtVlZTbWhWTUVwTFdXMDFVMkpIVG5ST1YzaHJVVE5rYmxwSE5WZGpSV3hJWlVoYU5sTlZTakZYYm14RFkyMUdhbFF6UmpaVFYzZ3dVMVZvVTJWV2JGUlJiazVhV1ROc2NWbFdUa1pRVVQwOQ=="))))))))), 1);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + ex.Message, 2);
				base.Close();
			}
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x001CD9BC File Offset: 0x001CBBBC
		public void Copy(string sourceDirectory, string targetDirectory)
		{
			DirectoryInfo source = new DirectoryInfo(sourceDirectory);
			DirectoryInfo target = new DirectoryInfo(targetDirectory);
			this.CopyAll(source, target);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x001CD9F0 File Offset: 0x001CBBF0
		public void CopyAll(DirectoryInfo source, DirectoryInfo target)
		{
			Directory.CreateDirectory(target.FullName);
			int num = 1;
			foreach (FileInfo fileInfo in source.GetFiles())
			{
				Application.DoEvents();
				fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name), true);
				num++;
			}
			foreach (DirectoryInfo directoryInfo in source.GetDirectories())
			{
				DirectoryInfo target2 = target.CreateSubdirectory(directoryInfo.Name);
				this.CopyAll(directoryInfo, target2);
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x001CDAD0 File Offset: 0x001CBCD0
		private void StartDownload(Uri uri, string pathFile)
		{
			Thread thread = new Thread(delegate()
			{
				WebClient webClient = new WebClient();
				webClient.DownloadProgressChanged += this.client_DownloadProgressChanged;
				webClient.DownloadFileCompleted += this.client_DownloadFileCompleted;
				webClient.DownloadFileAsync(uri, pathFile);
			});
			thread.Start();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x001CDB24 File Offset: 0x001CBD24
		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				double num = double.Parse(e.BytesReceived.ToString());
				double num2 = double.Parse(e.TotalBytesToReceive.ToString());
				double d = num / num2 * 100.0;
				this.lblproccess.Text = string.Format(Language.GetValue("Đang tải xuống, vui lòng chờ ({0}%)..."), int.Parse(Math.Truncate(d).ToString()));
				this.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
			}));
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x001CDB68 File Offset: 0x001CBD68
		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.lblproccess.Text = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("WlVWd1EyRkhTblJaTW1SaFRXMTRiMlZyYkhOalJXeElUbGQ0TmxOVldqRlRWV1JoWTBkS1NGWllWazFoVkZFNQ==")))))))));
			}));
			try
			{
				ZipFile.ExtractToDirectory(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck5GQlJQVDA9")))))))),
					Base.softname,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))),
					Base.softname,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjMWQyTkhUa0pRVkRBOQ=="))))))))
				}), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVkck5GQlJQVDA9")))))))) + Base.softname + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVoak9WQlJQVDA9")))))))));
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					base.Close();
				}));
			}
			catch (Exception ex)
			{
				MessageBoxHelper.ShowMessageBox(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + ex.Message, 2);
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					base.Close();
				}));
			}
		}
	}
}
