using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A0E RID: 2574
[Token(Token = "0x2000A0E")]
public class CustomMenu_page : MonoBehaviour
{
	// Token: 0x060034D8 RID: 13528 RVA: 0x001176A4 File Offset: 0x001158A4
	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "4")]
	public virtual void LoadOriginalSettings()
	{
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x001176B4 File Offset: 0x001158B4
	[Token(Token = "0x60034D9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "5")]
	public virtual void InitPage()
	{
	}

	// Token: 0x060034DA RID: 13530 RVA: 0x001176C4 File Offset: 0x001158C4
	[Token(Token = "0x60034DA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	public virtual void OnExport()
	{
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x001176D4 File Offset: 0x001158D4
	[Token(Token = "0x60034DB")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CustomMenu_page()
	{
	}

	// Token: 0x0400263D RID: 9789
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400263D")]
	[Header("主菜单引用")]
	public CustomMenu menu;
}
