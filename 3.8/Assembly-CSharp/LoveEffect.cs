using System;
using Cpp2IlInjected;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
[Serializable]
public class LoveEffect : ZombieEffect
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600006E RID: 110 RVA: 0x00003A50 File Offset: 0x00001C50
	[Token(Token = "0x1700001B")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "4")]
		get
		{
			return EffectType.Love;
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00003A60 File Offset: 0x00001C60
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3A9870", Offset = "0x3A7E70", VA = "0x1803A9870")]
	public LoveEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}
}
