using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000532 RID: 1330
[Token(Token = "0x2000532")]
public class HypnoCattailGirl_land : HypnoCattailGirl
{
	// Token: 0x060018D7 RID: 6359 RVA: 0x00086814 File Offset: 0x00084A14
	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x527CD0", Offset = "0x5262D0", VA = "0x180527CD0", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
		}
	}

	// Token: 0x060018D8 RID: 6360 RVA: 0x0008683C File Offset: 0x00084A3C
	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x527DB0", Offset = "0x5263B0", VA = "0x180527DB0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x060018D9 RID: 6361 RVA: 0x00086884 File Offset: 0x00084A84
	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x527EE0", Offset = "0x5264E0", VA = "0x180527EE0", Slot = "69")]
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

	// Token: 0x060018DA RID: 6362 RVA: 0x000868CC File Offset: 0x00084ACC
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public HypnoCattailGirl_land()
	{
	}
}
