using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007B2 RID: 1970
[Token(Token = "0x20007B2")]
public class MagnetLine : MonoBehaviour
{
	// Token: 0x060027DA RID: 10202 RVA: 0x000D3300 File Offset: 0x000D1500
	[Token(Token = "0x60027DA")]
	[Address(RVA = "0x647CE0", Offset = "0x6462E0", VA = "0x180647CE0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x000D331C File Offset: 0x000D151C
	[Token(Token = "0x60027DB")]
	[Address(RVA = "0x647D30", Offset = "0x646330", VA = "0x180647D30")]
	public void SetLinePositions(int column0, int row0, int column1, int row1)
	{
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(column0);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, row0);
		float boxXFromColumn2 = Mouse.Instance.GetBoxXFromColumn(column0);
		Mouse instance = Mouse.Instance;
		LineRenderer lineRenderer = this.lineRenderer;
		LineRenderer lineRenderer2 = this.lineRenderer;
		this.firstRow = row0;
		this.secondColumn = column1;
		this.secondRow = 0;
		this.firstColumn = column0;
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x000D3390 File Offset: 0x000D1590
	[Token(Token = "0x60027DC")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public MagnetLine()
	{
	}

	// Token: 0x0400154E RID: 5454
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400154E")]
	private LineRenderer lineRenderer;

	// Token: 0x0400154F RID: 5455
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400154F")]
	public int firstColumn;

	// Token: 0x04001550 RID: 5456
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001550")]
	public int firstRow;

	// Token: 0x04001551 RID: 5457
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001551")]
	public int secondColumn;

	// Token: 0x04001552 RID: 5458
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001552")]
	public int secondRow;
}
