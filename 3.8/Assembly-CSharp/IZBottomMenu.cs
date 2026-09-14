using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007E6 RID: 2022
[Token(Token = "0x20007E6")]
public class IZBottomMenu : BaseMenu
{
	// Token: 0x0600293D RID: 10557 RVA: 0x000E0694 File Offset: 0x000DE894
	[Token(Token = "0x600293D")]
	[Address(RVA = "0x62F8B0", Offset = "0x62DEB0", VA = "0x18062F8B0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		IZBottomMenu.Instance = this;
		this.SetLevelName();
		GameObject gameObject = this.switchModeButton;
		bool flag = "{il2cpp field on {'constant22' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x98}" == (ulong)1L;
		gameObject.SetActive(flag);
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x000E06E0 File Offset: 0x000DE8E0
	[Token(Token = "0x600293E")]
	[Address(RVA = "0x6308E0", Offset = "0x62EEE0", VA = "0x1806308E0")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)27)))
		{
			if (this.zombieLibary.activeSelf)
			{
				GameObject gameObject = this.zombieLibary;
				int num = 0;
				gameObject.SetActive(num != 0);
				Transform transform = InGameUI_IZ.Instance.transform;
				Transform canvas = GameAPP.canvas;
				transform.parentInternal = canvas;
				Time.timeScale = GameAPP.config.gameSpeed;
				CursorChange.SetDefaultCursor();
			}
			if (this.plantLibrary.activeSelf)
			{
				GameObject gameObject2 = this.plantLibrary;
				int num2 = 0;
				gameObject2.SetActive(num2 != 0);
				Transform transform2 = InGameUI_IZ.Instance.transform;
				Transform canvas2 = GameAPP.canvas;
				transform2.parentInternal = canvas2;
				Time.timeScale = GameAPP.config.gameSpeed;
				CursorChange.SetDefaultCursor();
			}
		}
		if (Input.GetKeyDownInt((KeyCode)((uint)27)) || Input.GetKeyDownInt((KeyCode)((uint)32)))
		{
			UIMgr.EnterPauseMenu();
			GameAPP.music.Pause();
			GameAPP.musicDrum.Pause();
			GameAPP.prelude.audioSource.Pause();
			return;
		}
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x000E07E8 File Offset: 0x000DE9E8
	[Token(Token = "0x600293F")]
	[Address(RVA = "0x630820", Offset = "0x62EE20", VA = "0x180630820")]
	public void SetSun(TMP_InputField field)
	{
		ulong num;
		if (!int.TryParse(field.m_Text, (int)num))
		{
			field.text = "0";
			return;
		}
		field.text = "0";
		ulong num2;
		Board.Instance.theSun = (int)num2;
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000E082C File Offset: 0x000DEA2C
	[Token(Token = "0x6002940")]
	[Address(RVA = "0x630120", Offset = "0x62E720", VA = "0x180630120")]
	public void SetDropSun(TMP_InputField field)
	{
		ulong num;
		if (!int.TryParse(field.m_Text, (int)num))
		{
			field.text = "0";
			return;
		}
		field.text = "0";
		ulong num2;
		if (num2 > (ulong)64L)
		{
			field.text = "64";
		}
		ulong num3;
		Board.Instance.config.izDropCount = (int)num3;
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x000E0888 File Offset: 0x000DEA88
	[Token(Token = "0x6002941")]
	[Address(RVA = "0x62FEA0", Offset = "0x62E4A0", VA = "0x18062FEA0")]
	public void PauseGame()
	{
		UIMgr.EnterPauseMenu();
		GameAPP.music.Pause();
		GameAPP.musicDrum.Pause();
		GameAPP.prelude.audioSource.Pause();
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x000E08C8 File Offset: 0x000DEAC8
	[Token(Token = "0x6002942")]
	[Address(RVA = "0x62FF60", Offset = "0x62E560", VA = "0x18062FF60")]
	public void SelectAll()
	{
		ulong num4;
		do
		{
			int num = 0;
			Transform transform = this.zombieLibary.transform;
			int num2 = 0;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(transform.GetChild(num2));
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				InGameUI_IZ instance = InGameUI_IZ.Instance;
				int num3 = 0;
				bool flag3 = instance.AddCardToBank(num, num3 != 0);
			}
		}
		while (num4 != (ulong)0L);
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000E092C File Offset: 0x000DEB2C
	[Token(Token = "0x6002943")]
	[Address(RVA = "0x62FE70", Offset = "0x62E470", VA = "0x18062FE70")]
	public void NormalMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000E0958 File Offset: 0x000DEB58
	[Token(Token = "0x6002944")]
	[Address(RVA = "0x62FC30", Offset = "0x62E230", VA = "0x18062FC30")]
	public void EveMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.eveModeButton.SetActive(true);
		EveManager.Instance.StartEveMode();
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x000E0994 File Offset: 0x000DEB94
	[Token(Token = "0x6002945")]
	[Address(RVA = "0x62FBB0", Offset = "0x62E1B0", VA = "0x18062FBB0")]
	public void EditMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.customModeButton.SetActive(true);
		EveManager.Instance.StartEveMode();
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x000E09D0 File Offset: 0x000DEBD0
	[Token(Token = "0x6002946")]
	[Address(RVA = "0x62FCB0", Offset = "0x62E2B0", VA = "0x18062FCB0")]
	public void NewEveMode()
	{
		if (Board.Instance.sceneType == SceneType.IZDay)
		{
			GameObject gameObject = this.switchModeButton;
			int num = 0;
			gameObject.SetActive(num != 0);
			this.newEveModeButton.SetActive(true);
			EveManager.Instance.StartNewEveMode();
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("该模式仅在默认地图可用", 5f, num2 != 0);
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x000E0A78 File Offset: 0x000DEC78
	[Token(Token = "0x6002947")]
	[Address(RVA = "0x62F9C0", Offset = "0x62DFC0", VA = "0x18062F9C0")]
	public void Balance()
	{
		Board instance = Board.Instance;
		Board instance2 = Board.Instance;
		bool flag = !instance.evebalance;
		instance2.evebalance = flag;
		InGameText instance3 = InGameText.Instance;
		Board instance4 = Board.Instance;
		string text = "已关闭";
		if (instance4.evebalance)
		{
			text = "已开启";
		}
		int num = 0;
		instance3.ShowText(text, 5f, num != 0);
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x000E0AE4 File Offset: 0x000DECE4
	[Token(Token = "0x6002948")]
	[Address(RVA = "0x630220", Offset = "0x62E820", VA = "0x180630220")]
	private void SetLevelName()
	{
		if (GameAPP.theBoardLevel <= 26)
		{
			this.ChangeString("我是僵尸！");
			return;
		}
		this.ChangeString("挑战模式");
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000E0CA8 File Offset: 0x000DEEA8
	[Token(Token = "0x6002949")]
	[Address(RVA = "0x62FA80", Offset = "0x62E080", VA = "0x18062FA80")]
	public void ChangeString(string name)
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.levelName;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x000E0CD4 File Offset: 0x000DEED4
	[Token(Token = "0x600294A")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public IZBottomMenu()
	{
	}

	// Token: 0x0400177A RID: 6010
	[Token(Token = "0x400177A")]
	public static IZBottomMenu Instance;

	// Token: 0x0400177B RID: 6011
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400177B")]
	public GameObject zombieLibary;

	// Token: 0x0400177C RID: 6012
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400177C")]
	public GameObject plantLibrary;

	// Token: 0x0400177D RID: 6013
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400177D")]
	public GameObject switchModeButton;

	// Token: 0x0400177E RID: 6014
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400177E")]
	public GameObject eveModeButton;

	// Token: 0x0400177F RID: 6015
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400177F")]
	public GameObject newEveModeButton;

	// Token: 0x04001780 RID: 6016
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001780")]
	public GameObject customModeButton;

	// Token: 0x04001781 RID: 6017
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001781")]
	public GameObject lookBuffButton;

	// Token: 0x04001782 RID: 6018
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001782")]
	public List<TextMeshProUGUI> levelName;
}
