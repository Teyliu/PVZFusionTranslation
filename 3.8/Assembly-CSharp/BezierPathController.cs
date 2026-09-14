using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F3 RID: 243
[Token(Token = "0x20000F3")]
public class BezierPathController : MonoBehaviour
{
	// Token: 0x06000494 RID: 1172 RVA: 0x00018078 File Offset: 0x00016278
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x5A3C20", Offset = "0x5A2220", VA = "0x1805A3C20")]
	private void Awake()
	{
		ulong num;
		do
		{
			BezierPathController.Instance = this;
			List<Vector3> list = this.ballPointList;
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.ballPrefab;
				Transform parent = base.transform.parent;
				Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, parent).transform;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x000180D8 File Offset: 0x000162D8
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x5A4350", Offset = "0x5A2950", VA = "0x1805A4350")]
	private void OnDrawGizmos()
	{
		List<Vector3> list2;
		for (;;)
		{
			int num = 0;
			List<GameObject> list = this.controlPointList;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			if (base.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				int size2 = this.controlPointList._size;
			}
			if (num == 0)
			{
				int num2 = 0;
				if (BezierPathController.<>c.<>9__10_0 == 0)
				{
					BezierPathController.<>c <> = BezierPathController.<>c.<>9;
					Func<GameObject, Vector3> func;
					BezierPathController.<>c.<>9__10_0 = func;
				}
				IEnumerable<GameObject> enumerable;
				list2 = Enumerable.ToList<Vector3>(enumerable);
				num2++;
				bool flag;
				if (flag)
				{
				}
				if (num2 == 0)
				{
					break;
				}
			}
		}
		int num3 = 0;
		List<Vector3> list3;
		int size3 = list3._size;
		if (num3 < size3)
		{
			num3++;
		}
		int size4 = list2._size;
		if (num3 < size4)
		{
			num3++;
		}
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x000181C8 File Offset: 0x000163C8
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x5A3FE0", Offset = "0x5A25E0", VA = "0x1805A3FE0")]
	private List<Vector3> GetDrawingPoints(List<Vector3> controlPoints, int segmentsPerCurve)
	{
		List<Vector3> list = new List();
		int num = 0;
		int num2 = 0;
		int size = controlPoints._size;
		if (num < size)
		{
			int i = 0;
			i++;
			while (i <= segmentsPerCurve)
			{
			}
			num2 += 3;
			uint num3;
			num3 += (uint)3;
		}
		return list;
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00018218 File Offset: 0x00016418
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x5A3E40", Offset = "0x5A2440", VA = "0x1805A3E40")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00018230 File Offset: 0x00016430
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x5A4CA0", Offset = "0x5A32A0", VA = "0x1805A4CA0")]
	public BezierPathController()
	{
		List<GameObject> list = new List();
		this.controlPointList = list;
		List<Vector3> list2 = new List();
		this.ballPointList = list2;
		this.distance = 0.2f;
		base..ctor();
	}

	// Token: 0x040002B3 RID: 691
	[Token(Token = "0x40002B3")]
	public static BezierPathController Instance;

	// Token: 0x040002B4 RID: 692
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B4")]
	public Transform t;

	// Token: 0x040002B5 RID: 693
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B5")]
	public bool debug = true;

	// Token: 0x040002B6 RID: 694
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002B6")]
	public GameObject ballPrefab;

	// Token: 0x040002B7 RID: 695
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002B7")]
	public List<GameObject> controlPointList;

	// Token: 0x040002B8 RID: 696
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002B8")]
	public int segmentsPerCurve;

	// Token: 0x040002B9 RID: 697
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002B9")]
	public float r;

	// Token: 0x040002BA RID: 698
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002BA")]
	public List<Vector3> ballPointList;

	// Token: 0x040002BB RID: 699
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002BB")]
	public float distance;
}
