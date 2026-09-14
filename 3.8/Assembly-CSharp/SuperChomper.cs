using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200033A RID: 826
[Token(Token = "0x200033A")]
public class SuperChomper : Chomper
{
	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00057FF0 File Offset: 0x000561F0
	[Token(Token = "0x170000D3")]
	public override int LimDamage
	{
		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x42B670", Offset = "0x429C70", VA = "0x18042B670", Slot = "66")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00058000 File Offset: 0x00056200
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected override void AttributeEvent()
	{
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00058010 File Offset: 0x00056210
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x42AA10", Offset = "0x429010", VA = "0x18042AA10", Slot = "71")]
	public override void ChomperSearchZombie([Optional] Collider2D collision)
	{
		ulong num8;
		do
		{
			int num = 0;
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			Vector2 range = this.range;
			int num2 = this.zombieLayer;
			int num3 = 0;
			int num4 = 0;
			Collider2D[] array;
			if (num4 < array.Length)
			{
				bool flag;
				if (flag)
				{
					if (flag <= true)
					{
					}
					num3++;
					int thePlantRow = this.thePlantRow;
					ulong num5;
					this.targetZombie = num5;
				}
				num3++;
			}
			Zombie targetZombie = this.targetZombie;
			int num6 = 0;
			if (targetZombie != num6)
			{
				break;
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num7 = 0;
				if (!(num != num7) || !base.CheckZombie(num))
				{
					continue;
				}
				this.targetZombie = num;
				this.anim.SetTrigger("bite");
				this.theStatus = (PlantStatus)((ulong)22L);
			}
		}
		while (num8 != (ulong)0L);
		this.anim.SetTrigger("bite");
		this.theStatus = (PlantStatus)((ulong)22L);
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00058114 File Offset: 0x00056314
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x42A660", Offset = "0x428C60", VA = "0x18042A660", Slot = "73")]
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

	// Token: 0x06000F1E RID: 3870 RVA: 0x00058168 File Offset: 0x00056368
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x42A4E0", Offset = "0x428AE0", VA = "0x18042A4E0", Slot = "76")]
	public virtual void AnimShoot()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.shootType;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x000581B0 File Offset: 0x000563B0
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x42AF50", Offset = "0x429550", VA = "0x18042AF50", Slot = "28")]
	protected override void LimHealth()
	{
		int thePlantMaxHealth = this.thePlantMaxHealth;
		int thePlantMaxHealth2 = this.thePlantMaxHealth;
		this.thePlantHealth = thePlantMaxHealth2;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x000581D4 File Offset: 0x000563D4
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x42B5A0", Offset = "0x429BA0", VA = "0x18042B5A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x000581E8 File Offset: 0x000563E8
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x42AEB0", Offset = "0x4294B0", VA = "0x18042AEB0", Slot = "77")]
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

	// Token: 0x06000F22 RID: 3874 RVA: 0x00058254 File Offset: 0x00056454
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x42AF80", Offset = "0x429580", VA = "0x18042AF80", Slot = "29")]
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

	// Token: 0x06000F23 RID: 3875 RVA: 0x00058408 File Offset: 0x00056608
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x42A760", Offset = "0x428D60", VA = "0x18042A760", Slot = "78")]
	protected virtual void Bite(Zombie zombie)
	{
		GameObject theFirstArmor = zombie.theFirstArmor;
		int num = 0;
		if (theFirstArmor == num)
		{
			PlantType thePlantType = this.thePlantType;
			int num2 = this.attackDamage;
			num2 += num2;
			this.shootType = (BulletType)((ulong)6L);
		}
		float attributeCountdown = this.attributeCountdown;
		PlantType thePlantType2 = this.thePlantType;
		int num3 = 0;
		ulong num4;
		ulong num5;
		base.Recover(attributeCountdown, (DamageType)num3, num4 != 0UL, num5 != 0UL);
		base.AttributeCountdown = 40f;
		PlantType thePlantType3 = this.thePlantType;
		int num6 = 0;
		ulong num7;
		ulong num8;
		base.Recover(attributeCountdown, (DamageType)num6, num7 != 0UL, num8 != 0UL);
		bool flag;
		this.shootType = (flag ? BulletType.Bullet_cherry : BulletType.Bullet_pea);
		uint num9;
		GameAPP.PlaySound((int)num9, 0.5f, 1f);
		this.targetZombie = (ulong)0L;
		throw new NullReferenceException();
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x000584B8 File Offset: 0x000566B8
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x41A120", Offset = "0x418720", VA = "0x18041A120", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x000584C8 File Offset: 0x000566C8
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x42B5D0", Offset = "0x429BD0", VA = "0x18042B5D0")]
	public SuperChomper()
	{
		List<GameObject> list = new List();
		this.changeSprites = list;
		this.shootType = (BulletType)((ulong)4L);
		this.swallowMaxCountDown = 40f;
		base..ctor();
	}

	// Token: 0x04000B2E RID: 2862
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B2E")]
	public List<GameObject> changeSprites;

	// Token: 0x04000B2F RID: 2863
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B2F")]
	private BulletType shootType;

	// Token: 0x04000B30 RID: 2864
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Token(Token = "0x4000B30")]
	protected float timer;
}
