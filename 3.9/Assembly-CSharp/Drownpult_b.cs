using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068B RID: 1675
[Token(Token = "0x200068B")]
public class Drownpult_b : DrownCatapultZombie
{
	// Token: 0x06001FE1 RID: 8161 RVA: 0x000A93D8 File Offset: 0x000A75D8
	[Token(Token = "0x6001FE1")]
	[Address(RVA = "0x5A1DE0", Offset = "0x5A03E0", VA = "0x1805A1DE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000A93F4 File Offset: 0x000A75F4
	[Token(Token = "0x6001FE2")]
	[Address(RVA = "0x5A5100", Offset = "0x5A3700", VA = "0x1805A5100", Slot = "77")]
	protected override void CataUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float boardMaxX = board.boardMaxX;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000A9450 File Offset: 0x000A7650
	[Token(Token = "0x6001FE3")]
	[Address(RVA = "0x5A4F50", Offset = "0x5A3550", VA = "0x1805A4F50", Slot = "76")]
	protected override void AnimShoot()
	{
		Transform shoot = this.shoot;
		float num = global::UnityEngine.Random.Range(-0.5f, 0.5f);
		float num2 = global::UnityEngine.Random.Range(-0.3f, 0.3f);
		while (shoot != 0)
		{
		}
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		base.DestoryWeapon2();
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000A94A8 File Offset: 0x000A76A8
	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x5A4F40", Offset = "0x5A3540", VA = "0x1805A4F40")]
	public Drownpult_b()
	{
	}
}
