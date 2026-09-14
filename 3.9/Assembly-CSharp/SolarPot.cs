using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000444 RID: 1092
[Token(Token = "0x2000444")]
public class SolarPot : MoneyPot
{
	// Token: 0x06001417 RID: 5143 RVA: 0x0006FC40 File Offset: 0x0006DE40
	[Token(Token = "0x6001417")]
	[Address(RVA = "0x4BEAE0", Offset = "0x4BD0E0", VA = "0x1804BEAE0", Slot = "69")]
	protected override void Produce()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x0006FC6C File Offset: 0x0006DE6C
	[Token(Token = "0x6001418")]
	[Address(RVA = "0x4BE9C0", Offset = "0x4BCFC0", VA = "0x1804BE9C0", Slot = "68")]
	protected override void MarigoldUpdate()
	{
		float thePlantProduceCountDown = this.thePlantProduceCountDown;
		float deltaTime = Time.deltaTime;
		int num = 0;
		this.thePlantProduceCountDown = thePlantProduceCountDown;
		float num2 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		Board board = this.board;
		float num3;
		if (num > (int)num3 || num3 > 1f)
		{
		}
		IEnumerator enumerator = base.Bright();
		Coroutine coroutine = base.StartCoroutine(enumerator);
		base.Invoke("Produce", 0.5f);
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
	[Token(Token = "0x6001419")]
	[Address(RVA = "0x4BE960", Offset = "0x4BCF60", VA = "0x1804BE960", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0006FD04 File Offset: 0x0006DF04
	[Token(Token = "0x600141A")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public SolarPot()
	{
	}
}
