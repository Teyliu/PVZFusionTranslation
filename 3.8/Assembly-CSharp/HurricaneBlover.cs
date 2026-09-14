using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200039C RID: 924
[Token(Token = "0x200039C")]
public class HurricaneBlover : Shooter
{
	// Token: 0x060010F8 RID: 4344 RVA: 0x00060BA8 File Offset: 0x0005EDA8
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x43A310", Offset = "0x438910", VA = "0x18043A310", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		global::UnityEngine.Object.Destroy(this.particle.gameObject);
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00060BCC File Offset: 0x0005EDCC
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x41EBD0", Offset = "0x41D1D0", VA = "0x18041EBD0", Slot = "48")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return base.SearchUniqueZombie(zombie) || zombie.theStatus == ZombieStatus.Flying;
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00060BF8 File Offset: 0x0005EDF8
	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x439AB0", Offset = "0x4380B0", VA = "0x180439AB0", Slot = "73")]
	protected virtual void AnimStartBlow()
	{
		SortingGroup sortingGroup = this.particle;
		int num = 0;
		if (sortingGroup != num)
		{
			int thePlantRow = this.thePlantRow;
			SortingGroup sortingGroup2 = this.particle;
			string text = string.Format("particle{0}", thePlantRow);
			sortingGroup2.sortingLayerName = text;
		}
		this.theStatus = (PlantStatus)((ulong)25L);
		GameAPP.PlaySound((SoundType)((uint)87), 0.5f, 1f);
		if (!this.blowed)
		{
			this.blowed = true;
			this.Blow();
		}
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00060C74 File Offset: 0x0005EE74
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x43A190", Offset = "0x438790", VA = "0x18043A190")]
	protected void Blow()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				Blow blow = num.AddComponent<Blow>();
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00060CBC File Offset: 0x0005EEBC
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x439AA0", Offset = "0x4380A0", VA = "0x180439AA0")]
	private void AnimEndBlow()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00060CD4 File Offset: 0x0005EED4
	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x43A380", Offset = "0x438980", VA = "0x18043A380", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00060CE8 File Offset: 0x0005EEE8
	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x439BE0", Offset = "0x4381E0", VA = "0x180439BE0", Slot = "74")]
	protected virtual void BlowUpdate()
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			Func<Zombie, bool> func;
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(Lawnf.GetZombiesByRow(this.thePlantRow, num2 != 0), func);
			Func<Zombie, float> <>9__8_ = HurricaneBlover.<>c.<>9__8_1;
			if (<>9__8_ == 0)
			{
				Func<Zombie, float> func2;
				HurricaneBlover.<>c.<>9__8_1 = func2;
			}
			uint num3;
			IEnumerable<Zombie> enumerable2 = Enumerable.Take<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, <>9__8_), (int)num3);
			if (num >= (int)num3)
			{
				goto IL_004D;
			}
			num += num;
			if (num != (int)num3)
			{
				num++;
				goto IL_004D;
			}
			goto IL_00A7;
			IL_00B1:
			int num4;
			num4 += 312;
			if (num == 0)
			{
				break;
			}
			continue;
			IL_004D:
			if (num < typeof(IEnumerable<Zombie>).TypeHandle)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				if (num == 0)
				{
					goto IL_00B1;
				}
				num++;
			}
			bool flag;
			float num5;
			if (flag)
			{
				num5 = Time.fixedDeltaTime;
				Vector2 vector = Vector3Extensions.Add(num, num, num);
			}
			bool flag2;
			bool flag3;
			if (!flag2 && !flag3)
			{
				num4 = 0;
				bool flag4;
				if (flag4)
				{
				}
			}
			num5 = Time.fixedDeltaTime;
			IL_00A7:
			num4 += 312;
			goto IL_00B1;
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00060DD0 File Offset: 0x0005EFD0
	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public HurricaneBlover()
	{
	}

	// Token: 0x04000B9F RID: 2975
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B9F")]
	private bool blowed;

	// Token: 0x04000BA0 RID: 2976
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000BA0")]
	public SortingGroup particle;
}
