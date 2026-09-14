using System;
using AdvBuffData;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
[Serializable]
public class FreezeEffect : ZombieEffect
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000075 RID: 117 RVA: 0x0000389C File Offset: 0x00001A9C
	[Token(Token = "0x1700001B")]
	public override bool HardControl
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000076 RID: 118 RVA: 0x000038AC File Offset: 0x00001AAC
	[Token(Token = "0x1700001C")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "4")]
		get
		{
			return EffectType.Freeze;
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000038BC File Offset: 0x00001ABC
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3F60C0", Offset = "0x3F46C0", VA = "0x1803F60C0")]
	public FreezeEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			ulong num;
			this.iceTrap = num;
		}
		this.duration = duration;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3F5E30", Offset = "0x3F4430", VA = "0x1803F5E30", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)3009));
		Zombie zombie = this.zombie;
		if (!flag2)
		{
			bool flag3 = zombie.RemoveBuff((EffectType)((uint)1));
		}
		if (zombie.RemoveBuff((EffectType)((uint)1)))
		{
			元素反应.Explode(this.zombie);
		}
		GameObject gameObject = this.iceTrap;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.iceTrap);
		}
		Zombie zombie2 = this.zombie;
		if (!zombie2.inWater && zombie2.theZombieType != ZombieType.ZombieBoss && zombie2.theZombieType != ZombieType.ZombieBoss2)
		{
			GameObject gameObject2 = Resources.Load<GameObject>("Image/ice/icetrap");
			Transform axis = this.zombie.axis;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject3;
			this.iceTrap = gameObject3;
			Transform transform = this.iceTrap.transform;
			Transform transform2 = this.zombie.transform;
			transform.parentInternal = transform2;
			this.iceTrap.GetComponent<SpriteRenderer>().sortingOrder = 138;
		}
		this.zombie.freezeSpeed = 0f;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00003A24 File Offset: 0x00001C24
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3F28A0", Offset = "0x3F0EA0", VA = "0x1803F28A0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00003A58 File Offset: 0x00001C58
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3F5C40", Offset = "0x3F4240", VA = "0x1803F5C40", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Zombie zombie = this.zombie;
		int num = 0;
		zombie.UpdateColor((Zombie.ZombieColor)num);
		this.zombie.freezeSpeed = 1f;
		this.zombie.freezeLevel = (int)((ulong)0L);
		GameObject gameObject = this.iceTrap;
		int num2 = 0;
		if (gameObject != num2)
		{
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = this.iceTrap.transform;
			int num3 = 0;
			int theZombieRow = this.zombie.theZombieRow;
			int num4 = 0;
			ulong num5;
			Particle particle = instance.SetParticle((ParticleType)((uint)145), num3, theZombieRow, num5 != 0UL, (float)num4);
			global::UnityEngine.Object.Destroy(this.iceTrap);
		}
		if (Lawnf.TravelUltimate((UltiBuff)((uint)5)))
		{
			long currentFirstHealth = this.zombie.CurrentFirstHealth;
		}
	}

	// Token: 0x0400003D RID: 61
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003D")]
	public float duration;

	// Token: 0x0400003E RID: 62
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003E")]
	public GameObject iceTrap;
}
