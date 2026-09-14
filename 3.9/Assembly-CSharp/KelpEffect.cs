using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000022 RID: 34
[Token(Token = "0x2000022")]
[Serializable]
public class KelpEffect : ZombieEffect
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00003F84 File Offset: 0x00002184
	[Token(Token = "0x17000025")]
	public override bool SoftControl
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "12")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000095 RID: 149 RVA: 0x00003F94 File Offset: 0x00002194
	[Token(Token = "0x17000026")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "4")]
		get
		{
			return EffectType.Kelp;
		}
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00003FA4 File Offset: 0x000021A4
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x3FACE0", Offset = "0x3F92E0", VA = "0x1803FACE0")]
	public KelpEffect(Zombie zombie, float duration)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		this.duration = duration;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
			ulong num;
			this.kelp = num;
		}
		zombie.kelpSpeed = 0.5f;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00003FF0 File Offset: 0x000021F0
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x3FAA30", Offset = "0x3F9030", VA = "0x1803FAA30", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		Zombie zombie = this.zombie;
		this.rwkr = flag;
		if (zombie.BoxType == BoxType.Water)
		{
			GameObject gameObject = Resources.Load<GameObject>("Bullet/Other/Grap");
			GameAPP.PlaySound((SoundType)((uint)24), 0.5f, 1f);
		}
		GameObject gameObject2 = Resources.Load<GameObject>("Bullet/Other/Grap_land");
		Transform axis = this.zombie.axis;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject3;
		this.kelp = gameObject3;
		Transform transform = this.kelp.transform;
		Transform transform2 = this.zombie.transform;
		transform.parentInternal = transform2;
		this.kelp.GetComponent<SpriteRenderer>().sortingOrder = 139;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000040B8 File Offset: 0x000022B8
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x3F28A0", Offset = "0x3F0EA0", VA = "0x1803F28A0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000040EC File Offset: 0x000022EC
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x3FA9B0", Offset = "0x3F8FB0", VA = "0x1803FA9B0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		global::UnityEngine.Object.Destroy(this.kelp);
		this.zombie.kelpSpeed = 1f;
	}

	// Token: 0x04000044 RID: 68
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000044")]
	public float duration;

	// Token: 0x04000045 RID: 69
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000045")]
	public GameObject kelp;
}
