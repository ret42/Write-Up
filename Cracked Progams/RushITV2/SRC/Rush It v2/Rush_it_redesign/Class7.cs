using System;
using System.Management;

namespace Rush_it_redesign
{
	// Token: 0x02000004 RID: 4
	internal class Class7
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003090 File Offset: 0x00001290
		public static string smethod_0()
		{
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_OperatingSystem")).Get())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				Convert.ToString("SerialNumber");
				result = Math.Round(Convert.ToDouble(managementObject["TotalVisibleMemorySize"]) / 1024.0 / 1024.0).ToString();
			}
			return result;
		}
	}
}
