using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003D9 RID: 985
[Token(Token = "0x20003D9")]
public class MachineNut : WallNut
{
	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06001219 RID: 4633 RVA: 0x00065D2C File Offset: 0x00063F2C
	[Token(Token = "0x170000ED")]
	public override int LimDamage
	{
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x44E2B0", Offset = "0x44C8B0", VA = "0x18044E2B0", Slot = "66")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x00065D40 File Offset: 0x00063F40
	[Token(Token = "0x600121A")]
	[Address(RVA = "0x44DB40", Offset = "0x44C140", VA = "0x18044DB40")]
	public void TurnStatus(int type)
	{
		if (this.machineType != type)
		{
			int num = 0;
			ulong num2;
			base.Recover(3000f, (DamageType)num, true, num2 != 0UL);
		}
		this.machineType = type;
		base.FlashOnce();
		if (this.machineType != 1)
		{
			if (this.machineType == 2)
			{
				Transform transform = base.transform;
				int num3 = 0;
				Transform child = transform.GetChild(num3);
				int num4 = 0;
				GameObject gameObject = child.GetChild(num4).gameObject;
				int num5 = 0;
				gameObject.SetActive(num5 != 0);
				Transform child2 = base.transform.GetChild(1);
				int num6 = 0;
				GameObject gameObject2 = child2.GetChild(num6).gameObject;
				int num7 = 0;
				gameObject2.SetActive(num7 != 0);
				Transform child3 = base.transform.GetChild(2);
				int num8 = 0;
				GameObject gameObject3 = child3.GetChild(num8).gameObject;
				int num9 = 0;
				gameObject3.SetActive(num9 != 0);
				Transform transform2 = base.transform;
				int num10 = 0;
				GameObject gameObject4 = transform2.GetChild(num10).GetChild(1).gameObject;
				int num11 = 0;
				gameObject4.SetActive(num11 != 0);
				GameObject gameObject5 = base.transform.GetChild(1).GetChild(1).gameObject;
				int num12 = 0;
				gameObject5.SetActive(num12 != 0);
				GameObject gameObject6 = base.transform.GetChild(2).GetChild(1).gameObject;
				int num13 = 0;
				gameObject6.SetActive(num13 != 0);
				Transform transform3 = base.transform;
				int num14 = 0;
				transform3.GetChild(num14).GetChild(2).gameObject.SetActive(true);
				base.transform.GetChild(1).GetChild(2).gameObject.SetActive(true);
				base.transform.GetChild(2).GetChild(2).gameObject.SetActive(true);
			}
			return;
		}
		int num15 = 0;
		Transform transform4;
		Transform child4 = transform4.GetChild(num15);
		int num16 = 0;
		GameObject gameObject7 = child4.GetChild(num16).gameObject;
		int num17 = 0;
		gameObject7.SetActive(num17 != 0);
		Transform transform5;
		Transform child5 = transform5.GetChild(1);
		int num18 = 0;
		GameObject gameObject8 = child5.GetChild(num18).gameObject;
		int num19 = 0;
		gameObject8.SetActive(num19 != 0);
		Transform transform6;
		Transform child6 = transform6.GetChild(2);
		int num20 = 0;
		GameObject gameObject9 = child6.GetChild(num20).gameObject;
		int num21 = 0;
		gameObject9.SetActive(num21 != 0);
		int num22 = 0;
		Transform transform7;
		transform7.GetChild(num22).GetChild(1).gameObject.SetActive(true);
		Transform transform8;
		transform8.GetChild(1).GetChild(1).gameObject.SetActive(true);
		Transform transform9;
		transform9.GetChild(2).GetChild(1).gameObject.SetActive(true);
		int num23 = 0;
		Transform transform10;
		GameObject gameObject10 = transform10.GetChild(num23).GetChild(2).gameObject;
		int num24 = 0;
		gameObject10.SetActive(num24 != 0);
		Transform transform11;
		GameObject gameObject11 = transform11.GetChild(1).GetChild(2).gameObject;
		int num25 = 0;
		gameObject11.SetActive(num25 != 0);
		Transform transform12;
		GameObject gameObject12 = transform12.GetChild(2).GetChild(2).gameObject;
		int num26 = 0;
		gameObject12.SetActive(num26 != 0);
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0006602C File Offset: 0x0006422C
	[Token(Token = "0x600121B")]
	[Address(RVA = "0x44DA50", Offset = "0x44C050", VA = "0x18044DA50", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (this.machineType != 1)
		{
			if (this.machineType == 2)
			{
				BoardAction boardAction = this.board.boardAction;
				PlantType thePlantType = this.thePlantType;
				int num = 0;
				int num2 = 0;
				int thePlantRow = this.thePlantRow;
				ulong num3;
				boardAction.CreateFireLine(thePlantRow, 1800, num2 != 0, num != 0, num3 != 0UL, num, thePlantType);
			}
			return;
		}
		Board board = this.board;
		Transform axis = this.axis;
		BoardAction boardAction2 = board.boardAction;
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x000660A0 File Offset: 0x000642A0
	[Token(Token = "0x600121C")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x000660B0 File Offset: 0x000642B0
	[Token(Token = "0x600121D")]
	[Address(RVA = "0x42AF50", Offset = "0x429550", VA = "0x18042AF50", Slot = "28")]
	protected override void LimHealth()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int thePlantMaxHealth2 = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth2;
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x000660D4 File Offset: 0x000642D4
	[Token(Token = "0x600121E")]
	[Address(RVA = "0x44DB30", Offset = "0x44C130", VA = "0x18044DB30", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
		this.TurnStatus(1);
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x000660E8 File Offset: 0x000642E8
	[Token(Token = "0x600121F")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public MachineNut()
	{
	}

	// Token: 0x04000BF5 RID: 3061
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BF5")]
	private int machineType;
}
