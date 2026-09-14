using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CB RID: 1739
[Token(Token = "0x20006CB")]
public class SnowShieldZombie : Zombie
{
	// Token: 0x06002237 RID: 8759 RVA: 0x000B382C File Offset: 0x000B1A2C
	[Token(Token = "0x6002237")]
	[Address(RVA = "0x570230", Offset = "0x56E830", VA = "0x180570230", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Bullet", "ZombieBullet" });
		this.bulletLayer = layerMask;
		this.theStatus = (ZombieStatus)((ulong)26L);
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000B3884 File Offset: 0x000B1A84
	[Token(Token = "0x6002238")]
	[Address(RVA = "0x570300", Offset = "0x56E900", VA = "0x180570300", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000B38C4 File Offset: 0x000B1AC4
	[Token(Token = "0x6002239")]
	[Address(RVA = "0x570BB0", Offset = "0x56F1B0", VA = "0x180570BB0", Slot = "64")]
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

	// Token: 0x0600223A RID: 8762 RVA: 0x000B39B8 File Offset: 0x000B1BB8
	[Token(Token = "0x600223A")]
	[Address(RVA = "0x570E80", Offset = "0x56F480", VA = "0x180570E80", Slot = "34")]
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

	// Token: 0x0600223B RID: 8763 RVA: 0x000B3A98 File Offset: 0x000B1C98
	[Token(Token = "0x600223B")]
	[Address(RVA = "0x550020", Offset = "0x54E620", VA = "0x180550020", Slot = "54")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
		if (coldLevel > 0)
		{
			base.SetCold(time, coldLevel, freeze);
			return;
		}
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000B3AB4 File Offset: 0x000B1CB4
	[Token(Token = "0x600223C")]
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

	// Token: 0x0600223D RID: 8765 RVA: 0x000B3AD0 File Offset: 0x000B1CD0
	[Token(Token = "0x600223D")]
	[Address(RVA = "0x5703A0", Offset = "0x56E9A0", VA = "0x1805703A0", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!this.bounding)
		{
			this.ReboundUpdate();
			return;
		}
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
	[Token(Token = "0x600223E")]
	[Address(RVA = "0x5712A0", Offset = "0x56F8A0", VA = "0x1805712A0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Animator anim = this.anim;
		float butterSpeed = this.butterSpeed;
		anim.SetFloat("Speed2", butterSpeed);
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000B3B28 File Offset: 0x000B1D28
	[Token(Token = "0x600223F")]
	[Address(RVA = "0x570570", Offset = "0x56EB70", VA = "0x180570570")]
	private void ReboundUpdate()
	{
		int num;
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
					Team <Team>k__BackingField = this.<Team>k__BackingField;
					if (<Team>k__BackingField > (Team)5 && <Team>k__BackingField != (Team)9)
					{
						if (<Team>k__BackingField == (Team)15)
						{
							goto IL_0056;
						}
						if (<Team>k__BackingField != (Team)19)
						{
							goto IL_0063;
						}
					}
					if (<Team>k__BackingField != Team.Player && <Team>k__BackingField > Team.AI)
					{
						goto IL_0063;
					}
					IL_0056:
					Vector2 reboundCenter = this.GetReboundCenter(1f);
				}
				IL_0063:
				num++;
			}
			int num3 = 0;
			if (!(num != num3))
			{
				return;
			}
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag2;
			if (flag2)
			{
				int num4 = 0;
				if (num2 == num4)
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
		bool flag4;
		if (!flag4)
		{
		}
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000B3C34 File Offset: 0x000B1E34
	[Token(Token = "0x6002240")]
	[Address(RVA = "0x5703E0", Offset = "0x56E9E0", VA = "0x1805703E0")]
	private Collider2D[] GetCollider2Ds(float range, float range2)
	{
		Vector2 reboundCenter = this.GetReboundCenter(range);
		LayerMask layerMask = this.bulletLayer;
		Collider2D[] array;
		return array;
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000B3C54 File Offset: 0x000B1E54
	[Token(Token = "0x6002241")]
	[Address(RVA = "0x5704A0", Offset = "0x56EAA0", VA = "0x1805704A0")]
	private Vector2 GetReboundCenter(float range)
	{
		Collider2D col = this.col;
		Collider2D col2 = this.col;
		Collider2D col3 = this.col;
		throw new NullReferenceException();
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000B3C88 File Offset: 0x000B1E88
	[Token(Token = "0x6002242")]
	[Address(RVA = "0x56FE50", Offset = "0x56E450", VA = "0x18056FE50")]
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
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				if (<Team>k__BackingField > (Team)5)
				{
					if (<Team>k__BackingField != (Team)9)
					{
						if (<Team>k__BackingField == (Team)15)
						{
							goto IL_005A;
						}
						if (<Team>k__BackingField != (Team)19)
						{
							goto IL_0069;
						}
					}
					CreateBullet instance = CreateBullet.Instance;
				}
				if (<Team>k__BackingField != Team.Player && <Team>k__BackingField > Team.AI)
				{
					goto IL_0069;
				}
				IL_005A:
				CreateBullet instance2 = CreateBullet.Instance;
				Bullet bullet;
				bullet.Damage = num;
			}
			IL_0069:
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

	// Token: 0x06002243 RID: 8771 RVA: 0x000B3D34 File Offset: 0x000B1F34
	[Token(Token = "0x6002243")]
	[Address(RVA = "0x571300", Offset = "0x56F900", VA = "0x180571300")]
	public SnowShieldZombie()
	{
	}

	// Token: 0x0400112E RID: 4398
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400112E")]
	private LayerMask bulletLayer;

	// Token: 0x0400112F RID: 4399
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x400112F")]
	private bool bounding;
}
