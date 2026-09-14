using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200076E RID: 1902
[Token(Token = "0x200076E")]
public class CursorChange : MonoBehaviour
{
	// Token: 0x060026BD RID: 9917 RVA: 0x000CB20C File Offset: 0x000C940C
	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
	public static void SetDefaultCursor()
	{
		CursorChange.curDefault = Resources.Load<Texture2D>("Image/CursorDefault");
		Texture2D texture2D = CursorChange.curDefault;
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x000CB230 File Offset: 0x000C9430
	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x620A00", Offset = "0x61F000", VA = "0x180620A00")]
	public static void SetClickCursor()
	{
		CursorChange.curClick = Resources.Load<Texture2D>("Image/CursorClick");
		Texture2D texture2D = CursorChange.curClick;
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x000CB254 File Offset: 0x000C9454
	[Token(Token = "0x60026BF")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CursorChange()
	{
	}

	// Token: 0x040013C2 RID: 5058
	[Token(Token = "0x40013C2")]
	private static Texture2D curDefault;

	// Token: 0x040013C3 RID: 5059
	[Token(Token = "0x40013C3")]
	private static Texture2D curClick;
}
