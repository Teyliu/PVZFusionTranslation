using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200077A RID: 1914
[Token(Token = "0x200077A")]
public class MagnetLineMgr : MonoBehaviour
{
	// Token: 0x060026AE RID: 9902 RVA: 0x000CE374 File Offset: 0x000CC574
	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x5E4200", Offset = "0x5E2800", VA = "0x1805E4200")]
	private void Awake()
	{
		MagnetLineMgr.Instance = this;
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x000CE388 File Offset: 0x000CC588
	[Token(Token = "0x60026AF")]
	[Address(RVA = "0x5E4410", Offset = "0x5E2A10", VA = "0x1805E4410")]
	public MagnetLine GetLine(int column0, int row0, int column1, int row1)
	{
		ulong num;
		do
		{
			List<MagnetLine> list = this.magnetLines;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				gameObject.SetActive(true);
			}
		}
		while (num != (ulong)0L);
		GameObject gameObject2 = Resources.Load<GameObject>("Magnet/MagnetLine");
		Transform transform = Board.Instance.transform;
		MagnetLine component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform).GetComponent<MagnetLine>();
		Mouse instance = Mouse.Instance;
		Mouse instance2 = Mouse.Instance;
		Mouse instance3 = Mouse.Instance;
		Mouse instance4 = Mouse.Instance;
		LineRenderer lineRenderer = component.lineRenderer;
		LineRenderer lineRenderer2 = component.lineRenderer;
		component.firstColumn = 0;
		component.firstRow = 0;
		component.secondColumn = 0;
		component.secondRow = 0;
		IntPtr cachedPtr = lineRenderer2.m_CachedPtr;
		throw new NullReferenceException();
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000CE454 File Offset: 0x000CC654
	[Token(Token = "0x60026B0")]
	[Address(RVA = "0x5E48C0", Offset = "0x5E2EC0", VA = "0x1805E48C0")]
	private bool SameLine(MagnetLine magnetLine, int column0, int row0, int column1, int row1)
	{
		if (magnetLine.firstColumn != column0 || magnetLine.firstRow == row0)
		{
		}
		if (magnetLine.secondColumn == column0 && magnetLine.secondRow == row0)
		{
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x000CE490 File Offset: 0x000CC690
	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x5E4260", Offset = "0x5E2860", VA = "0x1805E4260")]
	public MagnetLine DestoryLine(int column0, int row0, int column1, int row1)
	{
		ulong num2;
		do
		{
			List<MagnetLine> list = this.magnetLines;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				gameObject.SetActive(num != 0);
			}
		}
		while (num2 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000CE4D4 File Offset: 0x000CC6D4
	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x5E4920", Offset = "0x5E2F20", VA = "0x1805E4920")]
	public MagnetLineMgr()
	{
		List<MagnetLine> list = new List();
		this.magnetLines = list;
		base..ctor();
	}

	// Token: 0x04001477 RID: 5239
	[Token(Token = "0x4001477")]
	public static MagnetLineMgr Instance;

	// Token: 0x04001478 RID: 5240
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001478")]
	public List<MagnetLine> magnetLines;
}
