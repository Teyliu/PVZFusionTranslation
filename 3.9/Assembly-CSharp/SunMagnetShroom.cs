using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DA RID: 1242
[Token(Token = "0x20004DA")]
public class SunMagnetShroom : Producer
{
	// Token: 0x06001768 RID: 5992 RVA: 0x00080158 File Offset: 0x0007E358
	[Token(Token = "0x6001768")]
	[Address(RVA = "0x4A1B90", Offset = "0x4A0190", VA = "0x1804A1B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00080178 File Offset: 0x0007E378
	[Token(Token = "0x6001769")]
	[Address(RVA = "0x516CF0", Offset = "0x5152F0", VA = "0x180516CF0", Slot = "39")]
	protected override void AttributeEvent()
	{
		IEnumerator enumerator = base.SunBright();
		Coroutine coroutine = base.StartCoroutine(enumerator);
		base.Invoke("AnimProduce", 0.5f);
		base.AttributeCountdown = 30f;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x000801B0 File Offset: 0x0007E3B0
	[Token(Token = "0x600176A")]
	[Address(RVA = "0x516D70", Offset = "0x515370", VA = "0x180516D70", Slot = "60")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		int num = 0;
		if (bucket != num)
		{
			global::UnityEngine.Object.Destroy(bucket.gameObject);
		}
		CreateItem instance = CreateItem.Instance;
		return true;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x000801E8 File Offset: 0x0007E3E8
	[Token(Token = "0x600176B")]
	[Address(RVA = "0x516680", Offset = "0x514C80", VA = "0x180516680", Slot = "71")]
	protected virtual void AnimProduce()
	{
		int num;
		do
		{
			List<BucketType> list = new List();
			int size = list._size;
			num = 0;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			int size6 = list._size;
			int num2 = list._size;
			num2 = global::UnityEngine.Random.Range(0, num2);
			BucketType bucketType = list[num2];
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num3 = this.thePlantColumn;
			num3++;
			int thePlantRow = this.thePlantRow;
			List<Plant> list2 = Lawnf.Get1x1Plants(num3, thePlantRow);
			bool flag;
			if (flag)
			{
				if (flag)
				{
				}
				while (!flag)
				{
				}
				ItemManager itemManager = GameAPP.itemManager;
				bool flag2 = "{il2cpp field on {'constant65' (constant value of type Cpp2IL.Core.Analysis.Il2CppClassIdentifier)}, offset 0xFFFFFFFFFFFFFFF8}" == typeof(HypnoMagnet).TypeHandle;
			}
		}
		while (num != 0);
		ItemManager itemManager2 = GameAPP.itemManager;
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x000802D4 File Offset: 0x0007E4D4
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public SunMagnetShroom()
	{
	}
}
