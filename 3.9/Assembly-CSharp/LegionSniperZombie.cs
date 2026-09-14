using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D0 RID: 1744
[Token(Token = "0x20006D0")]
public class LegionSniperZombie : Zombie
{
	// Token: 0x060021CD RID: 8653 RVA: 0x000B1D18 File Offset: 0x000AFF18
	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000B1D28 File Offset: 0x000AFF28
	[Token(Token = "0x60021CE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000B1D38 File Offset: 0x000AFF38
	[Token(Token = "0x60021CF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000B1D48 File Offset: 0x000AFF48
	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x000B1D58 File Offset: 0x000AFF58
	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x5BEC10", Offset = "0x5BD210", VA = "0x1805BEC10")]
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
				LegionSniperZombie.<>c.<>9__4_0 = delegate(Plant p)
				{
					Plant.PlantTag plantTag = p.plantTag;
					throw new NullReferenceException();
				};
			}
			if (Enumerable.OrderBy<Plant, bool>(plantsByRow, <>9__4_) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_006D;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_006D;
				}
				goto IL_00BB;
				IL_00C2:
				this.attributeCount = num;
				int num3 = 0;
				Plant plant;
				if (!(plant != num3))
				{
				}
				plant.thePlantHealth = num;
				plant.FlashOnce();
				goto IL_00E7;
				IL_00BB:
				int num4;
				num4 += num4;
				goto IL_00C2;
				IL_006D:
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
					goto IL_00BB;
				}
				goto IL_00C2;
			}
			IL_00E7:
			if ("{il2cpp array field local14->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000B1E88 File Offset: 0x000B0088
	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x5BF260", Offset = "0x5BD860", VA = "0x1805BF260", Slot = "23")]
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

	// Token: 0x060021D3 RID: 8659 RVA: 0x000B1F14 File Offset: 0x000B0114
	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x5BF1F0", Offset = "0x5BD7F0", VA = "0x1805BF1F0", Slot = "25")]
	public override void ChangeRow(int theTargetRow)
	{
		base.ChangeRow(theTargetRow);
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("shooting", num != 0);
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000B1F50 File Offset: 0x000B0150
	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x586A30", Offset = "0x585030", VA = "0x180586A30", Slot = "63")]
	protected override void FirstArmorBroken()
	{
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000B1F60 File Offset: 0x000B0160
	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x000B1F9C File Offset: 0x000B019C
	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x5BF4B0", Offset = "0x5BDAB0", VA = "0x1805BF4B0")]
	public LegionSniperZombie()
	{
	}
}
