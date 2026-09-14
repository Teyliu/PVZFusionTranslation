using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
[Serializable]
public class ButterEffect : ZombieEffect
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000065 RID: 101 RVA: 0x000034A4 File Offset: 0x000016A4
	[Token(Token = "0x17000016")]
	public override bool HardControl
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "13")]
		get
		{
			return true;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000066 RID: 102 RVA: 0x000034B4 File Offset: 0x000016B4
	[Token(Token = "0x17000017")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "4")]
		get
		{
			return EffectType.Butter;
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x000034C4 File Offset: 0x000016C4
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x3F1D30", Offset = "0x3F0330", VA = "0x1803F1D30")]
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

	// Token: 0x06000068 RID: 104 RVA: 0x00003514 File Offset: 0x00001714
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3F18B0", Offset = "0x3EFEB0", VA = "0x1803F18B0", Slot = "5")]
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

	// Token: 0x06000069 RID: 105 RVA: 0x0000365C File Offset: 0x0000185C
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x3F1CD0", Offset = "0x3F02D0", VA = "0x1803F1CD0", Slot = "6")]
	public override void OnUpdate()
	{
		base.OnUpdate();
		float num = this.duration;
		float deltaTime = Time.deltaTime;
		this.duration = num;
		this.OnRemove();
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x3F1830", Offset = "0x3EFE30", VA = "0x1803F1830", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		global::UnityEngine.Object.Destroy(this.butter);
		this.zombie.butterSpeed = 1f;
	}

	// Token: 0x04000038 RID: 56
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000038")]
	public bool showButter;

	// Token: 0x04000039 RID: 57
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000039")]
	public float duration;

	// Token: 0x0400003A RID: 58
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003A")]
	public GameObject butter;
}
