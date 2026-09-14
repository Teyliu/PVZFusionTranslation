using System;
using Cpp2IlInjected;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
[Serializable]
public class EmberEffect : ZombieEffect
{
	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000057 RID: 87 RVA: 0x000034C4 File Offset: 0x000016C4
	[Token(Token = "0x17000014")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "4")]
		get
		{
			return EffectType.Ember;
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000034D4 File Offset: 0x000016D4
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x3A9870", Offset = "0x3A7E70", VA = "0x1803A9870")]
	public EmberEffect(Zombie zombie)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x3A9820", Offset = "0x3A7E20", VA = "0x1803A9820", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		throw new NullReferenceException();
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003524 File Offset: 0x00001724
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x3A97E0", Offset = "0x3A7DE0", VA = "0x1803A97E0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		throw new NullReferenceException();
	}
}
