using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200001D RID: 29
[Token(Token = "0x200001D")]
[Serializable]
public class KelpEffect : ZombieEffect
{
	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600007A RID: 122 RVA: 0x00003C28 File Offset: 0x00001E28
	[Token(Token = "0x1700001F")]
	public override bool SoftControl
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "12")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600007B RID: 123 RVA: 0x00003C38 File Offset: 0x00001E38
	[Token(Token = "0x17000020")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "4")]
		get
		{
			return EffectType.Kelp;
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00003C48 File Offset: 0x00001E48
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x3AEE70", Offset = "0x3AD470", VA = "0x1803AEE70")]
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

	// Token: 0x0600007D RID: 125 RVA: 0x00003C94 File Offset: 0x00001E94
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x3AEBC0", Offset = "0x3AD1C0", VA = "0x1803AEBC0", Slot = "5")]
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

	// Token: 0x0600007E RID: 126 RVA: 0x00003D5C File Offset: 0x00001F5C
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3A6910", Offset = "0x3A4F10", VA = "0x1803A6910", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003D90 File Offset: 0x00001F90
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3AEB40", Offset = "0x3AD140", VA = "0x1803AEB40", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		global::UnityEngine.Object.Destroy(this.kelp);
		this.zombie.kelpSpeed = 1f;
	}

	// Token: 0x0400003B RID: 59
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003B")]
	public float duration;

	// Token: 0x0400003C RID: 60
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003C")]
	public GameObject kelp;
}
