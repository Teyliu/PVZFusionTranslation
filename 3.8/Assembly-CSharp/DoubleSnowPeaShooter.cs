using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020004EA RID: 1258
[Token(Token = "0x20004EA")]
public class DoubleSnowPeaShooter : Shooter
{
	// Token: 0x060017A3 RID: 6051 RVA: 0x00081270 File Offset: 0x0007F470
	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x00081290 File Offset: 0x0007F490
	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x4C7840", Offset = "0x4C5E40", VA = "0x1804C7840", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		for (;;)
		{
			int num = 0;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				return BulletType.Bullet_snowPea;
			}
		}
		return BulletType.Bullet_extremeSnowPea;
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000812EC File Offset: 0x0007F4EC
	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public DoubleSnowPeaShooter()
	{
	}
}
