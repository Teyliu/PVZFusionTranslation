using System;
using Cpp2IlInjected;

// Token: 0x0200073B RID: 1851
[Token(Token = "0x200073B")]
public class UltimateMachineNutZombie : SuperMachineNutZombie
{
	// Token: 0x060024F8 RID: 9464 RVA: 0x000C0024 File Offset: 0x000BE224
	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x603BB0", Offset = "0x6021B0", VA = "0x180603BB0", Slot = "16")]
	protected override void Start()
	{
		int num = 0;
		base.Start();
		if (TravelMgr.Instance.data.invest_challenge)
		{
			float num2;
			this.theOriginSpeed = num2;
		}
		Board board = this.board;
		Lawnf.SetZombieHealth(this, (float)num);
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x000C006C File Offset: 0x000BE26C
	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x000C007C File Offset: 0x000BE27C
	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x603B60", Offset = "0x602160", VA = "0x180603B60", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		long num2;
		if (num > num2)
		{
		}
		return num;
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000C0094 File Offset: 0x000BE294
	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x5F7310", Offset = "0x5F5910", VA = "0x1805F7310", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000C00A4 File Offset: 0x000BE2A4
	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "31")]
	protected override bool Instead(int damage)
	{
		return false;
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000C00B4 File Offset: 0x000BE2B4
	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x5F5B70", Offset = "0x5F4170", VA = "0x1805F5B70")]
	public UltimateMachineNutZombie()
	{
	}
}
