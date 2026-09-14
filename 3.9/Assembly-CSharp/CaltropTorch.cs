using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200036E RID: 878
[Token(Token = "0x200036E")]
public class CaltropTorch : Plant
{
	// Token: 0x06001010 RID: 4112 RVA: 0x0005C158 File Offset: 0x0005A358
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x477F60", Offset = "0x476560", VA = "0x180477F60", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float thePlantAttackCountDown = this.thePlantAttackCountDown;
		int num = 0;
		if (thePlantAttackCountDown > (float)num)
		{
			base.UpdateAttackCountDown();
			this.SummonFire();
			float thePlantAttackInterval = this.thePlantAttackInterval;
			this.thePlantAttackCountDown = thePlantAttackInterval;
		}
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0005C194 File Offset: 0x0005A394
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x4778B0", Offset = "0x475EB0", VA = "0x1804778B0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag && !(collision == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
			if (<Team>k__BackingField != (Team)2)
			{
				while (!flag)
				{
				}
				Bullet bullet;
				while (bullet <= (ulong)100L)
				{
				}
				return;
			}
			BoardAction boardAction = this.board.boardAction;
			Bullet bullet2;
			bullet2.maxHitCount = num;
			int num2 = this.count;
			num2++;
			this.count = num2;
		}
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0005C20C File Offset: 0x0005A40C
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x477A90", Offset = "0x476090", VA = "0x180477A90")]
	private void SummonCaltrop()
	{
		int i = this.thePlantColumn;
		int num = 0;
		i++;
		int num2 = 0;
		int num3 = 0;
		if (num2 == num3)
		{
			CreatePlant instance = CreatePlant.Instance;
			int num4 = 0;
			Plant plant;
			if (plant != num4)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Transform axis = plant.axis;
				int num5 = 0;
				int thePlantRow = plant.thePlantRow;
				ulong num6;
				Particle particle = instance2.SetParticle((ParticleType)((uint)11), num5, thePlantRow, num6 != 0UL, (float)num);
			}
			Board board = this.board;
			i++;
			int columnNum = board.columnNum;
			while (i <= columnNum)
			{
			}
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0005C2A0 File Offset: 0x0005A4A0
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x477850", Offset = "0x475E50", VA = "0x180477850")]
	private void FireUpdate()
	{
		float thePlantAttackCountDown = this.thePlantAttackCountDown;
		int num = 0;
		if (thePlantAttackCountDown > (float)num)
		{
			base.UpdateAttackCountDown();
			this.SummonFire();
			float thePlantAttackInterval = this.thePlantAttackInterval;
			this.thePlantAttackCountDown = thePlantAttackInterval;
		}
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x0005C2D4 File Offset: 0x0005A4D4
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x477C80", Offset = "0x476280", VA = "0x180477C80")]
	private void SummonFire()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(this.thePlantRow, 0.5f, 1f);
				bool flag2;
				if (flag2)
				{
					num++;
					this.thePlantHealth = num;
				}
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0005C340 File Offset: 0x0005A540
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CaltropTorch()
	{
	}

	// Token: 0x04000BA8 RID: 2984
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA8")]
	private int count;
}
