using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000462 RID: 1122
[Token(Token = "0x2000462")]
public class UltimateBigChomper : BigChomper
{
	// Token: 0x060014B2 RID: 5298 RVA: 0x0007328C File Offset: 0x0007148C
	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x47D360", Offset = "0x47B960", VA = "0x18047D360", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)34)))
		{
			this.attributeFloat = 5f;
		}
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x000732B8 File Offset: 0x000714B8
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x47DB40", Offset = "0x47C140", VA = "0x18047DB40", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x000732CC File Offset: 0x000714CC
	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x47D570", Offset = "0x47BB70", VA = "0x18047D570")]
	private void SwallowEvent()
	{
		int num = 0;
		Transform axis = this.axis;
		bool flag;
		if (!flag)
		{
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num >= array.Length)
			{
				goto IL_0117;
			}
			bool flag2;
			bool flag3;
			if (flag2 && flag2 && base.CheckZombie(num) && !flag3)
			{
				Board board = this.board;
				BoxType boxType;
				int num3 = (int)boxType;
				GridSystem gridSystem = board.gridSystem;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				BoardGrid grid = gridSystem.GetGrid(thePlantColumn, thePlantRow);
				if (num3 == (int)grid.boxType)
				{
					int thePlantRow2 = this.thePlantRow;
					bool flag4 = num.Equals(thePlantRow2);
				}
			}
			num++;
		}
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag5;
			if (flag5)
			{
				int thePlantRow3 = this.thePlantRow;
				bool flag6;
				if (base.CheckZombie(num) && !flag6)
				{
					Board board2 = this.board;
					BoxType boxType2;
					int num4 = (int)boxType2;
					GridSystem gridSystem2 = board2.gridSystem;
					int thePlantRow4 = this.thePlantRow;
					int thePlantColumn2 = this.thePlantColumn;
					BoardGrid grid2 = gridSystem2.GetGrid(thePlantColumn2, thePlantRow4);
					if (num4 == (int)grid2.boxType)
					{
						int thePlantRow5 = this.thePlantRow;
						bool flag7 = num.Equals(thePlantRow5);
					}
				}
			}
			num++;
		}
		IL_0117:
		if ((this.add ? 1 : 0) != num)
		{
			CreatePlant instance = CreatePlant.Instance;
			int thePlantRow6 = this.thePlantRow;
			int thePlantColumn3 = this.thePlantColumn;
			uint num5;
			ulong num6;
			instance.AdjustLightLevel(thePlantColumn3, thePlantRow6, (int)num5, (int)num6);
			this.add = num != 0;
		}
		int num7 = 0;
		ulong num8;
		base.Recover(3f, (DamageType)num7, num8 != 0UL, num != 0);
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00073440 File Offset: 0x00071640
	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x47D450", Offset = "0x47BA50", VA = "0x18047D450", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base.Dispose();
		if (this.add)
		{
			ulong num;
			CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -2, (int)num);
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00073478 File Offset: 0x00071678
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x47D390", Offset = "0x47B990", VA = "0x18047D390", Slot = "74")]
	protected override void Chomp(Zombie zombie)
	{
		base.Chomp(zombie);
		if (Lawnf.TravelUltimate((UltiBuff)((uint)35)))
		{
			CreatePlant instance = CreatePlant.Instance;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			ulong num;
			instance.AdjustLightLevel(thePlantColumn, thePlantRow, 2, (int)num);
			this.add = true;
		}
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x000734C4 File Offset: 0x000716C4
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x47DB10", Offset = "0x47C110", VA = "0x18047DB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x000734D4 File Offset: 0x000716D4
	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x430E90", Offset = "0x42F490", VA = "0x180430E90")]
	public UltimateBigChomper()
	{
	}

	// Token: 0x04000CD0 RID: 3280
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CD0")]
	private bool add;
}
