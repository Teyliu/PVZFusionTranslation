using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005FD RID: 1533
[Token(Token = "0x20005FD")]
public class WaterBallista : SpruceBallista
{
	// Token: 0x06001C9E RID: 7326 RVA: 0x00098A4C File Offset: 0x00096C4C
	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x56EFF0", Offset = "0x56D5F0", VA = "0x18056EFF0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float fillingTimer = this.FillingTimer;
		float deltaTime = Time.deltaTime;
		this.FillingTimer = fillingTimer;
		this.FillingTimer = 3f;
		this.magazine = (int)((ulong)4L);
	}

	// Token: 0x06001C9F RID: 7327 RVA: 0x00098ADC File Offset: 0x00096CDC
	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x56F130", Offset = "0x56D730", VA = "0x18056F130", Slot = "68")]
	protected override Bullet Shoot1()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.normalSpeed = 12f;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001CA0 RID: 7328 RVA: 0x00098B38 File Offset: 0x00096D38
	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x56F290", Offset = "0x56D890", VA = "0x18056F290", Slot = "69")]
	protected override Bullet Shoot2()
	{
		CreateBullet instance = CreateBullet.Instance;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot;
		Bullet bullet;
		bullet.normalSpeed = 12f;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00098B94 File Offset: 0x00096D94
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public WaterBallista()
	{
	}

	// Token: 0x04000FB0 RID: 4016
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000FB0")]
	private int magazine;

	// Token: 0x04000FB1 RID: 4017
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000FB1")]
	private float FillingTimer;
}
