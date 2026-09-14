using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050C RID: 1292
[Token(Token = "0x200050C")]
public class DoomPeashooter : PeaShooter
{
	// Token: 0x06001843 RID: 6211 RVA: 0x00083E08 File Offset: 0x00082008
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x5217C0", Offset = "0x51FDC0", VA = "0x1805217C0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		ulong num2;
		do
		{
			Board board = this.board;
			int attributeCount = this.attributeCount;
			int num = attributeCount + 1;
			this.attributeCount = num;
			if (attributeCount + 1 > 60)
			{
				this.attributeCount = (int)((ulong)60L);
			}
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
			this.thePlantAttackInterval = 1.5f;
			bool flag;
			if (flag)
			{
				this.thePlantAttackInterval = flag;
				int attributeCount2 = this.attributeCount;
			}
		}
		while (num2 != (ulong)0L);
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attributeCount3 = this.attributeCount;
		Bullet bullet;
		bullet.Damage = attributeCount3;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x00083EC8 File Offset: 0x000820C8
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public DoomPeashooter()
	{
	}
}
