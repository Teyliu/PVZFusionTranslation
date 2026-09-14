using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E6 RID: 1766
[Token(Token = "0x20006E6")]
public class PenguinZombie : Zombie
{
	// Token: 0x0600227A RID: 8826 RVA: 0x000B4CF0 File Offset: 0x000B2EF0
	[Token(Token = "0x600227A")]
	[Address(RVA = "0x5C86D0", Offset = "0x5C6CD0", VA = "0x1805C86D0", Slot = "23")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		List<IceRoad> iceRoads = Board.Instance.iceRoads;
		int theZombieRow = this.theZombieRow;
		IceRoad iceRoad = iceRoads[theZombieRow];
		Transform axis = this.axis;
		float x = iceRoad.x;
		this.anim.Play("skating");
		this.theStatus = (ZombieStatus)((ulong)43L);
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000B4D50 File Offset: 0x000B2F50
	[Token(Token = "0x600227B")]
	[Address(RVA = "0x5C8820", Offset = "0x5C6E20", VA = "0x1805C8820", Slot = "19")]
	protected override void ZombieUpdate()
	{
		int num = 0;
		base.ZombieUpdate();
		List<IceRoad> iceRoads = Board.Instance.iceRoads;
		int theZombieRow = this.theZombieRow;
		IceRoad iceRoad = iceRoads[theZombieRow];
		Transform axis = this.axis;
		float x = iceRoad.x;
		this.anim.SetTrigger("walk");
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int theZombieRow2 = this.theZombieRow;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow2, num3 != 0UL, (float)num2);
		int num4 = 0;
		base.ChangeStatus((ZombieStatus)num4);
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000B4DE8 File Offset: 0x000B2FE8
	[Token(Token = "0x600227C")]
	[Address(RVA = "0x5C8530", Offset = "0x5C6B30", VA = "0x1805C8530", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000B4E00 File Offset: 0x000B3000
	[Token(Token = "0x600227D")]
	[Address(RVA = "0x5C87E0", Offset = "0x5C6DE0", VA = "0x1805C87E0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000B4E20 File Offset: 0x000B3020
	[Token(Token = "0x600227E")]
	[Address(RVA = "0x5C8110", Offset = "0x5C6710", VA = "0x1805C8110")]
	private void AnimCrash()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				int theZombieRow = this.theZombieRow;
				num++;
			}
			bool flag2;
			if (flag2)
			{
				int theZombieRow2 = this.theZombieRow;
			}
			num++;
			int num3 = this.zombieLayer;
			Collider2D[] array2;
			if (num < array2.Length)
			{
				bool flag3;
				if (flag3 && Lawnf.InLandStatus((ZombieStatus)num))
				{
					int theZombieRow3 = this.theZombieRow;
				}
				num++;
			}
		}
		ScreenShake.TriggerShake(0.05f);
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000B4EBC File Offset: 0x000B30BC
	[Token(Token = "0x600227F")]
	[Address(RVA = "0x58AAD0", Offset = "0x5890D0", VA = "0x18058AAD0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000B4ECC File Offset: 0x000B30CC
	[Token(Token = "0x6002280")]
	[Address(RVA = "0x5C8590", Offset = "0x5C6B90", VA = "0x1805C8590", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		int num = 0;
		if (reason == 0)
		{
			Transform axis = this.axis;
			ParticleManager instance = ParticleManager.Instance;
			Vector3 vector;
			float z = vector.z;
			int theZombieRow = this.theZombieRow;
			int num2 = 0;
			ulong num3;
			Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
		}
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000B4F18 File Offset: 0x000B3118
	[Token(Token = "0x6002281")]
	[Address(RVA = "0x5C8550", Offset = "0x5C6B50", VA = "0x1805C8550", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000B4F28 File Offset: 0x000B3128
	[Token(Token = "0x6002282")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000B4F44 File Offset: 0x000B3144
	[Token(Token = "0x6002283")]
	[Address(RVA = "0x5B3BD0", Offset = "0x5B21D0", VA = "0x1805B3BD0", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000B4F60 File Offset: 0x000B3160
	[Token(Token = "0x6002284")]
	[Address(RVA = "0x5C8520", Offset = "0x5C6B20", VA = "0x1805C8520", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		base.Buttered(time, sprite);
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000B4F78 File Offset: 0x000B3178
	[Token(Token = "0x6002285")]
	[Address(RVA = "0x5C8A50", Offset = "0x5C7050", VA = "0x1805C8A50")]
	public PenguinZombie()
	{
	}
}
