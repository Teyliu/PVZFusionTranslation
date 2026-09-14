using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000381 RID: 897
[Token(Token = "0x2000381")]
public class CornUmbrella : Umbrellaleaf
{
	// Token: 0x0600107B RID: 4219 RVA: 0x0005E144 File Offset: 0x0005C344
	[Token(Token = "0x600107B")]
	[Address(RVA = "0x47EFE0", Offset = "0x47D5E0", VA = "0x18047EFE0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim != 0)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (flag2 && !flag3)
				{
					this.anim.SetTrigger("block");
					base.AttributeCountdown = 1f;
					GameAPP.PlaySound(106, 0.5f, 1f);
					base.FlashOnce();
					this.BlockZombies();
				}
			}
		}
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x0005E1BC File Offset: 0x0005C3BC
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x47EB70", Offset = "0x47D170", VA = "0x18047EB70", Slot = "70")]
	protected virtual void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		if (!(umbrellaPot == num2))
		{
			zombie.Buttered(4f, true);
		}
		zombie.Buttered((float)num2, true);
		throw new NullReferenceException();
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0005E20C File Offset: 0x0005C40C
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x47EF80", Offset = "0x47D580", VA = "0x18047EF80", Slot = "71")]
	protected virtual void DamageHealth(int count)
	{
		if (count <= 0 || count == 1)
		{
		}
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x0005E224 File Offset: 0x0005C424
	[Token(Token = "0x600107E")]
	[Address(RVA = "0x47ECA0", Offset = "0x47D2A0", VA = "0x18047ECA0", Slot = "72")]
	protected virtual void BlockZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				if (base.SearchUniqueZombie(num) && !flag2)
				{
					this.BlockEffect(num);
					num++;
					bool flag3 = "{il2cpp field on CornUmbrella.BlockEffect, offset 0xFFFFFFFFFFFFFFF8}" == typeof(PogoZombie).TypeHandle;
				}
			}
			num++;
		}
		this.DamageHealth(num);
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0005E298 File Offset: 0x0005C498
	[Token(Token = "0x600107F")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public CornUmbrella()
	{
	}
}
