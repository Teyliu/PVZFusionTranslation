using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BA RID: 1210
[Token(Token = "0x20004BA")]
public class TwinFlower : SunFlower
{
	// Token: 0x060016D1 RID: 5841 RVA: 0x0007D9F0 File Offset: 0x0007BBF0
	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x4ABD50", Offset = "0x4AA350", VA = "0x1804ABD50", Slot = "70")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem component = this.board.GetComponent<CreateItem>();
		CreateItem component2 = this.board.GetComponent<CreateItem>();
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x0007DA38 File Offset: 0x0007BC38
	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public TwinFlower()
	{
	}
}
