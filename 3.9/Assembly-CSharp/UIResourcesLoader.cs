using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x02000A38 RID: 2616
[Token(Token = "0x2000A38")]
public class UIResourcesLoader
{
	// Token: 0x060035BA RID: 13754 RVA: 0x0011D9E4 File Offset: 0x0011BBE4
	[Token(Token = "0x60035BA")]
	[Address(RVA = "0x7AF6E0", Offset = "0x7ADCE0", VA = "0x1807AF6E0")]
	public UIResourcesLoader()
	{
		Dictionary<UIType, GameObject> dictionary = new Dictionary();
		this.UIPrefabs = dictionary;
		Stack<List<BaseMenu>> stack = new Stack();
		this.menuStack = stack;
		base..ctor();
		Dictionary<UIType, GameObject> dict = global::Core.Lawnf.GetDict<UIType, GameObject>("UI/Prefabs/", true);
		this.UIPrefabs = dict;
	}

	// Token: 0x060035BB RID: 13755 RVA: 0x0011DA24 File Offset: 0x0011BC24
	[Token(Token = "0x60035BB")]
	[Address(RVA = "0x7AF110", Offset = "0x7AD710", VA = "0x1807AF110")]
	public BaseMenu Push(UIType uIType, Transform transform, bool group = false)
	{
		BaseMenu component;
		ulong num2;
		do
		{
			int num = 0;
			Dictionary<UIType, GameObject> uiprefabs = this.UIPrefabs;
			bool flag;
			if (!flag)
			{
			}
			GameObject gameObject;
			component = gameObject.GetComponent<BaseMenu>();
			component.uIType = uIType;
			CanvasGroup canvasGroup = component.AddComponent<CanvasGroup>();
			component.canvasGroup = canvasGroup;
			Stack<List<BaseMenu>> stack = this.menuStack;
			List<BaseMenu> list = new List();
			if (group)
			{
			}
			bool flag2;
			if (flag2)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num2 != (ulong)0L);
		int size = new List()._size;
		component.collider2Ds = component;
		throw new NullReferenceException();
	}

	// Token: 0x060035BC RID: 13756 RVA: 0x0011DAB4 File Offset: 0x0011BCB4
	[Token(Token = "0x60035BC")]
	[Address(RVA = "0x7AF4F0", Offset = "0x7ADAF0", VA = "0x1807AF4F0")]
	public BaseMenu Push(UIType uIType, bool group = false)
	{
		BaseMenu baseMenu;
		return baseMenu;
	}

	// Token: 0x060035BD RID: 13757 RVA: 0x0011DAC4 File Offset: 0x0011BCC4
	[Token(Token = "0x60035BD")]
	[Address(RVA = "0x7AF580", Offset = "0x7ADB80", VA = "0x1807AF580")]
	public void SetThisMenuDisable()
	{
		ulong num2;
		do
		{
			int num = 0;
			List<BaseMenu> list = this.menuStack.Peek();
			bool flag;
			if (flag)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060035BE RID: 13758 RVA: 0x0011DAFC File Offset: 0x0011BCFC
	[Token(Token = "0x60035BE")]
	[Address(RVA = "0x7AEC90", Offset = "0x7AD290", VA = "0x1807AEC90")]
	public List<BaseMenu> Peak()
	{
		List<BaseMenu> list = new List();
		List<BaseMenu> list2 = this.menuStack.Peek();
		return list;
	}

	// Token: 0x060035BF RID: 13759 RVA: 0x0011DB2C File Offset: 0x0011BD2C
	[Token(Token = "0x60035BF")]
	[Address(RVA = "0x7AEE50", Offset = "0x7AD450", VA = "0x1807AEE50")]
	public void Pop()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<BaseMenu> list = this.menuStack.Pop();
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_004B;
			}
			List<BaseMenu> list2 = this.menuStack.Peek();
			bool flag2;
			if (flag2)
			{
				TypeCode typeCode = num.GetTypeCode();
			}
		}
		while (num3 != (ulong)0L);
		return;
		IL_004B:
		throw new NullReferenceException();
	}

	// Token: 0x060035C0 RID: 13760 RVA: 0x0011DB8C File Offset: 0x0011BD8C
	[Token(Token = "0x60035C0")]
	[Address(RVA = "0x7AED90", Offset = "0x7AD390", VA = "0x1807AED90")]
	public void PopTo(UIType uIType)
	{
		Stack<List<BaseMenu>> stack = this.menuStack;
		List<BaseMenu> list = this.menuStack.Peek();
		this.Pop();
		int num = 0;
		if (list[num].uIType != uIType)
		{
			Stack<List<BaseMenu>> stack2 = this.menuStack;
		}
	}

	// Token: 0x060035C1 RID: 13761 RVA: 0x0011DBD4 File Offset: 0x0011BDD4
	[Token(Token = "0x60035C1")]
	[Address(RVA = "0x7AED30", Offset = "0x7AD330", VA = "0x1807AED30")]
	public void PopAll()
	{
		Stack<List<BaseMenu>> stack = this.menuStack;
		this.Pop();
		Stack<List<BaseMenu>> stack2 = this.menuStack;
	}

	// Token: 0x040028E3 RID: 10467
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40028E3")]
	private readonly Dictionary<UIType, GameObject> UIPrefabs;

	// Token: 0x040028E4 RID: 10468
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40028E4")]
	private readonly Stack<List<BaseMenu>> menuStack;
}
