using System;
using Cpp2IlInjected;

// Token: 0x020006EA RID: 1770
[Token(Token = "0x20006EA")]
public class SuperSunNutZombie : SunNutZombie
{
	// Token: 0x060022F3 RID: 8947 RVA: 0x000B75E8 File Offset: 0x000B57E8
	[Token(Token = "0x60022F3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "74")]
	protected override void CheckMix()
	{
	}

	// Token: 0x060022F4 RID: 8948 RVA: 0x000B75F8 File Offset: 0x000B57F8
	[Token(Token = "0x60022F4")]
	[Address(RVA = "0x57C190", Offset = "0x57A790", VA = "0x18057C190", Slot = "32")]
	public override int GetDamage(int theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		this.board.UseSun(5f);
		Board board = this.board;
		if (board.theSun < 0)
		{
			int num = 0;
			board.theSun = num;
			return 20;
		}
		return 20;
	}

	// Token: 0x060022F5 RID: 8949 RVA: 0x000B764C File Offset: 0x000B584C
	[Token(Token = "0x60022F5")]
	[Address(RVA = "0x57C150", Offset = "0x57A750", VA = "0x18057C150", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		base.TakeDamage(20, this, (DamageType)((uint)12), reportType, fix);
	}

	// Token: 0x060022F6 RID: 8950 RVA: 0x000B7668 File Offset: 0x000B5868
	[Token(Token = "0x60022F6")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public SuperSunNutZombie()
	{
	}
}
