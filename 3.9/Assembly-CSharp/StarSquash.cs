using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000453 RID: 1107
[Token(Token = "0x2000453")]
public class StarSquash : Squash
{
	// Token: 0x06001468 RID: 5224 RVA: 0x000719C8 File Offset: 0x0006FBC8
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x4C6D90", Offset = "0x4C5390", VA = "0x1804C6D90", Slot = "72")]
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

	// Token: 0x06001469 RID: 5225 RVA: 0x00071A9C File Offset: 0x0006FC9C
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x4C7510", Offset = "0x4C5B10", VA = "0x1804C7510")]
	private void OnDrawGizmos()
	{
		Transform transform = base.transform;
		Transform transform2 = transform.Find("Shadow");
		Vector3 position = transform.position;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600146A RID: 5226 RVA: 0x00071AD8 File Offset: 0x0006FCD8
	[Token(Token = "0x600146A")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public StarSquash()
	{
	}
}
