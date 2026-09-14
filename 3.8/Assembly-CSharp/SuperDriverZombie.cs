using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006DC RID: 1756
[Token(Token = "0x20006DC")]
public class SuperDriverZombie : DriverZombie
{
	// Token: 0x06002296 RID: 8854 RVA: 0x000B5280 File Offset: 0x000B3480
	[Token(Token = "0x6002296")]
	[Address(RVA = "0x575250", Offset = "0x573850", VA = "0x180575250", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		int num;
		do
		{
			num = 0;
			int num2 = this.theHealth;
			num2 -= theDamage;
			this.theHealth = num2;
			num2 -= theDamage;
			if (num2 <= 0)
			{
				break;
			}
			float num3;
			float num4;
			if (num3 > num4)
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
			float num7;
			if (num7 <= num3)
			{
				return;
			}
			this.anim.SetTrigger("shake");
			Transform transform2 = base.transform;
			int num8 = 0;
			SpriteRenderer component3 = transform2.GetChild(num8).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[35];
			component3.sprite = sprite3;
			uint num9;
			SpriteRenderer component4 = base.transform.GetChild((int)num9).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[36];
			component4.sprite = sprite4;
			uint num10;
			uint num11;
			SpriteRenderer component5 = base.transform.GetChild((int)num10).GetChild((int)num11).GetComponent<SpriteRenderer>();
			Sprite sprite5 = GameAPP.spritePrefab[37];
			component5.sprite = sprite5;
			uint num12;
			uint num13;
			SpriteRenderer component6 = base.transform.GetChild((int)num12).GetChild((int)num13).GetComponent<SpriteRenderer>();
			Sprite sprite6 = GameAPP.spritePrefab[37];
			component6.sprite = sprite6;
			uint num14;
			Transform child = base.transform.GetChild((int)num14);
			int num15 = 0;
			ulong num16;
			child.GetChild(num15).gameObject.SetActive(num16 != 0UL);
			uint num17;
			Transform child2 = base.transform.GetChild((int)num17);
			int num18 = 0;
			GameObject gameObject = child2.GetChild(num18).gameObject;
			ulong num19;
			gameObject.SetActive(num19 != 0UL);
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
				uint num20;
				component8.sortingOrder = (int)num20;
			}
			if (component8 != 0)
			{
			}
		}
		while (num != 0);
		uint num21;
		base.Die((int)num21);
	}

	// Token: 0x06002297 RID: 8855 RVA: 0x000B54E4 File Offset: 0x000B36E4
	[Token(Token = "0x6002297")]
	[Address(RVA = "0x5763C0", Offset = "0x5749C0", VA = "0x1805763C0", Slot = "21")]
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

	// Token: 0x06002298 RID: 8856 RVA: 0x000B5568 File Offset: 0x000B3768
	[Token(Token = "0x6002298")]
	[Address(RVA = "0x575C10", Offset = "0x574210", VA = "0x180575C10", Slot = "73")]
	public override void KillByCaltrop()
	{
		int num;
		do
		{
			num = 0;
			this.anim.SetTrigger("shake");
			this.anim.SetTrigger("GoDie");
			Transform transform = base.transform;
			int num2 = 0;
			SpriteRenderer component = transform.GetChild(num2).GetComponent<SpriteRenderer>();
			Sprite sprite = GameAPP.spritePrefab[35];
			component.sprite = sprite;
			uint num3;
			SpriteRenderer component2 = base.transform.GetChild((int)num3).GetComponent<SpriteRenderer>();
			Sprite sprite2 = GameAPP.spritePrefab[36];
			component2.sprite = sprite2;
			uint num4;
			uint num5;
			SpriteRenderer component3 = base.transform.GetChild((int)num4).GetChild((int)num5).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[37];
			component3.sprite = sprite3;
			uint num6;
			uint num7;
			SpriteRenderer component4 = base.transform.GetChild((int)num6).GetChild((int)num7).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[37];
			component4.sprite = sprite4;
			uint num8;
			Transform child = base.transform.GetChild((int)num8);
			int num9 = 0;
			ulong num10;
			child.GetChild(num9).gameObject.SetActive(num10 != 0UL);
			uint num11;
			Transform child2 = base.transform.GetChild((int)num11);
			int num12 = 0;
			GameObject gameObject = child2.GetChild(num12).gameObject;
			ulong num13;
			gameObject.SetActive(num13 != 0UL);
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
				uint num14;
				particleSystem2.GetComponent<Renderer>().sortingOrder = (int)num14;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num15 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num15 != 0;
	}

	// Token: 0x06002299 RID: 8857 RVA: 0x000B5750 File Offset: 0x000B3950
	[Token(Token = "0x6002299")]
	[Address(RVA = "0x575A50", Offset = "0x574050", VA = "0x180575A50", Slot = "28")]
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

	// Token: 0x0600229A RID: 8858 RVA: 0x000B57A8 File Offset: 0x000B39A8
	[Token(Token = "0x600229A")]
	[Address(RVA = "0x576650", Offset = "0x574C50", VA = "0x180576650")]
	public SuperDriverZombie()
	{
	}
}
