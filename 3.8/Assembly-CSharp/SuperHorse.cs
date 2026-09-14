using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DE RID: 1758
[Token(Token = "0x20006DE")]
public class SuperHorse : Zombie
{
	// Token: 0x060022AB RID: 8875 RVA: 0x000B6014 File Offset: 0x000B4214
	[Token(Token = "0x60022AB")]
	[Address(RVA = "0x551420", Offset = "0x54FA20", VA = "0x180551420", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1.5f;
	}

	// Token: 0x060022AC RID: 8876 RVA: 0x000B6034 File Offset: 0x000B4234
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x577F60", Offset = "0x576560", VA = "0x180577F60", Slot = "74")]
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

	// Token: 0x060022AD RID: 8877 RVA: 0x000B6098 File Offset: 0x000B4298
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x5789A0", Offset = "0x576FA0", VA = "0x1805789A0", Slot = "65")]
	protected override int SecondArmorTakeDamage(int theDamage)
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		ulong num2;
		this.anim.SetBool("revive", num2 != 0UL);
		int theSecondArmorHealth = this.theSecondArmorHealth;
		int num3 = 0;
		this.theHealth = num3;
		this.theSecondArmorHealth = num3;
		this.theSecondArmorType = (Zombie.SecondArmorType)num3;
		this.theSecondArmor = num3;
		return theDamage;
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000B60FC File Offset: 0x000B42FC
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x534700", Offset = "0x532D00", VA = "0x180534700", Slot = "64")]
	protected override void SecondArmorBroken()
	{
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x000B610C File Offset: 0x000B430C
	[Token(Token = "0x60022AF")]
	[Address(RVA = "0x5786D0", Offset = "0x576CD0", VA = "0x1805786D0", Slot = "29")]
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
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x000B614C File Offset: 0x000B434C
	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x000B616C File Offset: 0x000B436C
	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x578610", Offset = "0x576C10", VA = "0x180578610", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.attributeCountDown = 1.5f;
		this.anim.SetTrigger("shoot");
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000B619C File Offset: 0x000B439C
	[Token(Token = "0x17000166")]
	protected virtual BulletType BulletType
	{
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "75")]
		get
		{
			return BulletType.Bullet_ironPea;
		}
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000B61AC File Offset: 0x000B43AC
	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x578460", Offset = "0x576A60", VA = "0x180578460")]
	private void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.BulletType;
		BulletType bulletType2 = this.BulletType;
		Bullet bullet;
		bullet.Damage = 80;
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x000B61EC File Offset: 0x000B43EC
	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x578890", Offset = "0x576E90", VA = "0x180578890", Slot = "45")]
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

	// Token: 0x060022B5 RID: 8885 RVA: 0x000B6254 File Offset: 0x000B4454
	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x577EB0", Offset = "0x5764B0", VA = "0x180577EB0")]
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

	// Token: 0x060022B6 RID: 8886 RVA: 0x000B6294 File Offset: 0x000B4494
	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x5781A0", Offset = "0x5767A0", VA = "0x1805781A0", Slot = "76")]
	protected virtual void AnimRevive()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform axis = this.axis;
		int num = 0;
		Transform child = axis.GetChild(num);
		int num2 = 0;
		Vector3 vector;
		float z = vector.z;
		int num3 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)121), num2, theZombieRow, num4 != 0UL, (float)num3);
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		int num5 = 0;
		Transform child2 = axis2.GetChild(num5);
		int num6 = 0;
		Zombie zombie;
		if (zombie != num6)
		{
			zombie.theHealth = (int)((ulong)1800L);
			zombie.theMaxHealth = (int)((ulong)1800L);
			zombie.theFirstArmorHealth = (int)((ulong)1L);
		}
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x000B6364 File Offset: 0x000B4564
	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x000B6374 File Offset: 0x000B4574
	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x5749D0", Offset = "0x572FD0", VA = "0x1805749D0")]
	public SuperHorse()
	{
	}

	// Token: 0x04001139 RID: 4409
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001139")]
	private bool summoned;
}
