using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000822 RID: 2082
[Token(Token = "0x2000822")]
public class IZZombieLibrary : MonoBehaviour
{
	// Token: 0x06002A81 RID: 10881 RVA: 0x000E5E28 File Offset: 0x000E4028
	[Token(Token = "0x6002A81")]
	[Address(RVA = "0x69F2A0", Offset = "0x69D8A0", VA = "0x18069F2A0")]
	private void Awake()
	{
		this.InitCards();
	}

	// Token: 0x06002A82 RID: 10882 RVA: 0x000E5E3C File Offset: 0x000E403C
	[Token(Token = "0x6002A82")]
	[Address(RVA = "0x69FA20", Offset = "0x69E020", VA = "0x18069FA20")]
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

	// Token: 0x06002A83 RID: 10883 RVA: 0x000E5F40 File Offset: 0x000E4140
	[Token(Token = "0x6002A83")]
	[Address(RVA = "0x69F2B0", Offset = "0x69D8B0", VA = "0x18069F2B0")]
	public List<ZombieType> GetZombieTypes()
	{
		return new List();
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x000E5FC4 File Offset: 0x000E41C4
	[Token(Token = "0x6002A84")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public IZZombieLibrary()
	{
	}

	// Token: 0x0400186C RID: 6252
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400186C")]
	public Transform grids;

	// Token: 0x0400186D RID: 6253
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400186D")]
	public GameObject page1;
}
