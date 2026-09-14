using System;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class DroppedCard : CardUI
{
	// Token: 0x06000889 RID: 2185 RVA: 0x0002B774 File Offset: 0x00029974
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x8F4AA0", Offset = "0x8F30A0", VA = "0x1808F4AA0", Slot = "4")]
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

	// Token: 0x0600088A RID: 2186 RVA: 0x0002B858 File Offset: 0x00029A58
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x8F5740", Offset = "0x8F3D40", VA = "0x1808F5740", Slot = "5")]
	protected override void Start()
	{
		base.ChangeCardSprite();
		Transform transform = base.transform;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x0002B87C File Offset: 0x00029A7C
	[Token(Token = "0x600088B")]
	[Address(RVA = "0x8F4C70", Offset = "0x8F3270", VA = "0x1808F4C70")]
	public void Fall()
	{
		int num = 0;
		this.fallByBoss = true;
		this.existTime = (float)num;
		this.velocity.y = (float)num;
		bool flag = ConveyManager.Instance.cardsOnBelt.Remove(this);
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x0002B8BC File Offset: 0x00029ABC
	[Token(Token = "0x600088C")]
	[Address(RVA = "0x8F57A0", Offset = "0x8F3DA0", VA = "0x1808F57A0", Slot = "6")]
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

	// Token: 0x0600088D RID: 2189 RVA: 0x0002BA9C File Offset: 0x00029C9C
	[Token(Token = "0x600088D")]
	[Address(RVA = "0x8F5460", Offset = "0x8F3A60", VA = "0x1808F5460")]
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

	// Token: 0x0600088E RID: 2190 RVA: 0x0002BB94 File Offset: 0x00029D94
	[Token(Token = "0x600088E")]
	[Address(RVA = "0x8F5370", Offset = "0x8F3970", VA = "0x1808F5370")]
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

	// Token: 0x0600088F RID: 2191 RVA: 0x0002BBE0 File Offset: 0x00029DE0
	[Token(Token = "0x600088F")]
	[Address(RVA = "0x8F4CF0", Offset = "0x8F32F0", VA = "0x1808F4CF0", Slot = "8")]
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

	// Token: 0x06000890 RID: 2192 RVA: 0x0002BC58 File Offset: 0x00029E58
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x8F4E60", Offset = "0x8F3460", VA = "0x1808F4E60", Slot = "9")]
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
					}
					global::UnityEngine.Object.Destroy(base.gameObject);
				}
			}
			uint num4;
			ulong num5;
			base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
			this.isPickUp = true;
			this.isLand = true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0002BDC0 File Offset: 0x00029FC0
	[Token(Token = "0x6000891")]
	[Address(RVA = "0x8F5E10", Offset = "0x8F4410", VA = "0x1808F5E10")]
	public DroppedCard()
	{
	}

	// Token: 0x04000404 RID: 1028
	[Token(Token = "0x4000404")]
	private const float gravity = 9.8f;

	// Token: 0x04000405 RID: 1029
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000405")]
	private Vector2 velocity;

	// Token: 0x04000406 RID: 1030
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000406")]
	private Vector2 startPosition;

	// Token: 0x04000407 RID: 1031
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000407")]
	private float minY;

	// Token: 0x04000408 RID: 1032
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000408")]
	private bool isLand;

	// Token: 0x04000409 RID: 1033
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000409")]
	public int movingWay;

	// Token: 0x0400040A RID: 1034
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400040A")]
	public float lifeTime = 15f;

	// Token: 0x0400040B RID: 1035
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x400040B")]
	public bool fromPumpiner;

	// Token: 0x0400040C RID: 1036
	[FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x400040C")]
	private float existTime;

	// Token: 0x0400040D RID: 1037
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400040D")]
	private float flashTime;

	// Token: 0x0400040E RID: 1038
	[FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x400040E")]
	private bool flashing;

	// Token: 0x0400040F RID: 1039
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400040F")]
	private Image image1;

	// Token: 0x04000410 RID: 1040
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000410")]
	private Image image2;

	// Token: 0x04000411 RID: 1041
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000411")]
	public bool fallByBoss;
}
