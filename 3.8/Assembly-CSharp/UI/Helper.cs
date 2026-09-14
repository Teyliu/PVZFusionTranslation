using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UI
{
	// Token: 0x02000A17 RID: 2583
	[Token(Token = "0x2000A17")]
	public static class Helper
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x0011E554 File Offset: 0x0011C754
		// Note: this type is marked as 'beforefieldinit'.
		[Token(Token = "0x6003547")]
		[Address(RVA = "0x75ABC0", Offset = "0x7591C0", VA = "0x18075ABC0")]
		static Helper()
		{
			Dictionary<Quality, string> dictionary = new Dictionary();
			int num = 0;
			dictionary[num] = "木头";
			dictionary[(uint)1] = "白银";
			dictionary[(uint)2] = "黄金";
			dictionary[(uint)3] = "钻石";
			Helper.qualityNames = dictionary;
			throw new NullReferenceException();
		}

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		public static Dictionary<Quality, string> qualityNames;
	}
}
