using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020002BE RID: 702
[Token(Token = "0x20002BE")]
public class GoldScaryPot : Plant
{
	// Token: 0x06000C67 RID: 3175 RVA: 0x0004775C File Offset: 0x0004595C
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x3E1B40", Offset = "0x3E0140", VA = "0x1803E1B40", Slot = "36")]
	protected override bool OnCrash()
	{
		this.Hit();
		return true;
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x00047770 File Offset: 0x00045970
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x3E1B60", Offset = "0x3E0160", VA = "0x1803E1B60")]
	public bool TryEatPlant(PlantType thePlantType)
	{
		List<PlantType> list = this.storedPlants;
		int size = list._size;
		int num = (int)(thePlantType + 1);
		list._size = num;
		bool flag;
		bool flag2;
		if (!flag && !flag2)
		{
			bool flag3;
			if (!flag3)
			{
				this.attributeCount = (flag3 ? 1 : 0);
			}
			this.attributeCount = (flag3 ? 1 : 0);
		}
		this.ulti = true;
		base.UpdateText();
		this.anim.SetTrigger("get");
		GameAPP.PlaySound(56, 0.5f, 1f);
		return true;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x000477F4 File Offset: 0x000459F4
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x3E1010", Offset = "0x3DF610", VA = "0x1803E1010")]
	public void Hit()
	{
		List<PlantType> list;
		for (;;)
		{
			int thePlantColumn = this.thePlantColumn;
			GridItem gridItem;
			if (gridItem == 0)
			{
			}
			list = new List(GameAPP.resourcesManager.allPlants);
			Predicate<PlantType> predicate;
			if (GoldScaryPot.<>c.<>9__4_0 == 0)
			{
				predicate = delegate(PlantType p)
				{
					bool flag2;
					bool flag3;
					bool flag4;
					return flag2 || flag3 || flag4;
				};
				GoldScaryPot.<>c.<>9__4_0 = predicate;
			}
			int num = list.RemoveAll(predicate);
			if (!this.ulti)
			{
				break;
			}
			Predicate<PlantType> predicate2;
			if (GoldScaryPot.<>c.<>9__4_1 == 0)
			{
				predicate2 = delegate(PlantType p)
				{
					bool flag5;
					return flag5;
				};
				GoldScaryPot.<>c.<>9__4_1 = predicate2;
			}
			int num2 = list.RemoveAll(predicate2);
			Board board = this.board;
			list._size = (int)((ulong)0L);
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			bool flag;
			if (flag)
			{
				int size = list._size;
				list._size = (flag ? 1 : 0);
				while (!flag)
				{
				}
			}
			ulong num3;
			if (num3 == (ulong)0L)
			{
				goto Block_12;
			}
		}
		int attributeCount = this.attributeCount;
		if (attributeCount != 0)
		{
			if (attributeCount != 0)
			{
				if (attributeCount != 0)
				{
					if (attributeCount != 1)
					{
						if (GoldScaryPot.<>c.<>9__4_6 != 0)
						{
							goto IL_00F0;
						}
						GoldScaryPot.<>c.<>9__4_6 = delegate(PlantType p)
						{
							bool flag6;
							return flag6;
						};
					}
					if (GoldScaryPot.<>c.<>9__4_5 != 0)
					{
						goto IL_00F0;
					}
					GoldScaryPot.<>c.<>9__4_5 = delegate(PlantType p)
					{
						bool flag7;
						return flag7;
					};
				}
				if (GoldScaryPot.<>c.<>9__4_4 != 0)
				{
					goto IL_00F0;
				}
				GoldScaryPot.<>c.<>9__4_4 = delegate(PlantType p)
				{
					bool flag8;
					return flag8;
				};
			}
			Predicate<PlantType> predicate3;
			if (GoldScaryPot.<>c.<>9__4_3 == 0)
			{
				predicate3 = delegate(PlantType p)
				{
					bool flag9;
					return flag9;
				};
				GoldScaryPot.<>c.<>9__4_3 = predicate3;
			}
			IL_00F0:
			int num4 = list.RemoveAll(predicate3);
		}
		int num5 = 0;
		base.Die((Plant.DieReason)num5);
		return;
		Block_12:
		Predicate<PlantType> predicate4;
		if (GoldScaryPot.<>c.<>9__4_2 == 0)
		{
			predicate4 = delegate(PlantType p)
			{
				CreatePlant instance2 = CreatePlant.Instance;
				bool flag10;
				return flag10;
			};
			GoldScaryPot.<>c.<>9__4_2 = predicate4;
		}
		int num6 = list.RemoveAll(predicate4);
		InGameText instance = InGameText.Instance;
		instance.TimeOver();
		int size2 = list._size;
		list._size = instance;
		PlantType random = ListExtensions.GetRandom<PlantType>(list);
		throw new NullReferenceException();
	}

	// Token: 0x06000C6A RID: 3178 RVA: 0x000479E0 File Offset: 0x00045BE0
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x3E1A70", Offset = "0x3E0070", VA = "0x1803E1A70", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x00047A00 File Offset: 0x00045C00
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x3E1D60", Offset = "0x3E0360", VA = "0x1803E1D60")]
	public GoldScaryPot()
	{
		List<PlantType> list = new List();
		this.storedPlants = list;
		base..ctor();
	}

	// Token: 0x04000886 RID: 2182
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000886")]
	private readonly List<PlantType> storedPlants;

	// Token: 0x04000887 RID: 2183
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000887")]
	private bool ulti;
}
