using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200043E RID: 1086
[Token(Token = "0x200043E")]
public class SuperCaltrop : Caltrop
{
	// Token: 0x06001407 RID: 5127 RVA: 0x00070088 File Offset: 0x0006E288
	[Token(Token = "0x6001407")]
	[Address(RVA = "0x471210", Offset = "0x46F810", VA = "0x180471210", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		int num2 = 0;
		bool flag;
		if (flag)
		{
		}
		Transform axis = this.axis;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		bool flag2;
		if (num < array.Length)
		{
			if (flag2)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.thePlantType;
					int num4 = this.attributeCount;
					num4++;
					this.attributeCount = num4;
					this.attributeCount = num;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			GameAPP.PlaySound(flag2 ? 1 : 0, 0.5f, 1f);
		}
	}

	// Token: 0x06001408 RID: 5128 RVA: 0x0007011C File Offset: 0x0006E31C
	[Token(Token = "0x6001408")]
	[Address(RVA = "0x471560", Offset = "0x46FB60", VA = "0x180471560")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)33));
		bool flag2;
		if (flag && flag2)
		{
			int thePlantRow = this.thePlantRow;
			bool flag3;
			if (flag3)
			{
				ulong num;
				if (num > (ulong)63L)
				{
					if (num == (ulong)231L || num == (ulong)260L)
					{
						return;
					}
				}
				else
				{
					while (flag <= true)
					{
					}
					while ((ulong)((uint)33) == (ulong)63L)
					{
					}
				}
				float num2 = Time.fixedDeltaTime * 0.3f;
				return;
			}
		}
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00070188 File Offset: 0x0006E388
	[Token(Token = "0x6001409")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600140A RID: 5130 RVA: 0x00070198 File Offset: 0x0006E398
	[Token(Token = "0x600140A")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x000701A8 File Offset: 0x0006E3A8
	[Token(Token = "0x600140B")]
	[Address(RVA = "0x471520", Offset = "0x46FB20", VA = "0x180471520", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		base.FlashOnce();
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x000701BC File Offset: 0x0006E3BC
	[Token(Token = "0x600140C")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public SuperCaltrop()
	{
	}
}
