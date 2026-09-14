using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200032C RID: 812
[Token(Token = "0x200032C")]
public class SeaMine : PotatoMine
{
	// Token: 0x06000EBF RID: 3775 RVA: 0x00053F10 File Offset: 0x00052110
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x469380", Offset = "0x467980", VA = "0x180469380", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(14f, 16f);
		base.AttributeCountdown = num;
		this.isAready = true;
		this.flashInterval = 2f;
		this.flashTime = 2f;
		float num2 = global::UnityEngine.Random.Range(29f, 31f);
		base.AttributeCountdown = num2;
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00053F70 File Offset: 0x00052170
	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x4692A0", Offset = "0x4678A0", VA = "0x1804692A0", Slot = "39")]
	protected override void AttributeEvent()
	{
		if (this.grow < 2)
		{
			float num = global::UnityEngine.Random.Range(29f, 31f);
			base.AttributeCountdown = num;
			GameAPP.PlaySound(56, 0.5f, 1f);
			int num2 = this.grow;
			if (num2 == 1)
			{
			}
			if (num2 == 2)
			{
				IEnumerator enumerator = this.Grow(0.25f);
				Coroutine coroutine = base.StartCoroutine(enumerator);
				return;
			}
		}
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00053FD4 File Offset: 0x000521D4
	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x4696C0", Offset = "0x467CC0", VA = "0x1804696C0", Slot = "68")]
	protected override void PotatoUpdate()
	{
		base.SetFlash();
		float deltaTime = Time.deltaTime;
		this.flashTime = deltaTime;
		this.flashTime = 0f;
		SeaMine.<Flash>d__8 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Flash>d__);
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00054020 File Offset: 0x00052220
	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x469400", Offset = "0x467A00", VA = "0x180469400", Slot = "73")]
	protected override void BombEffect()
	{
		int num = this.grow;
		if (num != 0)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					Transform axis = this.axis;
					Vector3 vector;
					float z = vector.z;
					PlantType thePlantType = this.thePlantType;
					int attackDamage = this.attackDamage;
				}
				return;
			}
			Transform axis2 = this.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			PlantType thePlantType2 = this.thePlantType;
		}
		Transform axis3 = this.axis;
		Vector3 vector3;
		float z3 = vector3.z;
		int num2 = this.attackDamage;
		num2 -= axis3;
		PlantType thePlantType3 = this.thePlantType;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x000540B0 File Offset: 0x000522B0
	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x469550", Offset = "0x467B50", VA = "0x180469550")]
	private void FlashLight()
	{
		SeaMine.<Flash>d__8 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Flash>d__);
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x000540DC File Offset: 0x000522DC
	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x4695D0", Offset = "0x467BD0", VA = "0x1804695D0")]
	private IEnumerator Flash()
	{
		SeaMine.<Flash>d__8 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00054100 File Offset: 0x00052300
	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x469640", Offset = "0x467C40", VA = "0x180469640")]
	private IEnumerator Grow(float size)
	{
		SeaMine.<Grow>d__9 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		<Grow>d__.size = size;
		return null;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x0005412C File Offset: 0x0005232C
	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x467BF0", Offset = "0x4661F0", VA = "0x180467BF0")]
	public SeaMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000B3F RID: 2879
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B3F")]
	public GameObject light1;

	// Token: 0x04000B40 RID: 2880
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B40")]
	public GameObject light2;

	// Token: 0x04000B41 RID: 2881
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000B41")]
	private int grow;
}
