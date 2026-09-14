using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008AE RID: 2222
[Token(Token = "0x20008AE")]
public class RogueShower : MonoBehaviour
{
	// Token: 0x06002D2A RID: 11562 RVA: 0x000F8C84 File Offset: 0x000F6E84
	[Token(Token = "0x6002D2A")]
	[Address(RVA = "0x6847A0", Offset = "0x682DA0", VA = "0x1806847A0")]
	private void Awake()
	{
		RogueManager instance = RogueManager.Instance;
		this.manager = instance;
	}

	// Token: 0x06002D2B RID: 11563 RVA: 0x000F8CA0 File Offset: 0x000F6EA0
	[Token(Token = "0x6002D2B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public RogueShower()
	{
	}

	// Token: 0x04001B56 RID: 6998
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B56")]
	public RogueManager manager;
}
