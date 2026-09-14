using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000D2B RID: 3371
	[Token(Token = "0x2000D2B")]
	public class ProButtonAttribute : Attribute, IButtonAttribute
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x00162838 File Offset: 0x00160A38
		[Token(Token = "0x170007E7")]
		public string Error
		{
			[Token(Token = "0x6004643")]
			[Address(RVA = "0x84A1C0", Offset = "0x8487C0", VA = "0x18084A1C0", Slot = "4")]
			get
			{
				return "Selected object is a prefab, use [Prefab] tag to execute method on a prefab";
			}
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x0016284C File Offset: 0x00160A4C
		[Token(Token = "0x6004644")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "5")]
		public bool PerformCheck(global::UnityEngine.Object obj)
		{
			return true;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x0016285C File Offset: 0x00160A5C
		[Token(Token = "0x6004645")]
		[Address(RVA = "0x82DCC0", Offset = "0x82C2C0", VA = "0x18082DCC0")]
		public ProButtonAttribute()
		{
		}
	}
}
