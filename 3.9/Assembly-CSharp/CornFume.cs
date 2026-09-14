using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000500 RID: 1280
[Token(Token = "0x2000500")]
public class CornFume : Plant
{
	// Token: 0x0600180C RID: 6156 RVA: 0x00083404 File Offset: 0x00081604
	[Token(Token = "0x600180C")]
	[Address(RVA = "0x51FD30", Offset = "0x51E330", VA = "0x18051FD30", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		List<Zombie> zombies = this.GetZombies();
		this.anim.SetTrigger("shoot");
		return true;
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00083434 File Offset: 0x00081634
	[Token(Token = "0x600180D")]
	[Address(RVA = "0x51F7D0", Offset = "0x51DDD0", VA = "0x18051F7D0", Slot = "68")]
	protected virtual void AnimShoot()
	{
		int num;
		do
		{
			List<Zombie> zombies = this.GetZombies();
			num = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot = this.shoot;
				Transform shoot2 = this.shoot;
				int attackDamage = this.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
				Transform shoot3 = this.shoot;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
			}
		}
		while (num != 0);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x000834D8 File Offset: 0x000816D8
	[Token(Token = "0x600180E")]
	[Address(RVA = "0x51FDB0", Offset = "0x51E3B0", VA = "0x18051FDB0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = 0;
		bool flag = this.OnClicked(num);
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x000834F0 File Offset: 0x000816F0
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x51FB50", Offset = "0x51E150", VA = "0x18051FB50", Slot = "69")]
	protected virtual List<Zombie> GetZombies()
	{
		int num = 0;
		List<Zombie> list = new List();
		Transform shoot = this.shoot;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num++;
		}
		return list;
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00083548 File Offset: 0x00081748
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CornFume()
	{
	}
}
