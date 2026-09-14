using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000873 RID: 2163
[Token(Token = "0x2000873")]
public class ExploreMenu : BaseMenu
{
	// Token: 0x06002C0B RID: 11275 RVA: 0x000EFC44 File Offset: 0x000EDE44
	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x6BC1D0", Offset = "0x6BA7D0", VA = "0x1806BC1D0", Slot = "6")]
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

	// Token: 0x06002C0C RID: 11276 RVA: 0x000EFCCC File Offset: 0x000EDECC
	[Token(Token = "0x6002C0C")]
	[Address(RVA = "0x6BCAB0", Offset = "0x6BB0B0", VA = "0x1806BCAB0")]
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

	// Token: 0x06002C0D RID: 11277 RVA: 0x000EFD0C File Offset: 0x000EDF0C
	[Token(Token = "0x6002C0D")]
	[Address(RVA = "0x6BD3F0", Offset = "0x6BB9F0", VA = "0x1806BD3F0")]
	public void SwitchEditMode()
	{
		ExploreMenu.editMode = "{il2cpp field on {'constant5' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x0}" == (ulong)0L;
		this.EditText();
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x000EFD30 File Offset: 0x000EDF30
	[Token(Token = "0x6002C0E")]
	[Address(RVA = "0x6BCCE0", Offset = "0x6BB2E0", VA = "0x1806BCCE0")]
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

	// Token: 0x06002C0F RID: 11279 RVA: 0x000EFDB8 File Offset: 0x000EDFB8
	[Token(Token = "0x6002C0F")]
	[Address(RVA = "0x6BD6A0", Offset = "0x6BBCA0", VA = "0x1806BD6A0")]
	public void UpdateScene()
	{
		this.UpdateTitleText();
		this.UpdateWindows();
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x000EFDD4 File Offset: 0x000EDFD4
	[Token(Token = "0x6002C10")]
	[Address(RVA = "0x6BD970", Offset = "0x6BBF70", VA = "0x1806BD970")]
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

	// Token: 0x06002C11 RID: 11281 RVA: 0x000EFE94 File Offset: 0x000EE094
	[Token(Token = "0x6002C11")]
	[Address(RVA = "0x6BD0F0", Offset = "0x6BB6F0", VA = "0x1806BD0F0")]
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

	// Token: 0x06002C12 RID: 11282 RVA: 0x000EFF0C File Offset: 0x000EE10C
	[Token(Token = "0x6002C12")]
	[Address(RVA = "0x6BC5B0", Offset = "0x6BABB0", VA = "0x1806BC5B0")]
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
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x000F000C File Offset: 0x000EE20C
	[Token(Token = "0x6002C13")]
	[Address(RVA = "0x6BD6C0", Offset = "0x6BBCC0", VA = "0x1806BD6C0")]
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

	// Token: 0x06002C14 RID: 11284 RVA: 0x000F0068 File Offset: 0x000EE268
	[Token(Token = "0x6002C14")]
	[Address(RVA = "0x6BD440", Offset = "0x6BBA40", VA = "0x1806BD440")]
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

	// Token: 0x06002C15 RID: 11285 RVA: 0x000F00E4 File Offset: 0x000EE2E4
	[Token(Token = "0x6002C15")]
	[Address(RVA = "0x6BD570", Offset = "0x6BBB70", VA = "0x1806BD570")]
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

	// Token: 0x06002C16 RID: 11286 RVA: 0x000F0160 File Offset: 0x000EE360
	[Token(Token = "0x6002C16")]
	[Address(RVA = "0x6BCFF0", Offset = "0x6BB5F0", VA = "0x1806BCFF0")]
	public Texture2D GetTexture(SceneType sceneType)
	{
		Type typeFromHandle = typeof(SceneType);
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		return Resources.Load<Texture2D>("UI/Background/" + name);
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x000F0194 File Offset: 0x000EE394
	[Token(Token = "0x6002C17")]
	[Address(RVA = "0x6BDF90", Offset = "0x6BC590", VA = "0x1806BDF90")]
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

	// Token: 0x040019F8 RID: 6648
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40019F8")]
	public Transform upperHead;

	// Token: 0x040019F9 RID: 6649
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40019F9")]
	public Transform lowerHead;

	// Token: 0x040019FA RID: 6650
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40019FA")]
	public ExploreEnterWindow sampleWindow;

	// Token: 0x040019FB RID: 6651
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40019FB")]
	public List<ExploreEnterWindow> upperWindows;

	// Token: 0x040019FC RID: 6652
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40019FC")]
	public List<ExploreEnterWindow> lowerWindows;

	// Token: 0x040019FD RID: 6653
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40019FD")]
	public List<TextMeshProUGUI> titleText;

	// Token: 0x040019FE RID: 6654
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40019FE")]
	public List<TextMeshProUGUI> trophyText;

	// Token: 0x040019FF RID: 6655
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40019FF")]
	public List<TextMeshProUGUI> editModeText;

	// Token: 0x04001A00 RID: 6656
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001A00")]
	public Image background;

	// Token: 0x04001A01 RID: 6657
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001A01")]
	public SceneType UpperScene;

	// Token: 0x04001A02 RID: 6658
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4001A02")]
	public SceneType LowerScene;

	// Token: 0x04001A03 RID: 6659
	[Token(Token = "0x4001A03")]
	private static bool editMode;

	// Token: 0x04001A04 RID: 6660
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001A04")]
	private readonly List<SceneType> SceneSwithSequence;

	// Token: 0x04001A05 RID: 6661
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001A05")]
	private readonly Dictionary<SceneType, List<PlantType>> PlantsInScene;
}
