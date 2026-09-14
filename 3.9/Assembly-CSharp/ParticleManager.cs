using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Rendering;

// Token: 0x020002F9 RID: 761
[Token(Token = "0x20002F9")]
public class ParticleManager : MonoBehaviour
{
	// Token: 0x06000DA2 RID: 3490 RVA: 0x0004DE0C File Offset: 0x0004C00C
	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x448F70", Offset = "0x447570", VA = "0x180448F70")]
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

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0004DE88 File Offset: 0x0004C088
	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x4495B0", Offset = "0x447BB0", VA = "0x1804495B0")]
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

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0004DF18 File Offset: 0x0004C118
	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x4492E0", Offset = "0x4478E0", VA = "0x1804492E0")]
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

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0004DF8C File Offset: 0x0004C18C
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x449530", Offset = "0x447B30", VA = "0x180449530")]
	private void GetParticle(Particle obj)
	{
		obj.gameObject.SetActive(true);
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0004DFAC File Offset: 0x0004C1AC
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x449570", Offset = "0x447B70", VA = "0x180449570")]
	private void ReleaseParticle(Particle obj)
	{
		GameObject gameObject = obj.gameObject;
		int num = 0;
		gameObject.SetActive(num != 0);
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0004DFD0 File Offset: 0x0004C1D0
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x4494C0", Offset = "0x447AC0", VA = "0x1804494C0")]
	private void DestoryParticle(Particle obj)
	{
		global::UnityEngine.Object.Destroy(obj.gameObject);
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0004DFF0 File Offset: 0x0004C1F0
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x449860", Offset = "0x447E60", VA = "0x180449860")]
	public ParticleManager()
	{
		Dictionary<ParticleType, ObjectPool<Particle>> dictionary = new Dictionary();
		this.pools = dictionary;
		base..ctor();
	}

	// Token: 0x04000A69 RID: 2665
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A69")]
	public Dictionary<ParticleType, ObjectPool<Particle>> pools;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	public static ParticleManager Instance;
}
