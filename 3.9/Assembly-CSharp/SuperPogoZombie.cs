using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200071F RID: 1823
[Token(Token = "0x200071F")]
public class SuperPogoZombie : PogoZombie
{
	// Token: 0x06002402 RID: 9218 RVA: 0x000BBFC8 File Offset: 0x000BA1C8
	[Token(Token = "0x6002402")]
	[Address(RVA = "0x5F6400", Offset = "0x5F4A00", VA = "0x1805F6400", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		float boardMaxX = this.board.boardMaxX;
		this.jumpX = boardMaxX;
		if (Lawnf.TravelDebuff((TravelDebuff)((uint)8)))
		{
			float num = this.jumpX;
			this.waitTime = 4.5f;
			this.jumpX = num;
		}
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000BC018 File Offset: 0x000BA218
	[Token(Token = "0x6002403")]
	[Address(RVA = "0x5F6470", Offset = "0x5F4A70", VA = "0x1805F6470", Slot = "17")]
	protected override void Update()
	{
		Transform axis = this.axis;
		float num = this.jumpX;
		Transform axis2 = this.axis;
		if (!this.jumped)
		{
			float deltaTime = Time.deltaTime;
			this.waitTime = deltaTime;
			this.theStatus = (ZombieStatus)((ulong)19L);
			Rigidbody2D rb = this.rb;
			Vector2 vector;
			rb.velocity = vector;
			float num2 = this.waitTime;
			this.anim.SetTrigger("jump");
			this.jumped = true;
			this.vx = -4.25f;
			this.vy = 6f;
		}
		Transform axis3 = this.axis;
		Board board = this.board;
		if (!this.jumped)
		{
			this.theStatus = (ZombieStatus)((ulong)14L);
		}
		base.Update();
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000BC0D8 File Offset: 0x000BA2D8
	[Token(Token = "0x6002404")]
	[Address(RVA = "0x5F5C60", Offset = "0x5F4260", VA = "0x1805F5C60")]
	private void BigJump()
	{
		this.theStatus = (ZombieStatus)((ulong)20L);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000BC10C File Offset: 0x000BA30C
	[Token(Token = "0x6002405")]
	[Address(RVA = "0x5F61A0", Offset = "0x5F47A0", VA = "0x1805F61A0", Slot = "22")]
	protected override void PositionUpdate()
	{
		Rigidbody2D rb = this.rb;
		Vector2 vector;
		rb.velocity = vector;
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000BC1D4 File Offset: 0x000BA3D4
	[Token(Token = "0x6002406")]
	[Address(RVA = "0x5F5CD0", Offset = "0x5F42D0", VA = "0x1805F5CD0", Slot = "63")]
	protected override void FirstArmorBroken()
	{
		bool flag;
		if (flag)
		{
			SpriteRenderer component = this.theFirstArmor.GetComponent<SpriteRenderer>();
			int num = 0;
			component.enabled = num != 0;
			Transform transform = this.theFirstArmor.transform;
			int num2 = 0;
			transform.GetChild(num2).gameObject.SetActive(true);
			GameObject gameObject = this.theFirstArmor.transform.GetChild(1).gameObject;
			int num3 = 0;
			gameObject.SetActive(num3 != 0);
		}
		SpriteRenderer component2 = this.theFirstArmor.GetComponent<SpriteRenderer>();
		int num4 = 0;
		component2.enabled = num4 != 0;
		Transform transform2 = this.theFirstArmor.transform;
		int num5 = 0;
		GameObject gameObject2 = transform2.GetChild(num5).gameObject;
		int num6 = 0;
		gameObject2.SetActive(num6 != 0);
		this.theFirstArmor.transform.GetChild(1).gameObject.SetActive(true);
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x000BC2A8 File Offset: 0x000BA4A8
	[Token(Token = "0x6002407")]
	[Address(RVA = "0x588740", Offset = "0x586D40", VA = "0x180588740", Slot = "65")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x000BC2E4 File Offset: 0x000BA4E4
	[Token(Token = "0x6002408")]
	[Address(RVA = "0x5F5F40", Offset = "0x5F4540", VA = "0x1805F5F40", Slot = "76")]
	public override void LoseJumper(int reason = 0)
	{
		List<GameObject> theUniqueItems = this.theUniqueItems;
		int num = 0;
		int num2 = 0;
		theUniqueItems[num2] = num;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		Board board = this.board;
		this.axis.GetComponent<SpriteRenderer>().enabled = true;
		Rigidbody2D rb = this.rb;
		Transform axis2 = this.axis;
		this.theStatus = (ZombieStatus)((ulong)0L);
		this.anim.SetTrigger("walk");
		Rigidbody2D rb2 = this.rb;
		if (reason == 0)
		{
			this.loseJumper = true;
		}
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x000BC374 File Offset: 0x000BA574
	[Token(Token = "0x6002409")]
	[Address(RVA = "0x5F6650", Offset = "0x5F4C50", VA = "0x1805F6650")]
	public SuperPogoZombie()
	{
	}

	// Token: 0x04001219 RID: 4633
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001219")]
	private float waitTime;

	// Token: 0x0400121A RID: 4634
	[FieldOffset(Offset = "0x294")]
	[Token(Token = "0x400121A")]
	private bool jumped;

	// Token: 0x0400121B RID: 4635
	[FieldOffset(Offset = "0x295")]
	[Token(Token = "0x400121B")]
	protected bool loseJumper;

	// Token: 0x0400121C RID: 4636
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x400121C")]
	private float jumpX;
}
