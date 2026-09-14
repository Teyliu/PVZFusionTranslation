using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000771 RID: 1905
[Token(Token = "0x2000771")]
public class CustomLevelShower : MonoBehaviour
{
	// Token: 0x060026C5 RID: 9925 RVA: 0x000CB410 File Offset: 0x000C9610
	[Token(Token = "0x60026C5")]
	[Address(RVA = "0x6210F0", Offset = "0x61F6F0", VA = "0x1806210F0")]
	private void Awake()
	{
		this.Show();
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x000CB424 File Offset: 0x000C9624
	[Token(Token = "0x60026C6")]
	[Address(RVA = "0x621100", Offset = "0x61F700", VA = "0x180621100")]
	private void Show()
	{
		CustomIZManager customIZManager = GameAPP.customIZManager;
		List<string> levelNames = customIZManager.levelNames;
		int num = 0;
		ulong num2;
		num2 += (ulong)1L;
		num2 += num2;
		if (num2 > (ulong)0L)
		{
			GameObject gameObject = this.gridPrefab;
			Transform transform = base.transform;
			int num3 = 0;
			Transform child = transform.GetChild(num3);
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, child);
			RectTransform component = gameObject2.GetComponent<RectTransform>();
			List<Transform> list = this.pages;
			Transform transform2 = gameObject2.transform;
			int size = list._size;
			num++;
		}
		List<string> levelNames2 = customIZManager.levelNames;
		List<Transform> list2 = this.pages;
		GameObject gameObject3 = this.levelWindowPrefab;
		ulong num4;
		num4 += num4;
		Transform transform3 = list2[(int)num4].transform;
		Transform transform4 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject3, transform3).transform;
		int num5 = 0;
		Transform transform5 = transform4.GetChild(num5).transform.Find("Window");
		CustomLevelEnter component2 = transform5.GetComponent<CustomLevelEnter>();
		Transform parent = base.transform.parent;
		component2.menu = parent;
		string text = customIZManager.levelNames[num];
		component2.levelName = text;
		int num6 = 0;
		TextMeshProUGUI component3 = transform5.GetChild(num6).GetComponent<TextMeshProUGUI>();
		string text2 = customIZManager.levelNames[num];
		component3.text = text2;
		num++;
		List<Transform> list3 = this.pages;
		GameObject gameObject4 = this.pages[num].gameObject;
		int num7 = 0;
		gameObject4.SetActive(num7 != 0);
		List<Transform> list4 = this.pages;
		num++;
		Transform transform6;
		ulong num8;
		transform6.gameObject.SetActive(num8 != 0UL);
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000CB5B0 File Offset: 0x000C97B0
	[Token(Token = "0x60026C7")]
	[Address(RVA = "0x621610", Offset = "0x61FC10", VA = "0x180621610")]
	public CustomLevelShower()
	{
		List<Transform> list = new List();
		this.pages = list;
		base..ctor();
	}

	// Token: 0x040013C8 RID: 5064
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013C8")]
	public GameObject levelWindowPrefab;

	// Token: 0x040013C9 RID: 5065
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013C9")]
	public GameObject gridPrefab;

	// Token: 0x040013CA RID: 5066
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013CA")]
	[SerializeField]
	private List<Transform> pages;
}
