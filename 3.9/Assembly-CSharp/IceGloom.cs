using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053E RID: 1342
[Token(Token = "0x200053E")]
public class IceGloom : GloomShroom
{
	// Token: 0x06001901 RID: 6401 RVA: 0x00087050 File Offset: 0x00085250
	[Token(Token = "0x6001901")]
	[Address(RVA = "0x52B280", Offset = "0x529880", VA = "0x18052B280", Slot = "72")]
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

	// Token: 0x06001902 RID: 6402 RVA: 0x000870C8 File Offset: 0x000852C8
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x52B4F0", Offset = "0x529AF0", VA = "0x18052B4F0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x06001903 RID: 6403 RVA: 0x000870F8 File Offset: 0x000852F8
	[Token(Token = "0x6001903")]
	[Address(RVA = "0x5236D0", Offset = "0x521CD0", VA = "0x1805236D0")]
	public IceGloom()
	{
		this.range = 2f;
		this.maxRow = (int)((ulong)1L);
		base..ctor();
	}
}
