using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000821 RID: 2081
[Token(Token = "0x2000821")]
public class IZBottomMenu : BaseMenu
{
	// Token: 0x06002A73 RID: 10867 RVA: 0x000E580C File Offset: 0x000E3A0C
	[Token(Token = "0x6002A73")]
	[Address(RVA = "0x693660", Offset = "0x691C60", VA = "0x180693660", Slot = "6")]
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

	// Token: 0x06002A74 RID: 10868 RVA: 0x000E5858 File Offset: 0x000E3A58
	[Token(Token = "0x6002A74")]
	[Address(RVA = "0x6946B0", Offset = "0x692CB0", VA = "0x1806946B0")]
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

	// Token: 0x06002A75 RID: 10869 RVA: 0x000E5960 File Offset: 0x000E3B60
	[Token(Token = "0x6002A75")]
	[Address(RVA = "0x6945F0", Offset = "0x692BF0", VA = "0x1806945F0")]
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

	// Token: 0x06002A76 RID: 10870 RVA: 0x000E59A4 File Offset: 0x000E3BA4
	[Token(Token = "0x6002A76")]
	[Address(RVA = "0x693EF0", Offset = "0x6924F0", VA = "0x180693EF0")]
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

	// Token: 0x06002A77 RID: 10871 RVA: 0x000E5A00 File Offset: 0x000E3C00
	[Token(Token = "0x6002A77")]
	[Address(RVA = "0x693C70", Offset = "0x692270", VA = "0x180693C70")]
	public void PauseGame()
	{
		UIMgr.EnterPauseMenu();
		GameAPP.music.Pause();
		GameAPP.musicDrum.Pause();
		GameAPP.prelude.audioSource.Pause();
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x000E5A40 File Offset: 0x000E3C40
	[Token(Token = "0x6002A78")]
	[Address(RVA = "0x693D30", Offset = "0x692330", VA = "0x180693D30")]
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

	// Token: 0x06002A79 RID: 10873 RVA: 0x000E5AA4 File Offset: 0x000E3CA4
	[Token(Token = "0x6002A79")]
	[Address(RVA = "0x693C40", Offset = "0x692240", VA = "0x180693C40")]
	public void NormalMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A7A RID: 10874 RVA: 0x000E5AD0 File Offset: 0x000E3CD0
	[Token(Token = "0x6002A7A")]
	[Address(RVA = "0x6939F0", Offset = "0x691FF0", VA = "0x1806939F0")]
	public void EveMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.eveModeButton.SetActive(true);
		EveManager.Instance.StartEveMode();
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x000E5B0C File Offset: 0x000E3D0C
	[Token(Token = "0x6002A7B")]
	[Address(RVA = "0x693970", Offset = "0x691F70", VA = "0x180693970")]
	public void EditMode()
	{
		GameObject gameObject = this.switchModeButton;
		int num = 0;
		gameObject.SetActive(num != 0);
		this.customModeButton.SetActive(true);
		EveManager.Instance.StartEveMode();
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x000E5B48 File Offset: 0x000E3D48
	[Token(Token = "0x6002A7C")]
	[Address(RVA = "0x693A70", Offset = "0x692070", VA = "0x180693A70")]
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
	}

	// Token: 0x06002A7D RID: 10877 RVA: 0x000E5BC8 File Offset: 0x000E3DC8
	[Token(Token = "0x6002A7D")]
	[Address(RVA = "0x693770", Offset = "0x691D70", VA = "0x180693770")]
	public void Balance()
	{
		Board instance = Board.Instance;
		Board instance2 = Board.Instance;
		bool flag = !instance.evebalance;
		instance2.evebalance = flag;
		InGameText instance3 = InGameText.Instance;
		Board instance4 = Board.Instance;
		if (instance4.evebalance)
		{
		}
	}

	// Token: 0x06002A7E RID: 10878 RVA: 0x000E5C24 File Offset: 0x000E3E24
	[Token(Token = "0x6002A7E")]
	[Address(RVA = "0x693FF0", Offset = "0x6925F0", VA = "0x180693FF0")]
	private void SetLevelName()
	{
		if (GameAPP.theBoardLevel <= 26)
		{
			this.ChangeString("我是僵尸！");
			return;
		}
		this.ChangeString("挑战模式");
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x000E5DE8 File Offset: 0x000E3FE8
	[Token(Token = "0x6002A7F")]
	[Address(RVA = "0x693840", Offset = "0x691E40", VA = "0x180693840")]
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

	// Token: 0x06002A80 RID: 10880 RVA: 0x000E5E14 File Offset: 0x000E4014
	[Token(Token = "0x6002A80")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public IZBottomMenu()
	{
	}

	// Token: 0x04001863 RID: 6243
	[Token(Token = "0x4001863")]
	public static IZBottomMenu Instance;

	// Token: 0x04001864 RID: 6244
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001864")]
	public GameObject zombieLibary;

	// Token: 0x04001865 RID: 6245
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001865")]
	public GameObject plantLibrary;

	// Token: 0x04001866 RID: 6246
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001866")]
	public GameObject switchModeButton;

	// Token: 0x04001867 RID: 6247
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001867")]
	public GameObject eveModeButton;

	// Token: 0x04001868 RID: 6248
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001868")]
	public GameObject newEveModeButton;

	// Token: 0x04001869 RID: 6249
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001869")]
	public GameObject customModeButton;

	// Token: 0x0400186A RID: 6250
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400186A")]
	public GameObject lookBuffButton;

	// Token: 0x0400186B RID: 6251
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400186B")]
	public List<TextMeshProUGUI> levelName;
}
