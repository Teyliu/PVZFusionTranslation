using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008EA RID: 2282
[Token(Token = "0x20008EA")]
public class RogueShower : MonoBehaviour
{
	// Token: 0x06002E5D RID: 11869 RVA: 0x000FD808 File Offset: 0x000FBA08
	[Token(Token = "0x6002E5D")]
	[Address(RVA = "0x6FDD60", Offset = "0x6FC360", VA = "0x1806FDD60")]
	private void Awake()
	{
		RogueManager instance = RogueManager.Instance;
		this.manager = instance;
	}

	// Token: 0x06002E5E RID: 11870 RVA: 0x000FD824 File Offset: 0x000FBA24
	[Token(Token = "0x6002E5E")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public RogueShower()
	{
	}

	// Token: 0x04001C46 RID: 7238
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C46")]
	public RogueManager manager;
}
