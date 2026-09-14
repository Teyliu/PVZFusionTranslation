using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x20000A7")]
public class ChessBack : MonoBehaviour
{
	// Token: 0x060002D7 RID: 727 RVA: 0x0000BE90 File Offset: 0x0000A090
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x4088E0", Offset = "0x406EE0", VA = "0x1804088E0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		ChessManager instance = ChessManager.Instance;
		int num = 0;
		bool flag;
		if (instance != num && flag)
		{
			Plant plant = ChessManager.Instance.将.plant;
			ChessManager.Instance.将.plant.FlashOnce();
		}
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ChessBack()
	{
	}
}
