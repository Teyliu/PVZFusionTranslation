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

// Token: 0x02000787 RID: 1927
[Token(Token = "0x2000787")]
public class BigGardenPlant : MonoBehaviour
{
	// Token: 0x0600271E RID: 10014 RVA: 0x000CE718 File Offset: 0x000CC918
	[Token(Token = "0x600271E")]
	[Address(RVA = "0x637710", Offset = "0x635D10", VA = "0x180637710")]
	private void Awake()
	{
		this.stage = (int)((ulong)1L);
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x000CE730 File Offset: 0x000CC930
	[Token(Token = "0x600271F")]
	[Address(RVA = "0x6384B0", Offset = "0x636AB0", VA = "0x1806384B0")]
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

	// Token: 0x06002720 RID: 10016 RVA: 0x000CE7DC File Offset: 0x000CC9DC
	[Token(Token = "0x6002720")]
	[Address(RVA = "0x637F90", Offset = "0x636590", VA = "0x180637F90")]
	private void Update()
	{
		long num = this.nextTime;
		GameObject gameObject = this.bubble;
		this.satisfied = true;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x06002721 RID: 10017 RVA: 0x000CE840 File Offset: 0x000CCA40
	[Token(Token = "0x6002721")]
	[Address(RVA = "0x637F90", Offset = "0x636590", VA = "0x180637F90")]
	private void DemandUpdae()
	{
		long num = this.nextTime;
		GameObject gameObject = this.bubble;
		this.satisfied = true;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x000CE8A4 File Offset: 0x000CCAA4
	[Token(Token = "0x6002722")]
	[Address(RVA = "0x637C60", Offset = "0x636260", VA = "0x180637C60")]
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
						goto IL_01AE;
					}
					int num4 = this.cultivateLevel;
					int num5 = 0;
					this.needTool = (ToolType)num5;
					uint num7;
					uint num8;
					int num6 = global::UnityEngine.Random.Range((int)num7, (int)num8);
					num6 += num4;
					this.cultivateLevel = num6;
					uint num9;
					GameAPP.PlaySound((int)num9, 0.5f, 1f);
					TreasureCardData treasureCardData = this.data;
					int maxDurability = treasureCardData.maxDurability;
					treasureCardData.durability = maxDurability;
				}
				int num10 = 0;
				this.needTool = (ToolType)num10;
				BigGardenPlant.<Grow>d__27 <Grow>d__;
				<Grow>d__.System.IDisposable.Dispose();
				<Grow>d__.<>1__state = num10;
				<Grow>d__.<>4__this = this;
				Coroutine coroutine = base.StartCoroutine(<Grow>d__);
				uint num11;
				GameAPP.PlaySound((int)num11, 0.5f, 1f);
				if (this.data.maxDurability == 1)
				{
					goto IL_01AE;
				}
				TreasureCardData treasureCardData2 = this.data;
			}
			uint num13;
			uint num14;
			int num12 = global::UnityEngine.Random.Range((int)num13, (int)num14);
			this.waterLevel = (int)num13;
			int num15 = 0;
			this.waterLevel = num15;
			if (this.stage < 3)
			{
				this.needTool = (ToolType)((ulong)1L);
			}
			uint num16;
			bool flag = global::UnityEngine.Random.Range(0, (int)num16) != 0;
			this.needTool = (flag ? ToolType.Fertilize : ToolType.WaterCan);
			long realTime2 = GameAPP.RealTime;
			uint num18;
			uint num19;
			int num17 = global::UnityEngine.Random.Range((int)num18, (int)num19);
			num17 = (int)((long)num17 + realTime2);
			this.nextTime = (long)num17;
			uint num20;
			GameAPP.PlaySound((int)num20, 0.5f, 1f);
			TreasureCardData treasureCardData3 = this.data;
			TreasureCardData treasureCardData4 = this.data;
			int maxDurability2 = treasureCardData4.maxDurability;
			if (treasureCardData4.durability > maxDurability2)
			{
				treasureCardData4.durability = maxDurability2;
			}
			IL_01AE:
			this.data.SaveFromGarden(this);
			this.UpdateBubbleSprite();
		}
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x000CEA78 File Offset: 0x000CCC78
	[Token(Token = "0x6002723")]
	[Address(RVA = "0x6382B0", Offset = "0x6368B0", VA = "0x1806382B0")]
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

	// Token: 0x06002724 RID: 10020 RVA: 0x000CEAC4 File Offset: 0x000CCCC4
	[Token(Token = "0x6002724")]
	[Address(RVA = "0x638450", Offset = "0x636A50", VA = "0x180638450")]
	public void HighLight(float light)
	{
		GameMaterial.SetBrightness(this.spriteRenderers, light);
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x000CEAE0 File Offset: 0x000CCCE0
	[Token(Token = "0x6002725")]
	[Address(RVA = "0x637720", Offset = "0x635D20", VA = "0x180637720")]
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

	// Token: 0x06002726 RID: 10022 RVA: 0x000CEC4C File Offset: 0x000CCE4C
	[Token(Token = "0x6002726")]
	[Address(RVA = "0x638080", Offset = "0x636680", VA = "0x180638080")]
	public static Vector3 GetPosition(Garden garden, int theColumn, int theRow)
	{
		Vector3 vector;
		float z = vector.z;
		throw new NullReferenceException();
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x000CEC74 File Offset: 0x000CCE74
	[Token(Token = "0x6002727")]
	[Address(RVA = "0x638100", Offset = "0x636700", VA = "0x180638100")]
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

	// Token: 0x06002728 RID: 10024 RVA: 0x000CECB8 File Offset: 0x000CCEB8
	[Token(Token = "0x6002728")]
	[Address(RVA = "0x638810", Offset = "0x636E10", VA = "0x180638810")]
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

	// Token: 0x06002729 RID: 10025 RVA: 0x000CED48 File Offset: 0x000CCF48
	[Token(Token = "0x6002729")]
	[Address(RVA = "0x6383E0", Offset = "0x6369E0", VA = "0x1806383E0")]
	private IEnumerator Grow()
	{
		BigGardenPlant.<Grow>d__27 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x000CED6C File Offset: 0x000CCF6C
	[Token(Token = "0x600272A")]
	[Address(RVA = "0x638AD0", Offset = "0x6370D0", VA = "0x180638AD0")]
	public BigGardenPlant()
	{
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x0400146D RID: 5229
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400146D")]
	[Header("属性")]
	public PlantType thePlantType;

	// Token: 0x0400146E RID: 5230
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400146E")]
	public int theColumn;

	// Token: 0x0400146F RID: 5231
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400146F")]
	public int theRow;

	// Token: 0x04001470 RID: 5232
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001470")]
	[Header("引用")]
	public GameObject bubble;

	// Token: 0x04001471 RID: 5233
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001471")]
	public GameObject body;

	// Token: 0x04001472 RID: 5234
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001472")]
	public Animator anim;

	// Token: 0x04001473 RID: 5235
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001473")]
	public Garden garden;

	// Token: 0x04001474 RID: 5236
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001474")]
	public SortingGroup sortingGroup;

	// Token: 0x04001475 RID: 5237
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001475")]
	public TreasureCardData data;

	// Token: 0x04001476 RID: 5238
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001476")]
	public List<SpriteRenderer> spriteRenderers;

	// Token: 0x04001477 RID: 5239
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001477")]
	[Header("培养属性")]
	public ToolType needTool;

	// Token: 0x04001478 RID: 5240
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001478")]
	public bool satisfied;

	// Token: 0x04001479 RID: 5241
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001479")]
	public long nextTime;

	// Token: 0x0400147A RID: 5242
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400147A")]
	public int stage;

	// Token: 0x0400147B RID: 5243
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400147B")]
	public int waterLevel;

	// Token: 0x0400147C RID: 5244
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400147C")]
	public int cultivateLevel;
}
