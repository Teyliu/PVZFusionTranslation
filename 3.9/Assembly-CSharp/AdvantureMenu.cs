using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

// Token: 0x02000814 RID: 2068
[Token(Token = "0x2000814")]
public class AdvantureMenu : BaseMenu
{
	// Token: 0x06002A25 RID: 10789 RVA: 0x000E3EE8 File Offset: 0x000E20E8
	[Token(Token = "0x6002A25")]
	[Address(RVA = "0x6808E0", Offset = "0x67EEE0", VA = "0x1806808E0", Slot = "6")]
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

	// Token: 0x06002A26 RID: 10790 RVA: 0x000E3F54 File Offset: 0x000E2154
	[Token(Token = "0x6002A26")]
	[Address(RVA = "0x681110", Offset = "0x67F710", VA = "0x180681110")]
	private void OnDestroy()
	{
		Camera.main.GetUniversalAdditionalCameraData().m_RenderPostProcessing = false;
		AdvantureMenu.lastSceneType = typeof(AdvantureMenu).TypeHandle;
	}

	// Token: 0x06002A27 RID: 10791 RVA: 0x000E3F84 File Offset: 0x000E2184
	[Token(Token = "0x6002A27")]
	[Address(RVA = "0x681350", Offset = "0x67F950", VA = "0x180681350")]
	private void Start()
	{
		this.InitScene();
		this.UpdateStarCount();
		this.UpdateChapterDifficulty();
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x000E3FA4 File Offset: 0x000E21A4
	[Token(Token = "0x6002A28")]
	[Address(RVA = "0x680B40", Offset = "0x67F140", VA = "0x180680B40")]
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
				GameAPP.PlaySound(26, 0.5f, 1f);
			}
			SceneType sceneType5 = this.currentScene;
		}
	}

	// Token: 0x06002A29 RID: 10793 RVA: 0x000E4084 File Offset: 0x000E2284
	[Token(Token = "0x6002A29")]
	[Address(RVA = "0x681530", Offset = "0x67FB30", VA = "0x180681530")]
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

	// Token: 0x06002A2A RID: 10794 RVA: 0x000E40D0 File Offset: 0x000E22D0
	[Token(Token = "0x6002A2A")]
	[Address(RVA = "0x680A20", Offset = "0x67F020", VA = "0x180680A20")]
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

	// Token: 0x06002A2B RID: 10795 RVA: 0x000E4134 File Offset: 0x000E2334
	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x681380", Offset = "0x67F980", VA = "0x180681380")]
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

	// Token: 0x06002A2C RID: 10796 RVA: 0x000E41B4 File Offset: 0x000E23B4
	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x680EE0", Offset = "0x67F4E0", VA = "0x180680EE0")]
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

	// Token: 0x06002A2D RID: 10797 RVA: 0x000E4268 File Offset: 0x000E2468
	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x680E50", Offset = "0x67F450", VA = "0x180680E50")]
	public void LastScene()
	{
		this.page.LastPage();
		SceneType sceneType = this.sceneTypes.Pop();
		this.currentScene = sceneType;
		this.OnSceneChanged();
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x000E42A8 File Offset: 0x000E24A8
	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x681180", Offset = "0x67F780", VA = "0x180681180")]
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

	// Token: 0x06002A2F RID: 10799 RVA: 0x000E431C File Offset: 0x000E251C
	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x680AF0", Offset = "0x67F0F0", VA = "0x180680AF0")]
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

	// Token: 0x06002A30 RID: 10800 RVA: 0x000E4358 File Offset: 0x000E2558
	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x681620", Offset = "0x67FC20", VA = "0x180681620")]
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

	// Token: 0x04001817 RID: 6167
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001817")]
	public SceneType currentScene;

	// Token: 0x04001818 RID: 6168
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001818")]
	public Stack<SceneType> sceneTypes;

	// Token: 0x04001819 RID: 6169
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001819")]
	public Page page;

	// Token: 0x0400181A RID: 6170
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400181A")]
	public List<TextMeshProUGUI> title;

	// Token: 0x0400181B RID: 6171
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400181B")]
	public TextMeshProUGUI starCount;

	// Token: 0x0400181C RID: 6172
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400181C")]
	public TextMeshProUGUI difficulty;

	// Token: 0x0400181D RID: 6173
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400181D")]
	public TextMeshProUGUI chapterDifficulty;

	// Token: 0x0400181E RID: 6174
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400181E")]
	public GameObject lastSceneButton;

	// Token: 0x0400181F RID: 6175
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400181F")]
	public GameObject nextSceneButton;

	// Token: 0x04001820 RID: 6176
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001820")]
	[Header("存储数据")]
	public AdvantureData data;

	// Token: 0x04001821 RID: 6177
	[Token(Token = "0x4001821")]
	private const int nextSceneNeedCount = 6;

	// Token: 0x04001822 RID: 6178
	[Token(Token = "0x4001822")]
	private static SceneType lastSceneType;

	// Token: 0x04001823 RID: 6179
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001823")]
	[TupleElementNames(new string[] { "nextScene", "thisTitle", "needLevel" })]
	private readonly Dictionary<SceneType, ValueTuple<SceneType, string, AdvantureLevel>> sceneNeedLevel;
}
