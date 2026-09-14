using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200031B RID: 795
[Token(Token = "0x200031B")]
public class PotatoMine : Plant
{
	// Token: 0x06000E67 RID: 3687 RVA: 0x00052B60 File Offset: 0x00050D60
	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x4127B0", Offset = "0x410DB0", VA = "0x1804127B0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00052B8C File Offset: 0x00050D8C
	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x412CC0", Offset = "0x4112C0", VA = "0x180412CC0", Slot = "36")]
	protected override bool OnCrash()
	{
		if (!this.isAready)
		{
		}
		this.Explode();
		return true;
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00052BB0 File Offset: 0x00050DB0
	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x413080", Offset = "0x411680", VA = "0x180413080", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00052BCC File Offset: 0x00050DCC
	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x412E60", Offset = "0x411460", VA = "0x180412E60", Slot = "69")]
	protected virtual void PotatoUpdate()
	{
		int num = 0;
		base.AttributeCountdown = (float)num;
		this.anim.SetTrigger("rise");
		this.SetFlash();
		if (this.isAready)
		{
			float deltaTime = Time.deltaTime;
			this.flashTime = deltaTime;
			if (deltaTime > this.flashInterval)
			{
				this.flashTime = 0f;
			}
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00052C2C File Offset: 0x00050E2C
	[Token(Token = "0x6000E6B")]
	[Address(RVA = "0x412CF0", Offset = "0x4112F0", VA = "0x180412CF0", Slot = "70")]
	protected virtual void OnFlash()
	{
		this.anim.Play("flash");
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00052C50 File Offset: 0x00050E50
	[Token(Token = "0x6000E6C")]
	[Address(RVA = "0x412D40", Offset = "0x411340", VA = "0x180412D40", Slot = "71")]
	protected virtual void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		bool flag2;
		if (flag && flag2)
		{
			int thePlantRow = this.thePlantRow;
			if (this.isAready && !this.exploded)
			{
				this.exploded = true;
				this.Explode();
			}
		}
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00052C94 File Offset: 0x00050E94
	[Token(Token = "0x6000E6D")]
	[Address(RVA = "0x412E10", Offset = "0x411410", VA = "0x180412E10", Slot = "72")]
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

	// Token: 0x06000E6E RID: 3694 RVA: 0x00052CE0 File Offset: 0x00050EE0
	[Token(Token = "0x6000E6E")]
	[Address(RVA = "0x412580", Offset = "0x410B80", VA = "0x180412580")]
	public void AnimStartRise(float timer = 1f)
	{
		GameAPP.PlaySound(48, 0.5f, 1f);
		this.invincible = true;
		base.Invoke("AnimRiseOver", timer);
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		Transform transform3 = base.transform;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[9];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform4 = this.board.transform;
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00052D5C File Offset: 0x00050F5C
	[Token(Token = "0x6000E6F")]
	[Address(RVA = "0x412570", Offset = "0x410B70", VA = "0x180412570")]
	public void AnimRiseOver()
	{
		this.isAready = true;
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00052D70 File Offset: 0x00050F70
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x412870", Offset = "0x410E70", VA = "0x180412870", Slot = "73")]
	public virtual void Explode()
	{
		int num = 0;
		base.Die((Plant.DieReason)num);
		this.BombEffect();
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)8), num2, 11, num4 != 0UL, (float)num3);
		GameAPP.PlaySound(47, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00052DD4 File Offset: 0x00050FD4
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x4127F0", Offset = "0x410DF0", VA = "0x1804127F0", Slot = "74")]
	protected virtual void BombEffect()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00052E08 File Offset: 0x00051008
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x412F30", Offset = "0x411530", VA = "0x180412F30")]
	protected void SetFlash()
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

	// Token: 0x06000E73 RID: 3699 RVA: 0x00052E54 File Offset: 0x00051054
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x4129C0", Offset = "0x410FC0", VA = "0x1804129C0", Slot = "75")]
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

	// Token: 0x06000E74 RID: 3700 RVA: 0x00052EE8 File Offset: 0x000510E8
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public PotatoMine()
	{
	}

	// Token: 0x04000AE9 RID: 2793
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000AE9")]
	public bool isAready;

	// Token: 0x04000AEA RID: 2794
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000AEA")]
	private GameObject nearestZombie;

	// Token: 0x04000AEB RID: 2795
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000AEB")]
	protected float flashInterval = 3f;

	// Token: 0x04000AEC RID: 2796
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000AEC")]
	protected float flashTime;

	// Token: 0x04000AED RID: 2797
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000AED")]
	public bool exploded;
}
