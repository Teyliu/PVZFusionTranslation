using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000161 RID: 353
[Token(Token = "0x2000161")]
public class Bullet_kernal_squash : Bullet_squashMelon
{
	// Token: 0x06000663 RID: 1635 RVA: 0x00021C30 File Offset: 0x0001FE30
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x6C8AF0", Offset = "0x6C70F0", VA = "0x1806C8AF0", Slot = "27")]
	protected override void ExtraEffect(GameObject obj)
	{
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			global::UnityEngine.Object.Destroy(obj);
		};
		delayAction.SetAction(action, 1f);
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00021C70 File Offset: 0x0001FE70
	[Token(Token = "0x6000664")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_kernal_squash()
	{
	}
}
