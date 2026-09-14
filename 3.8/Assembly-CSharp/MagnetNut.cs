using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003DE RID: 990
[Token(Token = "0x20003DE")]
public class MagnetNut : WallNut
{
	// Token: 0x0600123F RID: 4671 RVA: 0x00066AD8 File Offset: 0x00064CD8
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x450220", Offset = "0x44E820", VA = "0x180450220", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (base.Active)
		{
			List<Bullet> list = this.bullets;
			this.SearchBullet();
			return;
		}
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00066B0C File Offset: 0x00064D0C
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x450290", Offset = "0x44E890", VA = "0x180450290")]
	private void SearchBullet()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		LayerMask bulletLayer = this.bulletLayer;
		int num2 = 0;
		int num3 = bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (num2 == 0 || 18446744073709551612UL <= (ulong)1L || num2 == 24)
				{
					List<Bullet> list = this.bullets;
					Transform axis = this.axis;
					Vector3 vector2;
					float z2 = vector2.z;
					Vector3 vector3;
					float z3 = vector3.z;
					Vector3 vector4;
					float z4 = vector4.z;
				}
			}
			num++;
		}
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00066B9C File Offset: 0x00064D9C
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x4500D0", Offset = "0x44E6D0", VA = "0x1804500D0", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Bullet> list = this.bullets;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00066BD8 File Offset: 0x00064DD8
	[Token(Token = "0x6001242")]
	[Address(RVA = "0x450680", Offset = "0x44EC80", VA = "0x180450680", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			int size = this.bullets._size;
			int num = size - 1;
			if (size > 0)
			{
				int num2 = 0;
				Bullet bullet = this.bullets[num];
				int num3 = 0;
				if (bullet != num3 && !bullet.hit)
				{
					Transform axis = this.axis;
					float deltaTime = Time.deltaTime;
					Transform transform = bullet.transform;
					Transform transform2 = bullet.transform;
					float deltaTime2 = Time.deltaTime;
					if (num2 > (int)deltaTime2 || deltaTime2 > 1f)
					{
					}
					bullet.magnetNutAngle = deltaTime;
				}
				this.bullets.RemoveAt(num);
			}
		}
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00066C8C File Offset: 0x00064E8C
	[Token(Token = "0x6001243")]
	[Address(RVA = "0x4509E0", Offset = "0x44EFE0", VA = "0x1804509E0")]
	public MagnetNut()
	{
		List<Bullet> list = new List();
		this.bullets = list;
		this.R = 2f;
		this.V = 3f;
		base..ctor();
	}

	// Token: 0x04000C04 RID: 3076
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C04")]
	private readonly List<Bullet> bullets;

	// Token: 0x04000C05 RID: 3077
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000C05")]
	private readonly float R;

	// Token: 0x04000C06 RID: 3078
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x4000C06")]
	private readonly float V;
}
