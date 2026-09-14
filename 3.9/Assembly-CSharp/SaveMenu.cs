using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020008A8 RID: 2216
[Token(Token = "0x20008A8")]
public class SaveMenu : BaseMenu
{
	// Token: 0x06002D3E RID: 11582 RVA: 0x000F6A20 File Offset: 0x000F4C20
	[Token(Token = "0x6002D3E")]
	[Address(RVA = "0x6D6960", Offset = "0x6D4F60", VA = "0x1806D6960", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		SaveMenu.Instance = this;
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000F6A3C File Offset: 0x000F4C3C
	[Token(Token = "0x17000206")]
	private string LevelName
	{
		[Token(Token = "0x6002D3F")]
		[Address(RVA = "0x6D84D0", Offset = "0x6D6AD0", VA = "0x1806D84D0")]
		get
		{
			SurvivalLevel survivalLevel = this.level;
			return string.Format("level{0}", survivalLevel);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000F6A5C File Offset: 0x000F4C5C
	[Token(Token = "0x17000207")]
	private string LevelNameWithJson
	{
		[Token(Token = "0x6002D40")]
		[Address(RVA = "0x6D8460", Offset = "0x6D6A60", VA = "0x1806D8460")]
		get
		{
			SurvivalLevel survivalLevel = this.level;
			return string.Format("level{0}.json", survivalLevel);
		}
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x000F6A7C File Offset: 0x000F4C7C
	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x6D8320", Offset = "0x6D6920", VA = "0x1806D8320")]
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

	// Token: 0x06002D42 RID: 11586 RVA: 0x000F6B54 File Offset: 0x000F4D54
	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x6D69C0", Offset = "0x6D4FC0", VA = "0x1806D69C0")]
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

	// Token: 0x06002D43 RID: 11587 RVA: 0x000F6C5C File Offset: 0x000F4E5C
	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x6D8290", Offset = "0x6D6890", VA = "0x1806D8290")]
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

	// Token: 0x06002D44 RID: 11588 RVA: 0x000F6C90 File Offset: 0x000F4E90
	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x6D7D10", Offset = "0x6D6310", VA = "0x1806D7D10")]
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
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x000F6CDC File Offset: 0x000F4EDC
	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x6D7AF0", Offset = "0x6D60F0", VA = "0x1806D7AF0")]
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
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x000F6D28 File Offset: 0x000F4F28
	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x6D7C00", Offset = "0x6D6200", VA = "0x1806D7C00")]
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
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x000F6D74 File Offset: 0x000F4F74
	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x6D7820", Offset = "0x6D5E20", VA = "0x1806D7820")]
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
				return;
			}
			GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
			InGameText instance4 = InGameText.Instance;
		}
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance5 = InGameText.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x000F6E44 File Offset: 0x000F5044
	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x6D7F40", Offset = "0x6D6540", VA = "0x1806D7F40")]
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
			return;
		}
		SaveInfo instance2 = SaveInfo.Instance;
		SurvivalData survivalData;
		if (survivalData != 0 && (survivalData.boardData.isBoardSaved ? 1 : 0) != num)
		{
			SaveInfo instance3 = SaveInfo.Instance;
			InGameText instance4 = InGameText.Instance;
			int num3;
			string text4 = string.Format("保存成功，编号：{0}", num3);
			this.CreateLevelEnter(survivalData, num, text3).transform.SetAsFirstSibling();
			return;
		}
		GameAPP.PlaySound((SoundType)((uint)26), 0.5f, 1f);
		InGameText instance5 = InGameText.Instance;
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x000F6F1C File Offset: 0x000F511C
	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x6D7E20", Offset = "0x6D6420", VA = "0x1806D7E20")]
	public void OnExitButtonClicked()
	{
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x000F6F2C File Offset: 0x000F512C
	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x6D7E40", Offset = "0x6D6440", VA = "0x1806D7E40")]
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

	// Token: 0x06002D4B RID: 11595 RVA: 0x000F6F90 File Offset: 0x000F5190
	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x6D70A0", Offset = "0x6D56A0", VA = "0x1806D70A0")]
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

	// Token: 0x06002D4C RID: 11596 RVA: 0x000F712C File Offset: 0x000F532C
	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x6D6C70", Offset = "0x6D5270", VA = "0x1806D6C70")]
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

	// Token: 0x06002D4D RID: 11597 RVA: 0x000F7220 File Offset: 0x000F5420
	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x6D6F30", Offset = "0x6D5530", VA = "0x1806D6F30")]
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

	// Token: 0x06002D4E RID: 11598 RVA: 0x000F7294 File Offset: 0x000F5494
	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x6D7710", Offset = "0x6D5D10", VA = "0x1806D7710")]
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

	// Token: 0x06002D4F RID: 11599 RVA: 0x000F72CC File Offset: 0x000F54CC
	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public SaveMenu()
	{
	}

	// Token: 0x04001B19 RID: 6937
	[Token(Token = "0x4001B19")]
	public static SaveMenu Instance;

	// Token: 0x04001B1A RID: 6938
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B1A")]
	public SurvivalLevel level;

	// Token: 0x04001B1B RID: 6939
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B1B")]
	public TextMeshProUGUI menuTitle;

	// Token: 0x04001B1C RID: 6940
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B1C")]
	[Header("按钮")]
	public TheButton StartNewGameButton;

	// Token: 0x04001B1D RID: 6941
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B1D")]
	public TheButton EnterSelectedButton;

	// Token: 0x04001B1E RID: 6942
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001B1E")]
	public TheButton DeleteSelectedButton;

	// Token: 0x04001B1F RID: 6943
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001B1F")]
	public TheButton EditSelectedButton;

	// Token: 0x04001B20 RID: 6944
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001B20")]
	public TheButton CoverSelectedButton;

	// Token: 0x04001B21 RID: 6945
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001B21")]
	public TheButton SaveAsNewButton;

	// Token: 0x04001B22 RID: 6946
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001B22")]
	public TheButton ExitButton;

	// Token: 0x04001B23 RID: 6947
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001B23")]
	[Header("点击事件")]
	public UnityEvent actionOnCreateNewLevel;

	// Token: 0x04001B24 RID: 6948
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001B24")]
	public LevelSaveEnter selectedLevel;

	// Token: 0x04001B25 RID: 6949
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001B25")]
	public LevelSaveEnter sampleLevel;

	// Token: 0x04001B26 RID: 6950
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001B26")]
	public bool saveMode;
}
