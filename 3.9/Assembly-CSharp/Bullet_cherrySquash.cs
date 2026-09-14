using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class Bullet_cherrySquash : Bullet_squash
{
	// Token: 0x060005BF RID: 1471 RVA: 0x0001E484 File Offset: 0x0001C684
	[Token(Token = "0x60005BF")]
	[Address(RVA = "0x6E9CB0", Offset = "0x6E82B0", VA = "0x1806E9CB0", Slot = "25")]
	protected override void AttackZombie()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		int rogueStatus = this.rogueStatus;
		BombCherry bombCherry;
		if (rogueStatus == 0)
		{
			int damage2 = this._damage;
			bombCherry.damageToZombie = damage2;
			bombCherry.Explode(this);
			return;
		}
		if (rogueStatus != 0)
		{
			if (rogueStatus != 1)
			{
			}
			int damage3 = this._damage;
			bombCherry.damageToZombie = damage3;
			float num = bombCherry.range * 0.5f;
			bombCherry.range = num;
			bombCherry.maxRow = (int)((ulong)1L);
			bombCherry.Explode(this);
			return;
		}
		int num2 = this._damage;
		num2 += num2;
		bombCherry.damageToZombie = num2;
		float num3 = bombCherry.range * 1.5f;
		bombCherry.range = num3;
		bombCherry.maxRow = (int)((ulong)2L);
		bombCherry.Explode(this);
	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x0001E570 File Offset: 0x0001C770
	[Token(Token = "0x60005C0")]
	[Address(RVA = "0x6E9E40", Offset = "0x6E8440", VA = "0x1806E9E40", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)31)) && global::UnityEngine.Random.Range(0, 100) < 1)
		{
			BoardAction boardAction = this.board.boardAction;
		}
		base.HitZombie(zombie);
	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x0001E5B0 File Offset: 0x0001C7B0
	[Token(Token = "0x60005C1")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cherrySquash()
	{
	}
}
