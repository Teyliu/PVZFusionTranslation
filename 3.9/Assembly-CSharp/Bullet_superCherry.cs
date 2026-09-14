using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C6 RID: 454
[Token(Token = "0x20001C6")]
public class Bullet_superCherry : Bullet
{
	// Token: 0x060007BB RID: 1979 RVA: 0x00026F90 File Offset: 0x00025190
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x8146A0", Offset = "0x812CA0", VA = "0x1808146A0", Slot = "22")]
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

	// Token: 0x060007BC RID: 1980 RVA: 0x000270CC File Offset: 0x000252CC
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x8144A0", Offset = "0x812AA0", VA = "0x1808144A0", Slot = "17")]
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

	// Token: 0x060007BD RID: 1981 RVA: 0x00027124 File Offset: 0x00025324
	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x814570", Offset = "0x812B70", VA = "0x180814570", Slot = "21")]
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

	// Token: 0x060007BE RID: 1982 RVA: 0x00027190 File Offset: 0x00025390
	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_superCherry()
	{
	}
}
