using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000512 RID: 1298
[Token(Token = "0x2000512")]
public class DoubleSnowPeaShooter : Shooter
{
	// Token: 0x0600185A RID: 6234 RVA: 0x000844B8 File Offset: 0x000826B8
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x000844D8 File Offset: 0x000826D8
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x522B80", Offset = "0x521180", VA = "0x180522B80", Slot = "70")]
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

	// Token: 0x0600185C RID: 6236 RVA: 0x00084534 File Offset: 0x00082734
	[Token(Token = "0x600185C")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public DoubleSnowPeaShooter()
	{
	}
}
