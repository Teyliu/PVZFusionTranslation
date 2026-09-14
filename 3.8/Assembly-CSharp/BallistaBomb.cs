using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
public class BallistaBomb : MonoBehaviour
{
	// Token: 0x06000BF0 RID: 3056 RVA: 0x00044678 File Offset: 0x00042878
	[Token(Token = "0x6000BF0")]
	[Address(RVA = "0x3CC3C0", Offset = "0x3CA9C0", VA = "0x1803CC3C0")]
	private void Update()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			int num3 = this.damage;
			Zombie zombie = this.zombie;
			this.ExplodeAction(zombie, num3);
			global::UnityEngine.Object.Destroy(this);
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x000446C4 File Offset: 0x000428C4
	[Token(Token = "0x6000BF1")]
	[Address(RVA = "0x3CC080", Offset = "0x3CA680", VA = "0x1803CC080")]
	private void ExplodeAction(Zombie zombie, int damage)
	{
		int num = 0;
		int num2 = 0;
		if (zombie != num2)
		{
			Transform axis = zombie.axis;
			int num3 = 0;
			int num4 = 0;
			ParticleManager instance = ParticleManager.Instance;
			ParticleType particleType = this.particleType;
			uint num5;
			ulong num6;
			Particle particle = instance.SetParticle(particleType, num3, (int)num5, num6 != 0UL, (float)num4);
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag && Lawnf.InLandStatus((ZombieStatus)num))
				{
					PlantType plantType = this.fromType;
				}
				num++;
			}
			if (this.particleType == ParticleType.BombCloud_vision_water)
			{
				if (zombie.read == 0)
				{
				}
				throw new NullReferenceException();
			}
			uint num7;
			GameAPP.PlaySound((int)num7, 0.2f, 1f);
		}
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0004477C File Offset: 0x0004297C
	[Token(Token = "0x6000BF2")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public BallistaBomb()
	{
	}

	// Token: 0x040007E0 RID: 2016
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007E0")]
	public PlantType fromType;

	// Token: 0x040007E1 RID: 2017
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007E1")]
	public float timer;

	// Token: 0x040007E2 RID: 2018
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007E2")]
	public Zombie zombie;

	// Token: 0x040007E3 RID: 2019
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40007E3")]
	public int damage;

	// Token: 0x040007E4 RID: 2020
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007E4")]
	public ParticleType particleType;
}
