using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000800 RID: 2048
[Token(Token = "0x2000800")]
public class ShootingLevelMenu : BaseMenu
{
	// Token: 0x060029CC RID: 10700 RVA: 0x000E498C File Offset: 0x000E2B8C
	[Token(Token = "0x60029CC")]
	[Address(RVA = "0x647270", Offset = "0x645870", VA = "0x180647270")]
	private void Start()
	{
		this.InitPlants();
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x000E49A0 File Offset: 0x000E2BA0
	[Token(Token = "0x60029CD")]
	[Address(RVA = "0x646FA0", Offset = "0x6455A0", VA = "0x180646FA0")]
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

	// Token: 0x060029CE RID: 10702 RVA: 0x000E4A34 File Offset: 0x000E2C34
	[Token(Token = "0x60029CE")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public ShootingLevelMenu()
	{
	}

	// Token: 0x0400180C RID: 6156
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400180C")]
	public Transform cardsHead;
}
