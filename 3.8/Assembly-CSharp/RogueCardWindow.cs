using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200086B RID: 2155
[Token(Token = "0x200086B")]
public class RogueCardWindow : BaseWindow
{
	// Token: 0x06002C09 RID: 11273 RVA: 0x000F1C94 File Offset: 0x000EFE94
	[Token(Token = "0x6002C09")]
	[Address(RVA = "0x6718A0", Offset = "0x66FEA0", VA = "0x1806718A0")]
	public void InitCard(PlantType thePlantType)
	{
		int num = global::UnityEngine.Random.Range(1, 3);
		Dictionary<PlantType, int> dictionary = this.plants;
		Dictionary<PlantType, int> dictionary2 = this.plants;
		bool flag;
		if (!flag)
		{
		}
		TextMeshProUGUI introduce = this.introduce;
		throw new NullReferenceException();
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000F1CCC File Offset: 0x000EFECC
	[Token(Token = "0x6002C0A")]
	[Address(RVA = "0x6719D0", Offset = "0x66FFD0", VA = "0x1806719D0", Slot = "11")]
	public override void OnAnimOver()
	{
		int num;
		do
		{
			num = 0;
			Dictionary<PlantType, int> dictionary = this.plants;
			bool flag;
			if (flag)
			{
				GameObject gameObject;
				if (num != 1)
				{
					Transform transform = gameObject.transform;
					Vector3 vector;
					float z = vector.z;
					SortingGroup component = gameObject.GetComponent<SortingGroup>();
					int num2 = component.sortingOrder + 1;
					component.sortingOrder = num2;
					num++;
				}
				Transform transform2 = gameObject.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				num++;
			}
		}
		while (num != 0);
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x000F1D5C File Offset: 0x000EFF5C
	[Token(Token = "0x6002C0B")]
	[Address(RVA = "0x671C80", Offset = "0x670280", VA = "0x180671C80")]
	public RogueCardWindow()
	{
		Dictionary<PlantType, int> dictionary = new Dictionary();
		this.plants = dictionary;
		base..ctor();
	}

	// Token: 0x04001A2A RID: 6698
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001A2A")]
	public Dictionary<PlantType, int> plants;
}
