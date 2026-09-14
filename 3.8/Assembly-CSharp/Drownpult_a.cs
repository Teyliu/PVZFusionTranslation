using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000654 RID: 1620
[Token(Token = "0x2000654")]
public class Drownpult_a : DrownCatapultZombie
{
	// Token: 0x06001EDB RID: 7899 RVA: 0x000A4B50 File Offset: 0x000A2D50
	[Token(Token = "0x6001EDB")]
	[Address(RVA = "0x53F790", Offset = "0x53DD90", VA = "0x18053F790", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.basketballNum = (int)((ulong)2L);
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x000A4B6C File Offset: 0x000A2D6C
	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x5426F0", Offset = "0x540CF0", VA = "0x1805426F0", Slot = "75")]
	protected override void CataUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float boardMaxX = board.boardMaxX;
		base.SearchPlantUpdate();
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
	[Token(Token = "0x6001EDD")]
	[Address(RVA = "0x542540", Offset = "0x540B40", VA = "0x180542540", Slot = "74")]
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

	// Token: 0x06001EDE RID: 7902 RVA: 0x000A4C20 File Offset: 0x000A2E20
	[Token(Token = "0x6001EDE")]
	[Address(RVA = "0x5427E0", Offset = "0x540DE0", VA = "0x1805427E0")]
	public Drownpult_a()
	{
	}
}
