using System;
using Cpp2IlInjected;

// Token: 0x02000703 RID: 1795
[Token(Token = "0x2000703")]
public class UltimateMachineNutZombie : SuperMachineNutZombie
{
	// Token: 0x060023DD RID: 9181 RVA: 0x000BB420 File Offset: 0x000B9620
	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x58ADD0", Offset = "0x5893D0", VA = "0x18058ADD0", Slot = "15")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x000BB44C File Offset: 0x000B964C
	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060023DF RID: 9183 RVA: 0x000BB45C File Offset: 0x000B965C
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x58AD90", Offset = "0x589390", VA = "0x18058AD90", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		int num;
		long num2;
		if ((long)num > num2)
		{
		}
		return num;
	}

	// Token: 0x060023E0 RID: 9184 RVA: 0x000BB470 File Offset: 0x000B9670
	[Token(Token = "0x60023E0")]
	[Address(RVA = "0x57CD30", Offset = "0x57B330", VA = "0x18057CD30", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060023E1 RID: 9185 RVA: 0x000BB480 File Offset: 0x000B9680
	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "30")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x060023E2 RID: 9186 RVA: 0x000BB490 File Offset: 0x000B9690
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x58AE20", Offset = "0x589420", VA = "0x18058AE20")]
	public UltimateMachineNutZombie()
	{
	}
}
