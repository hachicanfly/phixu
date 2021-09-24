using System;
using System.Drawing;
using ConversionBack;
using OpenQA.Selenium.Chrome;

namespace Common
{
	// Token: 0x0200005B RID: 91
	public class CommonChromeDriver
	{
		// Token: 0x06000382 RID: 898 RVA: 0x00055BD8 File Offset: 0x00053DD8
		public static ChromeDriver OpenChrome(ChromeDriver chrome, bool isHideChrome, bool isHideImage, bool isDisableSound, string UserAgent, string LinkProfile, Point Size, Point Position, string Proxy, int TimeWaitForSearchingElement = 0, int TimeWaitForLoadingPage = 60)
		{
			object[] parameters = new object[]
			{
				chrome,
				isHideChrome,
				isHideImage,
				isDisableSound,
				UserAgent,
				LinkProfile,
				Size,
				Position,
				Proxy,
				TimeWaitForSearchingElement,
				TimeWaitForLoadingPage
			};
			return (ChromeDriver)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1112656, 11264, 538, parameters);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00055CC0 File Offset: 0x00053EC0
		public static void QuitChrome(ChromeDriver chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1123920, 96, 539, parameters);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00055D08 File Offset: 0x00053F08
		public static bool CheckChromeClosed(ChromeDriver chrome)
		{
			object[] parameters = new object[]
			{
				chrome
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1124016, 160, 540, parameters);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00055D50 File Offset: 0x00053F50
		public static bool CheckExistElement(ChromeDriver chrome, int typeAttribute, string attributeValue, int timeOut = 0)
		{
			object[] parameters = new object[]
			{
				chrome,
				typeAttribute,
				attributeValue,
				timeOut
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1124176, 608, 541, parameters);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00055DC8 File Offset: 0x00053FC8
		public static bool NavigateChrome(ChromeDriver chrome, string url)
		{
			object[] parameters = new object[]
			{
				chrome,
				url
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1124784, 176, 542, parameters);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00055E20 File Offset: 0x00054020
		public static bool ScrollChrome(ChromeDriver chrome, int x, int y)
		{
			object[] parameters = new object[]
			{
				chrome,
				x,
				y
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1124960, 400, 543, parameters);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00055E88 File Offset: 0x00054088
		public static bool SendKeysChrome(ChromeDriver chrome, int typeAttribute, string attributeValue, string content, double timeDelay)
		{
			object[] parameters = new object[]
			{
				chrome,
				typeAttribute,
				attributeValue,
				content,
				timeDelay
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1125360, 688, 544, parameters);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00055F10 File Offset: 0x00054110
		public static bool SendKeysChrome(ChromeDriver chrome, int typeAttribute, string attributeValue, string content)
		{
			object[] parameters = new object[]
			{
				chrome,
				typeAttribute,
				attributeValue,
				content
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1126048, 368, 545, parameters);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00055F88 File Offset: 0x00054188
		public static bool ClickChrome(ChromeDriver chrome, int typeAttribute, string attributeValue)
		{
			object[] parameters = new object[]
			{
				chrome,
				typeAttribute,
				attributeValue
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1126416, 336, 546, parameters);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00055FF0 File Offset: 0x000541F0
		public static bool ExecuteScriptChrome(ChromeDriver chrome, string script)
		{
			object[] parameters = new object[]
			{
				chrome,
				script
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(1126752, 176, 547, parameters);
		}
	}
}
