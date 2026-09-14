using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065F RID: 1631
[Token(Token = "0x200065F")]
public class ElephantZombie_c : ElephantZombie_a
{
	// Token: 0x06001F0A RID: 7946 RVA: 0x000A5644 File Offset: 0x000A3844
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x543B90", Offset = "0x542190", VA = "0x180543B90", Slot = "37")]
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

	// Token: 0x06001F0B RID: 7947 RVA: 0x000A568C File Offset: 0x000A388C
	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x543700", Offset = "0x541D00", VA = "0x180543700", Slot = "74")]
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

	// Token: 0x06001F0C RID: 7948 RVA: 0x000A573C File Offset: 0x000A393C
	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x543450", Offset = "0x541A50", VA = "0x180543450")]
	public ElephantZombie_c()
	{
	}
}
