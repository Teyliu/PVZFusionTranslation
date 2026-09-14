using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000959 RID: 2393
[Token(Token = "0x2000959")]
public abstract class BaseSynergyData : BaseBuffData
{
	// Token: 0x0600317B RID: 12667 RVA: 0x00104B20 File Offset: 0x00102D20
	[Token(Token = "0x600317B")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "6")]
	public virtual SynergyType GetSynergyType()
	{
		return SynergyType.None;
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x00104B38 File Offset: 0x00102D38
	[Token(Token = "0x600317C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "7")]
	public virtual void OnBoardEnd(Board board)
	{
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x00104B48 File Offset: 0x00102D48
	[Token(Token = "0x600317D")]
	[Address(RVA = "0x6E38C0", Offset = "0x6E1EC0", VA = "0x1806E38C0", Slot = "8")]
	public virtual List<SynergyLevelData> GetAllData()
	{
		return new List();
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x00104B5C File Offset: 0x00102D5C
	[Token(Token = "0x600317E")]
	[Address(RVA = "0x6E3920", Offset = "0x6E1F20", VA = "0x1806E3920", Slot = "9")]
	public virtual SynergyLevelData GetData()
	{
		SynergyManager instance = SynergyManager.Instance;
		SynergyType synergyType = this.GetSynergyType();
		List<SynergyLevelData> allData = this.GetAllData();
		int size = allData._size;
		if (size > 0)
		{
			return allData[size];
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00104BA4 File Offset: 0x00102DA4
	[Token(Token = "0x600317F")]
	[Address(RVA = "0x6E3A00", Offset = "0x6E2000", VA = "0x1806E3A00", Slot = "10")]
	public virtual int GetMaxCount()
	{
		List<SynergyLevelData> allData = this.GetAllData();
		Func<SynergyLevelData, int> <>9__5_ = BaseSynergyData.<>c.<>9__5_0;
		if (<>9__5_ == 0)
		{
			Func<SynergyLevelData, int> func;
			BaseSynergyData.<>c.<>9__5_0 = func;
		}
		SynergyLevelData synergyLevelData = Enumerable.FirstOrDefault<SynergyLevelData>(Enumerable.OrderByDescending<SynergyLevelData, int>(allData, <>9__5_));
		int <ActiveCount>k__BackingField;
		if (synergyLevelData != 0)
		{
			<ActiveCount>k__BackingField = synergyLevelData.<ActiveCount>k__BackingField;
			return <ActiveCount>k__BackingField;
		}
		return <ActiveCount>k__BackingField;
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x00104BE8 File Offset: 0x00102DE8
	[Token(Token = "0x6003180")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	protected BaseSynergyData()
	{
		int num = 0;
		this.OnBoardEnd(num);
	}

	// Token: 0x04001C86 RID: 7302
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001C86")]
	public HashSet<PlantType> plantsContained;
}
