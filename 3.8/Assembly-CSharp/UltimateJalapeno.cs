using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200047C RID: 1148
[Token(Token = "0x200047C")]
public class UltimateJalapeno : Plant
{
	// Token: 0x0600154E RID: 5454 RVA: 0x00076040 File Offset: 0x00074240
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x48BED0", Offset = "0x48A4D0", VA = "0x18048BED0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x00076054 File Offset: 0x00074254
	[Token(Token = "0x600154F")]
	[Address(RVA = "0x48C900", Offset = "0x48AF00", VA = "0x18048C900", Slot = "15")]
	protected override void Start()
	{
		base.Start();
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x00076068 File Offset: 0x00074268
	[Token(Token = "0x6001550")]
	[Address(RVA = "0x48BFE0", Offset = "0x48A5E0", VA = "0x18048BFE0", Slot = "69")]
	protected virtual void LimCount()
	{
		Board board = this.board;
		int plantCount = Lawnf.GetPlantCount(this.thePlantType, board);
		int num = this.board.rowNum;
		num += 2;
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x000760C8 File Offset: 0x000742C8
	[Token(Token = "0x6001551")]
	[Address(RVA = "0x48BFB0", Offset = "0x48A5B0", VA = "0x18048BFB0")]
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

	// Token: 0x06001552 RID: 5458 RVA: 0x000760F4 File Offset: 0x000742F4
	[Token(Token = "0x6001552")]
	[Address(RVA = "0x48BF90", Offset = "0x48A590", VA = "0x18048BF90", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.BySelf)
		{
		}
	}

	// Token: 0x06001553 RID: 5459 RVA: 0x00076108 File Offset: 0x00074308
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x48BEF0", Offset = "0x48A4F0", VA = "0x18048BEF0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason != Plant.DieReason.BySelf)
		{
			Action<object> action;
			EventManager.RemoveListener((GameEvent)((uint)2), action);
		}
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00076124 File Offset: 0x00074324
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x48C230", Offset = "0x48A830", VA = "0x18048C230", Slot = "70")]
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

	// Token: 0x06001555 RID: 5461 RVA: 0x00076194 File Offset: 0x00074394
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x48C490", Offset = "0x48AA90", VA = "0x18048C490", Slot = "71")]
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
					goto IL_009F;
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
		board.boardAction.CreateFreeze(num4, 4f);
		return;
		IL_009F:
		throw new NullReferenceException();
	}

	// Token: 0x06001556 RID: 5462 RVA: 0x00076248 File Offset: 0x00074448
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x48C320", Offset = "0x48A920", VA = "0x18048C320")]
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

	// Token: 0x06001557 RID: 5463 RVA: 0x000762D8 File Offset: 0x000744D8
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x48C160", Offset = "0x48A760", VA = "0x18048C160", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000762F8 File Offset: 0x000744F8
	[Token(Token = "0x6001558")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public UltimateJalapeno()
	{
	}

	// Token: 0x04000D0F RID: 3343
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D0F")]
	private int count;
}
