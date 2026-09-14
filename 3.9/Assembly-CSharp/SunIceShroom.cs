using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000457 RID: 1111
[Token(Token = "0x2000457")]
public class SunIceShroom : Producer
{
	// Token: 0x06001476 RID: 5238 RVA: 0x00071D10 File Offset: 0x0006FF10
	[Token(Token = "0x6001476")]
	[Address(RVA = "0x4AC180", Offset = "0x4AA780", VA = "0x1804AC180", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)3L);
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00071D2C File Offset: 0x0006FF2C
	[Token(Token = "0x6001477")]
	[Address(RVA = "0x4C7A70", Offset = "0x4C6070", VA = "0x1804C7A70", Slot = "69")]
	protected override void ProduceSun()
	{
		int num2;
		bool flag;
		do
		{
			int num = 0;
			base.ProduceSun();
			List<Zombie> zombieArray = this.board.zombieArray;
			num2 = 0;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				while (num != 0)
				{
				}
				CreateItem instance = CreateItem.Instance;
			}
		}
		while (num2 != 0);
		if (flag > false)
		{
			BoardAction boardAction = this.board.boardAction;
		}
		int num4 = 0;
		this.board.boardAction.CreateFreeze(num4, 4f, true);
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00071DBC File Offset: 0x0006FFBC
	[Token(Token = "0x6001478")]
	[Address(RVA = "0x4C7DA0", Offset = "0x4C63A0", VA = "0x1804C7DA0", Slot = "36")]
	public override void ProducerUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		if (num > (int)thePlantProduceCountDown)
		{
			float num2 = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.thePlantProduceCountDown = num2;
			IEnumerator enumerator = this.SunBright();
			Coroutine coroutine = base.StartCoroutine(enumerator);
		}
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00071E10 File Offset: 0x00070010
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x4C7E30", Offset = "0x4C6430", VA = "0x1804C7E30", Slot = "68")]
	protected override IEnumerator SunBright()
	{
		SunIceShroom.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00071E34 File Offset: 0x00070034
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SunIceShroom()
	{
	}
}
