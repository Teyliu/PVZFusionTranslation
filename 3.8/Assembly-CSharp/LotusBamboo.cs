using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020003D5 RID: 981
[Token(Token = "0x20003D5")]
public class LotusBamboo : Bamboo
{
	// Token: 0x06001200 RID: 4608 RVA: 0x00065820 File Offset: 0x00063A20
	[Token(Token = "0x6001200")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00065840 File Offset: 0x00063A40
	[Token(Token = "0x6001201")]
	[Address(RVA = "0x44CC60", Offset = "0x44B260", VA = "0x18044CC60", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int num = this.NearCount;
		num++;
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00065874 File Offset: 0x00063A74
	[Token(Token = "0x6001202")]
	[Address(RVA = "0x44CD20", Offset = "0x44B320", VA = "0x18044CD20", Slot = "69")]
	protected override void CrashWithZombie(Zombie zombie, float x)
	{
		int nearCount = this.NearCount;
		float num = x * 0.3f;
		base.CrashWithZombie(zombie, num);
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06001203 RID: 4611 RVA: 0x00065898 File Offset: 0x00063A98
	[Token(Token = "0x170000EC")]
	private int NearCount
	{
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x44CD70", Offset = "0x44B370", VA = "0x18044CD70")]
		get
		{
			int thePlantColumn = this.thePlantColumn;
			int thePlantRow = this.thePlantRow;
			List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
			Func<Plant, bool> <>9__4_ = LotusBamboo.<>c.<>9__4_0;
			if (<>9__4_ == 0)
			{
				Func<Plant, bool> func;
				LotusBamboo.<>c.<>9__4_0 = func;
			}
			bool flag = Enumerable.FirstOrDefault<Plant>(list, <>9__4_);
			int num = this.thePlantColumn;
			int thePlantRow2 = this.thePlantRow;
			num++;
			List<Plant> list2 = Lawnf.Get1x1Plants(num, thePlantRow2);
			Func<Plant, bool> func2;
			if (LotusBamboo.<>c.<>9__4_1 == 0)
			{
				LotusBamboo.<>c.<>9__4_1 = func2;
			}
			bool flag2 = Enumerable.FirstOrDefault<Plant>(list2, func2);
			int thePlantRow3 = this.thePlantRow;
			bool flag3 = flag + true;
			int thePlantColumn2 = this.thePlantColumn;
			if (!flag2)
			{
				flag3 = flag;
			}
			List<Plant> list3 = Lawnf.Get1x1Plants(thePlantColumn2, thePlantRow3);
			Func<Plant, bool> func3;
			if (LotusBamboo.<>c.<>9__4_2 == 0)
			{
				LotusBamboo.<>c.<>9__4_2 = func3;
			}
			bool flag4 = Enumerable.FirstOrDefault<Plant>(list3, func3);
			int num2 = this.thePlantRow;
			bool flag5 = flag3 + true;
			int thePlantColumn3 = this.thePlantColumn;
			if (!flag4)
			{
			}
			num2++;
			List<Plant> list4 = Lawnf.Get1x1Plants(thePlantColumn3, num2);
			Func<Plant, bool> func4;
			if (LotusBamboo.<>c.<>9__4_3 == 0)
			{
				LotusBamboo.<>c.<>9__4_3 = func4;
			}
			bool flag6 = Enumerable.FirstOrDefault<Plant>(list4, func4);
			return 0;
		}
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x000659B8 File Offset: 0x00063BB8
	[Token(Token = "0x6001204")]
	[Address(RVA = "0x44CCE0", Offset = "0x44B2E0", VA = "0x18044CCE0", Slot = "21")]
	public override void Charge()
	{
		int num = 0;
		ulong num2;
		base.Recover(50f, (DamageType)num, true, num2 != 0UL);
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x000659D8 File Offset: 0x00063BD8
	[Token(Token = "0x6001205")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public LotusBamboo()
	{
	}
}
