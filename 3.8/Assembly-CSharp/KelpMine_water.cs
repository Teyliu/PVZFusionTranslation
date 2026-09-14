using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000315 RID: 789
[Token(Token = "0x2000315")]
public class KelpMine_water : Tanglekelp
{
	// Token: 0x06000E4E RID: 3662 RVA: 0x0005246C File Offset: 0x0005066C
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x404C50", Offset = "0x403250", VA = "0x180404C50", Slot = "17")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			Zombie targetZombie = this.targetZombie;
			int num = 0;
			if (targetZombie == num)
			{
				base.GrabUpdate();
			}
		}
		this.LightUpdate();
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x000524B8 File Offset: 0x000506B8
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x404980", Offset = "0x402F80", VA = "0x180404980", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num = 0;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		Transform axis2 = this.axis;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				if ((flag > true && flag) || flag)
				{
					return;
				}
				PlantType thePlantType = this.thePlantType;
			}
			num++;
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x0005253C File Offset: 0x0005073C
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x404D80", Offset = "0x403380", VA = "0x180404D80")]
	private void LightUpdate()
	{
		Transform axis = this.axis;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num))
			{
				int num3 = this.thePlantRow;
				if (num3 > 12 && num3 == 16)
				{
					return;
				}
				num3 += -10;
				if (num3 == -3)
				{
					return;
				}
				Transform axis2 = this.axis;
			}
			num++;
		}
		int num4 = 0;
		if (num != num4)
		{
		}
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x000525C4 File Offset: 0x000507C4
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x405090", Offset = "0x403690", VA = "0x180405090", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.flashTimer;
		float deltaTime = Time.deltaTime;
		int num2 = 0;
		this.flashTimer = num;
		if (num2 > (int)num)
		{
			this.flashTimer = 2f;
			KelpMine_water.<FlashLight>d__7 <FlashLight>d__;
			<FlashLight>d__.System.IDisposable.Dispose();
			<FlashLight>d__.<>1__state = (int)((ulong)0L);
			<FlashLight>d__.<>4__this = this;
			Coroutine coroutine = base.StartCoroutine(<FlashLight>d__);
		}
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00052624 File Offset: 0x00050824
	[Token(Token = "0x6000E52")]
	[Address(RVA = "0x404D10", Offset = "0x403310", VA = "0x180404D10")]
	private IEnumerator FlashLight()
	{
		KelpMine_water.<FlashLight>d__7 <FlashLight>d__;
		<FlashLight>d__.System.IDisposable.Dispose();
		<FlashLight>d__.<>1__state = (int)((ulong)0L);
		<FlashLight>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00052648 File Offset: 0x00050848
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x402450", Offset = "0x400A50", VA = "0x180402450")]
	public KelpMine_water()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000ADF RID: 2783
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000ADF")]
	public GameObject kelpLight;

	// Token: 0x04000AE0 RID: 2784
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000AE0")]
	private float flashSpeed;

	// Token: 0x04000AE1 RID: 2785
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000AE1")]
	private float flashTimer;
}
