using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030C RID: 780
[Token(Token = "0x200030C")]
public class CaltropKelp_land : Caltrop
{
	// Token: 0x06000E3B RID: 3643 RVA: 0x00051B38 File Offset: 0x0004FD38
	[Token(Token = "0x6000E3B")]
	[Address(RVA = "0x444C50", Offset = "0x443250", VA = "0x180444C50", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		int num = Mathf.Min(gridSystem.GetGrid(thePlantColumn, thePlantRow).WaterLevel, 1);
		float num2;
		base.ModifySpeed((PlantSpeedAdder)((uint)4), num2);
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00051B84 File Offset: 0x0004FD84
	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x4449D0", Offset = "0x442FD0", VA = "0x1804449D0", Slot = "71")]
	protected override void AnimAttack()
	{
		int num = 0;
		base.KillCar();
		Transform axis = this.axis;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00051BF4 File Offset: 0x0004FDF4
	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x444D10", Offset = "0x443310", VA = "0x180444D10")]
	public CaltropKelp_land()
	{
	}
}
