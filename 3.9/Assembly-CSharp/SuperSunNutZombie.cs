using System;
using Cpp2IlInjected;

// Token: 0x02000722 RID: 1826
[Token(Token = "0x2000722")]
public class SuperSunNutZombie : SunNutZombie
{
	// Token: 0x0600240F RID: 9231 RVA: 0x000BC430 File Offset: 0x000BA630
	[Token(Token = "0x600240F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "76")]
	protected override void CheckMix()
	{
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000BC440 File Offset: 0x000BA640
	[Token(Token = "0x6002410")]
	[Address(RVA = "0x5F6770", Offset = "0x5F4D70", VA = "0x1805F6770", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		this.board.UseSun(5f);
		Board board = this.board;
		if (board.theSun < 0)
		{
			int num = 0;
			board.theSun = num;
			CreateItem instance = CreateItem.Instance;
			int column = base.Column;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000BC490 File Offset: 0x000BA690
	[Token(Token = "0x6002411")]
	[Address(RVA = "0x5F6730", Offset = "0x5F4D30", VA = "0x1805F6730", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
		base.TakeDamage(20, this, (DamageType)((uint)12), reportType, fix);
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x000BC4AC File Offset: 0x000BA6AC
	[Token(Token = "0x6002412")]
	[Address(RVA = "0x5883F0", Offset = "0x5869F0", VA = "0x1805883F0")]
	public SuperSunNutZombie()
	{
	}
}
