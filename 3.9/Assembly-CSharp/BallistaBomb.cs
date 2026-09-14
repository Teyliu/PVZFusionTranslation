using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002B0 RID: 688
[Token(Token = "0x20002B0")]
public class BallistaBomb : MonoBehaviour
{
	// Token: 0x06000C18 RID: 3096 RVA: 0x00044964 File Offset: 0x00042B64
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x419240", Offset = "0x417840", VA = "0x180419240")]
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

	// Token: 0x06000C19 RID: 3097 RVA: 0x000449B0 File Offset: 0x00042BB0
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x418F00", Offset = "0x417500", VA = "0x180418F00")]
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
				if (zombie.takeDmgMultiplier == 0f)
				{
				}
				throw new NullReferenceException();
			}
			uint num7;
			GameAPP.PlaySound((int)num7, 0.2f, 1f);
		}
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x00044A6C File Offset: 0x00042C6C
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public BallistaBomb()
	{
	}

	// Token: 0x040007FE RID: 2046
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007FE")]
	public PlantType fromType;

	// Token: 0x040007FF RID: 2047
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007FF")]
	public float timer;

	// Token: 0x04000800 RID: 2048
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000800")]
	public Zombie zombie;

	// Token: 0x04000801 RID: 2049
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000801")]
	public int damage;

	// Token: 0x04000802 RID: 2050
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000802")]
	public ParticleType particleType;
}
