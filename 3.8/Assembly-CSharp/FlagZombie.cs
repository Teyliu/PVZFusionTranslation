using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000667 RID: 1639
[Token(Token = "0x2000667")]
public class FlagZombie : Zombie
{
	// Token: 0x06001F35 RID: 7989 RVA: 0x000A6240 File Offset: 0x000A4440
	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x546480", Offset = "0x544A80", VA = "0x180546480", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		float num = this.theOriginSpeed * 1.3f;
		this.theOriginSpeed = num;
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x000A6268 File Offset: 0x000A4468
	[Token(Token = "0x6001F36")]
	[Address(RVA = "0x5464B0", Offset = "0x544AB0", VA = "0x1805464B0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		base.BodyTakeDamage(theDamage);
		int num = this.theMaxHealth;
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

	// Token: 0x06001F37 RID: 7991 RVA: 0x000A62E0 File Offset: 0x000A44E0
	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x5465D0", Offset = "0x544BD0", VA = "0x1805465D0", Slot = "33")]
	protected override void LoseHeadEvent()
	{
		base.ZombieUpdate();
		global::UnityEngine.Object.Destroy(this.flagHand);
		this.anim.CrossFade("attack2", 0.2f);
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x000A631C File Offset: 0x000A451C
	[Token(Token = "0x6001F38")]
	[Address(RVA = "0x546670", Offset = "0x544C70", VA = "0x180546670")]
	public FlagZombie()
	{
	}

	// Token: 0x04001076 RID: 4214
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001076")]
	public GameObject flag;

	// Token: 0x04001077 RID: 4215
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001077")]
	public GameObject flagHand;
}
