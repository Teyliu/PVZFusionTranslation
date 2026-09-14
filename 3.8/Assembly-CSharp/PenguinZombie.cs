using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006AF RID: 1711
[Token(Token = "0x20006AF")]
public class PenguinZombie : Zombie
{
	// Token: 0x06002163 RID: 8547 RVA: 0x000B0048 File Offset: 0x000AE248
	[Token(Token = "0x6002163")]
	[Address(RVA = "0x564E20", Offset = "0x563420", VA = "0x180564E20", Slot = "22")]
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

	// Token: 0x06002164 RID: 8548 RVA: 0x000B00A8 File Offset: 0x000AE2A8
	[Token(Token = "0x6002164")]
	[Address(RVA = "0x564F70", Offset = "0x563570", VA = "0x180564F70", Slot = "18")]
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

	// Token: 0x06002165 RID: 8549 RVA: 0x000B0140 File Offset: 0x000AE340
	[Token(Token = "0x6002165")]
	[Address(RVA = "0x564C80", Offset = "0x563280", VA = "0x180564C80", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return base.CanAttack(target);
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x000B0158 File Offset: 0x000AE358
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x564F30", Offset = "0x563530", VA = "0x180564F30")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000B0178 File Offset: 0x000AE378
	[Token(Token = "0x6002167")]
	[Address(RVA = "0x564860", Offset = "0x562E60", VA = "0x180564860")]
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
			LayerMask zombieLayer = this.zombieLayer;
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

	// Token: 0x06002168 RID: 8552 RVA: 0x000B020C File Offset: 0x000AE40C
	[Token(Token = "0x6002168")]
	[Address(RVA = "0x533DF0", Offset = "0x5323F0", VA = "0x180533DF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x000B021C File Offset: 0x000AE41C
	[Token(Token = "0x6002169")]
	[Address(RVA = "0x564CE0", Offset = "0x5632E0", VA = "0x180564CE0", Slot = "28")]
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

	// Token: 0x0600216A RID: 8554 RVA: 0x000B0268 File Offset: 0x000AE468
	[Token(Token = "0x600216A")]
	[Address(RVA = "0x564CA0", Offset = "0x5632A0", VA = "0x180564CA0", Slot = "25")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x000B0278 File Offset: 0x000AE478
	[Token(Token = "0x600216B")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool fromFreeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, fromFreeze);
			return;
		}
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000B0294 File Offset: 0x000AE494
	[Token(Token = "0x600216C")]
	[Address(RVA = "0x550040", Offset = "0x54E640", VA = "0x180550040", Slot = "51")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
		if (theFreezeLevel > 0)
		{
			int num = 0;
			base.SetFreeze(time, num);
			return;
		}
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000B02B0 File Offset: 0x000AE4B0
	[Token(Token = "0x600216D")]
	[Address(RVA = "0x564C70", Offset = "0x563270", VA = "0x180564C70", Slot = "56")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
		base.Buttered(time, sprite);
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000B02C8 File Offset: 0x000AE4C8
	[Token(Token = "0x600216E")]
	[Address(RVA = "0x5651A0", Offset = "0x5637A0", VA = "0x1805651A0")]
	public PenguinZombie()
	{
	}
}
