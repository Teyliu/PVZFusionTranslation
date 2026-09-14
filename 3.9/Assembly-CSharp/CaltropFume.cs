using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000369 RID: 873
[Token(Token = "0x2000369")]
public class CaltropFume : Caltrop
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000FFA RID: 4090 RVA: 0x0005BBE0 File Offset: 0x00059DE0
	[Token(Token = "0x17000119")]
	protected override Collider2D[] Cols
	{
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x476AE0", Offset = "0x4750E0", VA = "0x180476AE0", Slot = "68")]
		get
		{
			Transform axis = this.axis;
			int num = this.zombieLayer;
			Collider2D[] array;
			return array;
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0005BC0C File Offset: 0x00059E0C
	[Token(Token = "0x6000FFB")]
	[Address(RVA = "0x4768D0", Offset = "0x474ED0", VA = "0x1804768D0", Slot = "69")]
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

	// Token: 0x06000FFC RID: 4092 RVA: 0x0005BC5C File Offset: 0x00059E5C
	[Token(Token = "0x6000FFC")]
	[Address(RVA = "0x476770", Offset = "0x474D70", VA = "0x180476770")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
		bool flag;
		ulong num;
		if (flag && num != (ulong)0L)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				GameAPP.PlaySound(77, 0.5f, 1f);
				int num2 = 0;
				base.Die((Plant.DieReason)num2);
			}
		}
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0005BCA4 File Offset: 0x00059EA4
	[Token(Token = "0x6000FFD")]
	[Address(RVA = "0x4769F0", Offset = "0x474FF0", VA = "0x1804769F0")]
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

	// Token: 0x06000FFE RID: 4094 RVA: 0x0005BCFC File Offset: 0x00059EFC
	[Token(Token = "0x6000FFE")]
	[Address(RVA = "0x4764C0", Offset = "0x474AC0", VA = "0x1804764C0", Slot = "71")]
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

	// Token: 0x06000FFF RID: 4095 RVA: 0x0005BD98 File Offset: 0x00059F98
	[Token(Token = "0x6000FFF")]
	[Address(RVA = "0x473A90", Offset = "0x472090", VA = "0x180473A90")]
	public CaltropFume()
	{
		this.range = 1f;
		base..ctor();
	}
}
