using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000695 RID: 1685
[Token(Token = "0x2000695")]
public class ElephantZombie_c : ElephantZombie_a
{
	// Token: 0x0600200C RID: 8204 RVA: 0x000A9DBC File Offset: 0x000A7FBC
	[Token(Token = "0x600200C")]
	[Address(RVA = "0x5A61B0", Offset = "0x5A47B0", VA = "0x1805A61B0", Slot = "39")]
	protected override void PlayEatSound2()
	{
		base.PlayEatSound2();
		int attributeCount = this.attributeCount;
		int num = attributeCount + 1;
		this.attributeCount = num;
		if (attributeCount == 3)
		{
			this.anim.SetTrigger("attack2");
			this.attributeCount = (int)((ulong)0L);
		}
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x000A9E04 File Offset: 0x000A8004
	[Token(Token = "0x600200D")]
	[Address(RVA = "0x5A5D20", Offset = "0x5A4320", VA = "0x1805A5D20", Slot = "76")]
	protected override void KnockOthers()
	{
		int num = 0;
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				bool flag2;
				if (!Lawnf.InLandStatus((ZombieStatus)num) || !flag2)
				{
				}
			}
			num++;
		}
		Transform shoot2 = this.shoot;
		int num3 = this.plantLayer;
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag3;
			if (flag3 && Lawnf.InLandStatus((ZombieStatus)num))
			{
				num++;
			}
			bool flag4;
			if (flag4)
			{
				int num4 = 0;
				bool flag5;
				if (!flag5)
				{
					num4 += num4;
					int num5 = num.System.IConvertible.ToInt32(num4);
				}
			}
			num++;
		}
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000A9EB4 File Offset: 0x000A80B4
	[Token(Token = "0x600200E")]
	[Address(RVA = "0x5A5A70", Offset = "0x5A4070", VA = "0x1805A5A70")]
	public ElephantZombie_c()
	{
	}
}
