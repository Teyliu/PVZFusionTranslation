using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200044A RID: 1098
[Token(Token = "0x200044A")]
public class SquashBlover : Plant
{
	// Token: 0x0600143F RID: 5183 RVA: 0x00070A2C File Offset: 0x0006EC2C
	[Token(Token = "0x600143F")]
	[Address(RVA = "0x4BFEE0", Offset = "0x4BE4E0", VA = "0x1804BFEE0", Slot = "17")]
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
					if (Lawnf.ThrowLandStatus((ZombieStatus)num))
					{
						this.anim.SetTrigger("shoot");
						this.theStatus = (PlantStatus)((ulong)25L);
					}
				}
				num++;
			}
		}
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x00070AA4 File Offset: 0x0006ECA4
	[Token(Token = "0x6001440")]
	[Address(RVA = "0x4BFBA0", Offset = "0x4BE1A0", VA = "0x1804BFBA0")]
	private void AnimSquash()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (Lawnf.ThrowLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		Board board = this.board;
		int thePlantRow2 = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, thePlantRow2) != BoxType.Water)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			ScreenShake.TriggerShake(0.05f);
			return;
		}
		Vector2 oneVector = Vector2.oneVector;
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00070B60 File Offset: 0x0006ED60
	[Token(Token = "0x6001441")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SquashBlover()
	{
	}
}
