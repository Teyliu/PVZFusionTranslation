using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079C RID: 1948
[Token(Token = "0x200079C")]
public class GridManager : MonoBehaviour
{
	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06002784 RID: 10116 RVA: 0x000D16C0 File Offset: 0x000CF8C0
	[Token(Token = "0x170001D1")]
	public static GridManager Instance
	{
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x6464C0", Offset = "0x644AC0", VA = "0x1806464C0")]
		get
		{
			GridManager instance = GridManager._instance;
			int num = 0;
			if (instance == num)
			{
				GridManager._instance = global::UnityEngine.Object.FindObjectOfType<GridManager>();
				int num2 = 0;
				if (GridManager._instance == num2)
				{
					GridManager._instance = new GameObject("GridManager").AddComponent<GridManager>();
				}
			}
			return GridManager._instance;
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06002785 RID: 10117 RVA: 0x000D1718 File Offset: 0x000CF918
	[Token(Token = "0x170001D2")]
	private bool IsRoof
	{
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x646640", Offset = "0x644C40", VA = "0x180646640")]
		get
		{
			return true;
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06002786 RID: 10118 RVA: 0x000D172C File Offset: 0x000CF92C
	[Token(Token = "0x170001D3")]
	private bool Narrow
	{
		[Token(Token = "0x6002786")]
		[Address(RVA = "0x646660", Offset = "0x644C60", VA = "0x180646660")]
		get
		{
			if (this.sixRow || !this.sixRow)
			{
			}
			return true;
		}
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000D1750 File Offset: 0x000CF950
	[Token(Token = "0x6002787")]
	[Address(RVA = "0x6461E0", Offset = "0x6447E0", VA = "0x1806461E0")]
	private float GetRoofHeightOffset(float x)
	{
		float num = this.roofX * this.gridWidth;
		if (num < x)
		{
		}
		return num;
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000D1778 File Offset: 0x000CF978
	[Token(Token = "0x6002788")]
	[Address(RVA = "0x6460D0", Offset = "0x6446D0", VA = "0x1806460D0")]
	private Vector3 GetGridCornerWorldPos(int col, int row, int corner)
	{
		return default(Vector3);
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x000D1794 File Offset: 0x000CF994
	[Token(Token = "0x6002789")]
	[Address(RVA = "0x646230", Offset = "0x644830", VA = "0x180646230")]
	private int GetRowFromYNormal(float y)
	{
		float y2 = this.TopLeftConer.y;
		if (y <= y2)
		{
			int num = 0;
			if ((this.sixRow ? 1 : 0) != num || (this.sixRow ? 1 : 0) != num)
			{
			}
			int num2 = this.rowNum;
			return num;
		}
		return 0;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000D17D0 File Offset: 0x000CF9D0
	[Token(Token = "0x600278A")]
	[Address(RVA = "0x646290", Offset = "0x644890", VA = "0x180646290")]
	private int GetRowFromYRoof(float x, float y)
	{
		if (this.roofX < x)
		{
			if (y <= this.yTopThreshold)
			{
				int num = 0;
				if ((this.sixRow ? 1 : 0) != num || (this.sixRow ? 1 : 0) != num)
				{
				}
				int num2 = this.rowNum;
				return num;
			}
		}
		else if (y <= this.yBottomThreshold)
		{
			if (this.sixRow || !this.sixRow)
			{
			}
			return this.rowNum;
		}
		return 0;
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x000D1834 File Offset: 0x000CFA34
	[Token(Token = "0x600278B")]
	[Address(RVA = "0x646350", Offset = "0x644950", VA = "0x180646350")]
	public int GetRowFromY(float x, float y)
	{
		float num = this.roofSlope;
		float y2 = this.TopLeftConer.y;
		int num2 = 0;
		if (y <= y2)
		{
			if ((this.sixRow ? 1 : 0) != num2 || (this.sixRow ? 1 : 0) != num2)
			{
			}
			int num3 = this.rowNum;
			return num2;
		}
		return num2;
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x000D18A8 File Offset: 0x000CFAA8
	[Token(Token = "0x600278C")]
	[Address(RVA = "0x645DC0", Offset = "0x6443C0", VA = "0x180645DC0")]
	public int GetColumnFromX(float x)
	{
		if (this.TopLeftConer <= x)
		{
			return this.columnNum;
		}
		return 0;
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x000D18C8 File Offset: 0x000CFAC8
	[Token(Token = "0x600278D")]
	[Address(RVA = "0x646000", Offset = "0x644600", VA = "0x180646000")]
	public Vector3 GetGridCenter(int col, int row)
	{
		return default(Vector3);
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x000D18E4 File Offset: 0x000CFAE4
	[Token(Token = "0x600278E")]
	[Address(RVA = "0x645DF0", Offset = "0x6443F0", VA = "0x180645DF0")]
	public Vector3 GetGridCenterFromWorld(float x, float y)
	{
		int num = 0;
		if (x < (float)num)
		{
			return default(Vector3);
		}
		return default(Vector3);
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x000D1910 File Offset: 0x000CFB10
	[Token(Token = "0x600278F")]
	[Address(RVA = "0x646460", Offset = "0x644A60", VA = "0x180646460")]
	public GridManager()
	{
		this.TopLeftConer.y = 3.7f;
		this.gridWidth = 1.35f;
		this.gridLength = 1.67f;
		this.gridLength_narrow = 1.45f;
		this.columnNum = (int)((ulong)10L);
		this.rowNum = (int)((ulong)5L);
		this.roofOffset = 0.5f;
		this.yTopThreshold = 3.7f;
		this.yBottomThreshold = 1.6f;
		this.roofX = 1.5f;
		base..ctor();
	}

	// Token: 0x040014C5 RID: 5317
	[Token(Token = "0x40014C5")]
	private static GridManager _instance;

	// Token: 0x040014C6 RID: 5318
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014C6")]
	public Vector2 TopLeftConer = (ulong)3232707379L;

	// Token: 0x040014C7 RID: 5319
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014C7")]
	public float gridWidth;

	// Token: 0x040014C8 RID: 5320
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40014C8")]
	public float gridLength;

	// Token: 0x040014C9 RID: 5321
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014C9")]
	public float gridLength_narrow;

	// Token: 0x040014CA RID: 5322
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014CA")]
	public int columnNum;

	// Token: 0x040014CB RID: 5323
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014CB")]
	public int rowNum;

	// Token: 0x040014CC RID: 5324
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40014CC")]
	public bool sixRow;

	// Token: 0x040014CD RID: 5325
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014CD")]
	public Color textColor;

	// Token: 0x040014CE RID: 5326
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40014CE")]
	[Header("屋顶模式（斜率=0时为平地）")]
	public float roofSlope;

	// Token: 0x040014CF RID: 5327
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40014CF")]
	public float roofOffset;

	// Token: 0x040014D0 RID: 5328
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014D0")]
	public float yTopThreshold;

	// Token: 0x040014D1 RID: 5329
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40014D1")]
	public float yBottomThreshold;

	// Token: 0x040014D2 RID: 5330
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40014D2")]
	public float roofX;
}
