using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000359 RID: 857
[Token(Token = "0x2000359")]
public class CaltropFume : Caltrop
{
	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0005AC50 File Offset: 0x00058E50
	[Token(Token = "0x170000D6")]
	protected override Collider2D[] Cols
	{
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x41FB90", Offset = "0x41E190", VA = "0x18041FB90", Slot = "69")]
		get
		{
			Transform axis = this.axis;
			int num = this.zombieLayer;
			Collider2D[] array;
			return array;
		}
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x0005AC7C File Offset: 0x00058E7C
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x41F980", Offset = "0x41DF80", VA = "0x18041F980", Slot = "70")]
	protected override void ReadyToAttack()
	{
		int num = 0;
		Collider2D[] cols = this.Cols;
		if (num < cols.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int thePlantRow = this.thePlantRow;
				this.anim.SetTrigger("attack");
			}
			num++;
		}
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0005ACCC File Offset: 0x00058ECC
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x41F830", Offset = "0x41DE30", VA = "0x18041F830")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			int thePlantRow = this.thePlantRow;
			bool flag3;
			if (flag3)
			{
				GameAPP.PlaySound(77, 0.5f, 1f);
				int num = 0;
				base.Die((Plant.DieReason)num);
			}
		}
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0005AD10 File Offset: 0x00058F10
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x41FAA0", Offset = "0x41E0A0", VA = "0x18041FAA0")]
	private void StartShoot()
	{
		GameAPP.PlaySound((SoundType)((uint)58), 0.5f, 1f);
		Transform shoot = this.shoot;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		int thePlantRow = this.thePlantRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)158), num, thePlantRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0005AD68 File Offset: 0x00058F68
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x41F580", Offset = "0x41DB80", VA = "0x18041F580", Slot = "72")]
	protected override void AnimAttack()
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] cols = this.Cols;
		if (num < cols.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int thePlantRow = this.thePlantRow;
				PlantType thePlantType = this.thePlantType;
				num = num2;
				if (TypeMgr.IsDriverZombie((ZombieType)num2))
				{
					num = num2;
					if (!TypeMgr.IsBossZombie((ZombieType)num2))
					{
						PlantType thePlantType2 = this.thePlantType;
					}
				}
			}
			num++;
		}
		if (num2 != 0)
		{
			uint num4;
			GameAPP.PlaySound(global::UnityEngine.Random.Range(0, (int)num4), 0.5f, 1f);
		}
		if (num3 != 0)
		{
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
		}
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0005AE04 File Offset: 0x00059004
	[Token(Token = "0x6000FB3")]
	[Address(RVA = "0x41CBF0", Offset = "0x41B1F0", VA = "0x18041CBF0")]
	public CaltropFume()
	{
		this.range = 1f;
		base..ctor();
	}
}
