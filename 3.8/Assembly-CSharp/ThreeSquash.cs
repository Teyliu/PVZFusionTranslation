using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000592 RID: 1426
[Token(Token = "0x2000592")]
public class ThreeSquash : ThreePeater
{
	// Token: 0x06001A61 RID: 6753 RVA: 0x0008DE84 File Offset: 0x0008C084
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x4F1400", Offset = "0x4EFA00", VA = "0x1804F1400", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("headPos2").Find("Shoot").transform;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (!Lawnf.EveBalaced())
		{
			int rowNum = this.board.rowNum;
			return bullet;
		}
		CreateBullet instance2 = CreateBullet.Instance;
		CreateBullet instance3 = CreateBullet.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x0008DF24 File Offset: 0x0008C124
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x4F17F0", Offset = "0x4EFDF0", VA = "0x1804F17F0")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0008DF60 File Offset: 0x0008C160
	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x4F1730", Offset = "0x4EFD30", VA = "0x1804F1730")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0008DF9C File Offset: 0x0008C19C
	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x4F12B0", Offset = "0x4EF8B0", VA = "0x1804F12B0")]
	private void ExtraBullet()
	{
		Transform transform = base.transform.Find("headPos2").Find("Shoot").transform;
		CreateBullet component = this.board.GetComponent<CreateBullet>();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x0008E000 File Offset: 0x0008C200
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ThreeSquash()
	{
	}
}
