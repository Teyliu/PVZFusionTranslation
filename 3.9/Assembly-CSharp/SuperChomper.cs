using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200034A RID: 842
[Token(Token = "0x200034A")]
public class SuperChomper : Chomper
{
	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00058F98 File Offset: 0x00057198
	[Token(Token = "0x17000115")]
	public override int LimDamage
	{
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x46C280", Offset = "0x46A880", VA = "0x18046C280", Slot = "65")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x00058FA8 File Offset: 0x000571A8
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "39")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x00058FB8 File Offset: 0x000571B8
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x46B5B0", Offset = "0x469BB0", VA = "0x18046B5B0", Slot = "71")]
	public override void ChomperSearchZombie([Optional] Collider2D collision)
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			float chompRange = base.ChompRange;
			int num3 = this.zombieLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag;
				if (flag)
				{
					if (flag <= true)
					{
					}
					num++;
					int thePlantRow = this.thePlantRow;
					this.targetZombie = num;
				}
				num++;
			}
			Zombie targetZombie = this.targetZombie;
			int num4 = 0;
			if (targetZombie != num4)
			{
				break;
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (!(num2 != num5) || !base.CheckZombie(num2))
				{
					continue;
				}
				this.targetZombie = num2;
				this.anim.SetTrigger("bite");
				this.theStatus = (PlantStatus)((ulong)22L);
			}
		}
		while (num != 0);
		this.anim.SetTrigger("bite");
		this.theStatus = (PlantStatus)((ulong)22L);
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x000590B0 File Offset: 0x000572B0
	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x46B200", Offset = "0x469800", VA = "0x18046B200", Slot = "73")]
	public override void BiteEvent()
	{
		Zombie targetZombie = this.targetZombie;
		int num = 0;
		if (targetZombie != num)
		{
			if (!this.targetZombie.isMindControlled)
			{
				throw new NullReferenceException();
			}
			this.targetZombie = (ulong)0L;
		}
		GameAPP.PlaySound(49, 0.5f, 1f);
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x00059104 File Offset: 0x00057304
	[Token(Token = "0x6000F69")]
	[Address(RVA = "0x46B080", Offset = "0x469680", VA = "0x18046B080", Slot = "76")]
	public virtual void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.shootType;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0005914C File Offset: 0x0005734C
	[Token(Token = "0x6000F6A")]
	[Address(RVA = "0x46BB70", Offset = "0x46A170", VA = "0x18046BB70", Slot = "27")]
	protected override void LimHealth()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int thePlantMaxHealth2 = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth2;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x00059170 File Offset: 0x00057370
	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x46C1C0", Offset = "0x46A7C0", VA = "0x18046C1C0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x00059184 File Offset: 0x00057384
	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x46BAD0", Offset = "0x46A0D0", VA = "0x18046BAD0", Slot = "77")]
	protected virtual void DecreaseHealth()
	{
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.timer = num;
		if (num2 > (int)num)
		{
			int thePlantMaxHealth = this.thePlantMaxHealth;
			this.timer = 1f;
			int num3 = this.thePlantHealth;
			num3 -= thePlantMaxHealth;
			this.thePlantHealth = num3;
			int thePlantMaxHealth2 = this.thePlantMaxHealth;
			this.thePlantHealth = thePlantMaxHealth2;
			base.UpdateText();
		}
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x000591F0 File Offset: 0x000573F0
	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x46BBA0", Offset = "0x46A1A0", VA = "0x18046BBA0", Slot = "28")]
	protected override void ReplaceSprite()
	{
		ulong num19;
		do
		{
			int num = this.thePlantMaxHealth;
			num += num;
			List<GameObject> list = this.changeSprites;
			bool flag;
			if (flag)
			{
				SpriteRenderer spriteRenderer;
				ulong num2;
				spriteRenderer.enabled = num2 != 0UL;
				int num3 = 0;
				Transform transform;
				GameObject gameObject = transform.GetChild(num3).gameObject;
				int num4 = 0;
				gameObject.SetActive(num4 != 0);
				Transform transform2;
				uint num5;
				GameObject gameObject2 = transform2.GetChild((int)num5).gameObject;
				int num6 = 0;
				gameObject2.SetActive(num6 != 0);
			}
			ulong num7;
			if (num7 != (ulong)0L)
			{
				goto IL_0145;
			}
			bool flag2;
			if (flag2)
			{
				List<GameObject> list2 = this.changeSprites;
				bool flag3;
				if (flag3)
				{
					int num8 = 0;
					SpriteRenderer spriteRenderer2;
					spriteRenderer2.enabled = num8 != 0;
					int num9 = 0;
					Transform transform3;
					ulong num10;
					transform3.GetChild(num9).gameObject.SetActive(num10 != 0UL);
					Transform transform4;
					uint num11;
					GameObject gameObject3 = transform4.GetChild((int)num11).gameObject;
					int num12 = 0;
					gameObject3.SetActive(num12 != 0);
				}
				ulong num13;
				if (num13 != (ulong)0L)
				{
					goto IL_0175;
				}
			}
			bool flag4;
			if (flag4)
			{
				int num14 = 0;
				SpriteRenderer spriteRenderer3;
				spriteRenderer3.enabled = num14 != 0;
				int num15 = 0;
				Transform transform5;
				GameObject gameObject4 = transform5.GetChild(num15).gameObject;
				int num16 = 0;
				gameObject4.SetActive(num16 != 0);
				Transform transform6;
				uint num17;
				ulong num18;
				transform6.GetChild((int)num17).gameObject.SetActive(num18 != 0UL);
			}
		}
		while (num19 != (ulong)0L);
		return;
		IL_0145:
		throw new NullReferenceException();
		IL_0175:
		throw new NullReferenceException();
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x000593A4 File Offset: 0x000575A4
	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x46B300", Offset = "0x469900", VA = "0x18046B300", Slot = "78")]
	protected virtual void Bite(Zombie zombie)
	{
		GameObject theFirstArmor = zombie.theFirstArmor;
		int num = 0;
		if (theFirstArmor == num)
		{
			int num2 = 0;
			PlantType thePlantType = this.thePlantType;
			int num3 = this.attackDamage;
			int num4 = 0;
			num3 += num3;
			ulong num5;
			ulong num6;
			base.Recover((float)num2, (DamageType)num4, num5 != 0UL, num6 != 0UL);
			this.shootType = (BulletType)((ulong)6L);
		}
		float attributeCountdown = this.attributeCountdown;
		PlantType thePlantType2 = this.thePlantType;
		int num7 = 0;
		ulong num8;
		ulong num9;
		base.Recover(attributeCountdown, (DamageType)num7, num8 != 0UL, num9 != 0UL);
		base.AttributeCountdown = 40f;
		PlantType thePlantType3 = this.thePlantType;
		int num10 = 0;
		ulong num11;
		ulong num12;
		base.Recover(attributeCountdown, (DamageType)num10, num11 != 0UL, num12 != 0UL);
		bool flag;
		this.shootType = (flag ? BulletType.Bullet_cherry : BulletType.Bullet_pea);
		uint num13;
		GameAPP.PlaySound((int)num13, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		throw new NullReferenceException();
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00059468 File Offset: 0x00057668
	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x466C80", Offset = "0x465280", VA = "0x180466C80", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00059478 File Offset: 0x00057678
	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x46C1F0", Offset = "0x46A7F0", VA = "0x18046C1F0")]
	public SuperChomper()
	{
		List<GameObject> list = new List();
		this.changeSprites = list;
		this.shootType = (BulletType)((ulong)4L);
		base..ctor();
	}

	// Token: 0x04000B7F RID: 2943
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B7F")]
	public List<GameObject> changeSprites;

	// Token: 0x04000B80 RID: 2944
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B80")]
	private BulletType shootType;

	// Token: 0x04000B81 RID: 2945
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000B81")]
	protected float timer;
}
