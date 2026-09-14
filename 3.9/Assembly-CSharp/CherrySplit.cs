using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FA RID: 1274
[Token(Token = "0x20004FA")]
public class CherrySplit : SplitPea
{
	// Token: 0x060017F8 RID: 6136 RVA: 0x00082FD8 File Offset: 0x000811D8
	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x00082FF8 File Offset: 0x000811F8
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x51EB40", Offset = "0x51D140", VA = "0x18051EB40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance2 = CreateBullet.Instance;
		int attackDamage2 = this.attackDamage;
		Bullet bullet2;
		bullet2.Damage = attackDamage2;
		PlantType thePlantType2 = this.thePlantType;
		bullet2.fromType = thePlantType2;
		return bullet;
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x00083090 File Offset: 0x00081290
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x51ED90", Offset = "0x51D390", VA = "0x18051ED90", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform child = base.transform.GetChild(1);
		int num = 0;
		Transform child2 = child.GetChild(num);
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x000830E8 File Offset: 0x000812E8
	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public CherrySplit()
	{
	}
}
