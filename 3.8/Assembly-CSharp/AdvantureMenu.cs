using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x020007DB RID: 2011
[Token(Token = "0x20007DB")]
public class AdvantureMenu : BaseMenu
{
	// Token: 0x060028F6 RID: 10486 RVA: 0x000DEF2C File Offset: 0x000DD12C
	[Token(Token = "0x60028F6")]
	[Address(RVA = "0x61D020", Offset = "0x61B620", VA = "0x18061D020", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		AdvantureData advantureData = AdvantureConfig.data;
		this.data = advantureData;
		Camera.main.GetUniversalAdditionalCameraData().m_RenderPostProcessing = true;
		AdvantureData advantureData2 = AdvantureConfig.data;
		if (advantureData2.hardMode)
		{
		}
		TextMeshProUGUI textMeshProUGUI = this.difficulty;
		throw new NullReferenceException();
	}

	// Token: 0x060028F7 RID: 10487 RVA: 0x000DEF98 File Offset: 0x000DD198
	[Token(Token = "0x60028F7")]
	[Address(RVA = "0x61D820", Offset = "0x61BE20", VA = "0x18061D820")]
	private void OnDestroy()
	{
		Camera.main.GetUniversalAdditionalCameraData().m_RenderPostProcessing = false;
		AdvantureMenu.lastSceneType = typeof(AdvantureMenu).TypeHandle;
	}

	// Token: 0x060028F8 RID: 10488 RVA: 0x000DEFC8 File Offset: 0x000DD1C8
	[Token(Token = "0x60028F8")]
	[Address(RVA = "0x61DA60", Offset = "0x61C060", VA = "0x18061DA60")]
	private void Start()
	{
		this.InitScene();
		this.UpdateStarCount();
		this.UpdateChapterDifficulty();
	}

	// Token: 0x060028F9 RID: 10489 RVA: 0x000DEFE8 File Offset: 0x000DD1E8
	[Token(Token = "0x60028F9")]
	[Address(RVA = "0x61D280", Offset = "0x61B880", VA = "0x18061D280")]
	private void InitScene()
	{
		int count = this.sceneNeedLevel.Count;
		SceneType sceneType = this.currentScene;
		if (count > 0)
		{
			int num = 0;
			AdvantureData advantureData = AdvantureConfig.data;
			SceneType sceneType2 = this.currentScene;
			if (advantureData.GetSceneStars(sceneType2) < 6)
			{
				InGameText instance = InGameText.Instance;
			}
			Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> dictionary = this.sceneNeedLevel;
			SceneType sceneType3 = this.currentScene;
			if (dictionary.TryGetValue(sceneType3, num))
			{
				List<AdvantureLevel> levelCompleted = AdvantureConfig.data.levelCompleted;
				bool flag;
				if (flag)
				{
					this.page.NextPage();
					Stack<SceneType> stack = this.sceneTypes;
					SceneType sceneType4 = this.currentScene;
					stack.Push(sceneType4);
					this.currentScene = (SceneType)num;
					this.OnSceneChanged();
				}
				InGameText instance2 = InGameText.Instance;
				int num2 = 0;
				instance2.ShowText("需要通关主线关卡", 3f, num2 != 0);
				GameAPP.PlaySound(26, 0.5f, 1f);
			}
			SceneType sceneType5 = this.currentScene;
		}
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x000DF0DC File Offset: 0x000DD2DC
	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x61DC40", Offset = "0x61C240", VA = "0x18061DC40")]
	private void UpdateStarCount()
	{
		TextMeshProUGUI textMeshProUGUI = this.starCount;
		AdvantureData advantureData = AdvantureConfig.data;
		SceneType sceneType = this.currentScene;
		int sceneStars = advantureData.GetSceneStars(sceneType);
		string text2;
		string text3;
		string text = text2 + "/" + text3;
		textMeshProUGUI.text = text;
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x000DF128 File Offset: 0x000DD328
	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x61D160", Offset = "0x61B760", VA = "0x18061D160")]
	public void ChangeDifficulty()
	{
		AdvantureData advantureData = AdvantureConfig.data;
		AdvantureData advantureData2 = AdvantureConfig.data;
		bool flag = !advantureData.hardMode;
		advantureData2.hardMode = flag;
		AdvantureData advantureData3 = AdvantureConfig.data;
		string text = "普通模式";
		if (advantureData3.hardMode)
		{
			text = "困难模式";
		}
		this.difficulty.text = text;
		this.UpdateChapterDifficulty();
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x000DF18C File Offset: 0x000DD38C
	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x61DA90", Offset = "0x61C090", VA = "0x18061DA90")]
	private void UpdateChapterDifficulty()
	{
		AdvantureData advantureData = AdvantureConfig.data;
		SceneType sceneType = this.currentScene;
		TextMeshProUGUI textMeshProUGUI = this.chapterDifficulty;
		int num = (int)sceneType;
		if (!advantureData.hardMode)
		{
			if (sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || num != 1)
			{
			}
			int num2;
			string text = string.Format("章节难度：{0}", num2);
		}
		if (sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || sceneType == SceneType.Day || num != 1)
		{
		}
		int num3;
		string text2 = string.Format("章节难度：{0}+2", num3);
		textMeshProUGUI.text = text2;
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x000DF20C File Offset: 0x000DD40C
	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x61D600", Offset = "0x61BC00", VA = "0x18061D600")]
	public void NextScene()
	{
		int num = 0;
		AdvantureData advantureData = AdvantureConfig.data;
		SceneType sceneType = this.currentScene;
		if (advantureData.GetSceneStars(sceneType) < 6)
		{
			InGameText instance = InGameText.Instance;
		}
		Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> dictionary = this.sceneNeedLevel;
		SceneType sceneType2 = this.currentScene;
		if (dictionary.TryGetValue(sceneType2, num))
		{
			List<AdvantureLevel> levelCompleted = AdvantureConfig.data.levelCompleted;
			bool flag;
			if (!flag)
			{
				InGameText instance2 = InGameText.Instance;
				int num2 = 0;
				instance2.ShowText("需要通关主线关卡", 3f, num2 != 0);
				GameAPP.PlaySound(26, 0.5f, 1f);
				return;
			}
			this.page.NextPage();
			Stack<SceneType> stack = this.sceneTypes;
			SceneType sceneType3 = this.currentScene;
			stack.Push(sceneType3);
			this.currentScene = (SceneType)num;
			this.OnSceneChanged();
		}
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x000DF2D8 File Offset: 0x000DD4D8
	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x61D570", Offset = "0x61BB70", VA = "0x18061D570")]
	public void LastScene()
	{
		this.page.LastPage();
		SceneType sceneType = this.sceneTypes.Pop();
		this.currentScene = sceneType;
		this.OnSceneChanged();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x060028FF RID: 10495 RVA: 0x000DF318 File Offset: 0x000DD518
	[Token(Token = "0x60028FF")]
	[Address(RVA = "0x61D890", Offset = "0x61BE90", VA = "0x18061D890")]
	private void OnSceneChanged()
	{
		ulong num2;
		do
		{
			int num = 0;
			Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> dictionary = this.sceneNeedLevel;
			SceneType sceneType = this.currentScene;
			if (!dictionary.TryGetValue(sceneType, num))
			{
				break;
			}
			List<TextMeshProUGUI> list = this.title;
			bool flag;
			if (flag)
			{
			}
		}
		while (num2 != (ulong)0L);
		this.UpdateChapterDifficulty();
		this.UpdateStarCount();
		GameObject gameObject = this.lastSceneButton;
		Stack<SceneType> stack = this.sceneTypes;
		bool flag2;
		gameObject.SetActive(flag2);
	}

	// Token: 0x06002900 RID: 10496 RVA: 0x000DF38C File Offset: 0x000DD58C
	[Token(Token = "0x6002900")]
	[Address(RVA = "0x61D230", Offset = "0x61B830", VA = "0x18061D230")]
	private int GetChapterDifficulty()
	{
		SceneType sceneType = this.currentScene;
		int num = (int)sceneType;
		if (sceneType == SceneType.Day)
		{
			return 0;
		}
		if (sceneType == SceneType.Day)
		{
			return 0;
		}
		if (sceneType == SceneType.Day)
		{
			return 0;
		}
		if (sceneType == SceneType.Day)
		{
			return 0;
		}
		if (num != 1)
		{
			bool flag = sceneType == SceneType.Snow;
			return 0;
		}
		return 0;
	}

	// Token: 0x06002901 RID: 10497 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
	[Token(Token = "0x6002901")]
	[Address(RVA = "0x61DD30", Offset = "0x61C330", VA = "0x18061DD30")]
	public AdvantureMenu()
	{
		Stack<SceneType> stack = new Stack();
		this.sceneTypes = stack;
		List<TextMeshProUGUI> list = new List();
		this.title = list;
		Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> dictionary = new Dictionary();
		this.sceneNeedLevel = dictionary;
		base..ctor();
	}

	// Token: 0x0400173B RID: 5947
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400173B")]
	public SceneType currentScene;

	// Token: 0x0400173C RID: 5948
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400173C")]
	public Stack<SceneType> sceneTypes;

	// Token: 0x0400173D RID: 5949
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400173D")]
	public Page page;

	// Token: 0x0400173E RID: 5950
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400173E")]
	public List<TextMeshProUGUI> title;

	// Token: 0x0400173F RID: 5951
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400173F")]
	public TextMeshProUGUI starCount;

	// Token: 0x04001740 RID: 5952
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001740")]
	public TextMeshProUGUI difficulty;

	// Token: 0x04001741 RID: 5953
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001741")]
	public TextMeshProUGUI chapterDifficulty;

	// Token: 0x04001742 RID: 5954
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001742")]
	public GameObject lastSceneButton;

	// Token: 0x04001743 RID: 5955
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001743")]
	public GameObject nextSceneButton;

	// Token: 0x04001744 RID: 5956
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001744")]
	[Header("存储数据")]
	public AdvantureData data;

	// Token: 0x04001745 RID: 5957
	[Token(Token = "0x4001745")]
	private const int nextSceneNeedCount = 6;

	// Token: 0x04001746 RID: 5958
	[Token(Token = "0x4001746")]
	private static SceneType lastSceneType;

	// Token: 0x04001747 RID: 5959
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001747")]
	[TupleElementNames(new string[] { "nextScene", "thisTitle", "needLevel" })]
	private readonly Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> sceneNeedLevel;
}
