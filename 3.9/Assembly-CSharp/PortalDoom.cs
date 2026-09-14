using System;
using Cpp2IlInjected;

// Token: 0x02000328 RID: 808
[Token(Token = "0x2000328")]
public class PortalDoom : DoomShroom
{
	// Token: 0x06000EA6 RID: 3750 RVA: 0x000538B8 File Offset: 0x00051AB8
	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x467460", Offset = "0x465A60", VA = "0x180467460", Slot = "68")]
	public override void AnimExplode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		BoardAction boardAction = this.board.boardAction;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x000538F4 File Offset: 0x00051AF4
	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x4673C0", Offset = "0x4659C0", VA = "0x1804673C0")]
	private void ActionOnZombie(Zombie zombie)
	{
		bool flag;
		if (!flag)
		{
			zombie.SetPortaled(4f);
			return;
		}
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00053918 File Offset: 0x00051B18
	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public PortalDoom()
	{
	}
}
