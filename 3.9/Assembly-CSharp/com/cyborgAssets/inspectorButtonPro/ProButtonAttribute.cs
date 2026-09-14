using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000DF7 RID: 3575
	[Token(Token = "0x2000DF7")]
	public class ProButtonAttribute : Attribute, IButtonAttribute
	{
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x0016CF50 File Offset: 0x0016B150
		[Token(Token = "0x17000966")]
		public string Error
		{
			[Token(Token = "0x60049F2")]
			[Address(RVA = "0x8CF5A0", Offset = "0x8CDBA0", VA = "0x1808CF5A0", Slot = "7")]
			get
			{
				return "Selected object is a prefab, use [Prefab] tag to execute method on a prefab";
			}
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x0016CF64 File Offset: 0x0016B164
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "8")]
		public bool PerformCheck(global::UnityEngine.Object obj)
		{
			return true;
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x0016CF74 File Offset: 0x0016B174
		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ProButtonAttribute()
		{
		}
	}
}
