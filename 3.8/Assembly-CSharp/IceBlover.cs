using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AB RID: 939
[Token(Token = "0x20003AB")]
public class IceBlover : DoomBlover
{
	// Token: 0x0600113A RID: 4410 RVA: 0x000620F0 File Offset: 0x000602F0
	[Token(Token = "0x600113A")]
	[Address(RVA = "0x43E2F0", Offset = "0x43C8F0", VA = "0x18043E2F0", Slot = "71")]
	protected override void KeepEffect()
	{
		float timer = this.timer;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.timer = timer;
		if (num > (int)timer)
		{
			float attackCount = this.attackCount;
			this.attackCount = attackCount;
			this.BlowEffect();
			float attackCount2 = this.attackCount;
			this.timer = 1f;
			int num2 = 0;
			base.Die((Plant.DieReason)num2);
		}
		int size = this.board.boardEntity.bulletArray._size;
		int num3 = size - 1;
		if (size > 0)
		{
			Bullet bullet = this.board.boardEntity.bulletArray[num3];
			int num4 = 0;
			if (bullet != num4 && bullet.theBulletType == BulletType.Bullet_snowPea)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (bullet.<Team>k__BackingField == <Team>k__BackingField)
				{
					BoardAction boardAction = this.board.boardAction;
				}
			}
		}
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x000621CC File Offset: 0x000603CC
	[Token(Token = "0x600113B")]
	[Address(RVA = "0x43E150", Offset = "0x43C750", VA = "0x18043E150", Slot = "72")]
	protected override void BlowEffect()
	{
		ulong num;
		do
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				while (flag <= true)
				{
				}
				PlantType thePlantType = this.thePlantType;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00062208 File Offset: 0x00060408
	[Token(Token = "0x600113C")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public IceBlover()
	{
		this.timer = 1f;
		base..ctor();
	}
}
