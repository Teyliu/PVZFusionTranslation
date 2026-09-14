using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BA RID: 954
[Token(Token = "0x20003BA")]
public class HypnoQueen : HypnoEmperor
{
	// Token: 0x06001186 RID: 4486 RVA: 0x00063308 File Offset: 0x00061508
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x490E40", Offset = "0x48F440", VA = "0x180490E40", Slot = "68")]
	protected override void Summon()
	{
		if (!Lawnf.EveBalaced())
		{
			if (!Lawnf.TravelAdvanced((AdvBuff)((uint)1)))
			{
				Board board = this.board;
				int thePlantRow = this.thePlantRow;
				int thePlantColumn = this.thePlantColumn;
				if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
				{
					Transform axis = this.axis;
					CreateZombie instance = CreateZombie.Instance;
				}
				Transform axis2 = this.axis;
				CreateZombie instance2 = CreateZombie.Instance;
			}
			Board board2 = this.board;
			int thePlantRow2 = this.thePlantRow;
			int thePlantColumn2 = this.thePlantColumn;
			if (board2.GetBoxType(thePlantColumn2, thePlantRow2) != BoxType.Water)
			{
				Transform axis3 = this.axis;
				CreateZombie instance3 = CreateZombie.Instance;
			}
			Transform axis4 = this.axis;
			CreateZombie instance4 = CreateZombie.Instance;
			int num = 0;
			Zombie zombie;
			if (zombie == num || zombie.theZombieType == ZombieType.CherryPaperZ95 || zombie.theZombieType == ZombieType.CherryPaperZombie)
			{
			}
			return;
		}
		Transform axis5 = this.axis;
		CreateZombie instance5 = CreateZombie.Instance;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000633F0 File Offset: 0x000615F0
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x490C80", Offset = "0x48F280", VA = "0x180490C80", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num;
		do
		{
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get3x3Plants(this.thePlantColumn, thePlantRow);
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(83, 0.5f, 1f);
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00063440 File Offset: 0x00061640
	[Token(Token = "0x6001188")]
	[Address(RVA = "0x490BA0", Offset = "0x48F1A0", VA = "0x180490BA0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.attributeCountdown = 30f;
		if (!Lawnf.TravelAdvanced(AdvBuff.撒豆成兵))
		{
			Board board = this.board;
		}
		this.attributeCountdown = 10f;
		this.anim.SetTrigger("summon");
		GameAPP.PlaySound(83, 0.5f, 1f);
		Board board2 = this.board;
		this.attributeCountdown = 2.5f;
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x000634B4 File Offset: 0x000616B4
	[Token(Token = "0x6001189")]
	[Address(RVA = "0x48F0C0", Offset = "0x48D6C0", VA = "0x18048F0C0")]
	public HypnoQueen()
	{
		this.restHealth = (int)((ulong)5L);
		base..ctor();
	}
}
