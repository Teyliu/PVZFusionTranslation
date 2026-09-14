using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020003EB RID: 1003
[Token(Token = "0x20003EB")]
public class LotusBamboo : Bamboo
{
	// Token: 0x06001263 RID: 4707 RVA: 0x0006709C File Offset: 0x0006529C
	[Token(Token = "0x6001263")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x000670BC File Offset: 0x000652BC
	[Token(Token = "0x6001264")]
	[Address(RVA = "0x4A1420", Offset = "0x49FA20", VA = "0x1804A1420", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int num = this.NearCount;
		num++;
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x000670F0 File Offset: 0x000652F0
	[Token(Token = "0x6001265")]
	[Address(RVA = "0x4A14E0", Offset = "0x49FAE0", VA = "0x1804A14E0", Slot = "68")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		int nearCount = this.NearCount;
		float num = x * 0.3f;
		base.CrashWithZombie(zombie, num);
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06001266 RID: 4710 RVA: 0x00067114 File Offset: 0x00065314
	[Token(Token = "0x1700012F")]
	private int NearCount
	{
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x4A1530", Offset = "0x49FB30", VA = "0x1804A1530")]
		get
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__4_ = LotusBamboo.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				LotusBamboo.<>c.<>9__4_0 = delegate(Plant p)
				{
					int num3 = 0;
					if (p != 0)
					{
					}
					return num3 != 0;
				};
			}
			bool flag = Enumerable.FirstOrDefault<Plant>(list, <>9__4_);
			int num = this.thePlantColumn;
			int thePlantRow2 = this.thePlantRow;
			num++;
			List<Plant> list2 = Lawnf.Get1x1Plants(num, thePlantRow2);
			Func<Plant, bool> func;
			if (LotusBamboo.<>c.<>9__4_1 == 0)
			{
				func = delegate(Plant p)
				{
					int num4 = 0;
					if (p != 0)
					{
					}
					return num4 != 0;
				};
				LotusBamboo.<>c.<>9__4_1 = func;
			}
			bool flag2 = Enumerable.FirstOrDefault<Plant>(list2, func);
			int thePlantRow3 = this.thePlantRow;
			bool flag3 = flag + true;
			int thePlantColumn2 = this.thePlantColumn;
			if (!flag2)
			{
				flag3 = flag;
			}
			List<Plant> list3 = Lawnf.Get1x1Plants(thePlantColumn2, thePlantRow3);
			Func<Plant, bool> func2;
			if (LotusBamboo.<>c.<>9__4_2 == 0)
			{
				func2 = delegate(Plant p)
				{
					int num5 = 0;
					if (p != 0)
					{
					}
					return num5 != 0;
				};
				LotusBamboo.<>c.<>9__4_2 = func2;
			}
			bool flag4 = Enumerable.FirstOrDefault<Plant>(list3, func2);
			int num2 = this.thePlantRow;
			bool flag5 = flag3 + true;
			int thePlantColumn3 = this.thePlantColumn;
			if (!flag4)
			{
			}
			num2++;
			List<Plant> list4 = Lawnf.Get1x1Plants(thePlantColumn3, num2);
			Func<Plant, bool> func3;
			if (LotusBamboo.<>c.<>9__4_3 == 0)
			{
				func3 = delegate(Plant p)
				{
					int num6 = 0;
					if (p != 0)
					{
					}
					return num6 != 0;
				};
				LotusBamboo.<>c.<>9__4_3 = func3;
			}
			bool flag6 = Enumerable.FirstOrDefault<Plant>(list4, func3);
			return 0;
		}
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x00067278 File Offset: 0x00065478
	[Token(Token = "0x6001267")]
	[Address(RVA = "0x4A14A0", Offset = "0x49FAA0", VA = "0x1804A14A0", Slot = "21")]
	public override void Charge()
	{
		int num = 0;
		ulong num2;
		base.Recover(50f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x00067298 File Offset: 0x00065498
	[Token(Token = "0x6001268")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public LotusBamboo()
	{
	}
}
