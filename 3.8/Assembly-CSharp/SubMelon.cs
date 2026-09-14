using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002DD RID: 733
[Token(Token = "0x20002DD")]
public class SubMelon : MonoBehaviour
{
	// Token: 0x06000D21 RID: 3361 RVA: 0x0004BC4C File Offset: 0x00049E4C
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x3FBF20", Offset = "0x3FA520", VA = "0x1803FBF20")]
	private void Start()
	{
		this.SetTarget();
		if (Lawnf.TravelUltimate((UltiBuff)((uint)14)))
		{
			int num = this.damage;
			this.damage = num;
		}
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x0004BC78 File Offset: 0x00049E78
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x3FBFC0", Offset = "0x3FA5C0", VA = "0x1803FBFC0")]
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

	// Token: 0x06000D23 RID: 3363 RVA: 0x0004BCE0 File Offset: 0x00049EE0
	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x3FBBC0", Offset = "0x3FA1C0", VA = "0x1803FBBC0")]
	private void GoUp()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0004BD04 File Offset: 0x00049F04
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x3FBC40", Offset = "0x3FA240", VA = "0x1803FBC40")]
	private void SetTarget()
	{
		List<Zombie> allZombies = Lawnf.GetAllZombies(false);
		Func<Zombie, bool> <>9__12_ = SubMelon.<>c.<>9__12_0;
		if (<>9__12_ == 0)
		{
			Func<Zombie, bool> func;
			SubMelon.<>c.<>9__12_0 = func;
		}
		Func<Zombie, bool> func2;
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__12_)), func2));
		Transform transform = base.transform;
		Mouse instance = Mouse.Instance;
		float num;
		this.targetPosition.y = num;
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x0004BD98 File Offset: 0x00049F98
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x3FB790", Offset = "0x3F9D90", VA = "0x1803FB790")]
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

	// Token: 0x06000D26 RID: 3366 RVA: 0x0004BE78 File Offset: 0x0004A078
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x3FC230", Offset = "0x3FA830", VA = "0x1803FC230")]
	public SubMelon()
	{
	}

	// Token: 0x0400094D RID: 2381
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400094D")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400094E RID: 2382
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400094E")]
	public int damage;

	// Token: 0x0400094F RID: 2383
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400094F")]
	public int row;

	// Token: 0x04000950 RID: 2384
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000950")]
	public Board board;

	// Token: 0x04000951 RID: 2385
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000951")]
	public Vector2 cannonTarget;

	// Token: 0x04000952 RID: 2386
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000952")]
	public bool doom;

	// Token: 0x04000953 RID: 2387
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000953")]
	public bool isDouble;

	// Token: 0x04000954 RID: 2388
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000954")]
	private readonly float moveSpeed = 10f;

	// Token: 0x04000955 RID: 2389
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000955")]
	private Vector2 targetPosition;
}
