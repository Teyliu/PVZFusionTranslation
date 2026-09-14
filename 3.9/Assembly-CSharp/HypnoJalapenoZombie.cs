using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B4 RID: 1716
[Token(Token = "0x20006B4")]
public class HypnoJalapenoZombie : JalapenoZombie
{
	// Token: 0x060020E9 RID: 8425 RVA: 0x000ADFD4 File Offset: 0x000AC1D4
	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x5B39A0", Offset = "0x5B1FA0", VA = "0x1805B39A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
		float num2 = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num2;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000AE018 File Offset: 0x000AC218
	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x5B3800", Offset = "0x5B1E00", VA = "0x1805B3800", Slot = "24")]
	protected override void AttributeEvent()
	{
		base.Die(2);
		BoardAction boardAction = this.board.boardAction;
		int num = this.theZombieRow;
		boardAction.CreateFireLineVision(num);
		int size = this.board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			List<Zombie> zombieArray = this.board.zombieArray;
			num = num2;
			Zombie zombie = zombieArray[num];
			int num3 = 0;
			if (zombie != num3 && zombie.isMindControlled)
			{
				int theZombieRow = this.theZombieRow;
				if (zombie.theZombieRow == theZombieRow)
				{
				}
			}
		}
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000AE0AC File Offset: 0x000AC2AC
	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x5B3A00", Offset = "0x5B2000", VA = "0x1805B3A00")]
	public HypnoJalapenoZombie()
	{
	}
}
