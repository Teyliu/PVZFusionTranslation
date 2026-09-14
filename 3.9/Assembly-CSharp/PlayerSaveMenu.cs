using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200082F RID: 2095
[Token(Token = "0x200082F")]
public class PlayerSaveMenu : BaseMenu
{
	// Token: 0x06002ACC RID: 10956 RVA: 0x000E8288 File Offset: 0x000E6488
	[Token(Token = "0x6002ACC")]
	[Address(RVA = "0x6A60D0", Offset = "0x6A46D0", VA = "0x1806A60D0", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.RefreshPlayerList();
		this.SetupDefaultPlayerButton();
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x000E82A8 File Offset: 0x000E64A8
	[Token(Token = "0x6002ACD")]
	[Address(RVA = "0x6A80C0", Offset = "0x6A66C0", VA = "0x1806A80C0")]
	private void SetupDefaultPlayerButton()
	{
		for (;;)
		{
			GameObject gameObject = this.sampleName;
			int num = 0;
			if (gameObject == num)
			{
				goto IL_0079;
			}
			GameObject gameObject2 = this.sampleName;
			bool flag;
			if (!flag)
			{
				break;
			}
			UnityAction unityAction = delegate
			{
				List<PlayerSaveMenu.PlayerData> list3 = this.allPlayers;
				Predicate<PlayerSaveMenu.PlayerData> <>9__8_ = PlayerSaveMenu.<>c.<>9__8_1;
				if (<>9__8_ == 0)
				{
					Predicate<PlayerSaveMenu.PlayerData> predicate;
					PlayerSaveMenu.<>c.<>9__8_1 = predicate;
				}
				PlayerSaveMenu.PlayerData playerData = list3.Find(<>9__8_);
				if (playerData != 0)
				{
					this.currentSelect = playerData;
					this.UpdateButtonsSelectionState();
					string name = playerData.name;
					Debug.Log("已选择存档：" + name);
				}
			};
			List<PlayerSaveMenu.PlayerData> list = this.allPlayers;
			int num2 = 0;
			if (string.Equals(list[num2].name, "Player"))
			{
				goto Block_2;
			}
		}
		Debug.LogWarning("sampleName 预制体上未找到 TheButton 组件");
		return;
		Block_2:
		List<PlayerSaveMenu.PlayerData> list2 = this.allPlayers;
		int num3 = 0;
		ulong num4;
		list2[num3].button = num4;
		return;
		IL_0079:
		Debug.LogWarning("sampleName 未设置，无法设置默认存档按钮");
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x000E8340 File Offset: 0x000E6540
	[Token(Token = "0x6002ACE")]
	[Address(RVA = "0x6A7D40", Offset = "0x6A6340", VA = "0x1806A7D40")]
	public void ResetName()
	{
		if (this.currentSelect != (ulong)0L)
		{
			if (!string.Equals(this.currentSelect.name, "Player"))
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				Transform canvasUp = GameAPP.canvasUp;
				int num = 0;
				int num2 = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)75), canvasUp, num2 != 0);
				ReNameMenu menu;
				if (baseMenu == 0)
				{
					menu = num;
				}
				menu = baseMenu;
				menu.title.text = "重命名你的存档";
				PlayerSaveMenu.PlayerData playerData = this.currentSelect;
				ReNameMenu menu2 = menu;
				string name = playerData.name;
				TMP_InputField input = menu2.input;
				int num3 = 0;
				if (input != num3)
				{
					menu2.input.text = name;
				}
				UnityEvent clickEvent = menu.activeButton.clickEvent;
				UnityAction unityAction = delegate
				{
					TMP_InputField input2 = menu.input;
					PlayerSaveMenu <>4__this = this;
					PlayerSaveMenu.PlayerData playerData2 = <>4__this.currentSelect;
					string text = input2.m_Text;
					string name2 = playerData2.name;
					<>4__this.RenamePlayerData(name2, text);
					PlayerSaveMenu <>4__this2 = this;
					throw new NullReferenceException();
				};
				clickEvent.AddListener(unityAction);
				return;
			}
			InGameText instance = InGameText.Instance;
		}
		InGameText instance2 = InGameText.Instance;
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x000E8464 File Offset: 0x000E6664
	[Token(Token = "0x6002ACF")]
	[Address(RVA = "0x6A6640", Offset = "0x6A4C40", VA = "0x1806A6640")]
	public void CreatePlayerData()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		int num2 = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)75), canvasUp, num2 != 0);
		ReNameMenu menu;
		if (baseMenu == 0)
		{
			menu = num;
		}
		menu = baseMenu;
		menu.title.text = "请输入你的名字";
		UnityEvent clickEvent = menu.activeButton.clickEvent;
		UnityAction unityAction = delegate
		{
			TMP_InputField input = menu.input;
			PlayerSaveMenu <>4__this = this;
			string text = input.m_Text;
			<>4__this.NewPlayerData(text);
			PlayerSaveMenu <>4__this2 = this;
			throw new NullReferenceException();
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x000E84F8 File Offset: 0x000E66F8
	[Token(Token = "0x6002AD0")]
	[Address(RVA = "0x6A6850", Offset = "0x6A4E50", VA = "0x1806A6850")]
	public void DeletePlayerData()
	{
		UIResourcesLoader uimanager = GameAPP.UIManager;
		Transform canvasUp = GameAPP.canvasUp;
		int num = 0;
		BaseMenu baseMenu = uimanager.Push((UIType)((uint)68), canvasUp, num != 0);
		UnityAction unityAction = delegate
		{
			string name = this.currentSelect.name;
			this.RemovePlayerData(name);
			throw new NullReferenceException();
		};
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x000E8538 File Offset: 0x000E6738
	[Token(Token = "0x6002AD1")]
	[Address(RVA = "0x6A6EB0", Offset = "0x6A54B0", VA = "0x1806A6EB0")]
	public void OK()
	{
		GameAPP.playerName = this.currentSelect.name;
		SaveInfo.SaveLastSelectedSave(this.currentSelect.name);
		SaveInfo.Instance.LoadPlayerData();
		UIMgr.EnterMainMenu();
		CursorChange.SetDefaultCursor();
		string name = this.currentSelect.name;
		Debug.Log("已切换到存档：" + name + "，下次启动将自动加载此存档");
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x000E85A8 File Offset: 0x000E67A8
	[Token(Token = "0x6002AD2")]
	[Address(RVA = "0x6A6AC0", Offset = "0x6A50C0", VA = "0x1806A6AC0")]
	private void NewPlayerData(string name)
	{
		if (!string.IsNullOrEmpty(name))
		{
			if (!string.Equals(name, "Player"))
			{
				string path = this.GetPath(name);
				Debug.Log("创建存档路径：" + path);
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					string text = Path.Combine(path, "playerData.json");
					string text2 = JsonUtility.ToJson(new PlatyerSettings(), true);
					File.WriteAllText(text, text2);
					InGameText instance = InGameText.Instance;
					string text3 = "存档 " + name + " 创建成功";
					this.RefreshPlayerList();
				}
				InGameText instance2 = InGameText.Instance;
				GameAPP.PlaySound(26, 0.5f, 1f);
				string text4;
				Debug.Log(text4);
				InGameText instance3 = InGameText.Instance;
			}
			InGameText instance4 = InGameText.Instance;
		}
		InGameText instance5 = InGameText.Instance;
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x000E86A0 File Offset: 0x000E68A0
	[Token(Token = "0x6002AD3")]
	[Address(RVA = "0x6A7640", Offset = "0x6A5C40", VA = "0x1806A7640")]
	private void RemovePlayerData(string name)
	{
		if (!string.Equals(name, "Player"))
		{
			string path = this.GetPath(name);
			Debug.Log("指定路径：" + path);
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			string text;
			Debug.Log(text);
			return;
		}
		InGameText instance = InGameText.Instance;
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x000E870C File Offset: 0x000E690C
	[Token(Token = "0x6002AD4")]
	[Address(RVA = "0x6A7800", Offset = "0x6A5E00", VA = "0x1806A7800")]
	private void RenamePlayerData(string oldName, string newName)
	{
		string name = this.currentSelect.name;
		if ("Player" == 0)
		{
			bool flag = string.IsNullOrEmpty(newName);
			if (!flag)
			{
				if (!flag)
				{
					if (!flag)
					{
						string path = this.GetPath(oldName);
						string path2 = this.GetPath(newName);
						Debug.Log("重命名存档：" + path + " -> " + path2);
						if (Directory.Exists(path))
						{
							bool flag2 = Directory.Exists(path2);
							if (!flag2)
							{
								Directory.Move(path, path2);
								string playerName = GameAPP.playerName;
								if (flag2)
								{
									GameAPP.playerName = newName;
								}
								InGameText instance = InGameText.Instance;
								string text = "存档已重命名为 " + newName;
								this.RefreshPlayerList();
							}
							InGameText instance2 = InGameText.Instance;
							uint num;
							GameAPP.PlaySound((int)num, 0.5f, 1f);
						}
						InGameText instance3 = InGameText.Instance;
						uint num2;
						GameAPP.PlaySound((int)num2, 0.5f, 1f);
						string text2;
						Debug.Log(text2);
						InGameText instance4 = InGameText.Instance;
					}
					base.PopMenu();
					return;
				}
				InGameText instance5 = InGameText.Instance;
			}
			InGameText instance6 = InGameText.Instance;
		}
		InGameText instance7 = InGameText.Instance;
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x000E885C File Offset: 0x000E6A5C
	[Token(Token = "0x6002AD5")]
	[Address(RVA = "0x6A69B0", Offset = "0x6A4FB0", VA = "0x1806A69B0")]
	private string GetPath(string name)
	{
		if (!string.Equals(name, "Player"))
		{
			return Path.Combine(Application.persistentDataPath, "Saves", name);
		}
		return Path.Combine(Application.persistentDataPath, "playerData");
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x000E889C File Offset: 0x000E6A9C
	[Token(Token = "0x6002AD6")]
	[Address(RVA = "0x6A62D0", Offset = "0x6A48D0", VA = "0x1806A62D0")]
	private void CreateButton(PlayerSaveMenu.PlayerData playerData)
	{
		GameObject gameObject = this.sampleName;
		int num = 0;
		if (!(gameObject == num))
		{
			GameObject gameObject2 = this.sampleName;
			Transform parent = gameObject2.transform.parent;
			TheButton component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, parent).GetComponent<TheButton>();
			Transform transform = component.transform;
			int siblingIndex = this.sampleName.transform.GetSiblingIndex();
			int num2 = siblingIndex + 1;
			transform.SetSiblingIndex(num2);
			PlayerSaveMenu.PlayerData playerData2 = playerData;
			List<TheButton> list = this.dynamicallyCreatedButtons;
			int size = list._size;
			list._size = siblingIndex;
			TextMeshProUGUI componentInChildren = component.GetComponentInChildren<TextMeshProUGUI>();
			int num3 = 0;
			if (!(componentInChildren != num3))
			{
				Debug.LogWarning("按钮上未找到 TextMeshProUGUI 组件");
			}
			string name = playerData.name;
			componentInChildren.text = name;
			UnityEvent theEvent_up = component.theEvent_up;
			UnityAction unityAction = delegate
			{
				PlayerSaveMenu <>4__this = this;
				PlayerSaveMenu.PlayerData playerData3 = playerData;
				<>4__this.currentSelect = playerData3;
				<>4__this.UpdateButtonsSelectionState();
				string name2 = playerData3.name;
				Debug.Log("已选择存档：" + name2);
			};
			theEvent_up.AddListener(unityAction);
			return;
		}
		Debug.LogError("sampleName 预制体未设置，无法创建按钮");
		throw new NullReferenceException();
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x000E89AC File Offset: 0x000E6BAC
	[Token(Token = "0x6002AD7")]
	[Address(RVA = "0x6A7000", Offset = "0x6A5600", VA = "0x1806A7000")]
	private void OnPlayerButtonClicked(PlayerSaveMenu.PlayerData clickedPlayerData)
	{
		this.currentSelect = clickedPlayerData;
		this.UpdateButtonsSelectionState();
		string name = clickedPlayerData.name;
		Debug.Log("已选择存档：" + name);
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000E89E4 File Offset: 0x000E6BE4
	[Token(Token = "0x6002AD8")]
	[Address(RVA = "0x6A70A0", Offset = "0x6A56A0", VA = "0x1806A70A0")]
	public void RefreshPlayerList()
	{
		int num = 0;
		int num2 = 0;
		this.ClearDynamicButtons();
		string text = Path.Combine(Application.persistentDataPath, "Saves");
		if (!Directory.Exists(text))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
			Debug.Log("创建存档文件夹：" + text);
		}
		string[] directories = Directory.GetDirectories(text);
		if (this.currentSelect != 0)
		{
		}
		List<PlayerSaveMenu.PlayerData> list = this.allPlayers;
		int size = list._size;
		list._size = num2;
		if (size > 0)
		{
		}
		GameObject gameObject = this.sampleName;
		if (gameObject != 0)
		{
			TheButton component = gameObject.GetComponent<TheButton>();
		}
		List<PlayerSaveMenu.PlayerData> list2 = this.allPlayers;
		PlayerSaveMenu.PlayerData playerData;
		playerData.name = "Player";
		playerData.button = num2;
		int size2 = list2._size;
		list2._size = playerData;
		if (num2 < directories.Length)
		{
			string fileName = Path.GetFileName(directories[num2]);
			if (!string.Equals(fileName, "Player"))
			{
				PlayerSaveMenu.PlayerData playerData2;
				playerData2.name = fileName;
				playerData2.button = num2;
				List<PlayerSaveMenu.PlayerData> list3 = this.allPlayers;
				this.CreateButton(playerData2);
			}
			num2++;
		}
		if (!string.IsNullOrEmpty(num2))
		{
			List<PlayerSaveMenu.PlayerData> list4 = this.allPlayers;
			bool flag;
			if (flag)
			{
				while (!flag)
				{
				}
				this.currentSelect = num;
			}
		}
		if (this.currentSelect == (ulong)0L)
		{
			List<PlayerSaveMenu.PlayerData> list5 = this.allPlayers;
			int num3 = 0;
			PlayerSaveMenu.PlayerData playerData3 = list5[num3];
			this.currentSelect = playerData3;
		}
		this.UpdateButtonsSelectionState();
		if (num2 == 0)
		{
			TypeCode typeCode = num2.GetTypeCode();
			string text2;
			Debug.LogError(text2);
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x000E8BAC File Offset: 0x000E6DAC
	[Token(Token = "0x6002AD9")]
	[Address(RVA = "0x6A6100", Offset = "0x6A4700", VA = "0x1806A6100")]
	private void ClearDynamicButtons()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<TheButton> list = this.dynamicallyCreatedButtons;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000E8BF4 File Offset: 0x000E6DF4
	[Token(Token = "0x6002ADA")]
	[Address(RVA = "0x6A8510", Offset = "0x6A6B10", VA = "0x1806A8510")]
	private void UpdateButtonsSelectionState()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<PlayerSaveMenu.PlayerData> list = this.allPlayers;
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				bool flag3;
				while (!flag3)
				{
				}
				bool flag4 = num == this.currentSelect;
			}
		}
		while (num2 != 0);
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000E8C40 File Offset: 0x000E6E40
	[Token(Token = "0x6002ADB")]
	[Address(RVA = "0x6A86D0", Offset = "0x6A6CD0", VA = "0x1806A86D0")]
	public PlayerSaveMenu()
	{
		List<PlayerSaveMenu.PlayerData> list = new List();
		this.allPlayers = list;
		List<TheButton> list2 = new List();
		this.dynamicallyCreatedButtons = list2;
		base..ctor();
	}

	// Token: 0x040018D1 RID: 6353
	[Token(Token = "0x40018D1")]
	public const string defaultName = "Player";

	// Token: 0x040018D2 RID: 6354
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018D2")]
	public GameObject sampleName;

	// Token: 0x040018D3 RID: 6355
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018D3")]
	public RectTransform content;

	// Token: 0x040018D4 RID: 6356
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018D4")]
	public PlayerSaveMenu.PlayerData currentSelect;

	// Token: 0x040018D5 RID: 6357
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018D5")]
	public List<PlayerSaveMenu.PlayerData> allPlayers;

	// Token: 0x040018D6 RID: 6358
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018D6")]
	private List<TheButton> dynamicallyCreatedButtons;

	// Token: 0x02000830 RID: 2096
	[Token(Token = "0x2000830")]
	[Serializable]
	public class PlayerData
	{
		// Token: 0x06002ADE RID: 10974 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlayerData()
		{
		}

		// Token: 0x040018D7 RID: 6359
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40018D7")]
		public TheButton button;

		// Token: 0x040018D8 RID: 6360
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40018D8")]
		public string name;
	}
}
