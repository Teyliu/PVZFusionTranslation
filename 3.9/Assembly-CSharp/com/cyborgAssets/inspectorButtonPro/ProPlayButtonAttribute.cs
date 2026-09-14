using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000DF8 RID: 3576
	[Token(Token = "0x2000DF8")]
	public class ProPlayButtonAttribute : Attribute, IButtonAttribute
	{
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0016CF88 File Offset: 0x0016B188
		[Token(Token = "0x17000967")]
		public string Error
		{
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x8CF610", Offset = "0x8CDC10", VA = "0x1808CF610", Slot = "7")]
			get
			{
				return "Unity Editor is not running, press the unity play button - or use the [ProButton] attribute to execute methods in Edit mode";
			}
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x0016CF9C File Offset: 0x0016B19C
		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x8CF5D0", Offset = "0x8CDBD0", VA = "0x1808CF5D0", Slot = "8")]
		public bool PerformCheck(global::UnityEngine.Object obj)
		{
			return Application.isPlaying;
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x0016CFB0 File Offset: 0x0016B1B0
		[Token(Token = "0x60049F7")]
		[Address(RVA = "0x400960", Offset = "0x3FEF60", VA = "0x180400960")]
		public ProPlayButtonAttribute()
		{
		}
	}
}
