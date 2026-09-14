using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068A RID: 1674
[Token(Token = "0x200068A")]
public class Drownpult_a : DrownCatapultZombie
{
	// Token: 0x06001FDD RID: 8157 RVA: 0x000A92F4 File Offset: 0x000A74F4
	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x5A1DE0", Offset = "0x5A03E0", VA = "0x1805A1DE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000A9310 File Offset: 0x000A7510
	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x5A4E50", Offset = "0x5A3450", VA = "0x1805A4E50", Slot = "77")]
	protected override void CataUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float boardMaxX = board.boardMaxX;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000A936C File Offset: 0x000A756C
	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x5A4CA0", Offset = "0x5A32A0", VA = "0x1805A4CA0", Slot = "76")]
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

	// Token: 0x06001FE0 RID: 8160 RVA: 0x000A93C4 File Offset: 0x000A75C4
	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x5A4F40", Offset = "0x5A3540", VA = "0x1805A4F40")]
	public Drownpult_a()
	{
	}
}
