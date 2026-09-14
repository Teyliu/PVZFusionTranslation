using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C8 RID: 1480
[Token(Token = "0x20005C8")]
public class WaterBallista : SpruceBallista
{
	// Token: 0x06001B9F RID: 7071 RVA: 0x00093E58 File Offset: 0x00092058
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x5196A0", Offset = "0x517CA0", VA = "0x1805196A0", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float fillingTimer = this.FillingTimer;
		float deltaTime = Time.deltaTime;
		this.FillingTimer = fillingTimer;
		this.FillingTimer = 3f;
		this.magazine = (int)((ulong)4L);
	}

	// Token: 0x06001BA0 RID: 7072 RVA: 0x00093EE8 File Offset: 0x000920E8
	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x5197E0", Offset = "0x517DE0", VA = "0x1805197E0", Slot = "69")]
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

	// Token: 0x06001BA1 RID: 7073 RVA: 0x00093F44 File Offset: 0x00092144
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x519940", Offset = "0x517F40", VA = "0x180519940", Slot = "70")]
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

	// Token: 0x06001BA2 RID: 7074 RVA: 0x00093FA0 File Offset: 0x000921A0
	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public WaterBallista()
	{
	}

	// Token: 0x04000EE8 RID: 3816
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EE8")]
	private int magazine;

	// Token: 0x04000EE9 RID: 3817
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000EE9")]
	private float FillingTimer;
}
