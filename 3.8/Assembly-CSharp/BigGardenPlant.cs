using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Tilemaps;
using ZenGarden;

// Token: 0x0200074E RID: 1870
[Token(Token = "0x200074E")]
public class BigGardenPlant : MonoBehaviour
{
	// Token: 0x060025F7 RID: 9719 RVA: 0x000C96F4 File Offset: 0x000C78F4
	[Token(Token = "0x60025F7")]
	[Address(RVA = "0x5BD280", Offset = "0x5BB880", VA = "0x1805BD280")]
	private void Awake()
	{
		this.stage = (int)((ulong)1L);
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x000C970C File Offset: 0x000C790C
	[Token(Token = "0x60025F8")]
	[Address(RVA = "0x5BE030", Offset = "0x5BC630", VA = "0x1805BE030")]
	private void Start()
	{
		GameObject gameObject = base.gameObject;
		this.GetSpriteRenderers(gameObject);
		GameObject gameObject2 = Resources.Load<GameObject>("Garden/GeneralBubble");
		Transform transform = base.transform;
		GameObject gameObject3 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject2, transform);
		this.bubble = gameObject3;
		this.bubble.GetComponent<SortingGroup>().sortAtRoot = true;
		this.UpdateBubbleSprite();
		int num = this.stage;
		if (num == 1)
		{
			Transform transform2 = base.transform;
			Transform transform3 = this.bubble.transform;
		}
		if (num == 2)
		{
			Transform transform4 = base.transform;
			Transform transform5 = this.bubble.transform;
		}
		Transform transform6 = this.bubble.transform;
		Transform transform7 = base.transform;
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x000C97B8 File Offset: 0x000C79B8
	[Token(Token = "0x60025F9")]
	[Address(RVA = "0x5BDB10", Offset = "0x5BC110", VA = "0x1805BDB10")]
	private void Update()
	{
		long num = this.nextTime;
		GameObject gameObject = this.bubble;
		this.satisfied = true;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x000C981C File Offset: 0x000C7A1C
	[Token(Token = "0x60025FA")]
	[Address(RVA = "0x5BDB10", Offset = "0x5BC110", VA = "0x1805BDB10")]
	private void DemandUpdae()
	{
		long num = this.nextTime;
		GameObject gameObject = this.bubble;
		this.satisfied = true;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x000C9880 File Offset: 0x000C7A80
	[Token(Token = "0x60025FB")]
	[Address(RVA = "0x5BD7D0", Offset = "0x5BBDD0", VA = "0x1805BD7D0")]
	public void Cultivated(ToolType tool)
	{
		if (!this.satisfied && tool == this.needTool)
		{
			this.satisfied = true;
			long realTime = GameAPP.RealTime;
			uint num2;
			uint num3;
			int num = global::UnityEngine.Random.Range((int)num2, (int)num3);
			num = (int)((long)num + realTime);
			this.nextTime = (long)num;
			if (tool != ToolType.WaterCan)
			{
				if (tool != ToolType.WaterCan)
				{
					if (tool != ToolType.WaterCan && tool != ToolType.Fertilize)
					{
						goto IL_01AA;
					}
					int num4 = 0;
					this.needTool = (ToolType)num4;
					int num5 = this.cultivateLevel;
					uint num7;
					uint num8;
					int num6 = global::UnityEngine.Random.Range((int)num7, (int)num8);
					num6 += num5;
					this.cultivateLevel = num6;
					uint num9;
					GameAPP.PlaySound((int)num9, 0.5f, 1f);
					TreasureCardData treasureCardData = this.data;
					int maxDurability = treasureCardData.maxDurability;
					treasureCardData.durability = maxDurability;
				}
				int num10 = 0;
				this.needTool = (ToolType)num10;
				int num11;
				BigGardenPlant.<Grow>d__27 <Grow>d__ = new BigGardenPlant.<Grow>d__27(num11);
				num11 = 0;
				<Grow>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<Grow>d__);
				uint num12;
				GameAPP.PlaySound((int)num12, 0.5f, 1f);
				if (this.data.maxDurability == 1)
				{
					goto IL_01AA;
				}
				TreasureCardData treasureCardData2 = this.data;
			}
			uint num14;
			uint num15;
			int num13 = global::UnityEngine.Random.Range((int)num14, (int)num15);
			this.waterLevel = (int)num14;
			int num16 = 0;
			this.waterLevel = num16;
			if (this.stage < 3)
			{
				this.needTool = (ToolType)((ulong)1L);
			}
			uint num17;
			bool flag = global::UnityEngine.Random.Range(0, (int)num17) != 0;
			this.needTool = (flag ? ToolType.Fertilize : ToolType.WaterCan);
			long realTime2 = GameAPP.RealTime;
			uint num19;
			uint num20;
			int num18 = global::UnityEngine.Random.Range((int)num19, (int)num20);
			num18 = (int)((long)num18 + realTime2);
			this.nextTime = (long)num18;
			uint num21;
			GameAPP.PlaySound((int)num21, 0.5f, 1f);
			TreasureCardData treasureCardData3 = this.data;
			TreasureCardData treasureCardData4 = this.data;
			int maxDurability2 = treasureCardData4.maxDurability;
			if (treasureCardData4.durability > maxDurability2)
			{
				treasureCardData4.durability = maxDurability2;
			}
			IL_01AA:
			this.data.SaveFromGarden(this);
			this.UpdateBubbleSprite();
		}
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x000C9A50 File Offset: 0x000C7C50
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x5BDE30", Offset = "0x5BC430", VA = "0x1805BDE30")]
	private void GiveAward(ItemType itemType)
	{
		Transform transform = base.transform;
		Transform transform2 = this.garden.transform;
		int num = (int)this.thePlantType;
		MoneyInGarden moneyInGarden;
		int num2;
		moneyInGarden.treasureCost = num2;
		moneyInGarden.GetComponent<SpriteRenderer>().sortingLayerName = "UI";
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x000C9A9C File Offset: 0x000C7C9C
	[Token(Token = "0x60025FD")]
	[Address(RVA = "0x5BDFD0", Offset = "0x5BC5D0", VA = "0x1805BDFD0")]
	public void HighLight(float light)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, light);
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x000C9AB8 File Offset: 0x000C7CB8
	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x5BD290", Offset = "0x5BB890", VA = "0x1805BD290")]
	public static BigGardenPlant CreatePlant(Garden garden, PlantType thePlantType, int theColumn, int theRow)
	{
		Dictionary<PlantType, GameObject> plantPrefabs = GameAPP.resourcesManager.plantPrefabs;
		bool flag;
		if (!flag)
		{
		}
		Tilemap tilemap = garden.tilemap;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Plant component = gameObject.GetComponent<Plant>();
		Animator animator = component.anim;
		float num = global::UnityEngine.Random.Range(0.9f, 1.1f);
		animator.SetFloat("Speed", num);
		Collider2D[] components = gameObject.GetComponents<Collider2D>();
		int num2 = 0;
		int num3 = 0;
		if (num3 < components.Length)
		{
			num2++;
		}
		GameObject gameObject2 = new GameObject("plant");
		int num4 = 0;
		gameObject2.transform.position = num4;
		Transform transform = component.transform;
		Transform transform2 = gameObject2.transform;
		transform.parentInternal = transform2;
		BigGardenPlant bigGardenPlant = gameObject2.AddComponent<BigGardenPlant>();
		bigGardenPlant.thePlantType = bigGardenPlant;
		Animator animator2 = component.anim;
		bigGardenPlant.anim = animator2;
		bigGardenPlant.body = gameObject;
		bigGardenPlant.garden = garden;
		bigGardenPlant.theColumn = components;
		bigGardenPlant.theRow = (int)z;
		SortingGroup sortingGroup = bigGardenPlant.AddComponent<SortingGroup>();
		bigGardenPlant.sortingGroup = sortingGroup;
		uint num5;
		bigGardenPlant.sortingGroup.sortingOrder = (int)num5;
		Transform transform3 = bigGardenPlant.transform;
		Transform transform4 = garden.transform;
		transform3.parentInternal = transform4;
		Dictionary<ValueTuple<int, int>, BigGardenPlant> plants = garden.plants;
		bool flag2;
		if (flag2)
		{
			GameObject gameObject3;
			global::UnityEngine.Object.Destroy(gameObject3);
		}
		Dictionary<ValueTuple<int, int>, BigGardenPlant> plants2 = garden.plants;
		global::UnityEngine.Object.Destroy(component);
		throw new NullReferenceException();
	}

	// Token: 0x060025FF RID: 9727 RVA: 0x000C9C24 File Offset: 0x000C7E24
	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x5BDC00", Offset = "0x5BC200", VA = "0x1805BDC00")]
	public static Vector3 GetPosition(Garden garden, int theColumn, int theRow)
	{
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x06002600 RID: 9728 RVA: 0x000C9C4C File Offset: 0x000C7E4C
	[Token(Token = "0x6002600")]
	[Address(RVA = "0x5BDC80", Offset = "0x5BC280", VA = "0x1805BDC80")]
	private void GetSpriteRenderers(GameObject obj)
	{
		ulong num;
		do
		{
			List<GameObject> childs = global::Core.Lawnf.GetChilds(obj.transform);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<SpriteRenderer> list = this.spriteRenderers;
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002601 RID: 9729 RVA: 0x000C9C90 File Offset: 0x000C7E90
	[Token(Token = "0x6002601")]
	[Address(RVA = "0x5BE390", Offset = "0x5BC990", VA = "0x1805BE390")]
	private void UpdateBubbleSprite()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = this.bubble.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				int num2 = 0;
				GameObject gameObject;
				gameObject.SetActive(num2 != 0);
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		if (num == 0 || num == 0 || num == 0 || num == 1)
		{
		}
		Transform transform;
		uint num3;
		ulong num4;
		transform.GetChild((int)num3).gameObject.SetActive(num4 != 0UL);
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x000C9D20 File Offset: 0x000C7F20
	[Token(Token = "0x6002602")]
	[Address(RVA = "0x5BDF60", Offset = "0x5BC560", VA = "0x1805BDF60")]
	private IEnumerator Grow()
	{
		int num;
		BigGardenPlant.<Grow>d__27 <Grow>d__ = new BigGardenPlant.<Grow>d__27(num);
		num = 0;
		<Grow>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x000C9D44 File Offset: 0x000C7F44
	[Token(Token = "0x6002603")]
	[Address(RVA = "0x5BE650", Offset = "0x5BCC50", VA = "0x1805BE650")]
	public BigGardenPlant()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x04001395 RID: 5013
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001395")]
	[Header("属性")]
	public PlantType thePlantType;

	// Token: 0x04001396 RID: 5014
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001396")]
	public int theColumn;

	// Token: 0x04001397 RID: 5015
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001397")]
	public int theRow;

	// Token: 0x04001398 RID: 5016
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001398")]
	[Header("引用")]
	public GameObject bubble;

	// Token: 0x04001399 RID: 5017
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001399")]
	public GameObject body;

	// Token: 0x0400139A RID: 5018
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400139A")]
	public Animator anim;

	// Token: 0x0400139B RID: 5019
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400139B")]
	public Garden garden;

	// Token: 0x0400139C RID: 5020
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400139C")]
	public SortingGroup sortingGroup;

	// Token: 0x0400139D RID: 5021
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400139D")]
	public TreasureCardData data;

	// Token: 0x0400139E RID: 5022
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400139E")]
	public List<SpriteRenderer> spriteRenderers;

	// Token: 0x0400139F RID: 5023
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400139F")]
	[Header("培养属性")]
	public ToolType needTool;

	// Token: 0x040013A0 RID: 5024
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40013A0")]
	public bool satisfied;

	// Token: 0x040013A1 RID: 5025
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40013A1")]
	public long nextTime;

	// Token: 0x040013A2 RID: 5026
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40013A2")]
	public int stage;

	// Token: 0x040013A3 RID: 5027
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40013A3")]
	public int waterLevel;

	// Token: 0x040013A4 RID: 5028
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40013A4")]
	public int cultivateLevel;
}
