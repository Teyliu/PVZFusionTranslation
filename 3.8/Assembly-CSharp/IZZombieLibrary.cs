using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007E7 RID: 2023
[Token(Token = "0x20007E7")]
public class IZZombieLibrary : MonoBehaviour
{
	// Token: 0x0600294B RID: 10571 RVA: 0x000E0CE8 File Offset: 0x000DEEE8
	[Token(Token = "0x600294B")]
	[Address(RVA = "0x63AD30", Offset = "0x639330", VA = "0x18063AD30")]
	private void Awake()
	{
		this.InitCards();
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000E0CFC File Offset: 0x000DEEFC
	[Token(Token = "0x600294C")]
	[Address(RVA = "0x63B4B0", Offset = "0x639AB0", VA = "0x18063B4B0")]
	private void InitCards()
	{
		List<ZombieType> zombieTypes = this.GetZombieTypes();
		List<GameObject> list = new List();
		int num = 0;
		GameObject gameObject = this.page1;
		Transform parent = gameObject.transform.parent;
		GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, parent);
		int num2;
		string text = string.Format("ZombieCardPage_{0}", num2);
		gameObject2.name = text;
		int size = list._size;
		list._size = text;
		int num3 = zombieTypes._size;
		num3 -= num;
		if (num3 > 63)
		{
		}
		if (num3 > 0)
		{
			int num4 = zombieTypes[0];
			ZombieCardPackage zombieCardPackage;
			Transform transform = zombieCardPackage.transform;
			Transform transform2 = gameObject2.transform;
			transform.parentInternal = transform2;
			Transform transform3 = zombieCardPackage.transform;
			IZECard card = zombieCardPackage.card;
			Dictionary<ZombieType, ZombieDataManager.ZombieData> zombieDataDic = ZombieDataManager.zombieDataDic;
			ZombieDataManager.ZombieData zombieData;
			int cost = zombieData.cost;
			num++;
			card.theSeedCost = cost;
		}
		num += 63;
		num++;
		GameObject gameObject3 = list[num];
		bool flag = num == 0;
		gameObject3.SetActive(flag);
		num++;
		global::UnityEngine.Object.Destroy(this.page1);
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000E0E00 File Offset: 0x000DF000
	[Token(Token = "0x600294D")]
	[Address(RVA = "0x63AD40", Offset = "0x639340", VA = "0x18063AD40")]
	public List<ZombieType> GetZombieTypes()
	{
		return new List();
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x000E0E84 File Offset: 0x000DF084
	[Token(Token = "0x600294E")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public IZZombieLibrary()
	{
	}

	// Token: 0x04001783 RID: 6019
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001783")]
	public Transform grids;

	// Token: 0x04001784 RID: 6020
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001784")]
	public GameObject page1;
}
