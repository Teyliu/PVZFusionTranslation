using System;
using Cpp2IlInjected;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E39 RID: 3641
	[Token(Token = "0x2000E39")]
	public static class CommandLineTools
	{
		// Token: 0x06004B12 RID: 19218 RVA: 0x001718F8 File Offset: 0x0016FAF8
		[Token(Token = "0x6004B12")]
		[Address(RVA = "0x8CA990", Offset = "0x8C8F90", VA = "0x1808CA990")]
		public static string GetCodeViaCmdLineArgs()
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			int num = 0;
			if (num < commandLineArgs.Length)
			{
				bool flag;
				if (flag)
				{
				}
				num++;
			}
			return "";
		}

		// Token: 0x04003534 RID: 13620
		[Token(Token = "0x4003534")]
		private const string k_CodeIdArgs = "code=";
	}
}
