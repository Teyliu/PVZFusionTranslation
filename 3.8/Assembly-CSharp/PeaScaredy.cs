using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000543 RID: 1347
[Token(Token = "0x2000543")]
public class PeaScaredy : ScaredyShroom
{
	// Token: 0x0600190E RID: 6414 RVA: 0x000879A8 File Offset: 0x00085BA8
	[Token(Token = "0x600190E")]
	[Address(RVA = "0x4DB6C0", Offset = "0x4D9CC0", VA = "0x1804DB6C0", Slot = "69")]
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

	// Token: 0x0600190F RID: 6415 RVA: 0x00087A2C File Offset: 0x00085C2C
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x4DB6B0", Offset = "0x4D9CB0", VA = "0x1804DB6B0", Slot = "74")]
	protected override void ScaredEvent()
	{
		int num = 0;
		base.ModifySpeed((PlantSpeedAdder)((uint)4), (float)num);
	}

	// Token: 0x06001910 RID: 6416 RVA: 0x00087A44 File Offset: 0x00085C44
	[Token(Token = "0x6001910")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06001911 RID: 6417 RVA: 0x00087A54 File Offset: 0x00085C54
	[Token(Token = "0x6001911")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public PeaScaredy()
	{
	}
}
