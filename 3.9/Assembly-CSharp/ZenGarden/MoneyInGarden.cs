using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class MoneyInGarden : MonoBehaviour
	{
		// Token: 0x06003714 RID: 14100 RVA: 0x00127664 File Offset: 0x00125864
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x7C1C00", Offset = "0x7C0200", VA = "0x1807C1C00")]
		private void Awake()
		{
			SpriteRenderer component = base.GetComponent<SpriteRenderer>();
			this.r = component;
			float num;
			this.x = num;
			float num2 = global::UnityEngine.Random.Range(num, 3f);
			this.y = num2;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0012769C File Offset: 0x0012589C
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x7C1F50", Offset = "0x7C0550", VA = "0x1807C1F50")]
		private void Start()
		{
			ItemType itemType = this.theCoinType;
			if (typeof(GameAPP).TypeHandle <= (ulong)1L)
			{
			}
			if (itemType == ItemType.DiamondCoin)
			{
				GameAPP.PlaySound(117, 0.5f, 1f);
			}
			Transform transform = base.transform;
			Vector3 vector;
			float num = vector.y;
			this.startY = num;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x001276EC File Offset: 0x001258EC
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x7C2010", Offset = "0x7C0610", VA = "0x1807C2010")]
		private void Update()
		{
			GardenMoney instance = GardenMoney.Instance;
			int num = 0;
			if (!(instance == num))
			{
				Transform transform = base.transform;
				float num2 = this.startY;
				Vector3 vector;
				float num3 = vector.y;
				if (num3 > num2)
				{
					Transform transform2 = base.transform;
					float deltaTime = Time.deltaTime;
					float num4 = this.y;
					float deltaTime2 = Time.deltaTime;
					this.y = num4;
					float deltaTime3 = Time.deltaTime;
					this.timer = deltaTime3;
				}
				Transform transform3 = base.transform;
				Vector3 vector2;
				float z = vector2.z;
				Transform pos = GardenMoney.Instance.pos;
				float deltaTime4 = Time.deltaTime;
				float num5;
				if (num2 <= num5)
				{
					global::UnityEngine.Object.Destroy(base.gameObject);
					int num6 = 0;
					bool flag = Garden.Instance != num6;
					ItemType itemType = this.theCoinType;
					if (!flag)
					{
						if (itemType != ItemType.NormalSun)
						{
							if (itemType != ItemType.NormalSun)
							{
								if (itemType == ItemType.BigSun)
								{
									GameAPP.theMoneyCount = GameAPP.theMoneyCount;
								}
								return;
							}
							long theMoneyCount = GameAPP.theMoneyCount;
						}
						long theMoneyCount2 = GameAPP.theMoneyCount;
					}
					int num7 = TreasureData.treasureMoney;
					uint num8;
					num7 += (int)num8;
					TreasureData.treasureMoney = num7;
				}
			}
			global::UnityEngine.Object.Destroy(base.gameObject);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00127818 File Offset: 0x00125A18
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x7C1C90", Offset = "0x7C0290", VA = "0x1807C1C90")]
		private void PositionUpdate(float distance)
		{
			int num = 0;
			float a = this.color.a;
			float deltaTime = Time.deltaTime;
			this.color.a = a;
			SpriteRenderer spriteRenderer = this.r;
			Color color = this.color;
			spriteRenderer.color = color;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
			float deltaTime2 = Time.deltaTime;
			if (num > (int)distance || distance > 1f)
			{
			}
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform pos = GardenMoney.Instance.pos;
			float deltaTime3 = Time.deltaTime;
			if (num > (int)deltaTime3 || deltaTime3 > 1f)
			{
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x001278D4 File Offset: 0x00125AD4
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x7C2400", Offset = "0x7C0A00", VA = "0x1807C2400")]
		public MoneyInGarden()
		{
		}

		// Token: 0x04002A97 RID: 10903
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A97")]
		public ItemType theCoinType;

		// Token: 0x04002A98 RID: 10904
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002A98")]
		public int treasureCost = (int)((ulong)1L);

		// Token: 0x04002A99 RID: 10905
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A99")]
		private Color color;

		// Token: 0x04002A9A RID: 10906
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002A9A")]
		private SpriteRenderer r;

		// Token: 0x04002A9B RID: 10907
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002A9B")]
		private readonly float moveSpeed = 4f;

		// Token: 0x04002A9C RID: 10908
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002A9C")]
		private float timer;

		// Token: 0x04002A9D RID: 10909
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002A9D")]
		private float x;

		// Token: 0x04002A9E RID: 10910
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x4002A9E")]
		private float y;

		// Token: 0x04002A9F RID: 10911
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002A9F")]
		private float startY;
	}
}
