using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x020007E5 RID: 2021
[Token(Token = "0x20007E5")]
public class LevelSaveEnter : TheButton
{
	// Token: 0x06002908 RID: 10504 RVA: 0x000DD338 File Offset: 0x000DB538
	[Token(Token = "0x6002908")]
	[Address(RVA = "0x666620", Offset = "0x664C20", VA = "0x180666620")]
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

	// Token: 0x06002909 RID: 10505 RVA: 0x000DD458 File Offset: 0x000DB658
	[Token(Token = "0x6002909")]
	[Address(RVA = "0x666510", Offset = "0x664B10", VA = "0x180666510")]
	public void EnterGame()
	{
		SaveInfo instance = SaveInfo.Instance;
		CursorChange.SetDefaultCursor();
		int num = this.id;
		string text = this.path;
		Debug.Log(string.Format("进入存档：id：{0}，路径：{1}", num, text));
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x000DD49C File Offset: 0x000DB69C
	[Token(Token = "0x600290A")]
	[Address(RVA = "0x666180", Offset = "0x664780", VA = "0x180666180")]
	public void DeleteLevel()
	{
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
		string text;
		Debug.LogWarning(text);
		throw new MissingMethodException();
	}

	// Token: 0x0600290B RID: 10507 RVA: 0x000DD4CC File Offset: 0x000DB6CC
	[Token(Token = "0x600290B")]
	[Address(RVA = "0x6662F0", Offset = "0x6648F0", VA = "0x1806662F0")]
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

	// Token: 0x0600290C RID: 10508 RVA: 0x000DD57C File Offset: 0x000DB77C
	[Token(Token = "0x600290C")]
	[Address(RVA = "0x6669C0", Offset = "0x664FC0", VA = "0x1806669C0")]
	public LevelSaveEnter()
	{
	}

	// Token: 0x040016EE RID: 5870
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016EE")]
	public string path;

	// Token: 0x040016EF RID: 5871
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40016EF")]
	public TextMeshProUGUI text;

	// Token: 0x040016F0 RID: 5872
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40016F0")]
	public int id;

	// Token: 0x040016F1 RID: 5873
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40016F1")]
	public SurvivalLevel level;

	// Token: 0x040016F2 RID: 5874
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40016F2")]
	public SurvivalData data;

	// Token: 0x040016F3 RID: 5875
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40016F3")]
	public GameObject outLine;

	// Token: 0x040016F4 RID: 5876
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40016F4")]
	public Image icon;
}
