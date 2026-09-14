using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BD RID: 445
[Token(Token = "0x20001BD")]
public class Bullet_superCherry : Bullet
{
	// Token: 0x060007A9 RID: 1961 RVA: 0x0002751C File Offset: 0x0002571C
	[Token(Token = "0x60007A9")]
	[Address(RVA = "0x7E6E10", Offset = "0x7E5410", VA = "0x1807E6E10", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		bool shootByZombie = this.shootByZombie;
		BombCherry bombCherry;
		bombCherry.bulletFromZombie = shootByZombie;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		bombCherry.team = <Team>k__BackingField;
		int rogueStatus = this.rogueStatus;
		if (rogueStatus != 0)
		{
			if (rogueStatus != 0)
			{
				if (rogueStatus != 0)
				{
					if (rogueStatus != 1)
					{
						goto IL_00EC;
					}
					int damage2 = this._damage;
					bombCherry.damageToZombie = damage2;
					float num = bombCherry.range * 1.5f;
					bombCherry.range = num;
					bombCherry.maxRow = (int)((ulong)2L);
				}
				int damage3 = this._damage;
				bombCherry.damageToZombie = damage3;
				float num2 = bombCherry.range * 0.5f;
				bombCherry.range = num2;
				bombCherry.maxRow = (int)((ulong)1L);
			}
			int num3 = this._damage;
			num3 += num3;
		}
		int damage4 = this._damage;
		bombCherry.damageToZombie = damage4;
		IL_00EC:
		if (zombie.theStatus == ZombieStatus.Flying)
		{
			bombCherry.bombType = (CherryBombType)((ulong)5L);
		}
		bombCherry.Explode(this);
		base.Die();
		bool flag;
		if (flag && flag < true)
		{
			BoardAction boardAction2 = this.board.boardAction;
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x00027658 File Offset: 0x00025858
	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x7E6C10", Offset = "0x7E5210", VA = "0x1807E6C10", Slot = "18")]
	public override void HitLand()
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		BombCherry bombCherry;
		bombCherry.team = <Team>k__BackingField;
		bombCherry.Explode(this);
		base.Die();
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x000276B0 File Offset: 0x000258B0
	[Token(Token = "0x60007AB")]
	[Address(RVA = "0x7E6CE0", Offset = "0x7E52E0", VA = "0x1807E6CE0", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		BoardAction boardAction = this.board.boardAction;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Team <Team>k__BackingField = this.<Team>k__BackingField;
		BombCherry bombCherry;
		bombCherry.team = <Team>k__BackingField;
		bombCherry.targetPlant = plant;
		bombCherry.Explode(this);
		base.Die();
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0002771C File Offset: 0x0002591C
	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_superCherry()
	{
	}
}
