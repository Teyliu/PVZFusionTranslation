using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;

// Token: 0x020002CC RID: 716
[Token(Token = "0x20002CC")]
public class GoldScaryPot : Plant
{
	// Token: 0x06000CAA RID: 3242 RVA: 0x00048328 File Offset: 0x00046528
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x4327E0", Offset = "0x430DE0", VA = "0x1804327E0", Slot = "35")]
	protected override bool OnCrash()
	{
		this.Hit();
		return true;
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x0004833C File Offset: 0x0004653C
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x432800", Offset = "0x430E00", VA = "0x180432800")]
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

	// Token: 0x06000CAC RID: 3244 RVA: 0x000483C0 File Offset: 0x000465C0
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x431CB0", Offset = "0x4302B0", VA = "0x180431CB0")]
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

	// Token: 0x06000CAD RID: 3245 RVA: 0x000485AC File Offset: 0x000467AC
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x432710", Offset = "0x430D10", VA = "0x180432710", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x000485CC File Offset: 0x000467CC
	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x432A00", Offset = "0x431000", VA = "0x180432A00")]
	public GoldScaryPot()
	{
		List<PlantType> list = new List();
		this.storedPlants = list;
		base..ctor();
	}

	// Token: 0x040008C3 RID: 2243
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40008C3")]
	private readonly List<PlantType> storedPlants;

	// Token: 0x040008C4 RID: 2244
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40008C4")]
	private bool ulti;
}
