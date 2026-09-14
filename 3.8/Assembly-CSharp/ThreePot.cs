using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000459 RID: 1113
[Token(Token = "0x2000459")]
public class ThreePot : Pot
{
	// Token: 0x06001486 RID: 5254 RVA: 0x000724D8 File Offset: 0x000706D8
	[Token(Token = "0x6001486")]
	[Address(RVA = "0x479200", Offset = "0x477800", VA = "0x180479200", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)6), action, num != 0);
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000724F8 File Offset: 0x000706F8
	[Token(Token = "0x6001487")]
	[Address(RVA = "0x478F20", Offset = "0x477520", VA = "0x180478F20")]
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

	// Token: 0x06001488 RID: 5256 RVA: 0x0007259C File Offset: 0x0007079C
	[Token(Token = "0x6001488")]
	[Address(RVA = "0x478EB0", Offset = "0x4774B0", VA = "0x180478EB0", Slot = "17")]
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

	// Token: 0x06001489 RID: 5257 RVA: 0x000725E4 File Offset: 0x000707E4
	[Token(Token = "0x6001489")]
	[Address(RVA = "0x4788E0", Offset = "0x476EE0", VA = "0x1804788E0")]
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

	// Token: 0x0600148A RID: 5258 RVA: 0x00072664 File Offset: 0x00070864
	[Token(Token = "0x600148A")]
	[Address(RVA = "0x478CA0", Offset = "0x4772A0", VA = "0x180478CA0", Slot = "53")]
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

	// Token: 0x0600148B RID: 5259 RVA: 0x000726B4 File Offset: 0x000708B4
	[Token(Token = "0x600148B")]
	[Address(RVA = "0x4792B0", Offset = "0x4778B0", VA = "0x1804792B0")]
	public ThreePot()
	{
		HashSet<Plant> hashSet = new HashSet();
		this.effectPlants = hashSet;
		base..ctor();
	}

	// Token: 0x04000CC9 RID: 3273
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CC9")]
	private readonly HashSet<Plant> effectPlants;

	// Token: 0x04000CCA RID: 3274
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CCA")]
	private float timer;
}
