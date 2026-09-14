using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200067A RID: 1658
[Token(Token = "0x200067A")]
public class DancePolevaulterZombie : PolevaulterZombie
{
	// Token: 0x06001F75 RID: 8053 RVA: 0x000A7398 File Offset: 0x000A5598
	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x59C5B0", Offset = "0x59ABB0", VA = "0x18059C5B0", Slot = "77")]
	public override void JumpOver()
	{
		base.JumpOver();
		Transform axis = this.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.axis;
			Transform axis3 = this.axis;
			if (!Lawnf.EveBalaced())
			{
				Board board = this.board;
				int column = base.Column;
				int theZombieRow = this.theZombieRow;
				if (board.GetBoxType(column, theZombieRow) != BoxType.Water)
				{
					Transform axis4 = this.axis;
					int theZombieRow2 = this.theZombieRow;
				}
				int rowNum = this.board.rowNum;
				Board board2 = this.board;
				int column2 = base.Column;
				int num2 = this.theZombieRow;
				num2++;
				if (board2.GetBoxType(column2, num2) != BoxType.Water)
				{
					Transform axis5 = this.axis;
					int theZombieRow3 = this.theZombieRow;
				}
			}
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000A7468 File Offset: 0x000A5668
	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x59C7D0", Offset = "0x59ADD0", VA = "0x18059C7D0")]
	private void SetZombie(int row, ZombieType zombieType, float x)
	{
		Board board = this.board;
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		Zombie component = zombie.GetComponent<Zombie>();
		this.board.SetHealthInTravel(component);
		if (component.takeDmgMultiplier == 0f)
		{
		}
		CreateZombie instance2 = CreateZombie.Instance;
		Zombie zombie2;
		Zombie component2 = zombie2.GetComponent<Zombie>();
		ParticleManager instance3 = ParticleManager.Instance;
		Transform axis2 = component2.axis;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance3.SetParticle((ParticleType)((uint)11), num, row, num3 != 0UL, (float)num2);
		Corner targetCorner = this.targetCorner;
		component2.targetCorner = targetCorner;
		throw new NullReferenceException();
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000A7500 File Offset: 0x000A5700
	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x59CA20", Offset = "0x59B020", VA = "0x18059CA20")]
	public DancePolevaulterZombie()
	{
	}
}
