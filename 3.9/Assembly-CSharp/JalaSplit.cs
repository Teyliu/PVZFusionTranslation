using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054E RID: 1358
[Token(Token = "0x200054E")]
public class JalaSplit : SplitPea
{
	// Token: 0x06001939 RID: 6457 RVA: 0x00088840 File Offset: 0x00086A40
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x00088860 File Offset: 0x00086A60
	[Token(Token = "0x600193A")]
	[Address(RVA = "0x52C7F0", Offset = "0x52ADF0", VA = "0x18052C7F0", Slot = "68")]
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

	// Token: 0x0600193B RID: 6459 RVA: 0x000888D0 File Offset: 0x00086AD0
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x52C9E0", Offset = "0x52AFE0", VA = "0x18052C9E0", Slot = "69")]
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

	// Token: 0x0600193C RID: 6460 RVA: 0x00088918 File Offset: 0x00086B18
	[Token(Token = "0x600193C")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public JalaSplit()
	{
	}
}
