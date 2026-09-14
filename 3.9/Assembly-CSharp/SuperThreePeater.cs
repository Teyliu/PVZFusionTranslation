using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005B6 RID: 1462
[Token(Token = "0x20005B6")]
public class SuperThreePeater : ThreePeater
{
	// Token: 0x06001B04 RID: 6916 RVA: 0x00090C10 File Offset: 0x0008EE10
	[Token(Token = "0x6001B04")]
	[Address(RVA = "0x523EA0", Offset = "0x5224A0", VA = "0x180523EA0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_super;
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x00090C20 File Offset: 0x0008EE20
	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x54B9F0", Offset = "0x549FF0", VA = "0x18054B9F0", Slot = "51")]
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

	// Token: 0x06001B06 RID: 6918 RVA: 0x00090C78 File Offset: 0x0008EE78
	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x54BA90", Offset = "0x54A090", VA = "0x18054BA90", Slot = "68")]
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

	// Token: 0x06001B07 RID: 6919 RVA: 0x00090D04 File Offset: 0x0008EF04
	[Token(Token = "0x6001B07")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SuperThreePeater()
	{
	}
}
