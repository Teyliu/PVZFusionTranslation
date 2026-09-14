using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UIElements;

// Token: 0x0200023A RID: 570
[Token(Token = "0x200023A")]
public class Lava : MonoBehaviour
{
	// Token: 0x06000A05 RID: 2565 RVA: 0x00035E24 File Offset: 0x00034024
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x914BD0", Offset = "0x9131D0", VA = "0x180914BD0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		float num = global::UnityEngine.Random.Range(0.8f, 1.2f);
		component.SetFloat("Speed", num);
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00035E8C File Offset: 0x0003408C
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x914CF0", Offset = "0x9132F0", VA = "0x180914CF0")]
	private void Update()
	{
		int num;
		do
		{
			num = 0;
			float num2 = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num2;
			this.timer = 1f;
			int num3 = this.theRow;
			List<Plant> list = Lawnf.Get1x1Plants(this.theColumn, num3);
			Predicate<Plant> <>9__6_ = Lava.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				Predicate<Plant> predicate;
				Lava.<>c.<>9__6_0 = predicate;
			}
			int num4 = list.RemoveAll(<>9__6_);
			Predicate<Plant> predicate2;
			if (Lava.<>c.<>9__6_1 == 0)
			{
				Lava.<>c.<>9__6_1 = predicate2;
			}
			Plant plant = list.Find(predicate2);
			int num5 = 0;
			if (plant != num5)
			{
				goto IL_0099;
			}
			bool flag;
			if (flag)
			{
			}
		}
		while (num != 0);
		int num6 = 0;
		IL_0099:
		EasingMode mode = ((EasingMode)num).m_Mode;
		Collider2D[] array;
		if (num6 < array.Length)
		{
			bool flag2;
			if (!flag2 || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num6++;
		}
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00035F68 File Offset: 0x00034168
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x915290", Offset = "0x913890", VA = "0x180915290")]
	public Lava()
	{
	}

	// Token: 0x0400054C RID: 1356
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400054C")]
	public Board board;

	// Token: 0x0400054D RID: 1357
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400054D")]
	public int theColumn;

	// Token: 0x0400054E RID: 1358
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400054E")]
	public int theRow;

	// Token: 0x0400054F RID: 1359
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400054F")]
	private float timer = 1f;

	// Token: 0x04000550 RID: 1360
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000550")]
	private LayerMask zombieLayer;
}
