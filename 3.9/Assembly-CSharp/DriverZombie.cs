using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000684 RID: 1668
[Token(Token = "0x2000684")]
public class DriverZombie : Zombie
{
	// Token: 0x06001FA8 RID: 8104 RVA: 0x000A83B0 File Offset: 0x000A65B0
	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x5A0FC0", Offset = "0x59F5C0", VA = "0x1805A0FC0", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(76, 1f, 1f);
		float num = this.startSpeed;
		this.currentSpeed = num;
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x000A83E4 File Offset: 0x000A65E4
	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x5A0D00", Offset = "0x59F300", VA = "0x1805A0D00", Slot = "22")]
	protected override void PositionUpdate()
	{
		Board board = this.board;
		Transform axis = this.axis;
		float num = this.currentSpeed;
		Rigidbody2D rb = this.rb;
		Transform child = base.transform.GetChild(2);
		List<IceRoad> iceRoads = this.board.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		Board board2 = this.board;
		List<IceRoad> iceRoads2 = this.board.iceRoads;
		int theZombieRow2 = this.theZombieRow;
		iceRoads2[theZombieRow2].fadeTimer = 30f;
		Board board3 = this.board;
		Transform axis2 = this.axis;
		float num2 = this.currentSpeed;
		Rigidbody2D rb2 = this.rb;
		float num3 = this.currentSpeed;
		if (num3 > 0.2f)
		{
			float deltaTime = Time.deltaTime;
			this.currentSpeed = num3;
		}
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000A84C4 File Offset: 0x000A66C4
	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x58EA00", Offset = "0x58D000", VA = "0x18058EA00", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x000A84D8 File Offset: 0x000A66D8
	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000A84E8 File Offset: 0x000A66E8
	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "56")]
	public override void SetCold(float time, int coldLevel = 0, bool freeze = false)
	{
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000A84F8 File Offset: 0x000A66F8
	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x5A0410", Offset = "0x59EA10", VA = "0x1805A0410")]
	private void CreateIceRoad()
	{
		Transform child = base.transform.GetChild(2);
		List<IceRoad> iceRoads = this.board.iceRoads;
		int theZombieRow = this.theZombieRow;
		float x = iceRoads[theZombieRow].x;
		Board board = this.board;
		List<IceRoad> iceRoads2 = this.board.iceRoads;
		int theZombieRow2 = this.theZombieRow;
		iceRoads2[theZombieRow2].fadeTimer = 30f;
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x000A856C File Offset: 0x000A676C
	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x59FD50", Offset = "0x59E350", VA = "0x18059FD50", Slot = "30")]
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
			num2 -= (long)theDamage;
			int num3 = 0;
			float num4;
			if (num4 > (float)num3)
			{
				Transform transform = base.transform;
				int num5 = 0;
				SpriteRenderer component = transform.GetChild(num5).GetComponent<SpriteRenderer>();
				Sprite sprite = GameAPP.spritePrefab[29];
				component.sprite = sprite;
				uint num6;
				SpriteRenderer component2 = base.transform.GetChild((int)num6).GetComponent<SpriteRenderer>();
				Sprite sprite2 = GameAPP.spritePrefab[31];
				component2.sprite = sprite2;
			}
			int num7 = 0;
			float num8;
			if (num8 <= (float)num7)
			{
				break;
			}
			this.anim.SetTrigger("shake");
			Transform transform2 = base.transform;
			int num9 = 0;
			SpriteRenderer component3 = transform2.GetChild(num9).GetComponent<SpriteRenderer>();
			Sprite sprite3 = GameAPP.spritePrefab[30];
			component3.sprite = sprite3;
			uint num10;
			SpriteRenderer component4 = base.transform.GetChild((int)num10).GetComponent<SpriteRenderer>();
			Sprite sprite4 = GameAPP.spritePrefab[32];
			component4.sprite = sprite4;
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
				uint num17;
				component6.sortingOrder = (int)num17;
			}
			if (component6 != 0)
			{
			}
		}
		while (num != 0);
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000A876C File Offset: 0x000A696C
	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x586E80", Offset = "0x585480", VA = "0x180586E80")]
	protected void DieAndExplode()
	{
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000A877C File Offset: 0x000A697C
	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x5A0530", Offset = "0x59EB30", VA = "0x1805A0530", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(43, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = GameAPP.particlePrefab[34];
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000A87D4 File Offset: 0x000A69D4
	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x58EE50", Offset = "0x58D450", VA = "0x18058EE50")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000A87F4 File Offset: 0x000A69F4
	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000A8804 File Offset: 0x000A6A04
	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x5A06F0", Offset = "0x59ECF0", VA = "0x1805A06F0", Slot = "75")]
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
			Sprite sprite = GameAPP.spritePrefab[30];
			component.sprite = sprite;
			uint num3;
			SpriteRenderer component2 = base.transform.GetChild((int)num3).GetComponent<SpriteRenderer>();
			Sprite sprite2 = GameAPP.spritePrefab[32];
			component2.sprite = sprite2;
			uint num4;
			Transform child = base.transform.GetChild((int)num4);
			int num5 = 0;
			ulong num6;
			child.GetChild(num5).gameObject.SetActive(num6 != 0UL);
			uint num7;
			Transform child2 = base.transform.GetChild((int)num7);
			int num8 = 0;
			GameObject gameObject = child2.GetChild(num8).gameObject;
			ulong num9;
			gameObject.SetActive(num9 != 0UL);
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
				Renderer component3 = particleSystem.GetComponent<Renderer>();
				int theZombieRow = this.theZombieRow;
				string text = string.Format("zombie{0}", component3);
				component3.sortingLayerName = text;
				ParticleSystem particleSystem2;
				uint num10;
				particleSystem2.GetComponent<Renderer>().sortingOrder = (int)num10;
			}
			if (enumerator != 0)
			{
			}
		}
		while (num != 0);
		int num11 = 0;
		BoxCollider2D boxCollider2D;
		boxCollider2D.enabled = num11 != 0;
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000A8990 File Offset: 0x000A6B90
	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x5A1060", Offset = "0x59F660", VA = "0x1805A1060")]
	public DriverZombie()
	{
	}

	// Token: 0x0400112B RID: 4395
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400112B")]
	protected float startSpeed = 0.8f;

	// Token: 0x0400112C RID: 4396
	[FieldOffset(Offset = "0x27C")]
	[Token(Token = "0x400112C")]
	protected float currentSpeed = 0.8f;
}
