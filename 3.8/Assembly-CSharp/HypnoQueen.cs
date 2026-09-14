using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A6 RID: 934
[Token(Token = "0x20003A6")]
public class HypnoQueen : HypnoEmperor
{
	// Token: 0x0600112A RID: 4394 RVA: 0x00061CAC File Offset: 0x0005FEAC
	[Token(Token = "0x600112A")]
	[Address(RVA = "0x43D5E0", Offset = "0x43BBE0", VA = "0x18043D5E0", Slot = "69")]
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

	// Token: 0x0600112B RID: 4395 RVA: 0x00061D94 File Offset: 0x0005FF94
	[Token(Token = "0x600112B")]
	[Address(RVA = "0x43D420", Offset = "0x43BA20", VA = "0x18043D420", Slot = "52")]
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

	// Token: 0x0600112C RID: 4396 RVA: 0x00061DE4 File Offset: 0x0005FFE4
	[Token(Token = "0x600112C")]
	[Address(RVA = "0x43D340", Offset = "0x43B940", VA = "0x18043D340", Slot = "40")]
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

	// Token: 0x0600112D RID: 4397 RVA: 0x00061E58 File Offset: 0x00060058
	[Token(Token = "0x600112D")]
	[Address(RVA = "0x43B870", Offset = "0x439E70", VA = "0x18043B870")]
	public HypnoQueen()
	{
		this.restHealth = (int)((ulong)5L);
		base..ctor();
	}
}
