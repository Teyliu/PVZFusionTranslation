using System;
using Cpp2IlInjected;
using UnityEngine;

namespace com.cyborgAssets.inspectorButtonPro
{
	// Token: 0x02000DF6 RID: 3574
	[Token(Token = "0x2000DF6")]
	public interface IButtonAttribute
	{
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060049F0 RID: 18928
		[Token(Token = "0x17000965")]
		string Error
		{
			[Token(Token = "0x60049F0")]
			[Address(Slot = "0")]
			get;
		}

		// Token: 0x060049F1 RID: 18929
		[Token(Token = "0x60049F1")]
		[Address(Slot = "1")]
		bool PerformCheck(global::UnityEngine.Object obj);
	}
}
