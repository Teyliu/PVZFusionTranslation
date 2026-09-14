using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000442 RID: 1090
[Token(Token = "0x2000442")]
public class SolarPad : LilyPad
{
	// Token: 0x0600140A RID: 5130 RVA: 0x0006F90C File Offset: 0x0006DB0C
	[Token(Token = "0x600140A")]
	[Address(RVA = "0x4BE640", Offset = "0x4BCC40", VA = "0x1804BE640")]
	private void Produce()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x0006F938 File Offset: 0x0006DB38
	[Token(Token = "0x600140B")]
	[Address(RVA = "0x4BE910", Offset = "0x4BCF10", VA = "0x1804BE910", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x0006F954 File Offset: 0x0006DB54
	[Token(Token = "0x600140C")]
	[Address(RVA = "0x4BE7A0", Offset = "0x4BCDA0", VA = "0x1804BE7A0", Slot = "36")]
	public override void ProducerUpdate()
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
		SolarPad.<Bright>d__3 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Bright>d__);
		base.Invoke("Produce", 0.5f);
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x0006F9DC File Offset: 0x0006DBDC
	[Token(Token = "0x600140D")]
	[Address(RVA = "0x4BE190", Offset = "0x4BC790", VA = "0x1804BE190")]
	protected IEnumerator Bright()
	{
		SolarPad.<Bright>d__3 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x0006FA00 File Offset: 0x0006DC00
	[Token(Token = "0x600140E")]
	[Address(RVA = "0x4BE260", Offset = "0x4BC860", VA = "0x1804BE260", Slot = "68")]
	protected override void MixUpdate()
	{
		int num4;
		do
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int thePlantRow = this.thePlantRow;
			int thePlantColumn = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(thePlantColumn, thePlantRow).plants;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !(num != this))
				{
					continue;
				}
				bool flag2;
				while (flag2)
				{
				}
			}
			if (num2 != 0)
			{
				goto IL_00B4;
			}
			num4 = 0;
			BoardGrid boardGrid;
			List<Plant> plants2 = boardGrid.plants;
			bool flag3;
			if (flag3)
			{
				int num5 = 0;
				if (!(num != num5))
				{
					continue;
				}
			}
		}
		while (num4 != 0);
		int num6 = 0;
		BoxCollider2D[] col = this.col;
		if (num6 < col.Length)
		{
			num6++;
			if (num6 < col.Length)
			{
				num6++;
			}
		}
		return;
		IL_00B4:
		throw new NullReferenceException();
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x0006FAC8 File Offset: 0x0006DCC8
	[Token(Token = "0x600140F")]
	[Address(RVA = "0x4BE200", Offset = "0x4BC800", VA = "0x1804BE200", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x0006FAE8 File Offset: 0x0006DCE8
	[Token(Token = "0x6001410")]
	[Address(RVA = "0x4BE950", Offset = "0x4BCF50", VA = "0x1804BE950")]
	public SolarPad()
	{
	}
}
