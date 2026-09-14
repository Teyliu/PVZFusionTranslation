using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x0200040E RID: 1038
[Token(Token = "0x200040E")]
public class ObsidianWallNut : WallNut
{
	// Token: 0x17000137 RID: 311
	// (get) Token: 0x0600131C RID: 4892 RVA: 0x0006AEAC File Offset: 0x000690AC
	[Token(Token = "0x17000137")]
	public override int LimDamage
	{
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x3F8C00", Offset = "0x3F7200", VA = "0x1803F8C00", Slot = "65")]
		get
		{
			return 1000;
		}
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x0006AEC0 File Offset: 0x000690C0
	[Token(Token = "0x600131D")]
	[Address(RVA = "0x4AD470", Offset = "0x4ABA70", VA = "0x1804AD470", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 15f;
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0006AEE0 File Offset: 0x000690E0
	[Token(Token = "0x600131E")]
	[Address(RVA = "0x4AD5B0", Offset = "0x4ABBB0", VA = "0x1804AD5B0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.AttributeCountdown = 15f;
		int num = 0;
		ulong num2;
		base.Recover(1500f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x0006AF08 File Offset: 0x00069108
	[Token(Token = "0x600131F")]
	[Address(RVA = "0x4AD600", Offset = "0x4ABC00", VA = "0x1804AD600", Slot = "31")]
	protected override int GetDamage(int damage)
	{
		int thePlantRow = this.thePlantRow;
		List<Plant> list = Lawnf.Get1x1Plants(this.thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__4_ = ObsidianWallNut.<>c.<>9__4_0;
		if (<>9__4_ == 0)
		{
			ObsidianWallNut.<>c.<>9__4_0 = (Plant p) => p.thePlantType == PlantType.CaltropPot;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(list, <>9__4_);
		bool flag = plant;
		return base.GetDamage(damage);
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0006AF64 File Offset: 0x00069164
	[Token(Token = "0x6001320")]
	[Address(RVA = "0x4AD840", Offset = "0x4ABE40", VA = "0x1804AD840", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (Lawnf.TravelAdvanced((AdvBuff)((uint)7)))
		{
		}
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x0006AF7C File Offset: 0x0006917C
	[Token(Token = "0x6001321")]
	[Address(RVA = "0x4AD790", Offset = "0x4ABD90", VA = "0x1804AD790", Slot = "63")]
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

	// Token: 0x06001322 RID: 4898 RVA: 0x0006AFBC File Offset: 0x000691BC
	[Token(Token = "0x6001322")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public ObsidianWallNut()
	{
	}
}
