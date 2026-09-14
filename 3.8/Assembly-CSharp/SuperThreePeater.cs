using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000585 RID: 1413
[Token(Token = "0x2000585")]
public class SuperThreePeater : ThreePeater
{
	// Token: 0x06001A1E RID: 6686 RVA: 0x0008C888 File Offset: 0x0008AA88
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x4C8540", Offset = "0x4C6B40", VA = "0x1804C8540", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_super;
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x0008C898 File Offset: 0x0008AA98
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x4EBB80", Offset = "0x4EA180", VA = "0x1804EBB80", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoardAction boardAction = board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int num2 = 0;
			ulong num3;
			boardAction.CreateFireLine(num, 1800, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x4EBC20", Offset = "0x4EA220", VA = "0x1804EBC20", Slot = "69")]
	protected override Bullet Shoot1()
	{
		if (!Lawnf.TravelAdvanced((AdvBuff)((uint)12008)))
		{
			return base.Shoot1();
		}
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			BulletType bulletType = this.GetBulletType();
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			num++;
			bullet.fromType = thePlantType;
			Board board2 = this.board;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0008C97C File Offset: 0x0008AB7C
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public SuperThreePeater()
	{
	}
}
