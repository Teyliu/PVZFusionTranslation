using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace PlaceRule
{
	// Token: 0x02000A09 RID: 2569
	[Token(Token = "0x2000A09")]
	public class PlaceManager
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x0011A478 File Offset: 0x00118678
		[Token(Token = "0x1700022F")]
		private static Board board
		{
			[Token(Token = "0x60034C3")]
			[Address(RVA = "0x737AB0", Offset = "0x7360B0", VA = "0x180737AB0")]
			get
			{
				return Board.Instance;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x0011A48C File Offset: 0x0011868C
		[Token(Token = "0x17000230")]
		private static Mouse Mouse
		{
			[Token(Token = "0x60034C4")]
			[Address(RVA = "0x737A70", Offset = "0x736070", VA = "0x180737A70")]
			get
			{
				return Mouse.Instance;
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x0011A4A0 File Offset: 0x001186A0
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x737080", Offset = "0x735680", VA = "0x180737080")]
		public static bool CanPlace(int theColumn, int theRow, PlantType thePlantType)
		{
			int num;
			int num4;
			do
			{
				num = 0;
				float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theRow);
				IceRoad iceRoad = Board.Instance.iceRoads[theRow];
				if (boxXFromColumn > iceRoad.x && thePlantType != PlantType.Gravebuster && thePlantType != PlantType.Tower_gravebuster)
				{
					goto IL_0151;
				}
				int theBoardLevel = GameAPP.theBoardLevel;
				bool flag;
				Layer layer;
				if (((theBoardLevel == 29 || theBoardLevel == 82) && !flag) || layer == Layer.Fly || Board.Instance.gridSystem.GetBoxType(theColumn, theRow) == BoxType.Stone)
				{
					goto IL_0151;
				}
				List<GridItem> griditemArray = Board.Instance.griditemArray;
				bool flag2;
				if (flag2)
				{
					int num2 = 0;
					bool flag3 = num != num2;
					while (!flag3)
					{
					}
					while (flag3 > true)
					{
					}
					while (thePlantType == PlantType.Gravebuster)
					{
					}
					while (thePlantType == PlantType.Tower_gravebuster)
					{
					}
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_0170;
				}
				BoardGrid boardGrid;
				List<Plant> plants = boardGrid.plants;
				bool flag4;
				if (!flag4)
				{
					break;
				}
				num4 = 0;
			}
			while (!(num != num4));
			ulong num5;
			if (num5 != (ulong)0L)
			{
				throw new NullReferenceException();
			}
			Layer layer2;
			BoxType boxType;
			bool flag5;
			bool flag6;
			bool flag7;
			BoxType boxType2;
			BoxType boxType3;
			if ((layer2 == Layer.Pot || boxType != BoxType.Roof || (!flag5 && !flag6 && flag7)) && boxType2 != BoxType.Water && boxType3 != BoxType.Dirt)
			{
				bool flag8;
				return flag8;
			}
			IL_0151:
			BoardGrid grid = Board.Instance.gridSystem.GetGrid(theRow, theRow);
			throw new NullReferenceException();
			IL_0170:
			throw new NullReferenceException();
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0011A62C File Offset: 0x0011882C
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x737990", Offset = "0x735F90", VA = "0x180737990")]
		public static Layer GetLayer(PlantType thePlantType)
		{
			bool flag;
			if (flag)
			{
				return Layer.Pot;
			}
			bool flag2;
			if (!flag2)
			{
				bool flag3;
				if (!flag3)
				{
				}
				return Layer.Pumpkin;
			}
			return Layer.Lily;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0011A658 File Offset: 0x00118858
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlaceManager()
		{
		}
	}
}
