using System;
using System.Collections;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000835 RID: 2101
[Token(Token = "0x2000835")]
public class ExploreGrid : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06002ABF RID: 10943 RVA: 0x000EA040 File Offset: 0x000E8240
	[Token(Token = "0x6002ABF")]
	[Address(RVA = "0x655610", Offset = "0x653C10", VA = "0x180655610")]
	private void Start()
	{
		ExploreMakeMenu instance = ExploreMakeMenu.Instance;
		this.menu = instance;
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000EA05C File Offset: 0x000E825C
	[Token(Token = "0x6002AC0")]
	[Address(RVA = "0x654D30", Offset = "0x653330", VA = "0x180654D30", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
		for (;;)
		{
			int num = 0;
			PointerEventData.InputButton <button>k__BackingField = eventData.<button>k__BackingField;
			if (<button>k__BackingField == PointerEventData.InputButton.Left)
			{
				break;
			}
			while (<button>k__BackingField != PointerEventData.InputButton.Right)
			{
			}
			List<PrePlantData> list = this.plantData;
			int size = list._size;
			list._size = num;
			if (size > 0)
			{
			}
			List<Image> list2 = this.images;
			int size2 = list2._size;
			list2._size = num;
			if (size2 > 0)
			{
			}
			GameObject gameObject;
			if (base.transform.GetEnumerator() != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				global::UnityEngine.Object.Destroy(gameObject);
			}
			if (gameObject != 0)
			{
			}
			if (num == 0)
			{
				goto Block_4;
			}
		}
		PlantType selectedPlantType = this.menu.selectedPlantType;
		this.SetPlant(selectedPlantType);
		return;
		Block_4:
		throw new NullReferenceException();
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000EA11C File Offset: 0x000E831C
	[Token(Token = "0x6002AC1")]
	[Address(RVA = "0x655320", Offset = "0x653920", VA = "0x180655320")]
	public void SetPlant(PlantType thePlantType)
	{
		List<Image> list = this.images;
		if (thePlantType != PlantType.Nothing)
		{
			GameObject gameObject = new GameObject("icon");
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
			Transform transform3 = gameObject.transform;
			Image image = gameObject.AddComponent<Image>();
			int size = this.images._size;
			image.m_Material = image;
			List<PrePlantData> list2 = this.plantData;
			PrePlantData prePlantData = new PrePlantData();
			Vector2Int vector2Int = this.box;
			prePlantData.theColumn = vector2Int;
			int y = this.box.m_Y;
			prePlantData.theRow = y;
			prePlantData.thePlantType = thePlantType;
			int size2 = list2._size;
			list2._size = prePlantData;
			this.UpdateImages();
		}
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000EA1F0 File Offset: 0x000E83F0
	[Token(Token = "0x6002AC2")]
	[Address(RVA = "0x655660", Offset = "0x653C60", VA = "0x180655660")]
	private void UpdateImages()
	{
		List<Image> list = this.images;
		int size = list._size;
		if (list != 0)
		{
			if (list != 0)
			{
				if (list != 0)
				{
					if (size != 1)
					{
						return;
					}
					int num = 0;
					Transform transform = this.images[num].transform;
					List<Image> list2 = this.images;
					int num2 = 0;
					Transform transform2 = list2[num2].transform;
					uint num3;
					Transform transform3 = this.images[(int)num3].transform;
					uint num4;
					Transform transform4 = this.images[(int)num4].transform;
					uint num5;
					Transform transform5 = this.images[(int)num5].transform;
					uint num6;
					Transform transform6 = this.images[(int)num6].transform;
					uint num7;
					Transform transform7 = this.images[(int)num7].transform;
					List<Image> list3 = this.images;
				}
				List<Image> list4 = this.images;
				int num8 = 0;
				Transform transform8 = list4[num8].transform;
				List<Image> list5 = this.images;
				int num9 = 0;
				Transform transform9 = list5[num9].transform;
				uint num10;
				Transform transform10 = this.images[(int)num10].transform;
				uint num11;
				Transform transform11 = this.images[(int)num11].transform;
				uint num12;
				Transform transform12 = this.images[(int)num12].transform;
				uint num13;
				Transform transform13 = this.images[(int)num13].transform;
				return;
			}
			List<Image> list6 = this.images;
			int num14 = 0;
			Transform transform14 = list6[num14].transform;
			List<Image> list7 = this.images;
			int num15 = 0;
			Transform transform15 = list7[num15].transform;
			uint num16;
			Transform transform16 = this.images[(int)num16].transform;
			uint num17;
			Transform transform17 = this.images[(int)num17].transform;
		}
		List<Image> list8 = this.images;
		int num18 = 0;
		Transform transform18 = list8[num18].transform;
		List<Image> list9 = this.images;
		int num19 = 0;
		Transform transform19 = list9[num19].transform;
		Vector2 oneVector = Vector2.oneVector;
		throw new NullReferenceException();
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x000EA3F4 File Offset: 0x000E85F4
	[Token(Token = "0x6002AC3")]
	[Address(RVA = "0x6550E0", Offset = "0x6536E0", VA = "0x1806550E0")]
	private void SetIcon(Image icon, PlantType thePlantType)
	{
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			icon.sprite = sprite;
			icon.SetNativeSize();
			Transform transform = icon.transform;
		}
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x000EA43C File Offset: 0x000E863C
	[Token(Token = "0x6002AC4")]
	[Address(RVA = "0x655010", Offset = "0x653610", VA = "0x180655010")]
	[ProButton]
	public void SetBox()
	{
		int num = base.transform.GetSiblingIndex();
		ulong num2;
		num2 += num2;
		num2 += num2;
		num = (int)((ulong)num - num2);
		this.box = num;
		ulong num3;
		num3 += num3;
		this.box.m_Y = (int)num3;
		if (num3 == (ulong)1L)
		{
			Image component = base.GetComponent<Image>();
		}
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x000EA48C File Offset: 0x000E868C
	[Token(Token = "0x6002AC5")]
	[Address(RVA = "0x656150", Offset = "0x654750", VA = "0x180656150")]
	public ExploreGrid()
	{
		List<PrePlantData> list = new List();
		this.plantData = list;
		List<Image> list2 = new List();
		this.images = list2;
		base..ctor();
	}

	// Token: 0x040018E9 RID: 6377
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018E9")]
	public List<PrePlantData> plantData;

	// Token: 0x040018EA RID: 6378
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018EA")]
	public List<Image> images;

	// Token: 0x040018EB RID: 6379
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018EB")]
	public Vector2Int box;

	// Token: 0x040018EC RID: 6380
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018EC")]
	public ExploreMakeMenu menu;
}
