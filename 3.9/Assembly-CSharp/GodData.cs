using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000C2 RID: 194
[Token(Token = "0x20000C2")]
[Serializable]
public class GodData
{
	// Token: 0x0600037D RID: 893 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x4EFD50", Offset = "0x4EE350", VA = "0x1804EFD50")]
	public int GetRouteChoice(PlantType plant)
	{
		int num2;
		for (;;)
		{
			GodManager instance = GodManager.Instance;
			int num = 0;
			if (instance != num && GodManager.Instance.custom)
			{
				return 0;
			}
			PlantType plantType;
			num2 = (int)plantType;
			List<RouteChoice> list = this.plantRouteChoices;
			bool flag;
			if (flag)
			{
				break;
			}
			ulong num3;
			if (num3 == (ulong)0L)
			{
				return 0;
			}
		}
		return num2;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00010044 File Offset: 0x0000E244
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x4EFF70", Offset = "0x4EE570", VA = "0x1804EFF70")]
	public void SetRouteChoice(PlantType plant, int routeIndex)
	{
		List<RouteChoice> list = this.plantRouteChoices;
		int num = 0;
		PlantType plantType;
		int num2 = (int)plantType;
		List<RouteChoice> list2 = this.plantRouteChoices;
		RouteChoice routeChoice = list2[num];
		List<RouteChoice> list3 = this.plantRouteChoices;
		if (routeChoice.basePlant != (PlantType)num2)
		{
			num++;
		}
		list3[num].routeIndex = routeIndex;
	}

	// Token: 0x0600037F RID: 895 RVA: 0x000100B8 File Offset: 0x0000E2B8
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x4F0130", Offset = "0x4EE730", VA = "0x1804F0130")]
	public GodData()
	{
		List<RouteChoice> list = new List();
		this.plantRouteChoices = list;
		List<PlantType> list2 = new List();
		this.unlockedPlants = list2;
		base..ctor();
	}

	// Token: 0x040001D7 RID: 471
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D7")]
	public List<RouteChoice> plantRouteChoices;

	// Token: 0x040001D8 RID: 472
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001D8")]
	public List<PlantType> unlockedPlants;
}
