using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
public class BezierPathController : MonoBehaviour
{
	// Token: 0x060004AF RID: 1199 RVA: 0x00018464 File Offset: 0x00016664
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x5DB5B0", Offset = "0x5D9BB0", VA = "0x1805DB5B0")]
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

	// Token: 0x060004B0 RID: 1200 RVA: 0x000184C4 File Offset: 0x000166C4
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x5DBCE0", Offset = "0x5DA2E0", VA = "0x1805DBCE0")]
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
			Transform transform = base.transform;
			int num2 = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			if (num < num2)
			{
				num += num;
				num++;
			}
			if (num < num)
			{
				num += num;
				num++;
			}
			num += 312;
			int size2 = this.controlPointList._size;
			if (num == 0)
			{
				int num3 = 0;
				if (BezierPathController.<>c.<>9__10_0 == 0)
				{
					BezierPathController.<>c <> = BezierPathController.<>c.<>9;
					Func<GameObject, Vector3> func;
					BezierPathController.<>c.<>9__10_0 = func;
				}
				IEnumerable<GameObject> enumerable;
				list2 = Enumerable.ToList<Vector3>(enumerable);
				num3++;
				bool flag;
				if (flag)
				{
				}
				if (num3 == 0)
				{
					break;
				}
			}
		}
		int num4 = 0;
		List<Vector3> list3;
		int size3 = list3._size;
		if (num4 < size3)
		{
			num4++;
		}
		int size4 = list2._size;
		if (num4 < size4)
		{
			num4++;
		}
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x000185CC File Offset: 0x000167CC
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x5DB970", Offset = "0x5D9F70", VA = "0x1805DB970")]
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

	// Token: 0x060004B2 RID: 1202 RVA: 0x0001861C File Offset: 0x0001681C
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x5DB7D0", Offset = "0x5D9DD0", VA = "0x1805DB7D0")]
	private Vector3 CalculateBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		return default(Vector3);
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00018634 File Offset: 0x00016834
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x5DC690", Offset = "0x5DAC90", VA = "0x1805DC690")]
	public BezierPathController()
	{
		List<GameObject> list = new List();
		this.controlPointList = list;
		List<Vector3> list2 = new List();
		this.ballPointList = list2;
		this.distance = 0.2f;
		base..ctor();
	}

	// Token: 0x040002C1 RID: 705
	[Token(Token = "0x40002C1")]
	public static BezierPathController Instance;

	// Token: 0x040002C2 RID: 706
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002C2")]
	public Transform t;

	// Token: 0x040002C3 RID: 707
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002C3")]
	public bool debug = true;

	// Token: 0x040002C4 RID: 708
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002C4")]
	public GameObject ballPrefab;

	// Token: 0x040002C5 RID: 709
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002C5")]
	public List<GameObject> controlPointList;

	// Token: 0x040002C6 RID: 710
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002C6")]
	public int segmentsPerCurve;

	// Token: 0x040002C7 RID: 711
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002C7")]
	public float r;

	// Token: 0x040002C8 RID: 712
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002C8")]
	public List<Vector3> ballPointList;

	// Token: 0x040002C9 RID: 713
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002C9")]
	public float distance;
}
