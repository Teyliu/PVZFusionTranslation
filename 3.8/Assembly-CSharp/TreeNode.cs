using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007BC RID: 1980
[Token(Token = "0x20007BC")]
public class TreeNode : MonoBehaviour
{
	// Token: 0x0600280C RID: 10252 RVA: 0x000D9C8C File Offset: 0x000D7E8C
	[Token(Token = "0x600280C")]
	[Address(RVA = "0x631C70", Offset = "0x630270", VA = "0x180631C70")]
	[ProButton]
	public void Clear()
	{
		ulong num;
		do
		{
			List<TreeNode> list = this.childs;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				global::UnityEngine.Object.DestroyImmediate(gameObject);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600280D RID: 10253 RVA: 0x000D9CC4 File Offset: 0x000D7EC4
	[Token(Token = "0x600280D")]
	[Address(RVA = "0x631930", Offset = "0x62FF30", VA = "0x180631930")]
	[ProButton]
	public void AddNode()
	{
		TreeNode treeNode = global::UnityEngine.Object.Instantiate<TreeNode>(Resources.Load<TreeNode>("Tree/Node"));
		treeNode.parent = this;
		int size = this.childs._size;
		treeNode.parent = treeNode;
		string name = base.name;
		treeNode.name = name;
		Transform transform = treeNode.transform;
		TreeNode treeNode2 = this.parent;
		int num = 0;
		if (treeNode2 != num)
		{
			TreeNode treeNode3 = this.parent;
		}
		Transform transform2 = base.transform;
		transform.parentInternal = transform2;
		int size2 = this.childs._size;
		int num2 = 0;
		if (size2 > 0)
		{
			Transform transform3 = this.childs[num2].transform;
			Transform transform4 = base.transform;
			Vector3 vector;
			float z = vector.z;
			num2++;
		}
	}

	// Token: 0x0600280E RID: 10254 RVA: 0x000D9D88 File Offset: 0x000D7F88
	[Token(Token = "0x600280E")]
	[Address(RVA = "0x631E10", Offset = "0x630410", VA = "0x180631E10")]
	private TreeNode GetHead()
	{
		TreeNode treeNode = this.parent;
		int num = 0;
		if (treeNode != num)
		{
			TreeNode treeNode2 = this.parent;
		}
		return this;
	}

	// Token: 0x0600280F RID: 10255 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
	[Token(Token = "0x600280F")]
	[Address(RVA = "0x631EA0", Offset = "0x6304A0", VA = "0x180631EA0")]
	public TreeNode()
	{
		List<TreeNode> list = new List();
		this.childs = list;
		base..ctor();
	}

	// Token: 0x04001675 RID: 5749
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001675")]
	public TreeNode parent;

	// Token: 0x04001676 RID: 5750
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001676")]
	public List<TreeNode> childs;
}
