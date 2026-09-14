using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007BB RID: 1979
[Token(Token = "0x20007BB")]
public class BaseTree : MonoBehaviour
{
	// Token: 0x06002809 RID: 10249 RVA: 0x000D9C00 File Offset: 0x000D7E00
	[Token(Token = "0x6002809")]
	[Address(RVA = "0x62BFC0", Offset = "0x62A5C0", VA = "0x18062BFC0")]
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

	// Token: 0x0600280A RID: 10250 RVA: 0x000D9C50 File Offset: 0x000D7E50
	[Token(Token = "0x600280A")]
	[Address(RVA = "0x62BF00", Offset = "0x62A500", VA = "0x18062BF00")]
	public void AddNode(TreeNode parent, TreeNode treeNode)
	{
		int size = parent.childs._size;
		treeNode.parent = parent;
		throw new NullReferenceException();
	}

	// Token: 0x0600280B RID: 10251 RVA: 0x000D9C78 File Offset: 0x000D7E78
	[Token(Token = "0x600280B")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BaseTree()
	{
	}

	// Token: 0x04001674 RID: 5748
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001674")]
	public TreeNode head;
}
