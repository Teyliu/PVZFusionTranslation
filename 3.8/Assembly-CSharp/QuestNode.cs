using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008B2 RID: 2226
[Token(Token = "0x20008B2")]
public class QuestNode : MonoBehaviour
{
	// Token: 0x06002D32 RID: 11570 RVA: 0x000F8DAC File Offset: 0x000F6FAC
	[Token(Token = "0x6002D32")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500")]
	public bool Check()
	{
		return false;
	}

	// Token: 0x06002D33 RID: 11571 RVA: 0x000F8DBC File Offset: 0x000F6FBC
	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x684730", Offset = "0x682D30", VA = "0x180684730")]
	[ProButton]
	public void AddQuest()
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(base.gameObject);
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x000F8DD8 File Offset: 0x000F6FD8
	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public QuestNode()
	{
	}

	// Token: 0x04001B59 RID: 7001
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B59")]
	public QuestNode parent;

	// Token: 0x04001B5A RID: 7002
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B5A")]
	public List<QuestNode> childs;

	// Token: 0x04001B5B RID: 7003
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B5B")]
	[Header("任务描述")]
	public int id;

	// Token: 0x04001B5C RID: 7004
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B5C")]
	public string questName;

	// Token: 0x04001B5D RID: 7005
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B5D")]
	public string questDescription;

	// Token: 0x04001B5E RID: 7006
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B5E")]
	[Header("任务目标")]
	public QuestType questType;

	// Token: 0x04001B5F RID: 7007
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001B5F")]
	public QuestTarget questTarget;

	// Token: 0x04001B60 RID: 7008
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001B60")]
	public int target;

	// Token: 0x04001B61 RID: 7009
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001B61")]
	[Header("任务奖励")]
	public QuestAward questAward;

	// Token: 0x04001B62 RID: 7010
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001B62")]
	public int award;

	// Token: 0x04001B63 RID: 7011
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001B63")]
	[Header("任务状态")]
	public bool onTask;

	// Token: 0x04001B64 RID: 7012
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4001B64")]
	public bool completed;
}
