using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003E7 RID: 999
[Token(Token = "0x20003E7")]
public class MelonUmbrella : CornUmbrella
{
	// Token: 0x06001274 RID: 4724 RVA: 0x00067D8C File Offset: 0x00065F8C
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x453E40", Offset = "0x452440", VA = "0x180453E40", Slot = "69")]
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
		float detaVy = bullet.detaVy;
		float vx = bullet.Vx;
		float vy = bullet.Vy;
		bullet.Die();
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00067E14 File Offset: 0x00066014
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x453A80", Offset = "0x452080", VA = "0x180453A80", Slot = "71")]
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

	// Token: 0x06001276 RID: 4726 RVA: 0x00067ED0 File Offset: 0x000660D0
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public MelonUmbrella()
	{
	}

	// Token: 0x04000C19 RID: 3097
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000C19")]
	public int storgedDamage;
}
