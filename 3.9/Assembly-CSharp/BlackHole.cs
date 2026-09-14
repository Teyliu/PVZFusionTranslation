using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002B6 RID: 694
[Token(Token = "0x20002B6")]
public class BlackHole : MonoBehaviour
{
	// Token: 0x170000DD RID: 221
	// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00045590 File Offset: 0x00043790
	// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000455A4 File Offset: 0x000437A4
	[Token(Token = "0x170000DD")]
	public int Row
	{
		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70")]
		get
		{
			return this._row;
		}
		[Token(Token = "0x6000C34")]
		[Address(RVA = "0x41DF80", Offset = "0x41C580", VA = "0x18041DF80")]
		set
		{
			this._row = value;
			SortingGroup sortingGroup = this.g;
			string text = string.Format("particle{0}", "particle{0}");
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x000455DC File Offset: 0x000437DC
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x41D550", Offset = "0x41BB50", VA = "0x18041D550")]
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

	// Token: 0x06000C36 RID: 3126 RVA: 0x000456CC File Offset: 0x000438CC
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x41D8E0", Offset = "0x41BEE0", VA = "0x18041D8E0")]
	private void OnDestroy()
	{
		bool flag = Board.Instance.blackHoles.Remove(this);
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x000456F0 File Offset: 0x000438F0
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x41DC90", Offset = "0x41C290", VA = "0x18041DC90", Slot = "4")]
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

	// Token: 0x06000C38 RID: 3128 RVA: 0x000457B0 File Offset: 0x000439B0
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x41DDF0", Offset = "0x41C3F0", VA = "0x18041DDF0", Slot = "5")]
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

	// Token: 0x06000C39 RID: 3129 RVA: 0x00045844 File Offset: 0x00043A44
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x41D890", Offset = "0x41BE90", VA = "0x18041D890", Slot = "6")]
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

	// Token: 0x06000C3A RID: 3130 RVA: 0x00045890 File Offset: 0x00043A90
	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x41CE70", Offset = "0x41B470", VA = "0x18041CE70")]
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

	// Token: 0x06000C3B RID: 3131 RVA: 0x00045994 File Offset: 0x00043B94
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x41C680", Offset = "0x41AC80", VA = "0x18041C680")]
	private void AttackUpdate()
	{
		int num4;
		do
		{
			int num = 0;
			Transform transform = base.transform;
			Vector3 vector;
			float z5 = vector.z;
			List<Zombie> allZombies = global::Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__33_ = BlackHole.<>c.<>9__33_0;
			if (<>9__33_ == 0)
			{
				BlackHole.<>c.<>9__33_0 = delegate(Zombie z)
				{
					int num7 = 0;
					if (z != num7)
					{
						long currentAllHealth = z.CurrentAllHealth;
						int num8 = 0;
						long num9 = z.TotalAllHealth;
						num9 -= (long)num8;
						if (currentAllHealth < num9)
						{
							int theZombieType2 = (int)z.theZombieType;
							bool flag2;
							if (!flag2)
							{
								return z.isMindControlled == flag2;
							}
						}
					}
					throw new NullReferenceException();
				};
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

	// Token: 0x06000C3C RID: 3132 RVA: 0x00045ACC File Offset: 0x00043CCC
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x41D9C0", Offset = "0x41BFC0", VA = "0x18041D9C0")]
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

	// Token: 0x06000C3D RID: 3133 RVA: 0x00045B6C File Offset: 0x00043D6C
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x41D950", Offset = "0x41BF50", VA = "0x18041D950")]
	private void OnTriggerExit2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x00045B84 File Offset: 0x00043D84
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x41D810", Offset = "0x41BE10", VA = "0x18041D810")]
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

	// Token: 0x06000C3F RID: 3135 RVA: 0x00045BC8 File Offset: 0x00043DC8
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x41BC60", Offset = "0x41A260", VA = "0x18041BC60", Slot = "7")]
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

	// Token: 0x06000C40 RID: 3136 RVA: 0x00045D98 File Offset: 0x00043F98
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x41DED0", Offset = "0x41C4D0", VA = "0x18041DED0")]
	public BlackHole()
	{
		List<GameObject> list = new List();
		this.zombiePreviews = list;
		base..ctor();
	}

	// Token: 0x04000828 RID: 2088
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000828")]
	private int _row;

	// Token: 0x04000829 RID: 2089
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000829")]
	public int shootLevel;

	// Token: 0x0400082A RID: 2090
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400082A")]
	public PlantType fromType = (PlantType)((ulong)4294967295L);

	// Token: 0x0400082B RID: 2091
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400082B")]
	public int theDamage;

	// Token: 0x0400082C RID: 2092
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400082C")]
	public bool main;

	// Token: 0x0400082D RID: 2093
	[FieldOffset(Offset = "0x31")]
	[Token(Token = "0x400082D")]
	public bool gold;

	// Token: 0x0400082E RID: 2094
	[FieldOffset(Offset = "0x32")]
	[Token(Token = "0x400082E")]
	public bool nut;

	// Token: 0x0400082F RID: 2095
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400082F")]
	public SortingGroup g;

	// Token: 0x04000830 RID: 2096
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000830")]
	public Action<Bullet> onGetBullet;

	// Token: 0x04000831 RID: 2097
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000831")]
	public float timer;

	// Token: 0x04000832 RID: 2098
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000832")]
	protected float existTime;

	// Token: 0x04000833 RID: 2099
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000833")]
	protected Animator anim;

	// Token: 0x04000834 RID: 2100
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000834")]
	protected ParticleSystem particle;

	// Token: 0x04000835 RID: 2101
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000835")]
	protected bool dying;

	// Token: 0x04000836 RID: 2102
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000836")]
	protected LayerMask zombieLayer;

	// Token: 0x04000837 RID: 2103
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000837")]
	protected LayerMask bulletLayer;

	// Token: 0x04000838 RID: 2104
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000838")]
	protected float maxTime = 7.5f;

	// Token: 0x04000839 RID: 2105
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000839")]
	protected float baseTime = 2f;

	// Token: 0x0400083A RID: 2106
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400083A")]
	protected bool lianxie;

	// Token: 0x0400083B RID: 2107
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x400083B")]
	protected bool garlic;

	// Token: 0x0400083C RID: 2108
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400083C")]
	protected float damageMultiplier = 0.6f;

	// Token: 0x0400083D RID: 2109
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400083D")]
	private float totalTime;

	// Token: 0x0400083E RID: 2110
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400083E")]
	private readonly List<GameObject> zombiePreviews;

	// Token: 0x0400083F RID: 2111
	[Token(Token = "0x400083F")]
	private const float dt = 0.008f;
}
