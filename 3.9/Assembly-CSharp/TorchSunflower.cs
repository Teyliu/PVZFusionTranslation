using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DD RID: 1245
[Token(Token = "0x20004DD")]
public class TorchSunflower : Producer
{
	// Token: 0x06001779 RID: 6009 RVA: 0x00080594 File Offset: 0x0007E794
	[Token(Token = "0x6001779")]
	[Address(RVA = "0x5175D0", Offset = "0x515BD0", VA = "0x1805175D0", Slot = "69")]
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

	// Token: 0x0600177A RID: 6010 RVA: 0x00080640 File Offset: 0x0007E840
	[Token(Token = "0x600177A")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public TorchSunflower()
	{
	}
}
