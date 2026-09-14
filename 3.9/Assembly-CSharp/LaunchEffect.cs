using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000023")]
[Serializable]
public class LaunchEffect : ZombieEffect
{
	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600009A RID: 154 RVA: 0x00004120 File Offset: 0x00002320
	[Token(Token = "0x17000027")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "4")]
		get
		{
			return EffectType.Launch;
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004130 File Offset: 0x00002330
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x3FB290", Offset = "0x3F9890", VA = "0x1803FB290")]
	public LaunchEffect(Zombie zombie, float value)
	{
		this.first = true;
		base.OnStart();
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			ulong num;
			this.state = num != 0UL;
		}
		base.Value = value;
		this.zombie = zombie;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00004174 File Offset: 0x00002374
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x3FAFB0", Offset = "0x3F95B0", VA = "0x1803FAFB0", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		Rigidbody2D rb = zombie.rb;
		int num = 0;
		rb.isKinematic = num != 0;
		Rigidbody2D rb2 = this.zombie.rb;
		float value = base.Value;
		this.zombie.rb.gravityScale = 1f;
		Transform axis = this.zombie.axis;
		int num2 = 0;
		if (axis != num2)
		{
			Transform axis2 = this.zombie.axis;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				this.state = flag3;
			}
		}
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x600009D")]
	[Address(RVA = "0x3FB140", Offset = "0x3F9740", VA = "0x1803FB140", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		Zombie zombie = this.zombie;
		Mouse instance = Mouse.Instance;
		Transform axis = zombie.axis;
		Zombie zombie2 = this.zombie;
		Board board = this.zombie.board;
		Transform axis2 = this.zombie.axis;
		Vector2 velocity = this.zombie.rb.velocity;
		this.OnRemove();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00004284 File Offset: 0x00002484
	[Token(Token = "0x600009E")]
	[Address(RVA = "0x3FADF0", Offset = "0x3F93F0", VA = "0x1803FADF0", Slot = "7")]
	public override void OnFixedUpdate()
	{
		Rigidbody2D rb = this.zombie.rb;
		int num = 0;
		Vector2 velocity = rb.velocity;
		rb.velocity = num;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000042B4 File Offset: 0x000024B4
	[Token(Token = "0x600009F")]
	[Address(RVA = "0x3FAE50", Offset = "0x3F9450", VA = "0x1803FAE50", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		this.zombie.rb.isKinematic = true;
		Rigidbody2D rb = this.zombie.rb;
		Transform axis = this.zombie.axis;
		int num = 0;
		if (axis != num)
		{
			Transform axis2 = this.zombie.axis;
			bool flag;
			if (flag)
			{
				bool flag2 = this.state;
			}
		}
	}

	// Token: 0x04000046 RID: 70
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000046")]
	private bool state;
}
