using System;
using AdvBuffData;
using Cpp2IlInjected;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
[Serializable]
public class JalaEffect : ZombieEffect
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000084 RID: 132 RVA: 0x00003CA0 File Offset: 0x00001EA0
	[Token(Token = "0x17000020")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "4")]
		get
		{
			return EffectType.Jala;
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003CB0 File Offset: 0x00001EB0
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3F5670", Offset = "0x3F3C70", VA = "0x1803F5670")]
	public JalaEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00003CD4 File Offset: 0x00001ED4
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3FA8C0", Offset = "0x3F8EC0", VA = "0x1803FA8C0", Slot = "5")]
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

	// Token: 0x06000087 RID: 135 RVA: 0x00003D8C File Offset: 0x00001F8C
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3F55E0", Offset = "0x3F3BE0", VA = "0x1803F55E0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}
}
