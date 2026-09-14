using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009B1 RID: 2481
[Token(Token = "0x20009B1")]
[Serializable]
public class MapData
{
	// Token: 0x060032D2 RID: 13010 RVA: 0x0010DCDC File Offset: 0x0010BEDC
	[Token(Token = "0x60032D2")]
	[Address(RVA = "0x7035E0", Offset = "0x701BE0", VA = "0x1807035E0")]
	public MapData()
	{
		List<ZombieType> list = new List();
		this.allowZombies = list;
		base..ctor();
	}

	// Token: 0x04002481 RID: 9345
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002481")]
	public int Wave;

	// Token: 0x04002482 RID: 9346
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002482")]
	public string SceneType;

	// Token: 0x04002483 RID: 9347
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002483")]
	public List<ZombieType> allowZombies;
}
