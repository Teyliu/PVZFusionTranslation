using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057E RID: 1406
[Token(Token = "0x200057E")]
public class ScaredyDoom : ScaredyShroom
{
	// Token: 0x06001A18 RID: 6680 RVA: 0x0008C4AC File Offset: 0x0008A6AC
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x53BE20", Offset = "0x53A420", VA = "0x18053BE20", Slot = "68")]
	protected override Bullet Shoot1()
	{
		ulong num2;
		do
		{
			float thePlantAttackInterval = this.thePlantAttackInterval;
			if (thePlantAttackInterval <= 0.2f)
			{
				this.thePlantAttackInterval = 0.2f;
			}
			this.thePlantAttackInterval = thePlantAttackInterval;
			Board board = this.board;
			base.AdjustDamage();
			int num = this.thePlantColumn;
			num++;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(num, thePlantRow);
			bool flag;
			if (flag)
			{
				this.attackDamage = (flag ? 1 : 0);
			}
		}
		while (num2 != (ulong)0L);
		Transform transform2;
		Transform transform = transform2.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		bullet.fromType = instance;
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x0008C564 File Offset: 0x0008A764
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x53BD40", Offset = "0x53A340", VA = "0x18053BD40", Slot = "73")]
	protected override void ScaredEvent()
	{
		if (!Lawnf.EveBalaced())
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
			int num = 0;
			base.Die((Plant.DieReason)num);
		}
		Board board = this.board;
		this.thePlantAttackInterval = 1.5f;
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x0008C5B8 File Offset: 0x0008A7B8
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x53BCB0", Offset = "0x53A2B0", VA = "0x18053BCB0", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (Lawnf.EveBalaced())
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x0008C5F0 File Offset: 0x0008A7F0
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ScaredyDoom()
	{
	}
}
