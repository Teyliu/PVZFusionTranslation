using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020003A9 RID: 937
[Token(Token = "0x20003A9")]
public class IceBean : Plant
{
	// Token: 0x06001134 RID: 4404 RVA: 0x00061FFC File Offset: 0x000601FC
	[Token(Token = "0x6001134")]
	[Address(RVA = "0x43E130", Offset = "0x43C730", VA = "0x18043E130", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 1f;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x0006201C File Offset: 0x0006021C
	[Token(Token = "0x6001135")]
	[Address(RVA = "0x43DED0", Offset = "0x43C4D0", VA = "0x18043DED0", Slot = "40")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		this.attributeCountdown = 1f;
		List<Plant> list = Lawnf.Get1x1Plants(thePlantColumn, thePlantRow);
		Func<Plant, bool> <>9__1_ = IceBean.<>c.<>9__1_0;
		if (<>9__1_ == 0)
		{
			Func<Plant, bool> func;
			IceBean.<>c.<>9__1_0 = func;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__1_));
		int num = 0;
		if (plant != num)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00062090 File Offset: 0x00060290
	[Token(Token = "0x6001136")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public IceBean()
	{
	}
}
