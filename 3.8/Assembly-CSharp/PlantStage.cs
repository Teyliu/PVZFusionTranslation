using System;
using Cpp2IlInjected;

// Token: 0x020000BC RID: 188
[Token(Token = "0x20000BC")]
[Serializable]
public class PlantStage
{
	// Token: 0x06000361 RID: 865 RVA: 0x0000FC4C File Offset: 0x0000DE4C
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x4C3F60", Offset = "0x4C2560", VA = "0x1804C3F60")]
	public PlantStage(PlantType basePlant, PlantType current)
	{
		this.basePlant = basePlant;
		this.currentStage = current;
	}

	// Token: 0x040001C8 RID: 456
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001C8")]
	public PlantType basePlant;

	// Token: 0x040001C9 RID: 457
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001C9")]
	public PlantType currentStage;
}
