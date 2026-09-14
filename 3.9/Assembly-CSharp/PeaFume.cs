using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200056F RID: 1391
[Token(Token = "0x200056F")]
public class PeaFume : Shooter
{
	// Token: 0x060019D7 RID: 6615 RVA: 0x0008B3C0 File Offset: 0x000895C0
	[Token(Token = "0x60019D7")]
	[Address(RVA = "0x538450", Offset = "0x536A50", VA = "0x180538450", Slot = "68")]
	protected override Bullet Shoot1()
	{
		int size = this.board.zombieArray._size;
		int num = 0;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3 && !zombie.isMindControlled)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow)
				{
					Transform axis = zombie.axis;
					Transform axis2 = this.axis;
					if (Lawnf.InLandStatus(zombie.theStatus))
					{
						PlantType thePlantType = this.thePlantType;
					}
				}
			}
			if (num != 0)
			{
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
			}
		}
		GameAPP.PlaySound(58, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0008B484 File Offset: 0x00089684
	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x538690", Offset = "0x536C90", VA = "0x180538690", Slot = "72")]
	protected virtual void StartShooting()
	{
		int thePlantRow = this.thePlantRow;
		SortingGroup sortingGroup = this.fume;
		string text = string.Format("particle{0}", thePlantRow);
		sortingGroup.sortingLayerName = text;
		Bullet bullet = base.AnimShoot();
		this.theStatus = (PlantStatus)((ulong)25L);
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0008B4CC File Offset: 0x000896CC
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x48D320", Offset = "0x48B920", VA = "0x18048D320", Slot = "73")]
	protected virtual void EndShooting()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0008B4E4 File Offset: 0x000896E4
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x538400", Offset = "0x536A00", VA = "0x180538400", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
		}
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x0008B504 File Offset: 0x00089704
	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x5381E0", Offset = "0x5367E0", VA = "0x1805381E0", Slot = "74")]
	protected virtual void AddDamage()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Bullet> bulletArray = this.board.boardEntity.bulletArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				int thePlantRow = this.thePlantRow;
				Transform axis = this.axis;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x0008B564 File Offset: 0x00089764
	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public PeaFume()
	{
	}

	// Token: 0x04000EF5 RID: 3829
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000EF5")]
	public SortingGroup fume;
}
