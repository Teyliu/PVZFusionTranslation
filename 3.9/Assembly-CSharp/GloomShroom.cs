using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200052A RID: 1322
[Token(Token = "0x200052A")]
public class GloomShroom : Shooter
{
	// Token: 0x060018A5 RID: 6309 RVA: 0x000856F4 File Offset: 0x000838F4
	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x525AF0", Offset = "0x5240F0", VA = "0x180525AF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		GameObject gameObject = base.transform.Find("Shoot").gameObject;
		this.center = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x0008572C File Offset: 0x0008392C
	[Token(Token = "0x60018A6")]
	[Address(RVA = "0x525DD0", Offset = "0x5243D0", VA = "0x180525DD0", Slot = "15")]
	protected override void Start()
	{
		if (Lawnf.EveBalaced())
		{
			this.thePlantMaxHealth = (int)((ulong)2000L);
			this.thePlantHealth = (int)((ulong)2000L);
		}
		base.Start();
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x00085764 File Offset: 0x00083964
	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x525B70", Offset = "0x524170", VA = "0x180525B70", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		GameObject gameObject = this.center;
		int num = 0;
		Transform transform = gameObject.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || !base.SearchUniqueZombie(num))
			{
				num++;
			}
			GameObject gameObject2;
			return gameObject2;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x000857B8 File Offset: 0x000839B8
	[Token(Token = "0x60018A8")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "40")]
	protected override Zombie SearchBoss()
	{
		return null;
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x000857C8 File Offset: 0x000839C8
	[Token(Token = "0x60018A9")]
	[Address(RVA = "0x525D40", Offset = "0x524340", VA = "0x180525D40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x000857F8 File Offset: 0x000839F8
	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x5258A0", Offset = "0x523EA0", VA = "0x1805258A0", Slot = "72")]
	protected virtual void AttackZombie()
	{
		GameObject gameObject = this.center;
		int num = 0;
		int num2 = 0;
		Transform transform = gameObject.transform;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && base.AttackLandZombie(num))
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

	// Token: 0x060018AB RID: 6315 RVA: 0x0008586C File Offset: 0x00083A6C
	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x5236D0", Offset = "0x521CD0", VA = "0x1805236D0")]
	public GloomShroom()
	{
	}

	// Token: 0x04000E7D RID: 3709
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E7D")]
	protected GameObject center;

	// Token: 0x04000E7E RID: 3710
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E7E")]
	protected float range = 2f;

	// Token: 0x04000E7F RID: 3711
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000E7F")]
	protected int maxRow = (int)((ulong)1L);
}
