using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000637 RID: 1591
[Token(Token = "0x2000637")]
public class TravelLookMenu : BaseMenu
{
	// Token: 0x06001E04 RID: 7684 RVA: 0x0009FE1C File Offset: 0x0009E01C
	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x5823F0", Offset = "0x5809F0", VA = "0x1805823F0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		TravelLookMenu.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		if (!this.board.isEveStarted)
		{
		}
		this.showAll = true;
		this.treasureText.gameObject.SetActive(true);
		this.showAll = true;
		GameObject gameObject = this.investButton;
		if (TravelMgr.Instance.data.Invest)
		{
		}
		bool flag = this.board.isEveStarted;
		gameObject.SetActive(flag);
	}

	// Token: 0x06001E05 RID: 7685 RVA: 0x0009FEAC File Offset: 0x0009E0AC
	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x583E30", Offset = "0x582430", VA = "0x180583E30")]
	private void Update()
	{
		Board board = this.board;
		TextMeshProUGUI textMeshProUGUI = this.treasureText;
		int treasureMoney = TreasureData.treasureMoney;
		int buffCost = TreasureData.GetBuffCost();
		string text;
		textMeshProUGUI.text = text;
	}

	// Token: 0x06001E06 RID: 7686 RVA: 0x0009FEE8 File Offset: 0x0009E0E8
	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x583D80", Offset = "0x582380", VA = "0x180583D80")]
	private void Start()
	{
		this.GetBuffs();
		this.currentPage = (int)((ulong)1L);
		this.displayType = (BuffType)((ulong)1L);
		int num = 0;
		int num2 = this.GetAdvBuffs()._size;
		num2 += num;
		num2++;
		this.maxPage = num2;
		int num3 = 0;
		this.ShowBuffs(num3 != 0);
	}

	// Token: 0x06001E07 RID: 7687 RVA: 0x0009FF3C File Offset: 0x0009E13C
	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x5833E0", Offset = "0x5819E0", VA = "0x1805833E0")]
	public void LookBuff(string buffType)
	{
		object obj = Enum.Parse(typeof(BuffType), buffType);
	}

	// Token: 0x06001E08 RID: 7688 RVA: 0x0009FF64 File Offset: 0x0009E164
	[Token(Token = "0x6001E08")]
	[Address(RVA = "0x5834D0", Offset = "0x581AD0", VA = "0x1805834D0")]
	public void NextPage()
	{
		int num = this.maxPage;
		if (this.currentPage < num)
		{
			this.ShowBuffs(true);
			return;
		}
	}

	// Token: 0x06001E09 RID: 7689 RVA: 0x0009FF8C File Offset: 0x0009E18C
	[Token(Token = "0x6001E09")]
	[Address(RVA = "0x5833C0", Offset = "0x5819C0", VA = "0x1805833C0")]
	public void LastPage()
	{
		if (this.currentPage > 1)
		{
			this.ShowBuffs(true);
			return;
		}
	}

	// Token: 0x06001E0A RID: 7690 RVA: 0x0009FFAC File Offset: 0x0009E1AC
	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x583790", Offset = "0x581D90", VA = "0x180583790")]
	private void ShowBuffs(bool refresh)
	{
		ulong num;
		do
		{
			List<TravelLookBuff> list = this.theBuffs;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
		List<InvestBuff> list2;
		List<TravelDebuff> list3;
		List<AdvBuff> list4;
		List<TravelUnlocks> list5;
		if ((num != (ulong)0L && ((num != (ulong)0L && num != (ulong)0L && ((num != (ulong)0L && (num != (ulong)1L || list2 >= (ulong)8L)) || list3 >= (ulong)8L)) || list4 >= (ulong)8L)) || list5 < (ulong)8L)
		{
		}
	}

	// Token: 0x06001E0B RID: 7691 RVA: 0x000A0024 File Offset: 0x0009E224
	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x5832B0", Offset = "0x5818B0", VA = "0x1805832B0")]
	private void InitBuffType(BuffType buffType, bool refresh)
	{
		this.currentPage = (int)((ulong)1L);
		this.displayType = buffType;
		if (buffType != BuffType.UnlockPlant)
		{
			if (buffType != BuffType.UnlockPlant && buffType != BuffType.UnlockPlant)
			{
				if (buffType != BuffType.UnlockPlant)
				{
					if (buffType != BuffType.AdvancedBuff)
					{
						goto IL_0061;
					}
					List<InvestBuff> investBuffs = this.GetInvestBuffs();
				}
				List<TravelDebuff> debuffs = this.GetDebuffs();
			}
			List<AdvBuff> advBuffs = this.GetAdvBuffs();
		}
		int num = 0;
		int num2 = this.GetUnlocks()._size;
		num2 += num;
		num2++;
		this.maxPage = num2;
		IL_0061:
		this.ShowBuffs(refresh);
	}

	// Token: 0x06001E0C RID: 7692 RVA: 0x000A00A0 File Offset: 0x0009E2A0
	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x5830F0", Offset = "0x5816F0", VA = "0x1805830F0")]
	private List<TravelUnlocks> GetUnlocks()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.unlockedPlants);
	}

	// Token: 0x06001E0D RID: 7693 RVA: 0x000A0110 File Offset: 0x0009E310
	[Token(Token = "0x6001E0D")]
	[Address(RVA = "0x582D40", Offset = "0x581340", VA = "0x180582D40")]
	private List<TravelDebuff> GetDebuffs()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.travelDebuffs);
	}

	// Token: 0x06001E0E RID: 7694 RVA: 0x000A016C File Offset: 0x0009E36C
	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x582E70", Offset = "0x581470", VA = "0x180582E70")]
	private List<InvestBuff> GetInvestBuffs()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.investmentBuffs);
	}

	// Token: 0x06001E0F RID: 7695 RVA: 0x000A01C8 File Offset: 0x0009E3C8
	[Token(Token = "0x6001E0F")]
	[Address(RVA = "0x582FA0", Offset = "0x5815A0", VA = "0x180582FA0")]
	private ValueTuple<List<UltiBuff>, List<UltiBuff>> GetUltiBuffs()
	{
		if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		List<UltiBuff> list = new List(Enumerable.ToList<UltiBuff>(global::Core.Lawnf.GetEnumValues<UltiBuff>()));
		throw new NullReferenceException();
	}

	// Token: 0x06001E10 RID: 7696 RVA: 0x000A0204 File Offset: 0x0009E404
	[Token(Token = "0x6001E10")]
	[Address(RVA = "0x5825A0", Offset = "0x580BA0", VA = "0x1805825A0")]
	private List<AdvBuff> GetAdvBuffs()
	{
		while (this.showAll)
		{
			Board board = this.board;
			HashSet<AdvBuff> hashSet = new HashSet();
			Dictionary<PlantType, ValueTuple<PlantType?, object, object, bool>> plantInfo = TravelDictionary.PlantInfo;
			int num = 0;
			bool flag;
			if (flag)
			{
			}
			if (num == 0)
			{
				bool flag2 = hashSet.Add((uint)1002);
				bool flag3 = hashSet.Add((uint)1003);
				bool flag4 = hashSet.Add((uint)1004);
				bool flag5 = hashSet.Add((uint)1007);
				bool flag6 = hashSet.Add((uint)1008);
				bool flag7 = hashSet.Add((uint)1009);
				bool flag8 = hashSet.Add((uint)1011);
				bool flag9 = hashSet.Add((uint)1016);
				bool flag10 = hashSet.Add((uint)1017);
				return Enumerable.ToList<AdvBuff>(hashSet);
			}
		}
		List<AdvBuff> list = new List(this.manager.data.advBuffs);
		Array values = Enum.GetValues(typeof(AdvBuff));
		if (values == 0)
		{
		}
		if (values != 0)
		{
		}
		throw new InvalidCastException();
	}

	// Token: 0x06001E11 RID: 7697 RVA: 0x000A0330 File Offset: 0x0009E530
	[Token(Token = "0x6001E11")]
	[Address(RVA = "0x582A70", Offset = "0x581070", VA = "0x180582A70")]
	private void GetBuffs()
	{
		int num;
		do
		{
			num = 0;
			uint num2;
			IEnumerator enumerator = base.transform.GetChild((int)num2).GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				bool flag;
				while (!flag)
				{
				}
				List<TravelLookBuff> list = this.theBuffs;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		TravelMgr instance = TravelMgr.Instance;
	}

	// Token: 0x06001E12 RID: 7698 RVA: 0x000A03AC File Offset: 0x0009E5AC
	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x583640", Offset = "0x581C40", VA = "0x180583640", Slot = "10")]
	public override void OnHide()
	{
		ulong num;
		do
		{
			List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(base.gameObject);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001E13 RID: 7699 RVA: 0x000A03E0 File Offset: 0x0009E5E0
	[Token(Token = "0x6001E13")]
	[Address(RVA = "0x5834F0", Offset = "0x581AF0", VA = "0x1805834F0", Slot = "9")]
	public override void OnBackEnter()
	{
		ulong num;
		do
		{
			List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(base.gameObject);
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001E14 RID: 7700 RVA: 0x000A0410 File Offset: 0x0009E610
	[Token(Token = "0x6001E14")]
	[Address(RVA = "0x583F80", Offset = "0x582580", VA = "0x180583F80")]
	public TravelLookMenu()
	{
		List<TravelLookBuff> list = new List();
		this.theBuffs = list;
		base..ctor();
	}

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4001054")]
	public static TravelLookMenu Instance;

	// Token: 0x04001055 RID: 4181
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001055")]
	private readonly List<TravelLookBuff> theBuffs;

	// Token: 0x04001056 RID: 4182
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001056")]
	private TravelMgr manager;

	// Token: 0x04001057 RID: 4183
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001057")]
	private Board board;

	// Token: 0x04001058 RID: 4184
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001058")]
	public TextMeshProUGUI treasureText;

	// Token: 0x04001059 RID: 4185
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001059")]
	public GameObject investButton;

	// Token: 0x0400105A RID: 4186
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400105A")]
	private int currentPage;

	// Token: 0x0400105B RID: 4187
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400105B")]
	private int maxPage;

	// Token: 0x0400105C RID: 4188
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400105C")]
	private BuffType displayType;

	// Token: 0x0400105D RID: 4189
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400105D")]
	public bool showAll;
}
