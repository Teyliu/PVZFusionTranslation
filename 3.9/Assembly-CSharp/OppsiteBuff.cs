using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000624 RID: 1572
[Token(Token = "0x2000624")]
public class OppsiteBuff
{
	// Token: 0x06001D9F RID: 7583 RVA: 0x0009D7BC File Offset: 0x0009B9BC
	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x5712D0", Offset = "0x56F8D0", VA = "0x1805712D0")]
	public static void ShowConfig(Board board)
	{
		Time.timeScale = (float)0;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		InGameText instance = InGameText.Instance;
		if (OppsiteBuff.<>c.<>9__2_0 == 0)
		{
			OppsiteBuff.<>c.<>9__2_0 = delegate
			{
			};
		}
		if (OppsiteBuff.<>c.<>9__2_1 == 0)
		{
			OppsiteBuff.<>c.<>9__2_1 = delegate
			{
			};
		}
		if (OppsiteBuff.<>c.<>9__2_2 == 0)
		{
			OppsiteBuff.<>c.<>9__2_2 = delegate
			{
			};
		}
		if (OppsiteBuff.<>c.<>9__2_4 == 0)
		{
			OppsiteBuff.<>c.<>9__2_4 = delegate
			{
				Time.timeScale = GameAPP.config.gameSpeed;
			};
		}
		Delegate @delegate;
		if (@delegate == 0)
		{
		}
		if (@delegate != 0 && @delegate != 0)
		{
			UnityEvent dieEvent = board.DieEvent;
			UnityAction unityAction;
			if (OppsiteBuff.<>c.<>9__2_3 == 0)
			{
				unityAction = delegate
				{
				};
				OppsiteBuff.<>c.<>9__2_3 = unityAction;
			}
			dieEvent.AddListener(unityAction);
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x0009D8B0 File Offset: 0x0009BAB0
	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x570D50", Offset = "0x56F350", VA = "0x180570D50")]
	public static void ShowChoice()
	{
		int num = 0;
		uint num2;
		GameAPP.theGameStatus = (GameStatus)num2;
		Time.timeScale = (float)num;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		int num3 = 0;
		BaseMenu baseMenu;
		if (baseMenu == 0)
		{
		}
		int num4 = OppsiteBuff.optionCount;
		bool flag = OppsiteBuff.refreshCount != 0;
		List<object> list = new List();
		List<object> list2 = new List();
		int num5 = 0;
		OppsiteBuff.InitBuffPool(list, list2);
		int num6 = OppsiteBuff.refreshCount;
		num6++;
		if (num3 < num6)
		{
			int num7 = 0;
			OppsiteBuff.<>c__DisplayClass3_0 CS$<>8__locals1;
			ulong num8;
			CS$<>8__locals1.FieldGetter(num7, num5, num8);
			object randomAndRemove = ListExtensions.GetRandomAndRemove<object>(list);
			CS$<>8__locals1.goodBuff = randomAndRemove;
			object randomAndRemove2 = ListExtensions.GetRandomAndRemove<object>(list2);
			CS$<>8__locals1.badBuff = randomAndRemove2;
			TravelMgr instance = TravelMgr.Instance;
			object goodBuff = CS$<>8__locals1.goodBuff;
			string text = instance.GetText(goodBuff);
			TravelMgr instance2 = TravelMgr.Instance;
			object badBuff = CS$<>8__locals1.badBuff;
			string text2 = instance2.GetText(badBuff);
			string text3 = text + "\n\n但" + text2;
			UnityAction unityAction = delegate
			{
				object goodBuff2 = CS$<>8__locals1.goodBuff;
				if (goodBuff2 != 0)
				{
					if (goodBuff2 != 0)
					{
						TravelMgr instance3 = TravelMgr.Instance;
						throw new InvalidCastException();
					}
					if (goodBuff2 != 0)
					{
						TravelMgr instance4 = TravelMgr.Instance;
					}
				}
				object badBuff2 = CS$<>8__locals1.badBuff;
				if (badBuff2 != 0 && badBuff2 != 0)
				{
					TravelMgr instance5 = TravelMgr.Instance;
				}
			};
			if (OppsiteBuff.<>c.<>9__3_1 == 0)
			{
				OppsiteBuff.<>c.<>9__3_1 = delegate
				{
					Time.timeScale = GameAPP.config.gameSpeed;
				};
			}
			Delegate @delegate;
			if (@delegate == 0)
			{
				num3++;
			}
			if (@delegate == 0)
			{
				throw new InvalidCastException();
			}
			if (@delegate == 0)
			{
				throw new InvalidCastException();
			}
			num3++;
		}
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x0009D9F4 File Offset: 0x0009BBF4
	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x570A10", Offset = "0x56F010", VA = "0x180570A10")]
	private static void InitBuffPool(List<object> goodPool, List<object> badPool)
	{
		TravelMgr instance = TravelMgr.Instance;
		int num = 0;
		List<AdvBuff> advancedBuffPool = instance.GetAdvancedBuffPool(num != 0);
		UltiBuff[] enumValues = global::Core.Lawnf.GetEnumValues<UltiBuff>();
		int num2 = 0;
		if (num2 < enumValues.Length)
		{
			bool flag;
			if (!flag)
			{
			}
			num2++;
		}
		TravelDebuff[] enumValues2 = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
		if (num2 < enumValues2.Length)
		{
			if (global::Lawnf.TravelDebuff((TravelDebuff)num2) || num2 >= 10000 || TravelHelper.LeaderAppear.Contains(num2) || TravelHelper.LeaderArmor.Contains(num2) || (num2 > 23 && ((num2 > 1004 && (18446744073709549616UL <= (ulong)2L || num2 == 3001)) || 18446744073709550615UL <= (ulong)1L || num2 == 1004)) || 18446744073709551610UL <= (ulong)1L || 18446744073709551598UL <= (ulong)1L || 18446744073709551594UL > (ulong)1L)
			{
			}
			num2++;
		}
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public OppsiteBuff()
	{
	}

	// Token: 0x04001017 RID: 4119
	[Token(Token = "0x4001017")]
	public static int optionCount;

	// Token: 0x04001018 RID: 4120
	[Token(Token = "0x4001018")]
	public static int refreshCount;
}
