using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020003FC RID: 1020
[Token(Token = "0x20003FC")]
public class PineFurnace : Plant
{
	// Token: 0x060012C6 RID: 4806 RVA: 0x00069A0C File Offset: 0x00067C0C
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x42DFB0", Offset = "0x42C5B0", VA = "0x18042DFB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00069A2C File Offset: 0x00067C2C
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x45AC80", Offset = "0x459280", VA = "0x18045AC80", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			base.AttributeCountdown = 3f;
			AdvantureData data = AdvantureConfig.data;
			int size = this.board.griditemArray._size;
			int num3 = size - 1;
			if (size > 0)
			{
				GridItem gridItem = this.board.griditemArray[num3];
				int num4 = 0;
				if (gridItem != num4 && gridItem != 0)
				{
					int num5 = gridItem.theItemColumn;
					int num6 = this.thePlantColumn;
					bool flag;
					if (flag)
					{
						num5 -= num6;
						num6 = num5;
					}
					if (num5 == num6)
					{
						int thePlantRow = this.thePlantRow;
						if (gridItem.theItemRow == thePlantRow)
						{
						}
					}
				}
			}
			int thePlantRow2 = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow2);
			bool flag2;
			if (flag2)
			{
				Dictionary<PlantType, PlantType> dictionary = PineFurnace.mixDic;
				bool flag3;
				while (!flag3)
				{
				}
				CreatePlant instance = CreatePlant.Instance;
				int num7 = 0;
				Plant plant;
				if (plant != num7)
				{
					int num8 = PlantDataManager.GetPlantData((PlantType)num).cost;
					num8 += num8;
					ulong num9;
					num9 += num9;
					plant.attributeCount = (int)num9;
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00069B60 File Offset: 0x00067D60
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PineFurnace()
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00069B74 File Offset: 0x00067D74
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x45B190", Offset = "0x459790", VA = "0x18045B190")]
	static PineFurnace()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04000C25 RID: 3109
	[Token(Token = "0x4000C25")]
	public static readonly Dictionary<PlantType, PlantType> mixDic = new Dictionary
	{
		{
			(uint)36,
			(uint)1223
		},
		{
			(uint)33,
			(uint)1224
		},
		{
			(uint)37,
			(uint)1225
		},
		{
			(uint)38,
			(uint)1226
		},
		{
			(uint)1227,
			(uint)1234
		},
		{
			(uint)39,
			(uint)1265
		}
	};
}
