using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlaceRule;
using UnityEngine;

// Token: 0x0200022A RID: 554
[Token(Token = "0x200022A")]
[Serializable]
public class BoardGrid
{
	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060009BE RID: 2494 RVA: 0x00035068 File Offset: 0x00033268
	// (set) Token: 0x060009BF RID: 2495 RVA: 0x0003507C File Offset: 0x0003327C
	[Token(Token = "0x1700007F")]
	public Corner Corner
	{
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x5B7FF0", Offset = "0x5B65F0", VA = "0x1805B7FF0")]
		get;
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x5B8270", Offset = "0x5B6870", VA = "0x1805B8270")]
		set;
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00035090 File Offset: 0x00033290
	[Token(Token = "0x17000080")]
	public Vector2 Position
	{
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x86FDD0", Offset = "0x86E3D0", VA = "0x18086FDD0")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
			Mouse instance = Mouse.Instance;
			int num = this.theRow;
			float landY = instance.GetLandY(boxXFromColumn, num);
			return typeof(Mouse).TypeHandle;
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x000350CC File Offset: 0x000332CC
	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x86FCE0", Offset = "0x86E2E0", VA = "0x18086FCE0")]
	public BoardGrid(int column, int row)
	{
		this.theColumn = column;
		this.theRow = row;
		List<Plant> list = new List();
		this.plants = list;
		List<JigsawType> list2 = new List();
		this.jigsaws = list2;
		float num = global::UnityEngine.Random.Range(-90f, 90f);
		this.waterBoxYDeviation = num;
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00035120 File Offset: 0x00033320
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x86FB90", Offset = "0x86E190", VA = "0x18086FB90")]
	public bool HasPlantOnLayer(Layer plantLayer)
	{
		for (;;)
		{
			int num = 0;
			List<Plant> list = this.plants;
			bool flag;
			ulong num2;
			if (flag)
			{
				if (PlaceManager.GetLayer((PlantType)num) == plantLayer)
				{
					break;
				}
			}
			else if (num2 == (ulong)0L)
			{
				goto Block_2;
			}
		}
		return true;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x04000505 RID: 1285
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000505")]
	public int theColumn;

	// Token: 0x04000506 RID: 1286
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000506")]
	public int theRow;

	// Token: 0x04000507 RID: 1287
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000507")]
	public int lightLevel;

	// Token: 0x04000508 RID: 1288
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000508")]
	public int potNum;

	// Token: 0x04000509 RID: 1289
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000509")]
	public int lilyNum;

	// Token: 0x0400050A RID: 1290
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400050A")]
	public int graveNum;

	// Token: 0x0400050B RID: 1291
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400050B")]
	public int pitNum;

	// Token: 0x0400050C RID: 1292
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400050C")]
	public float waterBoxY;

	// Token: 0x0400050D RID: 1293
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400050D")]
	public float waterBoxYDeviation;

	// Token: 0x0400050E RID: 1294
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400050E")]
	public bool existTreasure;

	// Token: 0x0400050F RID: 1295
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x400050F")]
	public bool lavaWater;

	// Token: 0x04000510 RID: 1296
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000510")]
	public BoxType boxType;

	// Token: 0x04000511 RID: 1297
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000511")]
	public List<Plant> plants;

	// Token: 0x04000512 RID: 1298
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000512")]
	public List<JigsawType> jigsaws;
}
