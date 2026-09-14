using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003CE RID: 974
[Token(Token = "0x20003CE")]
public class IceSquash : Squash
{
	// Token: 0x060011D6 RID: 4566 RVA: 0x000647F0 File Offset: 0x000629F0
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x496360", Offset = "0x494960", VA = "0x180496360", Slot = "72")]
	protected override void AttackZombie()
	{
		int num = 0;
		base.AttackZombie();
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType thePlantType = this.thePlantType;
					num2 += num2;
				}
			}
			num++;
		}
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00064854 File Offset: 0x00062A54
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public IceSquash()
	{
	}
}
