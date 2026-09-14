using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x02000828 RID: 2088
[Token(Token = "0x2000828")]
[Serializable]
public class MultipleChoiceOptionData
{
	// Token: 0x06002AB2 RID: 10930 RVA: 0x000E7478 File Offset: 0x000E5678
	[Token(Token = "0x6002AB2")]
	[Address(RVA = "0x6A3A50", Offset = "0x6A2050", VA = "0x1806A3A50")]
	public MultipleChoiceOptionData(string title, string text, UnityAction call, PlantType plantType = PlantType.EndoFlame, ZombieType zombieType = ZombieType.Nothing)
	{
		int num = 0;
		this.zombieType = (ZombieType)((ulong)4294967295L);
		base.FieldGetter(num, text, call);
		this.title = title;
		this.text = text;
		this.call = call;
		this.plantType = PlantType.Peashooter;
		this.zombieType = ZombieType.NormalZombie;
	}

	// Token: 0x040018A8 RID: 6312
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40018A8")]
	public string title;

	// Token: 0x040018A9 RID: 6313
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40018A9")]
	public string text;

	// Token: 0x040018AA RID: 6314
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018AA")]
	public UnityAction call;

	// Token: 0x040018AB RID: 6315
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018AB")]
	public PlantType plantType = (PlantType)((ulong)254L);

	// Token: 0x040018AC RID: 6316
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40018AC")]
	public ZombieType zombieType;
}
