using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ConversionBack;
using Newtonsoft.Json.Linq;

namespace MCommon
{
	// Token: 0x0200004A RID: 74
	internal class JSON_Settings
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00039D74 File Offset: 0x00037F74
		public JSON_Settings(string jsonStringOrPathFile, bool isJsonString = false)
		{
			if (isJsonString)
			{
				bool flag = jsonStringOrPathFile.Trim() == Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				if (flag)
				{
					jsonStringOrPathFile = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xSTmQxQlJQVDA9"))))))));
				}
				this.json = JObject.Parse(jsonStringOrPathFile);
			}
			else
			{
				try
				{
					this.PathFileSetting = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1hwS1YwMUhVa2hpU0ZaaFRUQTFhZz09")))))))) + jsonStringOrPathFile + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGQyVnRTWGxPUkRBOQ=="))))))));
					bool flag2 = !File.Exists(this.PathFileSetting);
					if (flag2)
					{
						using (File.AppendText(this.PathFileSetting))
						{
						}
					}
					this.json = JObject.Parse(File.ReadAllText(this.PathFileSetting));
				}
				catch
				{
					this.json = new JObject();
				}
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00039F5C File Offset: 0x0003815C
		public static Dictionary<string, object> ConvertToDictionary(JObject jObject)
		{
			object[] parameters = new object[]
			{
				jObject
			};
			return (Dictionary<string, object>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(628544, 784, 468, parameters);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000026C5 File Offset: 0x000008C5
		public JSON_Settings()
		{
			this.json = new JObject();
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00039FA4 File Offset: 0x000381A4
		public string GetValue(string key, string valueDefault = "")
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(629328, 224, 469, parameters);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0003A00C File Offset: 0x0003820C
		public List<string> GetValueList(string key, int typeSplitString = 0)
		{
			List<string> list = new List<string>();
			try
			{
				bool flag = typeSplitString == 0;
				if (flag)
				{
					list = this.GetValue(key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Split(new char[]
					{
						'\n'
					}).ToList<string>();
				}
				else
				{
					list = this.GetValue(key, Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))))).Split(new string[]
					{
						Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VVRJMU0xTjNQVDA9"))))))))
					}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				}
				list = Common.RemoveEmptyItems(list);
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0003A1B0 File Offset: 0x000383B0
		public int GetValueInt(string key, int valueDefault = 0)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(630224, 224, 471, parameters);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0003A218 File Offset: 0x00038418
		public bool GetValueBool(string key, bool valueDefault = false)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(630448, 224, 472, parameters);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0003A280 File Offset: 0x00038480
		public void Add(string key, string value)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				value
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(630672, 240, 473, parameters);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0003A2E8 File Offset: 0x000384E8
		public void Update(string key, object value)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				value
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(630912, 128, 474, parameters);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0003A350 File Offset: 0x00038550
		public void Update(string key, List<string> lst)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				lst
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(631040, 256, 475, parameters);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0003A3B8 File Offset: 0x000385B8
		public void Remove(string key)
		{
			object[] parameters = new object[]
			{
				this,
				key
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(631296, 112, 476, parameters);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0003A410 File Offset: 0x00038610
		public void Save(string pathFileSetting = "")
		{
			object[] parameters = new object[]
			{
				this,
				pathFileSetting
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(631408, 272, 477, parameters);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0003A468 File Offset: 0x00038668
		public string GetFullString()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(631680, 480, 478, parameters);
		}

		// Token: 0x04000237 RID: 567
		private string PathFileSetting;

		// Token: 0x04000238 RID: 568
		private JObject json;
	}
}
