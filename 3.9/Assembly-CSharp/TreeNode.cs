using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007F5 RID: 2037
[Token(Token = "0x20007F5")]
public class TreeNode : MonoBehaviour
{
	// Token: 0x0600293B RID: 10555 RVA: 0x000DEC48 File Offset: 0x000DCE48
	[Token(Token = "0x600293B")]
	[Address(RVA = "0x695A40", Offset = "0x694040", VA = "0x180695A40")]
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

	// Token: 0x0600293C RID: 10556 RVA: 0x000DEC80 File Offset: 0x000DCE80
	[Token(Token = "0x600293C")]
	[Address(RVA = "0x695700", Offset = "0x693D00", VA = "0x180695700")]
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

	// Token: 0x0600293D RID: 10557 RVA: 0x000DED44 File Offset: 0x000DCF44
	[Token(Token = "0x600293D")]
	[Address(RVA = "0x695BE0", Offset = "0x6941E0", VA = "0x180695BE0")]
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

	// Token: 0x0600293E RID: 10558 RVA: 0x000DED74 File Offset: 0x000DCF74
	[Token(Token = "0x600293E")]
	[Address(RVA = "0x695C70", Offset = "0x694270", VA = "0x180695C70")]
	public TreeNode()
	{
		List<TreeNode> list = new List();
		this.childs = list;
		base..ctor();
	}

	// Token: 0x04001751 RID: 5969
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001751")]
	public TreeNode parent;

	// Token: 0x04001752 RID: 5970
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001752")]
	public List<TreeNode> childs;
}
