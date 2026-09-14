using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DE RID: 1246
[Token(Token = "0x20004DE")]
public class TwinFlower : SunFlower
{
	// Token: 0x0600177B RID: 6011 RVA: 0x00080654 File Offset: 0x0007E854
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x517980", Offset = "0x515F80", VA = "0x180517980", Slot = "69")]
	protected override void ProduceSun()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.3f, 1f);
		CreateItem component = this.board.GetComponent<CreateItem>();
		CreateItem component2 = this.board.GetComponent<CreateItem>();
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x0008069C File Offset: 0x0007E89C
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public TwinFlower()
	{
	}
}
