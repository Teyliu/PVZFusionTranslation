using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000714 RID: 1812
[Token(Token = "0x2000714")]
public class SuperDriverZombie : DriverZombie
{
	// Token: 0x060023B0 RID: 9136 RVA: 0x000B9FDC File Offset: 0x000B81DC
	[Token(Token = "0x60023B0")]
	[Address(RVA = "0x5D87C0", Offset = "0x5D6DC0", VA = "0x1805D87C0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num;
		do
		{
			num = 0;
			long num2 = this.theHealth;
			num2 -= (long)theDamage;
			this.theHealth = num2;
			num2 -= (long)theDamage;
			int num3 = 0;
			float num4;
			if (num4 > (float)num3)
			{
				Transform transform = base.transform;
				int num5 = 0;
				SpriteRenderer component = transform.GetChild(num5).GetComponent<SpriteRenderer>();
				Sprite sprite = GameAPP.spritePrefab[33];
				component.sprite = sprite;
				uint num6;
				SpriteRenderer component2 = base.transform.GetChild((int)num6).GetComponent<SpriteRenderer>();
				Sprite sprite2 = GameAPP.spritePrefab[34];
				component2.sprite = sprite2;
			}
			int num7 = 0;
			float num8;
			if (num8 <= (float)num7)
			{
				return;
			}
			this.anim.SetTrigger("shake");
			Transform transform2 = base.transform;
			int num9 = 0;
			SpriteRenderer component3 = transform2.GetChild(num9).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[35];
			component3.sprite = sprite3;
			uint num10;
			SpriteRenderer component4 = base.transform.GetChild((int)num10).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[36];
			component4.sprite = sprite4;
			uint num11;
			uint num12;
			SpriteRenderer component5 = base.transform.GetChild((int)num11).GetChild((int)num12).GetComponent<SpriteRenderer>();
			Sprite sprite5 = GameAPP.spritePrefab[37];
			component5.sprite = sprite5;
			uint num13;
			uint num14;
			SpriteRenderer component6 = base.transform.GetChild((int)num13).GetChild((int)num14).GetComponent<SpriteRenderer>();
			Sprite sprite6 = GameAPP.spritePrefab[37];
			component6.sprite = sprite6;
			uint num15;
			Transform child = base.transform.GetChild((int)num15);
			int num16 = 0;
			ulong num17;
			child.GetChild(num16).gameObject.SetActive(num17 != 0UL);
			uint num18;
			Transform child2 = base.transform.GetChild((int)num18);
			int num19 = 0;
			GameObject gameObject = child2.GetChild(num19).gameObject;
			ulong num20;
			gameObject.SetActive(num20 != 0UL);
			IEnumerator enumerator = gameObject.transform.GetEnumerator();
			Renderer component8;
			if (enumerator != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					num++;
				}
				enumerator += enumerator;
				ParticleSystem particleSystem;
				Renderer component7 = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component7);
				component7.sortingLayerName = text;
				ParticleSystem particleSystem2;
				component8 = particleSystem2.GetComponent<Renderer>();
				uint num21;
				component8.sortingOrder = (int)num21;
			}
			if (component8 != 0)
			{
			}
		}
		while (num != 0);
		uint num22;
		base.Die((int)num22);
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x000BA244 File Offset: 0x000B8444
	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x5D9940", Offset = "0x5D7F40", VA = "0x1805D9940", Slot = "22")]
	protected override void PositionUpdate()
	{
		Transform child = base.transform.GetChild(4);
		List<IceRoad> iceRoads = Board.Instance.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		Board board = this.board;
		Transform axis = this.axis;
		float currentSpeed = this.currentSpeed;
		Rigidbody2D rb = this.rb;
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x000BA2C8 File Offset: 0x000B84C8
	[Token(Token = "0x60023B2")]
	[Address(RVA = "0x5D9190", Offset = "0x5D7790", VA = "0x1805D9190", Slot = "75")]
	public override void KillByCaltrop()
	{
		int num;
		do
		{
			num = 0;
			int num2 = 0;
			int num3 = 0;
			if (num2 > num3)
			{
				return;
			}
			this.anim.SetTrigger("shake");
			this.anim.SetTrigger("GoDie");
			Transform transform = base.transform;
			int num4 = 0;
			SpriteRenderer component = transform.GetChild(num4).GetComponent<SpriteRenderer>();
			Sprite sprite = GameAPP.spritePrefab[35];
			component.sprite = sprite;
			uint num5;
			SpriteRenderer component2 = base.transform.GetChild((int)num5).GetComponent<SpriteRenderer>();
			Sprite sprite2 = GameAPP.spritePrefab[36];
			component2.sprite = sprite2;
			uint num6;
			uint num7;
			SpriteRenderer component3 = base.transform.GetChild((int)num6).GetChild((int)num7).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[37];
			component3.sprite = sprite3;
			uint num8;
			uint num9;
			SpriteRenderer component4 = base.transform.GetChild((int)num8).GetChild((int)num9).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[37];
			component4.sprite = sprite4;
			uint num10;
			Transform child = base.transform.GetChild((int)num10);
			int num11 = 0;
			ulong num12;
			child.GetChild(num11).gameObject.SetActive(num12 != 0UL);
			uint num13;
			Transform child2 = base.transform.GetChild((int)num13);
			int num14 = 0;
			GameObject gameObject = child2.GetChild(num14).gameObject;
			ulong num15;
			gameObject.SetActive(num15 != 0UL);
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
				Renderer component5 = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component5);
				component5.sortingLayerName = text;
				ParticleSystem particleSystem2;
				uint num16;
				particleSystem2.GetComponent<Renderer>().sortingOrder = (int)num16;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num17 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num17 != 0;
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x000BA4BC File Offset: 0x000B86BC
	[Token(Token = "0x60023B3")]
	[Address(RVA = "0x5D8FD0", Offset = "0x5D75D0", VA = "0x1805D8FD0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[36];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x000BA514 File Offset: 0x000B8714
	[Token(Token = "0x60023B4")]
	[Address(RVA = "0x5D9BD0", Offset = "0x5D81D0", VA = "0x1805D9BD0")]
	public SuperDriverZombie()
	{
	}
}
