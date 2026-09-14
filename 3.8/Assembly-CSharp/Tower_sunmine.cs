using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DD RID: 1501
[Token(Token = "0x20005DD")]
public class Tower_sunmine : TowerPlant
{
	// Token: 0x06001C32 RID: 7218 RVA: 0x00096838 File Offset: 0x00094A38
	[Token(Token = "0x6001C32")]
	[Address(RVA = "0x513CA0", Offset = "0x5122A0", VA = "0x180513CA0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.explodeRange * 1.5f;
		this.explodeRange = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x00096878 File Offset: 0x00094A78
	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "47")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x00096888 File Offset: 0x00094A88
	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x513270", Offset = "0x511870", VA = "0x180513270", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000968C0 File Offset: 0x00094AC0
	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x513AA0", Offset = "0x5120A0", VA = "0x180513AA0", Slot = "16")]
	protected override void Update()
	{
		int num = 0;
		base.AttributeCountdown = (float)num;
		this.anim.SetTrigger("rise");
		base.Update();
		if (base.Active)
		{
			base.ShootUpdate();
		}
		GameObject gameObject = this.GetNearestZombie();
		int num2 = 0;
		if (!(gameObject == num2))
		{
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
		}
		if (this.isAready)
		{
			float deltaTime = Time.deltaTime;
			this.flashTime = deltaTime;
			if (deltaTime > this.flashInterval)
			{
				Animator anim = this.anim;
				this.flashTime = 0f;
				anim.Play("flash");
			}
		}
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x00096968 File Offset: 0x00094B68
	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x513890", Offset = "0x511E90", VA = "0x180513890")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			int thePlantRow = this.thePlantRow;
			if (this.isAready && !this.explode)
			{
				this.explode = true;
				this.Explode();
			}
		}
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x000969AC File Offset: 0x00094BAC
	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x412E10", Offset = "0x411410", VA = "0x180412E10", Slot = "76")]
	protected virtual bool PotatoSearchZombie(Zombie zombie)
	{
		do
		{
			if (!zombie.beforeDying && !zombie.isMindControlled)
			{
				ZombieStatus theStatus = zombie.theStatus;
				if (theStatus <= ZombieStatus.Flying)
				{
					continue;
				}
				if (theStatus != ZombieStatus.Polo_jump && theStatus != ZombieStatus.Imp_fly)
				{
					return true;
				}
			}
		}
		while (0 <= 2);
		while (this == (ulong)10L)
		{
		}
		return true;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x000969F8 File Offset: 0x00094BF8
	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x41C540", Offset = "0x41AB40", VA = "0x18041C540")]
	private void DelayDie()
	{
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x00096A08 File Offset: 0x00094C08
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x513040", Offset = "0x511640", VA = "0x180513040")]
	public void AnimStartRise()
	{
		GameAPP.PlaySound(48, 0.5f, 1f);
		this.invincible = true;
		base.Invoke("AnimRiseOver", 1f);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[9];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform4 = this.board.transform;
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x00096A88 File Offset: 0x00094C88
	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x513030", Offset = "0x511630", VA = "0x180513030")]
	public void AnimRiseOver()
	{
		this.isAready = true;
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x00096A9C File Offset: 0x00094C9C
	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x513350", Offset = "0x511950", VA = "0x180513350")]
	public void Explode()
	{
		if (!this.isActive)
		{
			base.Invoke("DelayDie", 0.1f);
			this.isActive = true;
		}
		this.BombEffect();
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num, 11, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		CreateItem instance2 = CreateItem.Instance;
		CreateItem instance3 = CreateItem.Instance;
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x00096B30 File Offset: 0x00094D30
	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x5132C0", Offset = "0x5118C0", VA = "0x1805132C0", Slot = "77")]
	protected virtual void BombEffect()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x00096B5C File Offset: 0x00094D5C
	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x513950", Offset = "0x511F50", VA = "0x180513950")]
	private void SetFlash()
	{
		GameObject gameObject = this.GetNearestZombie();
		int num = 0;
		if (!(gameObject == num))
		{
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			float num2;
			this.flashInterval = num2;
			return;
		}
		this.flashInterval = 6f;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00096BA8 File Offset: 0x00094DA8
	[Token(Token = "0x6001C3E")]
	[Address(RVA = "0x513590", Offset = "0x511B90", VA = "0x180513590", Slot = "78")]
	protected virtual GameObject GetNearestZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			this.nearestZombie = num2;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				Transform transform = base.transform;
				int thePlantRow = this.thePlantRow;
				Vector3 vector;
				float z = vector.z;
				Transform transform2 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				GameObject gameObject;
				this.nearestZombie = gameObject;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x00096C3C File Offset: 0x00094E3C
	[Token(Token = "0x6001C3F")]
	[Address(RVA = "0x513D10", Offset = "0x512310", VA = "0x180513D10")]
	public Tower_sunmine()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F08 RID: 3848
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F08")]
	public bool isAready;

	// Token: 0x04000F09 RID: 3849
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F09")]
	private GameObject nearestZombie;

	// Token: 0x04000F0A RID: 3850
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F0A")]
	private float flashInterval = 3f;

	// Token: 0x04000F0B RID: 3851
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000F0B")]
	private float flashTime;

	// Token: 0x04000F0C RID: 3852
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000F0C")]
	private bool isActive;

	// Token: 0x04000F0D RID: 3853
	[FieldOffset(Offset = "0x249")]
	[Token(Token = "0x4000F0D")]
	private bool explode;

	// Token: 0x04000F0E RID: 3854
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000F0E")]
	private float explodeRange = 1f;
}
