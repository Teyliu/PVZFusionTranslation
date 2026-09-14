using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000399 RID: 921
[Token(Token = "0x2000399")]
public class EndPumpiner : Pumpiner
{
	// Token: 0x17000124 RID: 292
	// (get) Token: 0x060010EA RID: 4330 RVA: 0x0006038C File Offset: 0x0005E58C
	// (set) Token: 0x060010EB RID: 4331 RVA: 0x000603C8 File Offset: 0x0005E5C8
	[Token(Token = "0x17000124")]
	public override Dictionary<PlantType, int> PumpinerPlants
	{
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x487270", Offset = "0x485870", VA = "0x180487270", Slot = "68")]
		get
		{
			if (this.board.somethings["endChest"] == 0)
			{
			}
			throw new NullReferenceException();
		}
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x487320", Offset = "0x485920", VA = "0x180487320", Slot = "69")]
		set
		{
			this.board.somethings["endChest"] = value;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060010EC RID: 4332 RVA: 0x000603F4 File Offset: 0x0005E5F4
	[Token(Token = "0x17000125")]
	public override int LimDamage
	{
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00060408 File Offset: 0x0005E608
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x486BF0", Offset = "0x4851F0", VA = "0x180486BF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Board instance = Board.Instance;
		int num = 0;
		if (instance != num && !Board.Instance.somethings.ContainsKey("endChest"))
		{
			Dictionary<string, object> somethings = Board.Instance.somethings;
			Dictionary<PlantType, int> dictionary = new Dictionary();
			somethings["endChest"] = dictionary;
		}
		this.attributeCount = (int)((ulong)1L);
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00060470 File Offset: 0x0005E670
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x4870F0", Offset = "0x4856F0", VA = "0x1804870F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		Board board = this.board;
		PlantType random = ListExtensions.GetRandom<PlantType>(Lawnf.GetUltimatePlants());
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x000604B4 File Offset: 0x0005E6B4
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x4862B0", Offset = "0x4848B0", VA = "0x1804862B0", Slot = "71")]
	public override bool Add(PlantType thePlantType, bool a = false, bool fromPumpiner = false)
	{
		bool flag = base.Add(thePlantType, a, fromPumpiner);
		if (!flag)
		{
			return flag;
		}
		if (!fromPumpiner)
		{
			int num = this.thePlantMaxHealth;
			num = (int)(num + thePlantType);
		}
		return flag;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x000604E4 File Offset: 0x0005E6E4
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x487060", Offset = "0x485660", VA = "0x180487060")]
	public void OnRemove()
	{
		int num = this.theShieldHealth;
		int thePlantMaxHealth = this.thePlantMaxHealth;
		num -= thePlantMaxHealth;
		this.theShieldHealth = num;
		int num2 = 0;
		int num3 = Mathf.Max(num, num2);
		this.theShieldHealth = num3;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x0006051C File Offset: 0x0005E71C
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x486330", Offset = "0x484930", VA = "0x180486330")]
	private void AutoPlacePlant()
	{
		int num3;
		do
		{
			int num = 0;
			Dictionary<PlantType, int> dictionary = new Dictionary();
			List<ValueTuple<int, int>> list = new List();
			bool flag;
			if (flag)
			{
				Func<Plant, bool> <>9__13_ = EndPumpiner.<>c.<>9__13_1;
				if (<>9__13_ == 0)
				{
					EndPumpiner.<>c.<>9__13_1 = (Plant a) => Lawnf.IsLandPlant(a);
				}
				List<Plant> list2;
				Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list2, <>9__13_));
				int num2 = 0;
				if (!(plant != num2))
				{
				}
				Dictionary<PlantType, int> pumpinerPlants = this.PumpinerPlants;
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				if (!flag3)
				{
				}
			}
			if (num != 0)
			{
				goto IL_012E;
			}
			num3 = 0;
			int count = dictionary.Count;
			Func<KeyValuePair<PlantType, int>, int> func;
			if (EndPumpiner.<>c.<>9__13_0 == 0)
			{
				EndPumpiner.<>c.<>9__13_0 = func;
			}
			KeyValuePair<PlantType, int> keyValuePair = Enumerable.First<KeyValuePair<PlantType, int>>(Enumerable.OrderByDescending<KeyValuePair<PlantType, int>, int>(dictionary, func));
			if (keyValuePair == (ulong)(-1L))
			{
				break;
			}
			PlantType plantType = keyValuePair.key;
			Dictionary<PlantType, int> dictionary2;
			if (!dictionary2.TryGetValue(plantType, num))
			{
				break;
			}
			bool flag4;
			if (flag4)
			{
				CreatePlant instance = CreatePlant.Instance;
				int num4 = 0;
				Plant plant2;
				if (!(plant2 != num4))
				{
					continue;
				}
				PlantType plantType2 = keyValuePair.key;
				Dictionary<PlantType, int> dictionary3;
				dictionary3[plantType2] = num;
				PlantType plantType3 = keyValuePair.key;
				Dictionary<PlantType, int> dictionary4;
				bool flag5 = dictionary4.Remove(plantType3);
			}
		}
		while (num3 != 0);
		return;
		IL_012E:
		throw new NullReferenceException();
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0006066C File Offset: 0x0005E86C
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x486D70", Offset = "0x485370", VA = "0x180486D70")]
	private void ChangePlant()
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__14_ = EndPumpiner.<>c.<>9__14_0;
		if (<>9__14_ == 0)
		{
			EndPumpiner.<>c.<>9__14_0 = (Plant a) => a.thePlantType == PlantType.Pumpkin;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__14_));
		int num = 0;
		if (plant != num)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x000606D8 File Offset: 0x0005E8D8
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x486FB0", Offset = "0x4855B0", VA = "0x180486FB0")]
	private void GetCards()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x000606F8 File Offset: 0x0005E8F8
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "70")]
	protected override void Check()
	{
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00060708 File Offset: 0x0005E908
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x487250", Offset = "0x485850", VA = "0x180487250")]
	public EndPumpiner()
	{
	}

	// Token: 0x04000BDD RID: 3037
	[Token(Token = "0x4000BDD")]
	private const int stackCount = 64;

	// Token: 0x04000BDE RID: 3038
	[Token(Token = "0x4000BDE")]
	private const int MaxGridCount = 54;

	// Token: 0x04000BDF RID: 3039
	[Token(Token = "0x4000BDF")]
	private const string key = "endChest";

	// Token: 0x04000BE0 RID: 3040
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000BE0")]
	private PlantType lastPlacedPlant = (PlantType)((ulong)4294967295L);
}
