using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200009C RID: 156
[Token(Token = "0x200009C")]
public class BubbleGameDeadLine : MonoBehaviour
{
	// Token: 0x060002A8 RID: 680 RVA: 0x0000AD80 File Offset: 0x00008F80
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x405020", Offset = "0x403620", VA = "0x180405020")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			UIMgr.EnterLoseMenu("");
			Board.Instance.over = true;
		}
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000ADB0 File Offset: 0x00008FB0
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BubbleGameDeadLine()
	{
	}
}
