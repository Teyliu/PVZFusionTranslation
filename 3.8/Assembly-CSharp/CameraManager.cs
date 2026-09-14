using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200076F RID: 1903
[Token(Token = "0x200076F")]
public class CameraManager
{
	// Token: 0x0600268D RID: 9869 RVA: 0x000CDA48 File Offset: 0x000CBC48
	[Token(Token = "0x600268D")]
	[Address(RVA = "0x5D6590", Offset = "0x5D4B90", VA = "0x1805D6590")]
	public CameraManager(Transform camera)
	{
		this.Update();
		this.camera = camera;
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x000CDA64 File Offset: 0x000CBC64
	[Token(Token = "0x600268E")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10")]
	public void Update()
	{
	}

	// Token: 0x0400141F RID: 5151
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400141F")]
	private Transform camera;
}
