using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000521 RID: 1313
[Token(Token = "0x2000521")]
public class JalaSplit : SplitPea
{
	// Token: 0x0600186A RID: 6250 RVA: 0x00084CAC File Offset: 0x00082EAC
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x00084CCC File Offset: 0x00082ECC
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x4CFEC0", Offset = "0x4CE4C0", VA = "0x1804CFEC0", Slot = "69")]
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

	// Token: 0x0600186C RID: 6252 RVA: 0x00084D3C File Offset: 0x00082F3C
	[Token(Token = "0x600186C")]
	[Address(RVA = "0x4D00B0", Offset = "0x4CE6B0", VA = "0x1804D00B0", Slot = "70")]
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

	// Token: 0x0600186D RID: 6253 RVA: 0x00084D84 File Offset: 0x00082F84
	[Token(Token = "0x600186D")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public JalaSplit()
	{
	}
}
