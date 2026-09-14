using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000699 RID: 1689
[Token(Token = "0x2000699")]
public class LegionSniperZombie : Zombie
{
	// Token: 0x060020B6 RID: 8374 RVA: 0x000AD0D0 File Offset: 0x000AB2D0
	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000AD0F0 File Offset: 0x000AB2F0
	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000AD100 File Offset: 0x000AB300
	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000AD110 File Offset: 0x000AB310
	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x55BED0", Offset = "0x55A4D0", VA = "0x18055BED0")]
	private void AnimShoot()
	{
		int num;
		do
		{
			num = 0;
			uint num2;
			GameAPP.PlaySound((int)num2, 0.3f, 1f);
			int theZombieRow = this.theZombieRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(this.board, theZombieRow);
			Func<Plant, bool> <>9__4_ = LegionSniperZombie.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Func<Plant, bool> func;
				LegionSniperZombie.<>c.<>9__4_0 = func;
			}
			if (Enumerable.OrderBy<Plant, bool>(plantsByRow, <>9__4_) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_005F;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_005F;
				}
				goto IL_00AD;
				IL_00B4:
				this.attributeCount = num;
				int num3 = 0;
				Plant plant;
				if (!(plant != num3))
				{
				}
				plant.thePlantHealth = num;
				plant.FlashOnce();
				goto IL_00D9;
				IL_00AD:
				int num4;
				num4 += num4;
				goto IL_00B4;
				IL_005F:
				int column = base.Column;
				while (plantsByRow >= column)
				{
				}
				ParticleManager instance = ParticleManager.Instance;
				int num5 = this.attributeCount;
				num5++;
				this.attributeCount = num5;
				if (num5 != 6)
				{
					int num6 = 0;
					if (!(plant != num6))
					{
					}
					plant.FlashOnce();
					num4 = 0;
					goto IL_00AD;
				}
				goto IL_00B4;
			}
			IL_00D9:
			if ("{il2cpp array field local14->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000AD234 File Offset: 0x000AB434
	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x55C520", Offset = "0x55AB20", VA = "0x18055C520", Slot = "22")]
	protected override void OnFixedUpdate()
	{
		ulong num;
		do
		{
			base.OnFixedUpdate();
			Transform axis = this.axis;
			Board board = this.board;
			float boardMaxX = board.boardMaxX;
			int theZombieRow = this.theZombieRow;
			List<Plant> plantsByRow = Lawnf.GetPlantsByRow(board, theZombieRow);
			bool flag;
			if (flag)
			{
				int column = base.Column;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000AD2C0 File Offset: 0x000AB4C0
	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x55C4B0", Offset = "0x55AAB0", VA = "0x18055C4B0", Slot = "24")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("shooting", num != 0);
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000AD2F8 File Offset: 0x000AB4F8
	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x51A5B0", Offset = "0x518BB0", VA = "0x18051A5B0", Slot = "61")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000AD308 File Offset: 0x000AB508
	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000AD344 File Offset: 0x000AB544
	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x55C770", Offset = "0x55AD70", VA = "0x18055C770")]
	public LegionSniperZombie()
	{
	}
}
