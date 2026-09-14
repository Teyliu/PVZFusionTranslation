using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x020003BD RID: 957
[Token(Token = "0x20003BD")]
public class IceBean : Plant
{
	// Token: 0x06001190 RID: 4496 RVA: 0x00063658 File Offset: 0x00061858
	[Token(Token = "0x6001190")]
	[Address(RVA = "0x492040", Offset = "0x490640", VA = "0x180492040", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountdown = 1f;
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00063678 File Offset: 0x00061878
	[Token(Token = "0x6001191")]
	[Address(RVA = "0x491DE0", Offset = "0x4903E0", VA = "0x180491DE0", Slot = "39")]
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
			IceBean.<>c.<>9__1_0 = (Plant a) => a.thePlantType == PlantType.SnowPeaShooter;
		}
		Plant plant = Enumerable.FirstOrDefault<Plant>(Enumerable.Where<Plant>(list, <>9__1_));
		int num = 0;
		if (plant != num)
		{
			CreatePlant instance = CreatePlant.Instance;
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x000636FC File Offset: 0x000618FC
	[Token(Token = "0x6001192")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public IceBean()
	{
	}
}
