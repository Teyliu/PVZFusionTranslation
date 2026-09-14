using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000602 RID: 1538
[Token(Token = "0x2000602")]
public class TravelLookMenu : BaseMenu
{
	// Token: 0x06001D05 RID: 7429 RVA: 0x0009B328 File Offset: 0x00099528
	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x522360", Offset = "0x520960", VA = "0x180522360", Slot = "6")]
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

	// Token: 0x06001D06 RID: 7430 RVA: 0x0009B3B8 File Offset: 0x000995B8
	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x523DA0", Offset = "0x5223A0", VA = "0x180523DA0")]
	private void Update()
	{
		Board board = this.board;
		TextMeshProUGUI textMeshProUGUI = this.treasureText;
		int treasureMoney = TreasureData.treasureMoney;
		int buffCost = TreasureData.GetBuffCost();
		string text;
		textMeshProUGUI.text = text;
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x0009B3F4 File Offset: 0x000995F4
	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x523CF0", Offset = "0x5222F0", VA = "0x180523CF0")]
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

	// Token: 0x06001D08 RID: 7432 RVA: 0x0009B448 File Offset: 0x00099648
	[Token(Token = "0x6001D08")]
	[Address(RVA = "0x523350", Offset = "0x521950", VA = "0x180523350")]
	public void LookBuff(string buffType)
	{
		object obj = Enum.Parse(typeof(BuffType), buffType);
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x0009B470 File Offset: 0x00099670
	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x523440", Offset = "0x521A40", VA = "0x180523440")]
	public void NextPage()
	{
		int num = this.maxPage;
		if (this.currentPage < num)
		{
			this.ShowBuffs(true);
			return;
		}
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x0009B498 File Offset: 0x00099698
	[Token(Token = "0x6001D0A")]
	[Address(RVA = "0x523330", Offset = "0x521930", VA = "0x180523330")]
	public void LastPage()
	{
		if (this.currentPage > 1)
		{
			this.ShowBuffs(true);
			return;
		}
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x0009B4B8 File Offset: 0x000996B8
	[Token(Token = "0x6001D0B")]
	[Address(RVA = "0x523700", Offset = "0x521D00", VA = "0x180523700")]
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

	// Token: 0x06001D0C RID: 7436 RVA: 0x0009B530 File Offset: 0x00099730
	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x523220", Offset = "0x521820", VA = "0x180523220")]
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

	// Token: 0x06001D0D RID: 7437 RVA: 0x0009B5AC File Offset: 0x000997AC
	[Token(Token = "0x6001D0D")]
	[Address(RVA = "0x523060", Offset = "0x521660", VA = "0x180523060")]
	private List<TravelUnlocks> GetUnlocks()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.unlockedPlants);
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x0009B61C File Offset: 0x0009981C
	[Token(Token = "0x6001D0E")]
	[Address(RVA = "0x522CB0", Offset = "0x5212B0", VA = "0x180522CB0")]
	private List<TravelDebuff> GetDebuffs()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.travelDebuffs);
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x0009B678 File Offset: 0x00099878
	[Token(Token = "0x6001D0F")]
	[Address(RVA = "0x522DE0", Offset = "0x5213E0", VA = "0x180522DE0")]
	private List<InvestBuff> GetInvestBuffs()
	{
		if (this.showAll)
		{
			Board board = this.board;
			return new List();
		}
		return new List(this.manager.data.investmentBuffs);
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x0009B6D4 File Offset: 0x000998D4
	[Token(Token = "0x6001D10")]
	[Address(RVA = "0x522F10", Offset = "0x521510", VA = "0x180522F10")]
	private ValueTuple<List<UltiBuff>, List<UltiBuff>> GetUltiBuffs()
	{
		if ("{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		List<UltiBuff> list = new List(Enumerable.ToList<UltiBuff>(global::Core.Lawnf.GetEnumValues<UltiBuff>()));
		throw new NullReferenceException();
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x0009B710 File Offset: 0x00099910
	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x522510", Offset = "0x520B10", VA = "0x180522510")]
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

	// Token: 0x06001D12 RID: 7442 RVA: 0x0009B83C File Offset: 0x00099A3C
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x5229E0", Offset = "0x520FE0", VA = "0x1805229E0")]
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

	// Token: 0x06001D13 RID: 7443 RVA: 0x0009B8B8 File Offset: 0x00099AB8
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x5235B0", Offset = "0x521BB0", VA = "0x1805235B0", Slot = "10")]
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

	// Token: 0x06001D14 RID: 7444 RVA: 0x0009B8EC File Offset: 0x00099AEC
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x523460", Offset = "0x521A60", VA = "0x180523460", Slot = "9")]
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

	// Token: 0x06001D15 RID: 7445 RVA: 0x0009B91C File Offset: 0x00099B1C
	[Token(Token = "0x6001D15")]
	[Address(RVA = "0x523EF0", Offset = "0x5224F0", VA = "0x180523EF0")]
	public TravelLookMenu()
	{
		List<TravelLookBuff> list = new List();
		this.theBuffs = list;
		base..ctor();
	}

	// Token: 0x04000F8C RID: 3980
	[Token(Token = "0x4000F8C")]
	public static TravelLookMenu Instance;

	// Token: 0x04000F8D RID: 3981
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F8D")]
	private readonly List<TravelLookBuff> theBuffs;

	// Token: 0x04000F8E RID: 3982
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F8E")]
	private TravelMgr manager;

	// Token: 0x04000F8F RID: 3983
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F8F")]
	private Board board;

	// Token: 0x04000F90 RID: 3984
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F90")]
	public TextMeshProUGUI treasureText;

	// Token: 0x04000F91 RID: 3985
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F91")]
	public GameObject investButton;

	// Token: 0x04000F92 RID: 3986
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000F92")]
	private int currentPage;

	// Token: 0x04000F93 RID: 3987
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000F93")]
	private int maxPage;

	// Token: 0x04000F94 RID: 3988
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000F94")]
	private BuffType displayType;

	// Token: 0x04000F95 RID: 3989
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000F95")]
	public bool showAll;
}
