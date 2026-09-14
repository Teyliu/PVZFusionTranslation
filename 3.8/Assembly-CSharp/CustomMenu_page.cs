using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009D2 RID: 2514
[Token(Token = "0x20009D2")]
public class CustomMenu_page : MonoBehaviour
{
	// Token: 0x060033A4 RID: 13220 RVA: 0x00112730 File Offset: 0x00110930
	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "4")]
	public virtual void LoadOriginalSettings()
	{
	}

	// Token: 0x060033A5 RID: 13221 RVA: 0x00112740 File Offset: 0x00110940
	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "5")]
	public virtual void InitPage()
	{
	}

	// Token: 0x060033A6 RID: 13222 RVA: 0x00112750 File Offset: 0x00110950
	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
	public virtual void OnExport()
	{
	}

	// Token: 0x060033A7 RID: 13223 RVA: 0x00112760 File Offset: 0x00110960
	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CustomMenu_page()
	{
	}

	// Token: 0x0400252B RID: 9515
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400252B")]
	[Header("主菜单引用")]
	public CustomMenu menu;
}
