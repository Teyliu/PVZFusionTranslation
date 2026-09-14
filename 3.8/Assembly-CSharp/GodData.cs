using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020000BD RID: 189
[Token(Token = "0x20000BD")]
[Serializable]
public class GodData
{
	// Token: 0x06000362 RID: 866 RVA: 0x0000FC74 File Offset: 0x0000DE74
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x4B06C0", Offset = "0x4AECC0", VA = "0x1804B06C0")]
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

	// Token: 0x06000363 RID: 867 RVA: 0x0000FCD4 File Offset: 0x0000DED4
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x4B08E0", Offset = "0x4AEEE0", VA = "0x1804B08E0")]
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

	// Token: 0x06000364 RID: 868 RVA: 0x0000FD48 File Offset: 0x0000DF48
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x4B0AA0", Offset = "0x4AF0A0", VA = "0x1804B0AA0")]
	public GodData()
	{
		List<RouteChoice> list = new List();
		this.plantRouteChoices = list;
		List<PlantType> list2 = new List();
		this.unlockedPlants = list2;
		base..ctor();
	}

	// Token: 0x040001CA RID: 458
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001CA")]
	public List<RouteChoice> plantRouteChoices;

	// Token: 0x040001CB RID: 459
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001CB")]
	public List<PlantType> unlockedPlants;
}
