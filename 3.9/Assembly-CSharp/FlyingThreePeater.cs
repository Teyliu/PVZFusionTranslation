using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000519 RID: 1305
[Token(Token = "0x2000519")]
public class FlyingThreePeater : ThreePeater
{
	// Token: 0x06001870 RID: 6256 RVA: 0x00084A70 File Offset: 0x00082C70
	[Token(Token = "0x6001870")]
	[Address(RVA = "0x523EB0", Offset = "0x5224B0", VA = "0x180523EB0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		int rowNum = this.board.rowNum;
		base.Invoke("ExtraBullet", 0.2f);
		return bullet;
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00084AE8 File Offset: 0x00082CE8
	[Token(Token = "0x6001871")]
	[Address(RVA = "0x5241D0", Offset = "0x5227D0", VA = "0x1805241D0")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00084B2C File Offset: 0x00082D2C
	[Token(Token = "0x6001872")]
	[Address(RVA = "0x5240F0", Offset = "0x5226F0", VA = "0x1805240F0")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x00084B70 File Offset: 0x00082D70
	[Token(Token = "0x6001873")]
	[Address(RVA = "0x523D90", Offset = "0x522390", VA = "0x180523D90")]
	private void ExtraBullet()
	{
		Transform transform = this.shoot.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x00084BC4 File Offset: 0x00082DC4
	[Token(Token = "0x6001874")]
	[Address(RVA = "0x523EA0", Offset = "0x5224A0", VA = "0x180523EA0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_firePea_super;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x00084BD4 File Offset: 0x00082DD4
	[Token(Token = "0x6001875")]
	[Address(RVA = "0x523CF0", Offset = "0x5222F0", VA = "0x180523CF0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int i = this.thePlantRow;
		int num = this.thePlantRow;
		num++;
		int num2 = 0;
		Board board = this.board;
		if (i < board.rowNum)
		{
			BoardAction boardAction = board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int num3 = 0;
			ulong num4;
			boardAction.CreateFireLine(i, 1800, num3 != 0, num2 != 0, num4 != 0UL, num2, thePlantType);
		}
		int num5 = this.thePlantRow;
		i++;
		num5++;
		while (i <= num5)
		{
		}
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00084C4C File Offset: 0x00082E4C
	[Token(Token = "0x6001876")]
	[Address(RVA = "0x523C90", Offset = "0x522290", VA = "0x180523C90", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform shoot = this.shoot;
			return;
		}
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x00084C6C File Offset: 0x00082E6C
	[Token(Token = "0x6001877")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public FlyingThreePeater()
	{
	}
}
