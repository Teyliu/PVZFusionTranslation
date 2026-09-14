using System;
using Cpp2IlInjected;

// Token: 0x020003A5 RID: 933
[Token(Token = "0x20003A5")]
public class GarlicUmbrella : CornUmbrella
{
	// Token: 0x0600111F RID: 4383 RVA: 0x00061230 File Offset: 0x0005F430
	[Token(Token = "0x600111F")]
	[Address(RVA = "0x48A6B0", Offset = "0x488CB0", VA = "0x18048A6B0", Slot = "70")]
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

	// Token: 0x06001120 RID: 4384 RVA: 0x0006127C File Offset: 0x0005F47C
	[Token(Token = "0x6001120")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public GarlicUmbrella()
	{
	}
}
