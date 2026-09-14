using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002B8 RID: 696
[Token(Token = "0x20002B8")]
public class BlackHole_split : BlackHole
{
	// Token: 0x06000C44 RID: 3140 RVA: 0x00045E6C File Offset: 0x0004406C
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x41E2C0", Offset = "0x41C8C0", VA = "0x18041E2C0", Slot = "4")]
	protected override void Start()
	{
		float baseTime = this.baseTime;
		this.baseTime = baseTime;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle(ParticleType.RandomCloud, num, 11, num3 != 0UL, (float)num2);
		this.baseTime = 3f;
		Board instance2 = Board.Instance;
		this.damageMultiplier = 0.3f;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)30)))
		{
			float num4 = this.damageMultiplier * 1.33f;
			this.damageMultiplier = num4;
		}
		if (Lawnf.TravelUltimate((UltiBuff)((uint)31)))
		{
			float maxTime = this.maxTime;
			this.maxTime = maxTime;
		}
		this.baseTime = 2f;
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00045F18 File Offset: 0x00044118
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "6")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06000C46 RID: 3142 RVA: 0x00045F28 File Offset: 0x00044128
	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x41E010", Offset = "0x41C610", VA = "0x18041E010", Slot = "7")]
	public override void AnimDesotry()
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		ScreenShake.TriggerShake(0.05f);
		Transform transform2 = base.transform;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
			}
			num++;
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000C47 RID: 3143 RVA: 0x00045F94 File Offset: 0x00044194
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x41DED0", Offset = "0x41C4D0", VA = "0x18041DED0")]
	public BlackHole_split()
	{
		this.fromType = (PlantType)((ulong)4294967295L);
		this.maxTime = 7.5f;
		this.baseTime = 2f;
		this.damageMultiplier = 0.6f;
		List<GameObject> list = new List();
		this.zombiePreviews = list;
		base..ctor();
	}
}
