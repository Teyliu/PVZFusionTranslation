using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003BA RID: 954
[Token(Token = "0x20003BA")]
public class IceSquash : Squash
{
	// Token: 0x0600117A RID: 4474 RVA: 0x000631D0 File Offset: 0x000613D0
	[Token(Token = "0x600117A")]
	[Address(RVA = "0x444410", Offset = "0x442A10", VA = "0x180444410", Slot = "73")]
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

	// Token: 0x0600117B RID: 4475 RVA: 0x00063234 File Offset: 0x00061434
	[Token(Token = "0x600117B")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public IceSquash()
	{
	}
}
