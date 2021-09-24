using System;
using System.Configuration;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace License
{
	// Token: 0x02000006 RID: 6
	public class Hardware
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000043FC File Offset: 0x000025FC
		private string maHoa(string sChuoi)
		{
			MD5 md = MD5.Create();
			byte[] array = md.ComputeHash(Encoding.UTF8.GetBytes(sChuoi));
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xod1FrNXRWa1ZUYW1zOQ==")))))))), array[i]));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000044BC File Offset: 0x000026BC
		public string getHDD()
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1RJd05XUnRVa2RsUlZKVVZsUkdXRlJYWXpsUVVUMDk=")))))))), Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSQ1YxUldTbFpVYkZaS1VUSTVibFZ0ZUV0VlJsSlVVV3hvYUZaNlVqWlVWM2MxVWxkR1dWUnVTbE5UUlhCM1drY3hWbEJSUFQwPQ==")))))))));
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					object obj = managementObject[Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxSS1YyVlhSbGhTYms1VllteGFNRmRYTVZkbFVUMDk="))))))))];
					result = this.maHoa(Hardware.EncryptHDD(((obj != null) ? obj.ToString() : null) ?? Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("")))))))), true)).ToUpper();
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000046C8 File Offset: 0x000028C8
		private static string EncryptHDD(string toEncrypt, bool useHashing)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(toEncrypt);
			AppSettingsReader appSettingsReader = new AppSettingsReader();
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VTFSQ2IyTkdjRmxSYlhSaFYwVktWbGt5TVVkalJXd3pVRlF3UFE9PQ=="))))))));
			byte[] key;
			if (useHashing)
			{
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(@string));
				md5CryptoServiceProvider.Clear();
			}
			else
			{
				key = Encoding.UTF8.GetBytes(@string);
			}
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
			byte[] array = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			tripleDESCryptoServiceProvider.Clear();
			return Convert.ToBase64String(array, 0, array.Length);
		}
	}
}
