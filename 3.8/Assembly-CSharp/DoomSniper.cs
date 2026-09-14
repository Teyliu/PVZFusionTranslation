using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
[Token(Token = "0x20004E5")]
public class DoomSniper : Shooter
{
	// Token: 0x0600178E RID: 6030 RVA: 0x00080C94 File Offset: 0x0007EE94
	[Token(Token = "0x600178E")]
	[Address(RVA = "0x4A2060", Offset = "0x4A0660", VA = "0x1804A2060", Slot = "44")]
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
				if (num != num2)
				{
					float vision = this.vision;
					Transform shoot = this.shoot;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
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

	// Token: 0x0600178F RID: 6031 RVA: 0x00080D08 File Offset: 0x0007EF08
	[Token(Token = "0x600178F")]
	[Address(RVA = "0x4A28B0", Offset = "0x4A0EB0", VA = "0x1804A28B0", Slot = "46")]
	protected override void UpdateAttackCountDown()
	{
		float num = this.crazeTimer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.crazeTimer = num;
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			float deltaTime2 = Time.deltaTime;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
			this.crazeTimer = 0f;
		}
		base.UpdateAttackCountDown();
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x00080D5C File Offset: 0x0007EF5C
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A08A0", VA = "0x1804A22A0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = 0;
		float num2 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, num2);
		Transform shoot = this.shoot;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		ParticleManager instance = ParticleManager.Instance;
		Transform shoot2 = this.shoot;
		Vector3 vector2;
		float z2 = vector2.z;
		int num4 = 0;
		Zombie zombie;
		if (zombie != num4)
		{
			Collider2D col = zombie.col;
			Transform shoot3 = this.shoot;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform shoot4 = this.shoot;
			Vector3 vector4;
			float z4 = vector4.z;
			LayerMask zombieLayer = this.zombieLayer;
			Particle particle;
			Transform transform = particle.transform;
			int num5 = this.attackDamage;
			Quaternion quaternion;
			bool flag;
			if (quaternion == (ulong)5L || flag)
			{
				num5 += num5;
			}
			RaycastHit2D[] array;
			if (num < array.Length)
			{
				int num6 = 0;
				Collider2D collider2D;
				if (collider2D.TryGetComponent<Zombie>(num6) && Lawnf.InLandStatus(zombie.theStatus))
				{
					int num7 = 0;
					bool flag2;
					if (!flag2)
					{
					}
					num7 += num7;
					PlantType thePlantType = this.thePlantType;
					if (!flag2)
					{
					}
				}
				num++;
			}
			this.attributeCount = num;
			BoardAction boardAction = this.board.boardAction;
			int column = zombie.Column;
			PlantType thePlantType2 = this.thePlantType;
			this.crazeTimer = 8f;
			this.craze = num;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00080EB4 File Offset: 0x0007F0B4
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x4A1F60", Offset = "0x4A0560", VA = "0x1804A1F60")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (col != num && zombie.col.enabled)
			{
				Transform axis = zombie.axis;
				Transform shoot = this.shoot;
				return Lawnf.InLandStatus(zombie.theStatus);
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00080F10 File Offset: 0x0007F110
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public DoomSniper()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}

	// Token: 0x04000DC0 RID: 3520
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DC0")]
	private int craze;

	// Token: 0x04000DC1 RID: 3521
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000DC1")]
	private float crazeTimer;
}
