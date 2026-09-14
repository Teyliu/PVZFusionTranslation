using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000479 RID: 1145
[Token(Token = "0x2000479")]
public class ThreePot : Pot
{
	// Token: 0x06001516 RID: 5398 RVA: 0x00074830 File Offset: 0x00072A30
	[Token(Token = "0x6001516")]
	[Address(RVA = "0x4D0AC0", Offset = "0x4CF0C0", VA = "0x1804D0AC0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x00074850 File Offset: 0x00072A50
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x4D07E0", Offset = "0x4CEDE0", VA = "0x1804D07E0")]
	private void OnPlantShoot(object obj)
	{
		if (obj != 0)
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			Dictionary<PlantType, int> peaPlant = PeaPumpkin.PeaPlant;
			bool flag;
			if (flag)
			{
				int num = this.attributeCount;
				num++;
				this.attributeCount = num;
				this.attributeCount = (int)((ulong)0L);
				bool flag2;
				if (flag2)
				{
					int rowNum = this.board.rowNum;
					if (num > rowNum)
					{
						num = rowNum;
					}
					int num3;
					uint num4;
					int num2 = Mathf.Max(num3, (int)num4);
					num3 = num;
				}
				bool flag3;
				if (flag3)
				{
					int rowNum2 = this.board.rowNum;
					if ((flag2 ? 1 : 0) > rowNum2)
					{
					}
					int num6;
					uint num7;
					int num5 = Mathf.Max(num6, (int)num7);
				}
			}
		}
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x000748F4 File Offset: 0x00072AF4
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x4D0770", Offset = "0x4CED70", VA = "0x1804D0770", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			float num = this.timer;
			float fixedDeltaTime = Time.fixedDeltaTime;
			this.timer = num;
			this.timer = 1f;
			this.Check();
			return;
		}
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x0007493C File Offset: 0x00072B3C
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x4D01A0", Offset = "0x4CE7A0", VA = "0x1804D01A0")]
	private void Check()
	{
		int num4;
		do
		{
			int num = 0;
			HashSet<Plant> hashSet = this.effectPlants;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
			if (num2 != 0)
			{
				goto IL_0061;
			}
			num4 = 0;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (!PlantMixTreeManager.GetAllMixablePlantsCombined((PlantType)((uint)14)).Contains(num5))
				{
					continue;
				}
				bool flag3;
				Debug.Log(flag3);
			}
		}
		while (num4 != 0);
		return;
		IL_0061:
		throw new NullReferenceException();
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x000749BC File Offset: 0x00072BBC
	[Token(Token = "0x600151A")]
	[Address(RVA = "0x4D0560", Offset = "0x4CEB60", VA = "0x1804D0560", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num2;
		do
		{
			int num = 0;
			HashSet<Plant> hashSet = this.effectPlants;
			num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
			}
		}
		while (num2 != 0);
		Action<object> action;
		EventManager.RemoveListener((GameEvent)((uint)6), action);
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00074A0C File Offset: 0x00072C0C
	[Token(Token = "0x600151B")]
	[Address(RVA = "0x4D0B70", Offset = "0x4CF170", VA = "0x1804D0B70")]
	public ThreePot()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.effectPlants = hashSet;
		base..ctor();
	}

	// Token: 0x04000D55 RID: 3413
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D55")]
	private readonly HashSet<Plant> effectPlants;

	// Token: 0x04000D56 RID: 3414
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D56")]
	private float timer;
}
