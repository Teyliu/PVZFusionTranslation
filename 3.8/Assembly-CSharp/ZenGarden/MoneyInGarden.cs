using System;
using Cpp2IlInjected;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public class MoneyInGarden : MonoBehaviour
	{
		// Token: 0x060035D0 RID: 13776 RVA: 0x001223EC File Offset: 0x001205EC
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x75AFA0", Offset = "0x7595A0", VA = "0x18075AFA0")]
		private void Awake()
		{
			SpriteRenderer component = base.GetComponent<SpriteRenderer>();
			this.r = component;
			float num;
			this.x = num;
			float num2 = global::UnityEngine.Random.Range(num, 3f);
			this.y = num2;
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00122424 File Offset: 0x00120624
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x75B2F0", Offset = "0x7598F0", VA = "0x18075B2F0")]
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

		// Token: 0x060035D2 RID: 13778 RVA: 0x00122474 File Offset: 0x00120674
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x75B3B0", Offset = "0x7599B0", VA = "0x18075B3B0")]
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

		// Token: 0x060035D3 RID: 13779 RVA: 0x001225A0 File Offset: 0x001207A0
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x75B030", Offset = "0x759630", VA = "0x18075B030")]
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

		// Token: 0x060035D4 RID: 13780 RVA: 0x0012265C File Offset: 0x0012085C
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x75B7A0", Offset = "0x759DA0", VA = "0x18075B7A0")]
		public MoneyInGarden()
		{
		}

		// Token: 0x04002924 RID: 10532
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002924")]
		public ItemType theCoinType;

		// Token: 0x04002925 RID: 10533
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002925")]
		public int treasureCost = (int)((ulong)1L);

		// Token: 0x04002926 RID: 10534
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002926")]
		private Color color;

		// Token: 0x04002927 RID: 10535
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002927")]
		private SpriteRenderer r;

		// Token: 0x04002928 RID: 10536
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002928")]
		private readonly float moveSpeed = 4f;

		// Token: 0x04002929 RID: 10537
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4002929")]
		private float timer;

		// Token: 0x0400292A RID: 10538
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400292A")]
		private float x;

		// Token: 0x0400292B RID: 10539
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400292B")]
		private float y;

		// Token: 0x0400292C RID: 10540
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400292C")]
		private float startY;
	}
}
