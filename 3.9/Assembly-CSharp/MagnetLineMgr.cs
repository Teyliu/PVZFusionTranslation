using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B3 RID: 1971
[Token(Token = "0x20007B3")]
public class MagnetLineMgr : MonoBehaviour
{
	// Token: 0x060027DD RID: 10205 RVA: 0x000D33A4 File Offset: 0x000D15A4
	[Token(Token = "0x60027DD")]
	[Address(RVA = "0x647540", Offset = "0x645B40", VA = "0x180647540")]
	private void Awake()
	{
		MagnetLineMgr.Instance = this;
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x000D33B8 File Offset: 0x000D15B8
	[Token(Token = "0x60027DE")]
	[Address(RVA = "0x647750", Offset = "0x645D50", VA = "0x180647750")]
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

	// Token: 0x060027DF RID: 10207 RVA: 0x000D3484 File Offset: 0x000D1684
	[Token(Token = "0x60027DF")]
	[Address(RVA = "0x647C00", Offset = "0x646200", VA = "0x180647C00")]
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

	// Token: 0x060027E0 RID: 10208 RVA: 0x000D34C0 File Offset: 0x000D16C0
	[Token(Token = "0x60027E0")]
	[Address(RVA = "0x6475A0", Offset = "0x645BA0", VA = "0x1806475A0")]
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

	// Token: 0x060027E1 RID: 10209 RVA: 0x000D3504 File Offset: 0x000D1704
	[Token(Token = "0x60027E1")]
	[Address(RVA = "0x647C60", Offset = "0x646260", VA = "0x180647C60")]
	public MagnetLineMgr()
	{
		List<MagnetLine> list = new List();
		this.magnetLines = list;
		base..ctor();
	}

	// Token: 0x04001553 RID: 5459
	[Token(Token = "0x4001553")]
	public static MagnetLineMgr Instance;

	// Token: 0x04001554 RID: 5460
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001554")]
	public List<MagnetLine> magnetLines;
}
