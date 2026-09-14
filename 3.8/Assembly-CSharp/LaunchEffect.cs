using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
[Serializable]
public class LaunchEffect : ZombieEffect
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000080 RID: 128 RVA: 0x00003DC4 File Offset: 0x00001FC4
	[Token(Token = "0x17000021")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "4")]
		get
		{
			return EffectType.Launch;
		}
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00003DD4 File Offset: 0x00001FD4
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x3AF420", Offset = "0x3ADA20", VA = "0x1803AF420")]
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

	// Token: 0x06000082 RID: 130 RVA: 0x00003E18 File Offset: 0x00002018
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x3AF140", Offset = "0x3AD740", VA = "0x1803AF140", Slot = "5")]
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

	// Token: 0x06000083 RID: 131 RVA: 0x00003EBC File Offset: 0x000020BC
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x3AF2D0", Offset = "0x3AD8D0", VA = "0x1803AF2D0", Slot = "6")]
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

	// Token: 0x06000084 RID: 132 RVA: 0x00003F28 File Offset: 0x00002128
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x3AEF80", Offset = "0x3AD580", VA = "0x1803AEF80", Slot = "7")]
	public override void OnFixedUpdate()
	{
		Rigidbody2D rb = this.zombie.rb;
		int num = 0;
		Vector2 velocity = rb.velocity;
		rb.velocity = num;
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00003F58 File Offset: 0x00002158
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x3AEFE0", Offset = "0x3AD5E0", VA = "0x1803AEFE0", Slot = "8")]
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

	// Token: 0x0400003D RID: 61
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003D")]
	private bool state;
}
