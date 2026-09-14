using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032B RID: 811
[Token(Token = "0x200032B")]
public class PotatoMine : Plant
{
	// Token: 0x06000EB1 RID: 3761 RVA: 0x00053B68 File Offset: 0x00051D68
	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x468260", Offset = "0x466860", VA = "0x180468260", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00053B94 File Offset: 0x00051D94
	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x468770", Offset = "0x466D70", VA = "0x180468770", Slot = "35")]
	protected override bool OnCrash()
	{
		if (!this.isAready)
		{
		}
		this.Explode();
		return true;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00053BB8 File Offset: 0x00051DB8
	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x468B30", Offset = "0x467130", VA = "0x180468B30", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
		}
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00053BD4 File Offset: 0x00051DD4
	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x468910", Offset = "0x466F10", VA = "0x180468910", Slot = "68")]
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

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00053C34 File Offset: 0x00051E34
	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x4687A0", Offset = "0x466DA0", VA = "0x1804687A0", Slot = "69")]
	protected virtual void OnFlash()
	{
		this.anim.Play("flash");
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00053C58 File Offset: 0x00051E58
	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x4687F0", Offset = "0x466DF0", VA = "0x1804687F0", Slot = "70")]
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

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00053C9C File Offset: 0x00051E9C
	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x4688C0", Offset = "0x466EC0", VA = "0x1804688C0", Slot = "71")]
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

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00053CE8 File Offset: 0x00051EE8
	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x468030", Offset = "0x466630", VA = "0x180468030")]
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

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00053D64 File Offset: 0x00051F64
	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x468020", Offset = "0x466620", VA = "0x180468020")]
	public void AnimRiseOver()
	{
		this.isAready = true;
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00053D78 File Offset: 0x00051F78
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x468320", Offset = "0x466920", VA = "0x180468320", Slot = "72")]
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

	// Token: 0x06000EBB RID: 3771 RVA: 0x00053DDC File Offset: 0x00051FDC
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x4682A0", Offset = "0x4668A0", VA = "0x1804682A0", Slot = "73")]
	protected virtual void BombEffect()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		PlantType thePlantType = this.thePlantType;
		int attackDamage = this.attackDamage;
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00053E10 File Offset: 0x00052010
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x4689E0", Offset = "0x466FE0", VA = "0x1804689E0")]
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

	// Token: 0x06000EBD RID: 3773 RVA: 0x00053E5C File Offset: 0x0005205C
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x468470", Offset = "0x466A70", VA = "0x180468470", Slot = "74")]
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

	// Token: 0x06000EBE RID: 3774 RVA: 0x00053EF0 File Offset: 0x000520F0
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x467BF0", Offset = "0x4661F0", VA = "0x180467BF0")]
	public PotatoMine()
	{
	}

	// Token: 0x04000B3A RID: 2874
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000B3A")]
	public bool isAready;

	// Token: 0x04000B3B RID: 2875
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000B3B")]
	private GameObject nearestZombie;

	// Token: 0x04000B3C RID: 2876
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B3C")]
	protected float flashInterval = 3f;

	// Token: 0x04000B3D RID: 2877
	[FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000B3D")]
	protected float flashTime;

	// Token: 0x04000B3E RID: 2878
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B3E")]
	public bool exploded;
}
