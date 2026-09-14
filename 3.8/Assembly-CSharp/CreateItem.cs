using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using ZenGarden;

// Token: 0x02000209 RID: 521
[Token(Token = "0x2000209")]
public class CreateItem : MonoBehaviour
{
	// Token: 0x060008CD RID: 2253 RVA: 0x0002DDA8 File Offset: 0x0002BFA8
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x858800", Offset = "0x856E00", VA = "0x180858800")]
	private void Awake()
	{
		CreateItem.Instance = this;
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x0002DDBC File Offset: 0x0002BFBC
	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x858FE0", Offset = "0x8575E0", VA = "0x180858FE0")]
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

	// Token: 0x060008CF RID: 2255 RVA: 0x0002DE0C File Offset: 0x0002C00C
	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x858880", Offset = "0x856E80", VA = "0x180858880")]
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

	// Token: 0x060008D0 RID: 2256 RVA: 0x0002DF1C File Offset: 0x0002C11C
	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x858860", Offset = "0x856E60", VA = "0x180858860")]
	private bool LimSet(int theCoinType)
	{
		if (theCoinType <= 2 || theCoinType != 13)
		{
		}
		return true;
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x0002DF38 File Offset: 0x0002C138
	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x858D20", Offset = "0x857320", VA = "0x180858D20")]
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

	// Token: 0x060008D2 RID: 2258 RVA: 0x0002DFC4 File Offset: 0x0002C1C4
	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public CreateItem()
	{
	}

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	public static CreateItem Instance;
}
