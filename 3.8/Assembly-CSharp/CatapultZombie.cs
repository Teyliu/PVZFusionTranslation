using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200063A RID: 1594
[Token(Token = "0x200063A")]
public class CatapultZombie : Zombie
{
	// Token: 0x06001E49 RID: 7753 RVA: 0x000A1F0C File Offset: 0x000A010C
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x5374E0", Offset = "0x535AE0", VA = "0x1805374E0", Slot = "74")]
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

	// Token: 0x06001E4A RID: 7754 RVA: 0x000A1FE8 File Offset: 0x000A01E8
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x537870", Offset = "0x535E70", VA = "0x180537870", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num = this.theHealth;
		int num2 = this.theMaxHealth;
		num -= theDamage;
		this.theHealth = num;
		num2 -= theDamage;
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

	// Token: 0x06001E4B RID: 7755 RVA: 0x000A20B4 File Offset: 0x000A02B4
	[Token(Token = "0x6001E4B")]
	[Address(RVA = "0x537D40", Offset = "0x536340", VA = "0x180537D40", Slot = "73")]
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

	// Token: 0x06001E4C RID: 7756 RVA: 0x000A21BC File Offset: 0x000A03BC
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x537B40", Offset = "0x536140", VA = "0x180537B40")]
	protected void DieAndExplde()
	{
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000A21CC File Offset: 0x000A03CC
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x537D20", Offset = "0x536320", VA = "0x180537D20", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000A21E0 File Offset: 0x000A03E0
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x537B60", Offset = "0x536160", VA = "0x180537B60", Slot = "28")]
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

	// Token: 0x06001E4F RID: 7759 RVA: 0x000A2238 File Offset: 0x000A0438
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x538170", Offset = "0x536770", VA = "0x180538170")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000A2258 File Offset: 0x000A0458
	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001E51 RID: 7761 RVA: 0x000A2268 File Offset: 0x000A0468
	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x538570", Offset = "0x536B70", VA = "0x180538570", Slot = "16")]
	protected override void Update()
	{
		this.CataUpdate();
		base.Update();
	}

	// Token: 0x06001E52 RID: 7762 RVA: 0x000A2284 File Offset: 0x000A0484
	[Token(Token = "0x6001E52")]
	[Address(RVA = "0x537A60", Offset = "0x536060", VA = "0x180537A60", Slot = "75")]
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

	// Token: 0x06001E53 RID: 7763 RVA: 0x000A22EC File Offset: 0x000A04EC
	[Token(Token = "0x6001E53")]
	[Address(RVA = "0x5381A0", Offset = "0x5367A0", VA = "0x1805381A0")]
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

	// Token: 0x06001E54 RID: 7764 RVA: 0x000A2398 File Offset: 0x000A0598
	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x5385A0", Offset = "0x536BA0", VA = "0x1805385A0")]
	public CatapultZombie()
	{
	}

	// Token: 0x0400104B RID: 4171
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x400104B")]
	protected bool shooting;

	// Token: 0x0400104C RID: 4172
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x400104C")]
	protected Plant _target;

	// Token: 0x0400104D RID: 4173
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x400104D")]
	[SerializeField]
	protected int basketballNum = (int)((ulong)25L);
}
