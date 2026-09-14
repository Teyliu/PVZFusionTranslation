using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200012D RID: 301
[Token(Token = "0x200012D")]
public class Bullet_cherrySquash : Bullet_squash
{
	// Token: 0x060005B8 RID: 1464 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x6BEEF0", Offset = "0x6BD4F0", VA = "0x1806BEEF0", Slot = "27")]
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

	// Token: 0x060005B9 RID: 1465 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x6BF080", Offset = "0x6BD680", VA = "0x1806BF080", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)31)) && global::UnityEngine.Random.Range(0, 100) < 1)
		{
			BoardAction boardAction = this.board.boardAction;
		}
		base.HitZombie(zombie);
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cherrySquash()
	{
	}
}
