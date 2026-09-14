using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000779 RID: 1913
[Token(Token = "0x2000779")]
public class MagnetLine : MonoBehaviour
{
	// Token: 0x060026AB RID: 9899 RVA: 0x000CE2D0 File Offset: 0x000CC4D0
	[Token(Token = "0x60026AB")]
	[Address(RVA = "0x5E49A0", Offset = "0x5E2FA0", VA = "0x1805E49A0")]
	private void Awake()
	{
		LineRenderer component = base.GetComponent<LineRenderer>();
		this.lineRenderer = component;
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000CE2EC File Offset: 0x000CC4EC
	[Token(Token = "0x60026AC")]
	[Address(RVA = "0x5E49F0", Offset = "0x5E2FF0", VA = "0x1805E49F0")]
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

	// Token: 0x060026AD RID: 9901 RVA: 0x000CE360 File Offset: 0x000CC560
	[Token(Token = "0x60026AD")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public MagnetLine()
	{
	}

	// Token: 0x04001472 RID: 5234
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001472")]
	private LineRenderer lineRenderer;

	// Token: 0x04001473 RID: 5235
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001473")]
	public int firstColumn;

	// Token: 0x04001474 RID: 5236
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001474")]
	public int firstRow;

	// Token: 0x04001475 RID: 5237
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001475")]
	public int secondColumn;

	// Token: 0x04001476 RID: 5238
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001476")]
	public int secondRow;
}
