using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UIElements;

// Token: 0x02000234 RID: 564
[Token(Token = "0x2000234")]
public class Lava : MonoBehaviour
{
	// Token: 0x060009EA RID: 2538 RVA: 0x00035F1C File Offset: 0x0003411C
	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x885090", Offset = "0x883690", VA = "0x180885090")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		float num = global::UnityEngine.Random.Range(0.8f, 1.2f);
		component.SetFloat("Speed", num);
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie", "Plant" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x00035F84 File Offset: 0x00034184
	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x8851B0", Offset = "0x8837B0", VA = "0x1808851B0")]
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

	// Token: 0x060009EC RID: 2540 RVA: 0x00036060 File Offset: 0x00034260
	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x885750", Offset = "0x883D50", VA = "0x180885750")]
	public Lava()
	{
	}

	// Token: 0x04000541 RID: 1345
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000541")]
	public Board board;

	// Token: 0x04000542 RID: 1346
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000542")]
	public int theColumn;

	// Token: 0x04000543 RID: 1347
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000543")]
	public int theRow;

	// Token: 0x04000544 RID: 1348
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000544")]
	private float timer = 1f;

	// Token: 0x04000545 RID: 1349
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000545")]
	private LayerMask zombieLayer;
}
