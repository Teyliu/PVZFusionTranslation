using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x2000D2C")]
	public class ProPlayButtonAttribute : Attribute, IButtonAttribute
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x00162870 File Offset: 0x00160A70
		[Token(Token = "0x170007E8")]
		public string Error
		{
			[Token(Token = "0x6004646")]
			[Address(RVA = "0x84A230", Offset = "0x848830", VA = "0x18084A230", Slot = "4")]
			get
			{
				return "Unity Editor is not running, press the unity play button - or use the [ProButton] attribute to execute methods in Edit mode";
			}
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00162884 File Offset: 0x00160A84
		[Token(Token = "0x6004647")]
		[Address(RVA = "0x84A1F0", Offset = "0x8487F0", VA = "0x18084A1F0", Slot = "5")]
		public bool PerformCheck(global::UnityEngine.Object obj)
		{
			return Application.isPlaying;
		}

		// Token: 0x06004648 RID: 17992 RVA: 0x00162898 File Offset: 0x00160A98
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ProPlayButtonAttribute()
		{
		}
	}
}
