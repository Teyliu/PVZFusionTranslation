using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000738 RID: 1848
[Token(Token = "0x2000738")]
public class CustomLevelShower : MonoBehaviour
{
	// Token: 0x060025A0 RID: 9632 RVA: 0x000C652C File Offset: 0x000C472C
	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x5C0570", Offset = "0x5BEB70", VA = "0x1805C0570")]
	private void Awake()
	{
		this.Show();
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000C6540 File Offset: 0x000C4740
	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x5C0580", Offset = "0x5BEB80", VA = "0x1805C0580")]
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

	// Token: 0x060025A2 RID: 9634 RVA: 0x000C66CC File Offset: 0x000C48CC
	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x5C0A90", Offset = "0x5BF090", VA = "0x1805C0A90")]
	public CustomLevelShower()
	{
		List<Transform> list = new List();
		this.pages = list;
		base..ctor();
	}

	// Token: 0x040012F2 RID: 4850
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012F2")]
	public GameObject levelWindowPrefab;

	// Token: 0x040012F3 RID: 4851
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012F3")]
	public GameObject gridPrefab;

	// Token: 0x040012F4 RID: 4852
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012F4")]
	[SerializeField]
	private List<Transform> pages;
}
