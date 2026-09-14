using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008E8 RID: 2280
[Token(Token = "0x20008E8")]
public class MapEditor : MonoBehaviour
{
	// Token: 0x06002E57 RID: 11863 RVA: 0x000FD684 File Offset: 0x000FB884
	[Token(Token = "0x6002E57")]
	[Address(RVA = "0x6FC940", Offset = "0x6FAF40", VA = "0x1806FC940")]
	private void OnDrawGizmos()
	{
		if (!this.build)
		{
			this.build = true;
			this.Build();
			return;
		}
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x000FD6A8 File Offset: 0x000FB8A8
	[Token(Token = "0x6002E58")]
	[Address(RVA = "0x6FC460", Offset = "0x6FAA60", VA = "0x1806FC460")]
	private void Build()
	{
		for (;;)
		{
			int num = 0;
			List<GameObject> list = this.objs;
			bool flag;
			if (flag)
			{
				global::UnityEngine.Object.DestroyImmediate(num);
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				bool flag2;
				if (flag2)
				{
					global::UnityEngine.Object.DestroyImmediate(num);
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					break;
				}
			}
		}
		int num4 = 0;
		int num5 = 0;
		if (0UL == (ulong)1L)
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(num4);
			float boxYFromRow = Lawnf.GetBoxYFromRow(num5, 5);
			GameObject gameObject = Resources.Load<GameObject>("CustomMap/BlockDark");
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
		}
		num5++;
		num4++;
		if (0UL == (ulong)1L)
		{
			float boxYFromRow2 = Lawnf.GetBoxYFromRow(num5, 5);
			GameObject gameObject2 = Resources.Load<GameObject>("CustomMap/BlockDark");
			Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		}
		num5++;
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x000FD764 File Offset: 0x000FB964
	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x6FC960", Offset = "0x6FAF60", VA = "0x1806FC960")]
	public MapEditor()
	{
		List<GameObject> list = new List();
		this.objs = list;
		List<GameObject> list2 = new List();
		this.objs2 = list2;
		base..ctor();
	}

	// Token: 0x04001C3C RID: 7228
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C3C")]
	public bool build;

	// Token: 0x04001C3D RID: 7229
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001C3D")]
	public int theTotalColumn;

	// Token: 0x04001C3E RID: 7230
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C3E")]
	public int theTotalRow;

	// Token: 0x04001C3F RID: 7231
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001C3F")]
	public int startColumn;

	// Token: 0x04001C40 RID: 7232
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C40")]
	public int endColumn;

	// Token: 0x04001C41 RID: 7233
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001C41")]
	public int startRow;

	// Token: 0x04001C42 RID: 7234
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001C42")]
	public int endRow;

	// Token: 0x04001C43 RID: 7235
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001C43")]
	private readonly List<GameObject> objs;

	// Token: 0x04001C44 RID: 7236
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001C44")]
	private readonly List<GameObject> objs2;
}
