using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001BE RID: 446
[Token(Token = "0x20001BE")]
public class Bullet_steelPea : Bullet
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00026800 File Offset: 0x00024A00
	[Token(Token = "0x170000A7")]
	public override ParticleType ParticleType
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x813860", Offset = "0x811E60", VA = "0x180813860", Slot = "7")]
		get
		{
			return ParticleType.SteelPeaSplat;
		}
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00026810 File Offset: 0x00024A10
	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x813340", Offset = "0x811940", VA = "0x180813340", Slot = "22")]
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
			func = (Zombie z) => !z.Alive;
			Bullet_steelPea.<>c.<>9__2_1 = func;
		}
		global::Core.Lawnf.Bounce<Zombie>(list, shootingLevel, action, func);
		num++;
		base.Die();
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x00026914 File Offset: 0x00024B14
	[Token(Token = "0x60007A3")]
	[Address(RVA = "0x813210", Offset = "0x811810", VA = "0x180813210", Slot = "17")]
	public override void HitLand()
	{
		ParticleManager instance = ParticleManager.Instance;
		ParticleType particleType = this.ParticleType;
		Transform transform = base.transform;
		base.Die();
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00026948 File Offset: 0x00024B48
	[Token(Token = "0x60007A4")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_steelPea()
	{
	}
}
