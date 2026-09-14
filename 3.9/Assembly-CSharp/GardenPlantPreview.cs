using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000795 RID: 1941
[Token(Token = "0x2000795")]
public class GardenPlantPreview : MonoBehaviour
{
	// Token: 0x0600276B RID: 10091 RVA: 0x000D0BA8 File Offset: 0x000CEDA8
	[Token(Token = "0x600276B")]
	[Address(RVA = "0x63F8C0", Offset = "0x63DEC0", VA = "0x18063F8C0")]
	public static GardenPlantPreview CreatePreview(PlantType thePlantType, Vector2 position)
	{
		Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
		bool flag;
		if (!flag)
		{
		}
		GameObject gameObject;
		Plant component = gameObject.GetComponent<Plant>();
		GameObject gameObject2 = new GameObject("preview");
		Transform transform = gameObject2.transform;
		Transform transform2 = component.transform;
		Transform transform3 = gameObject2.transform;
		transform2.parentInternal = transform3;
		GardenPlantPreview gardenPlantPreview = gameObject2.AddComponent<GardenPlantPreview>();
		global::UnityEngine.Object.Destroy(component);
		throw new NullReferenceException();
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x000D0C1C File Offset: 0x000CEE1C
	[Token(Token = "0x600276C")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public GardenPlantPreview()
	{
	}
}
