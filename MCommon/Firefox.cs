using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using ConversionBack;
using OpenQA.Selenium.Firefox;

namespace MCommon
{
	// Token: 0x02000049 RID: 73
	public class Firefox
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002582 File Offset: 0x00000782
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000258A File Offset: 0x0000078A
		public bool HideBrowser { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00002593 File Offset: 0x00000793
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000259B File Offset: 0x0000079B
		public bool DisableImage { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000025A4 File Offset: 0x000007A4
		// (set) Token: 0x0600029F RID: 671 RVA: 0x000025AC File Offset: 0x000007AC
		public bool DisableSound { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x000025B5 File Offset: 0x000007B5
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000025BD File Offset: 0x000007BD
		public bool AutoPlayVideo { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000025C6 File Offset: 0x000007C6
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000025CE File Offset: 0x000007CE
		public string UserAgent { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000025D7 File Offset: 0x000007D7
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000025DF File Offset: 0x000007DF
		public string ProfilePath { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000025E8 File Offset: 0x000007E8
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000025F0 File Offset: 0x000007F0
		public Point Size { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000025F9 File Offset: 0x000007F9
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00002601 File Offset: 0x00000801
		public int Size_Heigh { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000260A File Offset: 0x0000080A
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00002612 File Offset: 0x00000812
		public int Size_Width { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000261B File Offset: 0x0000081B
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002623 File Offset: 0x00000823
		public Point Position { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000262C File Offset: 0x0000082C
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002634 File Offset: 0x00000834
		public int Position_X { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000263D File Offset: 0x0000083D
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00002645 File Offset: 0x00000845
		public int Position_Y { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000264E File Offset: 0x0000084E
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002656 File Offset: 0x00000856
		public int TimeWaitForSearchingElement { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000265F File Offset: 0x0000085F
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002667 File Offset: 0x00000867
		public int TimeWaitForLoadingPage { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00002678 File Offset: 0x00000878
		public string Proxy { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00002681 File Offset: 0x00000881
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002689 File Offset: 0x00000889
		public int TypeProxy { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00002692 File Offset: 0x00000892
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0000269A File Offset: 0x0000089A
		public string App { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000026A3 File Offset: 0x000008A3
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000026AB File Offset: 0x000008AB
		public string LinkToOtherBrowser { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000026B4 File Offset: 0x000008B4
		// (set) Token: 0x060002BF RID: 703 RVA: 0x000026BC File Offset: 0x000008BC
		public string PathExtension { get; set; }

		// Token: 0x060002C0 RID: 704 RVA: 0x00038A44 File Offset: 0x00036C44
		public Firefox()
		{
			this.DisableImage = true;
			this.DisableSound = false;
			this.UserAgent = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.ProfilePath = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.Size_Heigh = 300;
			this.Size_Width = 300;
			this.Size = new Point(this.Size_Width, this.Size_Heigh);
			this.Position_X = 300;
			this.Position_Y = 0;
			this.Proxy = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.TypeProxy = 0;
			this.Position = new Point(this.Position_X, this.Position_Y);
			this.TimeWaitForSearchingElement = 0;
			this.TimeWaitForLoadingPage = 5;
			this.App = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.AutoPlayVideo = false;
			this.LinkToOtherBrowser = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
			this.PathExtension = Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1IwMUdiRmRsUjNoc1UwWktjMWx0TlU5alIwbDVUa1F3UFE9PQ=="))))))));
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00038CB4 File Offset: 0x00036EB4
		public bool Open()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(586240, 6784, 429, parameters);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00038CFC File Offset: 0x00036EFC
		public static string SetPositionAndSizeFireFox(FirefoxOptions option, int i)
		{
			object[] parameters = new object[]
			{
				option,
				i
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(593024, 1008, 430, parameters);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00038D54 File Offset: 0x00036F54
		public string GetCssSelector(string querySelector, string attributeName, string attributeValue)
		{
			object[] parameters = new object[]
			{
				this,
				querySelector,
				attributeName,
				attributeValue
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(594032, 3152, 431, parameters);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00038DCC File Offset: 0x00036FCC
		public string GetAttributeValue(string querySelector, string attributeName)
		{
			object[] parameters = new object[]
			{
				this,
				querySelector,
				attributeName
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(597184, 1440, 432, parameters);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00038E34 File Offset: 0x00037034
		public void ScrollSmooth(int distance)
		{
			object[] parameters = new object[]
			{
				this,
				distance
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(598624, 768, 433, parameters);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00038E8C File Offset: 0x0003708C
		public string GetUseragent()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(599392, 448, 434, parameters);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00038ED4 File Offset: 0x000370D4
		public bool SendKeyDown(int typeAttribute, string attributeValue)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(599840, 752, 435, parameters);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00038F3C File Offset: 0x0003713C
		public string GetURL()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(600592, 464, 436, parameters);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00038F84 File Offset: 0x00037184
		public bool GotoURL(string url)
		{
			object[] parameters = new object[]
			{
				this,
				url
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(601056, 544, 437, parameters);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00038FDC File Offset: 0x000371DC
		public bool Refresh()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(601600, 400, 438, parameters);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00039024 File Offset: 0x00037224
		public bool GotoBackPage()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(602000, 416, 439, parameters);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0003906C File Offset: 0x0003726C
		public bool HoverElement(int typeAttribute, string attributeValue, double timeHover_second)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				timeHover_second
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(602416, 912, 440, parameters);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000390E4 File Offset: 0x000372E4
		public bool Click(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				index,
				subTypeAttribute,
				subAttributeValue,
				subIndex
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(603328, 1296, 441, parameters);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0003918C File Offset: 0x0003738C
		public bool ClickWithAction(int typeAttribute, string attributeValue, int index = 0, int subTypeAttribute = 0, string subAttributeValue = "", int subIndex = 0)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				index,
				subTypeAttribute,
				subAttributeValue,
				subIndex
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(604624, 1552, 442, parameters);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00039234 File Offset: 0x00037434
		public bool SendKeys(int typeAttribute, string attributeValue, string content, bool isClick = true)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				content,
				isClick
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(606176, 1024, 443, parameters);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000392BC File Offset: 0x000374BC
		public bool SendKeys(int typeAttribute, string attributeValue, string content, double timeDelay_Second, bool isClick = true)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				content,
				timeDelay_Second,
				isClick
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(607200, 1376, 444, parameters);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00039354 File Offset: 0x00037554
		public bool SelectText(int typeAttribute, string attributeValue)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(608576, 1216, 445, parameters);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000393BC File Offset: 0x000375BC
		public bool ClearText(int typeAttribute, string attributeValue)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(609792, 704, 446, parameters);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00039424 File Offset: 0x00037624
		public bool CheckExistElement(string querySelector, double timeWait_Second = 0.0)
		{
			object[] parameters = new object[]
			{
				this,
				querySelector,
				timeWait_Second
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(610496, 1152, 447, parameters);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0003948C File Offset: 0x0003768C
		public bool CheckExistElementv2(string JSPath, double timeWait_Second = 0.0)
		{
			object[] parameters = new object[]
			{
				this,
				JSPath,
				timeWait_Second
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(611648, 1072, 448, parameters);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000394F4 File Offset: 0x000376F4
		public bool CheckChromeClosed()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(612720, 448, 449, parameters);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0003953C File Offset: 0x0003773C
		public bool WaitForSearchElement(string querySelector, int typeSearch = 0, double timeWait_Second = 0.0)
		{
			object[] parameters = new object[]
			{
				this,
				querySelector,
				typeSearch,
				timeWait_Second
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(613168, 1936, 450, parameters);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000395B4 File Offset: 0x000377B4
		public int CheckExistElements(double timeWait_Second = 0.0, params string[] querySelectors)
		{
			int result = 0;
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					int tickCount = Environment.TickCount;
					int i;
					for (;;)
					{
						for (i = 0; i < querySelectors.Length; i++)
						{
							bool flag2 = this.CheckExistElement(querySelectors[i], 0.0);
							if (flag2)
							{
								goto Block_3;
							}
						}
						bool flag3 = (double)(Environment.TickCount - tickCount) > timeWait_Second * 1000.0;
						if (flag3)
						{
							goto Block_5;
						}
						Thread.Sleep(1000);
					}
					Block_3:
					return i + 1;
					Block_5:;
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweGMyVldjRmhYYmxwc1VYcFdSVmxWWkZkaGJVVjNWbXBTYUZkRk5IZFZiR1EwWWtkS1dGWnVWbXRUUlRGMldsaHdRMDlWZUVsak0yaHRWVEp6T1E9PQ==")))))))), timeWait_Second, string.Join(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V210Rk9WQlJQVDA9")))))))), querySelectors)));
				}
			}
			return result;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00039768 File Offset: 0x00037968
		public bool SendEnter(int typeAttribute, string attributeValue)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(616016, 736, 452, parameters);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000397D0 File Offset: 0x000379D0
		public bool Scroll(int x, int y)
		{
			object[] parameters = new object[]
			{
				this,
				x,
				y
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(616752, 704, 453, parameters);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00039838 File Offset: 0x00037A38
		public void ScrollSmooth(string JSpath)
		{
			object[] parameters = new object[]
			{
				this,
				JSpath
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(617456, 784, 454, parameters);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00039890 File Offset: 0x00037A90
		public int CheckExistElementOnScreen(string JSpath)
		{
			object[] parameters = new object[]
			{
				this,
				JSpath
			};
			return (int)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(618240, 1440, 455, parameters);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000398E8 File Offset: 0x00037AE8
		public Point GetSizeChrome()
		{
			object[] parameters = new object[]
			{
				this
			};
			return (Point)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(619680, 656, 456, parameters);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00039930 File Offset: 0x00037B30
		public void Close()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(620336, 352, 457, parameters);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00039978 File Offset: 0x00037B78
		public void AddCookieIntoFirefox(string cookie, string domain = ".facebook.com")
		{
			object[] parameters = new object[]
			{
				this,
				cookie,
				domain
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(620688, 1600, 458, parameters);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000399E0 File Offset: 0x00037BE0
		public string GetCookieFromChrome(string domain = "facebook")
		{
			object[] parameters = new object[]
			{
				this,
				domain
			};
			return (string)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(622288, 1216, 459, parameters);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00039A38 File Offset: 0x00037C38
		public void OpenNewTab(string url, bool switchToLastTab = true)
		{
			object[] parameters = new object[]
			{
				this,
				url,
				switchToLastTab
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(623504, 832, 460, parameters);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00039AA0 File Offset: 0x00037CA0
		public void CloseCurrentTab()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(624336, 352, 461, parameters);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00039AE8 File Offset: 0x00037CE8
		public void SwitchToFirstTab()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(624688, 400, 462, parameters);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00039B30 File Offset: 0x00037D30
		public void SwitchToLastTab()
		{
			object[] parameters = new object[]
			{
				this
			};
			object obj = PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(625088, 400, 463, parameters);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00039B78 File Offset: 0x00037D78
		public void DelayTime(double timeDelay_Seconds)
		{
			bool flag = this.isAlive;
			if (flag)
			{
				try
				{
					Thread.Sleep(Convert.ToInt32(timeDelay_Seconds * 1000.0));
				}
				catch (Exception ex)
				{
					Firefox.ExportError(null, ex, string.Format(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjIweGMyVldjRmhYYmxwc1VYcFdSbGRzWkRSaFIxWlhWVzVDYVZZeFZuWmFXSEJEVDFWMFVsQlVNRDA9")))))))), timeDelay_Seconds));
				}
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00039C3C File Offset: 0x00037E3C
		public bool Select(int typeAttribute, string attributeValue, string value)
		{
			object[] parameters = new object[]
			{
				this,
				typeAttribute,
				attributeValue,
				value
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(625872, 768, 465, parameters);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00039CB4 File Offset: 0x00037EB4
		public bool ScreenCapture(string imagePath, string fileName)
		{
			object[] parameters = new object[]
			{
				this,
				imagePath,
				fileName
			};
			return (bool)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(626640, 1280, 466, parameters);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00039D1C File Offset: 0x00037F1C
		public object ExecuteScript(string script)
		{
			object[] parameters = new object[]
			{
				this,
				script
			};
			return (object)PROTECTED_BY_MIN_SOFTWARE._PROTECTED_BY_MIN_SOFTWARE_(627920, 624, 467, parameters);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000183FC File Offset: 0x000165FC
		public static void ExportError(Chrome firefox, Exception ex, string error = "")
		{
			try
			{
				bool flag = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				if (flag)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSm5QVDA9")))))))));
				}
				bool flag2 = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTmpPUT09")))))))));
				if (flag2)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTmpPUT09")))))))));
				}
				bool flag3 = !Directory.Exists(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				if (flag3)
				{
					Directory.CreateDirectory(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWt6WXpsUVVUMDk=")))))))));
				}
				Random random = new Random();
				string text = string.Concat(new string[]
				{
					DateTime.Now.Day.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Month.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Year.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Hour.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Minute.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					DateTime.Now.Second.ToString(),
					Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjBoak9WQlJQVDA9")))))))),
					random.Next(1000, 9999).ToString()
				});
				bool flag4 = firefox != null;
				if (flag4)
				{
					string contents = firefox.ExecuteScript(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V2tjeFIyVlZiRWhOVjJocVlsaFJlRmt3VGtKUFZXeElWVzVhV2sweFdqQlhiR014VFVWNGRGVnVXbHBOTVZvd1YyeGpNVTFHU2xobFIzaHBWakZhTVZwRlRURmpSMHAwVGxkNGFtRXlhRlpXUmxZelRqSk9kRlpxUW10WFJYQXhVMVZqZUdGSFRuUmtSRVpxVWtoTk9RPT0="))))))))).ToString();
					firefox.ScreenCapture(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhpU0ZKYVZqSlNjMWw2UmpOUVVUMDk=")))))))), text);
					File.WriteAllText(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhoUkVKcFZqTm9hZz09")))))))) + text + Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVjeGIwMUhTbGhrZWpBOQ==")))))))), contents);
				}
				using (StreamWriter streamWriter = new StreamWriter(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("V1d0ak5XSnNhRWhsU0ZwaFpWUlZkMXBWYUZKUVVUMDk=")))))))), true))
				{
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VkVaTmQyUkZlRlJOU0ZKTlZYcENNRlJHVFhka1JYaFVUVWhTVFZWNlFqQlVSazEzWkVWNFZFMUlVazFWZWtJd1ZFWk5kMlJGZUZSTlNGSk5WWHBDTUZSR1RYZGtSWGhVVFVoU1RWVjZRakJVUmsxM1pFVjRWRTFJVWsxVmVrSXdWRVpOZDJSRmVGUk5TRkpOVlhwQ01GUkdUWGRrUlhoVVRVaFNUVlY2UWpCVVJrMTNaRVY0VkUxRU1EMD0=")))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld0a1IwMUdjRlZpTW1NOQ==")))))))) + DateTime.Now.ToString(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VjJ0a1VtUnNVbFpOU0Zwc1YwZDNNVnBXVGtOVFZrNUZZMGhTYVZaSVFqWlpNMk01VUZFOVBRPT0="))))))))));
					streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VlcweGMyTXhjRlZpTW1NOQ==")))))))) + text);
					bool flag5 = error != Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(""))))))));
					if (flag5)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vld4b1MyVlhTWHBUVkZwS1VWUXdPUT09")))))))) + error);
					}
					streamWriter.WriteLine();
					bool flag6 = ex != null;
					if (flag6)
					{
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vm10b2MyUXhjRlZpTW1NOQ==")))))))) + ex.GetType().FullName);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("Vmtaa1YyVnRUWGxTYlRWaFZrYzViZz09")))))))) + ex.Message);
						streamWriter.WriteLine(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String("VmxST1UyRkdhM2xrUmxacVlsVmFjVmRzVW5aYWR6MDk=")))))))) + ex.StackTrace);
						ex = ex.InnerException;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000222 RID: 546
		private FirefoxDriver firefox;

		// Token: 0x04000223 RID: 547
		public bool isAlive = false;
	}
}
