using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003EF RID: 1007
[Token(Token = "0x20003EF")]
public class MachineNut : WallNut
{
	// Token: 0x17000130 RID: 304
	// (get) Token: 0x0600127C RID: 4732 RVA: 0x000675DC File Offset: 0x000657DC
	[Token(Token = "0x17000130")]
	public override int LimDamage
	{
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x4A2A80", Offset = "0x4A1080", VA = "0x1804A2A80", Slot = "65")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x000675F0 File Offset: 0x000657F0
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x4A2310", Offset = "0x4A0910", VA = "0x1804A2310")]
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

	// Token: 0x0600127E RID: 4734 RVA: 0x000678DC File Offset: 0x00065ADC
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x4A2220", Offset = "0x4A0820", VA = "0x1804A2220", Slot = "51")]
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
		int num4 = 0;
		boardAction2.CreateFreeze(num4, 4f, true);
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x00067960 File Offset: 0x00065B60
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x00067970 File Offset: 0x00065B70
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x46BB70", Offset = "0x46A170", VA = "0x18046BB70", Slot = "27")]
	protected override void LimHealth()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int thePlantMaxHealth2 = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth2;
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00067994 File Offset: 0x00065B94
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x4A2300", Offset = "0x4A0900", VA = "0x1804A2300", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
		this.TurnStatus(1);
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x000679A8 File Offset: 0x00065BA8
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public MachineNut()
	{
	}

	// Token: 0x04000C61 RID: 3169
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C61")]
	private int machineType;
}
