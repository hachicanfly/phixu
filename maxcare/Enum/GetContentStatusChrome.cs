using System;
using System.Text;

namespace maxcare.Enum
{
	// Token: 0x020001A4 RID: 420
	public class GetContentStatusChrome
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x00413098 File Offset: 0x00411298
		public static string GetContent(StatusChromeAccount status)
		{
			string result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			switch (status)
			{
			case StatusChromeAccount.ChromeClosed:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1UwWktkMlZyYkVOa1JXeEpWVzA1TTA1cmVFNWFNV2h5V2pGcmVXRkliR2xOYWtaelUxWkZPVkJSUFQwPQ==")))))))));
				break;
			case StatusChromeAccount.Checkpoint:
				result = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlZSS2IySkdhM2xrU0dScFRXMTRNVnBGVGtaUVVUMDk="))))))));
				break;
			case StatusChromeAccount.NoInternet:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlhwS2NWSklVa2hPVnpWS1VqRkNSV016YkVOamFsSnBZMU01YTFFd1NqRk9SMG94VlcxR1ZGRnJjR2xpYkVweldUSXdNV0pIVWtSU1ZEQTk=")))))))));
				break;
			case StatusChromeAccount.Blocked:
				result = Language.GetValue(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweFIyRnNjRmhUYmxwcFRXNU9ibFZYTVRSa2JHdDVaRWQ0WVZFd1ZUaz0=")))))))));
				break;
			}
			return result;
		}
	}
}
