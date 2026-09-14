using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200035E RID: 862
[Token(Token = "0x200035E")]
public class CaltropTorch : Plant
{
	// Token: 0x06000FC4 RID: 4036 RVA: 0x0005B198 File Offset: 0x00059398
	[Token(Token = "0x6000FC4")]
	[Address(RVA = "0x421010", Offset = "0x41F610", VA = "0x180421010", Slot = "16")]
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

	// Token: 0x06000FC5 RID: 4037 RVA: 0x0005B1D4 File Offset: 0x000593D4
	[Token(Token = "0x6000FC5")]
	[Address(RVA = "0x420960", Offset = "0x41EF60", VA = "0x180420960")]
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
			bullet2.penetrationTimes = num;
			int num2 = this.count;
			num2++;
			this.count = num2;
		}
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x0005B24C File Offset: 0x0005944C
	[Token(Token = "0x6000FC6")]
	[Address(RVA = "0x420B40", Offset = "0x41F140", VA = "0x180420B40")]
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

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0005B2E0 File Offset: 0x000594E0
	[Token(Token = "0x6000FC7")]
	[Address(RVA = "0x420900", Offset = "0x41EF00", VA = "0x180420900")]
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

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0005B314 File Offset: 0x00059514
	[Token(Token = "0x6000FC8")]
	[Address(RVA = "0x420D30", Offset = "0x41F330", VA = "0x180420D30")]
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

	// Token: 0x06000FC9 RID: 4041 RVA: 0x0005B380 File Offset: 0x00059580
	[Token(Token = "0x6000FC9")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CaltropTorch()
	{
	}

	// Token: 0x04000B57 RID: 2903
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B57")]
	private int count;
}
