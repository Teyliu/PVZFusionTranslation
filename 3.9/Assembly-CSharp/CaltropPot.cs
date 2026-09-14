using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036C RID: 876
[Token(Token = "0x200036C")]
public class CaltropPot : Pot
{
	// Token: 0x06001005 RID: 4101 RVA: 0x0005BE74 File Offset: 0x0005A074
	[Token(Token = "0x6001005")]
	[Address(RVA = "0x476FE0", Offset = "0x4755E0", VA = "0x180476FE0", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__0_ = CaltropPot.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			CaltropPot.<>c.<>9__0_0 = (Plant p) => p.thePlantType == PlantType.ObsidianWallNut;
		}
		if (!Enumerable.FirstOrDefault<Plant>(list, <>9__0_))
		{
			base.Crashed(level, soundID, zombie);
		}
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0005BED0 File Offset: 0x0005A0D0
	[Token(Token = "0x6001006")]
	[Address(RVA = "0x4777B0", Offset = "0x475DB0", VA = "0x1804777B0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			int num = 0;
			if (thePlantAttackCountDown > (float)num)
			{
				base.UpdateAttackCountDown();
				this.ReadyToAttack();
				float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
				this.thePlantAttackCountDown = num2;
			}
		}
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x0005BF1C File Offset: 0x0005A11C
	[Token(Token = "0x6001007")]
	[Address(RVA = "0x4775E0", Offset = "0x475BE0", VA = "0x1804775E0", Slot = "68")]
	protected virtual void ReadyToAttack()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && base.SearchUniqueZombie(num))
			{
				int thePlantRow = this.thePlantRow;
				this.anim.SetTrigger("attack");
			}
			num++;
		}
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x0005BF7C File Offset: 0x0005A17C
	[Token(Token = "0x6001008")]
	[Address(RVA = "0x4774F0", Offset = "0x475AF0", VA = "0x1804774F0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				this.anim.SetTrigger("attack");
			}
		}
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
	[Token(Token = "0x6001009")]
	[Address(RVA = "0x477180", Offset = "0x475780", VA = "0x180477180")]
	private void KillCar()
	{
		int thePlantRow = this.thePlantRow;
		int num = 0;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__4_ = CaltropPot.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			CaltropPot.<>c.<>9__4_0 = (Plant p) => p.thePlantType == PlantType.ObsidianWallNut;
		}
		bool flag = Enumerable.FirstOrDefault<Plant>(list, <>9__4_);
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag2;
			if (flag2)
			{
				int thePlantRow2 = this.thePlantRow;
				bool flag3;
				if (flag3)
				{
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, 1f);
					if (!flag)
					{
						int num4 = 0;
						base.Die((Plant.DieReason)num4);
					}
				}
			}
			num++;
		}
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0005C060 File Offset: 0x0005A260
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x476D90", Offset = "0x475390", VA = "0x180476D90")]
	private void AnimAttack()
	{
		int num = 0;
		this.KillCar();
		Transform axis = this.axis;
		int num2 = this.zombieLayer;
		int num3 = 0;
		Collider2D[] array;
		bool flag;
		if (num < array.Length)
		{
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		if (num3 != 0)
		{
			GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
		}
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0005C0D8 File Offset: 0x0005A2D8
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CaltropPot()
	{
	}
}
