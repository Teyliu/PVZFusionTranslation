using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D3 RID: 1235
[Token(Token = "0x20004D3")]
public class CherrySplit : SplitPea
{
	// Token: 0x06001745 RID: 5957 RVA: 0x0007FE40 File Offset: 0x0007E040
	[Token(Token = "0x6001745")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x0007FE60 File Offset: 0x0007E060
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x49F370", Offset = "0x49D970", VA = "0x18049F370", Slot = "69")]
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

	// Token: 0x06001747 RID: 5959 RVA: 0x0007FEF8 File Offset: 0x0007E0F8
	[Token(Token = "0x6001747")]
	[Address(RVA = "0x49F5C0", Offset = "0x49DBC0", VA = "0x18049F5C0", Slot = "70")]
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

	// Token: 0x06001748 RID: 5960 RVA: 0x0007FF50 File Offset: 0x0007E150
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public CherrySplit()
	{
	}
}
