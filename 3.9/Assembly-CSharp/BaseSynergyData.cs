using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

// Token: 0x02000995 RID: 2453
[Token(Token = "0x2000995")]
public abstract class BaseSynergyData : BaseBuffData
{
	// Token: 0x060032AE RID: 12974 RVA: 0x001098A0 File Offset: 0x00107AA0
	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "6")]
	public virtual SynergyType GetSynergyType()
	{
		return SynergyType.None;
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x001098B8 File Offset: 0x00107AB8
	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "7")]
	public virtual void OnBoardEnd(Board board)
	{
	}

	// Token: 0x060032B0 RID: 12976 RVA: 0x001098C8 File Offset: 0x00107AC8
	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x748BD0", Offset = "0x7471D0", VA = "0x180748BD0", Slot = "8")]
	public virtual List<SynergyLevelData> GetAllData()
	{
		return new List();
	}

	// Token: 0x060032B1 RID: 12977 RVA: 0x001098DC File Offset: 0x00107ADC
	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x748C30", Offset = "0x747230", VA = "0x180748C30", Slot = "9")]
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

	// Token: 0x060032B2 RID: 12978 RVA: 0x00109924 File Offset: 0x00107B24
	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x748D10", Offset = "0x747310", VA = "0x180748D10", Slot = "10")]
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

	// Token: 0x060032B3 RID: 12979 RVA: 0x00109968 File Offset: 0x00107B68
	[Token(Token = "0x60032B3")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	protected BaseSynergyData()
	{
		int num = 0;
		this.OnBoardEnd(num);
	}

	// Token: 0x04001D76 RID: 7542
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001D76")]
	public HashSet<PlantType> plantsContained;
}
