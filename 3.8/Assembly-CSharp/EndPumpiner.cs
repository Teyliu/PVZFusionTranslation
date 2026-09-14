using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000386 RID: 902
[Token(Token = "0x2000386")]
public class EndPumpiner : Pumpiner
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06001095 RID: 4245 RVA: 0x0005F05C File Offset: 0x0005D25C
	// (set) Token: 0x06001096 RID: 4246 RVA: 0x0005F098 File Offset: 0x0005D298
	[Token(Token = "0x170000E1")]
	public override Dictionary<PlantType, int> PumpinerPlants
	{
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x4339C0", Offset = "0x431FC0", VA = "0x1804339C0", Slot = "69")]
		get
		{
			if (this.board.somethings["endChest"] == 0)
			{
			}
			throw new NullReferenceException();
		}
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x433A70", Offset = "0x432070", VA = "0x180433A70", Slot = "70")]
		set
		{
			this.board.somethings["endChest"] = value;
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06001097 RID: 4247 RVA: 0x0005F0C4 File Offset: 0x0005D2C4
	[Token(Token = "0x170000E2")]
	public override int LimDamage
	{
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x0005F0D8 File Offset: 0x0005D2D8
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x433590", Offset = "0x431B90", VA = "0x180433590", Slot = "10")]
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

	// Token: 0x06001099 RID: 4249 RVA: 0x0005F140 File Offset: 0x0005D340
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x433850", Offset = "0x431E50", VA = "0x180433850", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		Board board = this.board;
		PlantType random = ListExtensions.GetRandom<PlantType>(Lawnf.GetUltimatePlants());
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0005F184 File Offset: 0x0005D384
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x433510", Offset = "0x431B10", VA = "0x180433510", Slot = "72")]
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

	// Token: 0x0600109B RID: 4251 RVA: 0x0005F1B4 File Offset: 0x0005D3B4
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x4337C0", Offset = "0x431DC0", VA = "0x1804337C0")]
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

	// Token: 0x0600109C RID: 4252 RVA: 0x0005F1EC File Offset: 0x0005D3EC
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x433710", Offset = "0x431D10", VA = "0x180433710")]
	private void GetCards()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x0005F20C File Offset: 0x0005D40C
	[Token(Token = "0x600109D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	protected override void Check()
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x0005F21C File Offset: 0x0005D41C
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x4339B0", Offset = "0x431FB0", VA = "0x1804339B0")]
	public EndPumpiner()
	{
	}

	// Token: 0x04000B86 RID: 2950
	[Token(Token = "0x4000B86")]
	private const int stackCount = 64;

	// Token: 0x04000B87 RID: 2951
	[Token(Token = "0x4000B87")]
	private const int MaxGridCount = 54;

	// Token: 0x04000B88 RID: 2952
	[Token(Token = "0x4000B88")]
	private const string key = "endChest";
}
