using System;
using Cpp2IlInjected;

// Token: 0x0200038B RID: 907
[Token(Token = "0x200038B")]
public class DoomNut : WallNut
{
	// Token: 0x060010A9 RID: 4265 RVA: 0x0005F034 File Offset: 0x0005D234
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x4818B0", Offset = "0x47FEB0", VA = "0x1804818B0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damageType != DamageType.DoomExplode)
		{
			return;
		}
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0005F048 File Offset: 0x0005D248
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x446670", Offset = "0x444C70", VA = "0x180446670", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		BoardAction boardAction = this.board.boardAction;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0005F07C File Offset: 0x0005D27C
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public DoomNut()
	{
	}
}
