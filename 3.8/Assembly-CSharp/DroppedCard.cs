using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F1 RID: 497
[Token(Token = "0x20001F1")]
public class DroppedCard : CardUI
{
	// Token: 0x0600086F RID: 2159 RVA: 0x0002B780 File Offset: 0x00029980
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x865D50", Offset = "0x864350", VA = "0x180865D50", Slot = "4")]
	protected override void Awake()
	{
		this.maxUsedTimes = (int)((ulong)1L);
		Board instance = Board.Instance;
		this.board = instance;
		this.onCardBank = false;
		float num = global::UnityEngine.Random.Range(-4f, 4f);
		this.minY = num;
		this.theSeedCost = (int)((ulong)0L);
		this.CD = 10f;
		this.fullCD = 10f;
		Image component = base.GetComponent<Image>();
		this.image1 = component;
		Transform transform = base.transform;
		int num2 = 0;
		Image component2 = transform.GetChild(num2).GetComponent<Image>();
		this.image2 = component2;
		if (base.transform.childCount > 1)
		{
			TextMeshProUGUI component3 = base.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
			this.text = component3;
		}
		float num3;
		this.velocity = num3;
		float num4 = global::UnityEngine.Random.Range(num3, 3f);
		this.velocity.y = num4;
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0002B864 File Offset: 0x00029A64
	[Token(Token = "0x6000870")]
	[Address(RVA = "0x8669F0", Offset = "0x864FF0", VA = "0x1808669F0", Slot = "5")]
	protected override void Start()
	{
		base.ChangeCardSprite();
		Transform transform = base.transform;
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0002B888 File Offset: 0x00029A88
	[Token(Token = "0x6000871")]
	[Address(RVA = "0x865F20", Offset = "0x864520", VA = "0x180865F20")]
	public void Fall()
	{
		int num = 0;
		this.fallByBoss = true;
		this.existTime = (float)num;
		this.velocity.y = (float)num;
		bool flag = ConveyManager.Instance.cardsOnBelt.Remove(this);
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0002B8C8 File Offset: 0x00029AC8
	[Token(Token = "0x6000872")]
	[Address(RVA = "0x866A50", Offset = "0x865050", VA = "0x180866A50", Slot = "6")]
	protected override void Update()
	{
		if (!this.fallByBoss)
		{
			int maxUsedTimes = this.maxUsedTimes;
			int thePlantType = (int)this.thePlantType;
			global::UnityEngine.Object.Destroy(base.gameObject);
			string text;
			this.text.text = text;
			if (this.movingWay != 3)
			{
				if (this.movingWay != 0)
				{
					if (this.movingWay != 1 || this.isLand)
					{
						goto IL_008F;
					}
					Transform transform = base.transform;
					float deltaTime = Time.deltaTime;
					Transform transform2 = base.transform;
					Vector3 vector;
					if (this.minY <= vector.y)
					{
						goto IL_008F;
					}
					this.isLand = true;
				}
				this.PositionUpdate();
				IL_008F:
				float deltaTime2 = Time.deltaTime;
				this.existTime = deltaTime2;
				Board instance = Board.Instance;
				float num = this.lifeTime;
				if (deltaTime2 > num && this.lifeTime > deltaTime2)
				{
					this.flashing = true;
				}
				if (deltaTime2 > this.lifeTime)
				{
					GameObject theItemOnMouse = Mouse.Instance.theItemOnMouse;
					GameObject gameObject = base.gameObject;
					if (theItemOnMouse == gameObject)
					{
						Mouse instance2 = Mouse.Instance;
						int num2 = 0;
						instance2.ClearItemOnMouse(num2 != 0);
					}
					global::UnityEngine.Object.Destroy(base.gameObject);
				}
				if (this.flashing)
				{
					float deltaTime3 = Time.deltaTime;
					this.flashTime = deltaTime3;
					Image image = this.image1;
					Image image2 = this.image2;
				}
			}
			return;
		}
		GameObject theItemOnMouse2 = Mouse.Instance.theItemOnMouse;
		GameObject gameObject2 = base.gameObject;
		if (theItemOnMouse2 == gameObject2)
		{
			Mouse instance3 = Mouse.Instance;
			int num3 = 0;
			instance3.ClearItemOnMouse(num3 != 0);
		}
		float deltaTime4 = Time.deltaTime;
		this.existTime = deltaTime4;
		if (deltaTime4 > 5f)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
		float y = this.velocity.y;
		float deltaTime5 = Time.deltaTime;
		this.velocity.y = y;
		Transform transform3 = base.transform;
		float deltaTime6 = Time.deltaTime;
		throw new NullReferenceException();
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0002BAA8 File Offset: 0x00029CA8
	[Token(Token = "0x6000873")]
	[Address(RVA = "0x866710", Offset = "0x864D10", VA = "0x180866710")]
	private void PositionUpdate()
	{
		if (!this.isLand)
		{
			float y = this.velocity.y;
			float deltaTime = Time.deltaTime;
			this.velocity.y = y;
			Transform transform = base.transform;
			float deltaTime2 = Time.deltaTime;
			Transform transform2 = base.transform;
			Vector3 vector;
			if (Board.Instance.boardMinY > vector.y)
			{
				Transform transform3 = base.transform;
				Transform transform4 = base.transform;
				Board instance = Board.Instance;
				this.isLand = true;
			}
			Transform transform5 = base.transform;
			float boardMaxX = Board.Instance.boardMaxX;
			Transform transform6 = base.transform;
			Board instance2 = Board.Instance;
			Transform transform7 = base.transform;
			float y2 = this.velocity.y;
			this.velocity.y = y2;
			this.velocity = (ulong)3212836864L;
			if (this.existTime > 0.6f)
			{
				this.isLand = true;
			}
		}
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0002BBA0 File Offset: 0x00029DA0
	[Token(Token = "0x6000874")]
	[Address(RVA = "0x866620", Offset = "0x864C20", VA = "0x180866620")]
	private void PositionUpdate2()
	{
		if (!this.isLand)
		{
			Transform transform = base.transform;
			float deltaTime = Time.deltaTime;
			Transform transform2 = base.transform;
			Vector3 vector;
			if (this.minY > vector.y)
			{
				this.isLand = true;
			}
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0002BBEC File Offset: 0x00029DEC
	[Token(Token = "0x6000875")]
	[Address(RVA = "0x865FA0", Offset = "0x8645A0", VA = "0x180865FA0", Slot = "8")]
	protected override void OnMouseDown()
	{
		CursorChange.SetDefaultCursor();
		GameAPP.PlaySound(19, 0.5f, 1f);
		InGameUI_IZ instance = InGameUI_IZ.Instance;
		int num = 0;
		if (instance != num)
		{
			InGameUI_IZ instance2 = InGameUI_IZ.Instance;
			int num2 = 0;
			instance2.RemoveCardFromBank(this, num2 != 0);
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x0002BC64 File Offset: 0x00029E64
	[Token(Token = "0x6000876")]
	[Address(RVA = "0x866110", Offset = "0x864710", VA = "0x180866110", Slot = "9")]
	public override bool PickUp()
	{
		if (!this.fallByBoss)
		{
			Board instance = Board.Instance;
			if (global::Lawnf.IsBasicPlant(this.thePlantType))
			{
				int thePlantType = (int)this.thePlantType;
				PlantDataManager.PlantData plantData;
				if (plantData != 0)
				{
					PlantType thePlantType2 = this.thePlantType;
					int num = 0;
					int num2 = 0;
					num += num;
					if (num > 0)
					{
						CreateItem instance2 = CreateItem.Instance;
						Transform transform = base.transform;
						Vector3 vector;
						float z = vector.z;
						num2++;
					}
					Board instance3 = Board.Instance;
					PlantType thePlantType3 = this.thePlantType;
					if (instance3 <= (ulong)5L || thePlantType3 == PlantType.SeaShroom || thePlantType3 == PlantType.Magnetshroom)
					{
						CreateItem instance4 = CreateItem.Instance;
						Transform transform2 = base.transform;
						Vector3 vector2;
						float z2 = vector2.z;
						CreateItem instance5 = CreateItem.Instance;
						Transform transform3 = base.transform;
						Vector3 vector3;
						float z3 = vector3.z;
						CreateItem instance6 = CreateItem.Instance;
						Transform transform4 = base.transform;
						Vector3 vector4;
						float z4 = vector4.z;
					}
					uint num3;
					GameAPP.PlaySound((int)num3, 0.5f, 1f);
					Transform transform5 = base.transform;
					Vector3 vector5;
					float z5 = vector5.z;
					InGameUI instance7 = InGameUI.Instance;
					PlantType thePlantType4 = this.thePlantType;
					if (instance7.UnlockCard(thePlantType4))
					{
						InGameText instance8 = InGameText.Instance;
						int num4 = 0;
						instance8.ShowText("你为你的背包新增了一种卡牌", 5f, num4 != 0);
					}
					global::UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			uint num5;
			ulong num6;
			base.transform.GetChild((int)num5).gameObject.SetActive(num6 != 0UL);
			this.isPickUp = true;
			this.isLand = true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x0002BDE4 File Offset: 0x00029FE4
	[Token(Token = "0x6000877")]
	[Address(RVA = "0x8670C0", Offset = "0x8656C0", VA = "0x1808670C0")]
	public DroppedCard()
	{
	}

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	private const float gravity = 9.8f;

	// Token: 0x040003FB RID: 1019
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x40003FB")]
	private Vector2 velocity;

	// Token: 0x040003FC RID: 1020
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x40003FC")]
	private Vector2 startPosition;

	// Token: 0x040003FD RID: 1021
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x40003FD")]
	private float minY;

	// Token: 0x040003FE RID: 1022
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x40003FE")]
	private bool isLand;

	// Token: 0x040003FF RID: 1023
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x40003FF")]
	public int movingWay;

	// Token: 0x04000400 RID: 1024
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000400")]
	public float lifeTime = 15f;

	// Token: 0x04000401 RID: 1025
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000401")]
	public bool fromPumpiner;

	// Token: 0x04000402 RID: 1026
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000402")]
	private float existTime;

	// Token: 0x04000403 RID: 1027
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000403")]
	private float flashTime;

	// Token: 0x04000404 RID: 1028
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000404")]
	private bool flashing;

	// Token: 0x04000405 RID: 1029
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000405")]
	private Image image1;

	// Token: 0x04000406 RID: 1030
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000406")]
	private Image image2;

	// Token: 0x04000407 RID: 1031
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000407")]
	public bool fallByBoss;
}
