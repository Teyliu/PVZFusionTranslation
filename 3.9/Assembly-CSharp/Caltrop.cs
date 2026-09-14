using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000368 RID: 872
[Token(Token = "0x2000368")]
public class Caltrop : Attacker
{
	// Token: 0x06000FF2 RID: 4082 RVA: 0x0005B9D0 File Offset: 0x00059BD0
	[Token(Token = "0x6000FF2")]
	[Address(RVA = "0x478570", Offset = "0x476B70", VA = "0x180478570", Slot = "16")]
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

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0005BA14 File Offset: 0x00059C14
	[Token(Token = "0x17000118")]
	protected virtual Collider2D[] Cols
	{
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x478610", Offset = "0x476C10", VA = "0x180478610", Slot = "68")]
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

	// Token: 0x06000FF4 RID: 4084 RVA: 0x0005BA48 File Offset: 0x00059C48
	[Token(Token = "0x6000FF4")]
	[Address(RVA = "0x478450", Offset = "0x476A50", VA = "0x180478450", Slot = "69")]
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

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0005BA98 File Offset: 0x00059C98
	[Token(Token = "0x6000FF5")]
	[Address(RVA = "0x478360", Offset = "0x476960", VA = "0x180478360")]
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

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0005BACC File Offset: 0x00059CCC
	[Token(Token = "0x6000FF6")]
	[Address(RVA = "0x478150", Offset = "0x476750", VA = "0x180478150", Slot = "70")]
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

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0005BB24 File Offset: 0x00059D24
	[Token(Token = "0x6000FF7")]
	[Address(RVA = "0x477FD0", Offset = "0x4765D0", VA = "0x180477FD0", Slot = "71")]
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

	// Token: 0x06000FF8 RID: 4088 RVA: 0x0005BB90 File Offset: 0x00059D90
	[Token(Token = "0x6000FF8")]
	[Address(RVA = "0x478300", Offset = "0x476900", VA = "0x180478300", Slot = "72")]
	protected virtual void OnAttack(Zombie zombie)
	{
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		ulong num;
		zombie.TakeDamage(attackDamage, this, (DamageType)((uint)4), thePlantType, num != 0UL);
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0005BBC0 File Offset: 0x00059DC0
	[Token(Token = "0x6000FF9")]
	[Address(RVA = "0x473A90", Offset = "0x472090", VA = "0x180473A90")]
	public Caltrop()
	{
	}

	// Token: 0x04000BA2 RID: 2978
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA2")]
	public float range = 1f;
}
