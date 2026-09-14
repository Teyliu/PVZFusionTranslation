using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200056E RID: 1390
[Token(Token = "0x200056E")]
public class NutShooter : Shooter
{
	// Token: 0x060019D3 RID: 6611 RVA: 0x0008B244 File Offset: 0x00089444
	[Token(Token = "0x60019D3")]
	[Address(RVA = "0x538060", Offset = "0x536660", VA = "0x180538060", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x0008B29C File Offset: 0x0008949C
	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x537DA0", Offset = "0x5363A0", VA = "0x180537DA0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		uint num2;
		GameObject gameObject = base.transform.GetChild((int)num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		uint num4;
		ulong num5;
		base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x0008B39C File Offset: 0x0008959C
	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0008B3AC File Offset: 0x000895AC
	[Token(Token = "0x60019D6")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public NutShooter()
	{
	}
}
