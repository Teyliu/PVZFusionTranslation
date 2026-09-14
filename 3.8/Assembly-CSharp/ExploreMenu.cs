using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000837 RID: 2103
[Token(Token = "0x2000837")]
public class ExploreMenu : BaseMenu
{
	// Token: 0x06002AD9 RID: 10969 RVA: 0x000EAED8 File Offset: 0x000E90D8
	[Token(Token = "0x6002AD9")]
	[Address(RVA = "0x658390", Offset = "0x656990", VA = "0x180658390", Slot = "6")]
	protected override void Awake()
	{
		ulong num3;
		do
		{
			base.Awake();
			this.UpdateTitleText();
			this.UpdateWindows();
			int num = 0;
			Dictionary<PlantType, LevelData> levelDataDic = ExploreDataManager.levelDataDic;
			bool flag;
			if (flag)
			{
				HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
				bool flag2;
				while (!flag2)
				{
				}
				num++;
			}
			if (num != 0)
			{
				goto IL_006C;
			}
			bool flag3;
			if (flag3)
			{
				int count = ExploreDataManager.levelDataDic.Count;
				int num2;
				string text = string.Format("{0}/{1}", num2, count);
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_006C:
		throw new NullReferenceException();
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000EAF60 File Offset: 0x000E9160
	[Token(Token = "0x6002ADA")]
	[Address(RVA = "0x658C60", Offset = "0x657260", VA = "0x180658C60")]
	private void EditText()
	{
		ulong num2;
		do
		{
			List<TextMeshProUGUI> list = this.editModeText;
			bool flag;
			if (flag)
			{
			}
			ulong num;
			if (num != (ulong)0L)
			{
				goto IL_002A;
			}
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != (ulong)0L);
		return;
		IL_002A:
		throw new NullReferenceException();
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000EAFA0 File Offset: 0x000E91A0
	[Token(Token = "0x6002ADB")]
	[Address(RVA = "0x659590", Offset = "0x657B90", VA = "0x180659590")]
	public void SwitchEditMode()
	{
		ExploreMenu.editMode = "{il2cpp field on {'constant5' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}" == (ulong)0L;
		this.EditText();
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x000EAFC4 File Offset: 0x000E91C4
	[Token(Token = "0x6002ADC")]
	[Address(RVA = "0x658E90", Offset = "0x657490", VA = "0x180658E90")]
	public void EnterRandomLevel()
	{
		List<PlantType> list;
		ulong num;
		do
		{
			list = new List();
			Dictionary<PlantType, LevelData> levelDataDic = ExploreDataManager.levelDataDic;
			bool flag;
			if (flag)
			{
				HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
				bool flag2;
				while (flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
		CursorChange.SetDefaultCursor();
		int num2 = list._size;
		num2 = global::UnityEngine.Random.Range(0, num2);
		PlantType plantType = list[num2];
		int num3 = 0;
		int num4 = (int)plantType;
		UIMgr.EnterGame((LevelType)((uint)4), num4, -1, num3);
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x000EB060 File Offset: 0x000E9260
	[Token(Token = "0x6002ADD")]
	[Address(RVA = "0x659840", Offset = "0x657E40", VA = "0x180659840")]
	public void UpdateScene()
	{
		this.UpdateTitleText();
		this.UpdateWindows();
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x000EB07C File Offset: 0x000E927C
	[Token(Token = "0x6002ADE")]
	[Address(RVA = "0x659B10", Offset = "0x658110", VA = "0x180659B10")]
	private void UpdateWindows()
	{
		ulong num5;
		do
		{
			int num = 0;
			List<ExploreEnterWindow> list = this.upperWindows;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_007A;
			}
			bool flag2;
			if (flag2)
			{
				GameObject gameObject2;
				global::UnityEngine.Object.Destroy(gameObject2);
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0080;
			}
			bool flag3;
			if (flag3)
			{
				ExploreEnterWindow exploreEnterWindow;
				exploreEnterWindow.selfType = num;
				exploreEnterWindow.clickEvent = exploreEnterWindow;
			}
			ulong num4;
			if (num4 != (ulong)0L)
			{
				goto IL_0098;
			}
			bool flag4;
			if (flag4)
			{
				ExploreEnterWindow exploreEnterWindow2;
				exploreEnterWindow2.selfType = num;
				exploreEnterWindow2.clickEvent = exploreEnterWindow2;
			}
		}
		while (num5 != (ulong)0L);
		return;
		IL_007A:
		throw new NullReferenceException();
		IL_0080:
		throw new IndexOutOfRangeException();
		IL_0098:
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x000EB13C File Offset: 0x000E933C
	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x659290", Offset = "0x657890", VA = "0x180659290")]
	public void ResetWindows()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<ExploreEnterWindow> list = this.lowerWindows;
			List<ExploreEnterWindow> list2 = Enumerable.ToList<ExploreEnterWindow>(Enumerable.Concat<ExploreEnterWindow>(this.upperWindows, list));
			bool flag;
			if (flag)
			{
				HashSet<int> exploreLevelCompleted = GameAPP.exploreLevelCompleted;
				bool flag2 = global::Lawnf.CheckIfPlantUnlock((PlantType)num) != UnlockType.NotUnlocked;
				string name = global::Lawnf.GetName((PlantType)num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x000EB1B4 File Offset: 0x000E93B4
	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x658770", Offset = "0x656D70", VA = "0x180658770")]
	public void ClickWindow(ExploreEnterWindow window)
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			if ((window.disabled ? 1 : 0) != num)
			{
				goto IL_00CC;
			}
			if ((window.basicPlant ? 1 : 0) == num)
			{
				goto IL_005E;
			}
			if (!window.trophy.activeSelf)
			{
				break;
			}
			bool flag = this.upperWindows.Contains(window);
			bool flag2;
			if (flag2)
			{
				int selfType = window.selfType;
				bool flag3;
				if (!flag3)
				{
				}
				int selfType2 = window.selfType;
			}
		}
		while (num2 != 0);
		InGameText instance = InGameText.Instance;
		IL_005E:
		Dictionary<PlantType, LevelData> levelDataDic = ExploreDataManager.levelDataDic;
		PlantType targetType = window.targetType;
		bool flag4 = levelDataDic.ContainsKey(targetType);
		if (flag4)
		{
			CursorChange.SetDefaultCursor();
			return;
		}
		InGameText instance2 = InGameText.Instance;
		base.GetCol();
		UIResourcesLoader uimanager = GameAPP.UIManager;
		int num3 = 0;
		Transform canvasUp = GameAPP.canvasUp;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)11), canvasUp, num3 != 0);
		PlantType targetType2 = window.targetType;
		PlantType mix = window.mix1;
		PlantType mix2 = window.mix2;
		IL_00CC:
		InGameText instance3 = InGameText.Instance;
		int num4 = 0;
		instance3.ShowText("敬请期待", 3f, num4 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000EB2CC File Offset: 0x000E94CC
	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x659860", Offset = "0x657E60", VA = "0x180659860")]
	private void UpdateTitleText()
	{
		ulong num;
		do
		{
			SceneType upperScene = this.UpperScene;
			SceneType valueOrDefault = CollectionExtensions.GetValueOrDefault<SceneType, string>(MapData_cs.SceneName, upperScene);
			SceneType lowerScene = this.LowerScene;
			SceneType valueOrDefault2 = CollectionExtensions.GetValueOrDefault<SceneType, string>(MapData_cs.SceneName, lowerScene);
			List<TextMeshProUGUI> list = this.titleText;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000EB328 File Offset: 0x000E9528
	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x6595E0", Offset = "0x657BE0", VA = "0x1806595E0")]
	public void SwitchUpperScene()
	{
		List<SceneType> list = new List(this.SceneSwithSequence);
		SceneType lowerScene = this.LowerScene;
		bool flag = list.Remove(lowerScene);
		int num = 0;
		SceneType upperScene = this.UpperScene;
		SceneType sceneType = list[num];
		if (upperScene != sceneType)
		{
			num++;
		}
		int size = list._size;
		if (num != size)
		{
		}
		int num2 = 0;
		SceneType sceneType2 = list[num2];
		this.UpperScene = sceneType2;
		this.UpdateTitleText();
		this.UpdateWindows();
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000EB3A4 File Offset: 0x000E95A4
	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x659710", Offset = "0x657D10", VA = "0x180659710")]
	public void SwithLowerScene()
	{
		List<SceneType> list = new List(this.SceneSwithSequence);
		SceneType upperScene = this.UpperScene;
		bool flag = list.Remove(upperScene);
		int num = 0;
		SceneType lowerScene = this.LowerScene;
		SceneType sceneType = list[num];
		if (lowerScene != sceneType)
		{
			num++;
		}
		int size = list._size;
		if (num != size)
		{
		}
		int num2 = 0;
		SceneType sceneType2 = list[num2];
		this.LowerScene = sceneType2;
		this.UpdateTitleText();
		this.UpdateWindows();
	}

	// Token: 0x06002AE4 RID: 10980 RVA: 0x000EB420 File Offset: 0x000E9620
	[Token(Token = "0x6002AE4")]
	[Address(RVA = "0x659190", Offset = "0x657790", VA = "0x180659190")]
	public Texture2D GetTexture(SceneType sceneType)
	{
		Type typeFromHandle = typeof(SceneType);
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		return Resources.Load<Texture2D>("UI/Background/" + name);
	}

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000EB454 File Offset: 0x000E9654
	[Token(Token = "0x6002AE5")]
	[Address(RVA = "0x65A130", Offset = "0x658730", VA = "0x18065A130")]
	public ExploreMenu()
	{
		List<ExploreEnterWindow> list = new List();
		this.upperWindows = list;
		List<ExploreEnterWindow> list2 = new List();
		this.lowerWindows = list2;
		List<TextMeshProUGUI> list3 = new List();
		this.trophyText = list3;
		List<TextMeshProUGUI> list4 = new List();
		this.editModeText = list4;
		this.LowerScene = (SceneType)((ulong)1L);
		List<SceneType> list5 = new List();
		int size = list5._size;
		list5._size = 1;
		list5._syncRoot = (ulong)0L;
		int size2 = list5._size;
		list5._size = 1;
		int size3 = list5._size;
		list5._size = 1;
		int size4 = list5._size;
		list5._size = 1;
		int size5 = list5._size;
		list5._size = 1;
		this.SceneSwithSequence = list5;
		Dictionary<SceneType, List<PlantType>> dictionary = new Dictionary();
		List<PlantType> list6 = new List();
		int size6 = list6._size;
		int size7 = list6._size;
		int size8 = list6._size;
		int size9 = list6._size;
		int size10 = list6._size;
		int size11 = list6._size;
		int num = 0;
		dictionary.Add(num, list6);
		List<PlantType> list7 = new List();
		int size12 = list7._size;
		int size13 = list7._size;
		int size14 = list7._size;
		int size15 = list7._size;
		int size16 = list7._size;
		int size17 = list7._size;
		dictionary.Add((uint)1, list7);
		List<PlantType> list8 = new List();
		int size18 = list8._size;
		int size19 = list8._size;
		int size20 = list8._size;
		int size21 = list8._size;
		int size22 = list8._size;
		int size23 = list8._size;
		dictionary.Add((uint)2, list8);
		List<PlantType> list9 = new List();
		int size24 = list9._size;
		int size25 = list9._size;
		int size26 = list9._size;
		int size27 = list9._size;
		int size28 = list9._size;
		int size29 = list9._size;
		int size30 = list9._size;
		dictionary.Add((uint)3, list9);
		List<PlantType> list10 = new List();
		int size31 = list10._size;
		int size32 = list10._size;
		int size33 = list10._size;
		int size34 = list10._size;
		int size35 = list10._size;
		int size36 = list10._size;
		int size37 = list10._size;
		dictionary.Add((uint)4, list10);
		this.PlantsInScene = dictionary;
		base..ctor();
	}

	// Token: 0x0400190A RID: 6410
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400190A")]
	public Transform upperHead;

	// Token: 0x0400190B RID: 6411
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400190B")]
	public Transform lowerHead;

	// Token: 0x0400190C RID: 6412
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400190C")]
	public ExploreEnterWindow sampleWindow;

	// Token: 0x0400190D RID: 6413
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400190D")]
	public List<ExploreEnterWindow> upperWindows;

	// Token: 0x0400190E RID: 6414
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400190E")]
	public List<ExploreEnterWindow> lowerWindows;

	// Token: 0x0400190F RID: 6415
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400190F")]
	public List<TextMeshProUGUI> titleText;

	// Token: 0x04001910 RID: 6416
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001910")]
	public List<TextMeshProUGUI> trophyText;

	// Token: 0x04001911 RID: 6417
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001911")]
	public List<TextMeshProUGUI> editModeText;

	// Token: 0x04001912 RID: 6418
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001912")]
	public Image background;

	// Token: 0x04001913 RID: 6419
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001913")]
	public SceneType UpperScene;

	// Token: 0x04001914 RID: 6420
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4001914")]
	public SceneType LowerScene;

	// Token: 0x04001915 RID: 6421
	[Token(Token = "0x4001915")]
	private static bool editMode;

	// Token: 0x04001916 RID: 6422
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001916")]
	private readonly List<SceneType> SceneSwithSequence;

	// Token: 0x04001917 RID: 6423
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001917")]
	private readonly Dictionary<SceneType, List<PlantType>> PlantsInScene;
}
