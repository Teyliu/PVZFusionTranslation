using System;
using System.Collections;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C4 RID: 1732
[Token(Token = "0x20006C4")]
public class JacksonDriver : SuperDriverZombie
{
	// Token: 0x06002166 RID: 8550 RVA: 0x000AFF5C File Offset: 0x000AE15C
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x5B9AC0", Offset = "0x5B80C0", VA = "0x1805B9AC0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		if (!Lawnf.EveBalaced())
		{
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
			Transform axis2 = this.axis;
			CreateZombie instance2 = CreateZombie.Instance;
			Transform axis3 = this.axis;
			CreateZombie instance3 = CreateZombie.Instance;
			if (Lawnf.TravelDebuff((TravelDebuff)((uint)18)))
			{
				Transform axis4 = this.axis;
				CreateZombie instance4 = CreateZombie.Instance;
			}
		}
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000AFFCC File Offset: 0x000AE1CC
	[Token(Token = "0x6002167")]
	[Address(RVA = "0x5BA4A0", Offset = "0x5B8AA0", VA = "0x1805BA4A0", Slot = "22")]
	protected override void PositionUpdate()
	{
		Transform child = base.transform.GetChild(4);
		if (Lawnf.EveBalaced())
		{
		}
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)19)))
		{
		}
		List<IceRoad> iceRoads = Board.Instance.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		if (!Lawnf.TravelDebuff((TravelDebuff)((uint)19)))
		{
			Board board = this.board;
			Transform axis = this.axis;
			float currentSpeed = this.currentSpeed;
			Rigidbody2D rb = this.rb;
			return;
		}
		Board board2 = this.board;
		Transform axis2 = this.axis;
		Rigidbody2D rb2 = this.rb;
		Rigidbody2D rb3 = this.rb;
		Rigidbody2D rb4 = this.rb;
		throw new NullReferenceException();
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x000B0078 File Offset: 0x000AE278
	[Token(Token = "0x6002168")]
	[Address(RVA = "0x5B9190", Offset = "0x5B7790", VA = "0x1805B9190", Slot = "30")]
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
			int num4 = 0;
			if (num3 > num4)
			{
				Transform transform = base.transform;
				int num5 = 0;
				SpriteRenderer component = transform.GetChild(num5).GetComponent<SpriteRenderer>();
				Sprite sprite = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage1");
				component.sprite = sprite;
				uint num6;
				SpriteRenderer component2 = base.transform.GetChild((int)num6).GetComponent<SpriteRenderer>();
				Sprite sprite2 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage1");
				component2.sprite = sprite2;
			}
			int num7 = 0;
			if (0 <= num7)
			{
				return;
			}
			if (Lawnf.EveBalaced() && (this.setDancer ? 1 : 0) == num)
			{
				this.setDancer = true;
				CreateZombie instance = CreateZombie.Instance;
				Transform axis = this.axis;
				Transform axis2 = this.axis;
				Transform axis3 = this.axis;
			}
			this.anim.SetTrigger("shake");
			Transform transform2 = base.transform;
			int num8 = 0;
			SpriteRenderer component3 = transform2.GetChild(num8).GetComponent<SpriteRenderer>();
			Sprite sprite3 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage2");
			component3.sprite = sprite3;
			uint num9;
			SpriteRenderer component4 = base.transform.GetChild((int)num9).GetComponent<SpriteRenderer>();
			Sprite sprite4 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage2");
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

	// Token: 0x06002169 RID: 8553 RVA: 0x000B0318 File Offset: 0x000AE518
	[Token(Token = "0x6002169")]
	[Address(RVA = "0x5B9CF0", Offset = "0x5B82F0", VA = "0x1805B9CF0", Slot = "75")]
	[ProButton]
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
			Sprite sprite = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage2");
			component.sprite = sprite;
			uint num5;
			SpriteRenderer component2 = base.transform.GetChild((int)num5).GetComponent<SpriteRenderer>();
			Sprite sprite2 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage2");
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

	// Token: 0x0600216A RID: 8554 RVA: 0x000B0508 File Offset: 0x000AE708
	[Token(Token = "0x600216A")]
	[Address(RVA = "0x5BA790", Offset = "0x5B8D90", VA = "0x1805BA790")]
	public JacksonDriver()
	{
	}

	// Token: 0x0400119F RID: 4511
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x400119F")]
	private bool setDancer;
}
