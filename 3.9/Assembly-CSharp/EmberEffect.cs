using System;
using Cpp2IlInjected;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
[Serializable]
public class EmberEffect : ZombieEffect
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000071 RID: 113 RVA: 0x0000381C File Offset: 0x00001A1C
	[Token(Token = "0x1700001A")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "4")]
		get
		{
			return EffectType.Ember;
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000382C File Offset: 0x00001A2C
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x3F5670", Offset = "0x3F3C70", VA = "0x1803F5670")]
	public EmberEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00003850 File Offset: 0x00001A50
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3F5620", Offset = "0x3F3C20", VA = "0x1803F5620", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		throw new NullReferenceException();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000387C File Offset: 0x00001A7C
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x3F55E0", Offset = "0x3F3BE0", VA = "0x1803F55E0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}
}
