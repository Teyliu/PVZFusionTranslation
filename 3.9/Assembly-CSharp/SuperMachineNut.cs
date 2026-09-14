using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000468 RID: 1128
[Token(Token = "0x2000468")]
public class SuperMachineNut : WallNut
{
	// Token: 0x17000149 RID: 329
	// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0007319C File Offset: 0x0007139C
	[Token(Token = "0x17000149")]
	public override int LimDamage
	{
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x4A2A80", Offset = "0x4A1080", VA = "0x1804A2A80", Slot = "65")]
		get
		{
			return this.thePlantMaxHealth;
		}
	}

	// Token: 0x060014C9 RID: 5321 RVA: 0x000731B0 File Offset: 0x000713B0
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "32")]
	protected override bool Instead(int theDamage)
	{
		return false;
	}

	// Token: 0x060014CA RID: 5322 RVA: 0x000731C0 File Offset: 0x000713C0
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x4CB480", Offset = "0x4C9A80", VA = "0x1804CB480")]
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
		long theMaxHealth = zombie7.theMaxHealth;
		zombie7.theHealth = theMaxHealth;
		Transform axis3 = this.landSubmarine.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060014CB RID: 5323 RVA: 0x000732BC File Offset: 0x000714BC
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x4CB320", Offset = "0x4C9920", VA = "0x1804CB320", Slot = "52")]
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

	// Token: 0x060014CC RID: 5324 RVA: 0x000732F4 File Offset: 0x000714F4
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x4CB3B0", Offset = "0x4C99B0", VA = "0x1804CB3B0", Slot = "27")]
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

	// Token: 0x060014CD RID: 5325 RVA: 0x00073348 File Offset: 0x00071548
	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x4CB770", Offset = "0x4C9D70", VA = "0x1804CB770", Slot = "60")]
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

	// Token: 0x060014CE RID: 5326 RVA: 0x000733B4 File Offset: 0x000715B4
	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public SuperMachineNut()
	{
	}

	// Token: 0x04000D43 RID: 3395
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000D43")]
	private Zombie landSubmarine;
}
