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

// Token: 0x020007E0 RID: 2016
[Token(Token = "0x20007E0")]
public class CustomLevelMenu : BaseMenu
{
	// Token: 0x06002912 RID: 10514 RVA: 0x000DF870 File Offset: 0x000DDA70
	[Token(Token = "0x6002912")]
	[Address(RVA = "0x62C1C0", Offset = "0x62A7C0", VA = "0x18062C1C0", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		int num = 0;
		this.InitOnlineWindow(num != 0);
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x000DF8A4 File Offset: 0x000DDAA4
	[Token(Token = "0x6002913")]
	[Address(RVA = "0x62D820", Offset = "0x62BE20", VA = "0x18062D820")]
	public void ReloadFiles()
	{
		LevelManager.ReLoad();
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("已重新加载文件", 3f, num != 0);
		this.InitLocalWindows();
	}

	// Token: 0x06002914 RID: 10516 RVA: 0x000DF8E0 File Offset: 0x000DDAE0
	[Token(Token = "0x6002914")]
	[Address(RVA = "0x62D440", Offset = "0x62BA40", VA = "0x18062D440")]
	public void LoadOnlineFiles()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x000DF904 File Offset: 0x000DDB04
	[Token(Token = "0x6002915")]
	[Address(RVA = "0x62CD40", Offset = "0x62B340", VA = "0x18062CD40")]
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

	// Token: 0x06002916 RID: 10518 RVA: 0x000DFA08 File Offset: 0x000DDC08
	[Token(Token = "0x6002916")]
	[Address(RVA = "0x62C3D0", Offset = "0x62A9D0", VA = "0x18062C3D0")]
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

	// Token: 0x06002917 RID: 10519 RVA: 0x000DFB74 File Offset: 0x000DDD74
	[Token(Token = "0x6002917")]
	[Address(RVA = "0x62D630", Offset = "0x62BC30", VA = "0x18062D630")]
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

	// Token: 0x06002918 RID: 10520 RVA: 0x000DFBF0 File Offset: 0x000DDDF0
	[Token(Token = "0x6002918")]
	[Address(RVA = "0x62D500", Offset = "0x62BB00", VA = "0x18062D500")]
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

	// Token: 0x06002919 RID: 10521 RVA: 0x000DFC2C File Offset: 0x000DDE2C
	[Token(Token = "0x6002919")]
	[Address(RVA = "0x62DA40", Offset = "0x62C040", VA = "0x18062DA40")]
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

	// Token: 0x0600291A RID: 10522 RVA: 0x000DFC78 File Offset: 0x000DDE78
	[Token(Token = "0x600291A")]
	[Address(RVA = "0x62D8F0", Offset = "0x62BEF0", VA = "0x18062D8F0")]
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

	// Token: 0x0600291B RID: 10523 RVA: 0x000DFCC4 File Offset: 0x000DDEC4
	[Token(Token = "0x600291B")]
	[Address(RVA = "0x62C280", Offset = "0x62A880", VA = "0x18062C280")]
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

	// Token: 0x0600291C RID: 10524 RVA: 0x000DFD10 File Offset: 0x000DDF10
	[Token(Token = "0x600291C")]
	[Address(RVA = "0x62DB90", Offset = "0x62C190", VA = "0x18062DB90")]
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

	// Token: 0x0600291D RID: 10525 RVA: 0x000DFD5C File Offset: 0x000DDF5C
	[Token(Token = "0x600291D")]
	[Address(RVA = "0x62DD20", Offset = "0x62C320", VA = "0x18062DD20")]
	public CustomLevelMenu()
	{
		List<CustomButton_enterGame> list = new List();
		this.levels = list;
		List<Transform> list2 = new List();
		this.containers = list2;
		base..ctor();
	}

	// Token: 0x04001752 RID: 5970
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001752")]
	public CustomButton_enterGame sampleLevel;

	// Token: 0x04001753 RID: 5971
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001753")]
	public GameObject samplePage;

	// Token: 0x04001754 RID: 5972
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001754")]
	public Transform pageHead;

	// Token: 0x04001755 RID: 5973
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001755")]
	private bool loading;

	// Token: 0x04001756 RID: 5974
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001756")]
	private List<CustomButton_enterGame> levels;

	// Token: 0x04001757 RID: 5975
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001757")]
	public List<Transform> containers;

	// Token: 0x04001758 RID: 5976
	[Token(Token = "0x4001758")]
	public static bool local;
}
