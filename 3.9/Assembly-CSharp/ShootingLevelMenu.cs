using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200083B RID: 2107
[Token(Token = "0x200083B")]
public class ShootingLevelMenu : BaseMenu
{
	// Token: 0x06002B02 RID: 11010 RVA: 0x000E9A04 File Offset: 0x000E7C04
	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x6ABA10", Offset = "0x6AA010", VA = "0x1806ABA10")]
	private void Start()
	{
		this.InitPlants();
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x000E9A18 File Offset: 0x000E7C18
	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x6AB740", Offset = "0x6A9D40", VA = "0x1806AB740")]
	private void InitPlants()
	{
		ulong num3;
		do
		{
			int num = 0;
			HashSet<PlantType> baiscPlants = CoreEnums.baiscPlants;
			bool flag;
			if (flag)
			{
				Transform transform = this.cardsHead.transform;
				int num2 = 0;
				Transform child = transform.GetChild(num2);
				Transform transform2 = this.cardsHead;
				ShootingCard component = global::UnityEngine.Object.Instantiate<Transform>(child, transform2).GetComponent<ShootingCard>();
				component.thePlantType = (PlantType)num;
				PlantType plantType;
				string name = Enum.GetName(typeof(PlantType), plantType);
				component.name = name;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x000E9AAC File Offset: 0x000E7CAC
	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public ShootingLevelMenu()
	{
	}

	// Token: 0x040018F7 RID: 6391
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018F7")]
	public Transform cardsHead;
}
