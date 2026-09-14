using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002D1 RID: 721
[Token(Token = "0x20002D1")]
public class JumpSun : MonoBehaviour
{
	// Token: 0x06000CD8 RID: 3288 RVA: 0x00049124 File Offset: 0x00047324
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x4351D0", Offset = "0x4337D0", VA = "0x1804351D0")]
	private void Start()
	{
		List<Zombie> zombieArray = this.board.zombieArray;
		Func<Zombie, bool> <>9__6_ = JumpSun.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			JumpSun.<>c.<>9__6_0 = delegate(Zombie z)
			{
				int num = 0;
				return z != num;
			};
		}
		IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombieArray, <>9__6_);
		Func<Zombie, bool> func;
		if (JumpSun.<>c.<>9__6_1 == 0)
		{
			func = (Zombie z) => z.isMindControlled;
			JumpSun.<>c.<>9__6_1 = func;
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.OrderByDescending<Zombie, bool>(enumerable, func));
		this.zombies = list;
		Animator component = base.GetComponent<Animator>();
	}

	// Token: 0x06000CD9 RID: 3289 RVA: 0x000491A8 File Offset: 0x000473A8
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x435440", Offset = "0x433A40", VA = "0x180435440")]
	private void Update()
	{
		int size = this.zombies._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.zombies[num];
			int num2 = 0;
			if (zombie == num2)
			{
				this.zombies.RemoveAt(num);
			}
		}
		List<Zombie> list = this.zombies;
		int num3 = 0;
		Zombie zombie2 = list[num3];
		Transform axis = zombie2.axis;
		Vector3 vector;
		float z = vector.z;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		float deltaTime = Time.deltaTime;
		Transform transform3 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		int num4 = 0;
		if ((zombie2.isMindControlled ? 1 : 0) == num4)
		{
			int num5 = this.damage;
			num5 -= transform3;
			CreateItem instance = CreateItem.Instance;
			Transform transform4 = base.transform;
		}
		CreateItem instance2 = CreateItem.Instance;
		Transform transform5 = base.transform;
		Vector3 vector4;
		float z4 = vector4.z;
		uint num6;
		GameAPP.PlaySound((int)num6, 0.5f, 1f);
		uint num7;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num7), 0.5f, 1f);
		ParticleManager instance3 = ParticleManager.Instance;
		Transform transform6 = base.transform;
		List<Zombie> list2 = this.zombies;
		int num8 = 0;
		list2.RemoveAt(num8);
		int num9 = this.live;
		this.live = num9;
		this.Die();
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x000492FC File Offset: 0x000474FC
	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x4350E0", Offset = "0x4336E0", VA = "0x1804350E0")]
	private void Die()
	{
		if (!this.dying)
		{
			this.dying = true;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000CDB RID: 3291 RVA: 0x00049344 File Offset: 0x00047544
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x4359D0", Offset = "0x433FD0", VA = "0x1804359D0")]
	public JumpSun()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		this.damage = (int)((ulong)200L);
		this.live = (int)((ulong)10L);
		this.speed = 4f;
		base..ctor();
	}

	// Token: 0x040008EE RID: 2286
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008EE")]
	public List<Zombie> zombies;

	// Token: 0x040008EF RID: 2287
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008EF")]
	public Board board;

	// Token: 0x040008F0 RID: 2288
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008F0")]
	public int damage;

	// Token: 0x040008F1 RID: 2289
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008F1")]
	public int live;

	// Token: 0x040008F2 RID: 2290
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008F2")]
	public float speed;

	// Token: 0x040008F3 RID: 2291
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008F3")]
	private bool dying;
}
