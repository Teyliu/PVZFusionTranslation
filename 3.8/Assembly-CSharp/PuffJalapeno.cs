using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054C RID: 1356
[Token(Token = "0x200054C")]
public class PuffJalapeno : Plant
{
	// Token: 0x06001930 RID: 6448 RVA: 0x00088110 File Offset: 0x00086310
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x403ED0", Offset = "0x4024D0", VA = "0x180403ED0")]
	public void AnimExplode()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
		throw new NullReferenceException();
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x0008815C File Offset: 0x0008635C
	[Token(Token = "0x6001931")]
	[Address(RVA = "0x4DCE10", Offset = "0x4DB410", VA = "0x1804DCE10", Slot = "36")]
	protected override bool OnCrash()
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int num = 0;
		int attackDamage = this.attackDamage;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		ulong num3;
		boardAction.CreateFireLine(thePlantRow, attackDamage, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
		int num4 = 0;
		base.Die((Plant.DieReason)num4);
		return true;
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x000881B4 File Offset: 0x000863B4
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x4DCC00", Offset = "0x4DB200", VA = "0x1804DCC00", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		if (base.Active)
		{
			Transform axis = this.axis;
			int num2 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					int thePlantRow = this.thePlantRow;
					Team <Team>k__BackingField = this.<Team>k__BackingField;
					this.anim.Play("explode");
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, 1f);
					this.theStatus = (PlantStatus)((ulong)25L);
				}
				num++;
			}
		}
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x0008823C File Offset: 0x0008643C
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PuffJalapeno()
	{
	}
}
