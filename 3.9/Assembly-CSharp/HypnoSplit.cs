using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000535 RID: 1333
[Token(Token = "0x2000535")]
public class HypnoSplit : SplitPea
{
	// Token: 0x060018E1 RID: 6369 RVA: 0x00086974 File Offset: 0x00084B74
	[Token(Token = "0x60018E1")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x00086994 File Offset: 0x00084B94
	[Token(Token = "0x60018E2")]
	[Address(RVA = "0x528030", Offset = "0x526630", VA = "0x180528030", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		Transform shoot2 = this.shoot;
		CreateBullet instance2 = CreateBullet.Instance;
		Transform shoot3 = this.shoot;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		return bullet;
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x00086A04 File Offset: 0x00084C04
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x528220", Offset = "0x526820", VA = "0x180528220", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060018E4 RID: 6372 RVA: 0x00086A4C File Offset: 0x00084C4C
	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public HypnoSplit()
	{
	}
}
