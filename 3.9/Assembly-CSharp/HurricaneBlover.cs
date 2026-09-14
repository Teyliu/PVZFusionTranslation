using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020003B0 RID: 944
[Token(Token = "0x20003B0")]
public class HurricaneBlover : Shooter
{
	// Token: 0x06001154 RID: 4436 RVA: 0x000621F0 File Offset: 0x000603F0
	[Token(Token = "0x6001154")]
	[Address(RVA = "0x48DB50", Offset = "0x48C150", VA = "0x18048DB50", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		global::UnityEngine.Object.Destroy(this.particle.gameObject);
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x00062214 File Offset: 0x00060414
	[Token(Token = "0x6001155")]
	[Address(RVA = "0x475B10", Offset = "0x474110", VA = "0x180475B10", Slot = "47")]
	protected override bool SearchUniqueZombie(Zombie zombie)
	{
		return base.SearchUniqueZombie(zombie) || zombie.theStatus == ZombieStatus.Flying;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x00062240 File Offset: 0x00060440
	[Token(Token = "0x6001156")]
	[Address(RVA = "0x48D330", Offset = "0x48B930", VA = "0x18048D330", Slot = "72")]
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

	// Token: 0x06001157 RID: 4439 RVA: 0x000622BC File Offset: 0x000604BC
	[Token(Token = "0x6001157")]
	[Address(RVA = "0x48D950", Offset = "0x48BF50", VA = "0x18048D950")]
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
		bool flag2;
		if (flag2)
		{
			FogMgr.Instance.Blown();
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x00062318 File Offset: 0x00060518
	[Token(Token = "0x6001158")]
	[Address(RVA = "0x48D320", Offset = "0x48B920", VA = "0x18048D320")]
	private void AnimEndBlow()
	{
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x00062330 File Offset: 0x00060530
	[Token(Token = "0x6001159")]
	[Address(RVA = "0x48DBC0", Offset = "0x48C1C0", VA = "0x18048DBC0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00062344 File Offset: 0x00060544
	[Token(Token = "0x600115A")]
	[Address(RVA = "0x48D460", Offset = "0x48BA60", VA = "0x18048D460", Slot = "73")]
	protected virtual void BlowUpdate()
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			List<Zombie> zombiesByRow = Lawnf.GetZombiesByRow(this.thePlantRow, num2 != 0);
			Func<Zombie, bool> func = delegate(Zombie z)
			{
				int column = z.Column;
				return z.theStatus != ZombieStatus.Miner_digging;
			};
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombiesByRow, func);
			Func<Zombie, float> <>9__8_ = HurricaneBlover.<>c.<>9__8_1;
			if (<>9__8_ == 0)
			{
				Func<Zombie, float> func2;
				HurricaneBlover.<>c.<>9__8_1 = func2;
			}
			uint num3;
			if (Enumerable.Take<Zombie>(Enumerable.OrderBy<Zombie, float>(enumerable, <>9__8_), (int)num3) != 0)
			{
				if (num >= typeof(IEnumerator).TypeHandle)
				{
					goto IL_0065;
				}
				num += num;
				if (num != typeof(IEnumerator).TypeHandle)
				{
					num++;
					goto IL_0065;
				}
				IL_00A0:
				int num4;
				num4 += 312;
				goto IL_00AA;
				IL_0065:
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
				goto IL_00A0;
			}
			IL_00AA:
			if ("{il2cpp array field local17->}" != (ulong)0L)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00062428 File Offset: 0x00060628
	[Token(Token = "0x600115B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public HurricaneBlover()
	{
	}

	// Token: 0x04000C05 RID: 3077
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C05")]
	private bool blowed;

	// Token: 0x04000C06 RID: 3078
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000C06")]
	public SortingGroup particle;
}
