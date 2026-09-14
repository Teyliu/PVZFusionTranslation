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

// Token: 0x02000857 RID: 2135
[Token(Token = "0x2000857")]
public class CustomOnlineMenu : BaseMenu
{
	// Token: 0x06002B68 RID: 11112 RVA: 0x000EBDCC File Offset: 0x000E9FCC
	[Token(Token = "0x6002B68")]
	[Address(RVA = "0x69E6F0", Offset = "0x69CCF0", VA = "0x18069E6F0")]
	private void Start()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x000EBDF0 File Offset: 0x000E9FF0
	[Token(Token = "0x6002B69")]
	[Address(RVA = "0x69E670", Offset = "0x69CC70", VA = "0x18069E670")]
	public void EnterGame()
	{
		LevelType levelType = this.levelData.LevelType;
		CustomLevelData customLevelData = this.levelData;
		int levelNumber = customLevelData.LevelNumber;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x000EBE28 File Offset: 0x000EA028
	[Token(Token = "0x6002B6A")]
	[Address(RVA = "0x69E580", Offset = "0x69CB80", VA = "0x18069E580")]
	public void EditLevel()
	{
		CustomMenu._levelData = this.serializedLevelData;
		UIResourcesLoader uimanager = GameAPP.UIManager;
		UIResourcesLoader uimanager2 = GameAPP.UIManager;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x000EBE5C File Offset: 0x000EA05C
	[Token(Token = "0x6002B6B")]
	[Address(RVA = "0x69DF90", Offset = "0x69C590", VA = "0x18069DF90")]
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

	// Token: 0x06002B6C RID: 11116 RVA: 0x000EBEF0 File Offset: 0x000EA0F0
	[Token(Token = "0x6002B6C")]
	[Address(RVA = "0x69E420", Offset = "0x69CA20", VA = "0x18069E420")]
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

	// Token: 0x06002B6D RID: 11117 RVA: 0x000EBF30 File Offset: 0x000EA130
	[Token(Token = "0x6002B6D")]
	[Address(RVA = "0x69F150", Offset = "0x69D750", VA = "0x18069F150")]
	public void UploadUserLevel()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x000EBF54 File Offset: 0x000EA154
	[Token(Token = "0x6002B6E")]
	[Address(RVA = "0x69ECA0", Offset = "0x69D2A0", VA = "0x18069ECA0")]
	public void UpLoadLevel()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06002B6F RID: 11119 RVA: 0x000EBF78 File Offset: 0x000EA178
	[Token(Token = "0x170001F4")]
	private string ApiKey
	{
		[Token(Token = "0x6002B6F")]
		[Address(RVA = "0x69F200", Offset = "0x69D800", VA = "0x18069F200")]
		get
		{
			return InputKeyMenu.key;
		}
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x000EBF8C File Offset: 0x000EA18C
	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x69EEB0", Offset = "0x69D4B0", VA = "0x18069EEB0")]
	public UniTask<OnlineLevelApiResponse> UploadLevelAsync(string levelName, string authorName, SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x000EBFA4 File Offset: 0x000EA1A4
	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x69ED50", Offset = "0x69D350", VA = "0x18069ED50")]
	public UniTask<OnlineLevelApiResponse> UpdateLevelAsync(string levelId, [Optional] string levelName, [Optional] string authorName, [Optional] SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x000EBFBC File Offset: 0x000EA1BC
	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x69DE60", Offset = "0x69C460", VA = "0x18069DE60")]
	public UniTask<OnlineLevelApiResponse> DeleteLevelAsync(string levelId)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x000EBFDC File Offset: 0x000EA1DC
	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x69E2F0", Offset = "0x69C8F0", VA = "0x18069E2F0")]
	public UniTask<OnlineLevelApiResponse> DeleteUserLevelAsync(string levelId)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x000EBFFC File Offset: 0x000EA1FC
	[Token(Token = "0x6002B74")]
	[Address(RVA = "0x69F000", Offset = "0x69D600", VA = "0x18069F000")]
	public UniTask<OnlineLevelApiResponse> UploadUserLevelAsync(string levelName, string authorName, SerializedLevelData serializedLevelData)
	{
		return default(UniTask<OnlineLevelApiResponse>);
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x000EC01C File Offset: 0x000EA21C
	[Token(Token = "0x6002B75")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public CustomOnlineMenu()
	{
	}

	// Token: 0x04001963 RID: 6499
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001963")]
	public CustomLevelData levelData;

	// Token: 0x04001964 RID: 6500
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001964")]
	public SerializedLevelData serializedLevelData;

	// Token: 0x04001965 RID: 6501
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001965")]
	public TextMeshProUGUI title;

	// Token: 0x04001966 RID: 6502
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001966")]
	public TextMeshProUGUI title2;

	// Token: 0x04001967 RID: 6503
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001967")]
	public bool needCheck;

	// Token: 0x04001968 RID: 6504
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001968")]
	private string levelId;

	// Token: 0x04001969 RID: 6505
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001969")]
	private bool local;

	// Token: 0x0400196A RID: 6506
	[Token(Token = "0x400196A")]
	private static float time;

	// Token: 0x0400196B RID: 6507
	[Token(Token = "0x400196B")]
	private static string QQ_Group;
}
