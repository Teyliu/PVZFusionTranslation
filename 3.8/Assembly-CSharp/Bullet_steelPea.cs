using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001B5 RID: 437
[Token(Token = "0x20001B5")]
public class Bullet_steelPea : Bullet
{
	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600078F RID: 1935 RVA: 0x00026DC8 File Offset: 0x00024FC8
	[Token(Token = "0x1700006A")]
	public override ParticleType ParticleType
	{
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x7E5FE0", Offset = "0x7E45E0", VA = "0x1807E5FE0", Slot = "7")]
		get
		{
			return ParticleType.SteelPeaSplat;
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00026DD8 File Offset: 0x00024FD8
	[Token(Token = "0x6000790")]
	[Address(RVA = "0x7E5AC0", Offset = "0x7E40C0", VA = "0x1807E5AC0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Zombie zombie2 = zombie;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ParticleManager instance = ParticleManager.Instance;
		ParticleType particleType = this.ParticleType;
		Transform transform = base.transform;
		Zombie zombie3 = zombie;
		Zombie zombie4 = zombie;
		base.PlaySound(zombie4);
		int num = 0;
		List<Zombie> list = new List();
		Transform transform2 = base.transform;
		LayerMask zombieLayer = this.zombieLayer;
		int num2 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			bool flag2;
			if (!flag || flag2)
			{
			}
			num2++;
		}
		Action<Zombie> <>9__0;
		Action<Zombie> <>9__ = <>9__0;
		int shootingLevel = this.shootingLevel;
		Action<Zombie> action;
		if (<>9__ == 0)
		{
			<>9__0 = action;
		}
		Func<Zombie, bool> func;
		if (Bullet_steelPea.<>c.<>9__2_1 == 0)
		{
			Bullet_steelPea.<>c.<>9__2_1 = func;
		}
		global::Core.Lawnf.Bounce<Zombie>(list, shootingLevel, action, func);
		num++;
		base.Die();
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00026EC8 File Offset: 0x000250C8
	[Token(Token = "0x6000791")]
	[Address(RVA = "0x7E5990", Offset = "0x7E3F90", VA = "0x1807E5990", Slot = "18")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		ParticleType particleType = this.ParticleType;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00026EFC File Offset: 0x000250FC
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_steelPea()
	{
	}
}
