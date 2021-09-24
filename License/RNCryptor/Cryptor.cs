using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace License.RNCryptor
{
	// Token: 0x0200000E RID: 14
	public abstract class Cryptor
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002145 File Offset: 0x00000345
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000213C File Offset: 0x0000033C
		public Encoding TextEncoding { get; set; }

		// Token: 0x06000022 RID: 34 RVA: 0x0000214D File Offset: 0x0000034D
		public Cryptor()
		{
			this.TextEncoding = Encoding.UTF8;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000047E0 File Offset: 0x000029E0
		protected void configureSettings(Schema schemaVersion)
		{
			switch (schemaVersion)
			{
			case Schema.V0:
				this.aesMode = AesMode.CTR;
				this.options = Options.V0;
				this.hmac_includesHeader = false;
				this.hmac_includesPadding = true;
				this.hmac_algorithm = HmacAlgorithm.SHA1;
				break;
			case Schema.V1:
				this.aesMode = AesMode.CBC;
				this.options = Options.V1;
				this.hmac_includesHeader = false;
				this.hmac_includesPadding = false;
				this.hmac_algorithm = HmacAlgorithm.SHA256;
				break;
			case Schema.V2:
			case Schema.V3:
				this.aesMode = AesMode.CBC;
				this.options = Options.V1;
				this.hmac_includesHeader = true;
				this.hmac_includesPadding = false;
				this.hmac_algorithm = HmacAlgorithm.SHA256;
				break;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004914 File Offset: 0x00002B14
		protected byte[] generateHmac(PayloadComponents components, string password)
		{
			List<byte> list = new List<byte>();
			bool flag = this.hmac_includesHeader;
			if (flag)
			{
				list.AddRange(this.assembleHeader(components));
			}
			list.AddRange(components.ciphertext);
			byte[] key = this.generateKey(components.hmacSalt, password);
			HMAC hmac = null;
			HmacAlgorithm hmacAlgorithm = this.hmac_algorithm;
			HmacAlgorithm hmacAlgorithm2 = hmacAlgorithm;
			if (hmacAlgorithm2 != HmacAlgorithm.SHA1)
			{
				if (hmacAlgorithm2 == HmacAlgorithm.SHA256)
				{
					hmac = new HMACSHA256(key);
				}
			}
			else
			{
				hmac = new HMACSHA1(key);
			}
			List<byte> list2 = new List<byte>();
			list2.AddRange(hmac.ComputeHash(list.ToArray()));
			bool flag2 = this.hmac_includesPadding;
			if (flag2)
			{
				for (int i = list2.Count; i < 32; i++)
				{
					list2.Add(0);
				}
			}
			return list2.ToArray();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004A44 File Offset: 0x00002C44
		protected byte[] assembleHeader(PayloadComponents components)
		{
			List<byte> list = new List<byte>();
			list.AddRange(components.schema);
			list.AddRange(components.options);
			list.AddRange(components.salt);
			list.AddRange(components.hmacSalt);
			list.AddRange(components.iv);
			return list.ToArray();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004AC0 File Offset: 0x00002CC0
		protected byte[] generateKey(byte[] salt, string password)
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 10000);
			return rfc2898DeriveBytes.GetBytes(32);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004AF8 File Offset: 0x00002CF8
		protected byte[] encryptAesCtrLittleEndianNoPadding(byte[] plaintextBytes, byte[] key, byte[] iv)
		{
			byte[] plaintext = this.computeAesCtrLittleEndianCounter(plaintextBytes.Length, iv);
			byte[] second = this.encryptAesEcbNoPadding(plaintext, key);
			return this.bitwiseXOR(plaintextBytes, second);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004B4C File Offset: 0x00002D4C
		private byte[] computeAesCtrLittleEndianCounter(int payloadLength, byte[] iv)
		{
			byte[] array = new byte[iv.Length];
			iv.CopyTo(array, 0);
			int num = (int)Math.Ceiling(payloadLength / iv.Length);
			List<byte> list = new List<byte>();
			for (int i = 0; i < num; i++)
			{
				list.AddRange(array);
				byte[] array2 = array;
				int num2 = 0;
				array2[num2] += 1;
			}
			return list.ToArray();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004BF8 File Offset: 0x00002DF8
		private byte[] encryptAesEcbNoPadding(byte[] plaintext, byte[] key)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.ECB;
			aes.Padding = PaddingMode.None;
			ICryptoTransform transform = aes.CreateEncryptor(key, null);
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

		// Token: 0x0600002A RID: 42 RVA: 0x00004CC8 File Offset: 0x00002EC8
		private byte[] bitwiseXOR(byte[] first, byte[] second)
		{
			byte[] array = new byte[first.Length];
			ulong num = (ulong)((long)second.Length);
			ulong num2 = (ulong)((long)first.Length);
			ulong num3 = 0UL;
			for (ulong num4 = 0UL; num4 < num2; num4 += 1UL)
			{
				checked
				{
					array[(int)((IntPtr)num4)] = (first[(int)((IntPtr)num4)] ^ second[(int)((IntPtr)num3)]);
				}
				num3 = (((num3 += 1UL) < num) ? num3 : 0UL);
			}
			return array;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004D68 File Offset: 0x00002F68
		protected string hex_encode(byte[] input)
		{
			string text = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			foreach (byte b in input)
			{
				text += string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2xod1FrNXRWa1ZUYW1zOQ==")))))))), b);
			}
			return text;
		}

		// Token: 0x04000027 RID: 39
		protected AesMode aesMode;

		// Token: 0x04000028 RID: 40
		protected Options options;

		// Token: 0x04000029 RID: 41
		protected bool hmac_includesHeader;

		// Token: 0x0400002A RID: 42
		protected bool hmac_includesPadding;

		// Token: 0x0400002B RID: 43
		protected HmacAlgorithm hmac_algorithm;

		// Token: 0x0400002C RID: 44
		protected const Algorithm algorithm = Algorithm.AES;

		// Token: 0x0400002D RID: 45
		protected const short saltLength = 8;

		// Token: 0x0400002E RID: 46
		protected const short ivLength = 16;

		// Token: 0x0400002F RID: 47
		protected const Pbkdf2Prf pbkdf2_prf = Pbkdf2Prf.SHA1;

		// Token: 0x04000030 RID: 48
		protected const int pbkdf2_iterations = 10000;

		// Token: 0x04000031 RID: 49
		protected const short pbkdf2_keyLength = 32;

		// Token: 0x04000032 RID: 50
		protected const short hmac_length = 32;
	}
}
