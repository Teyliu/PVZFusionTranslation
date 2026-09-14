using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000507 RID: 1287
[Token(Token = "0x2000507")]
public class HypnoCattailGirl_land : HypnoCattailGirl
{
	// Token: 0x0600180E RID: 6158 RVA: 0x00082FD4 File Offset: 0x000811D4
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x4CB9B0", Offset = "0x4C9FB0", VA = "0x1804CB9B0", Slot = "53")]
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

	// Token: 0x0600180F RID: 6159 RVA: 0x00082FFC File Offset: 0x000811FC
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x4CBA90", Offset = "0x4CA090", VA = "0x1804CBA90", Slot = "69")]
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

	// Token: 0x06001810 RID: 6160 RVA: 0x00083044 File Offset: 0x00081244
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x4CBBC0", Offset = "0x4CA1C0", VA = "0x1804CBBC0", Slot = "70")]
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

	// Token: 0x06001811 RID: 6161 RVA: 0x0008308C File Offset: 0x0008128C
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public HypnoCattailGirl_land()
	{
	}
}
