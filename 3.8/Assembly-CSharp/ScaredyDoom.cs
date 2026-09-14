using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054F RID: 1359
[Token(Token = "0x200054F")]
public class ScaredyDoom : ScaredyShroom
{
	// Token: 0x0600193C RID: 6460 RVA: 0x00088540 File Offset: 0x00086740
	[Token(Token = "0x600193C")]
	[Address(RVA = "0x4DDD20", Offset = "0x4DC320", VA = "0x1804DDD20", Slot = "69")]
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

	// Token: 0x0600193D RID: 6461 RVA: 0x000885F8 File Offset: 0x000867F8
	[Token(Token = "0x600193D")]
	[Address(RVA = "0x4DDC40", Offset = "0x4DC240", VA = "0x1804DDC40", Slot = "74")]
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

	// Token: 0x0600193E RID: 6462 RVA: 0x0008864C File Offset: 0x0008684C
	[Token(Token = "0x600193E")]
	[Address(RVA = "0x4DDBB0", Offset = "0x4DC1B0", VA = "0x1804DDBB0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (Lawnf.EveBalaced())
		{
			BoardAction boardAction = this.board.boardAction;
			PlantType thePlantType = this.thePlantType;
		}
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x00088684 File Offset: 0x00086884
	[Token(Token = "0x600193F")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ScaredyDoom()
	{
	}
}
