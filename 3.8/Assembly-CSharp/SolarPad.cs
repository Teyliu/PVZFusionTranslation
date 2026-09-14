using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000423 RID: 1059
[Token(Token = "0x2000423")]
public class SolarPad : LilyPad
{
	// Token: 0x06001380 RID: 4992 RVA: 0x0006D664 File Offset: 0x0006B864
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x467650", Offset = "0x465C50", VA = "0x180467650")]
	private void Produce()
	{
		CreateItem instance = CreateItem.Instance;
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x0006D690 File Offset: 0x0006B890
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x467920", Offset = "0x465F20", VA = "0x180467920", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x0006D6AC File Offset: 0x0006B8AC
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x4677B0", Offset = "0x465DB0", VA = "0x1804677B0", Slot = "37")]
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

	// Token: 0x06001383 RID: 4995 RVA: 0x0006D734 File Offset: 0x0006B934
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x4671A0", Offset = "0x4657A0", VA = "0x1804671A0")]
	protected IEnumerator Bright()
	{
		SolarPad.<Bright>d__3 <Bright>d__;
		<Bright>d__.System.IDisposable.Dispose();
		<Bright>d__.<>1__state = (int)((ulong)0L);
		<Bright>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x0006D758 File Offset: 0x0006B958
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x467270", Offset = "0x465870", VA = "0x180467270", Slot = "69")]
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

	// Token: 0x06001385 RID: 4997 RVA: 0x0006D820 File Offset: 0x0006BA20
	[Token(Token = "0x6001385")]
	[Address(RVA = "0x467210", Offset = "0x465810", VA = "0x180467210", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			return;
		}
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x0006D840 File Offset: 0x0006BA40
	[Token(Token = "0x6001386")]
	[Address(RVA = "0x467960", Offset = "0x465F60", VA = "0x180467960")]
	public SolarPad()
	{
	}
}
