using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008EE RID: 2286
[Token(Token = "0x20008EE")]
public class QuestNode : MonoBehaviour
{
	// Token: 0x06002E65 RID: 11877 RVA: 0x000FD930 File Offset: 0x000FBB30
	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970")]
	public bool Check()
	{
		return false;
	}

	// Token: 0x06002E66 RID: 11878 RVA: 0x000FD940 File Offset: 0x000FBB40
	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x6FDCF0", Offset = "0x6FC2F0", VA = "0x1806FDCF0")]
	[ProButton]
	public void AddQuest()
	{
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(base.gameObject);
	}

	// Token: 0x06002E67 RID: 11879 RVA: 0x000FD95C File Offset: 0x000FBB5C
	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public QuestNode()
	{
	}

	// Token: 0x04001C49 RID: 7241
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C49")]
	public QuestNode parent;

	// Token: 0x04001C4A RID: 7242
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C4A")]
	public List<QuestNode> childs;

	// Token: 0x04001C4B RID: 7243
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C4B")]
	[Header("任务描述")]
	public int id;

	// Token: 0x04001C4C RID: 7244
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001C4C")]
	public string questName;

	// Token: 0x04001C4D RID: 7245
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001C4D")]
	public string questDescription;

	// Token: 0x04001C4E RID: 7246
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001C4E")]
	[Header("任务目标")]
	public QuestType questType;

	// Token: 0x04001C4F RID: 7247
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4001C4F")]
	public QuestTarget questTarget;

	// Token: 0x04001C50 RID: 7248
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001C50")]
	public int target;

	// Token: 0x04001C51 RID: 7249
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001C51")]
	[Header("任务奖励")]
	public QuestAward questAward;

	// Token: 0x04001C52 RID: 7250
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001C52")]
	public int award;

	// Token: 0x04001C53 RID: 7251
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001C53")]
	[Header("任务状态")]
	public bool onTask;

	// Token: 0x04001C54 RID: 7252
	[FieldOffset(Offset = "0x5D")]
	[Token(Token = "0x4001C54")]
	public bool completed;
}
