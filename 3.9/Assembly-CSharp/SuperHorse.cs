using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000716 RID: 1814
[Token(Token = "0x2000716")]
public class SuperHorse : Zombie
{
	// Token: 0x060023C5 RID: 9157 RVA: 0x000BADA4 File Offset: 0x000B8FA4
	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x5B4FB0", Offset = "0x5B35B0", VA = "0x1805B4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x000BADC4 File Offset: 0x000B8FC4
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x5F2450", Offset = "0x5F0A50", VA = "0x1805F2450", Slot = "76")]
	protected virtual void AnimFlagUp()
	{
		Board board = this.board;
		int num = 0;
		if (num < board.rowNum)
		{
			BoxType[] roadType = this.board.roadType;
			if ("{il2cpp array field local5->}" != (ulong)1L)
			{
				CreateZombie instance = CreateZombie.Instance;
				int num2 = 0;
				Zombie zombie;
				if (zombie != num2)
				{
				}
			}
			Board board2 = this.board;
			num++;
			uint num3;
			num3 += (uint)4;
		}
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x000BAE28 File Offset: 0x000B9028
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x5F2F30", Offset = "0x5F1530", VA = "0x1805F2F30", Slot = "67")]
	protected override int SecondArmorTakeDamage(int theDamage)
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		ulong num2;
		this.anim.SetBool("revive", num2 != 0UL);
		int theSecondArmorHealth = this.theSecondArmorHealth;
		int num3 = 0;
		this.theHealth = (long)num3;
		this.theSecondArmorHealth = num3;
		this.theSecondArmorType = (Zombie.SecondArmorType)num3;
		this.theSecondArmor = num3;
		return theDamage;
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x000BAE8C File Offset: 0x000B908C
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x58B3E0", Offset = "0x5899E0", VA = "0x18058B3E0", Slot = "66")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x000BAE9C File Offset: 0x000B909C
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x5F2A70", Offset = "0x5F1070", VA = "0x1805F2A70", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x000BAEDC File Offset: 0x000B90DC
	[Token(Token = "0x60023CA")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x000BAEFC File Offset: 0x000B90FC
	[Token(Token = "0x60023CB")]
	[Address(RVA = "0x5F29B0", Offset = "0x5F0FB0", VA = "0x1805F29B0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.attributeCountDown = 1.5f;
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x060023CC RID: 9164 RVA: 0x000BAF2C File Offset: 0x000B912C
	[Token(Token = "0x170001AC")]
	protected virtual BulletType BulletType
	{
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "77")]
		get
		{
			return BulletType.Bullet_ironPea;
		}
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x000BAF3C File Offset: 0x000B913C
	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x5F2800", Offset = "0x5F0E00", VA = "0x1805F2800")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.BulletType;
		BulletType bulletType2 = this.BulletType;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000BAF7C File Offset: 0x000B917C
	[Token(Token = "0x60023CE")]
	[Address(RVA = "0x5F2C30", Offset = "0x5F1230", VA = "0x1805F2C30", Slot = "47")]
	public override void DestoryZombie()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)120), num, theZombieRow, num3 != 0UL, (float)num2);
		GameAPP.PlaySound(142, 0.5f, 1f);
		IEnumerator enumerator = base.FadeDeath();
		Coroutine coroutine = base.StartCoroutine(enumerator);
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x000BAFE4 File Offset: 0x000B91E4
	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x5F23A0", Offset = "0x5F09A0", VA = "0x1805F23A0")]
	private void AnimDestoryHorse()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, theZombieRow, num3 != 0UL, (float)num2);
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x000BB024 File Offset: 0x000B9224
	[Token(Token = "0x60023D0")]
	[Address(RVA = "0x5F2D40", Offset = "0x5F1340", VA = "0x1805F2D40", Slot = "28")]
	public override void Die(int reason = 0)
	{
		if (reason == 0)
		{
			Animator anim = this.anim;
			this.theStatus = (ZombieStatus)((ulong)1L);
			anim.SetTrigger("GoDie");
			return;
		}
		base.Die(reason);
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x000BB060 File Offset: 0x000B9260
	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x5F2690", Offset = "0x5F0C90", VA = "0x1805F2690")]
	private void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		int num3 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)121), num2, theZombieRow, num4 != 0UL, (float)num3);
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
		this.ReviveZombie();
		this.theStatus = (ZombieStatus)((ulong)0L);
		base.Die(2);
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x000BB0E0 File Offset: 0x000B92E0
	[Token(Token = "0x60023D2")]
	[Address(RVA = "0x5F2DD0", Offset = "0x5F13D0", VA = "0x1805F2DD0", Slot = "78")]
	protected virtual void ReviveZombie()
	{
		Transform axis = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Zombie zombie;
		if (zombie != num2)
		{
			zombie.theHealth = (long)((ulong)1800L);
			zombie.theMaxHealth = (long)((ulong)1800L);
			zombie.theFirstArmorHealth = (int)((ulong)1L);
		}
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x000BB140 File Offset: 0x000B9340
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x000BB150 File Offset: 0x000B9350
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x5F3030", Offset = "0x5F1630", VA = "0x1805F3030")]
	public SuperHorse()
	{
	}

	// Token: 0x04001206 RID: 4614
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001206")]
	private bool summoned;
}
