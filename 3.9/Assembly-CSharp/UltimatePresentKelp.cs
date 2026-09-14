using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005EB RID: 1515
[Token(Token = "0x20005EB")]
public class UltimatePresentKelp : ThreePeater
{
	// Token: 0x06001C3A RID: 7226 RVA: 0x00096C04 File Offset: 0x00094E04
	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x569670", Offset = "0x567C70", VA = "0x180569670", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		if (base.BoxType == BoxType.Water)
		{
			int num = 0;
			base.Die((Plant.DieReason)num);
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
		}
		if (Lawnf.TravelUltimate((UltiBuff)((uint)28)))
		{
			Board board = this.board;
			float num2;
			base.AddSpeed(num2);
		}
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x00096C5C File Offset: 0x00094E5C
	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x5690D0", Offset = "0x5676D0", VA = "0x1805690D0", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		GridSystem gridSystem = this.board.gridSystem;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		int num = Mathf.Min(gridSystem.GetGrid(thePlantColumn, thePlantRow).WaterLevel, 1);
		float num2;
		base.ModifySpeed((PlantSpeedAdder)((uint)4), num2);
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x00096CB0 File Offset: 0x00094EB0
	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x568FF0", Offset = "0x5675F0", VA = "0x180568FF0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_goldSquashKelp;
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x00096CC0 File Offset: 0x00094EC0
	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x5693C0", Offset = "0x5679C0", VA = "0x1805693C0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			this.board.SetHealthInTravel(zombie);
			zombie.SetGold();
			Action<Zombie> action;
			zombie.onDeath = action;
			Transform axis2 = this.axis;
			ParticleManager instance2 = ParticleManager.Instance;
			Vector3 vector;
			float z = vector.z;
			int thePlantRow = this.thePlantRow;
			int num3 = 0;
			ulong num4;
			Particle particle = instance2.SetParticle((ParticleType)((uint)11), num, thePlantRow, num4 != 0UL, (float)num3);
		}
		base.UpdateText();
		return base.Shoot1();
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00096D54 File Offset: 0x00094F54
	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x5691A0", Offset = "0x5677A0", VA = "0x1805691A0")]
	private void OnZombieDeath(Zombie zombie)
	{
		int num = 0;
		if (zombie.existTime <= 10f)
		{
			Transform axis = zombie.axis;
			Vector3 vector;
			float z = vector.z;
			CreateBullet instance = CreateBullet.Instance;
			float num2 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
			float num3 = global::UnityEngine.Random.Range(-0.5f, 0.5f);
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			num++;
			bullet.fromType = (PlantType)((ulong)5003L);
		}
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x00096DD4 File Offset: 0x00094FD4
	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x569000", Offset = "0x567600", VA = "0x180569000", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x00096DF4 File Offset: 0x00094FF4
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimatePresentKelp()
	{
	}
}
