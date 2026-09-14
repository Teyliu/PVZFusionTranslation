using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002EB RID: 747
[Token(Token = "0x20002EB")]
public class SubMelon : MonoBehaviour
{
	// Token: 0x06000D64 RID: 3428 RVA: 0x0004C858 File Offset: 0x0004AA58
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x43FB20", Offset = "0x43E120", VA = "0x18043FB20")]
	private void Start()
	{
		this.SetTarget();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)14)))
		{
			int num = this.damage;
			this.damage = num;
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0004C884 File Offset: 0x0004AA84
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x43FBC0", Offset = "0x43E1C0", VA = "0x18043FBC0")]
	private void Update()
	{
		if (!this.isDouble)
		{
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
			float deltaTime = Time.deltaTime;
			Transform transform3 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Transform transform4 = base.transform;
			Vector2 vector3 = this.targetPosition;
			this.Die();
		}
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x0004C8EC File Offset: 0x0004AAEC
	[Token(Token = "0x6000D66")]
	[Address(RVA = "0x43F7C0", Offset = "0x43DDC0", VA = "0x18043F7C0")]
	private void GoUp()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0004C910 File Offset: 0x0004AB10
	[Token(Token = "0x6000D67")]
	[Address(RVA = "0x43F840", Offset = "0x43DE40", VA = "0x18043F840")]
	private void SetTarget()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Func<Zombie, bool> <>9__12_ = SubMelon.<>c.<>9__12_0;
		if (<>9__12_ == 0)
		{
			SubMelon.<>c.<>9__12_0 = delegate(Zombie z)
			{
				if (!z.isMindControlled && !z.beforeDying && z.theStatus != ZombieStatus.Dying)
				{
					Collider2D col = z.col;
					int num2 = 0;
					if (col != num2)
					{
						return z.col.enabled;
					}
				}
				throw new NullReferenceException();
			};
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__12_));
		Func<Zombie, bool> func = delegate(Zombie z)
		{
			Collider2D col2 = z.col;
			Vector2 vector = this.cannonTarget;
			throw new NullReferenceException();
		};
		List<Zombie> list2 = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(list, func));
		Transform transform = base.transform;
		Mouse instance = Mouse.Instance;
		float num;
		this.targetPosition.y = num;
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x0004C9C4 File Offset: 0x0004ABC4
	[Token(Token = "0x6000D68")]
	[Address(RVA = "0x43F390", Offset = "0x43D990", VA = "0x18043F390")]
	private void Die()
	{
		int num = 0;
		int num2;
		if ((this.doom ? 1 : 0) == num)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			num2 = 0;
			ScreenShake.TriggerShake(0.15f);
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			Transform transform2 = base.transform;
			int mask = LayerMask.GetMask(new string[] { "Zombie" });
			Collider2D[] array;
			if (num >= array.Length)
			{
				goto IL_00C0;
			}
			bool flag;
			if (flag)
			{
			}
			num++;
		}
		BoardAction boardAction = this.board.boardAction;
		Transform transform3 = base.transform;
		PlantType plantType = this.fromType;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = this.damage;
		ulong num8;
		ulong num9;
		Crater crater = boardAction.SetDoom(num6, num5, num4 != 0, num8 != 0UL, num2, num7, num, num, num9 != 0UL, plantType);
		IL_00C0:
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x0004CAA4 File Offset: 0x0004ACA4
	[Token(Token = "0x6000D69")]
	[Address(RVA = "0x43FE30", Offset = "0x43E430", VA = "0x18043FE30")]
	public SubMelon()
	{
	}

	// Token: 0x0400098A RID: 2442
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400098A")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400098B RID: 2443
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400098B")]
	public int damage;

	// Token: 0x0400098C RID: 2444
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400098C")]
	public int row;

	// Token: 0x0400098D RID: 2445
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400098D")]
	public Board board;

	// Token: 0x0400098E RID: 2446
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400098E")]
	public Vector2 cannonTarget;

	// Token: 0x0400098F RID: 2447
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400098F")]
	public bool doom;

	// Token: 0x04000990 RID: 2448
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000990")]
	public bool isDouble;

	// Token: 0x04000991 RID: 2449
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000991")]
	private readonly float moveSpeed = 10f;

	// Token: 0x04000992 RID: 2450
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000992")]
	private Vector2 targetPosition;
}
