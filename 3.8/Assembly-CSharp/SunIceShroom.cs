using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000438 RID: 1080
[Token(Token = "0x2000438")]
public class SunIceShroom : Producer
{
	// Token: 0x060013EC RID: 5100 RVA: 0x0006FA64 File Offset: 0x0006DC64
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x456CF0", Offset = "0x4552F0", VA = "0x180456CF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCount = (int)((ulong)3L);
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x0006FA80 File Offset: 0x0006DC80
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x470220", Offset = "0x46E820", VA = "0x180470220", Slot = "70")]
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
		this.board.boardAction.CreateFreeze(num4, 4f);
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0006FB0C File Offset: 0x0006DD0C
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x470540", Offset = "0x46EB40", VA = "0x180470540", Slot = "37")]
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

	// Token: 0x060013EF RID: 5103 RVA: 0x0006FB60 File Offset: 0x0006DD60
	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x4705D0", Offset = "0x46EBD0", VA = "0x1804705D0", Slot = "69")]
	protected override IEnumerator SunBright()
	{
		SunIceShroom.<SunBright>d__3 <SunBright>d__;
		<SunBright>d__.System.IDisposable.Dispose();
		<SunBright>d__.<>1__state = (int)((ulong)0L);
		<SunBright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0006FB84 File Offset: 0x0006DD84
	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SunIceShroom()
	{
	}
}
