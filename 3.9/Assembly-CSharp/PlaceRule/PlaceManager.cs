using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace PlaceRule
{
	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x2000A48")]
	public class PlaceManager
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x0011F634 File Offset: 0x0011D834
		[Token(Token = "0x17000277")]
		private static Board board
		{
			[Token(Token = "0x6003604")]
			[Address(RVA = "0x79E500", Offset = "0x79CB00", VA = "0x18079E500")]
			get
			{
				return Board.Instance;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x0011F648 File Offset: 0x0011D848
		[Token(Token = "0x17000278")]
		private static Mouse Mouse
		{
			[Token(Token = "0x6003605")]
			[Address(RVA = "0x79E4C0", Offset = "0x79CAC0", VA = "0x18079E4C0")]
			get
			{
				return Mouse.Instance;
			}
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x0011F65C File Offset: 0x0011D85C
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x79DAD0", Offset = "0x79C0D0", VA = "0x18079DAD0")]
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

		// Token: 0x06003607 RID: 13831 RVA: 0x0011F7E8 File Offset: 0x0011D9E8
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x79E3E0", Offset = "0x79C9E0", VA = "0x18079E3E0")]
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

		// Token: 0x06003608 RID: 13832 RVA: 0x0011F814 File Offset: 0x0011DA14
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlaceManager()
		{
		}
	}
}
