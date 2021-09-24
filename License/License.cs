using System;
using System.Net;
using System.Text;
using License.RNCryptor;

namespace License
{
	// Token: 0x02000005 RID: 5
	public class License
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003AE8 File Offset: 0x00001CE8
		public License(string usr, string pwd, string hardware, string softIndex, string randomKey)
		{
			this.Usr = usr;
			this.Pwd = pwd;
			this.Hardware = hardware;
			this.SoftIndex = softIndex;
			this.RandomKey = randomKey;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003CE4 File Offset: 0x00001EE4
		public string CheckLic()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtaV2MxUXhWWGRQVldSWFVtMVNRMVpYZEZkYWJFMTNWbXh3V1UxVlNsUldTR001VUZFOVBRPT0=")))))))) + this.RandomKey;
				Encryptor encryptor = new Encryptor();
				Decryptor decryptor = new Decryptor();
				string plaintext = string.Concat(new string[]
				{
					this.SoftIndex,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					this.Hardware,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					this.Usr,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					this.Pwd,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))),
					text
				});
				string str = encryptor.Encrypt(plaintext, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwQ1YxZHNhRFpoUnpGUFZrWlZNRmRYY0VwT1JURTJWVlJLWVZaR2NIRlhiWEJQWVd4bmQyRkZTbFpOUjJodFZERlNiazVXYkZoV1dHUmhVa2ROZVZSVlVrSmxWVEZJVjFoclBRPT0=")))))))));
				string text2 = this.ReadHTMLCode(this.ServerURL + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrUlVwcFVqTm9WbGxxU2pCaVIwcHdUME01V2xkRlNuZFZSa1U1VUZFOVBRPT0=")))))))) + str).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag = text2 != null;
				if (flag)
				{
					result = text2;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000040C4 File Offset: 0x000022C4
		public string CheckAcc()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtaV2MxUXhWWGRQVldSWFVtMVNRMVpYZEZkYWJFMTNWbXh3V1UxVlNsUldTR001VUZFOVBRPT0=")))))))) + this.RandomKey;
				Encryptor encryptor = new Encryptor();
				Decryptor decryptor = new Decryptor();
				string plaintext = this.Usr + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))) + this.Pwd;
				string str = encryptor.Encrypt(plaintext, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwQ1YxZHNhRFpoUnpGUFZrWlZNRmRYY0VwT1JURTJWVlJLWVZaR2NIRlhiWEJQWVd4bmQyRkZTbFpOUjJodFZERlNiazVXYkZoV1dHUmhVa2ROZVZSVlVrSmxWVEZJVjFoclBRPT0=")))))))));
				string text2 = this.ReadHTMLCode(this.ServerURL + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrUlRGcFRXMVNkMWx0YzNoalIwcHdUME01V2xkRlNuZFZSa1U1VUZFOVBRPT0=")))))))) + str).Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFkak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				bool flag = text2 != null;
				if (flag)
				{
					result = text2;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004374 File Offset: 0x00002574
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000043A0 File Offset: 0x000025A0
		private string ReadHTMLCode(string URL)
		{
			string result;
			try
			{
				WebClient webClient = new WebClient();
				byte[] bytes = webClient.DownloadData(URL);
				UTF8Encoding utf8Encoding = new UTF8Encoding();
				result = utf8Encoding.GetString(bytes);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000007 RID: 7
		private string Usr = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000008 RID: 8
		private string Pwd = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x04000009 RID: 9
		private string Hardware = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x0400000A RID: 10
		private string SoftIndex = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x0400000B RID: 11
		private string RandomKey = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));

		// Token: 0x0400000C RID: 12
		private string ServerURL = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlRXcEdkMWx0TUhoaFIxWkpWRzVhWVdKc1JqRlhWRWsxWkVWM2VWUnRPVnBYUlVwdldXdGtNMlJzYkZsUmJrSk5ZbXRLZGxrd1RUUlFVVDA5"))))))));
	}
}
