using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200031C RID: 796
[Token(Token = "0x200031C")]
public class SeaMine : PotatoMine
{
	// Token: 0x06000E75 RID: 3701 RVA: 0x00052F08 File Offset: 0x00051108
	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x4131A0", Offset = "0x4117A0", VA = "0x1804131A0", Slot = "10")]
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

	// Token: 0x06000E76 RID: 3702 RVA: 0x00052F68 File Offset: 0x00051168
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x4130C0", Offset = "0x4116C0", VA = "0x1804130C0", Slot = "40")]
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

	// Token: 0x06000E77 RID: 3703 RVA: 0x00052FCC File Offset: 0x000511CC
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x4134E0", Offset = "0x411AE0", VA = "0x1804134E0", Slot = "69")]
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

	// Token: 0x06000E78 RID: 3704 RVA: 0x00053018 File Offset: 0x00051218
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x413220", Offset = "0x411820", VA = "0x180413220", Slot = "74")]
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

	// Token: 0x06000E79 RID: 3705 RVA: 0x000530A8 File Offset: 0x000512A8
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x413370", Offset = "0x411970", VA = "0x180413370")]
	private void FlashLight()
	{
		SeaMine.<Flash>d__8 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Flash>d__);
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x000530D4 File Offset: 0x000512D4
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x4133F0", Offset = "0x4119F0", VA = "0x1804133F0")]
	private IEnumerator Flash()
	{
		SeaMine.<Flash>d__8 <Flash>d__;
		<Flash>d__.System.IDisposable.Dispose();
		<Flash>d__.<>1__state = (int)((ulong)0L);
		<Flash>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x000530F8 File Offset: 0x000512F8
	[Token(Token = "0x6000E7B")]
	[Address(RVA = "0x413460", Offset = "0x411A60", VA = "0x180413460")]
	private IEnumerator Grow(float size)
	{
		SeaMine.<Grow>d__9 <Grow>d__;
		<Grow>d__.System.IDisposable.Dispose();
		<Grow>d__.<>1__state = (int)((ulong)0L);
		<Grow>d__.<>4__this = this;
		<Grow>d__.size = size;
		return null;
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00053124 File Offset: 0x00051324
	[Token(Token = "0x6000E7C")]
	[Address(RVA = "0x401F90", Offset = "0x400590", VA = "0x180401F90")]
	public SeaMine()
	{
		this.flashInterval = 3f;
		base..ctor();
	}

	// Token: 0x04000AEE RID: 2798
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000AEE")]
	public GameObject light1;

	// Token: 0x04000AEF RID: 2799
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000AEF")]
	public GameObject light2;

	// Token: 0x04000AF0 RID: 2800
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000AF0")]
	private int grow;
}
