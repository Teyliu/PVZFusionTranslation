using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200086C RID: 2156
[Token(Token = "0x200086C")]
public class SaveMenu : BaseMenu
{
	// Token: 0x06002C0C RID: 11276 RVA: 0x000F1D7C File Offset: 0x000EFF7C
	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x671D90", Offset = "0x670390", VA = "0x180671D90", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		SaveMenu.Instance = this;
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000F1D98 File Offset: 0x000EFF98
	[Token(Token = "0x170001BE")]
	private string LevelName
	{
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x673880", Offset = "0x671E80", VA = "0x180673880")]
		get
		{
			SurvivalLevel survivalLevel = this.level;
			return string.Format("level{0}", survivalLevel);
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000F1DB8 File Offset: 0x000EFFB8
	[Token(Token = "0x170001BF")]
	private string LevelNameWithJson
	{
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x673810", Offset = "0x671E10", VA = "0x180673810")]
		get
		{
			SurvivalLevel survivalLevel = this.level;
			return string.Format("level{0}.json", survivalLevel);
		}
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x000F1DD8 File Offset: 0x000EFFD8
	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x6736D0", Offset = "0x671CD0", VA = "0x1806736D0")]
	private void Start()
	{
		this.BindingButtonEvents();
		this.InitLevelSaveEnters();
		GameObject gameObject = this.StartNewGameButton.gameObject;
		bool flag = !this.saveMode;
		gameObject.SetActive(flag);
		GameObject gameObject2 = this.EnterSelectedButton.gameObject;
		bool flag2 = !this.saveMode;
		gameObject2.SetActive(flag2);
		GameObject gameObject3 = this.DeleteSelectedButton.gameObject;
		bool flag3 = !this.saveMode;
		gameObject3.SetActive(flag3);
		GameObject gameObject4 = this.EditSelectedButton.gameObject;
		bool flag4 = !this.saveMode;
		gameObject4.SetActive(flag4);
		GameObject gameObject5 = this.CoverSelectedButton.gameObject;
		bool flag5 = this.saveMode;
		gameObject5.SetActive(flag5);
		GameObject gameObject6 = this.SaveAsNewButton.gameObject;
		bool flag6 = this.saveMode;
		gameObject6.SetActive(flag6);
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x000F1EB0 File Offset: 0x000F00B0
	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x671DF0", Offset = "0x6703F0", VA = "0x180671DF0")]
	private void BindingButtonEvents()
	{
		UnityEvent theEvent_up = this.StartNewGameButton.theEvent_up;
		UnityAction unityAction = new UnityAction(this.OnStartGameButtonClicked);
		theEvent_up.AddListener(unityAction);
		UnityEvent theEvent_up2 = this.EnterSelectedButton.theEvent_up;
		UnityAction unityAction2 = new UnityAction(this.OnEnterSelectedButtonClicked);
		theEvent_up2.AddListener(unityAction2);
		UnityEvent theEvent_up3 = this.DeleteSelectedButton.theEvent_up;
		UnityAction unityAction3 = new UnityAction(this.OnDeleteSelectedButtonClicked);
		theEvent_up3.AddListener(unityAction3);
		UnityEvent theEvent_up4 = this.EditSelectedButton.theEvent_up;
		UnityAction unityAction4 = new UnityAction(this.OnEditSelectedButtonClicked);
		theEvent_up4.AddListener(unityAction4);
		UnityEvent theEvent_up5 = this.ExitButton.theEvent_up;
		UnityAction unityAction5 = new UnityAction(this.OnExitButtonClicked);
		theEvent_up5.AddListener(unityAction5);
		UnityEvent theEvent_up6 = this.CoverSelectedButton.theEvent_up;
		UnityAction unityAction6 = new UnityAction(this.OnCoverSelectedButtonClicked);
		theEvent_up6.AddListener(unityAction6);
		UnityEvent theEvent_up7 = this.SaveAsNewButton.theEvent_up;
		UnityAction unityAction7 = new UnityAction(this.OnSaveAsNewButtonClicked);
		theEvent_up7.AddListener(unityAction7);
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x000F1FB8 File Offset: 0x000F01B8
	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x673640", Offset = "0x671C40", VA = "0x180673640")]
	public void OnStartGameButtonClicked()
	{
		SaveMgr.ClearBoard((int)this.level);
		UnityEvent unityEvent = this.actionOnCreateNewLevel;
		if (unityEvent != 0)
		{
			unityEvent.Invoke();
		}
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x000F1FEC File Offset: 0x000F01EC
	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x6730F0", Offset = "0x6716F0", VA = "0x1806730F0")]
	public void OnEnterSelectedButtonClicked()
	{
		LevelSaveEnter levelSaveEnter = this.selectedLevel;
		int num = 0;
		if (!(levelSaveEnter == num))
		{
			this.selectedLevel.EnterGame();
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("你还没有选中任何存档", 3f, num2 != 0);
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x000F204C File Offset: 0x000F024C
	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x672EF0", Offset = "0x6714F0", VA = "0x180672EF0")]
	public void OnDeleteSelectedButtonClicked()
	{
		LevelSaveEnter levelSaveEnter = this.selectedLevel;
		int num = 0;
		if (!(levelSaveEnter == num))
		{
			this.selectedLevel.DeleteLevel();
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("你还没有选中任何存档", 3f, num2 != 0);
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x000F20AC File Offset: 0x000F02AC
	[Token(Token = "0x6002C14")]
	[Address(RVA = "0x672FF0", Offset = "0x6715F0", VA = "0x180672FF0")]
	public void OnEditSelectedButtonClicked()
	{
		LevelSaveEnter levelSaveEnter = this.selectedLevel;
		int num = 0;
		if (!(levelSaveEnter == num))
		{
			this.selectedLevel.EditLevel();
			return;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num2 = 0;
		instance.ShowText("你还没有选中任何存档", 3f, num2 != 0);
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x000F210C File Offset: 0x000F030C
	[Token(Token = "0x6002C15")]
	[Address(RVA = "0x672C50", Offset = "0x671250", VA = "0x180672C50")]
	public void OnCoverSelectedButtonClicked()
	{
		LevelSaveEnter levelSaveEnter = this.selectedLevel;
		int num = 0;
		if (!(levelSaveEnter == num))
		{
			this.selectedLevel.DeleteLevel();
			int id = this.selectedLevel.id;
			SaveInfo instance = SaveInfo.Instance;
			SurvivalData survivalData;
			if (survivalData != 0 && survivalData.boardData.isBoardSaved)
			{
				SaveInfo instance2 = SaveInfo.Instance;
				string path = this.selectedLevel.path;
				this.CreateLevelEnter(survivalData, id, path).transform.SetAsFirstSibling();
				InGameText instance3 = InGameText.Instance;
				int num2 = 0;
				instance3.ShowText("覆盖成功", 3f, num2 != 0);
				return;
			}
			GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance5 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x000F21F0 File Offset: 0x000F03F0
	[Token(Token = "0x6002C16")]
	[Address(RVA = "0x673310", Offset = "0x671910", VA = "0x180673310")]
	public void OnSaveAsNewButtonClicked()
	{
		int num = 0;
		string dataPath = SaveInfo.GetDataPath();
		SurvivalLevel survivalLevel = this.level;
		string text = string.Format("level{0}", "level{0}");
		int num2;
		string text2 = string.Format("Player/Saves/{0}_{1}.json", text, num2);
		string text3 = Path.Combine(dataPath, text2);
		if (File.Exists(text3))
		{
			num++;
			InGameText instance = InGameText.Instance;
			int num3 = 0;
			instance.ShowText("存档数量已达上限", 3f, num3 != 0);
			return;
		}
		SaveInfo instance2 = SaveInfo.Instance;
		SurvivalData survivalData;
		if (survivalData != 0 && (survivalData.boardData.isBoardSaved ? 1 : 0) != num)
		{
			SaveInfo instance3 = SaveInfo.Instance;
			InGameText instance4 = InGameText.Instance;
			int num4;
			string text4 = string.Format("保存成功，编号：{0}", num4);
			int num5 = 0;
			instance4.ShowText(text4, 3f, num5 != 0);
			this.CreateLevelEnter(survivalData, num, text3).transform.SetAsFirstSibling();
			return;
		}
		GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
		InGameText instance5 = InGameText.Instance;
		int num6 = 0;
		instance5.ShowText("现在还不能存档", 3f, num6 != 0);
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x000F2304 File Offset: 0x000F0504
	[Token(Token = "0x6002C17")]
	[Address(RVA = "0x6731F0", Offset = "0x6717F0", VA = "0x1806731F0")]
	public void OnExitButtonClicked()
	{
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x000F2314 File Offset: 0x000F0514
	[Token(Token = "0x6002C18")]
	[Address(RVA = "0x673210", Offset = "0x671810", VA = "0x180673210")]
	public void OnLevelEnterClicked(LevelSaveEnter enter)
	{
		if (!(this.selectedLevel == enter))
		{
			LevelSaveEnter levelSaveEnter = this.selectedLevel;
			int num = 0;
			if (levelSaveEnter != num)
			{
				GameObject outLine = this.selectedLevel.outLine;
				int num2 = 0;
				outLine.SetActive(num2 != 0);
			}
			this.selectedLevel = enter;
			this.selectedLevel.outLine.SetActive(true);
		}
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x000F2378 File Offset: 0x000F0578
	[Token(Token = "0x6002C19")]
	[Address(RVA = "0x6724D0", Offset = "0x670AD0", VA = "0x1806724D0")]
	public void InitLevelSaveEnters()
	{
		ulong num6;
		do
		{
			int num = 0;
			if ((this.saveMode ? 1 : 0) == num)
			{
				string dataPath = SaveInfo.GetDataPath();
				SurvivalLevel survivalLevel = this.level;
				string text = string.Format("level{0}.json", survivalLevel);
				string text2 = Path.Combine(dataPath, text);
				if (!File.Exists(text2))
				{
				}
				SurvivalData survivalData = JsonUtility.FromJson<SurvivalData>(File.ReadAllText(text2));
				if (!survivalData.boardData.isBoardSaved)
				{
					Debug.Log(text2 + "这个存档无效");
				}
				string dataPath2 = SaveInfo.GetDataPath();
				string levelNameWithJson = this.LevelNameWithJson;
				string text3 = Path.Combine(dataPath2, levelNameWithJson);
				uint num2;
				LevelSaveEnter levelSaveEnter = this.CreateLevelEnter(survivalData, (int)num2, text3);
			}
			string text4 = Path.Combine(SaveInfo.GetDataPath(), "Player/Saves");
			List<LevelSaveEnter> list = new List();
			if (Directory.Exists(text4))
			{
				string[] files = Directory.GetFiles(text4, "*.json");
				int num3 = 0;
				int num4 = 0;
				if (num4 < files.Length)
				{
					SurvivalLevel survivalLevel2 = this.level;
					string text5 = string.Format("level{0}", "level{0}");
					string text6;
					if (text6.Contains(text5))
					{
						SurvivalData survivalData2 = JsonUtility.FromJson<SurvivalData>(File.ReadAllText(text6));
						if (survivalData2 != 0 && survivalData2.boardData.isBoardSaved)
						{
							int num5 = int.Parse(text6.GetSecondNumber());
							num3++;
						}
					}
					num3++;
				}
			}
			Func<LevelSaveEnter, long> func;
			if (SaveMenu.<>c.<>9__29_0 == 0)
			{
				SaveMenu.<>c.<>9__29_0 = func;
			}
			List<LevelSaveEnter> list2 = Enumerable.ToList<LevelSaveEnter>(Enumerable.OrderByDescending<LevelSaveEnter, long>(list, func));
			bool flag;
			if (flag)
			{
				Transform transform;
				transform.SetAsLastSibling();
			}
		}
		while (num6 != (ulong)0L);
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x000F2514 File Offset: 0x000F0714
	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0x6720A0", Offset = "0x6706A0", VA = "0x1806720A0")]
	private LevelSaveEnter CreateLevelEnter(SurvivalData data, int id, string path)
	{
		ulong num;
		this.sampleLevel.gameObject.SetActive(num != 0UL);
		LevelSaveEnter levelSaveEnter = this.sampleLevel;
		Transform parent = levelSaveEnter.transform.parent;
		LevelSaveEnter levelSaveEnter2 = global::UnityEngine.Object.Instantiate<LevelSaveEnter>(levelSaveEnter, parent);
		LevelSaveEnter levelEnter = levelSaveEnter2;
		levelEnter.id = id;
		LevelSaveEnter levelEnter3 = levelEnter;
		SurvivalLevel survivalLevel = this.level;
		levelEnter3.level = survivalLevel;
		levelEnter.data = data;
		levelEnter.path = path;
		levelEnter.InitEnter();
		UnityEvent theEvent = levelEnter.theEvent;
		UnityAction unityAction = delegate
		{
			SaveMenu <>4__this = this;
			LevelSaveEnter levelEnter2 = levelEnter;
			if (!(<>4__this.selectedLevel == levelEnter2))
			{
				LevelSaveEnter levelSaveEnter3 = <>4__this.selectedLevel;
				int num3 = 0;
				if (levelSaveEnter3 != num3)
				{
					GameObject outLine = <>4__this.selectedLevel.outLine;
					int num4 = 0;
					outLine.SetActive(num4 != 0);
				}
				<>4__this.selectedLevel = levelEnter2;
				<>4__this.selectedLevel.outLine.SetActive(true);
			}
		};
		theEvent.AddListener(unityAction);
		Debug.Log(string.Format("创建存档数据，id：{0}，路径：{1}", unityAction, path));
		GameObject gameObject = this.sampleLevel.gameObject;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
		return levelEnter;
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x000F2608 File Offset: 0x000F0808
	[Token(Token = "0x6002C1B")]
	[Address(RVA = "0x672360", Offset = "0x670960", VA = "0x180672360")]
	private SurvivalData GetFirstSave()
	{
		string dataPath = SaveInfo.GetDataPath();
		SurvivalLevel survivalLevel = this.level;
		string text = string.Format("level{0}.json", "level{0}.json");
		string text2 = Path.Combine(dataPath, text);
		if (!File.Exists(text2))
		{
		}
		if (!JsonUtility.FromJson<SurvivalData>(File.ReadAllText(text2)).boardData.isBoardSaved)
		{
			Debug.Log(text2 + "这个存档无效");
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x000F267C File Offset: 0x000F087C
	[Token(Token = "0x6002C1C")]
	[Address(RVA = "0x672B40", Offset = "0x671140", VA = "0x180672B40")]
	public static void InitSaveMenu(SurvivalLevel level, bool saveMode = false)
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)30), canvasUp, num != 0);
		if (saveMode)
		{
		}
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x000F26B4 File Offset: 0x000F08B4
	[Token(Token = "0x6002C1D")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public SaveMenu()
	{
	}

	// Token: 0x04001A2B RID: 6699
	[Token(Token = "0x4001A2B")]
	public static SaveMenu Instance;

	// Token: 0x04001A2C RID: 6700
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A2C")]
	public SurvivalLevel level;

	// Token: 0x04001A2D RID: 6701
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A2D")]
	public TextMeshProUGUI menuTitle;

	// Token: 0x04001A2E RID: 6702
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001A2E")]
	[Header("按钮")]
	public TheButton StartNewGameButton;

	// Token: 0x04001A2F RID: 6703
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001A2F")]
	public TheButton EnterSelectedButton;

	// Token: 0x04001A30 RID: 6704
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001A30")]
	public TheButton DeleteSelectedButton;

	// Token: 0x04001A31 RID: 6705
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001A31")]
	public TheButton EditSelectedButton;

	// Token: 0x04001A32 RID: 6706
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001A32")]
	public TheButton CoverSelectedButton;

	// Token: 0x04001A33 RID: 6707
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001A33")]
	public TheButton SaveAsNewButton;

	// Token: 0x04001A34 RID: 6708
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A34")]
	public TheButton ExitButton;

	// Token: 0x04001A35 RID: 6709
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A35")]
	[Header("点击事件")]
	public UnityEvent actionOnCreateNewLevel;

	// Token: 0x04001A36 RID: 6710
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001A36")]
	public LevelSaveEnter selectedLevel;

	// Token: 0x04001A37 RID: 6711
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001A37")]
	public LevelSaveEnter sampleLevel;

	// Token: 0x04001A38 RID: 6712
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001A38")]
	public bool saveMode;
}
