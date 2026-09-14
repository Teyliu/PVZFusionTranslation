using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008B1 RID: 2225
[Token(Token = "0x20008B1")]
public class QuestManager : MonoBehaviour
{
	// Token: 0x06002D31 RID: 11569 RVA: 0x000F8D8C File Offset: 0x000F6F8C
	[Token(Token = "0x6002D31")]
	[Address(RVA = "0x6846B0", Offset = "0x682CB0", VA = "0x1806846B0")]
	public QuestManager()
	{
		List<QuestNode> list = new List();
		this.questNodes = list;
		base..ctor();
	}

	// Token: 0x04001B58 RID: 7000
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B58")]
	public List<QuestNode> questNodes;
}
