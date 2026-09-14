using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using PlaceRule;
using UnityEngine;

// Token: 0x0200022F RID: 559
[Token(Token = "0x200022F")]
[Serializable]
public class BoardGrid
{
	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060009D4 RID: 2516 RVA: 0x00034E70 File Offset: 0x00033070
	[Token(Token = "0x170000BC")]
	public int WaterLevel
	{
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x8FFB10", Offset = "0x8FE110", VA = "0x1808FFB10")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x060009D5 RID: 2517 RVA: 0x00034E80 File Offset: 0x00033080
	// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00034E94 File Offset: 0x00033094
	[Token(Token = "0x170000BD")]
	public Corner Corner
	{
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x5EDAC0", Offset = "0x5EC0C0", VA = "0x1805EDAC0")]
		get;
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x5EDD40", Offset = "0x5EC340", VA = "0x1805EDD40")]
		set;
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00034EA8 File Offset: 0x000330A8
	[Token(Token = "0x170000BE")]
	public Vector2 Position
	{
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x8FFA90", Offset = "0x8FE090", VA = "0x1808FFA90")]
		get
		{
			float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.theColumn);
			Mouse instance = Mouse.Instance;
			int num = this.theRow;
			float landY = instance.GetLandY(boxXFromColumn, num);
			return typeof(Mouse).TypeHandle;
		}
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00034EE4 File Offset: 0x000330E4
	[Token(Token = "0x60009D8")]
	[Address(RVA = "0x8FF9A0", Offset = "0x8FDFA0", VA = "0x1808FF9A0")]
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

	// Token: 0x060009D9 RID: 2521 RVA: 0x00034F38 File Offset: 0x00033138
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x8FF850", Offset = "0x8FDE50", VA = "0x1808FF850")]
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

	// Token: 0x0400050B RID: 1291
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400050B")]
	public int theColumn;

	// Token: 0x0400050C RID: 1292
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400050C")]
	public int theRow;

	// Token: 0x0400050D RID: 1293
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400050D")]
	public int lightLevel;

	// Token: 0x0400050E RID: 1294
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400050E")]
	public int waterLevel;

	// Token: 0x0400050F RID: 1295
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400050F")]
	public int potNum;

	// Token: 0x04000510 RID: 1296
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000510")]
	public int lilyNum;

	// Token: 0x04000511 RID: 1297
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000511")]
	public int graveNum;

	// Token: 0x04000512 RID: 1298
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000512")]
	public int pitNum;

	// Token: 0x04000513 RID: 1299
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000513")]
	public float waterBoxY;

	// Token: 0x04000514 RID: 1300
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000514")]
	public float waterBoxYDeviation;

	// Token: 0x04000515 RID: 1301
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000515")]
	public bool existTreasure;

	// Token: 0x04000516 RID: 1302
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000516")]
	public bool lavaWater;

	// Token: 0x04000517 RID: 1303
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000517")]
	public BoxType boxType;

	// Token: 0x04000518 RID: 1304
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000518")]
	public List<Plant> plants;

	// Token: 0x04000519 RID: 1305
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000519")]
	public List<JigsawType> jigsaws;
}
