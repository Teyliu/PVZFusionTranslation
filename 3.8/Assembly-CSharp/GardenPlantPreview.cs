using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200075C RID: 1884
[Token(Token = "0x200075C")]
public class GardenPlantPreview : MonoBehaviour
{
	// Token: 0x06002644 RID: 9796 RVA: 0x000CBB24 File Offset: 0x000C9D24
	[Token(Token = "0x6002644")]
	[Address(RVA = "0x5DC9A0", Offset = "0x5DAFA0", VA = "0x1805DC9A0")]
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

	// Token: 0x06002645 RID: 9797 RVA: 0x000CBB98 File Offset: 0x000C9D98
	[Token(Token = "0x6002645")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public GardenPlantPreview()
	{
	}
}
