using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000448 RID: 1096
[Token(Token = "0x2000448")]
public class SuperMachineNut : WallNut
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06001438 RID: 5176 RVA: 0x00070E70 File Offset: 0x0006F070
	[Token(Token = "0x17000104")]
	public override int LimDamage
	{
		[Token(Token = "0x6001438")]
		[Address(RVA = "0x44E2B0", Offset = "0x44C8B0", VA = "0x18044E2B0", Slot = "66")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x00070E84 File Offset: 0x0006F084
	[Token(Token = "0x6001439")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "33")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x00070E94 File Offset: 0x0006F094
	[Token(Token = "0x600143A")]
	[Address(RVA = "0x473BD0", Offset = "0x4721D0", VA = "0x180473BD0")]
	public void Summon()
	{
		int num = 0;
		Zombie zombie = this.landSubmarine;
		int num2 = 0;
		if (!(zombie == num2))
		{
			Zombie zombie2 = this.landSubmarine;
			int num3 = 0;
			zombie2.Die(num3);
			this.landSubmarine = num;
		}
		Board board = this.board;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
		{
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
		}
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Zombie zombie4;
		Zombie zombie3 = zombie4.GetComponent<Zombie>();
		this.landSubmarine = zombie3;
		Zombie zombie5 = this.landSubmarine;
		zombie3 += zombie3;
		zombie5.theMaxHealth = zombie3;
		Zombie zombie6 = this.landSubmarine;
		float theArmor = zombie6.theArmor;
		zombie6.theArmor = theArmor;
		Zombie zombie7 = this.landSubmarine;
		int theMaxHealth = zombie7.theMaxHealth;
		zombie7.theHealth = theMaxHealth;
		Transform axis3 = this.landSubmarine.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x00070F90 File Offset: 0x0006F190
	[Token(Token = "0x600143B")]
	[Address(RVA = "0x473A70", Offset = "0x472070", VA = "0x180473A70", Slot = "53")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Zombie zombie = this.landSubmarine;
		int num = 0;
		if (zombie != num)
		{
			Zombie zombie2 = this.landSubmarine;
			int num2 = 0;
			zombie2.Die(num2);
		}
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00070FC8 File Offset: 0x0006F1C8
	[Token(Token = "0x600143C")]
	[Address(RVA = "0x473B00", Offset = "0x472100", VA = "0x180473B00", Slot = "28")]
	protected override void LimHealth()
	{
		uint num2;
		int num = Mathf.Min(this.board.theCurrentSurvivalRound, (int)num2);
		uint num4;
		long num3 = (long)(num4 * (uint)640000);
		Board board = this.board;
		num3 += num3;
		int num5 = Mathf.Min(this.thePlantHealth, (int)num3);
		this.thePlantHealth = num5;
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x0007101C File Offset: 0x0006F21C
	[Token(Token = "0x600143D")]
	[Address(RVA = "0x473EC0", Offset = "0x4724C0", VA = "0x180473EC0", Slot = "61")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		int num = this.thePlantMaxHealth.Multiply(0.6f);
		base.GetShield(0.6f);
		int num2 = this.thePlantMaxHealth.Multiply(0.6f);
		int num3 = 0;
		ulong num4;
		base.Recover(0.6f, (DamageType)num3, true, num4 != 0UL);
		int num5 = 0;
		if (bucket != num5)
		{
			global::UnityEngine.Object.Destroy(bucket.gameObject);
		}
		return true;
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x00071088 File Offset: 0x0006F288
	[Token(Token = "0x600143E")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public SuperMachineNut()
	{
	}

	// Token: 0x04000CB7 RID: 3255
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CB7")]
	private Zombie landSubmarine;
}
