using System;
using System.Collections;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200068E RID: 1678
[Token(Token = "0x200068E")]
public class JacksonDriver : SuperDriverZombie
{
	// Token: 0x06002064 RID: 8292 RVA: 0x000AB630 File Offset: 0x000A9830
	[Token(Token = "0x6002064")]
	[Address(RVA = "0x555630", Offset = "0x553C30", VA = "0x180555630", Slot = "28")]
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

	// Token: 0x06002065 RID: 8293 RVA: 0x000AB6A0 File Offset: 0x000A98A0
	[Token(Token = "0x6002065")]
	[Address(RVA = "0x556000", Offset = "0x554600", VA = "0x180556000", Slot = "21")]
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

	// Token: 0x06002066 RID: 8294 RVA: 0x000AB74C File Offset: 0x000A994C
	[Token(Token = "0x6002066")]
	[Address(RVA = "0x554D10", Offset = "0x553310", VA = "0x180554D10", Slot = "29")]
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
			Transform transform = base.transform;
			int num3 = 0;
			SpriteRenderer component = transform.GetChild(num3).GetComponent<SpriteRenderer>();
			Sprite sprite = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage1");
			component.sprite = sprite;
			uint num4;
			SpriteRenderer component2 = base.transform.GetChild((int)num4).GetComponent<SpriteRenderer>();
			Sprite sprite2 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage1");
			component2.sprite = sprite2;
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
			int num5 = 0;
			SpriteRenderer component3 = transform2.GetChild(num5).GetComponent<SpriteRenderer>();
			Sprite sprite3 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage2");
			component3.sprite = sprite3;
			uint num6;
			SpriteRenderer component4 = base.transform.GetChild((int)num6).GetComponent<SpriteRenderer>();
			Sprite sprite4 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage2");
			component4.sprite = sprite4;
			uint num7;
			uint num8;
			SpriteRenderer component5 = base.transform.GetChild((int)num7).GetChild((int)num8).GetComponent<SpriteRenderer>();
			Sprite sprite5 = GameAPP.spritePrefab[37];
			component5.sprite = sprite5;
			uint num9;
			uint num10;
			SpriteRenderer component6 = base.transform.GetChild((int)num9).GetChild((int)num10).GetComponent<SpriteRenderer>();
			Sprite sprite6 = GameAPP.spritePrefab[37];
			component6.sprite = sprite6;
			uint num11;
			Transform child = base.transform.GetChild((int)num11);
			int num12 = 0;
			ulong num13;
			child.GetChild(num12).gameObject.SetActive(num13 != 0UL);
			uint num14;
			Transform child2 = base.transform.GetChild((int)num14);
			int num15 = 0;
			GameObject gameObject = child2.GetChild(num15).gameObject;
			ulong num16;
			gameObject.SetActive(num16 != 0UL);
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
				uint num17;
				component8.sortingOrder = (int)num17;
			}
			if (component8 != 0)
			{
			}
		}
		while (num != 0);
		uint num18;
		base.Die((int)num18);
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x000AB9D4 File Offset: 0x000A9BD4
	[Token(Token = "0x6002067")]
	[Address(RVA = "0x555860", Offset = "0x553E60", VA = "0x180555860", Slot = "73")]
	[ProButton]
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
			Sprite sprite = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/damage2");
			component.sprite = sprite;
			uint num3;
			SpriteRenderer component2 = base.transform.GetChild((int)num3).GetComponent<SpriteRenderer>();
			Sprite sprite2 = Resources.Load<Sprite>("Zombies/InTravel/JacksonDriver/Zombie_zamboni_2_damage2");
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
			Renderer component6;
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
				component6 = particleSystem2.GetComponent<Renderer>();
				uint num14;
				component6.sortingOrder = (int)num14;
			}
			if (component6 != 0)
			{
			}
		}
		while (num != 0);
		int num15 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num15 != 0;
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x000ABBBC File Offset: 0x000A9DBC
	[Token(Token = "0x6002068")]
	[Address(RVA = "0x5562F0", Offset = "0x5548F0", VA = "0x1805562F0")]
	public JacksonDriver()
	{
	}

	// Token: 0x040010D2 RID: 4306
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x40010D2")]
	private bool setDancer;
}
