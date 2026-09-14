using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel;
using GameLevel.OnLine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000819 RID: 2073
[Token(Token = "0x2000819")]
public class CustomOnlineMenu : BaseMenu
{
	// Token: 0x06002A2A RID: 10794 RVA: 0x000E6A8C File Offset: 0x000E4C8C
	[Token(Token = "0x6002A2A")]
	[Address(RVA = "0x63A180", Offset = "0x638780", VA = "0x18063A180")]
	private void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x000E6AB0 File Offset: 0x000E4CB0
	[Token(Token = "0x6002A2B")]
	[Address(RVA = "0x63A100", Offset = "0x638700", VA = "0x18063A100")]
	public void EnterGame()
	{
		LevelType levelType = this.levelData.LevelType;
		CustomLevelData customLevelData = this.levelData;
		int levelNumber = customLevelData.LevelNumber;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x000E6AE8 File Offset: 0x000E4CE8
	[Token(Token = "0x6002A2C")]
	[Address(RVA = "0x63A010", Offset = "0x638610", VA = "0x18063A010")]
	public void EditLevel()
	{
		CustomMenu._levelData = this.serializedLevelData;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x000E6B1C File Offset: 0x000E4D1C
	[Token(Token = "0x6002A2D")]
	[Address(RVA = "0x639A20", Offset = "0x638020", VA = "0x180639A20")]
	public void DeleteLevel()
	{
		if (!this.needCheck)
		{
			if (!this.local)
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)68), canvasUp, num != 0);
				UnityAction unityAction = delegate
				{
					string text = this.levelId;
					LevelType levelType = this.levelData.LevelType;
					CustomLevelData customLevelData = this.levelData;
					int levelNumber = customLevelData.LevelNumber;
					base.PopMenu();
					throw new NullReferenceException();
				};
				return;
			}
			UIResourcesLoader uimanager2 = GameAPP.UIManager;
			Transform canvasUp2 = GameAPP.canvasUp;
			int num2 = 0;
			BaseMenu baseMenu2 = uimanager2.Push((UIType)((uint)68), canvasUp2, num2 != 0);
		}
		UIResourcesLoader uimanager3 = GameAPP.UIManager;
		Transform canvasUp3 = GameAPP.canvasUp;
		int num3 = 0;
		BaseMenu baseMenu3 = uimanager3.Push((UIType)((uint)68), canvasUp3, num3 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x000E6BB0 File Offset: 0x000E4DB0
	[Token(Token = "0x6002A2E")]
	[Address(RVA = "0x639EB0", Offset = "0x6384B0", VA = "0x180639EB0")]
	public void DeleteUserLevel()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)68), canvasUp, num != 0);
		UnityAction unityAction = delegate
		{
			string text = this.levelId;
		};
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x000E6BF0 File Offset: 0x000E4DF0
	[Token(Token = "0x6002A2F")]
	[Address(RVA = "0x63ABE0", Offset = "0x6391E0", VA = "0x18063ABE0")]
	public void UploadUserLevel()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002A30 RID: 10800 RVA: 0x000E6C14 File Offset: 0x000E4E14
	[Token(Token = "0x6002A30")]
	[Address(RVA = "0x63A730", Offset = "0x638D30", VA = "0x18063A730")]
	public void UpLoadLevel()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000E6C38 File Offset: 0x000E4E38
	[Token(Token = "0x170001AA")]
	private string ApiKey
	{
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x63AC90", Offset = "0x639290", VA = "0x18063AC90")]
		get
		{
			return InputKeyMenu.key;
		}
	}

	// Token: 0x06002A32 RID: 10802 RVA: 0x000E6C4C File Offset: 0x000E4E4C
	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x63A940", Offset = "0x638F40", VA = "0x18063A940")]
	public UniTask<OnlineLevelApiResponse> UploadLevelAsync(string levelName, string authorName, SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x000E6C64 File Offset: 0x000E4E64
	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x63A7E0", Offset = "0x638DE0", VA = "0x18063A7E0")]
	public UniTask<OnlineLevelApiResponse> UpdateLevelAsync(string levelId, [Optional] string levelName, [Optional] string authorName, [Optional] SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x000E6C7C File Offset: 0x000E4E7C
	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x6398F0", Offset = "0x637EF0", VA = "0x1806398F0")]
	public UniTask<OnlineLevelApiResponse> DeleteLevelAsync(string levelId)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002A35 RID: 10805 RVA: 0x000E6C9C File Offset: 0x000E4E9C
	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x639D80", Offset = "0x638380", VA = "0x180639D80")]
	public UniTask<OnlineLevelApiResponse> DeleteUserLevelAsync(string levelId)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x000E6CBC File Offset: 0x000E4EBC
	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x63AA90", Offset = "0x639090", VA = "0x18063AA90")]
	public UniTask<OnlineLevelApiResponse> UploadUserLevelAsync(string levelName, string authorName, SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x000E6CDC File Offset: 0x000E4EDC
	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public CustomOnlineMenu()
	{
	}

	// Token: 0x04001867 RID: 6247
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001867")]
	public CustomLevelData levelData;

	// Token: 0x04001868 RID: 6248
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001868")]
	public SerializedLevelData serializedLevelData;

	// Token: 0x04001869 RID: 6249
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001869")]
	public TextMeshProUGUI title;

	// Token: 0x0400186A RID: 6250
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400186A")]
	public TextMeshProUGUI title2;

	// Token: 0x0400186B RID: 6251
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400186B")]
	public bool needCheck;

	// Token: 0x0400186C RID: 6252
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400186C")]
	private string levelId;

	// Token: 0x0400186D RID: 6253
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400186D")]
	private bool local;

	// Token: 0x0400186E RID: 6254
	[Token(Token = "0x400186E")]
	private static float time;

	// Token: 0x0400186F RID: 6255
	[Token(Token = "0x400186F")]
	private static string QQ_Group;
}
