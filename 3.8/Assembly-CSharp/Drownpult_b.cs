using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000655 RID: 1621
[Token(Token = "0x2000655")]
public class Drownpult_b : DrownCatapultZombie
{
	// Token: 0x06001EDF RID: 7903 RVA: 0x000A4C34 File Offset: 0x000A2E34
	[Token(Token = "0x6001EDF")]
	[Address(RVA = "0x53F790", Offset = "0x53DD90", VA = "0x18053F790", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x000A4C50 File Offset: 0x000A2E50
	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x5429A0", Offset = "0x540FA0", VA = "0x1805429A0", Slot = "75")]
	protected override void CataUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float boardMaxX = board.boardMaxX;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000A4CAC File Offset: 0x000A2EAC
	[Token(Token = "0x6001EE1")]
	[Address(RVA = "0x5427F0", Offset = "0x540DF0", VA = "0x1805427F0", Slot = "74")]
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

	// Token: 0x06001EE2 RID: 7906 RVA: 0x000A4D04 File Offset: 0x000A2F04
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x5427E0", Offset = "0x540DE0", VA = "0x1805427E0")]
	public Drownpult_b()
	{
	}
}
