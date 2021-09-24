using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// Token: 0x02000010 RID: 16
	public class Encryptor : Cryptor
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000052FC File Offset: 0x000034FC
		public string Encrypt(string plaintext, string password)
		{
			string result;
			try
			{
				result = Encryptor.Base64Encode(this.Encrypt(plaintext, password, this.defaultSchemaVersion));
			}
			catch
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1cwMVYyTXlTa0pRVkRBOQ=="))))))));
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000053A0 File Offset: 0x000035A0
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000053CC File Offset: 0x000035CC
		public string Encrypt(string plaintext, string password, Schema schemaVersion)
		{
			base.configureSettings(schemaVersion);
			byte[] bytes = base.TextEncoding.GetBytes(plaintext);
			PayloadComponents payloadComponents = new PayloadComponents
			{
				schema = new byte[]
				{
					(byte)schemaVersion
				},
				options = new byte[]
				{
					(byte)this.options
				},
				salt = this.generateRandomBytes(8),
				hmacSalt = this.generateRandomBytes(8),
				iv = this.generateRandomBytes(16)
			};
			byte[] key = base.generateKey(payloadComponents.salt, password);
			AesMode aesMode = this.aesMode;
			AesMode aesMode2 = aesMode;
			if (aesMode2 != AesMode.CTR)
			{
				if (aesMode2 == AesMode.CBC)
				{
					payloadComponents.ciphertext = this.encryptAesCbcPkcs7(bytes, key, payloadComponents.iv);
				}
			}
			else
			{
				payloadComponents.ciphertext = base.encryptAesCtrLittleEndianNoPadding(bytes, key, payloadComponents.iv);
			}
			payloadComponents.hmac = base.generateHmac(payloadComponents, password);
			List<byte> list = new List<byte>();
			list.AddRange(base.assembleHeader(payloadComponents));
			list.AddRange(payloadComponents.ciphertext);
			list.AddRange(payloadComponents.hmac);
			return Convert.ToBase64String(list.ToArray());
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005578 File Offset: 0x00003778
		private byte[] encryptAesCbcPkcs7(byte[] plaintext, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aes.CreateEncryptor(key, iv);
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
				{
					cryptoStream.Write(plaintext, 0, plaintext.Length);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000564C File Offset: 0x0000384C
		private byte[] generateRandomBytes(int length)
		{
			byte[] array = new byte[length];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(array);
			return array;
		}

		// Token: 0x04000034 RID: 52
		private Schema defaultSchemaVersion = Schema.V2;
	}
}
