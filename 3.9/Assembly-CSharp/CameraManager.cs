using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A8 RID: 1960
[Token(Token = "0x20007A8")]
public class CameraManager
{
	// Token: 0x060027BC RID: 10172 RVA: 0x000D2AB4 File Offset: 0x000D0CB4
	[Token(Token = "0x60027BC")]
	[Address(RVA = "0x639450", Offset = "0x637A50", VA = "0x180639450")]
	public CameraManager(Transform camera)
	{
		this.Update();
		this.camera = camera;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000D2AD0 File Offset: 0x000D0CD0
	[Token(Token = "0x60027BD")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20")]
	public void Update()
	{
	}

	// Token: 0x040014FB RID: 5371
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014FB")]
	private Transform camera;
}
