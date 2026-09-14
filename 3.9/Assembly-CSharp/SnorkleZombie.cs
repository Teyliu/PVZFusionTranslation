using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006FA RID: 1786
[Token(Token = "0x20006FA")]
public class SnorkleZombie : Zombie
{
	// Token: 0x0600231B RID: 8987 RVA: 0x000B79A0 File Offset: 0x000B5BA0
	[Token(Token = "0x600231B")]
	[Address(RVA = "0x5D1040", Offset = "0x5CF640", VA = "0x1805D1040", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (ZombieStatus)((ulong)7L);
	}

	// Token: 0x0600231C RID: 8988 RVA: 0x000B79BC File Offset: 0x000B5BBC
	[Token(Token = "0x600231C")]
	[Address(RVA = "0x5D1130", Offset = "0x5CF730", VA = "0x1805D1130", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("swim");
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x0600231D RID: 8989 RVA: 0x000B79F4 File Offset: 0x000B5BF4
	[Token(Token = "0x600231D")]
	[Address(RVA = "0x5D1060", Offset = "0x5CF660", VA = "0x1805D1060", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_snorkle/Zombie_snorkle_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x0600231E RID: 8990 RVA: 0x000B7A20 File Offset: 0x000B5C20
	[Token(Token = "0x600231E")]
	[Address(RVA = "0x5D10F0", Offset = "0x5CF6F0", VA = "0x1805D10F0", Slot = "28")]
	public override void Die(int reason = 0)
	{
		base.Die(reason);
	}

	// Token: 0x0600231F RID: 8991 RVA: 0x000B7A34 File Offset: 0x000B5C34
	[Token(Token = "0x600231F")]
	[Address(RVA = "0x5D1110", Offset = "0x5CF710", VA = "0x1805D1110", Slot = "34")]
	protected override void LoseHeadEvent()
	{
	}

	// Token: 0x06002320 RID: 8992 RVA: 0x000B7A44 File Offset: 0x000B5C44
	[Token(Token = "0x6002320")]
	[Address(RVA = "0x5D1200", Offset = "0x5CF800", VA = "0x1805D1200")]
	public SnorkleZombie()
	{
	}
}
