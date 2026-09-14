using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B0 RID: 1200
[Token(Token = "0x20004B0")]
public class UltimateStarBlover : StarBlover
{
	// Token: 0x06001667 RID: 5735 RVA: 0x0007B79C File Offset: 0x0007999C
	[Token(Token = "0x6001667")]
	[Address(RVA = "0x4ECE00", Offset = "0x4EB400", VA = "0x1804ECE00", Slot = "70")]
	protected override void SetAccelerateTime()
	{
		ulong num5;
		do
		{
			int num = 0;
			int num2 = this.shootingLevel;
			num2 += 2;
			long num3 = (long)(num2 * (int)((uint)30));
			this.maxBullets = (int)num3;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			bool flag;
			if (flag)
			{
				int num4 = 0;
				if (!(num != num4))
				{
					continue;
				}
				int maxBullets = this.maxBullets;
				this.maxBullets = maxBullets;
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0007B828 File Offset: 0x00079A28
	[Token(Token = "0x6001668")]
	[Address(RVA = "0x4ECFC0", Offset = "0x4EB5C0", VA = "0x1804ECFC0", Slot = "71")]
	protected override void StarsUpdate()
	{
		ulong num5;
		do
		{
			int num = 0;
			List<Bullet_star> list = Enumerable.ToList<Bullet_star>(this.starBullets);
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
				float num3 = this.accTimer;
				uint num4;
				num4 += num4;
				base.RemoveNode(num);
				float deltaTime = Time.deltaTime;
				base.RotateOnCircle(num);
				base.MoveToCircle(num);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x0007B8A8 File Offset: 0x00079AA8
	[Token(Token = "0x6001669")]
	[Address(RVA = "0x4ED220", Offset = "0x4EB820", VA = "0x1804ED220")]
	public UltimateStarBlover()
	{
	}

	// Token: 0x04000DF0 RID: 3568
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000DF0")]
	public float accTimer = 1.5f;
}
