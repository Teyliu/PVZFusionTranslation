using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000425 RID: 1061
[Token(Token = "0x2000425")]
public class SolarPot : MoneyPot
{
	// Token: 0x0600138D RID: 5005 RVA: 0x0006D998 File Offset: 0x0006BB98
	[Token(Token = "0x600138D")]
	[Address(RVA = "0x467AF0", Offset = "0x4660F0", VA = "0x180467AF0", Slot = "70")]
	protected override void Produce()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x0006D9C4 File Offset: 0x0006BBC4
	[Token(Token = "0x600138E")]
	[Address(RVA = "0x4679D0", Offset = "0x465FD0", VA = "0x1804679D0", Slot = "69")]
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

	// Token: 0x0600138F RID: 5007 RVA: 0x0006DA3C File Offset: 0x0006BC3C
	[Token(Token = "0x600138F")]
	[Address(RVA = "0x467970", Offset = "0x465F70", VA = "0x180467970", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x0006DA5C File Offset: 0x0006BC5C
	[Token(Token = "0x6001390")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public SolarPot()
	{
	}
}
