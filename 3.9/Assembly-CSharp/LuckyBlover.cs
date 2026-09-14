using System;
using Core;
using Cpp2IlInjected;

// Token: 0x020003EE RID: 1006
[Token(Token = "0x20003EE")]
public class LuckyBlover : Plant
{
	// Token: 0x06001278 RID: 4728 RVA: 0x0006754C File Offset: 0x0006574C
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x4A21C0", Offset = "0x4A07C0", VA = "0x1804A21C0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("blow");
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00067578 File Offset: 0x00065778
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x4A20D0", Offset = "0x4A06D0", VA = "0x1804A20D0", Slot = "68")]
	protected virtual void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		base.Invoke("DelayDie", 3f);
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x000675B8 File Offset: 0x000657B8
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x4733E0", Offset = "0x4719E0", VA = "0x1804733E0")]
	protected void DelayDie()
	{
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x000675C8 File Offset: 0x000657C8
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public LuckyBlover()
	{
	}

	// Token: 0x04000C60 RID: 3168
	[Token(Token = "0x4000C60")]
	public static bool lucky;
}
