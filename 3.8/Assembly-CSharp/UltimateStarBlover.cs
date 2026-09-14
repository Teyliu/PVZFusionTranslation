using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200048E RID: 1166
[Token(Token = "0x200048E")]
public class UltimateStarBlover : StarBlover
{
	// Token: 0x060015C7 RID: 5575 RVA: 0x00078E18 File Offset: 0x00077018
	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x493950", Offset = "0x491F50", VA = "0x180493950", Slot = "71")]
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

	// Token: 0x060015C8 RID: 5576 RVA: 0x00078EA4 File Offset: 0x000770A4
	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x493B10", Offset = "0x492110", VA = "0x180493B10", Slot = "72")]
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

	// Token: 0x060015C9 RID: 5577 RVA: 0x00078F24 File Offset: 0x00077124
	[Token(Token = "0x60015C9")]
	[Address(RVA = "0x493D70", Offset = "0x492370", VA = "0x180493D70")]
	public UltimateStarBlover()
	{
	}

	// Token: 0x04000D57 RID: 3415
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000D57")]
	public float accTimer = 1.5f;
}
