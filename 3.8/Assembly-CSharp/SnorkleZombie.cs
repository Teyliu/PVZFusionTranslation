using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006C2 RID: 1730
[Token(Token = "0x20006C2")]
public class SnorkleZombie : Zombie
{
	// Token: 0x06002200 RID: 8704 RVA: 0x000B2BAC File Offset: 0x000B0DAC
	[Token(Token = "0x6002200")]
	[Address(RVA = "0x56D380", Offset = "0x56B980", VA = "0x18056D380", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000B2BC8 File Offset: 0x000B0DC8
	[Token(Token = "0x6002201")]
	[Address(RVA = "0x56D470", Offset = "0x56BA70", VA = "0x18056D470", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000B2C00 File Offset: 0x000B0E00
	[Token(Token = "0x6002202")]
	[Address(RVA = "0x56D3A0", Offset = "0x56B9A0", VA = "0x18056D3A0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_snorkle/Zombie_snorkle_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000B2C2C File Offset: 0x000B0E2C
	[Token(Token = "0x6002203")]
	[Address(RVA = "0x56D430", Offset = "0x56BA30", VA = "0x18056D430", Slot = "27")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000B2C40 File Offset: 0x000B0E40
	[Token(Token = "0x6002204")]
	[Address(RVA = "0x56D450", Offset = "0x56BA50", VA = "0x18056D450", Slot = "33")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000B2C50 File Offset: 0x000B0E50
	[Token(Token = "0x6002205")]
	[Address(RVA = "0x56D540", Offset = "0x56BB40", VA = "0x18056D540")]
	public SnorkleZombie()
	{
	}
}
