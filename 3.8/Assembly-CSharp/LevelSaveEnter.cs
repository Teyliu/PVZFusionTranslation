using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007AC RID: 1964
[Token(Token = "0x20007AC")]
public class LevelSaveEnter : TheButton
{
	// Token: 0x060027D9 RID: 10201 RVA: 0x000D837C File Offset: 0x000D657C
	[Token(Token = "0x60027D9")]
	[Address(RVA = "0x602E10", Offset = "0x601410", VA = "0x180602E10")]
	public void InitEnter()
	{
		TextMeshProUGUI textMeshProUGUI = this.text;
		if (this.id != -1)
		{
			object[] array = new object[4];
			string name = this.data.name;
			if (name != 0)
			{
			}
			array[0] = name;
			int num = this.id;
			if (num != 0)
			{
			}
			array[1] = num;
			string text = this.data.savedTime.ToDateTimeString();
			if (text != 0)
			{
			}
			array[2] = text;
			string version = this.data.version;
			if (version != 0)
			{
			}
			array[3] = version;
			string text2 = string.Format("{0}，编号：{1}\n保存时间：{2}\n版本：{3}", array);
			textMeshProUGUI.text = text2;
			return;
		}
		string[] array2 = new string[5];
		string name2 = this.data.name;
		array2[0] = name2;
		array2[1] = "，最近一次自动保存\n保存时间：";
		string text3 = this.data.savedTime.ToDateTimeString();
		array2[2] = text3;
		array2[3] = "\n版本：";
		string version2 = this.data.version;
		array2[4] = version2;
		string text4 = string.Concat(array2);
		throw new IndexOutOfRangeException();
	}

	// Token: 0x060027DA RID: 10202 RVA: 0x000D849C File Offset: 0x000D669C
	[Token(Token = "0x60027DA")]
	[Address(RVA = "0x602D00", Offset = "0x601300", VA = "0x180602D00")]
	public void EnterGame()
	{
		SaveInfo instance = SaveInfo.Instance;
		CursorChange.SetDefaultCursor();
		int num = this.id;
		string text = this.path;
		Debug.Log(string.Format("进入存档：id：{0}，路径：{1}", num, text));
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x000D84E0 File Offset: 0x000D66E0
	[Token(Token = "0x60027DB")]
	[Address(RVA = "0x602970", Offset = "0x600F70", VA = "0x180602970")]
	public void DeleteLevel()
	{
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		string text;
		Debug.LogWarning(text);
		throw new MissingMethodException();
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x000D8510 File Offset: 0x000D6710
	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x602AE0", Offset = "0x6010E0", VA = "0x180602AE0")]
	public void EditLevel()
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
		menu.SetTitle("重命名你的存档");
		SurvivalData survivalData = this.data;
		ReNameMenu menu2 = menu;
		string name = survivalData.name;
		menu2.SetInputText(name);
		UnityEvent clickEvent = menu.activeButton.clickEvent;
		UnityAction unityAction = delegate
		{
			TMP_InputField input = menu.input;
			SurvivalData survivalData2 = this.data;
			string text = input.m_Text;
			survivalData2.name = text;
			this.InitEnter();
			menu.PopMenu();
			LevelSaveEnter <>4__this = this;
			SaveInfo instance = SaveInfo.Instance;
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x000D85C0 File Offset: 0x000D67C0
	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x6031B0", Offset = "0x6017B0", VA = "0x1806031B0")]
	public LevelSaveEnter()
	{
	}

	// Token: 0x04001612 RID: 5650
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001612")]
	public string path;

	// Token: 0x04001613 RID: 5651
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001613")]
	public TextMeshProUGUI text;

	// Token: 0x04001614 RID: 5652
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001614")]
	public int id;

	// Token: 0x04001615 RID: 5653
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4001615")]
	public SurvivalLevel level;

	// Token: 0x04001616 RID: 5654
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001616")]
	public SurvivalData data;

	// Token: 0x04001617 RID: 5655
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001617")]
	public GameObject outLine;

	// Token: 0x04001618 RID: 5656
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001618")]
	public Image icon;
}
