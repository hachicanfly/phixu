using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace maxcare.Helper
{
	// Token: 0x0200019D RID: 413
	public class FileHelper
	{
		// Token: 0x060011E4 RID: 4580 RVA: 0x00412388 File Offset: 0x00410588
		public static string GetPathToCurrentFolder()
		{
			return Path.GetDirectoryName(Application.ExecutablePath);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00016388 File Offset: 0x00014588
		public static string SelectFolder()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
				{
					DialogResult dialogResult = folderBrowserDialog.ShowDialog();
					bool flag = dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath);
					if (flag)
					{
						result = folderBrowserDialog.SelectedPath;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x004123A8 File Offset: 0x004105A8
		public static string SelectFile(string title = "Chọn File txt", string defaultFolder = "C:\\", string filter = "txt Files (*.txt)|*.txt|All files (*.*)|*.*")
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.Filter = filter;
					openFileDialog.InitialDirectory = defaultFolder;
					openFileDialog.Title = title;
					bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						result = openFileDialog.FileName;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0041249C File Offset: 0x0041069C
		public static bool DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			try
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirName);
				bool flag = !directoryInfo.Exists;
				if (flag)
				{
					return false;
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				Directory.CreateDirectory(destDirName);
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					string destFileName = Path.Combine(destDirName, fileInfo.Name);
					fileInfo.CopyTo(destFileName, true);
				}
				if (copySubDirs)
				{
					foreach (DirectoryInfo directoryInfo2 in directories)
					{
						string destDirName2 = Path.Combine(destDirName, directoryInfo2.Name);
						FileHelper.DirectoryCopy(directoryInfo2.FullName, destDirName2, copySubDirs);
					}
				}
				return true;
			}
			catch (Exception)
			{
			}
			return false;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x004125F4 File Offset: 0x004107F4
		public static void CreateFile(string pathFile)
		{
			try
			{
				File.AppendAllText(pathFile, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
			}
			catch
			{
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0041267C File Offset: 0x0041087C
		public static void CreateFolderIfNotExist(string pathFolder)
		{
			try
			{
				Directory.CreateDirectory(pathFolder);
			}
			catch
			{
			}
		}
	}
}
