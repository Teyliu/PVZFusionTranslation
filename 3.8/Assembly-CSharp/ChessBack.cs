using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
public class ChessBack : MonoBehaviour
{
	// Token: 0x060002BC RID: 700 RVA: 0x0000BAE4 File Offset: 0x00009CE4
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x3BBB30", Offset = "0x3BA130", VA = "0x1803BBB30")]
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

	// Token: 0x060002BD RID: 701 RVA: 0x0000BB34 File Offset: 0x00009D34
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ChessBack()
	{
	}
}
