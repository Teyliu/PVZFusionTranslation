using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000D2A RID: 3370
	[Token(Token = "0x2000D2A")]
	public interface IButtonAttribute
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06004641 RID: 17985
		[Token(Token = "0x170007E6")]
		string Error
		{
			[Token(Token = "0x6004641")]
			[Address(Slot = "0")]
			get;
		}

		// Token: 0x06004642 RID: 17986
		[Token(Token = "0x6004642")]
		[Address(Slot = "1")]
		bool PerformCheck(global::UnityEngine.Object obj);
	}
}
