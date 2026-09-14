using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058B RID: 1419
[Token(Token = "0x200058B")]
public class SniperScaredy : SniperPea
{
	// Token: 0x06001A61 RID: 6753 RVA: 0x0008DBC8 File Offset: 0x0008BDC8
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x540630", Offset = "0x53EC30", VA = "0x180540630", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie == num)
		{
			GameObject gameObject = base.SearchZombie();
		}
		if (base.PumpkinType != PlantType.ScaredyPumpkin)
		{
			this.GetNearZombies();
			return;
		}
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x0008DC10 File Offset: 0x0008BE10
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x540950", Offset = "0x53EF50", VA = "0x180540950", Slot = "68")]
	protected override Bullet Shoot1()
	{
		if (this.thePlantAttackInterval > 0.5f)
		{
		}
		this.thePlantAttackInterval = 0.5f;
		return base.Shoot1();
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0008DC3C File Offset: 0x0008BE3C
	[Token(Token = "0x6001A63")]
	[Address(RVA = "0x540750", Offset = "0x53ED50", VA = "0x180540750")]
	protected void GetNearZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		Transform axis2 = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || flag > true)
			{
			}
			num++;
			ulong num3;
			this.anim.SetBool("NearZombie", num3 != 0UL);
			return;
		}
		Animator anim = this.anim;
		int num4 = 0;
		anim.SetBool("NearZombie", num4 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0008DCB0 File Offset: 0x0008BEB0
	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SniperScaredy()
	{
	}
}
