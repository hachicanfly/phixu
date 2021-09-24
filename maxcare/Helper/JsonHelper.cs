using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ConversionBack;
using MCommon;
using Newtonsoft.Json.Linq;

namespace maxcare.Helper
{
	// Token: 0x0200019E RID: 414
	internal class JsonHelper
	{
		// Token: 0x060011EB RID: 4587 RVA: 0x004126C0 File Offset: 0x004108C0
		public JsonHelper(string jsonStringOrPathFile, bool isJsonString = false)
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

		// Token: 0x060011EC RID: 4588 RVA: 0x004128A8 File Offset: 0x00410AA8
		public static Dictionary<string, object> ConvertToDictionary(JObject jObject)
		{
			object[] parameters = new object[]
			{
				jObject
			};
			return (Dictionary<string, object>)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8446864, 784, 3347, parameters);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000034D8 File Offset: 0x000016D8
		public JsonHelper()
		{
			this.json = new JObject();
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x004128F0 File Offset: 0x00410AF0
		public string GetValue(string key, string valueDefault = "")
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8447648, 224, 3348, parameters);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00412958 File Offset: 0x00410B58
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

		// Token: 0x060011F0 RID: 4592 RVA: 0x00412AFC File Offset: 0x00410CFC
		public int GetValueInt(string key, int valueDefault = 0)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8448544, 224, 3350, parameters);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00412B64 File Offset: 0x00410D64
		public bool GetValueBool(string key, bool valueDefault = false)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				valueDefault
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8448768, 224, 3351, parameters);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00412BCC File Offset: 0x00410DCC
		public void Add(string key, string value)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				value
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8448992, 240, 3352, parameters);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00412C34 File Offset: 0x00410E34
		public void Update(string key, object value)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				value
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8449232, 128, 3353, parameters);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00412C9C File Offset: 0x00410E9C
		public void Update(string key, List<string> lst)
		{
			object[] parameters = new object[]
			{
				this,
				key,
				lst
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8449360, 256, 3354, parameters);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00412D04 File Offset: 0x00410F04
		public void Remove(string key)
		{
			object[] parameters = new object[]
			{
				this,
				key
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8449616, 112, 3355, parameters);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00412D5C File Offset: 0x00410F5C
		public void Save(string pathFileSetting = "")
		{
			object[] parameters = new object[]
			{
				this,
				pathFileSetting
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8449728, 272, 3356, parameters);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00412DB4 File Offset: 0x00410FB4
		public string GetFullString()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(8450000, 480, 3357, parameters);
		}

		// Token: 0x04001B49 RID: 6985
		private string PathFileSetting;

		// Token: 0x04001B4A RID: 6986
		private JObject json;
	}
}
