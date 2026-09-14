using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020003F4 RID: 1012
[Token(Token = "0x20003F4")]
public class ObsidianWallNut : WallNut
{
	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00069128 File Offset: 0x00067328
	[Token(Token = "0x170000F3")]
	public override int LimDamage
	{
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x3ACD90", Offset = "0x3AB390", VA = "0x1803ACD90", Slot = "66")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x0006913C File Offset: 0x0006733C
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x459090", Offset = "0x457690", VA = "0x180459090", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0006915C File Offset: 0x0006735C
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x4591D0", Offset = "0x4577D0", VA = "0x1804591D0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00069184 File Offset: 0x00067384
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x459220", Offset = "0x457820", VA = "0x180459220", Slot = "32")]
	protected override int GetDamage(int damage)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__4_ = ObsidianWallNut.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			Func<Plant, bool> func;
			ObsidianWallNut.<>c.<>9__4_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(list, <>9__4_);
		bool flag = plant;
		return base.GetDamage(damage);
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x000691D4 File Offset: 0x000673D4
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x459460", Offset = "0x457A60", VA = "0x180459460", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)7)))
		{
		}
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x000691EC File Offset: 0x000673EC
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x4593B0", Offset = "0x4579B0", VA = "0x1804593B0", Slot = "64")]
	public override bool OnEat(Zombie zombie)
	{
		int num = 0;
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)6)))
		{
		}
		Board board = this.board;
		PlantType thePlantType = this.thePlantType;
		ulong num2;
		zombie.TakeDamage(num, this, (DamageType)((uint)4), thePlantType, num2 != 0UL);
		throw new NullReferenceException();
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x0006922C File Offset: 0x0006742C
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public ObsidianWallNut()
	{
	}
}
