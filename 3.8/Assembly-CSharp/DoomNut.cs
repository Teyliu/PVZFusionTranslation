using System;
using Cpp2IlInjected;

// Token: 0x0200037B RID: 891
[Token(Token = "0x200037B")]
public class DoomNut : WallNut
{
	// Token: 0x0600105D RID: 4189 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x430F20", Offset = "0x42F520", VA = "0x180430F20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.DoomExplode)
		{
			return;
		}
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x0005DFF4 File Offset: 0x0005C1F4
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x430EA0", Offset = "0x42F4A0", VA = "0x180430EA0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x0005E028 File Offset: 0x0005C228
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public DoomNut()
	{
	}
}
