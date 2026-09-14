using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002AB RID: 683
[Token(Token = "0x20002AB")]
public class BlackHole : MonoBehaviour
{
	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00045270 File Offset: 0x00043470
	// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00045284 File Offset: 0x00043484
	[Token(Token = "0x1700009E")]
	public int Row
	{
		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110")]
		get
		{
			return this._row;
		}
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x3D1120", Offset = "0x3CF720", VA = "0x1803D1120")]
		set
		{
			this._row = value;
			SortingGroup sortingGroup = this.g;
			string text = string.Format("particle{0}", "particle{0}");
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x000452BC File Offset: 0x000434BC
	[Token(Token = "0x6000C0C")]
	[Address(RVA = "0x3D06F0", Offset = "0x3CECF0", VA = "0x1803D06F0")]
	private void Awake()
	{
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		Transform transform = base.transform;
		int num2 = 0;
		ParticleSystem component2 = transform.GetChild(num2).GetComponent<ParticleSystem>();
		this.particle = component2;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
		LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Bullet", "ZombieBullet" });
		this.bulletLayer = layerMask2;
		SortingGroup component3 = base.GetComponent<SortingGroup>();
		this.g = component3;
		bool flag;
		this.lianxie = flag;
		List<BlackHole> blackHoles = Board.Instance.blackHoles;
		int size = blackHoles._size;
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x000453AC File Offset: 0x000435AC
	[Token(Token = "0x6000C0D")]
	[Address(RVA = "0x3D0A80", Offset = "0x3CF080", VA = "0x1803D0A80")]
	private void OnDestroy()
	{
		bool flag = Board.Instance.blackHoles.Remove(this);
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x000453D0 File Offset: 0x000435D0
	[Token(Token = "0x6000C0E")]
	[Address(RVA = "0x3D0E30", Offset = "0x3CF430", VA = "0x1803D0E30", Slot = "4")]
	protected virtual void Start()
	{
		if (!this.main)
		{
			float num = this.baseTime;
			this.baseTime = num;
		}
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = base.transform;
		int num2 = 0;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle(ParticleType.RandomCloud, num2, 11, num4 != 0UL, (float)num3);
		if (this.gold)
		{
			this.baseTime = 3f;
		}
		Board instance2 = Board.Instance;
		this.damageMultiplier = 0.3f;
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)30)))
		{
			float num5 = this.damageMultiplier * 1.33f;
			this.damageMultiplier = num5;
		}
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)31)))
		{
			float num6 = this.baseTime;
			float num7 = this.maxTime;
			this.baseTime = num6;
			this.maxTime = num7;
		}
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x00045490 File Offset: 0x00043690
	[Token(Token = "0x6000C0F")]
	[Address(RVA = "0x3D0F90", Offset = "0x3CF590", VA = "0x1803D0F90", Slot = "5")]
	protected virtual void Update()
	{
		float deltaTime = Time.deltaTime;
		this.totalTime = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.timer = deltaTime2;
		float deltaTime3 = Time.deltaTime;
		float num = this.timer;
		this.existTime = deltaTime3;
		if ((num > this.baseTime || deltaTime3 > this.maxTime) && !this.dying)
		{
			Animator animator = this.anim;
			this.dying = true;
			animator.SetTrigger("die");
			ParticleSystem.MainModule mainModule = this.particle.main;
		}
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x00045524 File Offset: 0x00043724
	[Token(Token = "0x6000C10")]
	[Address(RVA = "0x3D0A30", Offset = "0x3CF030", VA = "0x1803D0A30", Slot = "6")]
	protected virtual void FixedUpdate()
	{
		if (this.gold && this.main)
		{
			this.AttrackUpdate();
			if (global::Lawnf.TravelAdvanced((AdvBuff)((uint)12007)) && this.gold && this.main)
			{
				this.AttackUpdate();
				return;
			}
		}
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x00045570 File Offset: 0x00043770
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x3CFFE0", Offset = "0x3CE5E0", VA = "0x1803CFFE0")]
	private void AttrackUpdate()
	{
		int num = 0;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		LayerMask layerMask = this.bulletLayer;
		int num2 = layerMask;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && (!flag || (this.lianxie ? 1 : 0) == num))
			{
				if (flag)
				{
					this.garlic = true;
				}
				num += 168;
				PlantType plantType = this.fromType;
				Transform transform2 = base.transform;
				Transform transform3 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				Transform transform4 = base.transform;
				Vector2 gravity = Physics2D.gravity;
				float fixedDeltaTime = Time.fixedDeltaTime;
				Transform transform5 = base.transform;
				Vector3 vector3;
				if (vector3.backVector != (ulong)210L)
				{
					this.timer = (float)num;
					Transform transform6 = base.transform;
					Transform transform7 = base.transform;
					if (this.onGetBullet != 0)
					{
					}
					num++;
				}
				float fixedDeltaTime2 = Time.fixedDeltaTime;
				float fixedDeltaTime3 = Time.fixedDeltaTime;
			}
			num++;
		}
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x0004567C File Offset: 0x0004387C
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x3CF7F0", Offset = "0x3CDDF0", VA = "0x1803CF7F0")]
	private void AttackUpdate()
	{
		int num4;
		do
		{
			int num = 0;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__33_ = BlackHole.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				Func<Zombie, bool> func;
				BlackHole.<>c.<>9__33_0 = func;
			}
			Zombie random = ListExtensions.GetRandom<Zombie>(Enumerable.ToList<Zombie>(Enumerable.Where<Zombie>(allZombies, <>9__33_)));
			uint num2;
			random.Die((int)num2);
			ZombieType theZombieType = random.theZombieType;
			Transform transform2 = Board.Instance.transform;
			Transform axis = random.axis;
			Vector3 vector2;
			float z2 = vector2.z;
			int num3 = 0;
			GameObject gameObject;
			if (gameObject != num3)
			{
				gameObject.GetComponent<SortingGroup>().sortingLayerName = "particle11";
				List<GameObject> list = this.zombiePreviews;
				num4 = 0;
			}
			List<GameObject> list2 = this.zombiePreviews;
			int num5 = 0;
			bool flag;
			if (flag)
			{
				int num6 = 0;
				if (!(num != num6))
				{
					continue;
				}
				Vector3 vector3;
				float z3 = vector3.z;
				Vector3 vector4;
				float z4 = vector4.z;
				Transform transform3;
				transform3.Rotate((float)num5, (float)num5, 0.00013962634f);
			}
		}
		while (num4 != 0);
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x000457A4 File Offset: 0x000439A4
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x3D0B60", Offset = "0x3CF160", VA = "0x1803D0B60")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		while (flag)
		{
			int row = this._row;
			if (!this.gold)
			{
				break;
			}
			if (row <= 17)
			{
			}
			Transform transform = base.transform;
			if (this.gold)
			{
				Transform transform2 = base.transform;
			}
			float num;
			if (0 > (int)num || num > 1f)
			{
				float num2 = (float)(0 * (int)0.66999996f);
				if (this.shootLevel > 0 && this.theDamage > 0)
				{
					int num3 = this.shootLevel;
					int num4 = this.theDamage;
					float fixedDeltaTime = Time.fixedDeltaTime;
					PlantType plantType = this.fromType;
					break;
				}
				break;
			}
		}
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00045844 File Offset: 0x00043A44
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x3D0AF0", Offset = "0x3CF0F0", VA = "0x1803D0AF0")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x0004585C File Offset: 0x00043A5C
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x3D09B0", Offset = "0x3CEFB0", VA = "0x1803D09B0")]
	private void Die()
	{
		if (!this.dying)
		{
			Animator animator = this.anim;
			this.dying = true;
			animator.SetTrigger("die");
			ParticleSystem.MainModule mainModule = this.particle.main;
		}
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x000458A0 File Offset: 0x00043AA0
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x3CEDD0", Offset = "0x3CD3D0", VA = "0x1803CEDD0", Slot = "7")]
	public virtual void AnimDesotry()
	{
		int num9;
		do
		{
			int num = 0;
			int num2 = 0;
			bool flag;
			if (flag)
			{
				int num3 = this.theDamage.Multiply(1.3f);
				float num4 = this.totalTime;
				if (0 > (int)num4 || num4 > 1f)
				{
				}
				this.theDamage = num3;
			}
			if ((this.gold ? 1 : 0) == num2)
			{
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
			}
			if (this.existTime <= 5f)
			{
				ParticleManager instance = ParticleManager.Instance;
				Transform transform2 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
				uint num5;
				GameAPP.PlaySound((int)num5, 0.2f, 1f);
			}
			if ((GameAPP.config.distablexplodeFlash ? 1 : 0) != num2)
			{
				ParticleManager instance2 = ParticleManager.Instance;
				Transform transform3 = base.transform;
				Vector3 vector3;
				float z3 = vector3.z;
				uint num6;
				GameAPP.PlaySound((int)num6, 0.2f, 1f);
			}
			Transform transform4 = base.transform;
			Vector3 vector4;
			float z4 = vector4.z;
			uint num7;
			GameAPP.PlaySound((int)num7, 1f, 1f);
			ScreenShake.TriggerShake(0.15f);
			if ((this.nut ? 1 : 0) != num2)
			{
				break;
			}
			Transform transform5 = base.transform;
			int num8 = this.zombieLayer;
			Collider2D[] array;
			if ((this.gold ? 1 : 0) == num2)
			{
				if (num2 >= array.Length)
				{
					goto IL_0196;
				}
				bool flag2;
				if (flag2)
				{
					PlantType plantType = this.fromType;
					bool flag3;
					if (flag3)
					{
					}
				}
				num2++;
			}
			if ((this.main ? 1 : 0) != num2 && (this.lianxie ? 1 : 0) != num2)
			{
				List<BlackHole> blackHoles = Board.Instance.blackHoles;
				bool flag4;
				if (flag4)
				{
				}
				if (num2 != 0)
				{
					continue;
				}
				num9 = 0;
			}
			if (num9 < array.Length)
			{
				bool flag5;
				if (flag5)
				{
				}
				num9++;
				if (num9 < array.Length)
				{
					bool flag6;
					if (flag6)
					{
					}
					num9++;
				}
			}
			IL_0196:
			bool flag7;
			if (flag7)
			{
				global::UnityEngine.Object.Destroy(num);
			}
		}
		while (num9 != 0);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x00045A70 File Offset: 0x00043C70
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x3D1070", Offset = "0x3CF670", VA = "0x1803D1070")]
	public BlackHole()
	{
		List<GameObject> list = new List();
		this.zombiePreviews = list;
		base..ctor();
	}

	// Token: 0x04000809 RID: 2057
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000809")]
	private int _row;

	// Token: 0x0400080A RID: 2058
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400080A")]
	public int shootLevel;

	// Token: 0x0400080B RID: 2059
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400080B")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400080C RID: 2060
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400080C")]
	public int theDamage;

	// Token: 0x0400080D RID: 2061
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400080D")]
	public bool main;

	// Token: 0x0400080E RID: 2062
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400080E")]
	public bool gold;

	// Token: 0x0400080F RID: 2063
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400080F")]
	public bool nut;

	// Token: 0x04000810 RID: 2064
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000810")]
	public SortingGroup g;

	// Token: 0x04000811 RID: 2065
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000811")]
	public Action<Bullet> onGetBullet;

	// Token: 0x04000812 RID: 2066
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000812")]
	public float timer;

	// Token: 0x04000813 RID: 2067
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000813")]
	protected float existTime;

	// Token: 0x04000814 RID: 2068
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000814")]
	protected Animator anim;

	// Token: 0x04000815 RID: 2069
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000815")]
	protected ParticleSystem particle;

	// Token: 0x04000816 RID: 2070
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000816")]
	protected bool dying;

	// Token: 0x04000817 RID: 2071
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000817")]
	protected LayerMask zombieLayer;

	// Token: 0x04000818 RID: 2072
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000818")]
	protected LayerMask bulletLayer;

	// Token: 0x04000819 RID: 2073
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000819")]
	protected float maxTime = 7.5f;

	// Token: 0x0400081A RID: 2074
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400081A")]
	protected float baseTime = 2f;

	// Token: 0x0400081B RID: 2075
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400081B")]
	protected bool lianxie;

	// Token: 0x0400081C RID: 2076
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x400081C")]
	protected bool garlic;

	// Token: 0x0400081D RID: 2077
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400081D")]
	protected float damageMultiplier = 0.6f;

	// Token: 0x0400081E RID: 2078
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400081E")]
	private float totalTime;

	// Token: 0x0400081F RID: 2079
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400081F")]
	private readonly List<GameObject> zombiePreviews;

	// Token: 0x04000820 RID: 2080
	[Token(Token = "0x4000820")]
	private const float dt = 0.008f;
}
