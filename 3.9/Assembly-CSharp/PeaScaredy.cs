using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000571 RID: 1393
[Token(Token = "0x2000571")]
public class PeaScaredy : ScaredyShroom
{
	// Token: 0x060019E3 RID: 6627 RVA: 0x0008B750 File Offset: 0x00089950
	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x538E40", Offset = "0x537440", VA = "0x180538E40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int num = 0;
		base.AddSpeed((PlantSpeedAdder)((uint)4), 0.05f, num);
		float attackSpeedAdder = this.attackSpeedAdder;
		int num2 = 0;
		base.ModifyDamage((PlantDamageAdder)((uint)54), attackSpeedAdder, num2 != 0, num);
		this.anim.SetFloat("ShootSpeed", 1f);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0008B7D4 File Offset: 0x000899D4
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x538E30", Offset = "0x537430", VA = "0x180538E30", Slot = "73")]
	protected override void ScaredEvent()
	{
		int num = 0;
		base.ModifySpeed((PlantSpeedAdder)((uint)4), (float)num);
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0008B7EC File Offset: 0x000899EC
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x0008B7FC File Offset: 0x000899FC
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaScaredy()
	{
	}
}
