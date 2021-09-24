using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using maxcare;

namespace MCommon
{
	// Token: 0x02000047 RID: 71
	internal class CommonSQL
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0003185C File Offset: 0x0002FA5C
		public static bool CheckExitsFile(string name)
		{
			return Connector.Instance.ExecuteScalar(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFVVlpzVlRGV1ZYUkVZak5DU2xKV2NGUldSRUYzV2pGd2RHSklUbUZYUlRGdVZtcENiMUpzVm5KV1YyUnBZbFZhTUZkc1VYZGlaejA5")))))))) + name + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNVbkpWVjJSYVZqQTBkMWxXYUdGaVJrSlZVbFJqUFE9PQ=="))))))))) > 0;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00031918 File Offset: 0x0002FB18
		public static DataTable GetAllFilesFromDatabase(bool isShowAll = false)
		{
			DataTable result = new DataTable();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = !isShowAll;
				if (flag)
				{
					query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOa1ZteFlUVmQ0U2xJeGNEVlpha2wzV2pGd2RHSklUbUZYUlRGdVdrUktiMkpIVG5SV1YyUmFWakEwZDFsV2FHRmlSa0pWVWxRd1BRPT0="))))))));
				}
				else
				{
					query = string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOa1ZteFlUVmQ0U2xJeGNEVlpha2wzV2pGd2RHSklUbUZYUlRGdVdrUktiMkpIVG5SV1YyUmFWakEwZDFsV2FHRmlSa0pWVWxka1YxWlVWa3RXUkVFd1dqRlZkMVpyTVZOV1ZUVldVMVZOZDJWRmJFWlNiRkpLVWpKNGNsUkZUa0ppWnowOQ==")))))))),
						Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSklZV3RrZWxFd1NqQk9SMG94WWtacmVFMUVNRDA9"))))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNWalZSYmxaYVZucEdjMU5WV2xkVU1VNVdUMVU1U2xKck5VZFdSVlpYVWtaYVJGRlVWbEJXUjNNeFZERlNjbG94UmxkVVYyUm9WakZHZWxOVlRtcFFVVDA5")))))))),
						Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wQ1QySjZVbWxrVlRWcFlWVktNVmxWWkhWaFNGVXdVbXBHU2xOR1NuWmxTRXBDV2pKS2JGSjZaSGRXTURWcg=="))))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNWalZSYmxaYVZucEdjMU5WVlRWVk1VcEdWbXhPU2xKVmNHRlRWV1J6WVRCc1JsSnNVbEprZWpBNQ=="))))))))
					});
				}
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00031BB0 File Offset: 0x0002FDB0
		public static DataTable GetAllFilesFromDatabaseForBin(bool isShowAll = false)
		{
			DataTable result = new DataTable();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = !isShowAll;
				if (flag)
				{
					query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOa1ZteFlUVmQ0U2xJeGNEVlpha2wzV2pGd2RHSklUbUZYUlRGdVZtcENiMUpzVm5KV1YyUm9WakZHYmxVeFZUQmFNSFJIVkd0YVZWSldXa1ZXYTA1RFVsWk9WMVJzVmxSV1ZGWkZWbXRPUTJOR2NFaFhia0pwVWpGV2JsVnRlRXRWUmxKVVVXMW9XazFyTlRKYVJtTXhUVWRPTlZGc2FGUlNWbHBVVld4T1EyRkdhM3BWYmtKcllsWlZOVlJWVG5KUVVUMDk="))))))));
				}
				else
				{
					query = string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOa1ZteFlUVmQ0U2xJeGNEVlpha2wzV2pGd2RHSklUbUZYUlRGdVZtcENiMUpzVm5KV1YyUm9WakZHYmxVeFZUQmFNSFJIVkd0YVZWSldXa1ZXYTA1RFVsWk9WMVJzVmxSV1ZGWkZWbXRPUTJOR2NFaFhia0pwVWpGV2JsVnRlRXRWUmxKVVVXMW9XazFyTlRKYVJtTXhUVWRPTlZGc2FGUlNWbHBVVld4T1EyRkdhM3BWYmtKcllsWlZOVlJWVG5KYU1WcFdUbFZ3VlUxRVVtNVdWRUpYVkZaS1ZsUnNWa3BSZWtJMFUxVldSMVpGYkVoaVIzUk5VVEJHZFE9PQ==")))))))),
						Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSklZV3RrZWxFd1NqQk9SMG94WWtacmVFMUVNRDA9"))))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNWalZSYmxaYVZucEdjMU5WV2xkVU1VNVdUMVU1U2xKck5VZFdSVlpYVWtaYVJGRlVWbEJXUjNNeFZERlNjbG94UmxkVVYyUm9WakZHZWxOVlRtcFFVVDA5")))))))),
						Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wQ1QySjZVbWxrVlRWcFlWVktNVmxWWkhWaFNGVXdVbXBHU2xOR1NuWmxTRXBDV2pKS2JGSjZaSGRXTURWcg=="))))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNWalZSYmxaYVZucEdjMU5WVlRWVk1VcEdWbXhPU2xKVmNHRlRWV1J6WVRCc1JsSnNVbEprZWpBNQ=="))))))))
					});
				}
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00031E48 File Offset: 0x00030048
		public static bool InsertFileToDatabase(string namefile)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XVnNjRmxUYWtKS1VqSjRNVnBGWXpSYU1YQjBZa2hPWVZkRk1XNWFSekZIWXpKU1dGWnVjRXhTZWxWNFdXdGtNMk13Y0ROUVZEQTk=")))))))),
					namefile,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					DateTime.Now.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00yVkZkRkpRVkRBOQ=="))))))))
				});
				Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00031FC0 File Offset: 0x000301C0
		public static bool UpdateFileNameToDatabase(string idFile, string nameFile)
		{
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VqRndkMWxyWkZkbGEyeEhWR3RhVjFFd1NqRlhWbU40WWtaQ1ZGbDZNRDA9")))))))) + nameFile + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyVVhkUVVUMDk=")))))))) + idFile;
				return Connector.Instance.ExecuteNonQuery(query) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000320B4 File Offset: 0x000302B4
		public static bool DeleteFileToDatabase(string idFile)
		{
			bool result = false;
			try
			{
				bool flag = Connector.Instance.ExecuteScalar(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFVVlpzVlRGV1ZYUklZa2QwWVdKWGVIcFhiRTV5V2pGS2MxTnNRbFZWTUVwdlYxUktUMlJ0VWxoT1ZFSnFaVlZLV1ZVd1ZsZFZNVXBVVVc1Q1lWSXhjSGRaYTJSV1QxRTlQUT09")))))))) + idFile) == 0;
				bool flag2 = flag;
				if (flag2)
				{
					result = (Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1YQjBZa2hPWVZkRk1XNWFSRXB2WWtkT2RGWlhaR2hXTVVVMQ==")))))))) + idFile) > 0);
				}
				else
				{
					bool flag3 = Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VqRndkMWxyWkZkbGEyeEhWR3RhVjFFd1NtOVhWRTVUWTBkU2RGWlViRTVSTUVsNldWVmtWMlZXY0ZSUmJrSmhVa1JCT1E9PQ==")))))))) + idFile) > 0;
					if (flag3)
					{
						result = CommonSQL.DeleteAccountByIdFile(idFile);
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00032250 File Offset: 0x00030450
		public static bool UpdateMultiField(string field, List<string> lstId_FieldValue, string table = "accounts")
		{
			List<string> list = new List<string>();
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			for (int i = 0; i < lstId_FieldValue.Count; i++)
			{
				text = lstId_FieldValue[i].Split(new char[]
				{
					'|'
				})[0];
				text2 = lstId_FieldValue[i].Split(new char[]
				{
					'|'
				})[1];
				bool flag = !string.IsNullOrEmpty(text);
				if (flag)
				{
					list.Add(text);
					text3 = string.Concat(new string[]
					{
						text3,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wQ2IxSnNVbkJSVnpROQ==")))))))),
						text,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExWldUa1pXYXpsS1VUSk5PUT09")))))))),
						text2,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1FsQlJQVDA9"))))))))
					});
				}
			}
			string query = string.Concat(new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VWUXdPUT09")))))))),
				table,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWYVQxSnNXa1JSVkRBOQ==")))))))),
				field,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWUmQxb3hSWGRTYkZKVFZUQktkMWRyVGtKUVVUMDk=")))))))),
				text3,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4Vk1WSlZiRWRhUld4VFZtdHdSMU5WWkhOaE1HeEdZa1U1VEZFeVRUaz0=")))))))),
				string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))), list),
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NrNHdiRUpRVkRBOQ=="))))))))
			});
			return Connector.Instance.ExecuteNonQuery(query) > 0;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00032710 File Offset: 0x00030910
		public static bool DeleteFileToDatabaseIfEmptyAccount()
		{
			bool result = false;
			try
			{
				result = (Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1YQjBZa2hPWVZkRk1XNWFSRXB2WWtkT2RGWlhaR2hXTVVadVZrZHpOVlpWYkVaaVJUbEtVVEpvVlZWc1ZqUlNiRVY0VlZka1UxSlhlRlZXYTFaelZERkZlRlZYWkdoV01VcDBXVlprTkdKRmJFWlhiRTVWVFVSQ2JsZFdaRTloYlVsNlZtNVdhMU5GTVhjPQ=="))))))))) > 0);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000327AC File Offset: 0x000309AC
		public static DataTable GetAllInfoFromAccount(List<string> lstIdFile, bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = lstIdFile == null || lstIdFile.Count == 0;
				if (flag)
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2IySkhUblJXVjJSYVZqQTBkMWxXYUdGaVJrSlNVRlF3UFE9PQ==")))))))) + (isGetActive ? 1 : 0).ToString();
				}
				else
				{
					text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tSS2IySkhUblJXVjJSb1ZqRktkRmxXWkRSaVJXeEdZa1U1U2xFeVl6az0=")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstIdFile) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGT1ExRnNVbkpWVjJSYVZqQTBkMWxXYUdGaVJrSlNVRlF3UFE9PQ==")))))))) + (isGetActive ? 1 : 0).ToString();
				}
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSk9NRlJXVG1wYU1XeFpWRmRrYUZZeFJucFRWVTVxVUZFOVBRPT0=")))))))),
					Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm5wR1ZXRklWbmhXYWtKS1VqRkNiMlJZUms1YU1sSk9WRE5PYVdKWFpHNWFSV2hOWVVoV2VGSnVWbUZOVkVFNQ=="))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExRnNWalZSYmxaYVZucEdjMU5WV2xkVU1VNVdUMVU1U2xORk5YTlphMlJYWVcxU1JGRnJWbFJXYXpWV1ZURlZNVkpHV2tSUlZ6Vk9VVEpPYmxkV2FFNWFNa1pZVlZoT2FGWjZWblJaYm14RFlsZE9kRTlZVWtwU01GcHhWMVJKTlUxWFNuVlZibkJLVVZRd09RPT0=")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWVk5WVXhTa1pXYkU1S1VsVndZVk5WWkhOaE1HeEdVbXhTVW1SNk1Eaz0="))))))))
				});
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00032B44 File Offset: 0x00030D44
		public static bool InsertAccountToDatabase(string uid, string pass, string token, string cookie, string email, string phone, string name, string friends, string groups, string birthday, string gender, string info, string backup, string fa2, string idFile, string emaiRecovery = "", string passMail = "", string useragent = "", string proxy = "")
		{
			bool result = true;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1XeFlWRzF3YVUweFdqRmFSV2hPWWpKU1dHSkhkRTFSTUVvelYxWm9UMlZyZUVsVmJscG9UV3hhTVZSRlpFOWtiVWw1WkVoQ1lWWkZWbnBYYkdONFlVZEdXR1F6VG1saVZWb3dWMnhPTkdKWFRuUmlSM2hwWWxaS05sUkZaR3RsVjBsNlZtNWthbVZZYUhCWlZtaExUVWRHU0ZWdGFHeFZNMmgxVjJ4ak1XRXhjRmxUV0U1b1ZucFdkRmx1YkRSaVZteFZVMWhPV21KVlduRlpWRTVYWkRCNFNHSkhkR0ZpVjNoNlYyeE9OR1F4YkZsVWJuQnBWakJhZDFsclRqUk5WMDE1Vm01c1dsWXlVbk5aYlRWU1l6Sk9TVk51V214VFIzUjZWMnRrUjAxR2NGWmlTRkpxVW5wc05WcEZUalJoUm10NlZXNUNhMkpXVm5kVFZWcGhVV3hTUjFacldsWmxWMlIxV2xod1EwOVZjRFZrTWpWc1pXdFpOVk51YkROaWJWWTJVMnBzUzJWWVpIVmFXSEJQVDFWd05XUXlOV3hsYkVrMVUyNXNNMkp0VmpaV2FteExaVmhrZFZwWWNHRlBWWEExWkRJMWJHVnRVVFZUYm13elltMVdObUZFYkV0bFdHUjFXbGh3YzA5VmNEVmtNalZzWld0V00xcHNUbXBqTUc5Nll6Tm9UbGRFUW5WVVJVNXJUakF4VlZOcWJFdGxXR1IxV2xod1JtVnRXbFJaTTA1TFRUTk9ORlJyWjNkaWEzaEVXa1JrVGxaR1dUVlRibXd6WW0xV05sSlVTbTFWTWs1NlUycE9lbVZGTkhwTlJ6Vk5Va1ZXZHc9PQ=="))))))));
				text = string.Format(text, new object[]
				{
					uid,
					pass.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					token,
					cookie,
					email,
					name,
					friends,
					groups,
					birthday,
					gender,
					info,
					fa2,
					backup,
					idFile,
					passMail,
					useragent,
					proxy,
					DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0=")))))))))
				});
				Connector.Instance.ExecuteQuery(text);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00032DC4 File Offset: 0x00030FC4
		public static List<string> ConvertToSqlInsertAccount(List<string> lstSqlStatement)
		{
			List<string> list = new List<string>();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstSqlStatement.Count * 1.0 / (double)num)));
				string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < num2; i++)
				{
					item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1XeFlWRzF3YVUweFdqRmFSV2hPWWpKU1dHSkhkRTFSTUVvelYxWm9UMlZyZUVsVmJscG9UV3hhTVZSRlpFOWtiVWw1WkVoQ1lWWkZWbnBYYkdONFlVZEdXR1F6VG1saVZWb3dWMnhPTkdKWFRuUmlSM2hwWWxaS05sUkZaR3RsVjBsNlZtNWthbVZZYUhCWlZtaExUVWRHU0ZWdGFHeFZNMmgxVjJ4ak1XRXhjRmxUV0U1b1ZucFdkRmx1YkRSaVZteFZVMWhPYUZZeFNuUlpWbVEwWWtWNFNWRnRhR3BOTURVd1YxWmtjMk13ZUVsV2JuQmhWMFZ3YjFkcVNsZGtWMUpFWlVoa2FtSlVhekJhVms0MFlURnNXVlZ0ZUZSV2VrWXpXV3BPUzAxRmVFaFNiWEJyVWpKM2VWZHNUbkphTVZweVVtc3hWMVpXV2xWVFZVVTVVRkU5UFE9PQ==")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstSqlStatement.GetRange(num * i, (num * i + num <= lstSqlStatement.Count) ? num : (lstSqlStatement.Count % num)));
					list.Add(item);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00032F88 File Offset: 0x00031188
		public static string ConvertToSqlInsertAccount(string uid, string pass, string token, string cookie, string email, string name, string friends, string groups, string birthday, string gender, string info, string fa2, string idFile, string passMail, string useragent, string proxy)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpCT2EwNHdNVWxOUnpWTlVUSlJNMVJXWjNkaWEzaEVXa1JrVG1KcVFuVlVSVTVyVGpBd2VrMUhOVTFSTWxFelZHdG5kMkpyZUVSYVJHUlBWMFJDZFZSRlRtdE9NRFYxVFVjMVRWRXlVVE5VYWsxM1ltdDRSRnBFWkZCVFJFSjFWRVZPYTA0d09WbE5SelZOVVRKUk0xUldVa05QVlhBMVpESTFiR1ZyVmpSYWJFNXFZekJ2ZW1NemFFNWlha0oxVkVWT2EwNHdNVlZVYW14TFpWaGtkVnBZY0VaTlIxcFVXVE5PUzAwelRqUlViR2QzWW10NFJGcEVaRTVXUm04MVUyNXNNMlZGZEZKUVZEQTk="))))))));
				text = string.Format(text, new object[]
				{
					uid,
					pass.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					token,
					cookie,
					email,
					name.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					friends,
					groups,
					birthday,
					gender,
					info,
					fa2,
					idFile,
					passMail,
					useragent,
					proxy,
					DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0=")))))))))
				});
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000332B8 File Offset: 0x000314B8
		public static bool UpdateFieldToAccount(string id, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = fieldName == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ=="))))))));
				if (flag)
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1EyUXhiRmxVYm5CWlRXcHNlbGRyVVhoa01XeFpWRzV2UFE9PQ=="))))))));
				}
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xORk5YTmFSVTVDVUZFOVBRPT0=")))))))),
					fieldName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWUmQxb3djRE5RVkRBOQ==")))))))),
					fieldValue.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))),
					@string,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb2EySXhjRmxUYlhoS1VqSjRjbFZHUlRsUVVUMDk=")))))))),
					id
				});
				bool flag2 = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag2;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00033618 File Offset: 0x00031818
		public static bool UpdateMultiFieldToAccount(string id, string lstFieldName, string lstFieldValue, bool isAllowEmptyValue = true)
		{
			bool result = false;
			try
			{
				bool flag = lstFieldName.Split(new char[]
				{
					'|'
				}).Length == lstFieldValue.Split(new char[]
				{
					'|'
				}).Length;
				if (flag)
				{
					int num = lstFieldName.Split(new char[]
					{
						'|'
					}).Length;
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int i = 0; i < num; i++)
					{
						bool flag2 = !isAllowEmptyValue && lstFieldValue.Split(new char[]
						{
							'|'
						})[i].Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
						if (!flag2)
						{
							text = string.Concat(new string[]
							{
								text,
								lstFieldName.Split(new char[]
								{
									'|'
								})[i],
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVaT2FsQlJQVDA9")))))))),
								lstFieldValue.Split(new char[]
								{
									'|'
								})[i].Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
								Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))))
							});
						}
					}
					text = text.TrimEnd(new char[]
					{
						','
					});
					string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xORk5YTmFSVTVDVUZFOVBRPT0=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb2EySXhjRmxUYlhoS1VqSjRjbFZHUlRsUVVUMDk=")))))))) + id;
					result = (Connector.Instance.ExecuteNonQuery(query) > 0);
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00033A40 File Offset: 0x00031C40
		public static bool UpdateMultiFieldToAccount(List<string> lstId, string lstFieldName, string lstFieldValue)
		{
			bool result = false;
			try
			{
				bool flag = lstFieldName.Split(new char[]
				{
					'|'
				}).Length == lstFieldValue.Split(new char[]
				{
					'|'
				}).Length;
				if (flag)
				{
					int num = lstFieldName.Split(new char[]
					{
						'|'
					}).Length;
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int i = 0; i < num; i++)
					{
						text = string.Concat(new string[]
						{
							text,
							lstFieldName.Split(new char[]
							{
								'|'
							})[i],
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVaT2FsQlJQVDA9")))))))),
							lstFieldValue.Split(new char[]
							{
								'|'
							})[i].Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))))
						});
					}
					text = text.TrimEnd(new char[]
					{
						','
					});
					int num2 = 100;
					int num3 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num2)));
					List<string> list = new List<string>();
					string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int j = 0; j < num3; j++)
					{
						item = string.Concat(new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xORk5YTmFSVTVDVUZFOVBRPT0=")))))))),
							text,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb2EySXhjRmxUYlhoS1VqSjRjbE5WVm5OVU1HeEVXbm93UFE9PQ==")))))))),
							string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstId.GetRange(num2 * j, (num2 * j + num2 <= lstId.Count) ? num2 : (lstId.Count % num2))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))
						});
						list.Add(item);
					}
					bool flag2 = Connector.Instance.ExecuteNonQuery(list) > 0;
					result = flag2;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00033F90 File Offset: 0x00032190
		public static bool UpdateFieldToFile(string idFile, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqRndkMWxyWkZkbGEyeEpWRzE0YTFFd1JUaz0=")))))))),
					fieldName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWUmQxb3djRE5RVkRBOQ==")))))))),
					fieldValue.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyVVhkUVVUMDk=")))))))),
					idFile
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000341B8 File Offset: 0x000323B8
		public static bool UpdateFieldToAccount(List<string> lstId, string fieldName, string fieldValue)
		{
			bool result = false;
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = fieldName == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ=="))))))));
				if (flag)
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1EyUXhiRmxVYm5CWlRXcHNlbGRyVVhoa01XeFpWRzV2UFE9PQ=="))))))));
				}
				for (int i = 0; i < num2; i++)
				{
					item = string.Concat(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xORk5YTmFSVTVDVUZFOVBRPT0=")))))))),
						fieldName,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWUmQxb3djRE5RVkRBOQ==")))))))),
						fieldValue.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))),
						@string,
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb2EySXhjRmxUYlhoS1VqSjRjbE5WVm5OVU1HeEVXbm93UFE9PQ==")))))))),
						string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstId.GetRange(num * i, (num * i + num <= lstId.Count) ? num : (lstId.Count % num))),
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))
					});
					list.Add(item);
				}
				bool flag2 = Connector.Instance.ExecuteNonQuery(list) > 0;
				result = flag2;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00034694 File Offset: 0x00032894
		public static bool UpdateFieldToFile(List<string> lstId, string fieldName, string fieldValue)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqRndkMWxyWkZkbGEyeEpWRzE0YTFFd1JUaz0=")))))))),
					fieldName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWUmQxb3djRE5RVkRBOQ==")))))))),
					fieldValue,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyVGtOVGJGSndVVmM0UFE9PQ==")))))))),
					string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstId),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000348C0 File Offset: 0x00032AC0
		public static DataTable GetAccFromFile(List<string> lstIdFile = null, string info = "", bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm1wQ2IxSnNWbkpXVjJNOQ=="))))))));
				string text2 = (lstIdFile != null && lstIdFile.Count > 0) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWU1JtUlhSbGhWYTJSb1ZqTm9jMU5WVm5OVU1HeEVXbm93UFE9PQ==")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstIdFile) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					text = text + text2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ=="))))))));
				}
				string text3 = (info != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWU1JtUlhSbGhPVnpGcFpWVkZOVk5WVG1wUVVUMDk=")))))))) + info + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag2 = text3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					text = text + text3 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ=="))))))));
				}
				string str = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWU1JtUldiRmhVYWtKb1YwWndjMU5WVVhkYU1HOTZZek5rYlZVeVRUaz0=")))))))), isGetActive ? 1 : 0);
				text += str;
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIYkhaak1HeEpWVmhzVFdKVVZtOVpiR1JXV2pGR1YxUlhaR2xpVlZvd1YyeFdZV05IU2toV1YyUlRZa1Z3VVZaR1RrTmhSbXQ1Vkc1YWExWjZWWGRaTTJ4RFRVVXhWRkZyZEZWTlIzaFFVMVZrWVdOSFNraFdibkJLVTBaR05WTlZWVFZVTUd4SlZWaG9UV0pYZUhKWGJURnpZekZ3VlUxVVFrNWhWRlozVjJ0T1FsQlJQVDA9")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWVk5WVXhTa1pXYkU1S1VsVndZVk5WYUZKbFJYaDBZa2QwWVdKWGVIcFhiRVU1VUZFOVBRPT0="))))))));
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00034E30 File Offset: 0x00033030
		public static DataTable GetAccFromUid(List<string> lstUid)
		{
			DataTable result = new DataTable();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstUid.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < num2; i++)
				{
					item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIYkhaak1HeEpWVmhzVFdKVVZtOVpiR1JXV2pGR1YxUlhaR2xpVlZvd1YyeFdZV05IU2toV1YyUlRZa1Z3VVZaR1RrTmhSbXQ1Vkc1YWExWjZWWGRaTTJ4RFRVVXhWRkZyZEZWTlIzaFFVMVZrWVdOSFNraFdibkJLVTBaR05WTlZWVFZVTUd4SlZWaG9UV0pYZUhKWGJURnpZekZ3VlUxVVFrNWhWRlozVjJ0T1ExZEdUa1pXYkU1VFZUQkpkMVJXVFRGTlYwWllWVmRrVkZaVVVtNVRNRTVxVUZFOVBRPT0=")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))), lstUid.GetRange(num * i, (num * i + num <= lstUid.Count) ? num : (lstUid.Count % num))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2Nsb3hiRmhPVjNSS1UwWkdORlJITVVkaGJWSklZa1JLWVZaRVFqUlRWVlUxVlRGS1JsWnNUa3BTVlhCaFUxVm9VbVZGZUhWV2JrSmhVVlF3T1E9PQ=="))))))));
					list.Add(item);
				}
				result = Connector.Instance.ExecuteQuery(list);
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VldwS1YwMUdSbGhVYlhCVFltdHdNbGxzVm1GalIwcElWbFF3UFE9PQ==")))))))));
			}
			return result;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0003509C File Offset: 0x0003329C
		public static DataTable GetAllAccountFromDatabase(bool isGetActive = true)
		{
			DataTable result = new DataTable();
			try
			{
				string query = string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1UwWmFkMWRyVGtOaVYwNTBUMWhTU2xJd1duRlhWRWsxVFZkS2RWVnVjRXBUUjFKMlYyeG9TMkpGYkVoU2JYQnJVakozZVZkc1VYaE9NREZKVFVSalBRPT0=")))))))), isGetActive ? 1 : 0);
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00035158 File Offset: 0x00033358
		public static bool DeleteAccountByIdFile(string idFile)
		{
			bool result = true;
			try
			{
				bool flag = Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xKck5VZFdhMDVEWVVacmVsVnVRbXRpVmxVMVZGVk9NMW94Y0VoU2FrSmhWbFpLYzFsclpGZE5SbkJWVFVjMFBRPT0=")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV2JrNXRTbGhOUkZwcVRUQXhibGRyWkZKa2JGSldUVWhhYkZkSGR6RmFWa1U1VUZFOVBRPT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyWkdGalIwcElWbFJyUFE9PQ==")))))))) + idFile) > 0;
				result = flag;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000352BC File Offset: 0x000334BC
		public static bool DeleteAccountToDatabase(string id)
		{
			try
			{
				return Connector.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xKck5VZFdhMDVEWVVacmVsVnVRbXRpVmxVMVZGVk9NMW94Y0VoU2FrSmhWbFpLYzFsclpGZE5SbkJWVFVjMFBRPT0=")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV2JrNXRTbGhOUkZwcVRUQXhibGRyWkZKa2JGSldUVWhhYkZkSGR6RmFWa1U1VUZFOVBRPT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyVVhkUVVUMDk=")))))))) + id) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00035404 File Offset: 0x00033604
		public static DataTable GetAccFromId(List<string> lstId)
		{
			DataTable result = new DataTable();
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list = new List<string>();
				string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int i = 0; i < num2; i++)
				{
					item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWmFkMWRyVGpOYU1rNUlVbTV3YW1WWVpHNWFSV00xWTJ4d1dFNUlUa3BTTURVeVdXcEtNR05HY0ZWU1dFNWhWbnBHYjFsV1pETmpNR3hKVVcxb2FrMHdOVEJYVm1Sell6QjRSRkZ0TVZwV1JXeHVWVzE0UzFWR1VsUlJiV2hhVFdzMU1scEdZekZOUjA0MVVXeG9WRkpXV2xSVmJFNURZMFp3UkZGcmNGVmhWVVoyVTI1ak9WQlJQVDA9")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))), lstId.GetRange(num * i, (num * i + num <= lstId.Count) ? num : (lstId.Count % num))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))));
					list.Add(item);
				}
				result = Connector.Instance.ExecuteQuery(list);
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VldwS1YwMUdSbGhVYlhCVFltdHdNbGxzVm1GalIwcElWbFF3UFE9PQ==")))))))));
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00035670 File Offset: 0x00033870
		public static bool DeleteAccountToDatabase(List<string> lstId, bool isReallyDelete = false)
		{
			if (isReallyDelete)
			{
				List<string> list = new List<string>();
				DataTable accFromId = CommonSQL.GetAccFromId(lstId);
				for (int i = 0; i < accFromId.Rows.Count; i++)
				{
					string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					for (int j = 0; j < accFromId.Columns.Count; j++)
					{
						text = text + accFromId.Rows[i][j].ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9"))))))));
					}
					text = text.Substring(0, text.Length - 1);
					list.Add(text);
				}
				File.AppendAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyUlZlSFZWYWxKclVWUXdPUT09")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVaUmQwOVdRbFZOUkdzOQ==")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV2JrNXRTbGhOUkZwcVRUQXhibGRyWkZKa2JGSldUVWhhYkZkSGR6RmFWa1U1VUZFOVBRPT0="))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVaUmQwOVdRbFZOUkd4RlZWYzRPUT09")))))))));
				File.AppendAllLines(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFjeGMyUlZlSFZWYWxKclVWUXdPUT09")))))))), list);
			}
			bool result = true;
			try
			{
				int num = 100;
				int num2 = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)lstId.Count * 1.0 / (double)num)));
				List<string> list2 = new List<string>();
				string item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				for (int k = 0; k < num2; k++)
				{
					if (isReallyDelete)
					{
						item = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1XeFlWRzF3YVUweFdqRmFSV2hPV2pKUmVXRkhlR3BpVmxadVdWWmtVbG94VGxaT1IyUk1VVlF3T1E9PQ==")))))))) + string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstId.GetRange(num * k, (num * k + num <= lstId.Count) ? num : (lstId.Count % num))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))));
					}
					else
					{
						item = string.Concat(new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xKck5VZFdhMDVEWVVacmVsVnVRbXRpVmxVMVZGVk9NMW94Y0VoU2FrSmhWbFpLYzFsclpGZE5SbkJWVFVjMFBRPT0=")))))))),
							DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRCV2JrNXRTbGhOUkZwcVRUQXhibGRyWkZKa2JGSldUVWhhYkZkSGR6RmFWa1U1VUZFOVBRPT0="))))))))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1EwMHlSa2hXYm14aFZUQktkMWRyVGtOVGJGSndVVmM0UFE9PQ==")))))))),
							string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))), lstId.GetRange(num * k, (num * k + num <= lstId.Count) ? num : (lstId.Count % num))),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VXpGRk9WQlJQVDA9"))))))))
						});
					}
					list2.Add(item);
				}
				for (int l = 0; l < list2.Count; l++)
				{
					result = (Connector.Instance.ExecuteNonQuery(list2[l]) > 0);
				}
			}
			catch (Exception ex)
			{
				Common.ExportError(null, ex, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1YyTXhjRmxWYlhoU1ZqQTFjVmxxVGxka1YxSkhWVzVhVTFJd1dYZFhWbVJMWVVkTmVWWlVNRDA9")))))))));
			}
			return result;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00035DDC File Offset: 0x00033FDC
		public static bool UpdateAccountByUid(string account)
		{
			string[] array = account.Split(new char[]
			{
				'|'
			});
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text3 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text4 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text5 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text6 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text7 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text8 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			string text9 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			text = array[0];
			bool flag = text.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				text2 = array[1];
				text3 = array[2];
				text4 = array[3];
				text5 = array[4];
				text6 = array[5];
				text7 = array[6];
				text8 = array[7];
				text9 = array[8];
				List<string> list = new List<string>();
				list.Add((text2 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWHBrZWpBOQ==")))))))) + text2) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text3 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWak5XTnNjRmhPVkdjOQ==")))))))) + text3) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text4 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFSSk5XUnRSWGxpUjNoT1YwaGpPUT09")))))))) + text4) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text5 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ4amVHRkhSbGhsUkdjOQ==")))))))) + text5) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text6 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGxOVjJob1ZqTm5OQT09")))))))) + text6) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text7 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweFJtVlhXa0pRVkRBOQ==")))))))) + text7) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text8 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1QySkhUblJTYlRWaFZucFZkMXByUlRsUVVUMDk=")))))))) + text8) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				list.Add((text9 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? (Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCb1MyUnRWa2xpUkdjOQ==")))))))) + text9) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
				string text10 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tab1EyRXhiRmxWYlhoS1VqQmFjVmRVU1RWTlYwcDFWVzV3U2xORk5YTmFSVVU1VUZFOVBRPT0="))))))));
				foreach (string text11 in list)
				{
					bool flag2 = text11 != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag2)
					{
						text10 = string.Concat(new string[]
						{
							text10,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWRk9WQlJQVDA9")))))))),
							text11.Split(new char[]
							{
								'|'
							})[0],
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlVaT2FsQlJQVDA9")))))))),
							text11.Split(new char[]
							{
								'|'
							})[1],
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))))
						});
						bool flag3 = text11.Split(new char[]
						{
							'|'
						})[0] == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUak5RVkRBOQ=="))))))));
						if (flag3)
						{
							text10 += Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RCa1IyVnRUWGhQV0ZwcFVqRkZOVmt3WkVkbGJVNDFaSG93UFE9PQ=="))))))));
						}
					}
				}
				text10 = text10.TrimEnd(new char[]
				{
					','
				});
				text10 = text10 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWb2EySXhjRmxUYlhoS1UwWmFkMWRyVVhkaVp6MDk=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				result = (Connector.Instance.ExecuteNonQuery(text10) > 0);
			}
			return result;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00036C98 File Offset: 0x00034E98
		public static string GetIdFileFromIdAccount(string id)
		{
			try
			{
				return Connector.Instance.ExecuteScalar(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VqSjRjbFZ0TVhOak1YQlVVV3RrVm1GNmJFOVRWV1JIWVd4cmVVOVVSbWxpYkVvMlUxVmFhMU5XU2xkVGExcEtVako0Y2xWR1RtcFFVVDA5")))))))) + id + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))).ToString();
			}
			catch
			{
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00036DC4 File Offset: 0x00034FC4
		public static bool CheckColumnIsExistInTable(string table, string column)
		{
			return Connector.Instance.ExecuteScalar(string.Concat(new string[]
			{
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFVVlpzVlRGV1ZYUkVZak5DU2xKVldsVlRWV1JQWkcxU1dFNVVRa3BTVm5CVVZrUkJkMW95VGtsVGJXaGhUV3BHYjFkRVRsTmhSbXgwWlVkNFdVMXRlREZYYlRBMFlqQndNMUJVTUQwPQ==")))))))),
				table,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2Nsb3hXWGRoUlZwV1lURldibGx0TVVka1JuQlZUVWMwUFE9PQ==")))))))),
				column,
				Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))
			})) > 0;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00036EF8 File Offset: 0x000350F8
		public static bool CheckExistTable(string table)
		{
			return Connector.Instance.ExecuteScalar(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFVVlpzVlRGV1ZYUkVZak5DU2xKV2NGUldSRUYzV2pKTmVsSnVUbWhYUmtwelYwUkplR0ZIVFhwVmJYaHFZVlZLV1ZVd1ZsZFZNVXBVVVdwQ2JGZEZTbk5WUms1clRVWnNXRk51VG1GVk1rNXVWVlpWTVZKVmJFaE9WMmhwVmpGVk5WTnVZemxRVVQwOQ==")))))))) + table + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1d2VsQlJQVDA9"))))))))) > 0;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00036FB4 File Offset: 0x000351B4
		public static bool AddColumnsIntoTable(string table, string columnName, int typeColumnData)
		{
			bool result = false;
			try
			{
				bool flag = Connector.Instance.ExecuteNonQuery(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZaV05GWldTbGRUVjJSWFVsVmFSRlpGVmxaYWR6MDk=")))))))),
					table,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxSldTa1JSYTFKVlRVaG9WMVpHVlRCYU1IQXpVRlF3UFE9PQ==")))))))),
					columnName,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1FsQlJQVDA9")))))))),
					(typeColumnData == 0) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWlJQVDA9")))))))) : Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10V1YxZFdXa0pRVkRBOQ==")))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkROak9WQlJQVDA9"))))))))
				})) > 0;
				if (flag)
				{
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00037220 File Offset: 0x00035420
		public static bool InsertInteractToDatabase(string uid, string hanhDong, string cauHinh)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1rWllUbFJDWVZkRmNHOVhWRTVUWld0MFNWWnVRbUZSTTJSdVdrVmtjMlJHY0ZaaVNGWnJVakZhTlZkV1pFOU5SWGhJWVVkb2FXSlhhRVpaYWtreFltdDRTRlJ0YUd0V1YyaDNXVzB4Ym1ORmJFZFhhMHBWVW14YVIxWlliRUppTUhBelVGUXdQUT09")))))))),
					uid,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0="))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					hanhDong,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					cauHinh,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))))
				});
				Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00037490 File Offset: 0x00035690
		public static List<BaiViet> GetListBaiVietByID(string id)
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOTlJuQllUbFZTYUZOR1drWlhiRTQwWkZadmVWSnFWbXRTTUZveVZFVm9VMk5HY0ZsV2JYUmhWVE5vYjFsdE1XNWpNbEowWWtkMFlWWjZhSHBaYlRBMVkwWndTVlp1Vm1GbFZVcDBXVEl3TldSRmJFWlRiV2hvVm14d2QxZHNhRkphTVZsM1lVVmFWbUV4Vm01WlZtUlNXakZDVkZGVU1EMD0=")))))))) + id;
				DataTable source = Connector2.Instance.ExecuteQuery(query);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00037568 File Offset: 0x00035768
		public static List<string> GetListChuDe()
		{
			List<string> list = new List<string>();
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1UwWktjMWx0YkVOaVYwNTBUMWhTU2xKVk5YWmFSbFpUWWtVNU0xQlVNRDA9"))))))));
				DataTable dataTable = Connector2.Instance.ExecuteQuery(@string);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					list.Add(dataTable.Rows[i][0].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00037650 File Offset: 0x00035850
		public static List<BaiViet> GetListBaiViet(string tenChuDe = "")
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = tenChuDe != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGYUZOaVIwcDBWRzA1YTFZeFNuTlVSV014WW14c1dXSkVRbHBXZW1oNldrVmtjMkpIVWxoVmJYaE5VakJhTVZsVlRqUk5iVVpZVlcxNGFXVllhREZaYWtwellUSlNXRTVYTlVwU01YQTFXV3BKZDFveFJuUlNia0pYWWxkNGMxcEZUa05YUms1R1ZteE9VMVV3U1hkWGJHTXhZVzFHU1ZadGRHRldSRUox")))))))) + tenChuDe + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				}
				else
				{
					query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGYUZOaVIwcDBWRzA1YTFZeFNuTlVSV014WW14c1dXSkVRbHBXZW1oNldrVmtjMkpIVWxoVmJYaE5VakJhTVZsVlRqUk5iVVpZVlcxNGFXVllhREZaYWtwellUSlNXRTVYTlVwU01YQTFXV3BKZDFveFJuUlNia0pYWWxkNGMxcEZSVGxRVVQwOQ=="))))))));
				}
				DataTable source = Connector2.Instance.ExecuteQuery(query);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00037860 File Offset: 0x00035A60
		public static bool DeleteBaiViet(int id)
		{
			bool result = false;
			bool flag = Connector2.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1VWjBVbTVDVjJKWGVITmFSVTVEVFRKR1NGWnViR0ZWTUVwM1YydFJkMUJSUFQwPQ==")))))))) + id.ToString()) > 0;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000378F0 File Offset: 0x00035AF0
		public static bool DeleteChuDe(string ten)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1VVjVZVVJHVTFJeFZtNWFSRXB2WWtkT2RGWlhaR3RTTVZveFZVWk9hbEJSUFQwPQ==")))))))) + ten + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				bool flag = Connector2.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					CommonSQL.DeleteBaiVietByChuDe(ten);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00037A0C File Offset: 0x00035C0C
		public static bool DeleteBaiVietByChuDe(string tenChuDe)
		{
			bool result = false;
			bool flag = Connector2.Instance.ExecuteNonQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1YyTXhjRmxWYlhoS1VqRndOVmxxU1hkYU1VWjBVbTVDVjJKWGVITmFSVTVEVFRKR1NGWnViR0ZWTUVsM1YyeGpNV0Z0UmtsV2JYUmhWa1JDZFE9PQ==")))))))) + tenChuDe + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))) > 0;
			if (flag)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00037ADC File Offset: 0x00035CDC
		public static bool AddChuDe(string ten)
		{
			bool result = true;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XVnNjRmxUYWtKS1VqSjRNVnBGWXpSYU1VVjVZVVJHVTFJeFZtNWFSekZIWXpKU1dGWnVjRXhSTWswNQ==")))))))) + ten + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))));
				Connector2.Instance.ExecuteNonQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00037BCC File Offset: 0x00035DCC
		public static List<BaiViet> GetBaiVietNewest()
		{
			List<BaiViet> result = new List<BaiViet>();
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YyTXhjRmhVYWtKS1VqSjRjbFJGVGtOTlJuQllUbFZTYUZOR1drWlhiRTQwWkZadmVWSnFWbXRTTUZveVZFVm9VMk5HY0ZsV2JYUmhWVE5vYjFsdE1XNWpNbEowWWtkMFlWWjZhSHBaYlRBMVkwWndTVlp1Vm1GbFZVcDBXVEl3TldSRmJFWlRiV2hvVm14d2QxZHNhRkphTVZGNFUydFdVMVpyYkc1VlYzaHlXakpHV0ZWWFpGTlNWbHBWVlZoc1ExUldUbFpOVlhCWFVUQkdOQT09"))))))));
				DataTable source = Connector2.Instance.ExecuteQuery(@string);
				result = (from rw in source.AsEnumerable()
				select new BaiViet
				{
					id = Convert.ToInt32(rw["id"]),
					tenChuDe = Convert.ToString(rw["tenChuDe"]),
					ngayTao = Convert.ToString(rw["ngaytao"]),
					anh = Convert.ToString(rw["anh"]),
					video = Convert.ToString(rw["video"]),
					tieuDe = Convert.ToString(rw["tieude"]),
					noiDung = Convert.ToString(rw["noidung"])
				}).ToList<BaiViet>();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00037C98 File Offset: 0x00035E98
		public static bool UpdateBaiViet(int id, BaiViet baiviet)
		{
			bool result = true;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = baiviet.tieuDe != null;
				if (flag)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa2MySkhVbGhWYlhoS1VrUkNibE51WXpsUVVUMDk=")))))))) + baiviet.tieuDe.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag2 = baiviet.anh != null;
				if (flag2)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjFaak1XSXdiRVZOUjJSTFpIb3dPUT09")))))))) + baiviet.anh + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag3 = baiviet.noiDung != null;
				if (flag3)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwd05XTkdjRWxXYmxaaFpWVkZOVk5WVG1wUVVUMDk=")))))))) + baiviet.noiDung.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))) + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag4 = baiviet.ngayTao != null;
				if (flag4)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cweGEyRkhWbGxWYldocFpWVkZOVk5WVG1wUVVUMDk=")))))))) + baiviet.ngayTao + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag5 = baiviet.tenChuDe != null;
				if (flag5)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tWa1YyUldhM2xoUkVaaFVqRldibFZHVGtKaVp6MDk=")))))))) + baiviet.tenChuDe + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag6 = baiviet.video != null;
				if (flag6)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeGMyRXhjRmhQUjJSUlZUQkdkUT09")))))))) + baiviet.video + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				text = text.TrimEnd(new char[]
				{
					','
				});
				bool flag7 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag7)
				{
					string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsVndiMWxXV21GalJuQlpWVmRrVmsxR1dsWlRWVVU1VUZFOVBRPT0=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWYWExTldTbGRUYTFwS1VqSjRjbFZHUlRsUVVUMDk=")))))))) + id.ToString();
					Connector2.Instance.ExecuteNonQuery(query);
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000383A8 File Offset: 0x000365A8
		public static bool UpdateChuDe(string tenCu, string tenMoi)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsVTFkbHBHVmxOaVJXeEhWR3RhVjFFd1NYZFhiR013V2pGQ1ZGRlhORDA9")))))))),
					tenMoi,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExZEdUa1pXYkU1VFZUQkpkMWRzWXpCUFZYQXpVRlF3UFE9PQ==")))))))),
					tenCu,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))
				});
				bool flag = Connector2.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					List<BaiViet> listBaiViet = CommonSQL.GetListBaiViet(tenCu);
					for (int i = 0; i < listBaiViet.Count; i++)
					{
						CommonSQL.UpdateBaiViet(listBaiViet[i].id, new BaiViet
						{
							tenChuDe = tenMoi
						});
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00038584 File Offset: 0x00036784
		public static bool AddBaiViet(string tenchuDe, BaiViet baiviet)
		{
			bool result = true;
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1Zaak1XVnNjRmxUYWtKS1VqSjRNVnBGWXpSYU1VWjBVbTVDVjJKWGVITmFSVTV2VFVad1dFNVZVbWhUUmxwR1YyeE9NMW95VWtoaVIzaHJWakZLYzFSRlRrTmtWMGw1WWtkMGExWjZWblZVUlU1RFpGWnZlVkpxVm10U01Gb3lWRVZPUTJGSFNuUmFNMDVyWWxkNGNsZHNZelJqUld4SlYyMW9hVk5HV25OWk0yeHVZbWM5UFE9PQ==")))))))),
					tenchuDe,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					baiviet.tieuDe.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					baiviet.noiDung.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9"))))))))),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					baiviet.ngayTao,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					baiviet.anh,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00ySm5QVDA9")))))))),
					baiviet.video,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))))
				});
				Connector2.Instance.ExecuteNonQuery(query);
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
