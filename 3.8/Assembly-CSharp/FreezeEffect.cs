using System;
using AdvBuffData;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
[Serializable]
public class FreezeEffect : ZombieEffect
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600005B RID: 91 RVA: 0x00003544 File Offset: 0x00001744
	[Token(Token = "0x17000015")]
	public override bool HardControl
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600005C RID: 92 RVA: 0x00003554 File Offset: 0x00001754
	[Token(Token = "0x17000016")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "4")]
		get
		{
			return EffectType.Freeze;
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003564 File Offset: 0x00001764
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x3AA2C0", Offset = "0x3A88C0", VA = "0x1803AA2C0")]
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

	// Token: 0x0600005E RID: 94 RVA: 0x000035A8 File Offset: 0x000017A8
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x3AA030", Offset = "0x3A8630", VA = "0x1803AA030", Slot = "5")]
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

	// Token: 0x0600005F RID: 95 RVA: 0x000036CC File Offset: 0x000018CC
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x3A6910", Offset = "0x3A4F10", VA = "0x1803A6910", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003700 File Offset: 0x00001900
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x3A9E40", Offset = "0x3A8440", VA = "0x1803A9E40", Slot = "8")]
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
			int currentFirstHealth = this.zombie.CurrentFirstHealth;
		}
	}

	// Token: 0x04000034 RID: 52
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000034")]
	public float duration;

	// Token: 0x04000035 RID: 53
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000035")]
	public GameObject iceTrap;
}
