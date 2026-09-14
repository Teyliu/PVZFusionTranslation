using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000612 RID: 1554
[Token(Token = "0x2000612")]
public class Tower_sunmine : TowerPlant
{
	// Token: 0x06001D31 RID: 7473 RVA: 0x0009B3EC File Offset: 0x000995EC
	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x57B5D0", Offset = "0x579BD0", VA = "0x18057B5D0", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float num = this.explodeRange * 1.5f;
		this.explodeRange = num;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x0009B42C File Offset: 0x0009962C
	[Token(Token = "0x6001D32")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "46")]
	protected override bool Shootable()
	{
		return false;
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x0009B43C File Offset: 0x0009963C
	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x57ABA0", Offset = "0x5791A0", VA = "0x18057ABA0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x0009B468 File Offset: 0x00099668
	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x57B3F0", Offset = "0x5799F0", VA = "0x18057B3F0", Slot = "16")]
	protected override void Update()
	{
		int num = 0;
		base.AttributeCountdown = (float)num;
		this.anim.SetTrigger("rise");
		base.Update();
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

	// Token: 0x06001D35 RID: 7477 RVA: 0x0009B504 File Offset: 0x00099704
	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x57B1E0", Offset = "0x5797E0", VA = "0x18057B1E0")]
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

	// Token: 0x06001D36 RID: 7478 RVA: 0x0009B548 File Offset: 0x00099748
	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x4688C0", Offset = "0x466EC0", VA = "0x1804688C0", Slot = "75")]
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

	// Token: 0x06001D37 RID: 7479 RVA: 0x0009B594 File Offset: 0x00099794
	[Token(Token = "0x6001D37")]
	[Address(RVA = "0x4733E0", Offset = "0x4719E0", VA = "0x1804733E0")]
	private void DelayDie()
	{
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x0009B5A4 File Offset: 0x000997A4
	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x57A970", Offset = "0x578F70", VA = "0x18057A970")]
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

	// Token: 0x06001D39 RID: 7481 RVA: 0x0009B624 File Offset: 0x00099824
	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x57A960", Offset = "0x578F60", VA = "0x18057A960")]
	public void AnimRiseOver()
	{
		this.isAready = true;
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x0009B638 File Offset: 0x00099838
	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x57ACA0", Offset = "0x5792A0", VA = "0x18057ACA0")]
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

	// Token: 0x06001D3B RID: 7483 RVA: 0x0009B6CC File Offset: 0x000998CC
	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x57ABE0", Offset = "0x5791E0", VA = "0x18057ABE0", Slot = "76")]
	protected virtual void BombEffect()
	{
		Transform axis = this.axis;
		LayerMask zombieLayer = this.zombieLayer;
		Vector3 vector;
		float z = vector.z;
		int damage = base.Damage;
		PlantType thePlantType = this.thePlantType;
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x0009B708 File Offset: 0x00099908
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x57B2A0", Offset = "0x5798A0", VA = "0x18057B2A0")]
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

	// Token: 0x06001D3D RID: 7485 RVA: 0x0009B754 File Offset: 0x00099954
	[Token(Token = "0x6001D3D")]
	[Address(RVA = "0x57AEE0", Offset = "0x5794E0", VA = "0x18057AEE0", Slot = "77")]
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

	// Token: 0x06001D3E RID: 7486 RVA: 0x0009B7E8 File Offset: 0x000999E8
	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x57B640", Offset = "0x579C40", VA = "0x18057B640")]
	public Tower_sunmine()
	{
	}

	// Token: 0x04000FD0 RID: 4048
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FD0")]
	public bool isAready;

	// Token: 0x04000FD1 RID: 4049
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000FD1")]
	private GameObject nearestZombie;

	// Token: 0x04000FD2 RID: 4050
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000FD2")]
	private float flashInterval = 3f;

	// Token: 0x04000FD3 RID: 4051
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000FD3")]
	private float flashTime;

	// Token: 0x04000FD4 RID: 4052
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000FD4")]
	private bool isActive;

	// Token: 0x04000FD5 RID: 4053
	[FieldOffset(Offset = "0x249")]
	[Token(Token = "0x4000FD5")]
	private bool explode;

	// Token: 0x04000FD6 RID: 4054
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000FD6")]
	private float explodeRange = 1f;
}
