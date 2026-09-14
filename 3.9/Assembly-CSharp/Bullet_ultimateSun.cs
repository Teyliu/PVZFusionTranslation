using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[Token(Token = "0x20001D3")]
public class Bullet_ultimateSun : Bullet_pierce
{
	// Token: 0x060007F2 RID: 2034 RVA: 0x00028528 File Offset: 0x00026728
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x6E6350", Offset = "0x6E4950", VA = "0x1806E6350", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)1L);
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00028540 File Offset: 0x00026740
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x817C80", Offset = "0x816280", VA = "0x180817C80")]
	private void Explode(Vector2 center, int damage, float range = 1.5f)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				PlantType fromType = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x060007F4 RID: 2036 RVA: 0x0002858C File Offset: 0x0002678C
	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x817FC0", Offset = "0x8165C0", VA = "0x180817FC0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		int mask = LayerMask.GetMask(new string[] { "Bullet" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				uint num2;
				Transform transform3 = num2.transform;
				transform3 += transform3;
				base.Die();
			}
			num++;
		}
		CreateItem instance = CreateItem.Instance;
		Transform transform4 = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num3;
		GameAPP.PlaySound((int)num3, 0.2f, 1f);
	}

	// Token: 0x060007F5 RID: 2037 RVA: 0x00028634 File Offset: 0x00026834
	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x817E50", Offset = "0x816450", VA = "0x180817E50", Slot = "17")]
	public override void HitLand()
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x060007F6 RID: 2038 RVA: 0x00028678 File Offset: 0x00026878
	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x817C30", Offset = "0x816230", VA = "0x180817C30", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform child = base.transform.GetChild(1);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060007F7 RID: 2039 RVA: 0x000286A4 File Offset: 0x000268A4
	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x818420", Offset = "0x816A20", VA = "0x180818420", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060007F8 RID: 2040 RVA: 0x000286D4 File Offset: 0x000268D4
	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_ultimateSun()
	{
	}

	// Token: 0x040003BD RID: 957
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40003BD")]
	private Transform tail;
}
