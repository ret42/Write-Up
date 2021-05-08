using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Guna.UI2.WinForms;
using Microsoft.Win32;

namespace Rush_it_redesign
{
	// Token: 0x0200000D RID: 13
	public class system : UserControl
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000A984 File Offset: 0x00008B84
		public static system Instance
		{
			get
			{
				bool flag = system._instance == null;
				if (flag)
				{
					system._instance = new system();
				}
				return system._instance;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		public system()
		{
			this.InitializeComponent();
			this.bunifuMaterialTextbox2.Text = Class7.smethod_0();
			this.bunifuMaterialTextbox3.Text = Class8.smethod_0() + " Ko";
			this.bunifuMaterialTextbox4.Text = Class8.smethod_1() + " Ko";
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002057 File Offset: 0x00000257
		private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002057 File Offset: 0x00000257
		private void system_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000AA20 File Offset: 0x00008C20
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string value = Class8.smethod_0();
			string value2 = Class8.smethod_1();
			string value3 = Convert.ToString(Math.Ceiling(Convert.ToDecimal(this.bunifuMaterialTextbox2.Text) / 4m * 983040m));
			string value4 = Convert.ToString(Math.Ceiling(Convert.ToDecimal(this.bunifuMaterialTextbox2.Text) * 1024m * 1024m));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control", "SvcHostSplitThresholdInKB", value4, RegistryValueKind.QWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", value4, RegistryValueKind.QWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\", "LargeSystemCache", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\", "ThirdLevelDataCache", value, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\", "SecondLevelDataCache", value2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\", "DisablePagingExecutive", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\", "WriteWatch", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "IoPageLockLimit", value3, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "GameDVR_Enabled", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows", "AllowGameDVR", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Psched", "TimerResolution", 67537, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.BingWeather_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.BingWeather_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.BingWeather_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.GetHelp_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.GetHelp_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.GetHelp_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Getstarted_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Getstarted_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Getstarted_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Messaging_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Messaging_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Messaging_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Microsoft3DViewer_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Microsoft3DViewer_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Microsoft3DViewer_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftOfficeHub_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftSolitaireCollection_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftSolitaireCollection_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MicrosoftSolitaireCollection_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MSPaint_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MSPaint_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.MSPaint_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Office.OneNote_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Office.OneNote_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Office.OneNote_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.OneConnect_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.OneConnect_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.OneConnect_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.People_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.People_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.People_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Print3D_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Print3D_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.Print3D_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.SkypeApp_kzf8qxf38zg5c", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.SkypeApp_kzf8qxf38zg5c", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.SkypeApp_kzf8qxf38zg5c", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsAlarms_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsAlarms_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsAlarms_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\microsoft.windowscommunicationsapps_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsFeedbackHub_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsMaps_8wekyb3d8bbwe", "Disabled", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsMaps_8wekyb3d8bbwe", "DisabledByUser", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\\Microsoft.WindowsMaps_8wekyb3d8bbwe", "IgnoreBatterySaver", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\OneDrive", "DisableLibrariesDefaultSaveToOneDrive", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MRxSmb\\Parameters", "BackupBrowserRecoveryTime", 255, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MRxSmb\\Parameters", "BrowserFindMasterTimeout", 30, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MRxSmb\\Parameters", "BrowserMinimumConfiguredBrowsers", 65535, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MRxSmb\\Parameters", "EnablePlainTextPassword", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MRxSmb\\Parameters", "MaximumBrowseEntries", 262144, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\PowerSettings\\54533251-82be-4824-96c1-47b60b740d00\\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMax", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Control\\PowerSettings\\54533251-82be-4824-96c1-47b60b740d00\\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMin", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\0012ee47-9041-4b5d-9b77-535fba8b1442\\80e3c60e-bb94-4ad8-bbe0-0d3195efc663", "Attributes", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\0012ee47-9041-4b5d-9b77-535fba8b1442\\0b2d69d7-a2a1-449c-9680-f91c70521c60", "Attributes", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\0012ee47-9041-4b5d-9b77-535fba8b1442\\dab60367-53fe-4fbc-825e-521d069d2456", "Attributes", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\2a737441-1930-4402-8d77-b2bebba308a3\\d4e98f31-5ffe-4ce1-be31-1b38b384c009", "Attributes", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\9596FB26-9850-41fd-AC3E-F7C3C00AFD4B\03680956-93BC-4294-BBA6-4E0F09BB717F", "Attributes", 2, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\54533251-82be-4824-96c1-47b60b740d00\\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMax", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PowerSettings\\54533251-82be-4824-96c1-47b60b740d00\\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMin", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\xbgm", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XblAuthManager", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XblGameSave", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\xboxgip", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XboxGipSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\XboxNetApiSvc", "Start", 4, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "GameDVR_Enabled", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows", "AllowGameDVR", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", "AllowTelemetry", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowTelemetry", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\AutoLogger-Diagtrack-Listener", "Start", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\\ShellFolder", "Attributes", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\Wow6432Node\\CLSID\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\\ShellFolder", "Attributes", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows", "AllowGameDVR", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\System\\GameConfigStore", "GameDVR_Enabled", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "BootId", 38, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "BaseTime", 489678465, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "EnablePrefetcher", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "EnableSuperfetch", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", "EnableBoottrace", 0, RegistryValueKind.DWord);
			Process process = new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					Arguments = "sc stop iphlpsvc"
				}
			};
			process.StartInfo.Arguments = "sc stop MSiSCSI";
			process.StartInfo.Arguments = "sc stop napagent";
			process.StartInfo.Arguments = "sc stop Netlogon";
			process.StartInfo.Arguments = "sc stop RemoteAccess";
			process.StartInfo.Arguments = "sc stop sCardSvr";
			process.StartInfo.Arguments = "sc stop sCPolicySvc";
			process.StartInfo.Arguments = "sc stop sensrSvc";
			process.StartInfo.Arguments = "sc stop sNMPTRAP";
			process.StartInfo.Arguments = "sc stop WbioSrvc";
			process.StartInfo.Arguments = "sc stop wcncsvc";
			process.StartInfo.Arguments = "sc stop WMPNetworkSvc";
			process.StartInfo.Arguments = "sc stop SharedAccess";
			process.StartInfo.Arguments = "sc stop Storsvc";
			process.StartInfo.Arguments = "sc config CscService start= auto";
			process.StartInfo.Arguments = "sc config IKEEXT start= demand";
			process.StartInfo.Arguments = "sc config iphlpsvc start = disabled";
			process.StartInfo.Arguments = "sc config KtmRm start = demand";
			process.StartInfo.Arguments = "sc config lltdsvc start = demand";
			process.StartInfo.Arguments = "sc config lmhosts start = auto";
			process.StartInfo.Arguments = "sc config MSiSCSI start = disabled";
			process.StartInfo.Arguments = "sc config napagent start = disabled";
			process.StartInfo.Arguments = "sc config Netlogon start = disabled";
			process.StartInfo.Arguments = "sc config p2pimsvc start = demand";
			process.StartInfo.Arguments = "sc config p2psvc start = demand";
			process.StartInfo.Arguments = "sc config PNRPAutoReg start = demand";
			process.StartInfo.Arguments = "sc config PNRPsvc start = demand";
			process.StartInfo.Arguments = "sc config RemoteAccess start = disabled";
			process.StartInfo.Arguments = "sc config sCardSvr start = disabled";
			process.StartInfo.Arguments = "sc config sCPolicySvc start = disabled";
			process.StartInfo.Arguments = "sc config sensrSvc start = disabled";
			process.StartInfo.Arguments = "sc config sessionEnv start = demand";
			process.StartInfo.Arguments = "sc config sNMPTRAP start = disabled";
			process.StartInfo.Arguments = "sc config sSDPSRV start = demand";
			process.StartInfo.Arguments = "sc config stisvc start = demand";
			process.StartInfo.Arguments = "sc config systemEventsBroker start = demand";
			process.StartInfo.Arguments = "sc config TapiSrv start = auto";
			process.StartInfo.Arguments = "sc config TermService start = demand";
			process.StartInfo.Arguments = "sc config UmRdpService start = demand";
			process.StartInfo.Arguments = "sc config W32Time start = demand";
			process.StartInfo.Arguments = "sc config WbioSrvc start = auto";
			process.StartInfo.Arguments = "sc config wcncsvc start = disabled";
			process.StartInfo.Arguments = "sc config wlidsvc start = demand";
			process.StartInfo.Arguments = "sc config WMPNetworkSvc start = disabled";
			process.StartInfo.Arguments = "sc config WPDBusEnum start = demand";
			process.StartInfo.Arguments = "sc config SharedAccess start = disabled";
			process.StartInfo.Arguments = "sc config PrintNotify start = demand";
			process.StartInfo.Arguments = "sc config seclogon start = demand";
			process.StartInfo.Arguments = "sc config Storsvc start = disabled";
			process.StartInfo.Arguments = "sc config Wsearch start = auto";
			process.StartInfo.Arguments = "del /s /f /q c:\\windows\\temp\\*.*";
			process.StartInfo.Arguments = "rd /s /q c:\\windows\\temp";
			process.StartInfo.Arguments = "md c:\\windows\\temp";
			process.StartInfo.Arguments = "del /s /f /q C:\\WINDOWS\\Prefetch";
			process.StartInfo.Arguments = "del /s /f /q %temp%\\*.*";
			process.StartInfo.Arguments = "rd /s /q %temp%";
			process.StartInfo.Arguments = "md %temp%";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\tempor~1";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\temp";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\tmp";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\ff*.tmp";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\history";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\cookies";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\recent";
			process.StartInfo.Arguments = "deltree /y c:\\windows\\spool\\printers";
			process.StartInfo.Arguments = "del c:\\WIN386.SWP";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			MessageBox.Show("Parametres appliqué voulez vous redémarrer maintenent", "Rush It", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B914 File Offset: 0x00009B14
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer";
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, true))
			{
				registryKey.DeleteValue("NoLowDiskSpaceChecks", false);
				registryKey.DeleteValue("LinkResolveIgnoreLinkInfo", false);
				registryKey.DeleteValue("NoResolveSearch", false);
				registryKey.DeleteValue("NoResolveTrack", false);
				registryKey.DeleteValue("NoInternetOpenWith", false);
			}
			string name2 = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced";
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey(name2, true))
			{
				registryKey2.DeleteValue("DesktopLivePreviewHoverTime", false);
				registryKey2.DeleteValue("ExtendedUIHoverTime", false);
				registryKey2.DeleteValue("EnableBalloonTips", false);
			}
			string name3 = "SYSTEM\\CurrentControlSet\\Control\\ContentIndex";
			using (RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(name3, true))
			{
				registryKey3.DeleteValue("StartupDelay", false);
			}
			string name4 = "SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate";
			using (RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey(name4, true))
			{
				registryKey4.DeleteValue("NoAutoRebootWithLoggedOnUsers", false);
			}
			string name5 = "SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management";
			using (RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey(name5, true))
			{
				registryKey5.DeleteValue("SecondLevelDataCache", false);
				registryKey5.DeleteValue("ThirdLevelDataCache", false);
				registryKey5.DeleteValue("IoPageLockLimit", false);
				registryKey5.DeleteValue("LargeSystemCache", false);
			}
			string name6 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters";
			using (RegistryKey registryKey6 = Registry.LocalMachine.OpenSubKey(name6, true))
			{
				registryKey6.DeleteValue("DisabledComponents", false);
			}
			string name7 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\QoS";
			using (RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey(name7, true))
			{
				registryKey7.DeleteValue("LowDelayBound", false);
				registryKey7.DeleteValue("EnablePriorityBoost", false);
				registryKey7.DeleteValue("EnableRSVP", false);
			}
			string name8 = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider";
			using (RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey(name8, true))
			{
				registryKey8.DeleteValue("Class", false);
			}
			string name9 = "SOFTWARE\\Microsoft\\MSMQ\\Parameters";
			using (RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey(name9, true))
			{
				registryKey9.DeleteValue("TCPNoDelay", false);
			}
			string name10 = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
			using (RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey(name10, true))
			{
				registryKey10.DeleteValue("cc", false);
				registryKey10.DeleteValue("EndMaxConnectionsPer1_0Server", false);
				registryKey10.DeleteValue("SmoothScroll", false);
			}
			string name11 = "Software\\Microsoft\\Windows\\CurrentVersion";
			using (RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey(name11, true))
			{
				registryKey11.DeleteValue("MaxConnectionsPerServer", false);
				registryKey11.DeleteValue("EndMaxConnectionsPer1_0Server", false);
				registryKey11.DeleteValue("SmoothScroll", false);
			}
			MessageBox.Show("Parametres appliqué voulez vous redémarrer maintenent", "Rush It", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000BCFC File Offset: 0x00009EFC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(system));
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.bunifuMaterialTextbox4 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox3 = new BunifuMaterialTextbox();
			this.bunifuMaterialTextbox2 = new BunifuMaterialTextbox();
			this.bunifuCheckbox1 = new BunifuCheckbox();
			this.bunifuCheckbox2 = new BunifuCheckbox();
			this.label4 = new Label();
			this.label5 = new Label();
			Guna2Button guna2Button = new Guna2Button();
			Guna2Button guna2Button2 = new Guna2Button();
			base.SuspendLayout();
			guna2Button.BorderRadius = 22;
			guna2Button.CheckedState.Parent = guna2Button;
			guna2Button.CustomImages.Parent = guna2Button;
			guna2Button.FillColor = Color.White;
			guna2Button.Font = new Font("Segoe UI", 15f);
			guna2Button.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button.HoverState.Parent = guna2Button;
			guna2Button.Image = (Image)componentResourceManager.GetObject("guna2Button1.Image");
			guna2Button.ImageAlign = HorizontalAlignment.Left;
			guna2Button.ImageSize = new Size(40, 40);
			guna2Button.Location = new Point(369, 314);
			guna2Button.Name = "guna2Button1";
			guna2Button.ShadowDecoration.Parent = guna2Button;
			guna2Button.Size = new Size(184, 61);
			guna2Button.TabIndex = 7;
			guna2Button.Text = "Remove";
			guna2Button.Click += this.guna2Button1_Click;
			guna2Button2.BorderRadius = 22;
			guna2Button2.CheckedState.Parent = guna2Button2;
			guna2Button2.CustomImages.Parent = guna2Button2;
			guna2Button2.FillColor = Color.White;
			guna2Button2.Font = new Font("Segoe UI", 15f);
			guna2Button2.ForeColor = Color.FromArgb(40, 42, 60);
			guna2Button2.HoverState.Parent = guna2Button2;
			guna2Button2.Image = (Image)componentResourceManager.GetObject("guna2Button2.Image");
			guna2Button2.ImageAlign = HorizontalAlignment.Left;
			guna2Button2.ImageSize = new Size(40, 40);
			guna2Button2.Location = new Point(68, 314);
			guna2Button2.Name = "guna2Button2";
			guna2Button2.ShadowDecoration.Parent = guna2Button2;
			guna2Button2.Size = new Size(184, 61);
			guna2Button2.TabIndex = 6;
			guna2Button2.Text = "Apply";
			guna2Button2.Click += this.guna2Button2_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Microsoft Sans Serif", 12f);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(480, 193);
			this.label3.Name = "label3";
			this.label3.Size = new Size(37, 20);
			this.label3.TabIndex = 14;
			this.label3.Text = "Lvl3";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 12f);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(293, 193);
			this.label2.Name = "label2";
			this.label2.Size = new Size(37, 20);
			this.label2.TabIndex = 13;
			this.label2.Text = "Lvl2";
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 12f);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(105, 193);
			this.label1.Name = "label1";
			this.label1.Size = new Size(43, 20);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ram";
			this.bunifuMaterialTextbox4.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox4.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox4.ForeColor = Color.White;
			this.bunifuMaterialTextbox4.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox4.HintText = "Lvl2";
			this.bunifuMaterialTextbox4.isPassword = false;
			this.bunifuMaterialTextbox4.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox4.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox4.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox4.LineThickness = 3;
			this.bunifuMaterialTextbox4.Location = new Point(257, 146);
			this.bunifuMaterialTextbox4.Margin = new Padding(4);
			this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
			this.bunifuMaterialTextbox4.Size = new Size(109, 33);
			this.bunifuMaterialTextbox4.TabIndex = 11;
			this.bunifuMaterialTextbox4.Text = "Type";
			this.bunifuMaterialTextbox4.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox4.OnValueChanged += this.bunifuMaterialTextbox4_OnValueChanged;
			this.bunifuMaterialTextbox3.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox3.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox3.ForeColor = Color.White;
			this.bunifuMaterialTextbox3.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox3.HintText = "Lvl3";
			this.bunifuMaterialTextbox3.isPassword = false;
			this.bunifuMaterialTextbox3.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox3.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox3.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox3.LineThickness = 3;
			this.bunifuMaterialTextbox3.Location = new Point(444, 146);
			this.bunifuMaterialTextbox3.Margin = new Padding(4);
			this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
			this.bunifuMaterialTextbox3.Size = new Size(109, 33);
			this.bunifuMaterialTextbox3.TabIndex = 10;
			this.bunifuMaterialTextbox3.Text = "Mtu";
			this.bunifuMaterialTextbox3.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox3.OnValueChanged += this.bunifuMaterialTextbox3_OnValueChanged;
			this.bunifuMaterialTextbox2.Cursor = Cursors.IBeam;
			this.bunifuMaterialTextbox2.Font = new Font("Microsoft Sans Serif", 9.75f);
			this.bunifuMaterialTextbox2.ForeColor = Color.White;
			this.bunifuMaterialTextbox2.HintForeColor = Color.FromArgb(224, 224, 224);
			this.bunifuMaterialTextbox2.HintText = "Ram";
			this.bunifuMaterialTextbox2.isPassword = false;
			this.bunifuMaterialTextbox2.LineFocusedColor = Color.White;
			this.bunifuMaterialTextbox2.LineIdleColor = Color.White;
			this.bunifuMaterialTextbox2.LineMouseHoverColor = Color.White;
			this.bunifuMaterialTextbox2.LineThickness = 3;
			this.bunifuMaterialTextbox2.Location = new Point(68, 146);
			this.bunifuMaterialTextbox2.Margin = new Padding(4);
			this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
			this.bunifuMaterialTextbox2.Size = new Size(109, 33);
			this.bunifuMaterialTextbox2.TabIndex = 9;
			this.bunifuMaterialTextbox2.Text = "Ping";
			this.bunifuMaterialTextbox2.TextAlign = HorizontalAlignment.Center;
			this.bunifuMaterialTextbox2.OnValueChanged += this.bunifuMaterialTextbox2_OnValueChanged;
			this.bunifuCheckbox1.BackColor = Color.White;
			this.bunifuCheckbox1.ChechedOffColor = Color.White;
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = Color.White;
			this.bunifuCheckbox1.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox1.Location = new Point(207, 239);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 19;
			this.bunifuCheckbox2.BackColor = Color.White;
			this.bunifuCheckbox2.ChechedOffColor = Color.White;
			this.bunifuCheckbox2.Checked = true;
			this.bunifuCheckbox2.CheckedOnColor = Color.White;
			this.bunifuCheckbox2.ForeColor = Color.FromArgb(40, 42, 60);
			this.bunifuCheckbox2.Location = new Point(399, 239);
			this.bunifuCheckbox2.Name = "bunifuCheckbox2";
			this.bunifuCheckbox2.Size = new Size(20, 20);
			this.bunifuCheckbox2.TabIndex = 20;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Microsoft Sans Serif", 11f);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(85, 240);
			this.label4.Name = "label4";
			this.label4.Size = new Size(116, 18);
			this.label4.TabIndex = 21;
			this.label4.Text = "Background app";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Microsoft Sans Serif", 11f);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(425, 241);
			this.label5.Name = "label5";
			this.label5.Size = new Size(131, 18);
			this.label5.TabIndex = 22;
			this.label5.Text = "Services Windows";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(40, 42, 60);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.bunifuCheckbox2);
			base.Controls.Add(this.bunifuCheckbox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.bunifuMaterialTextbox4);
			base.Controls.Add(this.bunifuMaterialTextbox3);
			base.Controls.Add(this.bunifuMaterialTextbox2);
			base.Controls.Add(guna2Button);
			base.Controls.Add(guna2Button2);
			base.Name = "system";
			base.Size = new Size(636, 483);
			base.Load += this.system_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005C RID: 92
		private static system _instance;

		// Token: 0x0400005D RID: 93
		private IContainer components = null;

		// Token: 0x0400005E RID: 94
		private Label label3;

		// Token: 0x0400005F RID: 95
		private Label label2;

		// Token: 0x04000060 RID: 96
		private Label label1;

		// Token: 0x04000061 RID: 97
		private BunifuMaterialTextbox bunifuMaterialTextbox4;

		// Token: 0x04000062 RID: 98
		private BunifuMaterialTextbox bunifuMaterialTextbox3;

		// Token: 0x04000063 RID: 99
		private BunifuMaterialTextbox bunifuMaterialTextbox2;

		// Token: 0x04000064 RID: 100
		private BunifuCheckbox bunifuCheckbox1;

		// Token: 0x04000065 RID: 101
		private BunifuCheckbox bunifuCheckbox2;

		// Token: 0x04000066 RID: 102
		private Label label4;

		// Token: 0x04000067 RID: 103
		private Label label5;
	}
}
