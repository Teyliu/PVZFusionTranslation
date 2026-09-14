using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x0200082B RID: 2091
[Token(Token = "0x200082B")]
public class PlantCardPackageBuilder : MonoBehaviour
{
	// Token: 0x06002ABA RID: 10938 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
	[Token(Token = "0x6002ABA")]
	[Address(RVA = "0x6A4670", Offset = "0x6A2C70", VA = "0x1806A4670")]
	private void Awake()
	{
		List<PlantType> allPlantTypes = global::Lawnf.GetAllPlantTypes();
		this.RegisterGroup("全部植物", allPlantTypes);
		List<PlantType> ultimatePlants = global::Lawnf.GetUltimatePlants();
		this.RegisterGroup("究极植物", ultimatePlants);
		List<PlantType> list = new List();
		AdvantureCardLayout[] enumValues = global::Core.Lawnf.GetEnumValues<AdvantureCardLayout>();
		int num = 0;
		if (num < enumValues.Length)
		{
			int num2 = (int)enumValues.ConvertTo<PlantType>();
			int size = list._size;
			num++;
			list._size = 1;
			num++;
		}
		this.RegisterGroup("冒险植物", list);
		UnityEvent clickEvent = this.lastPage.clickEvent;
		UnityAction unityAction = new UnityAction(this.LastPage);
		clickEvent.AddListener(unityAction);
		UnityEvent clickEvent2 = this.nextPage.clickEvent;
		UnityAction unityAction2 = new UnityAction(this.NextPage);
		clickEvent2.AddListener(unityAction2);
	}

	// Token: 0x06002ABB RID: 10939 RVA: 0x000E7B7C File Offset: 0x000E5D7C
	[Token(Token = "0x6002ABB")]
	[Address(RVA = "0x6A5480", Offset = "0x6A3A80", VA = "0x1806A5480")]
	private void Start()
	{
		this.Look("冒险植物");
	}

	// Token: 0x06002ABC RID: 10940 RVA: 0x000E7B94 File Offset: 0x000E5D94
	[Token(Token = "0x6002ABC")]
	[Address(RVA = "0x6A49E0", Offset = "0x6A2FE0", VA = "0x1806A49E0")]
	private void Look(string name)
	{
		Page page = this.currentShow;
		int num = 0;
		if (page != num)
		{
			GameObject gameObject = this.currentShow.gameObject;
			int num2 = 0;
			gameObject.SetActive(num2 != 0);
		}
		Page page2 = this.groups[name];
		this.currentShow = page2;
		this.currentShow.gameObject.SetActive(true);
		this.UpdateText();
	}

	// Token: 0x06002ABD RID: 10941 RVA: 0x000E7BFC File Offset: 0x000E5DFC
	[Token(Token = "0x6002ABD")]
	[Address(RVA = "0x6A54C0", Offset = "0x6A3AC0", VA = "0x1806A54C0")]
	private void UpdateText()
	{
		Page page = this.currentShow;
		int num = 0;
		int childCount = page.transform.childCount;
		if (num < childCount)
		{
			GameObject gameObject = this.currentShow.transform.GetChild(num).gameObject;
			bool flag = gameObject.name != "page";
			bool activeSelf = gameObject.activeSelf;
			Page page2 = this.currentShow;
			num++;
		}
		TextMeshProUGUI textMeshProUGUI = this.text;
		int num2;
		int num3;
		string text = string.Format("{0}/{1}页", num2, num3);
		textMeshProUGUI.text = text;
	}

