using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000482 RID: 1154
[Token(Token = "0x2000482")]
public class UltimateBigChomper : BigChomper
{
	// Token: 0x06001542 RID: 5442 RVA: 0x000755E0 File Offset: 0x000737E0
	[Token(Token = "0x6001542")]
	[Address(RVA = "0x4D4CE0", Offset = "0x4D32E0", VA = "0x1804D4CE0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)34)))
		{
			this.attributeFloat = 5f;
		}
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x0007560C File Offset: 0x0007380C
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x4D54C0", Offset = "0x4D3AC0", VA = "0x1804D54C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x00075620 File Offset: 0x00073820
	[Token(Token = "0x6001544")]
	[Address(RVA = "0x4D4EF0", Offset = "0x4D34F0", VA = "0x1804D4EF0")]
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
				goto IL_00F3;
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
				}
			}
			num++;
		}
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag4;
			if (flag4)
			{
				int thePlantRow2 = this.thePlantRow;
				bool flag5;
				if (base.CheckZombie(num) && !flag5)
				{
					Board board2 = this.board;
					BoxType boxType2;
					int num4 = (int)boxType2;
					GridSystem gridSystem2 = board2.gridSystem;
					int thePlantRow3 = this.thePlantRow;
					int thePlantColumn2 = this.thePlantColumn;
					BoardGrid grid2 = gridSystem2.GetGrid(thePlantColumn2, thePlantRow3);
					if (num4 == (int)grid2.boxType)
					{
					}
				}
			}
			num++;
		}
		IL_00F3:
		if ((this.add ? 1 : 0) != num)
		{
			CreatePlant instance = CreatePlant.Instance;
			int thePlantRow4 = this.thePlantRow;
			int thePlantColumn3 = this.thePlantColumn;
			uint num5;
			ulong num6;
			instance.AdjustLightLevel(thePlantColumn3, thePlantRow4, (int)num5, (int)num6);
			this.add = num != 0;
		}
		int num7 = 0;
		ulong num8;
		base.Recover(3f, (DamageType)num7, num8 != 0UL, num != 0);
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00075770 File Offset: 0x00073970
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x4D4DD0", Offset = "0x4D33D0", VA = "0x1804D4DD0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
		base..ctor();
		if (this.add)
		{
			ulong num;
			CreatePlant.Instance.AdjustLightLevel(originalColumn, originalRow, -2, (int)num);
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x06001546 RID: 5446 RVA: 0x000757A8 File Offset: 0x000739A8
	[Token(Token = "0x6001546")]
	[Address(RVA = "0x4D4D10", Offset = "0x4D3310", VA = "0x1804D4D10", Slot = "74")]
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

	// Token: 0x06001547 RID: 5447 RVA: 0x000757F4 File Offset: 0x000739F4
	[Token(Token = "0x6001547")]
	[Address(RVA = "0x4D5490", Offset = "0x4D3A90", VA = "0x1804D5490", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00075804 File Offset: 0x00073A04
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x458C10", Offset = "0x457210", VA = "0x180458C10")]
	public UltimateBigChomper()
	{
	}

	// Token: 0x04000D5C RID: 3420
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D5C")]
	private bool add;
}
