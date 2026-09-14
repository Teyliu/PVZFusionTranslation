using System;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020007ED RID: 2029
[Token(Token = "0x20007ED")]
[Serializable]
public class MultipleChoiceOptionData
{
	// Token: 0x0600297C RID: 10620 RVA: 0x000E2374 File Offset: 0x000E0574
	[Token(Token = "0x600297C")]
	[Address(RVA = "0x63F480", Offset = "0x63DA80", VA = "0x18063F480")]
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

	// Token: 0x040017BF RID: 6079
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40017BF")]
	public string title;

	// Token: 0x040017C0 RID: 6080
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40017C0")]
	public string text;

	// Token: 0x040017C1 RID: 6081
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40017C1")]
	public UnityAction call;

	// Token: 0x040017C2 RID: 6082
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40017C2")]
	public PlantType plantType = (PlantType)((ulong)254L);

	// Token: 0x040017C3 RID: 6083
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40017C3")]
	public ZombieType zombieType;
}
