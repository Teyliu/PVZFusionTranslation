using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000335")]
public class TorchMine : TorchWood
{
	// Token: 0x06000EF5 RID: 3829 RVA: 0x00054CD4 File Offset: 0x00052ED4
	[Token(Token = "0x6000EF5")]
	[Address(RVA = "0x46D0F0", Offset = "0x46B6F0", VA = "0x18046D0F0", Slot = "68")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Bullet>(num);
		if (flag && !(collision == this))
		{
			Team <Team>k__BackingField = this.<Team>k__BackingField;
			int thePlantRow = this.thePlantRow;
			if (<Team>k__BackingField != (Team)2)
			{
				if (flag)
				{
				}
				Bullet bullet;
				while (bullet != (ulong)10L)
				{
				}
				BulletHelper hitHelper = bullet.hitHelper;
				Bullet bullet2;
				while (bullet2 <= (ulong)100L)
				{
				}
				return;
			}
			BoardAction boardAction = this.board.boardAction;
			Bullet bullet3;
			bullet3.maxHitCount = num;
			int num2 = this.count;
			num2++;
			this.count = num2;
		}
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00054D5C File Offset: 0x00052F5C
	[Token(Token = "0x6000EF6")]
	[Address(RVA = "0x46D320", Offset = "0x46B920", VA = "0x18046D320")]
	private void SummonMine()
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

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00054DF0 File Offset: 0x00052FF0
	[Token(Token = "0x6000EF7")]
	[Address(RVA = "0x46CF60", Offset = "0x46B560", VA = "0x18046CF60", Slot = "51")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00054E64 File Offset: 0x00053064
	[Token(Token = "0x6000EF8")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public TorchMine()
	{
	}

	// Token: 0x04000B57 RID: 2903
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B57")]
	private int count;
}
