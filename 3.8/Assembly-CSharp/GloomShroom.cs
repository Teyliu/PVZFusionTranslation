using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FF RID: 1279
[Token(Token = "0x20004FF")]
public class GloomShroom : Shooter
{
	// Token: 0x060017DC RID: 6108 RVA: 0x00081EB4 File Offset: 0x000800B4
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x4C97D0", Offset = "0x4C7DD0", VA = "0x1804C97D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		GameObject gameObject = base.transform.Find("Shoot").gameObject;
		this.center = gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x060017DD RID: 6109 RVA: 0x00081EEC File Offset: 0x000800EC
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x4C9AB0", Offset = "0x4C80B0", VA = "0x1804C9AB0", Slot = "15")]
	protected override void Start()
	{
		if (Lawnf.EveBalaced())
		{
			this.thePlantMaxHealth = (int)((ulong)2000L);
			this.thePlantHealth = (int)((ulong)2000L);
		}
		base.Start();
	}

	// Token: 0x060017DE RID: 6110 RVA: 0x00081F24 File Offset: 0x00080124
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x4C9850", Offset = "0x4C7E50", VA = "0x1804C9850", Slot = "44")]
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

	// Token: 0x060017DF RID: 6111 RVA: 0x00081F78 File Offset: 0x00080178
	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "41")]
	protected override Zombie SearchBoss()
	{
		return null;
	}

	// Token: 0x060017E0 RID: 6112 RVA: 0x00081F88 File Offset: 0x00080188
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x4C9A20", Offset = "0x4C8020", VA = "0x1804C9A20", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = this.center.transform;
		Vector3 vector;
		float z = vector.z;
		this.AttackZombie();
		throw new NullReferenceException();
	}

	// Token: 0x060017E1 RID: 6113 RVA: 0x00081FB8 File Offset: 0x000801B8
	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x4C9580", Offset = "0x4C7B80", VA = "0x1804C9580", Slot = "73")]
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

	// Token: 0x060017E2 RID: 6114 RVA: 0x0008202C File Offset: 0x0008022C
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x4C8390", Offset = "0x4C6990", VA = "0x1804C8390")]
	public GloomShroom()
	{
	}

	// Token: 0x04000DCE RID: 3534
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DCE")]
	protected GameObject center;

	// Token: 0x04000DCF RID: 3535
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000DCF")]
	protected float range = 2f;

	// Token: 0x04000DD0 RID: 3536
	[FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000DD0")]
	protected int maxRow = (int)((ulong)1L);
}
