using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000097 RID: 151
[Token(Token = "0x2000097")]
public class BubbleGameDeadLine : MonoBehaviour
{
	// Token: 0x0600028D RID: 653 RVA: 0x0000AA48 File Offset: 0x00008C48
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3B8270", Offset = "0x3B6870", VA = "0x1803B8270")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			UIMgr.EnterLoseMenu("");
			Board.Instance.over = true;
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0000AA78 File Offset: 0x00008C78
	[Token(Token = "0x600028E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BubbleGameDeadLine()
	{
	}
}
