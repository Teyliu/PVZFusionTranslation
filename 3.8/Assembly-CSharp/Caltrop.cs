using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000358")]
public class Caltrop : Attacker
{
	// Token: 0x06000FA6 RID: 4006 RVA: 0x0005AA40 File Offset: 0x00058C40
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x421620", Offset = "0x41FC20", VA = "0x180421620", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float thePlantAttackCountDown = this.thePlantAttackCountDown;
		int num = 0;
		if (thePlantAttackCountDown > (float)num)
		{
			base.UpdateAttackCountDown();
			this.ReadyToAttack();
			float num2 = global::UnityEngine.Random.Range(-0.1f, 0.1f);
			this.thePlantAttackCountDown = num2;
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x0005AA84 File Offset: 0x00058C84
	[Token(Token = "0x170000D5")]
	protected virtual Collider2D[] Cols
	{
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x4216C0", Offset = "0x41FCC0", VA = "0x1804216C0", Slot = "69")]
		get
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = this.zombieLayer;
			Collider2D[] array;
			return array;
		}
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0005AAB8 File Offset: 0x00058CB8
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x421500", Offset = "0x41FB00", VA = "0x180421500", Slot = "70")]
	protected virtual void ReadyToAttack()
	{
		int num = 0;
		Collider2D[] cols = this.Cols;
		if (num < cols.Length)
		{
			bool flag;
			if (flag && base.SearchUniqueZombie(num))
			{
				int thePlantRow = this.thePlantRow;
				this.anim.SetTrigger("attack");
			}
			num++;
		}
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0005AB08 File Offset: 0x00058D08
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x421410", Offset = "0x41FA10", VA = "0x180421410")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				this.anim.SetTrigger("attack");
			}
		}
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0005AB3C File Offset: 0x00058D3C
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x421200", Offset = "0x41F800", VA = "0x180421200", Slot = "71")]
	protected virtual void KillCar()
	{
		int num = 0;
		Collider2D[] cols = this.Cols;
		if (num < cols.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				bool flag2;
				if (flag2)
				{
					uint num2;
					GameAPP.PlaySound((int)num2, 0.5f, 1f);
					int num3 = 0;
					base.Die((Plant.DieReason)num3);
				}
			}
			num++;
		}
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0005AB94 File Offset: 0x00058D94
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x421080", Offset = "0x41F680", VA = "0x180421080", Slot = "72")]
	protected virtual void AnimAttack()
	{
		int num = 0;
		this.KillCar();
		int num2 = 0;
		Collider2D[] cols = this.Cols;
		if (num < cols.Length)
		{
			bool flag;
			if (flag)
			{
				int thePlantRow = this.thePlantRow;
				if (base.SearchUniqueZombie(num))
				{
					this.OnAttack(num);
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num3;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num3), 0.5f, 1f);
		}
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0005AC00 File Offset: 0x00058E00
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x4213B0", Offset = "0x41F9B0", VA = "0x1804213B0", Slot = "73")]
	protected virtual void OnAttack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)4), thePlantType, num != 0UL);
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x0005AC30 File Offset: 0x00058E30
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public Caltrop()
	{
	}

	// Token: 0x04000B51 RID: 2897
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B51")]
	public float range = 1f;
}
