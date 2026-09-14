using System;
using Cpp2IlInjected;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
[Serializable]
public class LoveEffect : ZombieEffect
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000088 RID: 136 RVA: 0x00003DAC File Offset: 0x00001FAC
	[Token(Token = "0x17000021")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x3F9920", Offset = "0x3F7F20", VA = "0x1803F9920", Slot = "4")]
		get
		{
			return EffectType.Love;
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00003DBC File Offset: 0x00001FBC
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3F5670", Offset = "0x3F3C70", VA = "0x1803F5670")]
	public LoveEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}
}
