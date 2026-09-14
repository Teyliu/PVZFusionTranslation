using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049E RID: 1182
[Token(Token = "0x200049E")]
public class UltimateJalapeno : Plant
{
	// Token: 0x060015EE RID: 5614 RVA: 0x00078A10 File Offset: 0x00076C10
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x4E5450", Offset = "0x4E3A50", VA = "0x1804E5450", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x00078A24 File Offset: 0x00076C24
	[Token(Token = "0x60015EF")]
	[Address(RVA = "0x4E5E80", Offset = "0x4E4480", VA = "0x1804E5E80", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x00078A38 File Offset: 0x00076C38
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x4E5560", Offset = "0x4E3B60", VA = "0x1804E5560", Slot = "68")]
	protected virtual void LimCount()
	{
		Board board = this.board;
		int plantCount = Lawnf.GetPlantCount(this.thePlantType, board);
		int num = this.board.rowNum;
		num += 2;
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00078A84 File Offset: 0x00076C84
	[Token(Token = "0x60015F1")]
	[Address(RVA = "0x4E5530", Offset = "0x4E3B30", VA = "0x1804E5530")]
	protected void GetEnergy(int max)
	{
		int num = this.attributeCount;
		num++;
		this.attributeCount = num;
		if (num > max)
		{
			this.attributeCount = max;
		}
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00078AB0 File Offset: 0x00076CB0
	[Token(Token = "0x60015F2")]
	[Address(RVA = "0x4E5510", Offset = "0x4E3B10", VA = "0x1804E5510", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.BySelf)
		{
		}
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00078AC4 File Offset: 0x00076CC4
	[Token(Token = "0x60015F3")]
	[Address(RVA = "0x4E5470", Offset = "0x4E3A70", VA = "0x1804E5470", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.BySelf)
		{
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)2), action);
		}
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00078AE0 File Offset: 0x00076CE0
	[Token(Token = "0x60015F4")]
	[Address(RVA = "0x4E57B0", Offset = "0x4E3DB0", VA = "0x1804E57B0", Slot = "69")]
	public virtual void OnDeath()
	{
		int num = 0;
		Board board = this.board;
		Board board2;
		if (num < board.rowNum)
		{
			BoardAction boardAction = board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int num2 = 0;
			int attackDamage = this.attackDamage;
			ulong num3;
			ulong num4;
			boardAction.CreateFireLine(num, attackDamage, num2 != 0, num3 != 0UL, num4 != 0UL, num, thePlantType);
			board2 = this.board;
			num++;
		}
		Transform axis = this.axis;
		BoardAction boardAction2 = board2.boardAction;
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x00078B50 File Offset: 0x00076D50
	[Token(Token = "0x60015F5")]
	[Address(RVA = "0x4E5A10", Offset = "0x4E4010", VA = "0x1804E5A10", Slot = "70")]
	public virtual void RecoverAll(Plant _plant)
	{
		int num3;
		do
		{
			bool flag;
			if (flag)
			{
				List<Plant> allPlants = Lawnf.GetAllPlants();
				int num = 0;
				bool flag2;
				if (flag2)
				{
					float[] array;
					float num2 = array[1];
					if (num2 <= 1f)
					{
					}
					float[] array2;
					array2[1] = num2;
				}
				if (num != 0)
				{
					goto IL_00A1;
				}
			}
			List<Plant> allPlants2 = Lawnf.GetAllPlants();
			num3 = 0;
			bool flag3;
			if (flag3)
			{
			}
		}
		while (num3 != 0);
		int num4 = 0;
		Board board = this.board;
		BoardAction boardAction = board.boardAction;
		num4++;
		ulong num5;
		board.boardAction.CreateFreeze(num4, 4f, num5 != 0UL);
		return;
		IL_00A1:
		throw new NullReferenceException();
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00078C04 File Offset: 0x00076E04
	[Token(Token = "0x60015F6")]
	[Address(RVA = "0x4E58A0", Offset = "0x4E3EA0", VA = "0x1804E58A0")]
	protected void OnZombieDeath(object value)
	{
		bool flag;
		bool flag2;
		uint num2;
		if (flag != flag2)
		{
			int num = this.attributeCount;
			num++;
			this.attributeCount = num;
			if (num > (int)num2)
			{
				this.attributeCount = (int)num2;
			}
			base.UpdateText();
		}
		int num3 = this.count;
		num3++;
		this.count = num3;
		num3 += -500;
		this.count = num3;
		int num4 = this.attributeCount;
		num4++;
		this.attributeCount = num4;
		if (num4 > (int)num2)
		{
			this.attributeCount = (int)num2;
		}
		base.UpdateText();
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00078C94 File Offset: 0x00076E94
	[Token(Token = "0x60015F7")]
	[Address(RVA = "0x4E56E0", Offset = "0x4E3CE0", VA = "0x1804E56E0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x00078CB4 File Offset: 0x00076EB4
	[Token(Token = "0x60015F8")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public UltimateJalapeno()
	{
	}

	// Token: 0x04000DA8 RID: 3496
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000DA8")]
	private int count;
}
