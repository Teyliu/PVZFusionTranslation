using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B6 RID: 1206
[Token(Token = "0x20004B6")]
public class SunMagnetShroom : Producer
{
	// Token: 0x060016BF RID: 5823 RVA: 0x0007D500 File Offset: 0x0007B700
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x44D3D0", Offset = "0x44B9D0", VA = "0x18044D3D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x0007D520 File Offset: 0x0007B720
	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x4AB0C0", Offset = "0x4A96C0", VA = "0x1804AB0C0", Slot = "40")]
	protected override void AttributeEvent()
	{
		IEnumerator enumerator = base.SunBright();
		Coroutine coroutine = base.StartCoroutine(enumerator);
		base.Invoke("AnimProduce", 0.5f);
		base.AttributeCountdown = 30f;
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x0007D558 File Offset: 0x0007B758
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x4AB140", Offset = "0x4A9740", VA = "0x1804AB140", Slot = "61")]
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

	// Token: 0x060016C2 RID: 5826 RVA: 0x0007D590 File Offset: 0x0007B790
	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x4AAA50", Offset = "0x4A9050", VA = "0x1804AAA50", Slot = "72")]
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

	// Token: 0x060016C3 RID: 5827 RVA: 0x0007D67C File Offset: 0x0007B87C
	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public SunMagnetShroom()
	{
	}
}
