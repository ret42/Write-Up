using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
using Microsoft.Win32;

namespace Rush_it_redesign
{
	// Token: 0x0200000A RID: 10
	public class internet : UserControl
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000065B4 File Offset: 0x000047B4
		public static internet Instance
		{
			get
			{
				bool flag = internet._instance == null;
				if (flag)
				{
					internet._instance = new internet();
				}
				return internet._instance;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000065E4 File Offset: 0x000047E4
		public bool PingTooBig(string host, int packetSize, int packetCount)
		{
			bool result = false;
			int num = 3000;
			byte[] buffer = new byte[packetSize];
			Ping ping = new Ping();
			for (int i = 0; i < packetCount; i++)
			{
				bool flag = ping.Send(host, num, buffer, new PingOptions(num, true)).Status == IPStatus.PacketTooBig;
				if (flag)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000664C File Offset: 0x0000484C
		public internet()
		{
			this.InitializeComponent();
			string text = Class5.fKfiSeRjqN();
			this.bunifuMaterialTextbox4.Text = text;
			string text2 = Class5.smethod_0();
			this.bunifuMaterialTextbox1.Text = text2;
			this.bunifuMaterialTextbox2.Text = new Ping().Send("google.com").RoundtripTime.ToString();
			string host = "216.58.209.228";
			for (int i = 1500; i >= 0; i--)
			{
				bool flag = !this.PingTooBig(host, i, 1);
				if (flag)
				{
					this.int_0 = 28 + i;
					this.bunifuMaterialTextbox3.Text = this.int_0.ToString();
					break;
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000671C File Offset: 0x0000491C
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			this.bunifuMaterialTextbox2.Text = new Ping().Send("google.com").RoundtripTime.ToString();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002057 File Offset: 0x00000257
		private void internet_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002057 File Offset: 0x00000257
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002057 File Offset: 0x00000257
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002057 File Offset: 0x00000257
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002057 File Offset: 0x00000257
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006754 File Offset: 0x00004954
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string text = this.bunifuMaterialTextbox2.Text;
			string value = Class7.smethod_0();
			double[] array = new double[2];
			for (int i = 0; i < 2; i++)
			{
				array[i] = Convert.ToDouble(text) / 1000.0 * 2.0;
			}
			int num = Convert.ToInt32(text) * 2;
			int num2 = Convert.ToInt32(value) / 4 * 983040;
			string str = Class5.smethod_0();
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "IGMPVersion", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DeadGWDetectDefault", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DontAddDefaultGatewayDefault", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "SynAttackProtect", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "UseDomainNameDevolution", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DefaultRegistrationTTL", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "IPEnableRouter", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DefaultTTL", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "DisableTaskOffload", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableConnectionRateLimiting", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnablePMTUDiscovery", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnablePMTUBHDetect", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableDCA", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableICMPRedirect", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableTCPA", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableWsd", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "EnableFastRouteLookup", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "FFPFastForwardingCacheSize", num2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "FFPControlFlags", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "IGMPLevel", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "MaxFreeTcbs", 65536, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "MaxHashTableSize", 65536, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "MaxUserPort", 65534, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "SackOpts", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "StrictTimeWaitSeqCheck", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "Tcp1323Opts", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxConnectResponseRetransmissions", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxConnectRetransmissions", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpCreateAndConnectTcbRateLimitDepth", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxSendFree", 65535, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxDupAcks", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpMaxDataRetransmissions", num / 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TcpUseRFC1122UrgentPointer", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters", "TrFunctionalMcastAddress", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "TCPNoDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "MaxForwardPending", -1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "TcpDelAckTicks", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "TcpAckFrequency", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "TcpInitialRTT", num, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "MTU", this.bunifuMaterialTextbox3.Text, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "DontAddDefaultGateway", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "UseZeroBroadcast", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "IPAutoconfigurationEnabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\" + str, "EnableDHCP", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched\\Parameters\\Adapters\\" + str, "NonBestEffortLimit", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched\\Parameters\\Adapters" + str, "NonBestEffortLimit", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched\\Parameters\\Adapters" + str, "MaxOutstandingSends", -1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Psched", "MaxOutstandingSends", -1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched\\Parameters", "TimerResolution", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Ndu", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", uint.MaxValue, RegistryValueKind.QWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "AckTimeout", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "BscAckFrequency", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "DcCacheExpirationTime", 1000, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "SeqMaxAckDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "StoreAckTimeout", 65535, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "TCPNoDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched", "NonBestEffortLimit", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "TCPNoDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS", "LowDelayBound  ", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS", "EnablePriorityBoost", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS", "EnableRSVP", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS", "Do Not Use NLA", 1, RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider", "DnsPriority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider", "HostsPriority", 5, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider", "LocalPriority", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider", "NetbtPriority", 7, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxCacheEntryTtlLimit", 64000, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxSOACacheEntryTtlLimit", 301, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "NegativeCacheTime", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "NetFailureCacheTime", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "NegativeSOACacheTime", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "CacheHashTableBucketSize", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "CacheHashTableSize", 384, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxCacheTtl", 10800, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters", "MaxNegativeCacheTtl", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\LanmanServer\\Parameters", "Size", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\LanmanServer\\Parameters", "IRPStackSize", 50, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\LanmanServer\\Parameters", "SizReqBuf", 17424, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\LanmanServer\\Parameters", "RestrictNullSessAccess", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "KeepConn", 32000, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "CollectionTime", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "MaxCollectionCount", 32, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "SizCharBuf", 4096, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "MaxCmds", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "BufFilesDenyWrite", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "MailslotBuffers", 16777215, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "NetworkThrottlingIndex", uint.MaxValue, RegistryValueKind.QWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "Size/Small/Medium/Large", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "EnableDns", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "BcastNameQueryCount", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "EnableLMHOSTS", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "NameSrvQueryCount", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "UseNewSmb", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "EnableProxy", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "EnableProxyRegCheck", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "NoNameReleaseOnDemand", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "BcastQueryTimeout", 750, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "CacheTimeout", uint.MaxValue, RegistryValueKind.QWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "ConnectOnRequestedInterfaceOnly", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NetBT\\Parameters", "DhcpNodeType", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", "DisableLargeMtu", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "EnableDynamicBacklog", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "BufferMultiplier", 6144, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "MinimumDynamicBacklog", 200, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "MaximumDynamicBacklog", 20000, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters", "DynamicBacklogGrowthDelta", 100, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched", "TimerResolution", 67537, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\WindowsUpdate", "AllowAutoWindowsUpdateDownloadOverMeteredNetwork", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "MaxConnectionsPerServer", 16, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "MaxConnectionsPer1_0Server", 16, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "EndMaxConnectionsPer1_0Server", 16, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", "SmoothScroll", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "TCPNoDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "SecureDSCommunication", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "AckTimeout", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "CleanupInterval", 3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "DcCacheExpirationTime", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "IdleAckDelay", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "IgnoreOSNameValidation", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "MaxRRThreads", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "MaxUnackedPacket", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "MaxUncackedPacket", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "MinRRThreads", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "RRThreadIdleTTL", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "SeqMaxAckDelay", 30, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSMQ\\Parameters", "StoreAckTimeout", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DesktopLivePreviewHoverTime", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "ExtendedUIHoverTime", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "EnableBalloonTips", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\cisvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SysMain", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\xbgm", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XblAuthManager", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XblGameSave", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\xboxgip", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XboxGipSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XboxNetApiSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MapsBroker", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\iphlpsvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\ALG", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AppMgmt", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PeerDistSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\CertPropSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\irmon", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MSiSCSI", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NaturalAuthentication", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Netlogon", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RpcLocator", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RetailDemo", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SCPolicySvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SNMPTRAP", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wcncsvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WinRM", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WwanSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SessionEnv", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TermService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\UmRdpService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\AJRouter", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RpcLocator", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\BthHFSrv", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\bthserv", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushsvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HvHost", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmickvpexchange", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmicguestinterface", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmicshutdown", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmicheartbeat", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmicvmsession", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\vmicrdv", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\IpxlatCfgSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SmsRouter", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\CscService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SEMgrSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PhoneSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensorDataService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensrSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensorService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\ScDeviceEnum", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TabletInputService", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WebClient", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WFDSConSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\FrameServer", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\icssvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lfsvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NcdAutoSetup", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NfsClnt", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WMPNetworkSvc", "Start", 4, RegistryValueKind.DWord);
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "NETSH.exe",
					Arguments = "int tcp reset"
				}
			};
			process.StartInfo.Arguments = "int ip reset";
			process.StartInfo.Arguments = "winsock reset";
			process.StartInfo.Arguments = "int ip delete arpcache";
			process.StartInfo.Arguments = "nap reset";
			process.StartInfo.Arguments = "rpc reset";
			process.StartInfo.Arguments = "winhttp reset";
			process.StartInfo.Arguments = "http flush";
			process.StartInfo.Arguments = "http delete timeout timeouttype=idleconnectiontimeout";
			process.StartInfo.Arguments = "http delete timeout timeouttype=headerwaittimeout";
			process.StartInfo.Arguments = "winhttp reset proxy";
			process.StartInfo.Arguments = "winhttp reset tracing";
			process.StartInfo.Arguments = "http delete cache";
			process.StartInfo.Arguments = "branchcache reset";
			process.StartInfo.Arguments = "routing reset";
			process.StartInfo.Arguments = "interface ipv4 reset";
			process.StartInfo.Arguments = "interface ipv6 reset";
			process.StartInfo.Arguments = "interface reset all";
			process.StartInfo.Arguments = "interface httpstunnel reset";
			process.StartInfo.Arguments = "int tcp set global autotuninglevel=normal";
			process.StartInfo.Arguments = "int tcp set global dca=enabled";
			process.StartInfo.Arguments = "interface tcp set global ecncapability=disabled";
			process.StartInfo.Arguments = "int tcp set global ecncapability=disabled";
			process.StartInfo.Arguments = "int tcp set heuristics enabled";
			process.StartInfo.Arguments = "interface tcp set heuristics wsh=enabled";
			process.StartInfo.Arguments = "interface tcp set heuristics forcews=enabled";
			process.StartInfo.Arguments = "interface ip set global neighborcachelimit=4096";
			process.StartInfo.Arguments = "int tcp set global fastopen=enabled";
			process.StartInfo.Arguments = "int tcp set global nonsackrttresiliency=disabled";
			process.StartInfo.Arguments = "int tcp set global rsc=disabled";
			process.StartInfo.Arguments = "int tcp set global maxsynretransmissions=2";
			process.StartInfo.Arguments = "int ipv4 set global defaultcurhoplimit=255";
			process.StartInfo.Arguments = string.Concat(new string[]
			{
				"int ipv4 set subinterface ",
				this.bunifuMaterialTextbox4.Text,
				" mtu=",
				this.bunifuMaterialTextbox3.Text,
				" store=persistent"
			});
			process.StartInfo.Arguments = "int tcp set security mpp=enabled";
			process.StartInfo.Arguments = "int ip set global icmpredirects=enabled";
			process.StartInfo.Arguments = "int ip set winsservers name=" + this.bunifuMaterialTextbox4.Text + " source=dhcp";
			process.StartInfo.Arguments = "int tcp set global netdma=enabled";
			process.StartInfo.Arguments = "int ip set global sourceroutingbehavior=forward";
			process.StartInfo.Arguments = "int ip set global taskoffload=disabled";
			process.StartInfo.Arguments = "int ip set global dhcpmediasense=enabled";
			process.StartInfo.Arguments = "int ip set global mediasenseeventlog=disabled";
			process.StartInfo.Arguments = "int ip set global mldlevel=none";
			process.StartInfo.Arguments = "int ip set global mldversion=version3";
			process.StartInfo.Arguments = "int ip set global multicastforwarding=disabled";
			process.StartInfo.Arguments = "int ip set global groupforwardedfragments=enabled";
			process.StartInfo.Arguments = "int ip set global randomizeidentifiers=enabled";
			process.StartInfo.Arguments = "int ip set global addressmaskreply=enabled";
			process.StartInfo.Arguments = "Int tcp set supplemental congestionprovider=ctcp";
			process.StartInfo.Arguments = "http add timeout timeouttype=idleconnectiontimeout value=30";
			process.StartInfo.Arguments = "http add timeout timeouttype=headerwaittimeout value=120";
			process.StartInfo.Arguments = "int ipv4 set interface " + this.bunifuMaterialTextbox4.Text + " retransmittime=1";
			process.StartInfo.Arguments = "int ipv6 set interface " + this.bunifuMaterialTextbox4.Text + " retransmittime=1";
			process.StartInfo.Arguments = "int ipv4 set interface " + this.bunifuMaterialTextbox4.Text + " advertisedrouterlifetime=255";
			process.StartInfo.Arguments = "int ipv6 set interface " + this.bunifuMaterialTextbox4.Text + " advertisedrouterlifetime=255";
			process.StartInfo.Arguments = "int ipv4 set interface " + this.bunifuMaterialTextbox4.Text + " advertisedefaultroute=enabled";
			process.StartInfo.Arguments = "int ipv6 set interface " + this.bunifuMaterialTextbox4.Text + " advertisedefaultroute=enabled";
			process.StartInfo.Arguments = "int ipv4 set interface " + this.bunifuMaterialTextbox4.Text + " rabaseddnsconfig=enabled";
			process.StartInfo.Arguments = "int ipv6 set interface " + this.bunifuMaterialTextbox4.Text + " rabaseddnsconfig=enabled";
			process.StartInfo.Arguments = "int ipv4 set interface " + this.bunifuMaterialTextbox4.Text + " dhcpstaticipcoexistence=enabled";
			process.StartInfo.Arguments = "int ipv6 set interface " + this.bunifuMaterialTextbox4.Text + " dhcpstaticipcoexistence=enabled";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			MessageBox.Show("Parametres appliqué voulez vous redémarrer maintenent", "Rush It", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008040 File Offset: 0x00006240
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Class5.fKfiSeRjqN();
			string str = Class5.smethod_0();
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "netsh.exe",
					Arguments = "int tcp reset"
				}
			};
			process.StartInfo.Arguments = "int ip reset";
			process.StartInfo.Arguments = "winsock reset";
			process.StartInfo.Arguments = "int ip delete arpcache";
			process.StartInfo.Arguments = "nap reset";
			process.StartInfo.Arguments = "rpc reset";
			process.StartInfo.Arguments = "winhttp reset";
			process.StartInfo.Arguments = "http flush";
			process.StartInfo.Arguments = "http delete timeout timeouttype=idleconnectiontimeout";
			process.StartInfo.Arguments = "http delete timeout timeouttype=headerwaittimeout";
			process.StartInfo.Arguments = "winhttp reset proxy";
			process.StartInfo.Arguments = "winhttp reset tracing";
			process.StartInfo.Arguments = "http delete cache";
			process.StartInfo.Arguments = "branchcache reset";
			process.StartInfo.Arguments = "routing reset";
			process.StartInfo.Arguments = "interface ipv4 reset";
			process.StartInfo.Arguments = "interface ipv6 reset";
			process.StartInfo.Arguments = "interface reset all";
			process.StartInfo.Arguments = "interface httpstunnel reset";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			string name = "SYSTEM\\CurrentControlSet\\Services\\TcpIp\\Parameters";
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name, true))
			{
				registryKey.DeleteValue("DefaultTTL", false);
				registryKey.DeleteValue("Tcp1323Opts", false);
				registryKey.DeleteValue("TcpTimedWaitDelay", false);
				registryKey.DeleteValue("TcpFinWait2Delay", false);
				registryKey.DeleteValue("TcpMaxDupAcks", false);
				registryKey.DeleteValue("TcpMaxSendFree", false);
				registryKey.DeleteValue("StrictTimeWaitSeqCheck", false);
				registryKey.DeleteValue("MaxFreeTcbs", false);
				registryKey.DeleteValue("MaxUserPort", false);
				registryKey.DeleteValue("MaxHashTableSize", false);
				registryKey.DeleteValue("EnablePMTUBHDetect", false);
				registryKey.DeleteValue("EnablePMTUDiscovery", false);
				registryKey.DeleteValue("EnableICMPRedirect", false);
				registryKey.DeleteValue("SackOpts", false);
				registryKey.DeleteValue("UseDomainNameDevolution", false);
				registryKey.DeleteValue("EnableIPAutoConfigurationLimits", false);
				registryKey.DeleteValue("SynAttackProtect", false);
				registryKey.DeleteValue("DontAddDefaultGatewayDefault", false);
				registryKey.DeleteValue("DeadGWDetectDefault", false);
				registryKey.DeleteValue("EnableConnectionRateLimiting", false);
				registryKey.DeleteValue("TcpNumConnections", false);
				registryKey.DeleteValue("TcpMaxConnectResponseRetransmissions", false);
				registryKey.DeleteValue("PPTPTcpMaxDataRetransmissions", false);
				registryKey.DeleteValue("TcpMaxDataRetransmissions", false);
				registryKey.DeleteValue("TcpMaxConnectRetransmissions", false);
				registryKey.DeleteValue("TcpCreateAndConnectTcbRateLimitDepth", false);
				registryKey.DeleteValue("DisableTaskOffload", false);
				registryKey.DeleteValue("EnableTCPA", false);
				registryKey.DeleteValue("EnableWsd", false);
				registryKey.DeleteValue("EnableDCA", false);
				registryKey.DeleteValue("ArpRetryCount", false);
				registryKey.DeleteValue("ArpTRSingleRoute", false);
				registryKey.DeleteValue("IGMPLevel", false);
				registryKey.DeleteValue("IGMPVersion", false);
				registryKey.DeleteValue("TcpMaxPortsExhausted", false);
				registryKey.DeleteValue("TcpMaxHalfOpen", false);
				registryKey.DeleteValue("TcpMaxHalfOpenRetried", false);
				registryKey.DeleteValue("FFPControlFlags", false);
				registryKey.DeleteValue("TrFunctionalMcastAddress", false);
				registryKey.DeleteValue("ArpCacheLife", false);
				registryKey.DeleteValue("ArpCacheMinReferencedLife", false);
				registryKey.DeleteValue("QualifyingDestinationThreshold", false);
				registryKey.DeleteValue("IPEnableRouter", false);
				registryKey.DeleteValue("PrioritizeRecordData", false);
				registryKey.DeleteValue("DefaultRegistrationTTL", false);
				registryKey.DeleteValue("Tcp1323Opts", false);
				registryKey.DeleteValue("GlobalMaxTcpWindowSize", false);
				registryKey.DeleteValue("NumTcbTablePartitions", false);
				registryKey.DeleteValue("TcpUseRFC1122UrgentPointer", false);
				registryKey.DeleteValue("SyncDomainWithMembership", false);
				registryKey.DeleteValue("NumForwardPackets", false);
			}
			string name2 = "SYSTEM\\CurrentControlSet\\Services\\TcpIp\\Parameters\\interfaces\\" + str;
			using (RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(name2, true))
			{
				registryKey2.DeleteValue("TCPNoDelay", false);
				registryKey2.DeleteValue("TcpAckFrequency", false);
				registryKey2.DeleteValue("TcpDelAckTicks", false);
				registryKey2.DeleteValue("TcpInitialRTT", false);
				registryKey2.DeleteValue("DontAddDefaultGateway", false);
				registryKey2.DeleteValue("InterfaceMetric", false);
				registryKey2.DeleteValue("MTU", false);
				registryKey2.DeleteValue("UseZeroBoradcast", false);
				registryKey2.DeleteValue("IPAutoconfigurationEnabled", false);
				registryKey2.DeleteValue("TcpWindowSize", false);
			}
			string name3 = "SYSTEM\\CurrentControlSet\\Services\\Dnscache\\Parameters";
			using (RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(name3, true))
			{
				registryKey3.DeleteValue("MaxCacheEntryTtlLimit", false);
				registryKey3.DeleteValue("MaxSOACacheEntryTtlLimit", false);
				registryKey3.DeleteValue("NegativeCacheTime", false);
				registryKey3.DeleteValue("NetFailureCacheTime", false);
				registryKey3.DeleteValue("NegativeSOACacheTime", false);
				registryKey3.DeleteValue("CacheHashTableBucketSize", false);
				registryKey3.DeleteValue("CacheHashTableSize", false);
			}
			string name4 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS";
			using (RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey(name4, true))
			{
				registryKey4.DeleteValue("LowDelayBound", false);
				registryKey4.DeleteValue("EnablePriorityBoost", false);
				registryKey4.DeleteValue("EnableRSVP", false);
			}
			string name5 = "SOFTWARE\\Microsoft\\MSMQ\\Parameters";
			using (RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey(name5, true))
			{
				registryKey5.DeleteValue("TCPNoDelay", false);
			}
			string name6 = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
			using (RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey(name6, true))
			{
				registryKey6.DeleteValue("MaxConnectionsPerServer", false);
				registryKey6.DeleteValue("MaxConnectionsPer1_0Server", false);
			}
			string name7 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters";
			using (RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey(name7, true))
			{
				registryKey7.DeleteValue("DisabledComponents", false);
			}
			string name8 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS";
			using (RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey(name8, true))
			{
				registryKey8.DeleteValue("LowDelayBound", false);
				registryKey8.DeleteValue("EnablePriorityBoost", false);
				registryKey8.DeleteValue("EnableRSVP", false);
			}
			MessageBox.Show("Parametres appliqué voulez vous redémarrer maintenent", "Rush It", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000881C File Offset: 0x00006A1C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00008854 File Offset: 0x00006A54
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(internet));
			this.bunifuMaterialTextbox1 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox3 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox4 = new BunifuMaterialTextbox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.bunifuImageButton1 = new BunifuImageButton();
			Guna2Button guna2Button = new Guna2Button();
			Guna2Button guna2Button2 = new Guna2Button();
			((ISupportInitialize)this.bunifuImageButton1).BeginInit();
			base.SuspendLayout();
			guna2Button.BorderRadius = 22;
			guna2Button.CheckedState.Parent = guna2Button;
			guna2Button.CustomImages.Parent = guna2Button;
			guna2Button.FillColor = Color.White;
			guna2Button.Font = new Font("Segoe UI", 15f);
			guna2Button.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button.HoverState.Parent = guna2Button;
			guna2Button.Image = (Image)componentResourceManager.GetObject("guna2Button2.Image");
			guna2Button.ImageAlign = HorizontalAlignment.Left;
			guna2Button.ImageSize = new Size(40, 40);
			guna2Button.Location = new Point(68, 314);
			guna2Button.Name = "guna2Button2";
			guna2Button.ShadowDecoration.Parent = guna2Button;
			guna2Button.Size = new Size(184, 61);
			guna2Button.TabIndex = 4;
			guna2Button.Text = "Apply";
			guna2Button.Click += this.guna2Button2_Click;
			guna2Button2.BorderRadius = 22;
			guna2Button2.CheckedState.Parent = guna2Button2;
			guna2Button2.CustomImages.Parent = guna2Button2;
			guna2Button2.FillColor = Color.White;
			guna2Button2.Font = new Font("Segoe UI", 15f);
			guna2Button2.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button2.HoverState.Parent = guna2Button2;
			guna2Button2.Image = (Image)componentResourceManager.GetObject("guna2Button1.Image");
			guna2Button2.ImageAlign = HorizontalAlignment.Left;
			guna2Button2.ImageSize = new Size(40, 40);
			guna2Button2.Location = new Point(369, 314);
			guna2Button2.Name = "guna2Button1";
			guna2Button2.ShadowDecoration.Parent = guna2Button2;
			guna2Button2.Size = new Size(184, 61);
			guna2Button2.TabIndex = 5;
			guna2Button2.Text = "Remove";
			guna2Button2.Click += this.guna2Button1_Click;
			this.bunifuMaterialTextbox1.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox1.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox1.ForeColor = Color.White;
			this.bunifuMaterialTextbox1.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox1.HintText = "Interface";
			this.bunifuMaterialTextbox1.isPassword = false;
			this.bunifuMaterialTextbox1.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox1.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox1.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox1.LineThickness = 3;
			this.bunifuMaterialTextbox1.Location = new Point(126, 98);
			this.bunifuMaterialTextbox1.Margin = new Padding(4);
			this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
			this.bunifuMaterialTextbox1.Size = new Size(379, 33);
			this.bunifuMaterialTextbox1.TabIndex = 0;
			this.bunifuMaterialTextbox1.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox1.OnValueChanged += this.bunifuMaterialTextbox1_OnValueChanged;
			this.bunifuMaterialTextbox2.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox2.ForeColor = Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox2.HintText = "Ping";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox2.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new Point(68, 180);
			this.bunifuMaterialTextbox2.Margin = new Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new Size(109, 33);
			this.bunifuMaterialTextbox2.TabIndex = 1;
			this.bunifuMaterialTextbox2.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox2.OnValueChanged += this.bunifuMaterialTextbox2_OnValueChanged;
			this.bunifuMaterialTextbox3.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox3.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox3.ForeColor = Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox3.HintText = "Mtu";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox3.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new Point(444, 180);
			this.bunifuMaterialTextbox3.Margin = new Padding(4);
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new Size(109, 33);
			this.bunifuMaterialTextbox3.TabIndex = 2;
			this.bunifuMaterialTextbox3.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox3.OnValueChanged += this.bunifuMaterialTextbox3_OnValueChanged;
			this.bunifuMaterialTextbox4.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox4.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox4.ForeColor = Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox4.HintText = "Type";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox4.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new Point(257, 180);
			this.bunifuMaterialTextbox4.Margin = new Padding(4);
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new Size(109, 33);
			this.bunifuMaterialTextbox4.TabIndex = 3;
			this.bunifuMaterialTextbox4.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox4.OnValueChanged += this.bunifuMaterialTextbox4_OnValueChanged;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 12f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(100, 227);
			this.label1.Name = "label1";
			this.label1.Size = new Size(40, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ping";
			this.label1.Click += this.label1_Click;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 12f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(288, 227);
			this.label2.Name = "label2";
			this.label2.Size = new Size(43, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Type";
			this.label2.Click += this.label2_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 12f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(484, 227);
			this.label3.Name = "label3";
			this.label3.Size = new Size(36, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mtu";
			this.label3.Click += this.label3_Click;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 12f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(278, 145);
			this.label4.Name = "label4";
			this.label4.Size = new Size(73, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Interface";
			this.label4.Click += this.label4_Click;
			this.bunifuImageButton1.BackColor = Color.Transparent;
			this.bunifuImageButton1.Image = (Image)componentResourceManager.GetObject("bunifuImageButton1.Image");
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new Point(182, 191);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new Size(24, 18);
			this.bunifuImageButton1.SizeMode = PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 10;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += this.bunifuImageButton1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 42, 60);
			base.Controls.Add(this.bunifuImageButton1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(guna2Button2);
			base.Controls.Add(guna2Button);
			base.Controls.Add(this.bunifuMaterialTextbox4);
			base.Controls.Add(this.bunifuMaterialTextbox3);
			base.Controls.Add(this.bunifuMaterialTextbox2);
			base.Controls.Add(this.bunifuMaterialTextbox1);
			base.Name = "internet";
			base.Size = new Size(636, 483);
			base.Load += this.internet_Load;
			((ISupportInitialize)this.bunifuImageButton1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003D RID: 61
		private static internet _instance;

		// Token: 0x0400003E RID: 62
		private int int_0;

		// Token: 0x0400003F RID: 63
		private IContainer components = null;

		// Token: 0x04000040 RID: 64
		private BunifuMaterialTextbox bunifuMaterialTextbox1;

		// Token: 0x04000041 RID: 65
		private BunifuMaterialTextbox bunifuMaterialTextbox2;

		// Token: 0x04000042 RID: 66
		private BunifuMaterialTextbox bunifuMaterialTextbox3;

		// Token: 0x04000043 RID: 67
		private BunifuMaterialTextbox bunifuMaterialTextbox4;

		// Token: 0x04000044 RID: 68
		private Label label1;

		// Token: 0x04000045 RID: 69
		private Label label2;

		// Token: 0x04000046 RID: 70
		private Label label3;

		// Token: 0x04000047 RID: 71
		private Label label4;

		// Token: 0x04000048 RID: 72
		private BunifuImageButton bunifuImageButton1;
	}
}
