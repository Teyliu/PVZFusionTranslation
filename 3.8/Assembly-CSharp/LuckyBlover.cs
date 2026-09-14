using System;
using Core;
using Cpp2IlInjected;

// Token: 0x020003D8 RID: 984
[Token(Token = "0x20003D8")]
public class LuckyBlover : Plant
{
	// Token: 0x06001215 RID: 4629 RVA: 0x00065C8C File Offset: 0x00063E8C
	[Token(Token = "0x6001215")]
	[Address(RVA = "0x44D9F0", Offset = "0x44BFF0", VA = "0x18044D9F0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		this.anim.SetTrigger("blow");
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x00065CB8 File Offset: 0x00063EB8
	[Token(Token = "0x6001216")]
	[Address(RVA = "0x44D910", Offset = "0x44BF10", VA = "0x18044D910", Slot = "69")]
	protected virtual void AnimBlow()
	{
		GameAPP.PlaySound(87, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		int num = 0;
		instance.ShowText("随着幸运四叶草的出现\n你感觉到礼盒里面会出现好东西", 3f, num != 0);
		base.Invoke("DelayDie", 3f);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x00065D08 File Offset: 0x00063F08
	[Token(Token = "0x6001217")]
	[Address(RVA = "0x41C540", Offset = "0x41AB40", VA = "0x18041C540")]
	protected void DelayDie()
	{
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x00065D18 File Offset: 0x00063F18
	[Token(Token = "0x6001218")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public LuckyBlover()
	{
	}

	// Token: 0x04000BF4 RID: 3060
	[Token(Token = "0x4000BF4")]
	public static bool lucky;
}
