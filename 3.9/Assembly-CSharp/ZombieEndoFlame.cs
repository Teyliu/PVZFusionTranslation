using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004C2 RID: 1218
[Token(Token = "0x20004C2")]
public class ZombieEndoFlame : Plant
{
	// Token: 0x060016CC RID: 5836 RVA: 0x0007D740 File Offset: 0x0007B940
	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x4A1B90", Offset = "0x4A0190", VA = "0x1804A1B90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 10f;
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0007D760 File Offset: 0x0007B960
	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "25")]
	public override void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0007D770 File Offset: 0x0007B970
	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "26")]
	public override void GetShield(float value)
	{
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0007D780 File Offset: 0x0007B980
	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x51CBF0", Offset = "0x51B1F0", VA = "0x18051CBF0", Slot = "39")]
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

	// Token: 0x060016D0 RID: 5840 RVA: 0x0007D7FC File Offset: 0x0007B9FC
	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x51D270", Offset = "0x51B870", VA = "0x18051D270", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(48, 0.5f, 1f);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0007D848 File Offset: 0x0007BA48
	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x51CF70", Offset = "0x51B570", VA = "0x18051CF70", Slot = "17")]
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

	// Token: 0x060016D2 RID: 5842 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x51D350", Offset = "0x51B950", VA = "0x18051D350", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x0007D8D8 File Offset: 0x0007BAD8
	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x51CD90", Offset = "0x51B390", VA = "0x18051CD90", Slot = "51")]
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

	// Token: 0x060016D4 RID: 5844 RVA: 0x0007D930 File Offset: 0x0007BB30
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x51D370", Offset = "0x51B970", VA = "0x18051D370")]
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

	// Token: 0x04000E0C RID: 3596
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E0C")]
	public GameObject zombieFertilize;

	// Token: 0x04000E0D RID: 3597
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E0D")]
	private readonly List<ZombieType> zombieTypes;
}
