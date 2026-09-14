using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057B RID: 1403
[Token(Token = "0x200057B")]
public class PuffJalapeno : Plant
{
	// Token: 0x06001A0C RID: 6668 RVA: 0x0008C07C File Offset: 0x0008A27C
	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x448100", Offset = "0x446700", VA = "0x180448100")]
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

	// Token: 0x06001A0D RID: 6669 RVA: 0x0008C0C8 File Offset: 0x0008A2C8
	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x53AF20", Offset = "0x539520", VA = "0x18053AF20", Slot = "35")]
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

	// Token: 0x06001A0E RID: 6670 RVA: 0x0008C120 File Offset: 0x0008A320
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x53AD10", Offset = "0x539310", VA = "0x18053AD10", Slot = "17")]
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

	// Token: 0x06001A0F RID: 6671 RVA: 0x0008C1A8 File Offset: 0x0008A3A8
	[Token(Token = "0x6001A0F")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PuffJalapeno()
	{
	}
}
