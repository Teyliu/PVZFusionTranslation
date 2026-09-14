using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;

// Token: 0x02000416 RID: 1046
[Token(Token = "0x2000416")]
public class PineFurnace : Plant
{
	// Token: 0x06001339 RID: 4921 RVA: 0x0006B7C0 File Offset: 0x000699C0
	[Token(Token = "0x6001339")]
	[Address(RVA = "0x47E710", Offset = "0x47CD10", VA = "0x18047E710", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 3f;
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0006B7E0 File Offset: 0x000699E0
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x4B0FD0", Offset = "0x4AF5D0", VA = "0x1804B0FD0", Slot = "39")]
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
					CreateItem instance = CreateItem.Instance;
				}
			}
			int thePlantRow = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				Dictionary<PlantType, PlantType> dictionary = PineFurnace.mixDic;
				bool flag2;
				while (!flag2)
				{
				}
				CreatePlant instance2 = CreatePlant.Instance;
				int num5 = 0;
				Plant plant;
				if (plant != num5)
				{
					if (plant != 0)
					{
					}
					int num6 = PlantDataManager.GetPlantData((PlantType)num).cost.Multiply(0.2f);
					plant.attributeCount = num6;
					this.MixAward(plant);
				}
			}
		}
		while (num2 != 0);
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x0006B8E8 File Offset: 0x00069AE8
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x4B15D0", Offset = "0x4AFBD0", VA = "0x1804B15D0")]
	private void MixAward(Plant plant)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x0006B908 File Offset: 0x00069B08
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PineFurnace()
	{
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x0006B91C File Offset: 0x00069B1C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x4B1680", Offset = "0x4AFC80", VA = "0x1804B1680")]
	static PineFurnace()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04000C9C RID: 3228
	[Token(Token = "0x4000C9C")]
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
