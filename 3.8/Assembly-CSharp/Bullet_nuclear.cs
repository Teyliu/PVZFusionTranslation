using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000177 RID: 375
[Token(Token = "0x2000177")]
public class Bullet_nuclear : Bullet_pierce
{
	// Token: 0x060006A7 RID: 1703 RVA: 0x00022E70 File Offset: 0x00021070
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00022E88 File Offset: 0x00021088
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x7D94D0", Offset = "0x7D7AD0", VA = "0x1807D94D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		BoardAction boardAction = this.board.boardAction;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		PlantType fromType = this.fromType;
		int num = 0;
		int damage = this._damage;
		BoardAction boardAction2 = this.board.boardAction;
		int column = zombie.Column;
		PlantType fromType2 = this.fromType;
		int damage2 = this._damage;
		if ((GameAPP.config.distablexplodeFlash ? 1 : 0) == num)
		{
			Transform axis = zombie.axis;
			Board board = this.board;
		}
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00022F14 File Offset: 0x00021114
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x7D9400", Offset = "0x7D7A00", VA = "0x1807D9400", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(70, 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00022F50 File Offset: 0x00021150
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_nuclear()
	{
	}
}
