using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200042B RID: 1067
[Token(Token = "0x200042B")]
public class SquashBlover : Plant
{
	// Token: 0x060013B5 RID: 5045 RVA: 0x0006E79C File Offset: 0x0006C99C
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x468EF0", Offset = "0x4674F0", VA = "0x180468EF0", Slot = "17")]
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

	// Token: 0x060013B6 RID: 5046 RVA: 0x0006E814 File Offset: 0x0006CA14
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x468BB0", Offset = "0x4671B0", VA = "0x180468BB0")]
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

	// Token: 0x060013B7 RID: 5047 RVA: 0x0006E8D0 File Offset: 0x0006CAD0
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SquashBlover()
	{
	}
}
