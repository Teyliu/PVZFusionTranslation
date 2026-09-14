using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E4 RID: 1252
[Token(Token = "0x20004E4")]
public class DoomPeashooter : PeaShooter
{
	// Token: 0x0600178C RID: 6028 RVA: 0x00080BC0 File Offset: 0x0007EDC0
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x4A1C90", Offset = "0x4A0290", VA = "0x1804A1C90", Slot = "69")]
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

	// Token: 0x0600178D RID: 6029 RVA: 0x00080C80 File Offset: 0x0007EE80
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public DoomPeashooter()
	{
	}
}
