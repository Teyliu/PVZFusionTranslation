using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000325 RID: 805
[Token(Token = "0x2000325")]
public class TorchMine : TorchWood
{
	// Token: 0x06000EAB RID: 3755 RVA: 0x00053CBC File Offset: 0x00051EBC
	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x414CF0", Offset = "0x4132F0", VA = "0x180414CF0", Slot = "69")]
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
			bullet3.penetrationTimes = num;
			int num2 = this.count;
			num2++;
			this.count = num2;
		}
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00053D44 File Offset: 0x00051F44
	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x414F20", Offset = "0x413520", VA = "0x180414F20")]
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

	// Token: 0x06000EAD RID: 3757 RVA: 0x00053DD8 File Offset: 0x00051FD8
	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x414B60", Offset = "0x413160", VA = "0x180414B60", Slot = "52")]
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

	// Token: 0x06000EAE RID: 3758 RVA: 0x00053E4C File Offset: 0x0005204C
	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public TorchMine()
	{
	}

	// Token: 0x04000B06 RID: 2822
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B06")]
	private int count;
}
