using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000826 RID: 2086
[Token(Token = "0x2000826")]
public class EveBuffMenu : BaseMenu
{
	// Token: 0x06002A5C RID: 10844 RVA: 0x000E7DA4 File Offset: 0x000E5FA4
	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0x64E540", Offset = "0x64CB40", VA = "0x18064E540")]
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

	// Token: 0x06002A5D RID: 10845 RVA: 0x000E7E30 File Offset: 0x000E6030
	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0x64DA50", Offset = "0x64C050", VA = "0x18064DA50")]
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

	// Token: 0x06002A5E RID: 10846 RVA: 0x000E7EAC File Offset: 0x000E60AC
	[Token(Token = "0x6002A5E")]
	[Address(RVA = "0x64D410", Offset = "0x64BA10", VA = "0x18064D410")]
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

	// Token: 0x06002A5F RID: 10847 RVA: 0x000E7FE4 File Offset: 0x000E61E4
	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x64DEC0", Offset = "0x64C4C0", VA = "0x18064DEC0")]
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

	// Token: 0x06002A60 RID: 10848 RVA: 0x000E8080 File Offset: 0x000E6280
	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x64DC50", Offset = "0x64C250", VA = "0x18064DC50")]
	private void PerformAISelection(int row)
	{
		List<EveOptionWindow> list = this.windows;
		Func<EveOptionWindow, bool> <>9__8_ = EveBuffMenu.<>c.<>9__8_0;
		if (<>9__8_ == 0)
		{
			Func<EveOptionWindow, bool> func;
			EveBuffMenu.<>c.<>9__8_0 = func;
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

	// Token: 0x06002A61 RID: 10849 RVA: 0x000E8110 File Offset: 0x000E6310
	[Token(Token = "0x6002A61")]
	[Address(RVA = "0x64E390", Offset = "0x64C990", VA = "0x18064E390")]
	public void SelectOption(EveOptionWindow window)
	{
		if (!this.look)
		{
			if (window.selected)
			{
				GameAPP.PlaySound(26, 0.5f, 1f);
				InGameText instance = InGameText.Instance;
				int num = 0;
				instance.ShowText("这个词条已经被其他路选择", 3f, num != 0);
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

	// Token: 0x06002A62 RID: 10850 RVA: 0x000E81B0 File Offset: 0x000E63B0
	[Token(Token = "0x6002A62")]
	[Address(RVA = "0x64E310", Offset = "0x64C910", VA = "0x18064E310")]
	private void SelectOptionGiveRow(EveOptionWindow window, int row)
	{
		NewEveData newEveData = EveManager.Instance.newEveData;
		EveBuff buffType = window.buffType;
		newEveData.GetBuff(buffType, row);
		window.SelectedByRow(row);
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x000E81E4 File Offset: 0x000E63E4
	[Token(Token = "0x6002A63")]
	[Address(RVA = "0x64D2B0", Offset = "0x64B8B0", VA = "0x18064D2B0")]
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

	// Token: 0x06002A64 RID: 10852 RVA: 0x000E825C File Offset: 0x000E645C
	[Token(Token = "0x6002A64")]
	[Address(RVA = "0x64DBC0", Offset = "0x64C1C0", VA = "0x18064DBC0", Slot = "8")]
	public override void OnExit()
	{
		Time.timeScale = GameAPP.config.gameSpeed;
	}

	// Token: 0x06002A65 RID: 10853 RVA: 0x000E8280 File Offset: 0x000E6480
	[Token(Token = "0x6002A65")]
	[Address(RVA = "0x64E6C0", Offset = "0x64CCC0", VA = "0x18064E6C0")]
	public EveBuffMenu()
	{
		List<EveOptionWindow> list = new List();
		this.windows = list;
		base..ctor();
	}

	// Token: 0x040018B3 RID: 6323
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018B3")]
	public List<EveOptionWindow> windows;

	// Token: 0x040018B4 RID: 6324
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018B4")]
	public bool look;

	// Token: 0x040018B5 RID: 6325
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40018B5")]
	public int lookRow;

	// Token: 0x040018B6 RID: 6326
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018B6")]
	public GameObject quitButton;
}
