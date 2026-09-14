using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000167 RID: 359
[Token(Token = "0x2000167")]
public class Bullet_kernal_squash : Bullet_squashMelon
{
	// Token: 0x0600066E RID: 1646 RVA: 0x0002161C File Offset: 0x0001F81C
	[Token(Token = "0x600066E")]
	[Address(RVA = "0x6F44A0", Offset = "0x6F2AA0", VA = "0x1806F44A0", Slot = "25")]
	protected override void ExtraEffect(GameObject obj)
	{
		DelayAction delayAction = GameAPP.delayAction;
		Action action = delegate
		{
			global::UnityEngine.Object.Destroy(obj);
		};
		delayAction.SetAction(action, 1f);
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0002165C File Offset: 0x0001F85C
	[Token(Token = "0x600066F")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_kernal_squash()
	{
	}
}
