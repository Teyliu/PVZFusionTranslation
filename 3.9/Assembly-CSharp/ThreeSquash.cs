using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C3 RID: 1475
[Token(Token = "0x20005C3")]
public class ThreeSquash : ThreePeater
{
	// Token: 0x06001B47 RID: 6983 RVA: 0x00092230 File Offset: 0x00090430
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x54F9A0", Offset = "0x54DFA0", VA = "0x18054F9A0", Slot = "68")]
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

	// Token: 0x06001B48 RID: 6984 RVA: 0x000922D0 File Offset: 0x000904D0
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x54FD90", Offset = "0x54E390", VA = "0x18054FD90")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x0009230C File Offset: 0x0009050C
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x54FCD0", Offset = "0x54E2D0", VA = "0x18054FCD0")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00092348 File Offset: 0x00090548
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x54F850", Offset = "0x54DE50", VA = "0x18054F850")]
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

	// Token: 0x06001B4B RID: 6987 RVA: 0x000923AC File Offset: 0x000905AC
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ThreeSquash()
	{
	}
}
