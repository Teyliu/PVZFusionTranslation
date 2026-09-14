using System;
using System.Collections.Generic;
using System.IO;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020007F4 RID: 2036
[Token(Token = "0x20007F4")]
public class PlayerSaveMenu : BaseMenu
{
	// Token: 0x06002996 RID: 10646 RVA: 0x000E3110 File Offset: 0x000E1310
	[Token(Token = "0x6002996")]
	[Address(RVA = "0x641A20", Offset = "0x640020", VA = "0x180641A20", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.RefreshPlayerList();
		this.SetupDefaultPlayerButton();
	}

	// Token: 0x06002997 RID: 10647 RVA: 0x000E3130 File Offset: 0x000E1330
	[Token(Token = "0x6002997")]
	[Address(RVA = "0x643960", Offset = "0x641F60", VA = "0x180643960")]
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

	// Token: 0x06002998 RID: 10648 RVA: 0x000E31C8 File Offset: 0x000E13C8
	[Token(Token = "0x6002998")]
	[Address(RVA = "0x6435F0", Offset = "0x641BF0", VA = "0x1806435F0")]
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
		int num4 = 0;
		instance2.ShowText("请先选择一个存档", 3f, num4 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x000E3300 File Offset: 0x000E1500
	[Token(Token = "0x6002999")]
	[Address(RVA = "0x641F90", Offset = "0x640590", VA = "0x180641F90")]
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

	// Token: 0x0600299A RID: 10650 RVA: 0x000E3394 File Offset: 0x000E1594
	[Token(Token = "0x600299A")]
	[Address(RVA = "0x6421A0", Offset = "0x6407A0", VA = "0x1806421A0")]
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

	// Token: 0x0600299B RID: 10651 RVA: 0x000E33D4 File Offset: 0x000E15D4
	[Token(Token = "0x600299B")]
	[Address(RVA = "0x6427C0", Offset = "0x640DC0", VA = "0x1806427C0")]
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

	// Token: 0x0600299C RID: 10652 RVA: 0x000E3444 File Offset: 0x000E1644
	[Token(Token = "0x600299C")]
	[Address(RVA = "0x642410", Offset = "0x640A10", VA = "0x180642410")]
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
				int num = 0;
				instance2.ShowText("存档名称已存在", 3f, num != 0);
				GameAPP.PlaySound(26, 0.5f, 1f);
				string text4;
				Debug.Log(text4);
				InGameText instance3 = InGameText.Instance;
			}
			InGameText instance4 = InGameText.Instance;
		}
		InGameText instance5 = InGameText.Instance;
		int num2 = 0;
		instance5.ShowText("存档名称不能为空", 3f, num2 != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x0600299D RID: 10653 RVA: 0x000E3568 File Offset: 0x000E1768
	[Token(Token = "0x600299D")]
	[Address(RVA = "0x642F50", Offset = "0x641550", VA = "0x180642F50")]
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
		int num = 0;
		instance.ShowText("无法删除默认存档", 3f, num != 0);
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x0600299E RID: 10654 RVA: 0x000E35E8 File Offset: 0x000E17E8
	[Token(Token = "0x600299E")]
	[Address(RVA = "0x643100", Offset = "0x641700", VA = "0x180643100")]
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
								int num = 0;
								string text = "存档已重命名为 " + newName;
								int num2 = 0;
								instance.ShowText(text, (float)num, num2 != 0);
								this.RefreshPlayerList();
							}
							InGameText instance2 = InGameText.Instance;
							int num3 = 0;
							instance2.ShowText("存档名称已存在", 3f, num3 != 0);
							uint num4;
							GameAPP.PlaySound((int)num4, 0.5f, 1f);
						}
						InGameText instance3 = InGameText.Instance;
						int num5 = 0;
						instance3.ShowText("存档不存在", 3f, num5 != 0);
						uint num6;
						GameAPP.PlaySound((int)num6, 0.5f, 1f);
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
		int num7 = 0;
		instance7.ShowText("不可重命名默认存档", 3f, num7 != 0);
		uint num8;
		GameAPP.PlaySound((int)num8, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x0600299F RID: 10655 RVA: 0x000E3790 File Offset: 0x000E1990
	[Token(Token = "0x600299F")]
	[Address(RVA = "0x642300", Offset = "0x640900", VA = "0x180642300")]
	private string GetPath(string name)
	{
		if (!string.Equals(name, "Player"))
		{
			return Path.Combine(Application.persistentDataPath, "Saves", name);
		}
		return Path.Combine(Application.persistentDataPath, "playerData");
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x000E37D0 File Offset: 0x000E19D0
	[Token(Token = "0x60029A0")]
	[Address(RVA = "0x641C20", Offset = "0x640220", VA = "0x180641C20")]
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

	// Token: 0x060029A1 RID: 10657 RVA: 0x000E38E0 File Offset: 0x000E1AE0
	[Token(Token = "0x60029A1")]
	[Address(RVA = "0x642910", Offset = "0x640F10", VA = "0x180642910")]
	private void OnPlayerButtonClicked(PlayerSaveMenu.PlayerData clickedPlayerData)
	{
		this.currentSelect = clickedPlayerData;
		this.UpdateButtonsSelectionState();
		string name = clickedPlayerData.name;
		Debug.Log("已选择存档：" + name);
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x000E3918 File Offset: 0x000E1B18
	[Token(Token = "0x60029A2")]
	[Address(RVA = "0x6429B0", Offset = "0x640FB0", VA = "0x1806429B0")]
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

	// Token: 0x060029A3 RID: 10659 RVA: 0x000E3AE0 File Offset: 0x000E1CE0
	[Token(Token = "0x60029A3")]
	[Address(RVA = "0x641A50", Offset = "0x640050", VA = "0x180641A50")]
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

	// Token: 0x060029A4 RID: 10660 RVA: 0x000E3B28 File Offset: 0x000E1D28
	[Token(Token = "0x60029A4")]
	[Address(RVA = "0x643DB0", Offset = "0x6423B0", VA = "0x180643DB0")]
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

	// Token: 0x060029A5 RID: 10661 RVA: 0x000E3B74 File Offset: 0x000E1D74
	[Token(Token = "0x60029A5")]
	[Address(RVA = "0x643F70", Offset = "0x642570", VA = "0x180643F70")]
	public PlayerSaveMenu()
	{
		List<PlayerSaveMenu.PlayerData> list = new List();
		this.allPlayers = list;
		List<TheButton> list2 = new List();
		this.dynamicallyCreatedButtons = list2;
		base..ctor();
	}

	// Token: 0x040017E6 RID: 6118
	[Token(Token = "0x40017E6")]
	public const string defaultName = "Player";

	// Token: 0x040017E7 RID: 6119
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017E7")]
	public GameObject sampleName;

	// Token: 0x040017E8 RID: 6120
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017E8")]
	public RectTransform content;

	// Token: 0x040017E9 RID: 6121
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017E9")]
	public PlayerSaveMenu.PlayerData currentSelect;

	// Token: 0x040017EA RID: 6122
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017EA")]
	public List<PlayerSaveMenu.PlayerData> allPlayers;

	// Token: 0x040017EB RID: 6123
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017EB")]
	private List<TheButton> dynamicallyCreatedButtons;

	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	[Serializable]
	public class PlayerData
	{
		// Token: 0x060029A8 RID: 10664 RVA: 0x000E3C2C File Offset: 0x000E1E2C
		[Token(Token = "0x60029A8")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlayerData()
		{
		}

		// Token: 0x040017EC RID: 6124
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40017EC")]
		public TheButton button;

		// Token: 0x040017ED RID: 6125
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40017ED")]
		public string name;
	}
}
