using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000670 RID: 1648
[Token(Token = "0x2000670")]
public class CatapultZombie : Zombie
{
	// Token: 0x06001F4B RID: 8011 RVA: 0x000A665C File Offset: 0x000A485C
	[Token(Token = "0x6001F4B")]
	[Address(RVA = "0x58E1C0", Offset = "0x58C7C0", VA = "0x18058E1C0", Slot = "76")]
	protected virtual void AnimShoot()
	{
		Plant target = this._target;
		int num = 0;
		if (!(target == num))
		{
			Transform transform = base.transform.Find("shoot");
			Vector3 vector;
			float z = vector.z;
			CreateBullet instance = CreateBullet.Instance;
			int num2 = 0;
			Bullet bullet;
			uint num3;
			bullet.Damage = (int)num3;
			this._target = num2;
			uint num4;
			GameAPP.PlaySound((int)num4, 0.5f, 1f);
			int num5 = this.basketballNum;
			if (num5 != 0)
			{
				if (num5 != 0)
				{
					if (num5 != 0)
					{
						if (num5 != 0)
						{
							if (num5 == 1)
							{
								uint num6;
								GameObject gameObject = base.transform.GetChild((int)num6).gameObject;
								int num7 = 0;
								gameObject.SetActive(num7 != 0);
								return;
							}
							return;
						}
						else
						{
							Transform transform2 = base.transform;
						}
					}
					Transform transform3 = base.transform;
				}
				Transform transform4 = base.transform;
			}
			this.anim.SetTrigger("walk2");
			throw new NullReferenceException();
		}
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000A6738 File Offset: 0x000A4938
	[Token(Token = "0x6001F4C")]
	[Address(RVA = "0x58E550", Offset = "0x58CB50", VA = "0x18058E550", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		long num = this.theHealth;
		long num2 = this.theMaxHealth;
		num -= (long)theDamage;
		this.theHealth = num;
		num2 -= (long)theDamage;
		if (num < num2)
		{
			uint num3;
			SpriteRenderer component = base.transform.GetChild((int)num3).GetComponent<SpriteRenderer>();
			int num4 = 0;
			component.enabled = num4 != 0;
			uint num5;
			Transform child = base.transform.GetChild((int)num5);
			int num6 = 0;
			ulong num7;
			child.GetChild(num6).GetComponent<SpriteRenderer>().enabled = num7 != 0UL;
			uint num8;
			SpriteRenderer component2 = base.transform.GetChild((int)num8).GetComponent<SpriteRenderer>();
			int num9 = 0;
			component2.enabled = num9 != 0;
			uint num10;
			Transform child2 = base.transform.GetChild((int)num10);
			int num11 = 0;
			ulong num12;
			child2.GetChild(num11).GetComponent<SpriteRenderer>().enabled = num12 != 0UL;
		}
		uint num13;
		this.Die((int)num13);
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000A6804 File Offset: 0x000A4A04
	[Token(Token = "0x6001F4D")]
	[Address(RVA = "0x58EA20", Offset = "0x58D020", VA = "0x18058EA20", Slot = "75")]
	public override void KillByCaltrop()
	{
		int num;
		do
		{
			num = 0;
			this.anim.SetTrigger("shake");
			this.anim.SetTrigger("GoDie");
			uint num2;
			Transform child = base.transform.GetChild((int)num2);
			int num3 = 0;
			GameObject gameObject = child.GetChild(num3).gameObject;
			ulong num4;
			gameObject.SetActive(num4 != 0UL);
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				ParticleSystem particleSystem;
				Renderer component = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component);
				component.sortingLayerName = text;
				ParticleSystem particleSystem2;
				uint num5;
				particleSystem2.GetComponent<Renderer>().sortingOrder = (int)num5;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num6 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num6 != 0;
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000A690C File Offset: 0x000A4B0C
	[Token(Token = "0x6001F4E")]
	[Address(RVA = "0x58E820", Offset = "0x58CE20", VA = "0x18058E820")]
	protected void DieAndExplde()
	{
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000A691C File Offset: 0x000A4B1C
	[Token(Token = "0x6001F4F")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000A6930 File Offset: 0x000A4B30
	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x58E840", Offset = "0x58CE40", VA = "0x18058E840", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[54];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000A6988 File Offset: 0x000A4B88
	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x000A69A8 File Offset: 0x000A4BA8
	[Token(Token = "0x6001F52")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x000A69B8 File Offset: 0x000A4BB8
	[Token(Token = "0x6001F53")]
	[Address(RVA = "0x58F250", Offset = "0x58D850", VA = "0x18058F250", Slot = "17")]
	protected override void Update()
	{
		this.CataUpdate();
		base.Update();
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000A69D4 File Offset: 0x000A4BD4
	[Token(Token = "0x6001F54")]
	[Address(RVA = "0x58E740", Offset = "0x58CD40", VA = "0x18058E740", Slot = "77")]
	protected virtual void CataUpdate()
	{
		Transform axis = this.axis;
		float boardMaxX = this.board.boardMaxX;
		if (this.basketballNum > 0)
		{
			this.SearchPlantUpdate();
			return;
		}
		while (!this.shooting)
		{
		}
		Animator anim = this.anim;
		int num = 0;
		anim.SetBool("shooting", num != 0);
		this.shooting = false;
		this._target = (ulong)0L;
		throw new NullReferenceException();
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000A6A3C File Offset: 0x000A4C3C
	[Token(Token = "0x6001F55")]
	[Address(RVA = "0x58EE80", Offset = "0x58D480", VA = "0x18058EE80")]
	protected void SearchPlantUpdate()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				int theZombieRow = this.theZombieRow;
				bool flag2;
				while (flag2)
				{
				}
				Transform axis = this.axis;
				Transform axis2 = this.axis;
			}
		}
		while (num2 != 0);
		int num4 = 0;
		bool flag3 = num2 != num4;
		bool flag4 = this.shooting;
		if (!flag3)
		{
			if (flag4)
			{
			}
			return;
		}
		if (!flag4)
		{
		}
		bool flag5;
		while (!flag5)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000A6AE8 File Offset: 0x000A4CE8
	[Token(Token = "0x6001F56")]
	[Address(RVA = "0x58F280", Offset = "0x58D880", VA = "0x18058F280")]
	public CatapultZombie()
	{
	}

	// Token: 0x04001117 RID: 4375
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001117")]
	protected bool shooting;

	// Token: 0x04001118 RID: 4376
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001118")]
	protected Plant _target;

	// Token: 0x04001119 RID: 4377
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001119")]
	[SerializeField]
	protected int basketballNum = (int)((ulong)25L);
}
