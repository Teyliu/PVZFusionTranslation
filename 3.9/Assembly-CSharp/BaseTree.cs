using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007F4 RID: 2036
[Token(Token = "0x20007F4")]
public class BaseTree : MonoBehaviour
{
	// Token: 0x06002938 RID: 10552 RVA: 0x000DEBBC File Offset: 0x000DCDBC
	[Token(Token = "0x6002938")]
	[Address(RVA = "0x68F8C0", Offset = "0x68DEC0", VA = "0x18068F8C0")]
	public void Traverse(Action<TreeNode> action)
	{
		ulong num2;
		do
		{
			int num = 0;
			Queue<TreeNode> queue = new Queue();
			TreeNode treeNode = this.head;
			queue.Enqueue(treeNode);
			TreeNode treeNode2 = queue.Dequeue();
			if (action != 0)
			{
			}
			List<TreeNode> childs = treeNode2.childs;
			bool flag;
			if (flag)
			{
				queue.Enqueue(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x000DEC0C File Offset: 0x000DCE0C
	[Token(Token = "0x6002939")]
	[Address(RVA = "0x68F800", Offset = "0x68DE00", VA = "0x18068F800")]
	public void AddNode(TreeNode parent, TreeNode treeNode)
	{
		int size = parent.childs._size;
		treeNode.parent = parent;
		throw new NullReferenceException();
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x000DEC34 File Offset: 0x000DCE34
	[Token(Token = "0x600293A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BaseTree()
	{
	}

	// Token: 0x04001750 RID: 5968
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001750")]
	public TreeNode head;
}
