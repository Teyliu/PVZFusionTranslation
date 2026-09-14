using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A3D RID: 2621
[Token(Token = "0x2000A3D")]
public class JobSwitch : MonoBehaviour
{
	// Token: 0x060035D3 RID: 13779 RVA: 0x0011E608 File Offset: 0x0011C808
	[Token(Token = "0x60035D3")]
	[Address(RVA = "0x798D70", Offset = "0x797370", VA = "0x180798D70")]
	private void Update()
	{
		if (Input.GetKeyDownInt((KeyCode)((uint)32)))
		{
			MonoBehaviour monoBehaviour = this.m1;
			bool enabled = monoBehaviour.enabled;
			monoBehaviour.enabled = enabled;
			MonoBehaviour monoBehaviour2 = this.m2;
			bool enabled2 = monoBehaviour2.enabled;
			monoBehaviour2.enabled = enabled2;
		}
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x0011E650 File Offset: 0x0011C850
	[Token(Token = "0x60035D4")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public JobSwitch()
	{
	}

	// Token: 0x04002948 RID: 10568
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002948")]
	public MonoBehaviour m1;

	// Token: 0x04002949 RID: 10569
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002949")]
	public MonoBehaviour m2;
}
