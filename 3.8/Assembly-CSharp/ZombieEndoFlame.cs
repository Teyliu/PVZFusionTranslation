using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004A0 RID: 1184
[Token(Token = "0x20004A0")]
public class ZombieEndoFlame : Plant
{
	// Token: 0x0600162C RID: 5676 RVA: 0x0007ACC4 File Offset: 0x00078EC4
	[Token(Token = "0x600162C")]
	[Address(RVA = "0x44D3D0", Offset = "0x44B9D0", VA = "0x18044D3D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0007ACE4 File Offset: 0x00078EE4
	[Token(Token = "0x600162D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "26")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0007ACF4 File Offset: 0x00078EF4
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "27")]
	public override void GetShield(float value)
	{
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0007AD04 File Offset: 0x00078F04
	[Token(Token = "0x600162F")]
	[Address(RVA = "0x4AE420", Offset = "0x4ACA20", VA = "0x1804AE420", Slot = "40")]
	protected override void AttributeEvent()
	{
		List<ZombieType> list = this.zombieTypes;
		CreateZombie instance = CreateZombie.Instance;
		int num = list._size;
		num = global::UnityEngine.Random.Range(0, num);
		ZombieType zombieType = list[num];
		Transform axis = this.axis;
		Transform shoot = this.shoot;
		ParticleManager instance2 = ParticleManager.Instance;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance2.SetParticle((ParticleType)((uint)11), num2, thePlantRow, num4 != 0UL, (float)num3);
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x0007AD80 File Offset: 0x00078F80
	[Token(Token = "0x6001630")]
	[Address(RVA = "0x4AEAA0", Offset = "0x4AD0A0", VA = "0x1804AEAA0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(48, 0.5f, 1f);
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x0007ADCC File Offset: 0x00078FCC
	[Token(Token = "0x6001631")]
	[Address(RVA = "0x4AE7A0", Offset = "0x4ACDA0", VA = "0x1804AE7A0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				uint num3;
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num3, (int)num4), 0.5f, 1f);
				num4 += num4;
				base.FlashOnce();
				Vector3 vector2;
				float z2 = vector2.z;
			}
			num++;
		}
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x0007AE4C File Offset: 0x0007904C
	[Token(Token = "0x6001632")]
	[Address(RVA = "0x4AEB80", Offset = "0x4AD180", VA = "0x1804AEB80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x0007AE5C File Offset: 0x0007905C
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x4AE5C0", Offset = "0x4ACBC0", VA = "0x1804AE5C0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		this.AttributeEvent();
		Board board = this.board;
		Transform axis = this.axis;
		GameObject gameObject = this.zombieFertilize;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001634 RID: 5684 RVA: 0x0007AEB4 File Offset: 0x000790B4
	[Token(Token = "0x6001634")]
	[Address(RVA = "0x4AEBA0", Offset = "0x4AD1A0", VA = "0x1804AEBA0")]
	public ZombieEndoFlame()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		int size14 = list._size;
		int size15 = list._size;
		this.zombieTypes = list;
		base..ctor();
	}

	// Token: 0x04000D73 RID: 3443
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D73")]
	public GameObject zombieFertilize;

	// Token: 0x04000D74 RID: 3444
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000D74")]
	private readonly List<ZombieType> zombieTypes;
}
