using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace maxcare
{
	// Token: 0x02000188 RID: 392
	public class TwoCaptcha
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x000033A7 File Offset: 0x000015A7
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x000033AF File Offset: 0x000015AF
		public string APIKey { get; private set; }

		// Token: 0x06001069 RID: 4201 RVA: 0x000033B8 File Offset: 0x000015B8
		public TwoCaptcha(string sApiAnticaptcha)
		{
			this.APIKey = sApiAnticaptcha;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00405108 File Offset: 0x00403308
		public bool SolveNormalCapcha(int type, string base64Image, out string result)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = type == 0;
			if (flag)
			{
				string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjeFQyRkhUa2xWYlhCb1VqQldNVmRVU1RWa1FUMDk="))))))));
			}
			else
			{
				string2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyTkZlSFJVYldocVUwWktjVmxWWkVaa1ZtOTZWbTVzYTFWVU1Eaz0="))))))));
			}
			using (WebClient webClient = new WebClient())
			{
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d4a1YwMUhSa2hQVjNNOQ=="))))))))] = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeFIyVnNjRlZYVkVFOQ=="))))))));
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZSS1YwNVJQVDA9"))))))))] = this.APIKey;
				nameValueCollection[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjd05XRXlWbEpRVkRBOQ=="))))))))] = base64Image;
				byte[] bytes = webClient.UploadValues(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlpIb3dPUT09")))))))) + string2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2MyUlZlSFZSYlRscVVWUXdPUT09")))))))), nameValueCollection);
				@string = Encoding.Default.GetString(bytes);
			}
			Thread.Sleep(TimeSpan.FromSeconds(5.0));
			bool flag2 = @string.Substring(0, 3) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtSQ01FOUJQVDA9"))))))));
			bool result2;
			if (flag2)
			{
				string text = @string.Remove(0, 3);
				for (int i = 0; i < 24; i++)
				{
					WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlpIb3dPUT09")))))))),
						string2,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1MySkhUalZPV0dSb1UwVkZkbGxVU2xkT1ZrSlNVRlF3UFE9PQ==")))))))),
						this.APIKey,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIweFIyRnRVa2hpU0ZwcFlXcEdkVmRzYUZKaVYwWllWVlJyUFE9PQ==")))))))),
						text
					}));
					using (WebResponse response = webRequest.GetResponse())
					{
						using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
						{
							string text2 = streamReader.ReadToEnd();
							bool flag3 = text2.Length < 3;
							if (flag3)
							{
								result = text2;
								return false;
							}
							bool flag4 = text2.Substring(0, 3) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtSQ01FOUJQVDA9"))))))));
							if (flag4)
							{
								result = text2.Remove(0, 3);
								return true;
							}
							bool flag5 = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSQ1IxVldSWGRoUlVwWlRVUldVVlpyV1RWVk1VcFdVbXRXV0ZWVU1Eaz0="))))))));
							if (flag5)
							{
								result = text2;
								return false;
							}
						}
					}
					Thread.Sleep(5000);
				}
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2MyUkdjRmhQVkVaclVWUXdPUT09"))))))));
				result2 = false;
			}
			else
			{
				result = @string;
				result2 = false;
			}
			return result2;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00405868 File Offset: 0x00403A68
		public static string ResloveNormalCaptcha(int type, string captchaKey, string imgBase64)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			TwoCaptcha twoCaptcha = new TwoCaptcha(captchaKey);
			bool flag = twoCaptcha.SolveNormalCapcha(type, imgBase64, out @string);
			while (!flag)
			{
				flag = twoCaptcha.SolveNormalCapcha(type, imgBase64, out @string);
				Thread.Sleep(TimeSpan.FromSeconds(2.0));
			}
			return @string;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00405928 File Offset: 0x00403B28
		public bool SolveRecaptchaV2(int type, string googleKey, string pageUrl, out string result)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool flag = type == 0;
			if (flag)
			{
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZjeFQyRkhUa2xWYlhCb1VqQldNVmRVU1RWa1FUMDk="))))))));
			}
			else
			{
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFab1EyTkZlSFJVYldocVUwWktjVmxWWkVaa1ZtOTZWbTVzYTFWVU1Eaz0="))))))));
			}
			string requestUriString = string.Concat(new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlpIb3dPUT09")))))))),
				@string,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVSS2MyUlZlSFZSYlRscVVrUnNlVmRzYUhKUFVUMDk=")))))))),
				this.APIKey,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwd2VHSkhVa2hoU0ZwaFVrUkZlRmw2U2xkbFYwNTBWbTF3V2xkRlNYZFhWRXB2WVVWd2RGcElXbWxOYlZKNlYyeGtNR0pIVmxWTlJEQTk=")))))))),
				googleKey,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIwMVEyRkdiM2xXYWtacVlsaGpOUT09")))))))),
				pageUrl
			});
			try
			{
				WebRequest webRequest = WebRequest.Create(requestUriString);
				using (WebResponse response = webRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
					{
						string text = streamReader.ReadToEnd();
						bool flag2 = text.Length < 3;
						if (flag2)
						{
							result = text;
							return false;
						}
						bool flag3 = text.Substring(0, 3) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtSQ01FOUJQVDA9"))))))));
						if (flag3)
						{
							string text2 = text.Remove(0, 3);
							for (int i = 0; i < 24; i++)
							{
								WebRequest webRequest2 = WebRequest.Create(string.Concat(new string[]
								{
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1ZWb1UwMUhUa1ZpTTFwTlpIb3dPUT09")))))))),
									@string,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVST1MySkhUalZPV0dSb1UwVkZkbGxVU2xkT1ZrSlNVRlF3UFE9PQ==")))))))),
									this.APIKey,
									Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTIweFIyRnRVa2hpU0ZwcFlXcEdkVmRzYUZKaVYwWllWVlJyUFE9PQ==")))))))),
									text2
								}));
								using (WebResponse response2 = webRequest2.GetResponse())
								{
									using (StreamReader streamReader2 = new StreamReader(response2.GetResponseStream()))
									{
										string text3 = streamReader2.ReadToEnd();
										bool flag4 = text3.Length < 3;
										if (flag4)
										{
											result = text3;
											return false;
										}
										bool flag5 = text3.Substring(0, 3) == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmtSQ01FOUJQVDA9"))))))));
										if (flag5)
										{
											result = text3.Remove(0, 3);
											return true;
										}
										bool flag6 = text3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSQ1IxVldSWGRoUlVwWlRVUldVVlpyV1RWVk1VcFdVbXRXV0ZWVU1Eaz0="))))))));
										if (flag6)
										{
											result = text3;
											return false;
										}
									}
								}
								Thread.Sleep(5000);
							}
							result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a2MyUkdjRmhQVkVaclVWUXdPUT09"))))))));
							return false;
						}
						result = text;
						return false;
					}
				}
			}
			catch
			{
			}
			result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14ak1XTnRTblJQVkU1cFlWVktjMWt5TlV0a2JVNXVVRlF3UFE9PQ=="))))))));
			return false;
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x004060B4 File Offset: 0x004042B4
		public static string ResolveRecaptcha(int type, string captchaKey, string ggKey, string pageUrl)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			TwoCaptcha twoCaptcha = new TwoCaptcha(captchaKey);
			bool flag = twoCaptcha.SolveRecaptchaV2(type, ggKey, pageUrl, out @string);
			while (!flag)
			{
				flag = twoCaptcha.SolveRecaptchaV2(type, ggKey, pageUrl, out @string);
				Thread.Sleep(TimeSpan.FromSeconds(2.0));
			}
			return @string;
		}
	}
}