	// Token: 0x06002ABE RID: 10942 RVA: 0x000E7C88 File Offset: 0x000E5E88
	[Token(Token = "0x6002ABE")]
	[Address(RVA = "0x6A4D00", Offset = "0x6A3300", VA = "0x1806A4D00")]
	private void RegisterGroup(string name, List<PlantType> plants)
	{
		Page page = this.sampleGroup;
		Transform parent = page.transform.parent;
		Page page2 = global::UnityEngine.Object.Instantiate<Page>(page, parent);
		string name;
		page2.name = name;
		this.groups[name] = page2;
		Transform transform = page2.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		List<GameObject> list = new List();
		int num2 = 0;
		int num3 = 0;
		Transform transform2 = page2.transform;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform2);
		int num4;
		string text = string.Format("PlantCardPage_{0}", num4);
		gameObject2.name = text;
		int size = list._size;
		list._size = text;
		int num5 = plants._size;
		num5 -= num3;
		int num6 = 0;
		if (num5 > 63)
		{
		}
		if (num5 > 0)
		{
			PlantType plantType = plants[0];
			GameObject gameObject3;
			Transform transform3 = gameObject3.transform;
			Transform transform4 = gameObject2.transform;
			transform3.parentInternal = transform4;
			Transform transform5 = gameObject3.transform;
			CardUI cardUI;
			Transform transform6 = cardUI.transform;
			Transform transform7 = gameObject3.transform;
			transform6.parentInternal = transform7;
			Transform transform8 = cardUI.transform;
			cardUI.parent = gameObject3;
			int num7 = 0;
			num6++;
			cardUI.CD = (float)num7;
			cardUI.theSeedCost = num7;
		}
		num2++;
		num3 += 63;
		global::UnityEngine.Object.Destroy(gameObject);
		uint num8;
		GameObject gameObject4 = list[(int)num8];
		int num9 = 0;
		gameObject4.SetActive(num9 != 0);
		num8 += (uint)1;
		name = name;
		UIButton uibutton = this.sampleButton;
		Transform parent2 = uibutton.transform.parent;
		UIButton uibutton2 = global::UnityEngine.Object.Instantiate<UIButton>(uibutton, parent2);
		TextMeshProUGUI componentInChildren = uibutton2.GetComponentInChildren<TextMeshProUGUI>();
		string name2 = name;
		componentInChildren.text = name2;
		uibutton2.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent = uibutton2.clickEvent;
		UnityAction unityAction = delegate
		{
			PlantCardPackageBuilder <>4__this = this;
			string name3 = name;
			<>4__this.Look(name3);
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x000E7E7C File Offset: 0x000E607C
	[Token(Token = "0x6002ABF")]
	[Address(RVA = "0x6A4B60", Offset = "0x6A3160", VA = "0x1806A4B60")]
	private void RegisterButton(string name)
	{
		UIButton uibutton = this.sampleButton;
		Transform parent = uibutton.transform.parent;
		UIButton uibutton2 = global::UnityEngine.Object.Instantiate<UIButton>(uibutton, parent);
		TextMeshProUGUI componentInChildren = uibutton2.GetComponentInChildren<TextMeshProUGUI>();
		string name2 = name;
		componentInChildren.text = name2;
		uibutton2.clickEvent.RemoveAllListeners();
		UnityEvent clickEvent = uibutton2.clickEvent;
		UnityAction unityAction = delegate
		{
			PlantCardPackageBuilder <>4__this = this;
			string name3 = name;
			<>4__this.Look(name3);
		};
		clickEvent.AddListener(unityAction);
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000E7F04 File Offset: 0x000E6104
	[Token(Token = "0x6002AC0")]
	[Address(RVA = "0x6A4960", Offset = "0x6A2F60", VA = "0x1806A4960")]
	private void LastPage()
	{
		Page page = this.currentShow;
		int num = 0;
		if (page != num)
		{
			this.currentShow.LastPage();
			this.UpdateText();
		}
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000E7F3C File Offset: 0x000E613C
	[Token(Token = "0x6002AC1")]
	[Address(RVA = "0x6A4AE0", Offset = "0x6A30E0", VA = "0x1806A4AE0")]
	private void NextPage()
	{
		Page page = this.currentShow;
		int num = 0;
		if (page != num)
		{
			this.currentShow.NextPage();
			this.UpdateText();
		}
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000E7F74 File Offset: 0x000E6174
	[Token(Token = "0x6002AC2")]
	[Address(RVA = "0x6A5690", Offset = "0x6A3C90", VA = "0x1806A5690")]
	public PlantCardPackageBuilder()
	{
		Dictionary<string, Page> dictionary = new Dictionary();
		this.groups = dictionary;
		base..ctor();
	}

	// Token: 0x040018C0 RID: 6336
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018C0")]
	[Header("预制体？")]
	public Page sampleGroup;

	// Token: 0x040018C1 RID: 6337
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018C1")]
	public UIButton sampleButton;

	// Token: 0x040018C2 RID: 6338
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018C2")]
	[Header("按钮")]
	public UIButton lastPage;

	// Token: 0x040018C3 RID: 6339
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018C3")]
	public UIButton nextPage;

	// Token: 0x040018C4 RID: 6340
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018C4")]
	[Header("文本")]
	public TextMeshProUGUI text;

	// Token: 0x040018C5 RID: 6341
	[Token(Token = "0x40018C5")]
	private const int CardInOnePage = 63;

	// Token: 0x040018C6 RID: 6342
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018C6")]
	private readonly Dictionary<string, Page> groups;

	// Token: 0x040018C7 RID: 6343
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018C7")]
	private Page currentShow;
}
