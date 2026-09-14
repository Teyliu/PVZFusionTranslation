using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008AC RID: 2220
[Token(Token = "0x20008AC")]
public class MapEditor : MonoBehaviour
{
	// Token: 0x06002D24 RID: 11556 RVA: 0x000F8B00 File Offset: 0x000F6D00
	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x683380", Offset = "0x681980", VA = "0x180683380")]
	private void OnDrawGizmos()
	{
		if (!this.build)
		{
			this.build = true;
			this.Build();
			return;
		}
	}

	// Token: 0x06002D25 RID: 11557 RVA: 0x000F8B24 File Offset: 0x000F6D24
	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x682EA0", Offset = "0x6814A0", VA = "0x180682EA0")]
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

	// Token: 0x06002D26 RID: 11558 RVA: 0x000F8BE0 File Offset: 0x000F6DE0
	[Token(Token = "0x6002D26")]
	[Address(RVA = "0x6833A0", Offset = "0x6819A0", VA = "0x1806833A0")]
	public MapEditor()
	{
		List<GameObject> list = new List();
		this.objs = list;
		List<GameObject> list2 = new List();
		this.objs2 = list2;
		base..ctor();
	}

	// Token: 0x04001B4C RID: 6988
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B4C")]
	public bool build;

	// Token: 0x04001B4D RID: 6989
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001B4D")]
	public int theTotalColumn;

	// Token: 0x04001B4E RID: 6990
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B4E")]
	public int theTotalRow;

	// Token: 0x04001B4F RID: 6991
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001B4F")]
	public int startColumn;

	// Token: 0x04001B50 RID: 6992
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B50")]
	public int endColumn;

	// Token: 0x04001B51 RID: 6993
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001B51")]
	public int startRow;

	// Token: 0x04001B52 RID: 6994
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B52")]
	public int endRow;

	// Token: 0x04001B53 RID: 6995
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B53")]
	private readonly List<GameObject> objs;

	// Token: 0x04001B54 RID: 6996
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B54")]
	private readonly List<GameObject> objs2;
}
