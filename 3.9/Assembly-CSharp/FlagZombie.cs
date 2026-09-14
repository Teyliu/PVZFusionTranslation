using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200069D RID: 1693
[Token(Token = "0x200069D")]
public class FlagZombie : Zombie
{
	// Token: 0x06002037 RID: 8247 RVA: 0x000AA9B8 File Offset: 0x000A8BB8
	[Token(Token = "0x6002037")]
	[Address(RVA = "0x5A8600", Offset = "0x5A6C00", VA = "0x1805A8600", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		float num = this.theOriginSpeed * 1.3f;
		this.theOriginSpeed = num;
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000AA9E0 File Offset: 0x000A8BE0
	[Token(Token = "0x6002038")]
	[Address(RVA = "0x5A8630", Offset = "0x5A6C30", VA = "0x1805A8630", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
		long num = this.theMaxHealth;
		num += num;
		GameObject gameObject = this.flag;
		int num2 = 0;
		if (gameObject != num2)
		{
			SpriteRenderer component = this.flag.GetComponent<SpriteRenderer>();
			int num3 = 0;
			component.enabled = num3 != 0;
			Transform transform = this.flag.transform;
			int num4 = 0;
			ulong num5;
			transform.GetChild(num4).gameObject.SetActive(num5 != 0UL);
		}
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000AAA58 File Offset: 0x000A8C58
	[Token(Token = "0x6002039")]
	[Address(RVA = "0x5A8750", Offset = "0x5A6D50", VA = "0x1805A8750", Slot = "34")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
		global::UnityEngine.Object.Destroy(this.flagHand);
		this.anim.CrossFade("attack2", 0.2f);
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000AAA94 File Offset: 0x000A8C94
	[Token(Token = "0x600203A")]
	[Address(RVA = "0x5A87F0", Offset = "0x5A6DF0", VA = "0x1805A87F0")]
	public FlagZombie()
	{
	}

	// Token: 0x04001142 RID: 4418
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001142")]
	public GameObject flag;

	// Token: 0x04001143 RID: 4419
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001143")]
	public GameObject flagHand;
}
