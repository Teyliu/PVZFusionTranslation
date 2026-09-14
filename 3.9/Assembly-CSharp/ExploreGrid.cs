using System;
using System.Collections;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000871 RID: 2161
[Token(Token = "0x2000871")]
public class ExploreGrid : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	// Token: 0x06002BF1 RID: 11249 RVA: 0x000EEDE8 File Offset: 0x000ECFE8
	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x6B9430", Offset = "0x6B7A30", VA = "0x1806B9430")]
	private void Start()
	{
		ExploreMakeMenu instance = ExploreMakeMenu.Instance;
		this.menu = instance;
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x000EEE04 File Offset: 0x000ED004
	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x6B8B50", Offset = "0x6B7150", VA = "0x1806B8B50", Slot = "4")]
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

	// Token: 0x06002BF3 RID: 11251 RVA: 0x000EEEC4 File Offset: 0x000ED0C4
	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x6B9140", Offset = "0x6B7740", VA = "0x1806B9140")]
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

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000EEF98 File Offset: 0x000ED198
	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x6B9480", Offset = "0x6B7A80", VA = "0x1806B9480")]
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

	// Token: 0x06002BF5 RID: 11253 RVA: 0x000EF19C File Offset: 0x000ED39C
	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x6B8F00", Offset = "0x6B7500", VA = "0x1806B8F00")]
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

	// Token: 0x06002BF6 RID: 11254 RVA: 0x000EF1E4 File Offset: 0x000ED3E4
	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x6B8E30", Offset = "0x6B7430", VA = "0x1806B8E30")]
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

	// Token: 0x06002BF7 RID: 11255 RVA: 0x000EF234 File Offset: 0x000ED434
	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x6B9F70", Offset = "0x6B8570", VA = "0x1806B9F70")]
	public ExploreGrid()
	{
		List<PrePlantData> list = new List();
		this.plantData = list;
		List<Image> list2 = new List();
		this.images = list2;
		base..ctor();
	}

	// Token: 0x040019D7 RID: 6615
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40019D7")]
	public List<PrePlantData> plantData;

	// Token: 0x040019D8 RID: 6616
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40019D8")]
	public List<Image> images;

	// Token: 0x040019D9 RID: 6617
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40019D9")]
	public Vector2Int box;

	// Token: 0x040019DA RID: 6618
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40019DA")]
	public ExploreMakeMenu menu;
}
