using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x020002EB RID: 747
[Token(Token = "0x20002EB")]
public class ParticleManager : MonoBehaviour
{
	// Token: 0x06000D5F RID: 3423 RVA: 0x0004D198 File Offset: 0x0004B398
	[Token(Token = "0x6000D5F")]
	[Address(RVA = "0x3EC550", Offset = "0x3EAB50", VA = "0x1803EC550")]
	private void Awake()
	{
		ulong num5;
		do
		{
			int num = 0;
			ParticleManager.Instance = this;
			List<ParticleType> allParticles = GameAPP.resourcesManager.allParticles;
			bool flag;
			if (flag)
			{
				ParticleManager.<>c__DisplayClass2_0 CS$<>8__locals1;
				CS$<>8__locals1.<>4__this = this;
				CS$<>8__locals1.item = (ParticleType)num;
				Func<Particle> func;
				Action<Particle> action;
				Action<Particle> action2;
				Action<Particle> action3;
				ulong num2;
				ulong num3;
				ulong num4;
				ObjectPool<Particle> objectPool = new ObjectPool(func, action, action2, action3, num2 != 0UL, (int)num3, (int)num4);
				Dictionary<ParticleType, ObjectPool<Particle>> dictionary = this.pools;
				ParticleType item = CS$<>8__locals1.item;
				dictionary.Add(item, objectPool);
			}
		}
		while (num5 != (ulong)0L);
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x0004D214 File Offset: 0x0004B414
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x3ECB90", Offset = "0x3EB190", VA = "0x1803ECB90")]
	public Particle SetParticle(ParticleType particleType, Vector2 position, int layerRow = 11, bool lim = true, float scale = 0f)
	{
		Dictionary<ParticleType, ObjectPool<Particle>> dictionary = this.pools;
		bool flag;
		if (flag)
		{
			Particle particle;
			particle.existTimer = 0f;
			Transform transform = particle.transform;
			float z = particle.originalScale.z;
			Transform transform2 = particle.transform;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			SortingGroup component = particle.GetComponent<SortingGroup>();
			string text = string.Format("particle{0}", component);
			component.sortingLayerName = text;
			if (component != 0)
			{
				Transform transform3 = particle.transform;
				Vector3 vector;
				float z2 = vector.z;
			}
			return particle;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x0004D2A4 File Offset: 0x0004B4A4
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x3EC8C0", Offset = "0x3EAEC0", VA = "0x1803EC8C0")]
	private Particle CreateParticle(ParticleType particleType)
	{
		int num = 0;
		Dictionary<ParticleType, GameObject> particlePrefabs = GameAPP.resourcesManager.particlePrefabs;
		bool flag;
		if (!flag)
		{
		}
		Transform transform = Board.Instance.transform;
		GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(num, transform);
		Particle particle;
		if (!gameObject.TryGetComponent<Particle>(num))
		{
			particle = gameObject.AddComponent<Particle>();
		}
		particle.theParticleType = particleType;
		if (!gameObject.TryGetComponent<SortingGroup>(num))
		{
			SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
		}
		return particle;
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0004D318 File Offset: 0x0004B518
	[Token(Token = "0x6000D62")]
	[Address(RVA = "0x3ECB10", Offset = "0x3EB110", VA = "0x1803ECB10")]
	private void GetParticle(Particle obj)
	{
		obj.gameObject.SetActive(true);
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0004D338 File Offset: 0x0004B538
	[Token(Token = "0x6000D63")]
	[Address(RVA = "0x3ECB50", Offset = "0x3EB150", VA = "0x1803ECB50")]
	private void ReleaseParticle(Particle obj)
	{
		GameObject gameObject = obj.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x0004D35C File Offset: 0x0004B55C
	[Token(Token = "0x6000D64")]
	[Address(RVA = "0x3ECAA0", Offset = "0x3EB0A0", VA = "0x1803ECAA0")]
	private void DestoryParticle(Particle obj)
	{
		global::UnityEngine.Object.Destroy(obj.gameObject);
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0004D37C File Offset: 0x0004B57C
	[Token(Token = "0x6000D65")]
	[Address(RVA = "0x3ECE40", Offset = "0x3EB440", VA = "0x1803ECE40")]
	public ParticleManager()
	{
		Dictionary<ParticleType, ObjectPool<Particle>> dictionary = new Dictionary();
		this.pools = dictionary;
		base..ctor();
	}

	// Token: 0x04000A2A RID: 2602
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A2A")]
	public Dictionary<ParticleType, ObjectPool<Particle>> pools;

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000A2B")]
	public static ParticleManager Instance;
}
