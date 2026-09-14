using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006E7 RID: 1767
[Token(Token = "0x20006E7")]
public class SuperPogoZombie : PogoZombie
{
	// Token: 0x060022E6 RID: 8934 RVA: 0x000B7180 File Offset: 0x000B5380
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x57BE20", Offset = "0x57A420", VA = "0x18057BE20", Slot = "15")]
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

	// Token: 0x060022E7 RID: 8935 RVA: 0x000B71D0 File Offset: 0x000B53D0
	[Token(Token = "0x60022E7")]
	[Address(RVA = "0x57BE90", Offset = "0x57A490", VA = "0x18057BE90", Slot = "16")]
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

	// Token: 0x060022E8 RID: 8936 RVA: 0x000B7290 File Offset: 0x000B5490
	[Token(Token = "0x60022E8")]
	[Address(RVA = "0x57B680", Offset = "0x579C80", VA = "0x18057B680")]
	private void BigJump()
	{
		this.theStatus = (ZombieStatus)((ulong)20L);
		SpriteRenderer component = this.axis.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x000B72C4 File Offset: 0x000B54C4
	[Token(Token = "0x60022E9")]
	[Address(RVA = "0x57BBC0", Offset = "0x57A1C0", VA = "0x18057BBC0", Slot = "21")]
	protected override void PositionUpdate()
	{
		Rigidbody2D rb = this.rb;
		Vector2 vector;
		rb.velocity = vector;
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x000B738C File Offset: 0x000B558C
	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x57B6F0", Offset = "0x579CF0", VA = "0x18057B6F0", Slot = "61")]
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

	// Token: 0x060022EB RID: 8939 RVA: 0x000B7460 File Offset: 0x000B5660
	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x531BF0", Offset = "0x5301F0", VA = "0x180531BF0", Slot = "63")]
	protected override int FirstArmorTakeDamage(int theDamage)
	{
		int theFirstArmorHealth = this.theFirstArmorHealth;
		int num = 0;
		this.theFirstArmorHealth = num;
		this.theFirstArmorType = (Zombie.FirstArmorType)num;
		this.theFirstArmor = num;
		return theDamage;
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x000B749C File Offset: 0x000B569C
	[Token(Token = "0x60022EC")]
	[Address(RVA = "0x57B960", Offset = "0x579F60", VA = "0x18057B960", Slot = "74")]
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

	// Token: 0x060022ED RID: 8941 RVA: 0x000B752C File Offset: 0x000B572C
	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x57C070", Offset = "0x57A670", VA = "0x18057C070")]
	public SuperPogoZombie()
	{
	}

	// Token: 0x0400114C RID: 4428
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x400114C")]
	private float waitTime;

	// Token: 0x0400114D RID: 4429
	[FieldOffset(Offset = "0x274")]
	[Token(Token = "0x400114D")]
	private bool jumped;

	// Token: 0x0400114E RID: 4430
	[FieldOffset(Offset = "0x275")]
	[Token(Token = "0x400114E")]
	protected bool loseJumper;

	// Token: 0x0400114F RID: 4431
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x400114F")]
	private float jumpX;
}
