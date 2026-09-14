using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020008A7 RID: 2215
[Token(Token = "0x20008A7")]
public class RogueCardWindow : BaseWindow
{
	// Token: 0x06002D3B RID: 11579 RVA: 0x000F6938 File Offset: 0x000F4B38
	[Token(Token = "0x6002D3B")]
	[Address(RVA = "0x6D6470", Offset = "0x6D4A70", VA = "0x1806D6470")]
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

	// Token: 0x06002D3C RID: 11580 RVA: 0x000F6970 File Offset: 0x000F4B70
	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x6D65A0", Offset = "0x6D4BA0", VA = "0x1806D65A0", Slot = "11")]
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

	// Token: 0x06002D3D RID: 11581 RVA: 0x000F6A00 File Offset: 0x000F4C00
	[Token(Token = "0x6002D3D")]
	[Address(RVA = "0x6D6850", Offset = "0x6D4E50", VA = "0x1806D6850")]
	public RogueCardWindow()
	{
		Dictionary<PlantType, int> dictionary = new Dictionary();
		this.plants = dictionary;
		base..ctor();
	}

	// Token: 0x04001B18 RID: 6936
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001B18")]
	public Dictionary<PlantType, int> plants;
}
