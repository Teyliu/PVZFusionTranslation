using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000644 RID: 1604
[Token(Token = "0x2000644")]
public class DancePolevaulterZombie : PolevaulterZombie
{
	// Token: 0x06001E73 RID: 7795 RVA: 0x000A2C4C File Offset: 0x000A0E4C
	[Token(Token = "0x6001E73")]
	[Address(RVA = "0x539FD0", Offset = "0x5385D0", VA = "0x180539FD0", Slot = "75")]
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

	// Token: 0x06001E74 RID: 7796 RVA: 0x000A2D1C File Offset: 0x000A0F1C
	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x53A1F0", Offset = "0x5387F0", VA = "0x18053A1F0")]
	private void SetZombie(int row, ZombieType zombieType, float x)
	{
		Board board = this.board;
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		Zombie zombie;
		Zombie component = zombie.GetComponent<Zombie>();
		this.board.SetHealthInTravel(component);
		if (component.read == 0)
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

	// Token: 0x06001E75 RID: 7797 RVA: 0x000A2DB0 File Offset: 0x000A0FB0
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x53A440", Offset = "0x538A40", VA = "0x18053A440")]
	public DancePolevaulterZombie()
	{
	}
}
