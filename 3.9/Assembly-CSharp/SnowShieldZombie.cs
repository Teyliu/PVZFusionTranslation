using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000703 RID: 1795
[Token(Token = "0x2000703")]
public class SnowShieldZombie : Zombie
{
	// Token: 0x06002352 RID: 9042 RVA: 0x000B863C File Offset: 0x000B683C
	[Token(Token = "0x6002352")]
	[Address(RVA = "0x5D3920", Offset = "0x5D1F20", VA = "0x1805D3920", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Bullet", "ZombieBullet" });
		this.bulletLayer = layerMask;
		this.theStatus = (ZombieStatus)((ulong)26L);
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x000B8694 File Offset: 0x000B6894
	[Token(Token = "0x6002353")]
	[Address(RVA = "0x5D39F0", Offset = "0x5D1FF0", VA = "0x1805D39F0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002354 RID: 9044 RVA: 0x000B86D4 File Offset: 0x000B68D4
	[Token(Token = "0x6002354")]
	[Address(RVA = "0x5D4290", Offset = "0x5D2890", VA = "0x1805D4290", Slot = "66")]
	protected override void SecondArmorBroken()
	{
		GameObject theSecondArmor = this.theSecondArmor;
		bool flag;
		if (!flag)
		{
			ulong num;
			theSecondArmor.GetComponent<SpriteRenderer>().enabled = num != 0UL;
			Transform transform = this.theSecondArmor.transform;
			int num2 = 0;
			GameObject gameObject = transform.GetChild(num2).gameObject;
			int num3 = 0;
			SpriteRenderer spriteRenderer;
			spriteRenderer.enabled = num3 != 0;
			Transform transform2 = this.theSecondArmor.transform;
			int num4 = 0;
			GameObject gameObject2 = transform2.GetChild(num4).gameObject;
			int num5 = 0;
			gameObject2.SetActive(num5 != 0);
			uint num6;
			ulong num7;
			this.theSecondArmor.transform.GetChild((int)num6).gameObject.SetActive(num7 != 0UL);
			return;
		}
		SpriteRenderer component = theSecondArmor.GetComponent<SpriteRenderer>();
		int num8 = 0;
		component.enabled = num8 != 0;
		Transform transform3 = this.theSecondArmor.transform;
		int num9 = 0;
		ulong num10;
		transform3.GetChild(num9).gameObject.SetActive(num10 != 0UL);
		uint num11;
		GameObject gameObject3 = this.theSecondArmor.transform.GetChild((int)num11).gameObject;
		throw new NullReferenceException();
	}

	// Token: 0x06002355 RID: 9045 RVA: 0x000B87C8 File Offset: 0x000B69C8
	[Token(Token = "0x6002355")]
	[Address(RVA = "0x5D4560", Offset = "0x5D2B60", VA = "0x1805D4560", Slot = "35")]
	protected override void SecondArmorFall()
	{
		int num;
		do
		{
			num = 0;
			IEnumerator enumerator = base.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				string text;
				while (text == 0)
				{
				}
				GameObject gameObject;
				ulong num2;
				gameObject.SetActive(num2 != 0UL);
				GameObject gameObject2;
				ParticleSystemRenderer component = gameObject2.GetComponent<ParticleSystemRenderer>();
				int theZombieRow = this.theZombieRow;
				string text2 = string.Format("zombie{0}", component);
				component.sortingLayerName = text2;
				GameObject gameObject3;
				ParticleSystemRenderer component2 = gameObject3.GetComponent<ParticleSystemRenderer>();
				int num3 = this.sortingGroup.sortingOrder + 1;
				component2.sortingOrder = num3;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06002356 RID: 9046 RVA: 0x000B88A8 File Offset: 0x000B6AA8
	[Token(Token = "0x6002356")]
	[Address(RVA = "0x5B3BB0", Offset = "0x5B21B0", VA = "0x1805B3BB0", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x06002357 RID: 9047 RVA: 0x000B88C4 File Offset: 0x000B6AC4
	[Token(Token = "0x6002357")]
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

	// Token: 0x06002358 RID: 9048 RVA: 0x000B88E0 File Offset: 0x000B6AE0
	[Token(Token = "0x6002358")]
	[Address(RVA = "0x5D3A90", Offset = "0x5D2090", VA = "0x1805D3A90", Slot = "18")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!this.bounding)
		{
			this.ReboundUpdate();
			return;
		}
	}

	// Token: 0x06002359 RID: 9049 RVA: 0x000B8904 File Offset: 0x000B6B04
	[Token(Token = "0x6002359")]
	[Address(RVA = "0x5D4980", Offset = "0x5D2F80", VA = "0x1805D4980", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float butterSpeed = this.butterSpeed;
		anim.SetFloat("Speed2", butterSpeed);
	}

	// Token: 0x0600235A RID: 9050 RVA: 0x000B8938 File Offset: 0x000B6B38
	[Token(Token = "0x600235A")]
	[Address(RVA = "0x5D3C60", Offset = "0x5D2260", VA = "0x1805D3C60")]
	private void ReboundUpdate()
	{
		int num;
		int num4;
		do
		{
			num = 0;
			int num2 = 0;
			Collider2D[] collider2Ds = this.GetCollider2Ds(5.5f, 0.5f);
			if (num < collider2Ds.Length)
			{
				bool flag;
				if (flag)
				{
					int theZombieRow = this.theZombieRow;
					if (this.<Team>k__BackingField <= Team.AI)
					{
					}
					Vector2 reboundCenter = this.GetReboundCenter(1f);
				}
				num++;
			}
			int num3 = 0;
			if (!(num != num3))
			{
				return;
			}
			num4 = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num5 = 0;
				if (num2 == num5)
				{
					continue;
				}
				bool flag3 = num2 == this;
				while (flag3)
				{
				}
				if (this > (ulong)3L)
				{
					if (flag3 <= true)
					{
					}
					if (flag3 <= true)
					{
					}
				}
				while (this == (ulong)1L)
				{
				}
				while (this == (ulong)3L)
				{
				}
				int theZombieRow2 = this.theZombieRow;
				Transform axis = this.axis;
				int theZombieRow3 = this.theZombieRow;
				Transform axis2 = this.axis;
			}
		}
		while (num != 0);
		if (num4 == 0)
		{
		}
	}

	// Token: 0x0600235B RID: 9051 RVA: 0x000B8A20 File Offset: 0x000B6C20
	[Token(Token = "0x600235B")]
	[Address(RVA = "0x5D3AD0", Offset = "0x5D20D0", VA = "0x1805D3AD0")]
	private Collider2D[] GetCollider2Ds(float range, float range2)
	{
		Vector2 reboundCenter = this.GetReboundCenter(range);
		LayerMask layerMask = this.bulletLayer;
		Collider2D[] array;
		return array;
	}

	// Token: 0x0600235C RID: 9052 RVA: 0x000B8A40 File Offset: 0x000B6C40
	[Token(Token = "0x600235C")]
	[Address(RVA = "0x5D3B90", Offset = "0x5D2190", VA = "0x1805D3B90")]
	private Vector2 GetReboundCenter(float range)
	{
		Collider2D col = this.col;
		Collider2D col2 = this.col;
		Collider2D col3 = this.col;
		throw new NullReferenceException();
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x000B8A74 File Offset: 0x000B6C74
	[Token(Token = "0x600235D")]
	[Address(RVA = "0x5D3560", Offset = "0x5D1B60", VA = "0x1805D3560")]
	private void AnimRebound()
	{
		int num = 0;
		int num2 = 0;
		Collider2D[] collider2Ds = this.GetCollider2Ds(1f, 1f);
		if (num < collider2Ds.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				if (this.<Team>k__BackingField <= Team.AI)
				{
					CreateBullet instance = CreateBullet.Instance;
				}
				CreateBullet instance2 = CreateBullet.Instance;
				Bullet bullet;
				bullet.Damage = num;
			}
			num++;
		}
		if (num2 != 0)
		{
			float num3 = global::UnityEngine.Random.Range(1f, 1.5f);
			uint num4;
			GameAPP.PlaySound((int)num4, 0.3f, num3);
		}
		this.bounding = num != 0;
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x000B8B00 File Offset: 0x000B6D00
	[Token(Token = "0x600235E")]
	[Address(RVA = "0x5D49E0", Offset = "0x5D2FE0", VA = "0x1805D49E0")]
	public SnowShieldZombie()
	{
	}

	// Token: 0x040011FC RID: 4604
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011FC")]
	private LayerMask bulletLayer;

	// Token: 0x040011FD RID: 4605
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x40011FD")]
	private bool bounding;
}
