using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004B9 RID: 1209
[Token(Token = "0x20004B9")]
public class TorchSunflower : Producer
{
	// Token: 0x060016CF RID: 5839 RVA: 0x0007D930 File Offset: 0x0007BB30
	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x4AB9A0", Offset = "0x4A9FA0", VA = "0x1804AB9A0", Slot = "70")]
	protected override void ProduceSun()
	{
		Transform shoot = this.shoot;
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		int num3 = 0;
		CreateItem instance = CreateItem.Instance;
		int num4 = 0;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		GameObject gameObject = instance.SetCoin(thePlantColumn, thePlantRow, num4, num, num3, num3 != 0);
		Transform shoot2 = this.shoot;
		LayerMask bulletLayer = this.bulletLayer;
		int num5 = bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				CreateItem instance2 = CreateItem.Instance;
				Vector3 vector;
				float z = vector.z;
			}
			num++;
		}
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0007D9DC File Offset: 0x0007BBDC
	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public TorchSunflower()
	{
	}
}
