using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;

// Token: 0x020009FC RID: 2556
[Token(Token = "0x20009FC")]
public class UIResourcesLoader
{
	// Token: 0x06003485 RID: 13445 RVA: 0x00118AE4 File Offset: 0x00116CE4
	[Token(Token = "0x6003485")]
	[Address(RVA = "0x748DB0", Offset = "0x7473B0", VA = "0x180748DB0")]
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

	// Token: 0x06003486 RID: 13446 RVA: 0x00118B24 File Offset: 0x00116D24
	[Token(Token = "0x6003486")]
	[Address(RVA = "0x7487E0", Offset = "0x746DE0", VA = "0x1807487E0")]
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

	// Token: 0x06003487 RID: 13447 RVA: 0x00118BB4 File Offset: 0x00116DB4
	[Token(Token = "0x6003487")]
	[Address(RVA = "0x748BC0", Offset = "0x7471C0", VA = "0x180748BC0")]
	public BaseMenu Push(UIType uIType, bool group = false)
	{
		BaseMenu baseMenu;
		return baseMenu;
	}

	// Token: 0x06003488 RID: 13448 RVA: 0x00118BC4 File Offset: 0x00116DC4
	[Token(Token = "0x6003488")]
	[Address(RVA = "0x748C50", Offset = "0x747250", VA = "0x180748C50")]
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

	// Token: 0x06003489 RID: 13449 RVA: 0x00118BFC File Offset: 0x00116DFC
	[Token(Token = "0x6003489")]
	[Address(RVA = "0x748360", Offset = "0x746960", VA = "0x180748360")]
	public List<BaseMenu> Peak()
	{
		List<BaseMenu> list = new List();
		List<BaseMenu> list2 = this.menuStack.Peek();
		return list;
	}

	// Token: 0x0600348A RID: 13450 RVA: 0x00118C2C File Offset: 0x00116E2C
	[Token(Token = "0x600348A")]
	[Address(RVA = "0x748520", Offset = "0x746B20", VA = "0x180748520")]
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

	// Token: 0x0600348B RID: 13451 RVA: 0x00118C8C File Offset: 0x00116E8C
	[Token(Token = "0x600348B")]
	[Address(RVA = "0x748460", Offset = "0x746A60", VA = "0x180748460")]
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

	// Token: 0x0600348C RID: 13452 RVA: 0x00118CD4 File Offset: 0x00116ED4
	[Token(Token = "0x600348C")]
	[Address(RVA = "0x748400", Offset = "0x746A00", VA = "0x180748400")]
	public void PopAll()
	{
		Stack<List<BaseMenu>> stack = this.menuStack;
		this.Pop();
		Stack<List<BaseMenu>> stack2 = this.menuStack;
	}

	// Token: 0x04002783 RID: 10115
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002783")]
	private readonly Dictionary<UIType, GameObject> UIPrefabs;

	// Token: 0x04002784 RID: 10116
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002784")]
	private readonly Stack<List<BaseMenu>> menuStack;
}
