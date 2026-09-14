using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200007C RID: 124
[Token(Token = "0x200007C")]
public class PotatoMine_rise : StateMachineBehaviour
{
	// Token: 0x0600020B RID: 523 RVA: 0x00006F6C File Offset: 0x0000516C
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x3FD020", Offset = "0x3FB620", VA = "0x1803FD020", Slot = "6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		bool flag;
		if (flag)
		{
			Type typeFromHandle = typeof(PlantStatus);
			string text = this.endStatus;
			object obj = Enum.Parse(typeFromHandle, text);
		}
	}

	// Token: 0x0600020C RID: 524 RVA: 0x00006FA0 File Offset: 0x000051A0
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF0B0", VA = "0x1803F0AB0")]
	public PotatoMine_rise()
	{
	}

	// Token: 0x0400007F RID: 127
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400007F")]
	public string endStatus;
}
