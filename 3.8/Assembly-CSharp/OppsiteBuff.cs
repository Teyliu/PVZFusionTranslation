using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020005EF RID: 1519
[Token(Token = "0x20005EF")]
public class OppsiteBuff
{
	// Token: 0x06001CA0 RID: 7328 RVA: 0x00098C6C File Offset: 0x00096E6C
	[Token(Token = "0x6001CA0")]
	[Address(RVA = "0x505BC0", Offset = "0x5041C0", VA = "0x180505BC0")]
	public static void ShowConfig(Board board)
	{
		Time.timeScale = (float)0;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("请选择福祸相依的难度", 5f, num != 0);
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

	// Token: 0x06001CA1 RID: 7329 RVA: 0x00098D74 File Offset: 0x00096F74
	[Token(Token = "0x6001CA1")]
	[Address(RVA = "0x505640", Offset = "0x503C40", VA = "0x180505640")]
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

	// Token: 0x06001CA2 RID: 7330 RVA: 0x00098EB8 File Offset: 0x000970B8
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x505300", Offset = "0x503900", VA = "0x180505300")]
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
			if (global::Lawnf.TravelDebuff((TravelDebuff)num2) || TravelHelper.LeaderAppear.Contains(num2) || TravelHelper.LeaderArmor.Contains(num2) || (num2 > 23 && ((num2 > 1004 && (18446744073709549616UL <= (ulong)2L || num2 == 3001)) || 18446744073709550615UL <= (ulong)1L || num2 == 1004)) || 18446744073709551610UL <= (ulong)1L || 18446744073709551598UL <= (ulong)1L || 18446744073709551594UL > (ulong)1L)
			{
			}
			num2++;
		}
	}

	// Token: 0x06001CA3 RID: 7331 RVA: 0x00098F90 File Offset: 0x00097190
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public OppsiteBuff()
	{
	}

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	public static int optionCount;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000F50")]
	public static int refreshCount;
}
