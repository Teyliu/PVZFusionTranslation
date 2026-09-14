using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000862 RID: 2146
[Token(Token = "0x2000862")]
public class EveBuffMenu : BaseMenu
{
	// Token: 0x06002B8E RID: 11150 RVA: 0x000ECBE0 File Offset: 0x000EADE0
	[Token(Token = "0x6002B8E")]
	[Address(RVA = "0x6B22F0", Offset = "0x6B08F0", VA = "0x1806B22F0")]
	private void Start()
	{
		if (!this.look)
		{
			this.InitWindows();
			return;
		}
		List<List<EveBuff>> eveBuffs = EveManager.Instance.newEveData.eveBuffs;
		int num = this.lookRow;
		List<EveBuff> list = eveBuffs[num];
		int num2 = 0;
		EveOptionWindow eveOptionWindow = this.windows[num2];
		EveBuff eveBuff = list[num2];
		EveOptionWindow eveOptionWindow2 = this.windows[num2];
		int num3 = this.lookRow;
		eveOptionWindow2.SelectedByRow(num3);
		num2++;
		this.quitButton.SetActive(true);
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x000ECC6C File Offset: 0x000EAE6C
	[Token(Token = "0x6002B8F")]
	[Address(RVA = "0x6B17F0", Offset = "0x6AFDF0", VA = "0x1806B17F0")]
	private void LookWindow()
	{
		List<List<EveBuff>> eveBuffs = EveManager.Instance.newEveData.eveBuffs;
		int num = this.lookRow;
		List<EveBuff> list = eveBuffs[num];
		int num2 = 0;
		EveOptionWindow eveOptionWindow = this.windows[num2];
		EveBuff eveBuff = list[num2];
		EveOptionWindow eveOptionWindow2 = this.windows[num2];
		int num3 = this.lookRow;
		eveOptionWindow2.SelectedByRow(num3);
		num2++;
		this.quitButton.SetActive(true);
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x000ECCE8 File Offset: 0x000EAEE8
	[Token(Token = "0x6002B90")]
	[Address(RVA = "0x6B11B0", Offset = "0x6AF7B0", VA = "0x1806B11B0")]
	private void InitWindows()
	{
		int num3;
		do
		{
			int num = 0;
			Array values = Enum.GetValues(typeof(EveBuff));
			if (values == 0)
			{
			}
			if (values == 0)
			{
				goto IL_0110;
			}
			int num2 = 0;
			List<EveBuff> list = Enumerable.ToList<EveBuff>(values);
			List<List<EveBuff>> eveBuffs = EveManager.Instance.newEveData.eveBuffs;
			bool flag;
			if (flag)
			{
				bool flag2;
				if (flag2)
				{
					bool flag3 = list.Remove(num);
				}
				if (num2 != 0)
				{
					goto IL_011C;
				}
			}
			if (num2 != 0)
			{
				goto IL_0122;
			}
			num3 = 0;
			int size = list._size;
			bool flag4;
			if (flag4)
			{
				int num4 = list._size;
				int num5 = global::UnityEngine.Random.Range(0, num4);
				num4 = num5;
				EveBuff eveBuff = list[num4];
				num4 = num5;
				list.RemoveAt(num4);
			}
		}
		while (num3 != 0);
		int num6 = 0;
		EveManager instance = EveManager.Instance;
		EveManager.<GameUpdate>d__31 <GameUpdate>d__;
		<GameUpdate>d__.<>1__state = num6;
		<GameUpdate>d__.<>4__this = instance;
		Coroutine coroutine = instance.StartCoroutine(<GameUpdate>d__);
		instance.gameUpdate = coroutine;
		instance.SaveThePlant();
		GameObject newEveModeButton = IZBottomMenu.Instance.newEveModeButton;
		int num7 = 0;
		newEveModeButton.SetActive(num7 != 0);
		IZBottomMenu.Instance.lookBuffButton.SetActive(true);
		instance.OnGameStart();
		return;
		IL_0110:
		throw new InvalidCastException();
		IL_011C:
		throw new NullReferenceException();
		IL_0122:
		throw new NullReferenceException();
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x000ECE20 File Offset: 0x000EB020
	[Token(Token = "0x6002B91")]
	[Address(RVA = "0x6B1C60", Offset = "0x6B0260", VA = "0x1806B1C60")]
	private void PerformSelectionsAfterPlayer()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<int> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			List<int> points = EveManager.Instance.newEveData.points;
			EveBuffMenu.<>c__DisplayClass7_0 CS$<>8__locals1;
			CS$<>8__locals1.points = points;
			int selectedRow = EveManager.Instance.newEveData.selectedRow;
			bool flag = list.Remove(selectedRow);
			Func<int, int> func;
			List<int> list2 = Enumerable.ToList<int>(Enumerable.OrderBy<int, int>(list, func));
			bool flag2;
			if (flag2)
			{
				this.PerformAISelection(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x000ECEBC File Offset: 0x000EB0BC
	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x6B19F0", Offset = "0x6AFFF0", VA = "0x1806B19F0")]
	private void PerformAISelection(int row)
	{
		List<EveOptionWindow> list = this.windows;
		Func<EveOptionWindow, bool> <>9__8_ = EveBuffMenu.<>c.<>9__8_0;
		if (<>9__8_ == 0)
		{
			EveBuffMenu.<>c.<>9__8_0 = (EveOptionWindow w) => !w.selected;
		}
		List<EveOptionWindow> list2 = Enumerable.ToList<EveOptionWindow>(Enumerable.Where<EveOptionWindow>(list, <>9__8_));
		int num = list2._size;
		num = global::UnityEngine.Random.Range(0, num);
		EveOptionWindow eveOptionWindow = list2[num];
		EveManager instance = EveManager.Instance;
		NewEveData newEveData = instance.newEveData;
		EveBuff buffType = eveOptionWindow.buffType;
		newEveData.GetBuff(buffType, row);
		eveOptionWindow.SelectedByRow(row);
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x000ECF58 File Offset: 0x000EB158
	[Token(Token = "0x6002B93")]
	[Address(RVA = "0x6B2130", Offset = "0x6B0730", VA = "0x1806B2130")]
	public void SelectOption(EveOptionWindow window)
	{
		if (!this.look)
		{
			if (window.selected)
			{
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				return;
			}
			int selectedRow = EveManager.Instance.newEveData.selectedRow;
			NewEveData newEveData = EveManager.Instance.newEveData;
			EveBuff buffType = window.buffType;
			newEveData.GetBuff(buffType, selectedRow);
			window.SelectedByRow(selectedRow);
			this.PerformSelectionsAfterPlayer();
			base.Invoke("BuffOver", 3f);
		}
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x000ECFE0 File Offset: 0x000EB1E0
	[Token(Token = "0x6002B94")]
	[Address(RVA = "0x6B20B0", Offset = "0x6B06B0", VA = "0x1806B20B0")]
	private void SelectOptionGiveRow(EveOptionWindow window, int row)
	{
		NewEveData newEveData = EveManager.Instance.newEveData;
		EveBuff buffType = window.buffType;
		newEveData.GetBuff(buffType, row);
		window.SelectedByRow(row);
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x000ED014 File Offset: 0x000EB214
	[Token(Token = "0x6002B95")]
	[Address(RVA = "0x6B1050", Offset = "0x6AF650", VA = "0x1806B1050")]
	private void BuffOver()
	{
		base.PopMenu();
		EveManager instance = EveManager.Instance;
		EveManager.<GameUpdate>d__31 <GameUpdate>d__;
		<GameUpdate>d__.System.IDisposable.Dispose();
		<GameUpdate>d__.<>1__state = (int)((ulong)0L);
		<GameUpdate>d__.<>4__this = instance;
		Coroutine coroutine = instance.StartCoroutine(<GameUpdate>d__);
		instance.gameUpdate = coroutine;
		instance.SaveThePlant();
		GameObject newEveModeButton = IZBottomMenu.Instance.newEveModeButton;
		int num = 0;
		newEveModeButton.SetActive(num != 0);
		IZBottomMenu.Instance.lookBuffButton.SetActive(true);
		instance.OnGameStart();
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x000ED08C File Offset: 0x000EB28C
	[Token(Token = "0x6002B96")]
	[Address(RVA = "0x6B1960", Offset = "0x6AFF60", VA = "0x1806B1960", Slot = "8")]
	public override void OnExit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x000ED0B0 File Offset: 0x000EB2B0
	[Token(Token = "0x6002B97")]
	[Address(RVA = "0x6B2470", Offset = "0x6B0A70", VA = "0x1806B2470")]
	public EveBuffMenu()
	{
		List<EveOptionWindow> list = new List();
		this.windows = list;
		base..ctor();
	}

	// Token: 0x040019A1 RID: 6561
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019A1")]
	public List<EveOptionWindow> windows;

	// Token: 0x040019A2 RID: 6562
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019A2")]
	public bool look;

	// Token: 0x040019A3 RID: 6563
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40019A3")]
	public int lookRow;

	// Token: 0x040019A4 RID: 6564
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019A4")]
	public GameObject quitButton;
}
