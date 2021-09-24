using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// Token: 0x0200000F RID: 15
	public class Decryptor : Cryptor
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00004E48 File Offset: 0x00003048
		public string Decrypt(string encryptedBase64, string password)
		{
			string @string;
			try
			{
				PayloadComponents payloadComponents = this.unpackEncryptedBase64Data(encryptedBase64);
				bool flag = !this.hmacIsValid(payloadComponents, password);
				if (flag)
				{
					@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
				}
				else
				{
					byte[] key = base.generateKey(payloadComponents.salt, password);
					byte[] bytes = new byte[0];
					AesMode aesMode = this.aesMode;
					AesMode aesMode2 = aesMode;
					if (aesMode2 != AesMode.CTR)
					{
						if (aesMode2 == AesMode.CBC)
						{
							bytes = this.decryptAesCbcPkcs7(payloadComponents.ciphertext, key, payloadComponents.iv);
						}
					}
					else
					{
						bytes = base.encryptAesCtrLittleEndianNoPadding(payloadComponents.ciphertext, key, payloadComponents.iv);
					}
					@string = Encoding.UTF8.GetString(bytes);
				}
			}
			catch
			{
				@string = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
			}
			return @string;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004FEC File Offset: 0x000031EC
		private byte[] decryptAesCbcPkcs7(byte[] encrypted, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aes.CreateDecryptor(key, iv);
			string s;
			using (MemoryStream memoryStream = new MemoryStream(encrypted))
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
				{
					using (StreamReader streamReader = new StreamReader(cryptoStream))
					{
						s = streamReader.ReadToEnd();
					}
				}
			}
			return base.TextEncoding.GetBytes(s);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000050F0 File Offset: 0x000032F0
		private PayloadComponents unpackEncryptedBase64Data(string encryptedBase64)
		{
			List<byte> list = new List<byte>();
			list.AddRange(Convert.FromBase64String(encryptedBase64));
			int num = 0;
			PayloadComponents payloadComponents;
			payloadComponents.schema = list.GetRange(0, 1).ToArray();
			num++;
			base.configureSettings((Schema)list[0]);
			payloadComponents.options = list.GetRange(1, 1).ToArray();
			num++;
			payloadComponents.salt = list.GetRange(num, 8).ToArray();
			num += payloadComponents.salt.Length;
			payloadComponents.hmacSalt = list.GetRange(num, 8).ToArray();
			num += payloadComponents.hmacSalt.Length;
			payloadComponents.iv = list.GetRange(num, 16).ToArray();
			num += payloadComponents.iv.Length;
			payloadComponents.headerLength = num;
			payloadComponents.ciphertext = list.GetRange(num, list.Count - 32 - payloadComponents.headerLength).ToArray();
			num += payloadComponents.ciphertext.Length;
			payloadComponents.hmac = list.GetRange(num, 32).ToArray();
			return payloadComponents;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005240 File Offset: 0x00003440
		private bool hmacIsValid(PayloadComponents components, string password)
		{
			byte[] array = base.generateHmac(components, password);
			bool flag = array.Length != components.hmac.Length;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < components.hmac.Length; i++)
				{
					bool flag2 = array[i] != components.hmac[i];
					if (flag2)
					{
						return false;
					}
				}
				result = true;
			}
			return result;
		}
	}
}
