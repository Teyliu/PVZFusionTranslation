using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000735 RID: 1845
[Token(Token = "0x2000735")]
public class CursorChange : MonoBehaviour
{
	// Token: 0x06002598 RID: 9624 RVA: 0x000C6328 File Offset: 0x000C4528
	[Token(Token = "0x6002598")]
	[Address(RVA = "0x5BFF30", Offset = "0x5BE530", VA = "0x1805BFF30")]
	public static void SetDefaultCursor()
	{
		CursorChange.curDefault = Resources.Load<Texture2D>("Image/CursorDefault");
		Texture2D texture2D = CursorChange.curDefault;
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x000C634C File Offset: 0x000C454C
	[Token(Token = "0x6002599")]
	[Address(RVA = "0x5BFE80", Offset = "0x5BE480", VA = "0x1805BFE80")]
	public static void SetClickCursor()
	{
		CursorChange.curClick = Resources.Load<Texture2D>("Image/CursorClick");
		Texture2D texture2D = CursorChange.curClick;
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x000C6370 File Offset: 0x000C4570
	[Token(Token = "0x600259A")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CursorChange()
	{
	}

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	private static Texture2D curDefault;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	private static Texture2D curClick;
}
