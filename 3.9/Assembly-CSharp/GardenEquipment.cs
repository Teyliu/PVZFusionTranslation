using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Tilemaps;

// Token: 0x02000792 RID: 1938
[Token(Token = "0x2000792")]
public class GardenEquipment : MonoBehaviour
{
	// Token: 0x06002761 RID: 10081 RVA: 0x000D08E8 File Offset: 0x000CEAE8
	[Token(Token = "0x6002761")]
	[Address(RVA = "0x63EE00", Offset = "0x63D400", VA = "0x18063EE00")]
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

	// Token: 0x06002762 RID: 10082 RVA: 0x000D0958 File Offset: 0x000CEB58
	[Token(Token = "0x6002762")]
	[Address(RVA = "0x63F620", Offset = "0x63DC20", VA = "0x18063F620")]
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

	// Token: 0x06002763 RID: 10083 RVA: 0x000D0998 File Offset: 0x000CEB98
	[Token(Token = "0x6002763")]
	[Address(RVA = "0x63EF00", Offset = "0x63D500", VA = "0x18063EF00")]
	public void HighLight(float light)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, light);
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x000D09B4 File Offset: 0x000CEBB4
	[Token(Token = "0x6002764")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "4")]
	protected virtual void TimeUp()
	{
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x000D09C4 File Offset: 0x000CEBC4
	[Token(Token = "0x6002765")]
	[Address(RVA = "0x63F2A0", Offset = "0x63D8A0", VA = "0x18063F2A0")]
	public static GardenEquipment SetEquipment(Garden garden, EquipmentData data)
	{
		Dictionary<EquipmentType, GameObject> equipmentPrefabs = GameAPP.resourcesManager.equipmentPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Tilemap tilemap = garden.tilemap;
		Transform transform = garden.transform;
		GameObject gameObject;
		GardenEquipment component = gameObject.GetComponent<GardenEquipment>();
		component.data = data;
		component.garden = garden;
		int theRow = data.theRow;
		int num = data.theColumn;
		Dictionary<ValueTuple<int, int>, GardenEquipment> equipments = garden.equipments;
		bool flag2;
		if (!flag2)
		{
			int theRow2 = data.theRow;
			num = theRow2;
			Debug.LogError(string.Format("{0}行{1}列已被占用，无法放置设备，已退回仓库", num, theRow2));
			global::UnityEngine.Object.Destroy(component.gameObject);
			data.set = false;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x000D0A64 File Offset: 0x000CEC64
	[Token(Token = "0x6002766")]
	[Address(RVA = "0x63EF60", Offset = "0x63D560", VA = "0x18063EF60")]
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

	// Token: 0x06002767 RID: 10087 RVA: 0x000D0AA4 File Offset: 0x000CECA4
	[Token(Token = "0x6002767")]
	[Address(RVA = "0x63F080", Offset = "0x63D680", VA = "0x18063F080")]
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

	// Token: 0x06002768 RID: 10088 RVA: 0x000D0B08 File Offset: 0x000CED08
	[Token(Token = "0x6002768")]
	[Address(RVA = "0x63F690", Offset = "0x63DC90", VA = "0x18063F690")]
	public GardenEquipment()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		this.period = 3f;
		base..ctor();
	}

	// Token: 0x040014A7 RID: 5287
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40014A7")]
	public EquipmentData data;

	// Token: 0x040014A8 RID: 5288
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40014A8")]
	public Garden garden;

	// Token: 0x040014A9 RID: 5289
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014A9")]
	public GameObject preview;

	// Token: 0x040014AA RID: 5290
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014AA")]
	public GameObject main;

	// Token: 0x040014AB RID: 5291
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40014AB")]
	private List<SpriteRenderer> spriteRenderers;

	// Token: 0x040014AC RID: 5292
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40014AC")]
	[Header("参数")]
	public float timer;

	// Token: 0x040014AD RID: 5293
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40014AD")]
	public float period;
}
