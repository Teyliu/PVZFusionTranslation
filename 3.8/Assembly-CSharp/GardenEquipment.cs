using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000759 RID: 1881
[Token(Token = "0x2000759")]
public class GardenEquipment : MonoBehaviour
{
	// Token: 0x0600263A RID: 9786 RVA: 0x000CB858 File Offset: 0x000C9A58
	[Token(Token = "0x600263A")]
	[Address(RVA = "0x5DBEF0", Offset = "0x5DA4F0", VA = "0x1805DBEF0")]
	private void Awake()
	{
		float num = this.period;
		this.timer = num;
		Transform transform = base.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).gameObject;
		this.preview = gameObject;
		GameObject gameObject2 = base.transform.GetChild(1).gameObject;
		this.main = gameObject2;
		List<SpriteRenderer> sprites = global::Core.Lawnf.GetSprites(base.gameObject);
		this.spriteRenderers = sprites;
		throw new NullReferenceException();
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x000CB8C8 File Offset: 0x000C9AC8
	[Token(Token = "0x600263B")]
	[Address(RVA = "0x5DC700", Offset = "0x5DAD00", VA = "0x1805DC700")]
	private void Update()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			float num3 = this.period;
			this.timer = num3;
			this.TimeUp();
		}
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x000CB908 File Offset: 0x000C9B08
	[Token(Token = "0x600263C")]
	[Address(RVA = "0x5DBFF0", Offset = "0x5DA5F0", VA = "0x1805DBFF0")]
	public void HighLight(float light)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, light);
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x000CB924 File Offset: 0x000C9B24
	[Token(Token = "0x600263D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "4")]
	protected virtual void TimeUp()
	{
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x000CB934 File Offset: 0x000C9B34
	[Token(Token = "0x600263E")]
	[Address(RVA = "0x5DC390", Offset = "0x5DA990", VA = "0x1805DC390")]
	public static GardenEquipment SetEquipment(Garden garden, EquipmentData data)
	{
		Dictionary<EquipmentType, GameObject> equipmentPrefabs = GameAPP.resourcesManager.equipmentPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = garden.transform;
		GameObject gameObject;
		GardenEquipment component = gameObject.GetComponent<GardenEquipment>();
		component.data = data;
		component.garden = garden;
		int theRow = data.theRow;
		int theColumn = data.theColumn;
		Dictionary<ValueTuple<int, int>, GardenEquipment> equipments = garden.equipments;
		bool flag2;
		if (!flag2)
		{
			int theRow2 = data.theRow;
			int theColumn2 = data.theColumn;
			Debug.LogError(string.Format("{0}行{1}列已被占用，无法放置设备，已退回仓库", theRow2, theRow2));
			global::UnityEngine.Object.Destroy(component.gameObject);
			data.set = false;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x000CB9E0 File Offset: 0x000C9BE0
	[Token(Token = "0x600263F")]
	[Address(RVA = "0x5DC050", Offset = "0x5DA650", VA = "0x1805DC050")]
	public static GameObject SetEquipmentPreviewWithShadow(EquipmentType type)
	{
		Dictionary<EquipmentType, GameObject> equipmentPrefabs = GameAPP.resourcesManager.equipmentPrefabs;
		bool flag;
		if (!flag)
		{
		}
		GameObject gameObject;
		GardenEquipment component = gameObject.GetComponent<GardenEquipment>();
		global::UnityEngine.Object.Destroy(component);
		return component.gameObject;
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x000CBA20 File Offset: 0x000C9C20
	[Token(Token = "0x6002640")]
	[Address(RVA = "0x5DC170", Offset = "0x5DA770", VA = "0x1805DC170")]
	public static GameObject SetEquipmentPreview(Garden garden, EquipmentType type)
	{
		Dictionary<EquipmentType, GameObject> equipmentPrefabs = GameAPP.resourcesManager.equipmentPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = garden.transform;
		GameObject gameObject;
		GardenEquipment component = gameObject.GetComponent<GardenEquipment>();
		component.preview.SetActive(true);
		global::UnityEngine.Object.Destroy(component);
		global::UnityEngine.Object.Destroy(component.main);
		return gameObject;
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x000CBA84 File Offset: 0x000C9C84
	[Token(Token = "0x6002641")]
	[Address(RVA = "0x5DC770", Offset = "0x5DAD70", VA = "0x1805DC770")]
	public GardenEquipment()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		this.period = 3f;
		base..ctor();
	}

	// Token: 0x040013CF RID: 5071
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013CF")]
	public EquipmentData data;

	// Token: 0x040013D0 RID: 5072
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40013D0")]
	public Garden garden;

	// Token: 0x040013D1 RID: 5073
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40013D1")]
	public GameObject preview;

	// Token: 0x040013D2 RID: 5074
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40013D2")]
	public GameObject main;

	// Token: 0x040013D3 RID: 5075
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40013D3")]
	private List<SpriteRenderer> spriteRenderers;

	// Token: 0x040013D4 RID: 5076
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40013D4")]
	[Header("参数")]
	public float timer;

	// Token: 0x040013D5 RID: 5077
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40013D5")]
	public float period;
}
