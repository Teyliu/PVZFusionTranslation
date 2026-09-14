using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005FD RID: 1533
[Token(Token = "0x20005FD")]
public class TravelInvestMenu : BaseMenu
{
	// Token: 0x06001CF0 RID: 7408 RVA: 0x0009AAC4 File Offset: 0x00098CC4
	[Token(Token = "0x6001CF0")]
	[Address(RVA = "0x520420", Offset = "0x51EA20", VA = "0x180520420", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		Time.timeScale = (float)0;
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x0009AAE0 File Offset: 0x00098CE0
	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x5211E0", Offset = "0x51F7E0", VA = "0x1805211E0")]
	private void Start()
	{
		this.RefreshOptions();
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x0009AAF4 File Offset: 0x00098CF4
	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x520620", Offset = "0x51EC20", VA = "0x180520620")]
	private void RefreshOptions()
	{
		List<InvestBuff> investBuffs2;
		int num11;
		do
		{
			int num = 0;
			List<InvestBuff> investBuffs = TravelMgr.Instance.data.investBuffs;
			InvestBuff[] enumValues = global::Core.Lawnf.GetEnumValues<InvestBuff>();
			Func<InvestBuff, bool> <>9__4_ = TravelInvestMenu.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				TravelInvestMenu.<>c.<>9__4_0 = delegate(InvestBuff a)
				{
					bool flag5;
					return flag5;
				};
			}
			List<InvestBuff> list = Enumerable.ToList<InvestBuff>(Enumerable.Where<InvestBuff>(enumValues, <>9__4_));
			List<InvestBuff> list2 = new List(list);
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = TravelMgr.Instance.GetInvestLevel((InvestBuff)num) - 1;
				if (num3 != 0)
				{
					while (num3 != 1)
					{
					}
				}
			}
			if (num2 != 0)
			{
				goto IL_01C7;
			}
			int num4 = 0;
			uint num5;
			if (global::UnityEngine.Random.Range(0, (int)num5) != 0)
			{
				Predicate<InvestBuff> predicate;
				if (TravelInvestMenu.<>c.<>9__4_1 == 0)
				{
					predicate = (InvestBuff a) => a == InvestBuff.积分大使飘飘;
					TravelInvestMenu.<>c.<>9__4_1 = predicate;
				}
				int num6 = list.RemoveAll(predicate);
			}
			bool flag2;
			if (flag2)
			{
				int num7 = list._size;
				num7 = global::UnityEngine.Random.Range(0, num7);
				InvestBuff investBuff = list[num7];
				TravelInvestMenu.<>c__DisplayClass4_0 CS$<>8__locals1;
				CS$<>8__locals1.buff = investBuff;
				Predicate<InvestBuff> predicate2 = (InvestBuff a) => a == CS$<>8__locals1.buff;
				int num8 = list.RemoveAll(predicate2);
				InvestBuff buff = CS$<>8__locals1.buff;
			}
			if (num4 != 0)
			{
				goto IL_01D9;
			}
			int num9 = 0;
			bool flag3;
			if (flag3)
			{
				TravelInvestMenu.<>c__DisplayClass4_1 CS$<>8__locals2;
				InvestBuff investBuff2;
				CS$<>8__locals2.buff = investBuff2;
				Predicate<InvestBuff> predicate3 = (InvestBuff a) => a == CS$<>8__locals2.buff;
				int num10 = list.RemoveAll(predicate3);
				InvestBuff buff2 = CS$<>8__locals2.buff;
			}
			if (num9 != 0)
			{
				goto IL_01EB;
			}
			investBuffs2 = TravelMgr.Instance.data.investBuffs;
			num11 = 0;
			bool flag4;
			if (flag4)
			{
			}
		}
		while (num11 != 0);
		int num12 = 0;
		InvestBuff investBuff3 = investBuffs2[num12];
		TravelBuffOptionButton travelBuffOptionButton;
		ulong num13;
		travelBuffOptionButton.SetBuff(investBuff3, num13 != 0UL);
		num12++;
		uint num14;
		InvestBuff investBuff4 = investBuffs2[(int)num14];
		TravelBuffOptionButton travelBuffOptionButton2;
		travelBuffOptionButton2.refreshedbuffIndex = investBuff4;
		num14 += (uint)1;
		return;
		IL_01C7:
		throw new NullReferenceException();
		IL_01D9:
		throw new NullReferenceException();
		IL_01EB:
		throw new NullReferenceException();
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x0009ACF4 File Offset: 0x00098EF4
	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x520530", Offset = "0x51EB30", VA = "0x180520530")]
	public void RefreshBuff(TravelBuffOptionButton option)
	{
		List<TravelBuffOptionButton> list = this.options;
		List<GameObject> list2 = this.refreshButton;
		int num = list.IndexOf(option);
		GameObject gameObject = list2[num];
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		InvestBuff refreshedbuffIndex = option.refreshedbuffIndex;
		option.SetBuff(refreshedbuffIndex, true);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x0009AD4C File Offset: 0x00098F4C
	[Token(Token = "0x6001CF4")]
	[Address(RVA = "0x521030", Offset = "0x51F630", VA = "0x180521030")]
	public void SelectBuff(TravelBuffOptionButton option)
	{
		TravelMgr instance = TravelMgr.Instance;
		object buff = option.buff;
		string text = instance.GetText(buff);
		if (option.set)
		{
			object buff2 = option.buff;
			InGameText instance2 = InGameText.Instance;
			int num = 0;
			instance2.ShowText(text, 3f, num != 0);
		}
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x0009ADB4 File Offset: 0x00098FB4
	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x520490", Offset = "0x51EA90", VA = "0x180520490")]
	public void Quit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x0009ADD8 File Offset: 0x00098FD8
	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x5211F0", Offset = "0x51F7F0", VA = "0x1805211F0")]
	public TravelInvestMenu()
	{
		List<TravelBuffOptionButton> list = new List();
		this.options = list;
		List<GameObject> list2 = new List();
		this.refreshButton = list2;
		base..ctor();
	}

	// Token: 0x04000F85 RID: 3973
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F85")]
	public List<TravelBuffOptionButton> options;

	// Token: 0x04000F86 RID: 3974
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F86")]
	public List<GameObject> refreshButton;
}
