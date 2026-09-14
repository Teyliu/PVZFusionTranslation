using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002C3 RID: 707
[Token(Token = "0x20002C3")]
public class JumpSun : MonoBehaviour
{
	// Token: 0x06000C95 RID: 3221 RVA: 0x00048554 File Offset: 0x00046754
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x3E4530", Offset = "0x3E2B30", VA = "0x1803E4530")]
	private void Start()
	{
		List<Zombie> zombieArray = this.board.zombieArray;
		Func<Zombie, bool> <>9__6_ = JumpSun.<>c.<>9__6_0;
		if (<>9__6_ == 0)
		{
			Func<Zombie, bool> func;
			JumpSun.<>c.<>9__6_0 = func;
		}
		IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(zombieArray, <>9__6_);
		Func<Zombie, bool> func2;
		if (JumpSun.<>c.<>9__6_1 == 0)
		{
			JumpSun.<>c.<>9__6_1 = func2;
		}
		List<Zombie> list = Enumerable.ToList<Zombie>(Enumerable.OrderByDescending<Zombie, bool>(enumerable, func2));
		this.zombies = list;
		Animator component = base.GetComponent<Animator>();
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x000485BC File Offset: 0x000467BC
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x3E47A0", Offset = "0x3E2DA0", VA = "0x1803E47A0")]
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

	// Token: 0x06000C97 RID: 3223 RVA: 0x00048710 File Offset: 0x00046910
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x3E4440", Offset = "0x3E2A40", VA = "0x1803E4440")]
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

	// Token: 0x06000C98 RID: 3224 RVA: 0x00048758 File Offset: 0x00046958
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x3E4D30", Offset = "0x3E3330", VA = "0x1803E4D30")]
	public JumpSun()
	{
		List<Zombie> list = new List();
		this.zombies = list;
		this.damage = (int)((ulong)200L);
		this.live = (int)((ulong)10L);
		this.speed = 4f;
		base..ctor();
	}

	// Token: 0x040008B1 RID: 2225
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008B1")]
	public List<Zombie> zombies;

	// Token: 0x040008B2 RID: 2226
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008B2")]
	public Board board;

	// Token: 0x040008B3 RID: 2227
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008B3")]
	public int damage;

	// Token: 0x040008B4 RID: 2228
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008B4")]
	public int live;

	// Token: 0x040008B5 RID: 2229
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008B5")]
	public float speed;

	// Token: 0x040008B6 RID: 2230
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008B6")]
	private bool dying;
}
