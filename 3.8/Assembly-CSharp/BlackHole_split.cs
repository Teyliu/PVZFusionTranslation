using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002AD RID: 685
[Token(Token = "0x20002AD")]
public class BlackHole_split : BlackHole
{
	// Token: 0x06000C1B RID: 3099 RVA: 0x00045B44 File Offset: 0x00043D44
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x3D1460", Offset = "0x3CFA60", VA = "0x1803D1460", Slot = "4")]
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

	// Token: 0x06000C1C RID: 3100 RVA: 0x00045BF0 File Offset: 0x00043DF0
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "6")]
	protected override void FixedUpdate()
	{
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x00045C00 File Offset: 0x00043E00
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x3D11B0", Offset = "0x3CF7B0", VA = "0x1803D11B0", Slot = "7")]
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

	// Token: 0x06000C1E RID: 3102 RVA: 0x00045C6C File Offset: 0x00043E6C
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x3D1070", Offset = "0x3CF670", VA = "0x1803D1070")]
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
