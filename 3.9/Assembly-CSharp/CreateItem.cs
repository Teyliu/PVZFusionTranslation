using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000210 RID: 528
[Token(Token = "0x2000210")]
public class CreateItem : MonoBehaviour
{
	// Token: 0x060008E7 RID: 2279 RVA: 0x0002DDA4 File Offset: 0x0002BFA4
	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x8E74E0", Offset = "0x8E5AE0", VA = "0x1808E74E0")]
	private void Awake()
	{
		CreateItem.Instance = this;
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x8E7CC0", Offset = "0x8E62C0", VA = "0x1808E7CC0")]
	public static MoneyInGarden SetMoney(Vector2 position, ItemType theItemType, Transform transform, float scale = 0.6f)
	{
		GameObject gameObject = GameAPP.itemPrefab[(int)theItemType];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject2;
		Transform transform2 = gameObject2.transform;
		Vector3 vector;
		float z = vector.z;
		MoneyInGarden moneyInGarden = gameObject2.AddComponent<MoneyInGarden>();
		moneyInGarden.theCoinType = theItemType;
		return moneyInGarden;
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x0002DE08 File Offset: 0x0002C008
	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x8E7560", Offset = "0x8E5B60", VA = "0x1808E7560")]
	public GameObject SetCoin(int theColumn, int theRow, int theItemType, int theMoveType, [Optional] Vector3 pos, bool freeSet = false)
	{
		Board instance = Board.Instance;
		if (theItemType <= 2 || theItemType == 13 || typeof(Board).TypeHandle <= (ulong)1L)
		{
		}
		float boxXFromColumn = Mouse.Instance.GetBoxXFromColumn(theColumn);
		float landY = Mouse.Instance.GetLandY(boxXFromColumn, theRow);
		GameObject gameObject = GameAPP.itemPrefab[theItemType];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = instance.transform;
		int num = 0;
		GameObject gameObject2;
		Transform transform2;
		if (num == 0)
		{
			transform2 = gameObject2.transform;
			transform2.position = num;
		}
		if (theItemType > 13)
		{
			if (transform2 <= (ulong)2L)
			{
			}
			CoinMoney coinMoney;
			if (transform2 <= (ulong)1L)
			{
				Transform transform3 = gameObject2.transform;
				Transform transform4 = gameObject2.transform;
				Vector3 vector;
				float z = vector.z;
				transform3.localScale = num;
				coinMoney = gameObject2.AddComponent<CoinMoney>();
				coinMoney.theCoinType = theItemType;
			}
			if (coinMoney > (ulong)1L)
			{
				goto IL_00EF;
			}
		}
		if (theItemType > 2)
		{
			if (theItemType == 9)
			{
				gameObject2.GetComponent<DroppedCard>().movingWay = 0;
			}
			if (theItemType != 13)
			{
				goto IL_00EF;
			}
		}
		CoinSun coinSun = gameObject2.AddComponent<CoinSun>();
		coinSun.theMoveType = 0;
		coinSun.theCoinType = theItemType;
		IL_00EF:
		this.SetLayer(gameObject2);
		return gameObject2;
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x0002DF18 File Offset: 0x0002C118
	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x8E7540", Offset = "0x8E5B40", VA = "0x1808E7540")]
	private bool LimSet(int theCoinType)
	{
		if (theCoinType <= 2 || theCoinType != 13)
		{
		}
		return true;
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x0002DF34 File Offset: 0x0002C134
	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x8E7A00", Offset = "0x8E6000", VA = "0x1808E7A00")]
	private void SetLayer(GameObject coin)
	{
		int num;
		do
		{
			num = 0;
			int num2 = Board.Instance.theTotalNumOfCoin;
			if (num2 > 1000)
			{
				ulong num3;
				num3 += num3;
				long num4 = (long)(num3 * (ulong)((uint)1000));
				num2 = (int)((long)num2 + num4);
			}
			IEnumerator enumerator = coin.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				bool flag;
				while (!flag)
				{
				}
			}
			int num5;
			if (num5 != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public CreateItem()
	{
	}

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	public static CreateItem Instance;
}
