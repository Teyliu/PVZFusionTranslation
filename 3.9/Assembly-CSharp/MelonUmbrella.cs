using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FF RID: 1023
[Token(Token = "0x20003FF")]
public class MelonUmbrella : CornUmbrella
{
	// Token: 0x060012E1 RID: 4833 RVA: 0x000699B8 File Offset: 0x00067BB8
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x4A8D60", Offset = "0x4A7360", VA = "0x1804A8D60", Slot = "68")]
	public override void Block(Bullet bullet)
	{
		base.Block(bullet);
		int num = this.storgedDamage;
		this.storgedDamage = num;
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = bullet.transform;
		Transform transform2 = bullet.transform;
		Plant umbrellaPot = base.UmbrellaPot;
		int num2 = 0;
		bool flag = umbrellaPot == num2;
		int num3 = this.attackDamage;
		if (!flag)
		{
			num3 += num3;
		}
		float y = bullet.acceleration.y;
		Vector2 acceleration = bullet.acceleration;
		float y2 = bullet.velocity.y;
		Vector2 velocity = bullet.velocity;
		bullet.Die();
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00069A50 File Offset: 0x00067C50
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x4A89A0", Offset = "0x4A6FA0", VA = "0x1804A89A0", Slot = "72")]
	protected override void BlockZombies()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		int num3 = 0;
		int num4 = 0;
		Collider2D[] array;
		if (num3 < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				bool flag3;
				if (flag2 && !flag3)
				{
					PlantType thePlantType = this.thePlantType;
					Plant umbrellaPot = base.UmbrellaPot;
					int num5 = 0;
					bool flag4 = umbrellaPot == num5;
					if (!flag4)
					{
					}
					num++;
					if (flag4 || flag4 || flag4)
					{
						int num6 = 0;
						PogoZombie pogoZombie;
						pogoZombie.LoseJumper(num6);
					}
				}
			}
			num4++;
		}
		this.storgedDamage = (int)((ulong)0L);
		if (num <= 0 || num == 1)
		{
			return;
		}
		if (18446744073709551614UL <= (ulong)3L)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00069B0C File Offset: 0x00067D0C
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public MelonUmbrella()
	{
	}

	// Token: 0x04000C8E RID: 3214
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C8E")]
	public int storgedDamage;
}
