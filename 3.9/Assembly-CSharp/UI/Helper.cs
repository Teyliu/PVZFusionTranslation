using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace UI
{
	// Token: 0x02000A56 RID: 2646
	[Token(Token = "0x2000A56")]
	public static class Helper
	{
		// Token: 0x06003688 RID: 13960 RVA: 0x00123670 File Offset: 0x00121870
		// Note: this type is marked as 'beforefieldinit'.
		[Token(Token = "0x6003688")]
		[Address(RVA = "0x7C1820", Offset = "0x7BFE20", VA = "0x1807C1820")]
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

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		public static Dictionary<Quality, string> qualityNames;
	}
}
