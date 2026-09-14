using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008BE RID: 2238
[Token(Token = "0x20008BE")]
public class Transition : MonoBehaviour
{
	// Token: 0x06002DAD RID: 11693 RVA: 0x000F9EE8 File Offset: 0x000F80E8
	[Token(Token = "0x6002DAD")]
	[Address(RVA = "0x701820", Offset = "0x6FFE20", VA = "0x180701820")]
	public void FadeCenter()
	{
		if (this.center != 0)
		{
		}
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x000F9F00 File Offset: 0x000F8100
	[Token(Token = "0x6002DAE")]
	[Address(RVA = "0x701840", Offset = "0x6FFE40", VA = "0x180701840")]
	public void FadeOver()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x000F9F18 File Offset: 0x000F8118
	[Token(Token = "0x6002DAF")]
	[Address(RVA = "0x7018A0", Offset = "0x6FFEA0", VA = "0x1807018A0")]
	public static Transition Set()
	{
		return global::UnityEngine.Object.Instantiate<GameObject>(Resources.Load<GameObject>("UI/Transition/Transition")).GetComponent<Transition>();
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x000F9F40 File Offset: 0x000F8140
	[Token(Token = "0x6002DB0")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Transition()
	{
	}

	// Token: 0x04001B87 RID: 7047
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B87")]
	public Action center;
}
