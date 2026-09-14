using System;
using AdvBuffData;
using Cpp2IlInjected;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000019")]
[Serializable]
public class JalaEffect : ZombieEffect
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600006A RID: 106 RVA: 0x00003944 File Offset: 0x00001B44
	[Token(Token = "0x1700001A")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "4")]
		get
		{
			return EffectType.Jala;
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003954 File Offset: 0x00001B54
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3A9870", Offset = "0x3A7E70", VA = "0x1803A9870")]
	public JalaEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003978 File Offset: 0x00001B78
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3AEA50", Offset = "0x3AD050", VA = "0x1803AEA50", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)3009));
		Zombie zombie = this.zombie;
		if (!flag2)
		{
			int num = 0;
			bool flag3 = zombie.RemoveBuff((EffectType)num);
			bool flag4 = this.zombie.RemoveBuff((EffectType)((uint)2));
		}
		if (zombie.RemoveBuff((EffectType)((uint)2)))
		{
			元素反应.Explode(this.zombie);
		}
		Zombie zombie2 = this.zombie;
		int num2 = 0;
		if (zombie2.RemoveBuff((EffectType)num2))
		{
			元素反应.Explode(this.zombie);
		}
		bool flag5 = this.zombie.RemoveBuff((EffectType)((uint)10));
		bool flag6 = this.zombie.RemoveBuff((EffectType)((uint)4));
		Zombie zombie3 = this.zombie;
		throw new NullReferenceException();
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00003A30 File Offset: 0x00001C30
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3A97E0", Offset = "0x3A7DE0", VA = "0x1803A97E0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}
}
