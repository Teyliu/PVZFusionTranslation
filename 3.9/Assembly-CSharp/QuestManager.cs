using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008ED RID: 2285
[Token(Token = "0x20008ED")]
public class QuestManager : MonoBehaviour
{
	// Token: 0x06002E64 RID: 11876 RVA: 0x000FD910 File Offset: 0x000FBB10
	[Token(Token = "0x6002E64")]
	[Address(RVA = "0x6FDC70", Offset = "0x6FC270", VA = "0x1806FDC70")]
	public QuestManager()
	{
		List<QuestNode> list = new List();
		this.questNodes = list;
		base..ctor();
	}

	// Token: 0x04001C48 RID: 7240
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C48")]
	public List<QuestNode> questNodes;
}
