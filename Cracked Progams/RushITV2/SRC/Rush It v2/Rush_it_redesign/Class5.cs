using System;
using System.Management;

namespace Rush_it_redesign
{
	// Token: 0x02000003 RID: 3
	internal class Class5
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002FA8 File Offset: 0x000011A8
		public static string smethod_0()
		{
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM win32_networkadapter WHERE netconnectionstatus = 2")).Get())
			{
				result = Convert.ToString(managementBaseObject["GUID"]);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000301C File Offset: 0x0000121C
		public static string fKfiSeRjqN()
		{
			string result = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM win32_networkadapter WHERE netconnectionstatus = 2")).Get())
			{
				result = Convert.ToString(managementBaseObject["NetConnectionID"]);
			}
			return result;
		}
	}
}
