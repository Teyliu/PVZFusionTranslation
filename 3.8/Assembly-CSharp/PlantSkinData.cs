using System;
using Cpp2IlInjected;

// Token: 0x020007B0 RID: 1968
[Token(Token = "0x20007B0")]
[Serializable]
public class PlantSkinData
{
	// Token: 0x060027EE RID: 10222 RVA: 0x000D8FF0 File Offset: 0x000D71F0
	[Token(Token = "0x60027EE")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PlantSkinData()
	{
	}

	// Token: 0x04001634 RID: 5684
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001634")]
	public PlantType thePlantType;

	// Token: 0x04001635 RID: 5685
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001635")]
	public int skinIndex;
}
