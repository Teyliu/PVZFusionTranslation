using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000632 RID: 1586
[Token(Token = "0x2000632")]
public class TravelInvestMenu : BaseMenu
{
	// Token: 0x06001DEF RID: 7663 RVA: 0x0009F5E0 File Offset: 0x0009D7E0
	[Token(Token = "0x6001DEF")]
	[Address(RVA = "0x5804A0", Offset = "0x57EAA0", VA = "0x1805804A0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		Time.timeScale = (float)0;
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x0009F5FC File Offset: 0x0009D7FC
	[Token(Token = "0x6001DF0")]
	[Address(RVA = "0x581270", Offset = "0x57F870", VA = "0x180581270")]
	private void Start()
	{
		this.RefreshOptions();
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x0009F610 File Offset: 0x0009D810
	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x5806A0", Offset = "0x57ECA0", VA = "0x1805806A0")]
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

	// Token: 0x06001DF2 RID: 7666 RVA: 0x0009F810 File Offset: 0x0009DA10
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x5805B0", Offset = "0x57EBB0", VA = "0x1805805B0")]
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

	// Token: 0x06001DF3 RID: 7667 RVA: 0x0009F868 File Offset: 0x0009DA68
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x5810B0", Offset = "0x57F6B0", VA = "0x1805810B0")]
	public void SelectBuff(TravelBuffOptionButton option)
	{
		TravelMgr instance = TravelMgr.Instance;
		object buff = option.buff;
		string text = instance.GetText(buff);
		if (option.set)
		{
			object buff2 = option.buff;
			InGameText instance2 = InGameText.Instance;
		}
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x0009F8BC File Offset: 0x0009DABC
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x580510", Offset = "0x57EB10", VA = "0x180580510")]
	public void Quit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
		throw new NullReferenceException();
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x0009F8E0 File Offset: 0x0009DAE0
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x581280", Offset = "0x57F880", VA = "0x180581280")]
	public TravelInvestMenu()
	{
		List<TravelBuffOptionButton> list = new List();
		this.options = list;
		List<GameObject> list2 = new List();
		this.refreshButton = list2;
		base..ctor();
	}

	// Token: 0x0400104D RID: 4173
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400104D")]
	public List<TravelBuffOptionButton> options;

	// Token: 0x0400104E RID: 4174
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400104E")]
	public List<GameObject> refreshButton;
}
