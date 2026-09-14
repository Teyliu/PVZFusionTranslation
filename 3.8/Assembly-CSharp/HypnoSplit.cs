using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050A RID: 1290
[Token(Token = "0x200050A")]
public class HypnoSplit : SplitPea
{
	// Token: 0x06001818 RID: 6168 RVA: 0x00083134 File Offset: 0x00081334
	[Token(Token = "0x6001818")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x00083154 File Offset: 0x00081354
	[Token(Token = "0x6001819")]
	[Address(RVA = "0x4CBD10", Offset = "0x4CA310", VA = "0x1804CBD10", Slot = "69")]
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

	// Token: 0x0600181A RID: 6170 RVA: 0x000831C4 File Offset: 0x000813C4
	[Token(Token = "0x600181A")]
	[Address(RVA = "0x4CBF00", Offset = "0x4CA500", VA = "0x1804CBF00", Slot = "70")]
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

	// Token: 0x0600181B RID: 6171 RVA: 0x0008320C File Offset: 0x0008140C
	[Token(Token = "0x600181B")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public HypnoSplit()
	{
	}
}
