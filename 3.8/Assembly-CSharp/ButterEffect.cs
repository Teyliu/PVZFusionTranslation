using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
[Serializable]
public class ButterEffect : ZombieEffect
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600004B RID: 75 RVA: 0x0000314C File Offset: 0x0000134C
	[Token(Token = "0x17000010")]
	public override bool HardControl
	{
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600004C RID: 76 RVA: 0x0000315C File Offset: 0x0000135C
	[Token(Token = "0x17000011")]
	public override EffectType EffectType
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "4")]
		get
		{
			return EffectType.Butter;
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000316C File Offset: 0x0000136C
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x3A5DA0", Offset = "0x3A43A0", VA = "0x1803A5DA0")]
	public ButterEffect(Zombie zombie, float duration, float value)
	{
		this.first = true;
		base.OnStart();
		this.zombie = zombie;
		EffectType effectType = this.EffectType;
		bool flag;
		ulong num;
		if (flag)
		{
			this.butter = num;
		}
		if (num == (ulong)0L)
		{
		}
		int num2 = 0;
		this.duration = duration;
		this.showButter = num2 != 0;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000031BC File Offset: 0x000013BC
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x3A5920", Offset = "0x3A3F20", VA = "0x1803A5920", Slot = "5")]
	public override void OnStart()
	{
		bool flag = Lawnf.TravelDebuff((TravelDebuff)((uint)5000));
		this.rwkr = flag;
		GameObject butterHead = this.zombie.butterHead;
		int num = 0;
		if (butterHead != num)
		{
			Transform transform = this.zombie.butterHead.transform;
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = this.butter;
			int num2 = 0;
			if (gameObject == num2)
			{
				float num3 = this.duration;
				if (num3 > 0.5f && this.showButter)
				{
					GameObject[] itemPrefab = GameAPP.itemPrefab;
					GameObject gameObject2 = itemPrefab[15];
					Quaternion identityQuaternion = Quaternion.identityQuaternion;
					GameObject gameObject3;
					this.butter = gameObject3;
					this.butter.GetComponent<SpriteRenderer>().sortingOrder = 140;
					Transform transform2 = this.butter.transform;
					Transform transform3 = this.zombie.butterHead.transform;
					transform2.parentInternal = transform3;
					if (this.zombie.isSmall)
					{
						Transform transform4 = this.butter.transform;
						Vector3 vector2;
						float z2 = vector2.z;
						Transform transform5 = this.butter.transform;
						Vector3 vector3;
						float z3 = vector3.z;
					}
				}
			}
		}
		this.zombie.butterSpeed = 0f;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00003304 File Offset: 0x00001504
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x3A5D40", Offset = "0x3A4340", VA = "0x1803A5D40", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00003338 File Offset: 0x00001538
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x3A58A0", Offset = "0x3A3EA0", VA = "0x1803A58A0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		global::UnityEngine.Object.Destroy(this.butter);
		this.zombie.butterSpeed = 1f;
	}

	// Token: 0x0400002F RID: 47
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002F")]
	public bool showButter;

	// Token: 0x04000030 RID: 48
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000030")]
	public float duration;

	// Token: 0x04000031 RID: 49
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000031")]
	public GameObject butter;
}
