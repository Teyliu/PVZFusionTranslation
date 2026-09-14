using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000434 RID: 1076
[Token(Token = "0x2000434")]
public class StarSquash : Squash
{
	// Token: 0x060013DE RID: 5086 RVA: 0x0006F71C File Offset: 0x0006D91C
	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x46F540", Offset = "0x46DB40", VA = "0x18046F540", Slot = "73")]
	protected override void AttackZombie()
	{
		int num = 0;
		base.AttackZombie();
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
		LayerMask zombieLayer2 = this.zombieLayer;
		Collider2D[] array2;
		if (num < array2.Length)
		{
			bool flag2;
			if (flag2)
			{
				PlantType thePlantType2 = this.thePlantType;
			}
			num++;
		}
		LayerMask zombieLayer3 = this.zombieLayer;
		Collider2D[] array3;
		if (num < array3.Length)
		{
			bool flag3;
			if (flag3)
			{
				PlantType thePlantType3 = this.thePlantType;
			}
			num++;
		}
		LayerMask zombieLayer4 = this.zombieLayer;
		Collider2D[] array4;
		if (num < array4.Length)
		{
			bool flag4;
			if (flag4)
			{
				PlantType thePlantType4 = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0006F7F0 File Offset: 0x0006D9F0
	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x46FCC0", Offset = "0x46E2C0", VA = "0x18046FCC0")]
	private void OnDrawGizmos()
	{
		Transform transform = base.transform;
		Transform transform2 = transform.Find("Shadow");
		Vector3 position = transform.position;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0006F82C File Offset: 0x0006DA2C
	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public StarSquash()
	{
	}
}
