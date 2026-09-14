using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000513 RID: 1299
[Token(Token = "0x2000513")]
public class IceGloom : GloomShroom
{
	// Token: 0x06001838 RID: 6200 RVA: 0x00083800 File Offset: 0x00081A00
	[Token(Token = "0x6001838")]
	[Address(RVA = "0x4CEEC0", Offset = "0x4CD4C0", VA = "0x1804CEEC0", Slot = "73")]
	protected override void AttackZombie()
	{
		GameObject center = this.center;
		int num = 0;
		int num2 = 0;
		Transform transform = center.transform;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && base.SearchUniqueZombie(num))
			{
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x00083878 File Offset: 0x00081A78
	[Token(Token = "0x6001839")]
	[Address(RVA = "0x4CF130", Offset = "0x4CD730", VA = "0x1804CF130", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x000838A8 File Offset: 0x00081AA8
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x4C8390", Offset = "0x4C6990", VA = "0x1804C8390")]
	public IceGloom()
	{
		this.range = 2f;
		this.maxRow = (int)((ulong)1L);
		base..ctor();
	}
}
