using System;
using System.Windows.Forms;

namespace Rush_it_redesign
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000020C7 File Offset: 0x000002C7
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
