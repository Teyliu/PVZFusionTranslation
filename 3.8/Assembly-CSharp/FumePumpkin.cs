using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200038D RID: 909
[Token(Token = "0x200038D")]
public class FumePumpkin : Pumpkin
{
	// Token: 0x060010B6 RID: 4278 RVA: 0x0005F9B8 File Offset: 0x0005DBB8
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x4362C0", Offset = "0x4348C0", VA = "0x1804362C0")]
	private void AnimPreShoot()
	{
		GameAPP.PlaySound(58, 0.5f, 1f);
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Transform transform = instance.SetParticle((ParticleType)((uint)130), num, 11, num3 != 0UL, (float)num2).transform;
		Transform shoot2 = this.shoot;
		ParticleManager instance2 = ParticleManager.Instance;
		int num4 = 0;
		Vector3 vector2;
		float z2 = vector2.z;
		ulong num5;
		Transform transform2 = instance2.SetParticle((ParticleType)((uint)130), num4, 11, num5 != 0UL, (float)num2).transform;
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x0005FA48 File Offset: 0x0005DC48
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x436510", Offset = "0x434B10", VA = "0x180436510")]
	private void AnimShoot()
	{
		Board board = this.board;
		int num = 0;
		int size = board.zombieArray._size;
		int num2 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num2];
			int num3 = 0;
			if (zombie != num3)
			{
				int column = zombie.Column;
				if (base.SearchUniqueZombie(zombie))
				{
					PlantType thePlantType = this.thePlantType;
				}
			}
			if (num != 0)
			{
				uint num4;
				GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
			}
		}
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x401130", Offset = "0x3FF730", VA = "0x180401130", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0005FAF0 File Offset: 0x0005DCF0
	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x4366E0", Offset = "0x434CE0", VA = "0x1804366E0", Slot = "44")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2 && base.SearchUniqueZombie(num))
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0005FB44 File Offset: 0x0005DD44
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public FumePumpkin()
	{
	}
}
