using System;
using Cpp2IlInjected;

// Token: 0x02000392 RID: 914
[Token(Token = "0x2000392")]
public class GarlicUmbrella : CornUmbrella
{
	// Token: 0x060010C5 RID: 4293 RVA: 0x0005FCE4 File Offset: 0x0005DEE4
	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x436DD0", Offset = "0x4353D0", VA = "0x180436DD0", Slot = "70")]
	protected override void BlockEffect(Zombie zombie)
	{
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(40, this, (DamageType)((uint)4), thePlantType, num != 0UL);
		int num2 = 0;
		int num3 = 0;
		zombie.Garliced(num3 != 0, num2 != 0);
		Plant umbrellaPot = base.UmbrellaPot;
		int num4 = 0;
		if (!(umbrellaPot == num4))
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0005FD30 File Offset: 0x0005DF30
	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public GarlicUmbrella()
	{
	}
}
