using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace maxcare.KichBan
{
	// Token: 0x0200018C RID: 396
	internal class InteractSQL
	{
		// Token: 0x060011A0 RID: 4512 RVA: 0x0040E3B8 File Offset: 0x0040C5B8
		public static bool CheckColumnIsExistInTable(string table, string column)
		{
			bool result = false;
			try
			{
				int num = Connector.Instance.ExecuteScalar(string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFVVlpzVlRGV1ZYUkVZak5DU2xKVldsVlRWV1JQWkcxU1dFNVVRa3BTVm5CVVZrUkJkMW95VGtsVGJXaGhUV3BHYjFkRVRsTmhSbXgwWlVkNFdVMXRlREZYYlRBMFlqQndNMUJVTUQwPQ==")))))))),
					table,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2Nsb3hXWGRoUlZwV1lURldibGx0TVVka1JuQlZUVWMwUFE9PQ==")))))))),
					column,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))
				}));
				bool flag = num > 0;
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

		// Token: 0x060011A1 RID: 4513 RVA: 0x0040E538 File Offset: 0x0040C738
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

		// Token: 0x060011A2 RID: 4514 RVA: 0x0040E7A4 File Offset: 0x0040C9A4
		public static DataTable GetKichBanById(string id)
		{
			DataTable result = new DataTable();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3Q0YUZZd05YWlhSRUpMWVVkS2NGRnNhRlJTVmxwVVZXeE9RMU5zY0VkUFZYaG9WakExZGxWWE1VZGtWV3hGVFVkalBRPT0=")))))))) + id;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0040E848 File Offset: 0x0040CA48
		public static string GetTenKichBanById(string id)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VteEtjMWx0ZERCalJtdDVZVVZPV2xaNlVtNVZiWGhMVlVaU1ZGRnJlR2hXTURWMlYwUkNTMkZIU25CUmJHaFVVbFphVkZWc1RrTlRiSEJIVDFWNGFGWXdOWFpWVnpGSFpGVnNSVTFIWXowPQ==")))))))) + id;
				result = Connector.Instance.ExecuteQuery(query).Rows[0][0].ToString();
			}
			catch (Exception ex)
			{
			}
			return result;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0040E948 File Offset: 0x0040CB48
		public static DataTable GetAllKichBan()
		{
			DataTable result = new DataTable();
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3Q0YUZZd05YWlhSRUpMWVVkS2JsQlVNRDA9"))))))));
				result = Connector.Instance.ExecuteQuery(@string);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0040E9E0 File Offset: 0x0040CBE0
		public static DataTable GetKichBanMoi()
		{
			DataTable result = new DataTable();
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3Q0YUZZd05YWlhSRUpMWVVkS2NGRnNRbFpoTVVwSFZsZHNRMUV4WkZSUmEzQmhVbXBzVFZsV1pFOWlNVVowVW01V1NsSldTa2RXVkVKT1dqRlNSbUpGTlZSV2JFWnVWRlpGT1ZCUlBUMD0="))))))));
				result = Connector.Instance.ExecuteQuery(@string);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0040EA78 File Offset: 0x0040CC78
		public static string GetCauHinhFromKichBan(string Id_KichBan)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFiMXBHVm05alIwcDBXakprVTJKRmNGRldSazVEVkVkR1dGUnRPVmxOUlhCdldXMXNRMWRHVGtaV2JFNVRWVEJLUzFkcldUVlVSMFpZVkcwNVVtSlZXakZUVlZGM1duYzlQUT09")))))))) + Id_KichBan;
				result = Connector.Instance.ExecuteQuery(query).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0040EBB8 File Offset: 0x0040CDB8
		public static bool SaveCauHinhFromKichBan(string Id_KichBan, string cauHinh)
		{
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsaFNkMWRVU205YWJFWjBVbTVXU2xKck5VZFdhMDVEVWtac1dWWnJiR2hXZWxaMlUxVlJkMW93Y0ROUVZEQTk=")))))))) + cauHinh + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExZEdUa1pXYkU1VFZUQktTMWRyV1RWVVIwWllWRzA1VW1KVldqRlRWVkYzV25jOVBRPT0=")))))))) + Id_KichBan;
				return Connector.Instance.ExecuteNonQuery(query) > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0040ECAC File Offset: 0x0040CEAC
		public static bool CheckExistTenKichBan(string tenKichBan)
		{
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsZDRjbGRFUWpCalJtdDVZVVZPV2xaNlVtNVZiWGhMVlVaU1ZGRnJlR2hXTURWMlYwUkNTMkZIU25CUmJHaFVVbFphVkZWc1RrTldWbkJZVGxWNGFGWXdOWFpWVnpGSFpGVnNSVTFIWkV0a2VqQTU=")))))))) + tenKichBan + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				bool flag = Connector.Instance.ExecuteQuery(query).Rows.Count > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0040EDB4 File Offset: 0x0040CFB4
		public static bool InsertKichBan(string tenKichBan)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1VMTVZa2R3YUZKcWJFUlhWbU13V2pCMFIxVnRlR2xoTTFKM1YxUktiMUV4YkZoT1NFSktVbXh3UTFaRldsZFNiRlkxVVZjNVMyUjZNRGs9")))))))) + tenKichBan + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))));
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011AA RID: 4522 RVA: 0x0040EEB0 File Offset: 0x0040D0B0
		public static bool UpdateKichBan(string id, string tenKichBanMoi)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsaFNkMWRVU205YWJFWjBVbTVXU2xKck5VZFdhMDVEVmxad1dFNVZlR2hXTURWMlZWY3hSMlJWYkVWTlIyUkxaSG93T1E9PQ==")))))))) + tenKichBanMoi + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c1ExZEdUa1pXYkU1VFZUQktTMWRyV1RWVVIwWllWRzA1VW1KVldqRlRWVkYzV25jOVBRPT0=")))))))) + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011AB RID: 4523 RVA: 0x0040EFB0 File Offset: 0x0040D1B0
		public static bool DeleteKichBan(string id)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0V1YxUldTbGRWYTFwS1VsWndWRlpFUVhkYU1VMTVZa2R3YUZKcWJFUlhWbU13V2pGWmQyRkZXbFpoTVZadVZURmtVMXBzVFhsaVIzQm9VbFZ3YjFsdGJFSlBWV3hDVUZRd1BRPT0=")))))))) + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
				if (flag)
				{
					InteractSQL.DeleteHanhDongByIdKichBan(id);
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0040F074 File Offset: 0x0040D274
		public static bool DuplicateKichBan(string Id_KichBanCu, string TenKichBanMoi)
		{
			bool result = false;
			try
			{
				bool flag = InteractSQL.InsertKichBan(TenKichBanMoi);
				if (flag)
				{
					string text = InteractSQL.GetKichBanMoi().Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString();
					DataTable dataTable = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3RzV2xaNlZuWlhSRUpUWkcxS2RGa3laRmROUjJoSFZsZDBWbG94VGxoVmJWcFVUVzE0Y1ZsVlZrdGhSMHB3VVZSc1NsRlVNRGs9")))))))) + Id_KichBanCu);
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						string query = string.Concat(new string[]
						{
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1VNUlVbTVXYUZKcWJFWlpha2t4WW10c1JHRkdVbGRTYkVaNlZURmtVMXBzVFhsaVIzQm9VbFZ3YjFsdGJETmFNVnBJVm01V1ZGSXdXakZaVlZaVFpHMUtkRmt6VGtwU1YzaHlWMFJHVTAxWFNYbE9WelZYVWpCYWNWUkZUa05TUm14WlZtdHNhRlo2Vm5aVE1VNURWakZHVm1WR1dsTldhekZ1VXpCRk9WQlJQVDA9")))))))),
							dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))))].ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
							text,
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
							dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))].ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xcDNQVDA9")))))))),
							dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))))].ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
							dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString(),
							Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))))
						});
						Connector.Instance.ExecuteNonQuery(query);
					}
					result = true;
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0040F54C File Offset: 0x0040D74C
		public static DataTable GetTuongTac(string id = "", string ten = "")
		{
			DataTable result = new DataTable();
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				bool flag = id != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1YU1VSlVVVlF3UFE9PQ==")))))))) + id + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ=="))))))));
				}
				bool flag2 = ten != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldXa2xXYmxwcFlsZFNWbGRXWkU1YU1VSlVVVmMwUFE9PQ==")))))))) + ten + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				}
				bool flag3 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag3)
				{
					bool flag4 = text.EndsWith(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ==")))))))));
					if (flag4)
					{
						text = text.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSVkRBOQ==")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))));
					}
					string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3hXYTFaNmJERlhha1UxVmxac1dGUlhaRmROUjJoSFZsZDBWbHAzUFQwPQ==")))))))) + text;
					result = Connector.Instance.ExecuteQuery(query);
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x0040F958 File Offset: 0x0040DB58
		public static DataTable GetAllHanhDongByKichBan(string idKichBan)
		{
			DataTable result = new DataTable();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIZEhOaE1XZDNZVWRvYVdKWGFFWlpha2t4WW10NFJGRnFRazVWZWxaV1YyeGpNVk5XYkZoT1Z6bFRVbnBzTVZkdWJEUk5SVEZ3VGxWd1lWSnFiRlphUm1NMVpGWnZlRlZ0YUZwbFdHZDNWRmRyTVZaV2NGaE9WbFpyVm5wc01WZHFSbE5oUm13MVpESmthMUpGYkRGV1JtTTFWbFpzVkZGclpGWmhlbXhQVTFWV2IyRkhTblJoUjFwVFVucHNNVmR1YkVOTlJURlVVV3QwVlUxSGVGQlRWVnBUVFZkSmVVNVhOVmxOVmtwdlYxaHNRMDFGTVhCUmJFSlZZVlZKZDFSV1RURlRiSEJIVDFaV2ExWjZiREZYYWtaVFlVWnNOVkZVYkVwVFJrWTFWRWQwYzJFeFozaFZha1pwVFdwV2RWWnJaRWRoYTJ4SFdrVnNVMVpyY0VkVFZXaFNaVVY0Y21KSGRGbE5TRkozVjFSS2IxRXhiRmhPUjJSUlZUQkZPUT09")))))))) + idKichBan + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWVk5WVXhTa1pXYkU1S1VsVndZVk5WYUZKbFJYaHpWR3hXVjFGVU1Eaz0="))))))));
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0040FA40 File Offset: 0x0040DC40
		public static DataTable GetHanhDongById(string id)
		{
			DataTable result = new DataTable();
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIZUZOaVIwcHlZVWRvYVdKWGFFWlpha2t4WW10NFNWVllhRTFoTURWdldrWldiMk5IU25SYU0wNXJVa1ZzTVZVeFpGTmFiRnBKVm01YWFXSlhVbFpYVm1ST1l6SlNSVk5ZVmxkU01Wb3hWbXRvVjJSdFNuUmFSbFphVmpBeGVsTlZhRkpsVlhoeVRWaGFWMUl3Vm01VmJYaExWVVpTVkZGcmJGcFdlbFoyVjBSQ1UyUnRTblJaTW1SclVrVldibFV5Y3pWVGJGSndVV3hXYTFaNmJERlhha1UxVmxac1dGUlhaR3RTUld4dVZrUkJNRm95VWtWU1dGWlVWakZLYlZacmFGZGtiVXAwV2taV1dsWXdNVzVWUms1RFRVVXhjRTVWY0dGU2FteFdXa1pqTldSV2IzaFZiV2hhWlZWS1dWVXdWbGRWTVVwVVVXcENUbFY2Vmt0WGExazFVMVpzV0U1WE9WTlNlbXd4VjI1c1FrOVZiRUpRVkRBOQ==")))))))) + id;
				result = Connector.Instance.ExecuteQuery(query);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0040FAE4 File Offset: 0x0040DCE4
		public static DataTable GetHanhDongMoi()
		{
			DataTable result = new DataTable();
			try
			{
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIZEhOaE1XZDNZVWRvYVdKWGFFWlpha2t4WW10NFNWVllhRTFpUmtweldXMTBiMkZIU25SaFJWWnBUV3BXZFZSRmFGSmxSWGh5Vkcxb2ExWlhhSGRaYlRGdVl6SlNSVk5ZVmxSV01VcHRWbXRvVjJSdFNuUmFSbFphVmpBeGVscEZVa3BrVmxwSVZtNVdWMU5HV2pKWmJURnJWbFpzV0ZSWVRrcFRSa1kxVkVkemVHUnNXa2hTVjJSVFlrVndVVlpHVGtOVFZteFlUbGM1V1UxR1NqSlpiVEZxV2pKU1JWSlhaRlJoZW14TFZrZHNRMVpYVWxoUFdGWmhUVlJzVmxkV1pFNWFNbEpGVTFka1ZVMUVVbTVhUlZKR1pGWk9XRlZ0V2xkVFJsb3lXVzB4YTFaV2JGaFVWMlJSVlRCSmQxUlhhekZUYkhCSFQxWldhMVo2YkRGWGFrWlRZVVpzTlZGc1FsWmhNVXBIVmxkc1ExRXhaRlJSYTNCaFVtcHNTbGRXWXpGaU1VcElUMWhXWVdWVlNrWlZiRnBQVWtWc1JtVkZjRlZXVjNoV1UxVlNSbEJSUFQwPQ=="))))))));
				result = Connector.Instance.ExecuteQuery(@string);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0040FB7C File Offset: 0x0040DD7C
		public static bool CheckExistTenHanhDong(string tenHanhDong)
		{
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsZDRjbGRFUW05aFIwcDBZVVZXYVUxcVZuVlRWVlpoVlRGUmQwMUhaRlJTTUZveFdWVlpOVkpYU1hsT1Z6VktVbTFTU2xWc1drdFNhMnhIVlcxNGFXRXlhRzlaYlRGdlVsZEplVTVYTlVwU1JFSnVVMjVqT1ZCUlBUMD0=")))))))) + tenHanhDong + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				bool flag = Connector.Instance.ExecuteQuery(query).Rows.Count > 0;
				if (flag)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0040FC84 File Offset: 0x0040DE84
		public static bool InsertHanhDong(string Id_KichBan, string TenHanhDong, string Id_TuongTac, string CauHinh)
		{
			bool result = false;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				try
				{
					text = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VtczFWbFpyVGtOU01WWnlUMVUxU2xKWGFHOVpiVEZ2V214S1NFOVlWbUZsVlVwWlZUQldWMVV4U2xSUmEzQmhVbXBzVFZsV1pFOWlNVVowVW01V1NsSkVRbTQ9")))))))) + Id_KichBan + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWVk5WVXhTa1pXYkU1S1VsVndZVk5WV2s5V1ZscEVVV3RXVTFack5VVlRWVlkwVTJ4U1ZtSkdWa3BTUlZVNQ=="))))))))).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))))].ToString();
				}
				catch
				{
				}
				text = ((text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))) : (Convert.ToInt32(text) + 1).ToString());
				CauHinh = CauHinh.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9")))))))));
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1VNUlVbTVXYUZKcWJFWlpha2t4WW10c1JHRkdVbGRTYkVaNlZURmtVMXBzVFhsaVIzQm9VbFZ3YjFsdGJETmFNVnBJVm01V1ZGSXdXakZaVlZaVFpHMUtkRmt6VGtwU1YzaHlWMFJHVTAxWFNYbE9WelZYVWpCYWNWUkZUa05TUm14WlZtdHNhRlo2Vm5aVE1VNURWakZHVm1WR1dsTldhekZ1VXpCRk9WQlJQVDA9")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
					Id_KichBan,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
					TenHanhDong,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xcDNQVDA9")))))))),
					Id_TuongTac,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
					CauHinh,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))))
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011B3 RID: 4531 RVA: 0x004101CC File Offset: 0x0040E3CC
		public static bool DuplicateHanhDong(string Id_HanhDong, string TenHanhDongMoi)
		{
			bool result = false;
			try
			{
				DataTable dataTable = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3RzV2xaNlZuWlhSRUpUWkcxS2RGa3laRmROUjJoSFZsZDBWbG94VGxoVmJWcFVVakJhTVZsVlZsTmtiVXAwV1RKa1VWVXdSVGs9")))))))) + Id_HanhDong);
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				try
				{
					text = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VtczFWbFpyVGtOU01WWnlUMVUxU2xKWGFHOVpiVEZ2V214S1NFOVlWbUZsVlVwWlZUQldWMVV4U2xSUmEzQmhVbXBzVFZsV1pFOWlNVVowVW01V1NsSkVRbTQ9")))))))) + dataTable.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString() + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWVk5WVXhTa1pXYkU1S1VsVndZVk5WV2s5V1ZscEVVV3RXVTFack5VVlRWVlkwVTJ4U1ZtSkdWa3BTUlZVNQ=="))))))))).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))))].ToString();
				}
				catch
				{
				}
				text = ((text == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))) ? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkZaRk9WQlJQVDA9")))))))) : (Convert.ToInt32(text) + 1).ToString());
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGVk1WWkdTbGRUYkZaS1VsZDRVRlpyVlRSYU1VNUlVbTVXYUZKcWJFWlpha2t4WW10c1JHRkdVbGRTYkVaNlZURmtVMXBzVFhsaVIzQm9VbFZ3YjFsdGJETmFNVnBJVm01V1ZGSXdXakZaVlZaVFpHMUtkRmt6VGtwU1YzaHlWMFJHVTAxWFNYbE9WelZYVWpCYWNWUkZUa05TUm14WlZtdHNhRlo2Vm5aVE1VNURWakZHVm1WR1dsTldhekZ1VXpCRk9WQlJQVDA9")))))))),
					text,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWRk9WQlJQVDA9")))))))),
					dataTable.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUWGxpUjNCb1VsVndiMWx0WXpsUVVUMDk="))))))))].ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
					TenHanhDongMoi,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xcDNQVDA9")))))))),
					dataTable.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1UVVUMDk="))))))))].ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVWT1FtSm5QVDA9")))))))),
					dataTable.Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2NsQlJQVDA9"))))))))
				});
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011B4 RID: 4532 RVA: 0x00410838 File Offset: 0x0040EA38
		public static bool UpdateHanhDong(string Id_HanhDong, string TenHanhDong = "", string CauHinh = "")
		{
			bool result = false;
			try
			{
				string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				CauHinh = CauHinh.Replace(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c2FsQlJQVDA9")))))))));
				bool flag = TenHanhDong != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10a1YyUldUa2hTYmxab1VsWktNbGx0TVdwYU1VSlVVVmMwUFE9PQ==")))))))) + TenHanhDong + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1c00xQlJQVDA9"))))))));
				}
				bool flag2 = CauHinh != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag2)
				{
					text = text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VUQkZOVk5WVG1wUVVUMDk=")))))))) + CauHinh + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))));
				}
				bool flag3 = text != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag3)
				{
					text = text.TrimEnd(new char[]
					{
						','
					});
					string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsZG9iMWx0TVc5YWJFcElUMWhXWVdWVlNsVlZiRnBTV25jOVBRPT0=")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWYWExTldTbGRUYTFwS1VsZDRjbGRFUW05aFIwcDBZVVZXYVUxcVZuVlRWVkYzV25jOVBRPT0=")))))))) + Id_HanhDong;
					bool flag4 = Connector.Instance.ExecuteNonQuery(query) > 0;
					if (flag4)
					{
						result = true;
					}
				}
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00410C78 File Offset: 0x0040EE78
		public static bool UpdateThuTuHanhDong(string Id_HanhDong1, string Id_HanhDong2)
		{
			bool result = false;
			try
			{
				string str = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VtczFWbFpyVGtOU01WWnlUMVUxU2xKWGFHOVpiVEZ2V214S1NFOVlWbUZsVlVwWlZUQldWMVV4U2xSUmEzQmhVbXBzU2xkV1l6RmlNVXBJVDFoV1lXVlZSVFZUVlVVNVVGRTlQUT09")))))))) + Id_HanhDong1).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))))].ToString();
				string str2 = Connector.Instance.ExecuteQuery(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VtczFWbFpyVGtOU01WWnlUMVUxU2xKWGFHOVpiVEZ2V214S1NFOVlWbUZsVlVwWlZUQldWMVV4U2xSUmEzQmhVbXBzU2xkV1l6RmlNVXBJVDFoV1lXVlZSVFZUVlVVNVVGRTlQUT09")))))))) + Id_HanhDong2).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSR1UxWlJQVDA9"))))))))].ToString();
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsZG9iMWx0TVc5YWJFcElUMWhXWVdWVlNsVlZiRnBTV2pGVmVGVnNWa3BTUkVKdQ==")))))))) + str2 + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWYWExTldTbGRUYTFwS1VsZDRjbGRFUW05aFIwcDBZVVZXYVUxcVZuVlRWVkYzV25jOVBRPT0=")))))))) + Id_HanhDong1;
				string query2 = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm14YVExSldSbGRWYTFwS1VsZG9iMWx0TVc5YWJFcElUMWhXWVdWVlNsVlZiRnBTV2pGVmVGVnNWa3BTUkVKdQ==")))))))) + str + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWYWExTldTbGRUYTFwS1VsZDRjbGRFUW05aFIwcDBZVVZXYVUxcVZuVlRWVkYzV25jOVBRPT0=")))))))) + Id_HanhDong2;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0 && Connector.Instance.ExecuteNonQuery(query2) > 0;
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

		// Token: 0x060011B6 RID: 4534 RVA: 0x00410FB0 File Offset: 0x0040F1B0
		public static bool DeleteHanhDongByIdHanhDong(string id)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0V1YxUldTbGRWYTFwS1VsWndWRlpFUVhkYU1VNUlVbTVXYUZKcWJFWlpha2t4WW10c1IxcEZiRk5XYTNCSFUxVldjMkV4WjNkaFIyaHBZbGRvUmxscVNURmlhMnhGVFVkalBRPT0=")))))))) + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011B7 RID: 4535 RVA: 0x00411068 File Offset: 0x0040F268
		public static bool DeleteHanhDongByIdKichBan(string id)
		{
			bool result = false;
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0V1YxUldTbGRWYTFwS1VsWndWRlpFUVhkYU1VNUlVbTVXYUZKcWJFWlpha2t4WW10c1IxcEZiRk5XYTNCSFUxVldjMkV4WjNka1NFSmFUVzFvUkZkV1l6QmFNVUpVVVZRd1BRPT0=")))))))) + id;
				bool flag = Connector.Instance.ExecuteNonQuery(query) > 0;
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

		// Token: 0x060011B8 RID: 4536 RVA: 0x00411120 File Offset: 0x0040F320
		public static List<string> GetIdHanhDongByIdKichBanAndTenTuongTac(string Id_KichBan, string tenTuongTac)
		{
			List<string> list = new List<string>();
			try
			{
				string query = string.Concat(new string[]
				{
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1UwWkdORlJIZEhOaE1XZDNZVWRvYVdKWGFFWlpha2t4WW10c1JsZHNUbFZOUkVKdVZUQmtSMlJYUmtkUFZWWnBUV3BXZFZOVmFGSmxSV3hHWTBaQ1ZGWlVVbTVXYTJoWFpHMUtkRnBIV2xkU01GcHhVMVZvVW1WVmJFWlBWVGxLVTBaR05GUkhkSE5oTVdkNFZXcEdhVTFxVm5WV2EyUkhZV3RzUlUxSFpHdFNSV3d4VlRGa1UxcHNXa2xXYmxwcFlsZFNWbGRXWkU1YU1WbDNZVVZhVm1FeFZtNWFSVkpHWkZaT1dGVnRXbFJOYlhoeFdWVldTMkZIU25CUlZHeEtVVlF3T1E9PQ==")))))))),
					Id_KichBan,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFWV1IxUXhTa1JSYWtKT1lWUldWbGRzWXpGV1YxSllUMWhXWVUxV1NtOVhXR3hDVDFWc1JGbDZNRDA9")))))))),
					tenTuongTac,
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTI1ak9WQlJQVDA9"))))))))
				});
				DataTable dataTable = Connector.Instance.ExecuteQuery(query);
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					list.Add(dataTable.Rows[i][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlRGa1UxcHNUa2hTYmxab1VsWktNbGx0TVdwUVVUMDk="))))))))].ToString());
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0041131C File Offset: 0x0040F51C
		public static string GetCauHinhFromHanhDong(string Id_HanhDong)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			try
			{
				string query = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VsVTFiMXBHVm05alIwcDBXakprVTJKRmNGRldSazVEVTFac1dFNVhPVmxOUmtveVdXMHhhbG94V1hkaFJWcFdZVEZXYmxVeFpGTmFiRTVJVW01V2FGSldTakpaYlRGcVdqRkNWRkZVTUQwPQ==")))))))) + Id_HanhDong;
				result = Connector.Instance.ExecuteQuery(query).Rows[0][Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS1IwMVdUa2hpU0Zab1VWUXdPUT09"))))))))].ToString();
			}
			catch
			{
			}
			return result;
		}
	}
}
