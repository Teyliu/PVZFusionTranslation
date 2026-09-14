using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x020009ED RID: 2541
[Token(Token = "0x20009ED")]
[Serializable]
public class MapData
{
	// Token: 0x06003406 RID: 13318 RVA: 0x00112CF4 File Offset: 0x00110EF4
	[Token(Token = "0x6003406")]
	[Address(RVA = "0x768AF0", Offset = "0x7670F0", VA = "0x180768AF0")]
	public MapData()
	{
		List<ZombieType> list = new List();
		this.allowZombies = list;
		base..ctor();
	}

	// Token: 0x04002593 RID: 9619
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002593")]
	public int Wave;

	// Token: 0x04002594 RID: 9620
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002594")]
	public string SceneType;

	// Token: 0x04002595 RID: 9621
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002595")]
	public List<ZombieType> allowZombies;
}
