using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E0 RID: 736
[Token(Token = "0x20002E0")]
public class TimeBomb : MonoBehaviour
{
	// Token: 0x06000D34 RID: 3380 RVA: 0x0004C63C File Offset: 0x0004A83C
	[Token(Token = "0x6000D34")]
	[Address(RVA = "0x3FD8E0", Offset = "0x3FBEE0", VA = "0x1803FD8E0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x0004C658 File Offset: 0x0004A858
	[Token(Token = "0x6000D35")]
	[Address(RVA = "0x3FD9A0", Offset = "0x3FBFA0", VA = "0x1803FD9A0")]
	private void Update()
	{
		Zombie zombie = this.zombie;
		int num = 0;
		if (zombie != num && this.zombie.theStatus != ZombieStatus.Dying)
		{
			float deltaTime = Time.deltaTime;
			this.timer = deltaTime;
			if (deltaTime <= 6f)
			{
				return;
			}
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num2 < array.Length)
			{
				bool flag;
				if (flag)
				{
					Zombie zombie2 = this.zombie;
					bool flag2;
					if (flag2)
					{
						PlantType plantType = this.fromType;
					}
				}
				num3++;
			}
			ParticleManager instance = ParticleManager.Instance;
			Transform transform2 = base.transform;
			Zombie zombie3 = this.zombie;
			uint num4;
			GameAPP.PlaySound((int)num4, 0.2f, 1f);
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0004C74C File Offset: 0x0004A94C
	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x3FD930", Offset = "0x3FBF30", VA = "0x1803FD930")]
	public void Charge(int fromDamage)
	{
		this.anim.SetTrigger("charge");
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x0004C770 File Offset: 0x0004A970
	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TimeBomb()
	{
	}

	// Token: 0x04000965 RID: 2405
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000965")]
	public PlantType fromType;

	// Token: 0x04000966 RID: 2406
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000966")]
	public Zombie zombie;

	// Token: 0x04000967 RID: 2407
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000967")]
	public int damage;

	// Token: 0x04000968 RID: 2408
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000968")]
	private Animator anim;

	// Token: 0x04000969 RID: 2409
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000969")]
	private float timer;
}
