using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
public class PotatoMine_rise : StateMachineBehaviour
{
	// Token: 0x060001F0 RID: 496 RVA: 0x00006B98 File Offset: 0x00004D98
	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x3B0D60", Offset = "0x3AF360", VA = "0x1803B0D60", Slot = "6")]
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

	// Token: 0x060001F1 RID: 497 RVA: 0x00006BCC File Offset: 0x00004DCC
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x3A4B20", Offset = "0x3A3120", VA = "0x1803A4B20")]
	public PotatoMine_rise()
	{
	}

	// Token: 0x04000072 RID: 114
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000072")]
	public string endStatus;
}
