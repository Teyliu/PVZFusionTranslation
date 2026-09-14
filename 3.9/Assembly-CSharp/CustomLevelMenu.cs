using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Core;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.OnLine;
using TMPro;
using UnityEngine;

// Token: 0x02000819 RID: 2073
[Token(Token = "0x2000819")]
public class CustomLevelMenu : BaseMenu
{
	// Token: 0x06002A41 RID: 10817 RVA: 0x000E47FC File Offset: 0x000E29FC
	[Token(Token = "0x6002A41")]
	[Address(RVA = "0x68FAC0", Offset = "0x68E0C0", VA = "0x18068FAC0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		int num = 0;
		this.InitOnlineWindow(num != 0);
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x000E4830 File Offset: 0x000E2A30
	[Token(Token = "0x6002A42")]
	[Address(RVA = "0x691120", Offset = "0x68F720", VA = "0x180691120")]
	public void ReloadFiles()
	{
		LevelManager.ReLoad();
		InGameText instance = InGameText.Instance;
		this.InitLocalWindows();
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x000E485C File Offset: 0x000E2A5C
	[Token(Token = "0x6002A43")]
	[Address(RVA = "0x690D40", Offset = "0x68F340", VA = "0x180690D40")]
	public void LoadOnlineFiles()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x000E4880 File Offset: 0x000E2A80
	[Token(Token = "0x6002A44")]
	[Address(RVA = "0x690640", Offset = "0x68EC40", VA = "0x180690640")]
	private void InitOnlineWindow(bool needCheck)
	{
		for (;;)
		{
			int num = 0;
			int num2 = 0;
			IEnumerator enumerator = this.pageHead.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (enumerator != 0)
			{
			}
			if (num == 0)
			{
				int num3 = 0;
				if (enumerator > 0)
				{
				}
				if (enumerator > 0)
				{
				}
				GameObject gameObject2;
				ulong num4;
				gameObject2.SetActive(num4 != 0UL);
				ulong num5;
				gameObject2.SetActive(num5 != 0UL);
				GameObject gameObject3;
				Transform transform = gameObject3.transform;
				List<OnlineLevelInfo> onlineLevelInfos = LevelManager.onlineLevelInfos;
				bool flag;
				if (flag)
				{
					CustomButton_enterGame customButton_enterGame = global::UnityEngine.Object.Instantiate<CustomButton_enterGame>(num, transform);
					customButton_enterGame.needCheck = false;
					customButton_enterGame.SetOnlineLevelInfo(num2);
					TextMeshProUGUI levelName = customButton_enterGame.levelName;
					num3++;
					while (num3 != 28)
					{
					}
					GameObject gameObject5;
					GameObject gameObject4 = gameObject5.transform.gameObject;
					int num6 = 0;
					gameObject4.SetActive(num6 != 0);
				}
				if (num3 == 0)
				{
					break;
				}
			}
		}
		int num7 = 0;
		GameObject gameObject6;
		gameObject6.SetActive(num7 != 0);
		int num8 = 0;
		gameObject6.SetActive(num8 != 0);
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x000E4984 File Offset: 0x000E2B84
	[Token(Token = "0x6002A45")]
	[Address(RVA = "0x68FCD0", Offset = "0x68E2D0", VA = "0x18068FCD0")]
	private void InitLocalWindows()
	{
		for (;;)
		{
			int num = 0;
			IEnumerator enumerator = this.pageHead.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (enumerator != 0)
			{
			}
			if (num == 0)
			{
				int num2 = 0;
				if (enumerator > 0)
				{
				}
				if (enumerator > 0)
				{
				}
				GameObject gameObject2;
				ulong num3;
				gameObject2.SetActive(num3 != 0UL);
				ulong num4;
				gameObject2.SetActive(num4 != 0UL);
				GameObject gameObject3;
				Transform transform = gameObject3.transform;
				List<CustomLevelData> allDynamicLevels = LevelManager.GetAllDynamicLevels();
				Func<CustomLevelData, int> func;
				if (CustomLevelMenu.<>c.<>9__11_0 == 0)
				{
					CustomLevelMenu.<>c.<>9__11_0 = func;
				}
				IOrderedEnumerable<CustomLevelData> orderedEnumerable = Enumerable.OrderBy<CustomLevelData, int>(allDynamicLevels, func);
				if (num2 < typeof(IEnumerable<CustomLevelData>).TypeHandle)
				{
					num2 += num2;
					num2++;
				}
				if (num2 >= num2)
				{
					goto IL_009E;
				}
				num2 += num2;
				if (num2 != 0)
				{
					num2++;
					goto IL_009E;
				}
				IL_00E0:
				TextMeshProUGUI textMeshProUGUI;
				textMeshProUGUI += textMeshProUGUI;
				string text;
				textMeshProUGUI.m_CancellationTokenSource = text;
				num2++;
				while (num2 != 28)
				{
				}
				GameObject gameObject5;
				GameObject gameObject4 = gameObject5.transform.gameObject;
				int num5 = 0;
				gameObject4.SetActive(num5 != 0);
				if ("{il2cpp array field local35->}" != (ulong)0L)
				{
				}
				if (num2 == 0)
				{
					break;
				}
				continue;
				IL_009E:
				CustomButton_enterGame customButton_enterGame;
				CustomLevelData levelData = customButton_enterGame.levelData;
				textMeshProUGUI = customButton_enterGame.levelName;
				CustomButton_enterGame customButton_enterGame2;
				string text2 = string.Format("({0})", customButton_enterGame2);
				textMeshProUGUI.text = text;
				IntPtr cachedPtr = textMeshProUGUI.m_CachedPtr;
				CancellationTokenSource cancellationTokenSource = textMeshProUGUI.m_CancellationTokenSource;
				textMeshProUGUI += textMeshProUGUI;
				goto IL_00E0;
			}
		}
		int num6 = 0;
		GameObject gameObject6;
		gameObject6.SetActive(num6 != 0);
		int num7 = 0;
		gameObject6.SetActive(num7 != 0);
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x000E4AF0 File Offset: 0x000E2CF0
	[Token(Token = "0x6002A46")]
	[Address(RVA = "0x690F30", Offset = "0x68F530", VA = "0x180690F30")]
	public void OpenFile()
	{
		string levelFolderPath = LevelConstants.LevelFolderPath;
		if (!Directory.Exists(levelFolderPath))
		{
			Debug.Log("文件夹不存在，正在创建: " + levelFolderPath);
			DirectoryInfo directoryInfo = Directory.CreateDirectory(levelFolderPath);
		}
		string fullPath = Path.GetFullPath(levelFolderPath);
		Application.OpenURL("file://" + fullPath);
		string text = "文件夹已打开: " + fullPath;
		Debug.Log(text);
		Debug.LogError(text + text + text + fullPath);
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x000E4B6C File Offset: 0x000E2D6C
	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x690E00", Offset = "0x68F400", VA = "0x180690E00")]
	public void LookAll()
	{
		ulong num;
		do
		{
			List<CustomButton_enterGame> list = this.levels;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				gameObject.SetActive(true);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x000E4BA8 File Offset: 0x000E2DA8
	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x691350", Offset = "0x68F950", VA = "0x180691350")]
	public void Shooting()
	{
		ulong num2;
		do
		{
			List<CustomButton_enterGame> list = this.levels;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				gameObject.SetActive(num != 0);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x000E4BF4 File Offset: 0x000E2DF4
	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x691200", Offset = "0x68F800", VA = "0x180691200")]
	public void ScaryPot()
	{
		ulong num2;
		do
		{
			List<CustomButton_enterGame> list = this.levels;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				gameObject.SetActive(num != 0);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x000E4C40 File Offset: 0x000E2E40
	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x68FB80", Offset = "0x68E180", VA = "0x18068FB80")]
	public void IZ()
	{
		ulong num2;
		do
		{
			List<CustomButton_enterGame> list = this.levels;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				gameObject.SetActive(num != 0);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x000E4C8C File Offset: 0x000E2E8C
	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x6914A0", Offset = "0x68FAA0", VA = "0x1806914A0")]
	public void SuperRandom()
	{
		ulong num2;
		do
		{
			List<CustomButton_enterGame> list = this.levels;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				gameObject.SetActive(num != 0);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x000E4CD8 File Offset: 0x000E2ED8
	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x691630", Offset = "0x68FC30", VA = "0x180691630")]
	public CustomLevelMenu()
	{
		List<CustomButton_enterGame> list = new List();
		this.levels = list;
		List<Transform> list2 = new List();
		this.containers = list2;
		base..ctor();
	}

	// Token: 0x0400182E RID: 6190
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400182E")]
	public CustomButton_enterGame sampleLevel;

	// Token: 0x0400182F RID: 6191
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400182F")]
	public GameObject samplePage;

	// Token: 0x04001830 RID: 6192
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001830")]
	public Transform pageHead;

	// Token: 0x04001831 RID: 6193
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001831")]
	private bool loading;

	// Token: 0x04001832 RID: 6194
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001832")]
	private List<CustomButton_enterGame> levels;

	// Token: 0x04001833 RID: 6195
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001833")]
	public List<Transform> containers;

	// Token: 0x04001834 RID: 6196
	[Token(Token = "0x4001834")]
	public static bool local;
}
