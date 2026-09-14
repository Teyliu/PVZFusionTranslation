using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002EE RID: 750
[Token(Token = "0x20002EE")]
public class TimeBomb : MonoBehaviour
{
	// Token: 0x06000D77 RID: 3447 RVA: 0x0004D29C File Offset: 0x0004B49C
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x441260", Offset = "0x43F860", VA = "0x180441260")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x0004D2B8 File Offset: 0x0004B4B8
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x441320", Offset = "0x43F920", VA = "0x180441320")]
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

	// Token: 0x06000D79 RID: 3449 RVA: 0x0004D3AC File Offset: 0x0004B5AC
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x4412B0", Offset = "0x43F8B0", VA = "0x1804412B0")]
	public void Charge(int fromDamage)
	{
		this.anim.SetTrigger("charge");
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TimeBomb()
	{
	}

	// Token: 0x040009A2 RID: 2466
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A2")]
	public PlantType fromType;

	// Token: 0x040009A3 RID: 2467
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009A3")]
	public Zombie zombie;

	// Token: 0x040009A4 RID: 2468
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009A4")]
	public int damage;

	// Token: 0x040009A5 RID: 2469
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009A5")]
	private Animator anim;

	// Token: 0x040009A6 RID: 2470
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009A6")]
	private float timer;
}
