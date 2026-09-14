using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C9 RID: 1737
[Token(Token = "0x20006C9")]
public class JalapenoZombie : Zombie
{
	// Token: 0x06002194 RID: 8596 RVA: 0x000B0E08 File Offset: 0x000AF008
	[Token(Token = "0x6002194")]
	[Address(RVA = "0x5BBCD0", Offset = "0x5BA2D0", VA = "0x1805BBCD0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000B0E34 File Offset: 0x000AF034
	[Token(Token = "0x6002195")]
	[Address(RVA = "0x5BBC40", Offset = "0x5BA240", VA = "0x1805BBC40", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.ZombieUpdate();
		base.Die(2);
		BoardAction boardAction = this.board.boardAction;
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000B0E64 File Offset: 0x000AF064
	[Token(Token = "0x6002196")]
	[Address(RVA = "0x5B3A00", Offset = "0x5B2000", VA = "0x1805B3A00")]
	public JalapenoZombie()
	{
	}
}
