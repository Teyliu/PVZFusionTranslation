using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000325 RID: 805
[Token(Token = "0x2000325")]
public class KelpMine_water : Tanglekelp
{
	// Token: 0x06000E97 RID: 3735 RVA: 0x00053444 File Offset: 0x00051644
	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x459030", Offset = "0x457630", VA = "0x180459030", Slot = "17")]
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

	// Token: 0x06000E98 RID: 3736 RVA: 0x00053490 File Offset: 0x00051690
	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x458D60", Offset = "0x457360", VA = "0x180458D60", Slot = "51")]
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

	// Token: 0x06000E99 RID: 3737 RVA: 0x00053514 File Offset: 0x00051714
	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x459160", Offset = "0x457760", VA = "0x180459160")]
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

	// Token: 0x06000E9A RID: 3738 RVA: 0x0005359C File Offset: 0x0005179C
	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x459470", Offset = "0x457A70", VA = "0x180459470", Slot = "16")]
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

	// Token: 0x06000E9B RID: 3739 RVA: 0x000535FC File Offset: 0x000517FC
	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x4590F0", Offset = "0x4576F0", VA = "0x1804590F0")]
	private IEnumerator FlashLight()
	{
		KelpMine_water.<FlashLight>d__7 <FlashLight>d__;
		<FlashLight>d__.System.IDisposable.Dispose();
		<FlashLight>d__.<>1__state = (int)((ulong)0L);
		<FlashLight>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x00053620 File Offset: 0x00051820
	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x459540", Offset = "0x457B40", VA = "0x180459540")]
	public KelpMine_water()
	{
		this.range = (ulong)1073741824L;
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04000B30 RID: 2864
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B30")]
	public GameObject kelpLight;

	// Token: 0x04000B31 RID: 2865
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B31")]
	private float flashSpeed;

	// Token: 0x04000B32 RID: 2866
	[FieldOffset(Offset = "0x244")]
	[Token(Token = "0x4000B32")]
	private float flashTimer;
}
