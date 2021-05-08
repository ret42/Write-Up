using System;
using System.Management;

namespace Rush_it_redesign
{
	// Token: 0x02000005 RID: 5
	internal class Class8
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003138 File Offset: 0x00001338
		public static string smethod_0()
		{
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_Processor")).Get();
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				result = managementBaseObject["L3CacheSize"].ToString();
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000031B0 File Offset: 0x000013B0
		public static string smethod_1()
		{
			ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_Processor")).Get();
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				result = managementBaseObject["L2CacheSize"].ToString();
			}
			return result;
		}
	}
}
