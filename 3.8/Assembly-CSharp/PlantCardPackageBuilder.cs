using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020007F0 RID: 2032
[Token(Token = "0x20007F0")]
public class PlantCardPackageBuilder : MonoBehaviour
{
	// Token: 0x06002984 RID: 10628 RVA: 0x000E2930 File Offset: 0x000E0B30
	[Token(Token = "0x6002984")]
	[Address(RVA = "0x63FFC0", Offset = "0x63E5C0", VA = "0x18063FFC0")]
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

	// Token: 0x06002985 RID: 10629 RVA: 0x000E2A04 File Offset: 0x000E0C04
	[Token(Token = "0x6002985")]
	[Address(RVA = "0x640DD0", Offset = "0x63F3D0", VA = "0x180640DD0")]
	private void Start()
	{
		this.Look("冒险植物");
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x000E2A1C File Offset: 0x000E0C1C
	[Token(Token = "0x6002986")]
	[Address(RVA = "0x640330", Offset = "0x63E930", VA = "0x180640330")]
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

	// Token: 0x06002987 RID: 10631 RVA: 0x000E2A84 File Offset: 0x000E0C84
	[Token(Token = "0x6002987")]
	[Address(RVA = "0x640E10", Offset = "0x63F410", VA = "0x180640E10")]
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

	// Token: 0x06002988 RID: 10632 RVA: 0x000E2B10 File Offset: 0x000E0D10
	[Token(Token = "0x6002988")]
	[Address(RVA = "0x640650", Offset = "0x63EC50", VA = "0x180640650")]
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

	// Token: 0x06002989 RID: 10633 RVA: 0x000E2D04 File Offset: 0x000E0F04
	[Token(Token = "0x6002989")]
	[Address(RVA = "0x6404B0", Offset = "0x63EAB0", VA = "0x1806404B0")]
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

	// Token: 0x0600298A RID: 10634 RVA: 0x000E2D8C File Offset: 0x000E0F8C
	[Token(Token = "0x600298A")]
	[Address(RVA = "0x6402B0", Offset = "0x63E8B0", VA = "0x1806402B0")]
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

	// Token: 0x0600298B RID: 10635 RVA: 0x000E2DC4 File Offset: 0x000E0FC4
	[Token(Token = "0x600298B")]
	[Address(RVA = "0x640430", Offset = "0x63EA30", VA = "0x180640430")]
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

	// Token: 0x0600298C RID: 10636 RVA: 0x000E2DFC File Offset: 0x000E0FFC
	[Token(Token = "0x600298C")]
	[Address(RVA = "0x640FE0", Offset = "0x63F5E0", VA = "0x180640FE0")]
	public PlantCardPackageBuilder()
	{
		Dictionary<string, Page> dictionary = new Dictionary();
		this.groups = dictionary;
		base..ctor();
	}

	// Token: 0x040017D5 RID: 6101
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017D5")]
	[Header("预制体？")]
	public Page sampleGroup;

	// Token: 0x040017D6 RID: 6102
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017D6")]
	public UIButton sampleButton;

	// Token: 0x040017D7 RID: 6103
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40017D7")]
	[Header("按钮")]
	public UIButton lastPage;

	// Token: 0x040017D8 RID: 6104
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40017D8")]
	public UIButton nextPage;

	// Token: 0x040017D9 RID: 6105
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017D9")]
	[Header("文本")]
	public TextMeshProUGUI text;

	// Token: 0x040017DA RID: 6106
	[Token(Token = "0x40017DA")]
	private const int CardInOnePage = 63;

	// Token: 0x040017DB RID: 6107
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017DB")]
	private readonly Dictionary<string, Page> groups;

	// Token: 0x040017DC RID: 6108
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017DC")]
	private Page currentShow;
}
