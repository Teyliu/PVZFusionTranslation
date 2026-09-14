using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000540 RID: 1344
[Token(Token = "0x2000540")]
public class NutShooter : Shooter
{
	// Token: 0x060018FF RID: 6399 RVA: 0x000874AC File Offset: 0x000856AC
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x4D7510", Offset = "0x4D5B10", VA = "0x1804D7510", Slot = "69")]
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

	// Token: 0x06001900 RID: 6400 RVA: 0x00087504 File Offset: 0x00085704
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x4D7250", Offset = "0x4D5850", VA = "0x1804D7250", Slot = "29")]
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

	// Token: 0x06001901 RID: 6401 RVA: 0x00087604 File Offset: 0x00085804
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001902 RID: 6402 RVA: 0x00087614 File Offset: 0x00085814
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public NutShooter()
	{
	}
}
