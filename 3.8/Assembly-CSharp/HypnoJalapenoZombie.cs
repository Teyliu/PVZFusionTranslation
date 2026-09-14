using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067E RID: 1662
[Token(Token = "0x200067E")]
public class HypnoJalapenoZombie : JalapenoZombie
{
	// Token: 0x06001FE7 RID: 8167 RVA: 0x000A96C4 File Offset: 0x000A78C4
	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x54FE10", Offset = "0x54E410", VA = "0x18054FE10", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(13.22f, 22.68f);
		this.attributeCountDown = num;
		float num2 = global::UnityEngine.Random.Range(4.4f, 7.54f);
		this.attributeCountDown = num2;
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000A9708 File Offset: 0x000A7908
	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x54FC70", Offset = "0x54E270", VA = "0x18054FC70", Slot = "23")]
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

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000A979C File Offset: 0x000A799C
	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x54FE70", Offset = "0x54E470", VA = "0x18054FE70")]
	public HypnoJalapenoZombie()
	{
	}
}
