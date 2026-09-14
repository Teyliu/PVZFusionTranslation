using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003AC RID: 940
[Token(Token = "0x20003AC")]
public class IceCaltrop : Caltrop
{
	// Token: 0x0600113D RID: 4413 RVA: 0x00062228 File Offset: 0x00060428
	[Token(Token = "0x600113D")]
	[Address(RVA = "0x43E4E0", Offset = "0x43CAE0", VA = "0x18043E4E0", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		base.KillCar();
		Transform axis = this.axis;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00062298 File Offset: 0x00060498
	[Token(Token = "0x600113E")]
	[Address(RVA = "0x400D00", Offset = "0x3FF300", VA = "0x180400D00")]
	public IceCaltrop()
	{
	}
}
