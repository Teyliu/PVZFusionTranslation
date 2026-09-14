using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035C RID: 860
[Token(Token = "0x200035C")]
public class CaltropPot : Pot
{
	// Token: 0x06000FB9 RID: 4025 RVA: 0x0005AED4 File Offset: 0x000590D4
	[Token(Token = "0x6000FB9")]
	[Address(RVA = "0x420090", Offset = "0x41E690", VA = "0x180420090", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__0_ = CaltropPot.<>c.<>9__0_0;
		if (<>9__0_ == 0)
		{
			Func<Plant, bool> func;
			CaltropPot.<>c.<>9__0_0 = func;
		}
		if (!Enumerable.FirstOrDefault<Plant>(list, <>9__0_))
		{
			base.Crashed(level, soundID, zombie);
		}
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0005AF20 File Offset: 0x00059120
	[Token(Token = "0x6000FBA")]
	[Address(RVA = "0x420860", Offset = "0x41EE60", VA = "0x180420860", Slot = "16")]
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

	// Token: 0x06000FBB RID: 4027 RVA: 0x0005AF6C File Offset: 0x0005916C
	[Token(Token = "0x6000FBB")]
	[Address(RVA = "0x420690", Offset = "0x41EC90", VA = "0x180420690", Slot = "69")]
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

	// Token: 0x06000FBC RID: 4028 RVA: 0x0005AFCC File Offset: 0x000591CC
	[Token(Token = "0x6000FBC")]
	[Address(RVA = "0x4205A0", Offset = "0x41EBA0", VA = "0x1804205A0")]
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

	// Token: 0x06000FBD RID: 4029 RVA: 0x0005B000 File Offset: 0x00059200
	[Token(Token = "0x6000FBD")]
	[Address(RVA = "0x420230", Offset = "0x41E830", VA = "0x180420230")]
	private void KillCar()
	{
		int thePlantRow = this.thePlantRow;
		int num = 0;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__4_ = CaltropPot.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			Func<Plant, bool> func;
			CaltropPot.<>c.<>9__4_0 = func;
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

	// Token: 0x06000FBE RID: 4030 RVA: 0x0005B0A0 File Offset: 0x000592A0
	[Token(Token = "0x6000FBE")]
	[Address(RVA = "0x41FE40", Offset = "0x41E440", VA = "0x18041FE40")]
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

	// Token: 0x06000FBF RID: 4031 RVA: 0x0005B118 File Offset: 0x00059318
	[Token(Token = "0x6000FBF")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public CaltropPot()
	{
	}
}
