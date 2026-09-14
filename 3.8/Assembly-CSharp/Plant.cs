using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using GameLevel;
using GameLevel.EventNodes;
using GameLevel.RogueShooting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020002F1 RID: 753
[Token(Token = "0x20002F1")]
public class Plant : Entity
{
	// Token: 0x06000D72 RID: 3442 RVA: 0x0004D64C File Offset: 0x0004B84C
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x3EDA30", Offset = "0x3EC030", VA = "0x1803EDA30", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.9f, 1.1f);
		this.theOriginSpeed = num;
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant", "TorchWood", "Zombie" });
		this.potLayer = layerMask;
		LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Bullet", "ZombieBullet" });
		this.bulletLayer = layerMask2;
		LayerMask layerMask3 = LayerMask.GetMask(new string[] { "AirProjectile" });
		this.airLayer = layerMask3;
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
		Board instance = Board.Instance;
		int num2 = 0;
		if (instance != num2)
		{
			float plantMaxVisionX = Board.Instance.plantMaxVisionX;
			this.vision = plantMaxVisionX;
		}
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x0004D754 File Offset: 0x0004B954
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x3F02A0", Offset = "0x3EE8A0", VA = "0x1803F02A0")]
	public void Hid()
	{
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x0004D764 File Offset: 0x0004B964
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x3F4F30", Offset = "0x3F3530", VA = "0x1803F4F30", Slot = "15")]
	protected virtual void Start()
	{
		this.board.OnPlantCreate(this);
		if (this.jigsawType.Contains((uint)4))
		{
			Dictionary<PlantSpeedAdder, float> dictionary = this.speedAdder;
			int num = 0;
			ulong num2;
			bool flag = dictionary.TryGetValue(num, num2);
			Dictionary<PlantSpeedAdder, float> dictionary2 = this.speedAdder;
			int num3 = 0;
			dictionary2[num3] = num2;
		}
		this.UpdateText();
		throw new NullReferenceException();
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x3F6940", Offset = "0x3F4F40", VA = "0x1803F6940", Slot = "16")]
	protected virtual void Update()
	{
		this.PlantUpdate();
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x0004D7D4 File Offset: 0x0004B9D4
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x3EF7D0", Offset = "0x3EDDD0", VA = "0x1803EF7D0", Slot = "17")]
	protected virtual void FixedUpdate()
	{
		this.FlashUpdate();
		float num = this.Timers[1];
		int num2 = 0;
		if (num > (float)num2)
		{
		}
		Animator anim = this.anim;
		float speed = anim.speed;
		if (anim != 0)
		{
			this.OnFixedUpdate();
		}
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x0004D820 File Offset: 0x0004BA20
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "18")]
	protected virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x0004D830 File Offset: 0x0004BA30
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x3F02C0", Offset = "0x3EE8C0", VA = "0x1803F02C0")]
	public bool InRow(int row)
	{
		if (row < this.thePlantRow)
		{
		}
		int y = this.size.m_Y;
		return row <= y;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x0004D860 File Offset: 0x0004BA60
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x3F0020", Offset = "0x3EE620", VA = "0x1803F0020")]
	public int GetRowDistance(int row)
	{
		int num = this.thePlantRow;
		int y = this.size.m_Y;
		int num2 = num - 1;
		num2 += y;
		int num3 = 0;
		num2 -= row;
		return num3;
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0004D898 File Offset: 0x0004BA98
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x3F4B40", Offset = "0x3F3140", VA = "0x1803F4B40", Slot = "19")]
	public virtual void SetColor(Color color)
	{
		ulong num3;
		do
		{
			int num = 0;
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x3F1690", Offset = "0x3EFC90", VA = "0x1803F1690", Slot = "20")]
	public virtual void KillZombie(Zombie zombie)
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x3EDD00", Offset = "0x3EC300", VA = "0x1803EDD00", Slot = "21")]
	public virtual void Charge()
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x0004D8F4 File Offset: 0x0004BAF4
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x3F6090", Offset = "0x3F4690", VA = "0x1803F6090", Slot = "22")]
	public virtual void TryBeDisable(float timer = 0f)
	{
		ulong num3;
		for (;;)
		{
			int num = (int)this.thePlantType;
			bool flag;
			if (flag && flag)
			{
				this.Charge();
			}
			Board board = this.board;
			SynergyManager instance = SynergyManager.Instance;
			int num2 = 0;
			if (instance.GetActiveSynergies(num2 != 0).Contains((uint)6))
			{
				return;
			}
			PlantType plantType = this.thePlantType;
			if (plantType > PlantType.BigSunNut)
			{
				if (plantType == PlantType.BigWallNut || plantType == PlantType.CherryJalapeno)
				{
					return;
				}
			}
			else
			{
				while (plantType == PlantType.Firecracker)
				{
				}
				while (plantType == PlantType.BigSunNut)
				{
				}
			}
			if (!this.FindPineFunrce())
			{
				if (this.disableCount != 0)
				{
					break;
				}
				Material material = GameMaterial.GetMaterial((MaterialType)((uint)1));
				List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
				bool flag2;
				if (flag2)
				{
				}
				if (num3 == (ulong)0L)
				{
					break;
				}
			}
		}
		while (num3 == (ulong)0L)
		{
		}
		HashSet<SceneType> snowMaps = MapData_cs.SnowMaps;
		bool flag3;
		if (flag3)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x0004D9D0 File Offset: 0x0004BBD0
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x3EF5F0", Offset = "0x3EDBF0", VA = "0x1803EF5F0")]
	private bool FindPineFunrce()
	{
		int num;
		for (;;)
		{
			num = 0;
			int num2 = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, num2);
			int num3 = 0;
			bool flag;
			if (flag)
			{
				break;
			}
			if (num3 == 0)
			{
				goto Block_1;
			}
		}
		if (num != 0)
		{
		}
		int num4 = this.thePlantColumn;
		int num5 = this.thePlantRow;
		return true;
		Block_1:
		throw new NullReferenceException();
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x0004DA28 File Offset: 0x0004BC28
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x3F5B90", Offset = "0x3F4190", VA = "0x1803F5B90", Slot = "23")]
	public virtual void TryBeActive()
	{
		int num5;
		for (;;)
		{
			int num = 0;
			PlantType plantType = this.thePlantType;
			if (plantType > PlantType.BigSunNut)
			{
				if (plantType == PlantType.BigWallNut || plantType == PlantType.CherryJalapeno)
				{
					break;
				}
			}
			else
			{
				while (num == 222)
				{
				}
				while (num == 251)
				{
				}
			}
			int num2 = this.disableCount;
			int num3 = num2 - 1;
			this.disableCount = num3;
			int num4 = num2 - 1;
			num5 = 0;
			this.disableCount = num5;
			Material material = GameMaterial.GetMaterial(MaterialType.Default);
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			if (flag)
			{
			}
			if (num5 == 0)
			{
				int num6 = 0;
				bool flag2;
				while (flag2)
				{
				}
				if (MapData_cs.SnowMaps.Contains(num6))
				{
					goto Block_4;
				}
			}
		}
		return;
		Block_4:
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/IceTrap");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform;
		Renderer component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num5, identityQuaternion, transform).GetComponent<ParticleSystem>().GetComponent<Renderer>();
		string text = string.Format("particle{0}", component);
		component.sortingLayerName = text;
		throw new NullReferenceException();
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x0004DB1C File Offset: 0x0004BD1C
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x3EE040", Offset = "0x3EC640", VA = "0x1803EE040")]
	private bool CheckOrActive()
	{
		PlantType plantType = this.thePlantType;
		if (plantType > PlantType.BigSunNut)
		{
			if (plantType == PlantType.BigWallNut || plantType == PlantType.CherryJalapeno)
			{
				return true;
			}
		}
		else
		{
			while (1UL == (ulong)222L)
			{
			}
			while (1UL == (ulong)251L)
			{
			}
		}
		return false;
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x0004DB64 File Offset: 0x0004BD64
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x3F02F0", Offset = "0x3EE8F0", VA = "0x1803F02F0")]
	public void InitText()
	{
		if (this.plantTag == (ulong)0L && !this.isLily)
		{
			HealthSlider healthSlider = global::UnityEngine.Object.Instantiate<HealthSlider>(Resources.Load<HealthSlider>("Image/HealthIcon/HealthHUD"));
			this.healthSlider = healthSlider;
			Transform transform = this.healthSlider.transform;
			Transform uiparent = this.board.UIParent;
			int num = 0;
			transform.SetParent(uiparent, num != 0);
			this.healthSlider.follow = this;
			Board board = this.board;
			HealthSlider healthSlider2 = this.healthSlider;
			int showPlantHealth = board.showPlantHealth;
			GameObject fillObject = healthSlider2.fillObject;
			healthSlider2.showType = showPlantHealth;
			bool flag = showPlantHealth == 2;
			fillObject.SetActive(flag);
			GameObject gameObject = healthSlider2.healthText.gameObject;
			bool flag2 = showPlantHealth == 1;
			gameObject.SetActive(flag2);
			GameObject gameObject2 = healthSlider2.healthTextContainer.gameObject;
			bool flag3 = showPlantHealth != 0;
			gameObject2.SetActive(flag3);
			HealthSlider healthSlider3 = this.healthSlider;
			int num2 = 0;
			healthSlider3.offset = num2;
			healthSlider3.offset.y = 1f;
			healthSlider3.offset.y = 0.2f;
			Transform transform2 = this.healthSlider.layout.transform;
			Transform transform3 = this.healthSlider.layout.transform;
			Transform transform4 = this.healthSlider.transform;
			Vector3 vector;
			float z = vector.z;
			HealthSlider healthSlider4 = this.healthSlider;
			int num3 = 0;
			healthSlider4.offset.y = 0.5f;
			healthSlider4.offset = num3;
			this.OnAfterInitText();
		}
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0004DCEC File Offset: 0x0004BEEC
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "24")]
	protected virtual void OnAfterInitText()
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x0004DCFC File Offset: 0x0004BEFC
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x3F6820", Offset = "0x3F4E20", VA = "0x1803F6820", Slot = "25")]
	public virtual void UpdateText()
	{
		HealthSlider healthSlider = this.healthSlider;
		int num = 0;
		if (healthSlider != num)
		{
			HealthSlider healthSlider2 = this.healthSlider;
			int num2 = 0;
			int num3 = 0;
			healthSlider2.HealthValue = (float)num2;
			Image shieldFill = this.healthSlider.shieldFill;
			this.healthSlider.shieldFill.fillAmount = (float)num3;
			this.healthSlider.UpdateText();
		}
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x0004DD64 File Offset: 0x0004BF64
	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x3F3270", Offset = "0x3F1870", VA = "0x1803F3270", Slot = "26")]
	public virtual void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		int num;
		float[] timers;
		float num4;
		int num6;
		do
		{
			num = 0;
			timers = this.Timers;
			float num2 = timers[0];
			int num3 = 0;
			if (num2 > (float)num3 || num3 >= (int)health)
			{
				return;
			}
			HashSet<EveZombieBuff> eveZombieBuffs = this.board.eveZombieBuffs;
			bool flag;
			bool flag2;
			if (flag || flag2)
			{
				num4 = health * 0.5f;
			}
			HashSet<EveBuff> hashSet = this.eveBuffs;
			bool flag3;
			if (!flag3)
			{
				break;
			}
			int num5 = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, num5);
			bool flag4;
			if (flag4)
			{
			}
			if (num != 0)
			{
				goto IL_014D;
			}
			num6 = 0;
			bool flag5;
			if (flag5)
			{
			}
		}
		while (num6 != 0);
		if (RogueManager.Instance.leaderType == LeaderType.UltimateChomper)
		{
		}
		if (global::Lawnf.TravelCurse())
		{
		}
		bool flag6;
		if (flag6)
		{
		}
		bool flag7;
		float num7;
		if (flag7)
		{
			num7 = num4 * 1.2f;
		}
		bool flag8;
		if (flag8)
		{
		}
		bool flag9;
		if (!flag9 || num7 <= (float)num)
		{
		}
		Func<Zombie, bool> func;
		if (Plant.<>c.<>9__110_0 == 0)
		{
			Plant.<>c.<>9__110_0 = func;
		}
		List<Zombie> list2;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(list2, func);
		int num8 = 0;
		if (zombie != num8)
		{
			float num9 = health * 0.1f;
			float num11;
			float num10 = num11 * 0.01f;
			if (num10 <= num9)
			{
			}
			float num12 = timers[60];
			throw new NullReferenceException();
		}
		Vector3 vector;
		float z = vector.z;
		ParticleManager instance = ParticleManager.Instance;
		int num13 = 0;
		Particle particle2;
		if (particle2 != num13)
		{
			Transform transform = particle2.transform;
		}
		return;
		IL_014D:
		throw new NullReferenceException();
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x0004DECC File Offset: 0x0004C0CC
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x3F0050", Offset = "0x3EE650", VA = "0x1803F0050", Slot = "27")]
	public virtual void GetShield(float value)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x0004DEE0 File Offset: 0x0004C0E0
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x3F0690", Offset = "0x3EEC90", VA = "0x1803F0690")]
	private bool InsteadRecover()
	{
		PlantType plantType = this.thePlantType;
		if ((plantType > PlantType.CherryUltimatePumpkin && (plantType == PlantType.CherryNut || plantType == PlantType.CherryPumpkin)) || plantType == PlantType.UltimateChomper || plantType == PlantType.CherryUltimatePumpkin)
		{
			int num = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, num);
			Predicate<Plant> <>9__112_ = Plant.<>c.<>9__112_0;
			if (<>9__112_ == 0)
			{
				Predicate<Plant> predicate;
				Plant.<>c.<>9__112_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__112_);
			int num3 = list._size;
			num3 = global::UnityEngine.Random.Range(0, num3);
			Plant plant = list[num3];
			if (!plant.alwaysLightUp)
			{
				plant.lightCountDown = 0.2f;
			}
			plant.UpdateText();
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0004DF90 File Offset: 0x0004C190
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x3F16A0", Offset = "0x3EFCA0", VA = "0x1803F16A0", Slot = "28")]
	protected virtual void LimHealth()
	{
		int num = this.thePlantMaxHealth;
		if (this.thePlantHealth > num)
		{
			this.thePlantHealth = num;
		}
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0004DFB4 File Offset: 0x0004C1B4
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "29")]
	protected virtual void ReplaceSprite()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x0004DFC4 File Offset: 0x0004C1C4
	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x3EDCE0", Offset = "0x3EC2E0", VA = "0x1803EDCE0")]
	public void Broken()
	{
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x3EDD20", Offset = "0x3EC320", VA = "0x1803EDD20")]
	protected bool CheckJackbox()
	{
		for (;;)
		{
			int num = 0;
			GridSystem gridSystem = this.board.gridSystem;
			int num2 = this.thePlantRow;
			int num3 = this.thePlantColumn;
			List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
			int num4 = 0;
			bool flag;
			if (flag)
			{
				int num5 = 0;
				bool flag2 = num != num5;
				while (!flag2)
				{
				}
				if (flag2 > true && !flag2 && !flag2)
				{
					while (!flag2)
					{
					}
				}
				if (!flag2)
				{
					while (!flag2)
					{
					}
				}
				List<Plant> plants2 = MagnetSystem.GetPlants(num);
				bool flag3;
				if (flag3)
				{
					break;
				}
				if (num4 != 0)
				{
					goto IL_0093;
				}
			}
			if (num4 == 0)
			{
				goto Block_5;
			}
		}
		return true;
		Block_5:
		throw new NullReferenceException();
		IL_0093:
		throw new NullReferenceException();
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x0004E084 File Offset: 0x0004C284
	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x3F3180", Offset = "0x3F1780", VA = "0x1803F3180")]
	public void RealTakeDamage(int damage)
	{
		this.UpdateText();
		this.ReplaceSprite();
		this.lastTakeDamgeTime = 0f;
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x0004E0AC File Offset: 0x0004C2AC
	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0x3F51D0", Offset = "0x3F37D0", VA = "0x1803F51D0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		for (;;)
		{
			int num = 0;
			Plant.<>c__DisplayClass118_0 CS$<>8__locals1 = new Plant.<>c__DisplayClass118_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.damage = damage;
			float num2 = this.Timers[1];
			int num3 = 0;
			if (num2 > (float)num3)
			{
				break;
			}
			bool flag;
			if (damageType == DamageType.JackboxExplode)
			{
				if (this.CheckJackbox())
				{
					break;
				}
			}
			else if (damageType != DamageType.Crash || flag)
			{
			}
			int damage2 = CS$<>8__locals1.damage;
			int num4 = this.LimDamage;
			if (damage2 < num4)
			{
				num4 = damage2;
			}
			CS$<>8__locals1.damage = num4;
			if (!this.Instead(num4))
			{
				int damage3 = CS$<>8__locals1.damage;
				int damage4 = this.GetDamage(damage3);
				CS$<>8__locals1.damage = damage4;
				HashSet<EveBuff> hashSet = this.eveBuffs;
				bool flag2;
				int num8;
				if (flag2)
				{
					int num5 = this.thePlantRow;
					num5++;
					List<Plant> list = global::Lawnf.Get1x1Plants(this.thePlantColumn, num5);
					bool flag3;
					if (flag3)
					{
					}
					ulong num6;
					if (num6 != (ulong)0L)
					{
						goto IL_020A;
					}
					bool flag4;
					if (flag4)
					{
					}
					ulong num7;
					if (num7 != (ulong)0L)
					{
						goto IL_0216;
					}
					num8 = 0;
				}
				int num9 = CS$<>8__locals1.damage;
				int num10;
				num9 -= num10;
				int num11 = CS$<>8__locals1.damage;
				num11 -= num10;
				if (num11 <= 0)
				{
					goto IL_0204;
				}
				List<TalentType> talents = AdvantureConfig.data.talents;
				bool flag5;
				if (flag5)
				{
					DelayAction delayAction;
					if (num == 22)
					{
						Func<Zombie, float> func;
						if (Plant.<>c.<>9__118_0 == 0)
						{
							Plant.<>c.<>9__118_0 = func;
						}
						List<Zombie> list2;
						Zombie zombie5 = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(list2, func));
						Zombie zombie = zombie5;
						Zombie zombie2 = zombie;
						int num12 = 0;
						if (!(zombie2 != num12) || zombie.theStatus == ZombieStatus.Dying)
						{
							continue;
						}
						delayAction = GameAPP.delayAction;
						Action action = delegate
						{
							Zombie zombie3 = zombie;
							int num14 = 0;
							if (zombie3 != num14)
							{
								Plant.<>c__DisplayClass118_0 CS$<>8__locals4 = CS$<>8__locals1;
								Plant <>4__this = CS$<>8__locals4.<>4__this;
								int damage5 = CS$<>8__locals4.damage;
								Zombie zombie4 = zombie;
							}
						};
						delayAction.SetAction(action, (float)num8);
					}
					while (delayAction != (ulong)24L)
					{
					}
					DelayAction delayAction2 = GameAPP.delayAction;
					Action action2;
					if (CS$<>8__locals1.<>9__2 == 0)
					{
						Plant.<>c__DisplayClass118_0 CS$<>8__locals3 = CS$<>8__locals1;
						action2 = delegate
						{
							Plant <>4__this2 = CS$<>8__locals3.<>4__this;
							int num15 = 0;
							if (<>4__this2 != num15)
							{
								Plant <>4__this3 = CS$<>8__locals3.<>4__this;
								int num16 = CS$<>8__locals3.damage;
								num16 -= num15;
								int num17 = 0;
								float num18;
								ulong num19;
								ulong num20;
								<>4__this3.Recover(num18, (DamageType)num17, num19 != 0UL, num20 != 0UL);
							}
						};
						CS$<>8__locals3.<>9__2 = action2;
					}
					delayAction2.SetAction(action2, (float)num8);
				}
				ulong num13;
				if (num13 == (ulong)0L)
				{
					goto IL_0204;
				}
			}
		}
		return;
		IL_0204:
		throw new NullReferenceException();
		IL_020A:
		throw new NullReferenceException();
		IL_0216:
		throw new NullReferenceException();
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
	[Token(Token = "0x6000D8D")]
	[Address(RVA = "0x3EE9B0", Offset = "0x3ECFB0", VA = "0x1803EE9B0", Slot = "30")]
	protected virtual void DecreateShield(int value)
	{
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x0004E300 File Offset: 0x0004C500
	[Token(Token = "0x6000D8E")]
	[Address(RVA = "0x3EE7F0", Offset = "0x3ECDF0", VA = "0x1803EE7F0", Slot = "31")]
	protected virtual void DecreaseHealth(int value)
	{
		int num = 0;
		bool flag;
		if (flag)
		{
			int num2 = (int)this.thePlantType;
			float num3 = (float)(num * (int)0.4f);
			int num4 = (int)this.thePlantType;
			PlantDataManager.PlantData plantData;
			this.thePlantMaxHealth = plantData;
		}
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x0004E33C File Offset: 0x0004C53C
	[Token(Token = "0x6000D8F")]
	[Address(RVA = "0x3EFAD0", Offset = "0x3EE0D0", VA = "0x1803EFAD0", Slot = "32")]
	protected virtual int GetDamage(int damage)
	{
		bool flag;
		if (flag)
		{
			float num = global::UnityEngine.Random.Range((float)0, 1f);
			if (TravelMgr.Instance.LuckyStrike * 0.3f > num)
			{
				goto IL_0038;
			}
		}
		bool flag2;
		if (flag2)
		{
			float num2 = global::UnityEngine.Random.Range((float)0, 1f);
		}
		IL_0038:
		bool flag3;
		if (!flag3 || this.isConnected)
		{
		}
		float num3 = this.Timers[3];
		float num5;
		float num4 = num5 * this.defence;
		if (num3 * 0.3f > 0.2f)
		{
			AdvantureData data = AdvantureConfig.data;
			bool flag4;
			if (flag4)
			{
			}
		}
		float num6;
		if (this.theShieldHealth > 0)
		{
			num6 = num4 * 0.8f;
		}
		Board board = this.board;
		Func<Zombie, bool> func;
		if (Plant.<>c.<>9__121_0 == 0)
		{
			Plant.<>c.<>9__121_0 = func;
		}
		List<Zombie> list;
		float num7;
		if (Enumerable.FirstOrDefault<Zombie>(list, func))
		{
			num7 = num6 * 0.1f;
		}
		float num8;
		if (this.PotType == PlantType.NutPot)
		{
			num8 = num7 * 0.8f;
		}
		List<JigsawType> list2 = this.jigsawType;
		bool flag5;
		float num9;
		if (flag5)
		{
			num9 = num8 * 0.85f;
		}
		float num10 = this.Timers[0];
		float num11 = num9 * 3f;
		if (global::Lawnf.TravelCurse() || TravelMgr.Instance.data.invest_challenge)
		{
		}
		bool flag6;
		float num12;
		if (flag6)
		{
			num12 = num11 * 4f;
		}
		Dictionary<EffectType, BaseEffect> effects = this.effects;
		bool flag7;
		if (flag7)
		{
		}
		bool flag8;
		if (flag8)
		{
			float num13 = num10 * 0.1f;
			if (num12 > num13)
			{
			}
		}
		TravelMgr instance = TravelMgr.Instance;
		throw new NullReferenceException();
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x0004E4B4 File Offset: 0x0004C6B4
	[Token(Token = "0x6000D90")]
	[Address(RVA = "0x3F08C0", Offset = "0x3EEEC0", VA = "0x1803F08C0", Slot = "33")]
	protected virtual bool Instead(int theDamage)
	{
		int num11;
		do
		{
			int num = 0;
			int num2 = 0;
			float num3 = this.Timers[3];
			int num4 = 0;
			if (num3 > (float)num4)
			{
				goto IL_01C2;
			}
			List<JigsawType> list = this.jigsawType;
			bool flag;
			if (flag)
			{
				goto IL_01C2;
			}
			bool flag2;
			if (flag2)
			{
				int num5 = this.thePlantColumn;
				int num6 = this.thePlantColumn;
				num6++;
				int num7 = this.thePlantRow;
				List<Plant> list2 = global::Lawnf.Get1x1Plants(num5, num7);
				bool flag3;
				if (flag3)
				{
					if (!flag3)
					{
						while (!flag3)
						{
						}
					}
					ParticleManager instance = ParticleManager.Instance;
					Transform axis = this.axis;
					Vector3 vector;
					float z = vector.z;
				}
				if (num2 != 0)
				{
					goto IL_01C8;
				}
				num5++;
			}
			int num8 = this.thePlantRow;
			List<Plant> list3 = global::Lawnf.Get3x3Plants(this.thePlantColumn, num8);
			bool flag4;
			if (flag4)
			{
				int num9 = 0;
				if (!(num != num9))
				{
					continue;
				}
				bool flag5;
				bool flag6;
				if (flag5 && !flag6)
				{
					ParticleManager instance2 = ParticleManager.Instance;
					Transform axis2 = this.axis;
				}
				Particle particle;
				if (particle <= (ulong)1129L)
				{
					continue;
				}
				if (particle == (ulong)1151L)
				{
					ParticleManager instance3 = ParticleManager.Instance;
					Transform axis3 = this.axis;
				}
				Particle particle2;
				if (particle2 == (ulong)1207L)
				{
					ParticleManager instance4 = ParticleManager.Instance;
					Transform axis4 = this.axis;
				}
				Particle particle3;
				while (particle3 != (ulong)1255L)
				{
				}
				int num10 = this.thePlantColumn;
				if (this.thePlantRow == 223)
				{
					ParticleManager instance5 = ParticleManager.Instance;
					Transform axis5 = this.axis;
				}
				Particle particle4;
				while (particle4 != (ulong)1129L)
				{
				}
				ParticleManager instance6 = ParticleManager.Instance;
				Transform axis6 = this.axis;
			}
			if (num2 != 0)
			{
				goto IL_0210;
			}
			num11 = 0;
			if (Plant.<>c.<>9__122_0 == 0)
			{
				Func<Plant, bool> func;
				Plant.<>c.<>9__122_0 = func;
			}
			int num12 = 0;
			Plant plant;
			if (plant != num12)
			{
				break;
			}
			bool flag7;
			if (flag7)
			{
				CrackStatus crackStatus;
				while (crackStatus != CrackStatus.Good)
				{
				}
			}
		}
		while (num11 != 0);
		Transform axis7 = this.axis;
		ParticleManager instance7 = ParticleManager.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		Vector3 vector3;
		float z3 = vector3.z;
		IL_01C2:
		throw new NullReferenceException();
		IL_01C8:
		throw new NullReferenceException();
		IL_0210:
		throw new NullReferenceException();
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x0004E6D8 File Offset: 0x0004C8D8
	[Token(Token = "0x6000D91")]
	[Address(RVA = "0x3EF8E0", Offset = "0x3EDEE0", VA = "0x1803EF8E0")]
	public void FlashOnce()
	{
		if (!this.alwaysLightUp)
		{
			this.lightCountDown = 0.2f;
		}
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x0004E6FC File Offset: 0x0004C8FC
	[Token(Token = "0x6000D92")]
	[Address(RVA = "0x3EE9C0", Offset = "0x3ECFC0", VA = "0x1803EE9C0", Slot = "34")]
	public virtual void Die(Plant.DieReason reason = Plant.DieReason.Default)
	{
		int num7;
		EventNodeManager instance5;
		for (;;)
		{
			int num = 0;
			if ((this.dying ? 1 : 0) != num)
			{
				return;
			}
			this.dying = true;
			if (Mouse.Instance.thePlantOnGlove == this)
			{
				global::UnityEngine.Object.Destroy(Mouse.Instance.theItemOnMouse);
				Mouse instance = Mouse.Instance;
				int num2 = 0;
				instance.theItemOnMouse = num2;
				Mouse.Instance.thePlantTypeOnMouse = (PlantType)((ulong)4294967295L);
				Mouse.Instance.thePlantOnGlove = num2;
			}
			int num3 = 0;
			Board board = this.board;
			if (reason == Plant.DieReason.Default || reason == Plant.DieReason.BySteal || board <= (ulong)1L)
			{
				this.GiveSunInIZ();
			}
			GridItem ladder = this.Ladder;
			int num4 = 0;
			GridItem ladder2;
			if (ladder != num4)
			{
				ladder2 = this.Ladder;
				ladder2.Die();
			}
			this.RemoveFromList();
			if (ladder2 <= (ulong)1L || reason != Plant.DieReason.Wheel)
			{
			}
			Plant plant = this.jalapuff;
			int num5 = 0;
			if (plant != num5)
			{
				Plant plant2 = this.jalapuff;
			}
			HashSet<EveBuff> hashSet = this.eveBuffs;
			bool flag;
			if (flag)
			{
				CreateZombie instance2 = CreateZombie.Instance;
				Transform axis = this.axis;
			}
			Board board2 = this.board;
			if (RogueManager.Instance.leaderType != LeaderType.UltimateTallNut)
			{
				goto IL_0142;
			}
			if (reason == Plant.DieReason.Default)
			{
				int num6 = this.thePlantRow;
				List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, num6);
				bool flag2;
				if (flag2)
				{
				}
				if (num3 == 0)
				{
					num7 = 0;
					goto IL_0142;
				}
				continue;
			}
			IL_015D:
			MagnetSystem.MagnetSystemUpdate();
			DroppedCard droppedCard;
			bool isExtra = droppedCard.isExtra;
			bool flag3;
			if (flag3)
			{
			}
			UIMgr.EnterLoseMenu("需要被保护的植物死亡了");
			if (!flag3)
			{
			}
			int num8 = 0;
			Plant plant3;
			Plant plant4;
			if (plant3 != num8 && plant4.thePlantType == PlantType.BigPumpkin)
			{
				int num9 = 0;
				Plant plant5;
				plant5.Die((Plant.DieReason)num9);
			}
			ShootingManager instance3 = ShootingManager.Instance;
			ulong num10;
			num10 += num10;
			if (num10 > (ulong)0L)
			{
				CreateItem instance4 = CreateItem.Instance;
				num7++;
			}
			instance5 = EventNodeManager.Instance;
			int num11 = 0;
			if (instance5 != num11)
			{
				break;
			}
			continue;
			IL_0142:
			bool flag4;
			if (flag4 && flag4 > true && !flag4)
			{
				Vector3 vector;
				float z = vector.z;
				goto IL_015D;
			}
			goto IL_015D;
		}
		if (EventNodeManager.Instance > (ulong)7L)
		{
			GameObject gameObject = base.gameObject;
			this.hid = true;
			List<Plant> hiddenPlants = this.board.boardEntity.hiddenPlants;
			GameObject gameObject2 = base.gameObject;
			int num12 = 0;
			gameObject2.SetActive(num12 != 0);
			BoardStatistics boardStatistics = this.board.boardStatistics;
			throw new NullReferenceException();
		}
		global::UnityEngine.Object.Destroy(instance5);
		global::UnityEngine.Object.Destroy(instance5.gameObject);
		Collider2D[] array;
		if (num7 < array.Length)
		{
			num7++;
		}
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0004E988 File Offset: 0x0004CB88
	[Token(Token = "0x6000D93")]
	[Address(RVA = "0x3EE0F0", Offset = "0x3EC6F0", VA = "0x1803EE0F0", Slot = "35")]
	public virtual void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		while (!this.isCrashed && this.plantTag == (ulong)0L)
		{
			float[] timers = this.Timers;
			float num = timers[1];
			int num2 = 0;
			if (num > (float)num2)
			{
				break;
			}
			this.isCrashed = true;
			if ("{il2cpp array field local5->}" != typeof(global::Squash).TypeHandle)
			{
				PlantType plantType = this.thePlantType;
				if (plantType <= PlantType.PotatoChomper)
				{
					goto IL_0175;
				}
				if (plantType > PlantType.JalaTorch)
				{
					if (plantType == PlantType.SpikeRock)
					{
						goto IL_01CF;
					}
					if (plantType == PlantType.SuperKelp)
					{
						goto IL_01A0;
					}
					if (timers <= (ulong)1L)
					{
						goto IL_01CF;
					}
					if (!this.OnCrash())
					{
						if (soundID != 0)
						{
							GameAPP.PlaySound(soundID, 0.3f, 1f);
						}
						PlantType plantType2 = this.thePlantType;
						Transform transform = this.board.transform;
						Transform axis = this.axis;
						Vector3 vector;
						float z = vector.z;
						GameObject gameObject;
						Transform transform2 = gameObject.transform;
						Vector3 vector2;
						float z2 = vector2.z;
						float num3 = (float)(num2 * (int)0.2f);
						Transform transform3 = gameObject.transform;
						SortingGroup component = gameObject.GetComponent<SortingGroup>();
						int num4 = this.thePlantRow;
						string text = string.Format("plant{0}", component);
						component.sortingLayerName = text;
						int num5 = 0;
						component.sortingOrder = num5;
						global::UnityEngine.Object.Destroy(gameObject, 3f);
					}
					GridSystem gridSystem = this.board.gridSystem;
					int num6 = this.thePlantRow;
					int num7 = this.thePlantColumn;
					if (gridSystem.GetBoxType(num7, num6) != BoxType.Water)
					{
						break;
					}
					goto IL_01F1;
				}
				else
				{
					if ("plant{0}" <= (ulong)2L)
					{
						goto IL_01A0;
					}
					if ("plant{0}" > (ulong)1L)
					{
						goto IL_0175;
					}
					goto IL_0199;
				}
				IL_01C5:
				while (zombie != (ulong)906L)
				{
				}
				goto IL_01CF;
				IL_01A0:
				int num8 = 0;
				if (zombie != num8)
				{
					while (zombie.theZombieType == ZombieType.ZombieBoss)
					{
					}
					while (zombie.theZombieType == ZombieType.ZombieBoss2)
					{
					}
					goto IL_01C5;
				}
				continue;
				IL_0199:
				if (this == (ulong)15L)
				{
					goto IL_01A0;
				}
				goto IL_01C5;
				IL_0175:
				if ("plant{0}" > (ulong)906L)
				{
					while ("plant{0}" > (ulong)12L)
					{
					}
					while ("plant{0}" >= (ulong)12L)
					{
					}
					goto IL_0199;
				}
				goto IL_0199;
				IL_01CF:
				int num9 = 0;
				if (zombie != num9)
				{
					while (zombie.theZombieType == ZombieType.ZombieBoss)
					{
					}
					while (zombie.theZombieType == ZombieType.ZombieBoss2)
					{
					}
				}
				IL_01F1:
				throw new NullReferenceException();
			}
			break;
		}
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x0004EB8C File Offset: 0x0004CD8C
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "36")]
	protected virtual bool OnCrash()
	{
		return false;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0004EB9C File Offset: 0x0004CD9C
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x3ED7C0", Offset = "0x3EBDC0", VA = "0x1803ED7C0")]
	public void AdjustPosition(Vector3 targetPosition)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x0004EBC8 File Offset: 0x0004CDC8
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x3ED720", Offset = "0x3EBD20", VA = "0x1803ED720")]
	public void AdjustPositionY(float y)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0004EBF4 File Offset: 0x0004CDF4
	[Token(Token = "0x6000D97")]
	[Address(RVA = "0x3ED8C0", Offset = "0x3EBEC0", VA = "0x1803ED8C0")]
	public void AdjustY(float y)
	{
		Transform axis = this.axis;
		Rigidbody2D rigidbody2D = this.rb;
		int num = 0;
		Vector2 position = rigidbody2D.position;
		this.rb.MovePosition(num);
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x0004EC2C File Offset: 0x0004CE2C
	[Token(Token = "0x6000D98")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "37")]
	public virtual void ProducerUpdate()
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0004EC3C File Offset: 0x0004CE3C
	[Token(Token = "0x6000D99")]
	[Address(RVA = "0x3F4AD0", Offset = "0x3F30D0", VA = "0x1803F4AD0", Slot = "38")]
	public virtual void SetBrightness(float b)
	{
		this.brightness = b;
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0004EC5C File Offset: 0x0004CE5C
	[Token(Token = "0x6000D9A")]
	[Address(RVA = "0x3EF900", Offset = "0x3EDF00", VA = "0x1803EF900")]
	private void FlashUpdate()
	{
		float[] timers = this.Timers;
		float num = timers[1];
		int num2 = 0;
		if (num > (float)num2)
		{
			this.SetBrightness(3f);
			return;
		}
		float num3 = this.flashCountDown;
		if (num3 <= (float)num2)
		{
			float num4 = this.lightCountDown;
			if (num4 > (float)num2)
			{
				if (num4 > 0.2f || num4 > (float)num2)
				{
					float num5 = num4 * -30f;
					this.SetBrightness(num5);
				}
				float num6 = this.lightCountDown;
				float fixedDeltaTime = Time.fixedDeltaTime;
				this.lightCountDown = num6;
				this.SetBrightness(1f);
				this.lightCountDown = 0f;
			}
			return;
		}
		float fixedDeltaTime2 = Time.fixedDeltaTime;
		this.flashCountDown = num3;
		float num7 = num3 * 4f;
		uint num8;
		num8 -= timers;
		float num9;
		this.SetBrightness(num9);
		this.flashCountDown = 0f;
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0004ED30 File Offset: 0x0004CF30
	[Token(Token = "0x6000D9B")]
	[Address(RVA = "0x3F25D0", Offset = "0x3F0BD0", VA = "0x1803F25D0")]
	private void PlantUpdate()
	{
		int num10;
		do
		{
			Plant plant = this.jalapuff;
			int num = 0;
			if (plant != num && plant.attributeCount == 0)
			{
				int num2 = 0;
				this.jalapuff = num2;
			}
			int num3 = 0;
			Plant plant2;
			if (plant == num3)
			{
				Func<Plant, bool> func;
				if (Plant.<>c.<>9__133_0 == 0)
				{
					Plant.<>c.<>9__133_0 = func;
				}
				List<Plant> list;
				plant2 = Enumerable.FirstOrDefault<Plant>(list, func);
			}
			int num4 = 0;
			if (!(plant2 != num4))
			{
				EveManager instance = EveManager.Instance;
				int num5 = 0;
				if (instance != num5 && instance.newEve)
				{
					List<int> recoverTimes = instance.newEveData.recoverTimes;
					int num6 = this.thePlantRow;
					if (recoverTimes[num6] > 0)
					{
						List<int> recoverTimes2 = instance.newEveData.recoverTimes;
						int num7 = recoverTimes2[num6] - 1;
						recoverTimes2[num6] = num7;
						int num8 = this.thePlantMaxHealth;
						this.thePlantHealth = num8;
						this.ReplaceSprite();
						this.UpdateText();
						ParticleManager instance2 = ParticleManager.Instance;
						Transform axis = this.axis;
						Vector3 vector;
						float z = vector.z;
					}
				}
				int num9 = 0;
				this.Die((Plant.DieReason)num9);
			}
			this.thePlantHealth = (int)((ulong)1L);
			this.UpdateText();
			bool flag = "{il2cpp field on Plant.UpdateText, offset 0xFFFFFFFFFFFFFFF8}" == typeof(UltimateJalapeno).TypeHandle;
			num10 = 0;
			int num11 = 0;
			Animator anim = this.anim;
			float num12 = this.thePlantSpeed;
			anim.SetFloat("Speed", num12);
			GridSystem gridSystem = this.board.gridSystem;
			int num13 = this.thePlantRow;
			int num14 = this.thePlantColumn;
			if (gridSystem.GetBoxType(num14, num13) == BoxType.Water && this.freeMoving)
			{
				Transform transform = base.transform;
				GridSystem gridSystem2 = this.board.gridSystem;
				int num15 = this.thePlantRow;
				int num16 = this.thePlantColumn;
				BoardGrid grid = gridSystem2.GetGrid(num16, num15);
				float z2 = this.startPos.z;
				if (!this.isLily)
				{
					CreatePlant instance3 = CreatePlant.Instance;
					PlantType plantType = this.thePlantType;
					if (!instance3.IsPuff(plantType))
					{
						Transform transform2 = base.transform;
						Vector3 vector2;
						float z3 = vector2.z;
					}
				}
			}
			float deltaTime = Time.deltaTime;
			this.lastTakeDamgeTime = deltaTime;
			if (!(this.board.controledPlant == this))
			{
				Board board = this.board;
			}
			Board board2 = this.board;
			Vector2 vector3;
			this.MovePosition(vector3);
			GridSystem gridSystem3 = this.board.gridSystem;
			int num17 = this.thePlantRow;
			int num18 = this.thePlantColumn;
			int lightLevel = gridSystem3.GetGrid(num18, num17).lightLevel;
			this.currentLightLevel = lightLevel;
			Animator anim2 = this.anim;
			float speed = anim2.speed;
			if (anim2 != 0)
			{
				if (this.wheatType != 0 && this.board.enermyCount > 0)
				{
					this.WheatUpdate();
				}
				float num19 = this.attributeCountdown;
				if (num19 > (float)num11)
				{
					float deltaTime2 = Time.deltaTime;
					this.AttributeCountdown = num19;
					int num20 = 0;
					this.AttributeCountdown = (float)num20;
					this.AttributeEvent();
				}
			}
			float[] timers = this.Timers;
			if (num10 < timers.Length)
			{
				float[] timers2 = this.Timers;
				float num21;
				uint num22;
				if (num21 > (float)num11)
				{
					float[] timers3 = this.Timers;
					float deltaTime3 = Time.deltaTime;
					float num23;
					num22.m_value = (uint)num23;
					float[] timers4 = this.Timers;
					float[] timers5 = this.Timers;
					num22.m_value = (uint)num10;
					if (num10 == 3)
					{
					}
				}
				num10++;
				num22 += (uint)4;
				float[] timers6 = this.Timers;
			}
			List<KeyValuePair<EffectType, BaseEffect>> list2 = Enumerable.ToList<KeyValuePair<EffectType, BaseEffect>>(this.effects);
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num10 != 0);
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0004F0AC File Offset: 0x0004D2AC
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "39")]
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x0004F0BC File Offset: 0x0004D2BC
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x3F3120", Offset = "0x3F1720", VA = "0x1803F3120")]
	private void PositionUpdate()
	{
		Board board = this.board;
		Vector2 vector;
		this.MovePosition(vector);
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0004F0DC File Offset: 0x0004D2DC
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x3F2110", Offset = "0x3F0710", VA = "0x1803F2110")]
	private void MovePosition(Vector2 position)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		float timeScale = Time.timeScale;
		Transform axis2 = this.axis;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		float num = this.moveSpeed;
		float num2 = Time.deltaTime;
		float num3;
		num2 = num3;
		Transform axis3 = this.axis;
		Vector3 position2 = transform2.position;
		num3 = num2;
		float timeScale2 = Time.timeScale;
		CreatePlant instance = CreatePlant.Instance;
		int num4 = this.thePlantRow;
		int num5 = this.thePlantColumn;
		instance.SetLayer(this, num5, num4);
		int num6 = 0;
		base.transform.position = num6;
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0004F190 File Offset: 0x0004D390
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x3F24A0", Offset = "0x3F0AA0", VA = "0x1803F24A0")]
	private bool Near(Vector2 startPosition, Vector2 endPosition)
	{
		float timeScale = Time.timeScale;
		return false;
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0004F1A8 File Offset: 0x0004D3A8
	[Token(Token = "0x6000DA0")]
	[Address(RVA = "0x3F1F90", Offset = "0x3F0590", VA = "0x1803F1F90")]
	public void MoveBox(int theColumn, int theRow)
	{
		Board board = this.board;
		if (theColumn < board.columnNum && theRow < board.rowNum)
		{
			GridSystem gridSystem = board.gridSystem;
			int num = this.thePlantRow;
			int num2 = this.thePlantColumn;
			bool flag = gridSystem.GetGrid(num2, num).plants.Remove(this);
			Board board2 = this.board;
			this.thePlantColumn = theColumn;
			this.thePlantRow = theRow;
			BoardGrid grid = board2.gridSystem.GetGrid(theColumn, theRow);
			List<Plant> plants = grid.plants;
			SortingGroup sortingGroup = this.sortingGroup;
			string text = string.Format("plant{0}", grid);
			sortingGroup.sortingLayerName = text;
		}
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0004F250 File Offset: 0x0004D450
	[Token(Token = "0x6000DA1")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "40")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0004F260 File Offset: 0x0004D460
	[Token(Token = "0x6000DA2")]
	[Address(RVA = "0x3F76D0", Offset = "0x3F5CD0", VA = "0x1803F76D0")]
	private void WheatUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.wheatTime = deltaTime;
		if (deltaTime > 31f)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num = 0;
			if (this.wheatType != 1)
			{
				List<PlantType> ultimatePlants = global::Lawnf.GetUltimatePlants();
				Predicate<PlantType> <>9__140_ = Plant.<>c.<>9__140_0;
				if (<>9__140_ == 0)
				{
					Plant.<>c.<>9__140_0 = delegate(PlantType p)
					{
						bool flag2;
						bool flag3;
						bool flag4;
						bool flag5;
						bool flag6;
						return flag2 || flag3 || flag4 || flag5 || flag6;
					};
				}
				int num2 = ultimatePlants.RemoveAll(<>9__140_);
				bool flag;
				PlantType plantType = ultimatePlants[flag ? 1 : 0];
				CreatePlant instance = CreatePlant.Instance;
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
					goto IL_00C4;
				}
				Transform axis2 = this.axis;
			}
			Board board = this.board;
			int num4 = this.thePlantRow;
			int num5 = this.thePlantColumn;
			ulong num6;
			Plant plant2 = board.SetEvePlants(num5, num4, num6 != 0UL);
			IL_00C4:
			int num7 = 0;
			if (plant2 != num7)
			{
				int num8 = this.wheatType;
				plant2.wheatType = num8;
				if ((GameAPP.config.wheatColor ? 1 : 0) != num)
				{
					plant2.SetWheat();
				}
			}
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0004F370 File Offset: 0x0004D570
	[Token(Token = "0x6000DA3")]
	[Address(RVA = "0x3F4CC0", Offset = "0x3F32C0", VA = "0x1803F4CC0")]
	public void SetWheat()
	{
		ulong num;
		do
		{
			List<SpriteRenderer> spriteRenderers = this.spriteRenderers;
			bool flag;
			if (flag)
			{
				Material material = GameMaterial.GetMaterial((MaterialType)((uint)3));
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0004F3A4 File Offset: 0x0004D5A4
	[Token(Token = "0x6000DA4")]
	[Address(RVA = "0x3F4120", Offset = "0x3F2720", VA = "0x1803F4120", Slot = "41")]
	protected virtual Zombie SearchBoss()
	{
		ulong num3;
		do
		{
			int num = 0;
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num2 = 0;
				if (!(num != num2))
				{
					continue;
				}
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0004F3EC File Offset: 0x0004D5EC
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "42")]
	protected virtual void AnimSuperShoot()
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0004F3FC File Offset: 0x0004D5FC
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x3F5070", Offset = "0x3F3670", VA = "0x1803F5070", Slot = "43")]
	public virtual bool SuperSkill()
	{
		float num = this.flashCountDown;
		int num2 = 0;
		if (num <= (float)num2)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num3 = 0;
			ulong num4;
			this.Recover(z, (DamageType)num3, true, num4 != 0UL);
			GameAPP.PlaySound(66, 0.5f, 1f);
			this.anim.SetTrigger("super");
			this.flashCountDown = 2f;
			return true;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0004F470 File Offset: 0x0004D670
	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x3F4880", Offset = "0x3F2E80", VA = "0x1803F4880", Slot = "44")]
	protected virtual GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num5;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					int num3 = this.thePlantRow;
					float num4 = this.vision;
					Transform axis = this.axis;
					if (this.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num5 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0004F4EC File Offset: 0x0004D6EC
	[Token(Token = "0x6000DA8")]
	[Address(RVA = "0x3F2510", Offset = "0x3F0B10", VA = "0x1803F2510", Slot = "45")]
	protected virtual void PlantShootUpdate()
	{
		this.UpdateAttackCountDown();
		if (0 > (int)this.thePlantAttackCountDown)
		{
			float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
			this.thePlantAttackCountDown = num;
			if (this.Shootable())
			{
				this.anim.SetTrigger("shoot");
				return;
			}
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x0004F540 File Offset: 0x0004D740
	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x3F63F0", Offset = "0x3F49F0", VA = "0x1803F63F0", Slot = "46")]
	protected virtual void UpdateAttackCountDown()
	{
		float num = this.thePlantAttackCountDown;
		float deltaTime = Time.deltaTime;
		this.thePlantAttackCountDown = num;
		float deltaTime2 = Time.deltaTime;
		this.thePlantAttackCountDown = num;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0004F574 File Offset: 0x0004D774
	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x3F4E10", Offset = "0x3F3410", VA = "0x1803F4E10", Slot = "47")]
	protected virtual bool Shootable()
	{
		GameObject gameObject = this.SearchZombie();
		int num = 0;
		if (!(gameObject != num))
		{
			Zombie zombie = this.SearchBoss();
			int num2 = 0;
			if (!(zombie != num2))
			{
				return this.SearchGoldMagnet();
			}
		}
		return true;
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0004F5B0 File Offset: 0x0004D7B0
	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x3F42C0", Offset = "0x3F28C0", VA = "0x1803F42C0")]
	protected bool SearchGoldMagnet()
	{
		int num2;
		for (;;)
		{
			int num = 0;
			num2 = 0;
			Board board = this.board;
			if (num2 >= board.columnNum)
			{
				goto IL_00BB;
			}
			int rowNum = board.rowNum;
			if (this.thePlantRow < rowNum)
			{
				GridSystem gridSystem = board.gridSystem;
				int num3 = this.thePlantRow;
				num3++;
				List<Plant> plants = gridSystem.GetGrid(num2, num3).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
				}
				if (num2 != 0)
				{
					goto IL_00C7;
				}
			}
			if (this.thePlantRow <= 0)
			{
				goto IL_00B7;
			}
			GridSystem gridSystem2 = this.board.gridSystem;
			int num5 = this.thePlantRow;
			List<Plant> plants2 = gridSystem2.GetGrid(num2, num5).plants;
			bool flag2;
			if (flag2)
			{
				int num6 = 0;
				if (num != num6)
				{
					break;
				}
			}
			else if (num2 == 0)
			{
				goto IL_00B7;
			}
		}
		return true;
		IL_00B7:
		num2++;
		IL_00BB:
		throw new NullReferenceException();
		IL_00C7:
		throw new NullReferenceException();
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0004F68C File Offset: 0x0004D88C
	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x3F4610", Offset = "0x3F2C10", VA = "0x1803F4610", Slot = "48")]
	protected virtual bool SearchUniqueZombie(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (!flag && zombie.isMindControlled == flag)
		{
			ZombieStatus zombieStatus = zombie.theStatus;
			if (zombieStatus > ZombieStatus.Pol_jump)
			{
				if (zombieStatus != ZombieStatus.Dolphinrider_jump)
				{
					if (flag <= true)
					{
					}
					if (zombieStatus != ZombieStatus.Bungi_awake)
					{
						goto IL_003F;
					}
				}
			}
		}
		IL_0032:
		while (18446744073709551615UL == (ulong)4294967293L)
		{
		}
		goto IL_003F;
		goto IL_0032;
		IL_003F:
		PlantType plantType = this.thePlantType;
		if (plantType <= PlantType.PeaNut)
		{
			goto IL_00B8;
		}
		int num3;
		if (plantType > PlantType.JalaSquash)
		{
			if (plantType == PlantType.FireSquash)
			{
				goto IL_00E4;
			}
			if (plantType == PlantType.SeaCactus)
			{
				goto IL_00F2;
			}
			int num2 = (int)this.thePlantType;
			bool flag2;
			if (flag2)
			{
				goto IL_00F7;
			}
			bool flag3;
			if (this.thePlantType == PlantType.CherryMagnet)
			{
				num3 = 0;
				flag3 = this == num3;
				while (flag3)
				{
				}
			}
			while (flag3)
			{
			}
			while (flag3)
			{
			}
		}
		ulong num4;
		if (num4 != (ulong)4294967291L)
		{
			goto IL_00B8;
		}
		IL_00E4:
		while (num3 == 10)
		{
		}
		IL_00EA:
		ulong num5;
		while (num5 != (ulong)21L)
		{
		}
		IL_00F2:
		while (num3 == 7)
		{
		}
		goto IL_00F7;
		IL_00B8:
		if (num4 > (ulong)21L)
		{
			if (num4 == (ulong)248L)
			{
				goto IL_00E4;
			}
			while (num4 != (ulong)1004L)
			{
			}
			while (num3 == 10)
			{
			}
		}
		ulong num6;
		if (num6 == (ulong)13L)
		{
			goto IL_00E4;
		}
		goto IL_00EA;
		IL_00F7:
		throw new NullReferenceException();
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x0004F798 File Offset: 0x0004D998
	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x3ED960", Offset = "0x3EBF60", VA = "0x1803ED960")]
	protected bool AttackLandZombie(Zombie zombie)
	{
		int num = 0;
		bool flag = zombie == num;
		if (!flag && zombie.isMindControlled == flag)
		{
			ZombieStatus zombieStatus = zombie.theStatus;
			if (zombieStatus != ZombieStatus.Pol_jump)
			{
				if (flag <= true)
				{
				}
				if (zombieStatus != ZombieStatus.Bungi_awake)
				{
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0004F7DC File Offset: 0x0004D9DC
	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x3EE090", Offset = "0x3EC690", VA = "0x1803EE090", Slot = "49")]
	public virtual void Connected(Plant plant)
	{
		this.isConnected = true;
		this.connectPlant = plant;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x0004F800 File Offset: 0x0004DA00
	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x3EF590", Offset = "0x3EDB90", VA = "0x1803EF590", Slot = "50")]
	public virtual void DisConnected()
	{
		this.isConnected = false;
		this.connectPlant = (ulong)0L;
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x0004F820 File Offset: 0x0004DA20
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x3F6450", Offset = "0x3F4A50", VA = "0x1803F6450", Slot = "51")]
	public virtual void UpdateMagnetCount(int count)
	{
		this.magnetCount = count;
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0004F834 File Offset: 0x0004DA34
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x3F3C00", Offset = "0x3F2200", VA = "0x1803F3C00")]
	protected void RemoveFromList()
	{
		GridSystem gridSystem = this.board.gridSystem;
		int num = this.thePlantRow;
		int num2 = this.thePlantColumn;
		bool flag = gridSystem.GetGrid(num2, num).plants.Remove(this);
		Board board = this.board;
		int num3 = 0;
		List<Plant> plantArray = board.boardEntity.plantArray;
		bool flag2 = this.board.boardEntity.plantArray[num3] == this;
		Board board2 = this.board;
		if (!flag2)
		{
			num3++;
		}
		List<Plant> plantArray2 = board2.boardEntity.plantArray;
		int num4 = 0;
		plantArray2[num3] = num4;
		Board board3 = this.board;
		Board board4 = this.board;
		int num5 = this.thePlantRow;
		int num6 = this.thePlantColumn;
		board4.UpdateBox(num6, num5);
		Plant plant = this.pre;
		int num7 = 0;
		if (plant == num7)
		{
			Plant plant2 = this.next;
			int num8 = 0;
			if (plant2 == num8)
			{
				bool flag3 = this.board.boardEntity.plantHead.Remove(this);
			}
		}
		Plant plant3 = this.pre;
		int num9 = 0;
		if (plant3 != num9)
		{
			Plant plant4 = this.next;
			int num10 = 0;
			if (plant4 == num10)
			{
				this.pre.next = (ulong)0L;
			}
		}
		Plant plant5 = this.pre;
		int num11 = 0;
		if (plant5 == num11)
		{
			Plant plant6 = this.next;
			int num12 = 0;
			if (plant6 != num12)
			{
				bool flag4 = this.board.boardEntity.plantHead.Remove(this);
				this.next.pre = (ulong)0L;
				List<Plant> plantHead = this.board.boardEntity.plantHead;
			}
		}
		Plant plant7 = this.pre;
		int num13 = 0;
		if (plant7 != num13)
		{
			Plant plant8 = this.next;
			int num14 = 0;
			if (plant8 != num14)
			{
				Plant plant9 = this.pre;
				Plant plant10 = this.next;
				plant9.next = plant10;
				Plant plant11 = this.next;
				Plant plant12 = this.pre;
				plant11.pre = plant12;
			}
		}
		Dictionary<PlantType, List<Plant>> plantHeads = this.board.boardEntity.plantHeads;
		bool flag5;
		if (flag5)
		{
		}
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x0004FA6C File Offset: 0x0004DC6C
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "52")]
	protected virtual void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x0004FA7C File Offset: 0x0004DC7C
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "53")]
	protected virtual void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0004FA8C File Offset: 0x0004DC8C
	[Token(Token = "0x6000DB4")]
	[Address(RVA = "0x3F00B0", Offset = "0x3EE6B0", VA = "0x1803F00B0")]
	private void GiveSunInIZ()
	{
		PlantType plantType = this.thePlantType;
		if (plantType > PlantType.PotatoMine)
		{
			if (plantType != PlantType.Pot)
			{
				if (plantType != PlantType.TwinFlower)
				{
					goto IL_0043;
				}
				int num = 0;
				CreateItem instance = CreateItem.Instance;
				num++;
			}
			return;
		}
		if (plantType == PlantType.SunFlower)
		{
			int num2 = 0;
			CreateItem instance2 = CreateItem.Instance;
			num2++;
			return;
		}
		while (plantType == PlantType.PotatoMine)
		{
		}
		IL_0043:
		Board board = this.board;
		int i = 0;
		BoardConfig config = board.config;
		while (i >= config.izDropCount)
		{
		}
		CreateItem instance3 = CreateItem.Instance;
		Board board2 = this.board;
		i++;
		while (board2 != 0)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x0004FB20 File Offset: 0x0004DD20
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "54")]
	public virtual void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x0004FB30 File Offset: 0x0004DD30
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "55")]
	public virtual void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x0004FB40 File Offset: 0x0004DD40
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x3F1EA0", Offset = "0x3F04A0", VA = "0x1803F1EA0")]
	public void ModifyTempDamage(PlantDamageAdder index, float value, float during)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x0004FB64 File Offset: 0x0004DD64
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x3F16C0", Offset = "0x3EFCC0", VA = "0x1803F16C0")]
	public void ModifyDamage(PlantDamageAdder index, float value, bool add = false, [Optional] float? max)
	{
		int num4;
		do
		{
			Board board = this.board;
			int num = (int)this.thePlantType;
			PlantDataManager.PlantData plantData;
			if (plantData == 0)
			{
				return;
			}
			if (index == PlantDamageAdder.PointEffect)
			{
			}
			Dictionary<PlantDamageAdder, float> dictionary = this.damageAdder;
			Dictionary<PlantDamageAdder, float> dictionary2 = this.damageAdder;
			bool flag;
			if (!flag || !add)
			{
			}
			Dictionary<PlantDamageAdder, float> dictionary3 = this.damageAdder;
			float num2;
			float num3;
			if (num2 > num3)
			{
				Dictionary<PlantDamageAdder, float> dictionary4 = this.damageAdder;
			}
			num4 = 0;
			Dictionary<PlantDamageAdder, float> dictionary5 = this.damageAdder;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num4 != 0);
		num4 += num4;
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x0004FBE0 File Offset: 0x0004DDE0
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x3ED520", Offset = "0x3EBB20", VA = "0x1803ED520")]
	public void AddSpeed(float value)
	{
		this.thePlantSpeed = value;
		this.attributeSpeed = value;
		this.attackSpeedAdder = value;
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x0004FC04 File Offset: 0x0004DE04
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x3F1DE0", Offset = "0x3F03E0", VA = "0x1803F1DE0")]
	public void ModifySpeed(PlantSpeedAdder index, float value)
	{
		Dictionary<PlantSpeedAdder, float> dictionary = this.speedAdder;
		Dictionary<PlantSpeedAdder, float> dictionary2 = this.speedAdder;
		this.attackSpeedAdder = value;
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x0004FC30 File Offset: 0x0004DE30
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x3ED370", Offset = "0x3EB970", VA = "0x1803ED370")]
	public void AddSpeed(PlantSpeedAdder index, float value, [Optional] float? max)
	{
		Dictionary<PlantSpeedAdder, float> dictionary = this.speedAdder;
		Dictionary<PlantSpeedAdder, float> dictionary2 = this.speedAdder;
		this.attackSpeedAdder = value;
		Dictionary<PlantSpeedAdder, float> dictionary3 = this.speedAdder;
		float num;
		if (value > num)
		{
			Dictionary<PlantSpeedAdder, float> dictionary4 = this.speedAdder;
			Dictionary<PlantSpeedAdder, float> dictionary5 = this.speedAdder;
			float num2 = this.attackSpeedAdder;
			this.attackSpeedAdder = num2;
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x0004FC88 File Offset: 0x0004DE88
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x3F1AB0", Offset = "0x3F00B0", VA = "0x1803F1AB0", Slot = "56")]
	public virtual void ModifyHealth(PlantHealthAdder index, float value, bool add = false)
	{
		int num2;
		do
		{
			int num = (int)this.thePlantType;
			Dictionary<PlantHealthAdder, float> dictionary = this.healthAdder;
			Dictionary<PlantHealthAdder, float> dictionary2 = this.healthAdder;
			bool flag;
			if (!flag || !add)
			{
			}
			num2 = 0;
			Dictionary<PlantHealthAdder, float> dictionary3 = this.healthAdder;
			bool flag2;
			if (flag2)
			{
			}
		}
		while (num2 != 0);
		num2 += num2;
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x0004FCDC File Offset: 0x0004DEDC
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x3ED560", Offset = "0x3EBB60", VA = "0x1803ED560")]
	public void AdjustDamage()
	{
		ulong num;
		do
		{
			Dictionary<PlantDamageAdder, float> dictionary = this.damageAdder;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x0004FD04 File Offset: 0x0004DF04
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x3F6460", Offset = "0x3F4A60", VA = "0x1803F6460")]
	private void UpdateStarIcon()
	{
		GameObject gameObject = this.cheatIcon;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.cheatIcon);
		}
		GameObject gameObject2 = Resources.Load<GameObject>("Items/LevelUp/CheatIcon");
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject3;
		this.cheatIcon = gameObject3;
		Transform transform = this.cheatIcon.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		if (this.plantTag != (ulong)0L)
		{
			Transform transform2 = this.cheatIcon.transform;
			Vector3 vector3;
			float z3 = vector3.z;
			Transform transform3 = this.cheatIcon.transform;
			Vector3 vector4;
			float z4 = vector4.z;
		}
		Transform transform4 = this.cheatIcon.transform;
		Transform transform5 = base.transform;
		transform4.parentInternal = transform5;
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x0004FDCC File Offset: 0x0004DFCC
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x3F69B0", Offset = "0x3F4FB0", VA = "0x1803F69B0")]
	public bool Upgrade(int targetLevel, bool free = false, bool abyss = false)
	{
		if (this.theLevel < 3)
		{
			if (!free)
			{
				int plantUpgradeCost = global::Lawnf.GetPlantUpgradeCost(this.thePlantType, targetLevel);
				if (abyss)
				{
					int num = (int)this.thePlantType;
					PlantDataManager.PlantData plantData;
					int num2 = plantData.cost;
					num2 += 50;
				}
				this.board.UseSun((float)targetLevel);
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
				Transform axis = this.axis;
			}
			this.theLevel = targetLevel;
			int num4 = (int)this.thePlantType;
			Board board = this.board;
			int num5 = this.theLevel;
			InGameText instance;
			if (num5 != 0)
			{
				if (num5 != 0)
				{
					if (num5 != 1)
					{
						goto IL_0108;
					}
					GameObject[] itemPrefab = GameAPP.itemPrefab;
					instance = InGameText.Instance;
					int num6;
					string text = string.Format("升级植物需要消耗{0}阳光", num6);
					int num7 = 0;
					instance.ShowText(text, 3f, num7 != 0);
				}
				GameObject[] itemPrefab2 = GameAPP.itemPrefab;
			}
			GameObject[] itemPrefab3 = GameAPP.itemPrefab;
			if (typeof(GameAPP).TypeHandle != 0)
			{
				if (typeof(GameAPP).TypeHandle != 0)
				{
					if (typeof(GameAPP).TypeHandle != (ulong)1L)
					{
						goto IL_0108;
					}
					GameObject[] itemPrefab4 = GameAPP.itemPrefab;
				}
				GameObject[] itemPrefab5 = GameAPP.itemPrefab;
			}
			GameObject gameObject = GameAPP.itemPrefab[43];
			IL_0108:
			int num8 = 0;
			if (gameObject != num8)
			{
				bool flag;
				int num9;
				if (flag)
				{
					num9 = 0;
				}
				int num10 = 0;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num9, num10);
				Vector3 localScale = gameObject.transform.localScale;
				Transform transform;
				Vector3 position = transform.position;
				Transform transform2 = instance.transform;
				Transform transform3;
				transform3.parentInternal = transform2;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x0004FF38 File Offset: 0x0004E138
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x3F4EE0", Offset = "0x3F34E0", VA = "0x1803F4EE0")]
	[ProButton]
	public void StarUp()
	{
		if (!this.starUp && this.OnStarUp())
		{
			this.starUp = true;
			this.UpdateStarIcon();
			return;
		}
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0004FF68 File Offset: 0x0004E168
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "57")]
	protected virtual bool OnStarUp()
	{
		return false;
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x0004FF78 File Offset: 0x0004E178
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "58")]
	protected virtual void UpgradeEvent(int theCurrentLevel)
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x0004FF88 File Offset: 0x0004E188
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "59")]
	public virtual void InfluenceByIceShroom()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x0004FF98 File Offset: 0x0004E198
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "60")]
	public virtual void InfluenceByJalapeno()
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x0004FFA8 File Offset: 0x0004E1A8
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x3F7280", Offset = "0x3F5880", VA = "0x1803F7280", Slot = "61")]
	public virtual bool UseItem(BucketType type, Bucket bucket)
	{
		int num;
		int num6;
		int num7;
		Plant plant;
		do
		{
			Board board = this.board;
			num = 0;
			PlantType plantType = this.thePlantType;
			bool flag = Bucket.Recipes.TryGetValue(num, num);
			if (!flag)
			{
				PlantType plantType2 = this.thePlantType;
				GameObject gameObject;
				int j;
				if (plantType2 > PlantType.PickaxePumpkin)
				{
					int i;
					if (plantType2 > PlantType.PortalPea)
					{
						if (plantType2 > PlantType.PortalNut)
						{
							if (plantType2 != PlantType.IronSquash && plantType2 != PlantType.HelmetGatling && flag > true)
							{
								goto IL_00AA;
							}
							int num2 = 0;
							ulong num3;
							this.Recover(500f, (DamageType)num2, num3 != 0UL, num != 0);
							int num4 = 0;
							if (bucket != num4)
							{
								gameObject = bucket.gameObject;
								global::UnityEngine.Object.Destroy(gameObject);
							}
						}
						ulong num5;
						while (num5 <= (ulong)1L)
						{
						}
						while (gameObject == (ulong)1215L)
						{
						}
						IL_00AA:
						i = 0;
					}
					if (gameObject > (ulong)1152L)
					{
						while (i <= 1)
						{
						}
						while (gameObject == (ulong)1169L)
						{
						}
						while (gameObject == (ulong)1208L)
						{
						}
					}
					while (gameObject == (ulong)1129L)
					{
					}
					while (gameObject == (ulong)1152L)
					{
					}
					j = 0;
				}
				if (gameObject > (ulong)976L)
				{
					if (gameObject <= (ulong)991L)
					{
						continue;
					}
					while (gameObject == (ulong)1020L)
					{
					}
					while (j <= 1)
					{
					}
					while (j <= 5)
					{
					}
					if (0 <= 1)
					{
						continue;
					}
					while (gameObject == (ulong)991L)
					{
					}
				}
				int k;
				if (gameObject > (ulong)945L)
				{
					while (gameObject > (ulong)19L)
					{
					}
					k = 0;
				}
				while (gameObject == (ulong)935L)
				{
				}
				while (k > 5)
				{
				}
			}
			CreatePlant instance = CreatePlant.Instance;
			num6 = 0;
			num7 = 0;
		}
		while (!(plant == num7));
		int num8 = 0;
		DroppedCard droppedCard = global::Lawnf.SetDroppedCard(num6, (PlantType)num, num8);
		throw new NullReferenceException();
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x0005013C File Offset: 0x0004E33C
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "62")]
	public virtual bool OnClicked(Mouse mouse)
	{
		return false;
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x0005014C File Offset: 0x0004E34C
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x3EE600", Offset = "0x3ECC00", VA = "0x1803EE600")]
	protected void CreateCannonTarget(Mouse mouse)
	{
		mouse.cannonPlant = this;
		GameObject gameObject = GameAPP.itemPrefab[16];
		Vector2 mousePosition = mouse.MousePosition;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = this.board.transform;
		GameObject gameObject2;
		mouse.theItemOnMouse = gameObject2;
		mouse.theItemOnMouse.name = "cannon";
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x000501A8 File Offset: 0x0004E3A8
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "63")]
	public virtual void SetTargetByMouse(Mouse mouse)
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x000501B8 File Offset: 0x0004E3B8
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "64")]
	public virtual bool OnEat(Zombie zombie)
	{
		return false;
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000DCA RID: 3530 RVA: 0x000501C8 File Offset: 0x0004E3C8
	[Token(Token = "0x170000B3")]
	public virtual PlantType PreviewType
	{
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x3F8220", Offset = "0x3F6820", VA = "0x1803F8220", Slot = "65")]
		get
		{
			return this.thePlantType;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000501DC File Offset: 0x0004E3DC
	// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000501F0 File Offset: 0x0004E3F0
	[Token(Token = "0x170000B4")]
	public float AttributeCountdown
	{
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x3F7E00", Offset = "0x3F6400", VA = "0x1803F7E00")]
		get
		{
			return this.attributeCountdown;
		}
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x3F9290", Offset = "0x3F7890", VA = "0x1803F9290")]
		set
		{
			HealthSlider healthSlider = this.healthSlider;
			this.attributeCountdown = value;
			int num = 0;
			if (healthSlider != num)
			{
				HealthSlider healthSlider2 = this.healthSlider;
				float progressMaxValue = healthSlider2.progressMaxValue;
				healthSlider2.progressMaxValue = progressMaxValue;
				HealthSlider healthSlider3 = this.healthSlider;
				int num2 = 0;
				if (healthSlider3 != 0)
				{
					throw new NullReferenceException();
				}
				healthSlider3.progressFill.fillAmount = (float)num2;
			}
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00050254 File Offset: 0x0004E454
	[Token(Token = "0x170000B5")]
	public bool Active
	{
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x3F7D70", Offset = "0x3F6370", VA = "0x1803F7D70")]
		get
		{
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim == 0)
			{
			}
			return "{il2cpp field on {'constant9' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xA8}" == (ulong)0L;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00050288 File Offset: 0x0004E488
	[Token(Token = "0x170000B6")]
	public BoxType BoxType
	{
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x3F7E80", Offset = "0x3F6480", VA = "0x1803F7E80")]
		get
		{
			GridSystem gridSystem = this.board.gridSystem;
			int num = this.thePlantRow;
			int num2 = this.thePlantColumn;
			return gridSystem.GetBoxType(num2, num);
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000502C0 File Offset: 0x0004E4C0
	[Token(Token = "0x170000B7")]
	public float[] Timers
	{
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x3F8FA0", Offset = "0x3F75A0", VA = "0x1803F8FA0")]
		get
		{
			if (this._timers == (ulong)0L)
			{
				if (Enum.GetValues(typeof(PlantTimer)) == 0)
				{
					throw new InvalidCastException();
				}
				float[] array = new float[0];
				this._timers = array;
			}
			return this._timers;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0005030C File Offset: 0x0004E50C
	[Token(Token = "0x170000B8")]
	public virtual int LimDamage
	{
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x3F8060", Offset = "0x3F6660", VA = "0x1803F8060", Slot = "66")]
		get
		{
			return int.MaxValue;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00050320 File Offset: 0x0004E520
	[Token(Token = "0x170000B9")]
	public Plant SameUpper
	{
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x3F8DD0", Offset = "0x3F73D0", VA = "0x1803F8DD0")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				if (this.thePlantRow <= num)
				{
					break;
				}
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					PlantType plantType = this.thePlantType;
				}
			}
			while (num5 != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00050394 File Offset: 0x0004E594
	[Token(Token = "0x170000BA")]
	public Plant SameLower
	{
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x3F8A10", Offset = "0x3F7010", VA = "0x1803F8A10")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				int rowNum = this.board.rowNum;
				if (this.thePlantRow >= rowNum)
				{
					break;
				}
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				num2++;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					PlantType plantType = this.thePlantType;
				}
			}
			while (num5 != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00050420 File Offset: 0x0004E620
	[Token(Token = "0x170000BB")]
	public Plant SameLeft
	{
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x3F8840", Offset = "0x3F6E40", VA = "0x1803F8840")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				if (this.thePlantColumn <= num)
				{
					break;
				}
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantColumn;
				int num3 = this.thePlantRow;
				List<Plant> plants = gridSystem.GetGrid(num2, num3).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					PlantType plantType = this.thePlantType;
				}
			}
			while (num5 != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00050494 File Offset: 0x0004E694
	[Token(Token = "0x170000BC")]
	public Plant SameRight
	{
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x3F8BF0", Offset = "0x3F71F0", VA = "0x1803F8BF0")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				int columnNum = this.board.columnNum;
				if (this.thePlantColumn >= columnNum)
				{
					break;
				}
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantColumn;
				num2++;
				int num3 = this.thePlantRow;
				List<Plant> plants = gridSystem.GetGrid(num2, num3).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					PlantType plantType = this.thePlantType;
				}
			}
			while (num5 != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00050520 File Offset: 0x0004E720
	[Token(Token = "0x170000BD")]
	public bool WithGoldPot
	{
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x3F90D0", Offset = "0x3F76D0", VA = "0x1803F90D0")]
		get
		{
			for (;;)
			{
				int num = 0;
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				ulong num5;
				if (flag)
				{
					int num4 = 0;
					if (num != num4)
					{
						break;
					}
				}
				else if (num5 == (ulong)0L)
				{
					goto Block_2;
				}
			}
			return true;
			Block_2:
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00050588 File Offset: 0x0004E788
	[Token(Token = "0x170000BE")]
	public PlantType PotType
	{
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x3F8070", Offset = "0x3F6670", VA = "0x1803F8070")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
				}
			}
			while (num5 != (ulong)0L);
			return PlantType.Nothing;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x000505F8 File Offset: 0x0004E7F8
	[Token(Token = "0x170000BF")]
	public Plant Pumpkin
	{
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x3F8540", Offset = "0x3F6B40", VA = "0x1803F8540")]
		get
		{
			ulong num7;
			do
			{
				int num = 0;
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_007B;
				}
				BoardGrid boardGrid;
				List<Plant> plants2 = boardGrid.plants;
				bool flag2;
				if (flag2)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
				}
			}
			while (num7 != (ulong)0L);
			throw new NullReferenceException();
			IL_007B:
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00050688 File Offset: 0x0004E888
	[Token(Token = "0x170000C0")]
	public bool BlockedByPumpkin
	{
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x3F7E10", Offset = "0x3F6410", VA = "0x1803F7E10")]
		get
		{
			Plant pumpkin = this.Pumpkin;
			int num = 0;
			return pumpkin != num;
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x000506AC File Offset: 0x0004E8AC
	[Token(Token = "0x170000C1")]
	public PlantType PumpkinType
	{
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x3F8230", Offset = "0x3F6830", VA = "0x1803F8230")]
		get
		{
			ulong num7;
			do
			{
				int num = 0;
				GridSystem gridSystem = this.board.gridSystem;
				int num2 = this.thePlantRow;
				int num3 = this.thePlantColumn;
				List<Plant> plants = gridSystem.GetGrid(num3, num2).plants;
				bool flag;
				if (flag)
				{
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_007A;
				}
				BoardGrid boardGrid;
				List<Plant> plants2 = boardGrid.plants;
				bool flag2;
				if (flag2)
				{
					int num6 = 0;
					if (!(num != num6))
					{
						continue;
					}
				}
			}
			while (num7 != (ulong)0L);
			return PlantType.Nothing;
			IL_007A:
			throw new NullReferenceException();
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00050744 File Offset: 0x0004E944
	[Token(Token = "0x170000C2")]
	public GridItem Ladder
	{
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x3F7EC0", Offset = "0x3F64C0", VA = "0x1803F7EC0")]
		get
		{
			ulong num5;
			do
			{
				int num = 0;
				List<GridItem> griditemArray = this.board.griditemArray;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					int num3 = this.thePlantColumn;
					int num4 = this.thePlantRow;
				}
			}
			while (num5 != (ulong)0L);
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x0005079C File Offset: 0x0004E99C
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "67")]
	public virtual void BeforeSerialized(SavePlantData data)
	{
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000507AC File Offset: 0x0004E9AC
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "68")]
	public virtual void AfterDeserialized(SavePlantData data)
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x000507BC File Offset: 0x0004E9BC
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x3F7B10", Offset = "0x3F6110", VA = "0x1803F7B10")]
	public Plant()
	{
		List<Zombie> list = new List();
		this.zombieList = list;
		this.thePlantMaxHealth = (int)((ulong)300L);
		this.thePlantHealth = (int)((ulong)300L);
		this.attackDamage = (int)((ulong)20L);
		this.butterP = (int)((ulong)4L);
		this.defence = 1f;
		this.moveSpeed = 8f;
		this.thePlantSpeed = 1f;
		this.brightness = 1f;
		this.attributeSpeed = 1f;
		this.theLilyType = (PlantType)((ulong)(-1L));
		this.secondParent = (PlantType)((ulong)4294967295L);
		HashSet<EveBuff> hashSet = new HashSet();
		this.eveBuffs = hashSet;
		Vector2Int s_One = Vector2Int.s_One;
		this.size = s_One;
		this.freeMoving = true;
		Dictionary<PlantDamageAdder, float> dictionary = new Dictionary();
		this.damageAdder = dictionary;
		Dictionary<PlantHealthAdder, float> dictionary2 = new Dictionary();
		this.healthAdder = dictionary2;
		Dictionary<PlantSpeedAdder, float> dictionary3 = new Dictionary();
		this.speedAdder = dictionary3;
		base..ctor();
	}

	// Token: 0x04000A33 RID: 2611
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A33")]
	[Header("引用")]
	public List<JigsawType> jigsawType;

	// Token: 0x04000A34 RID: 2612
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A34")]
	protected List<Zombie> zombieList;

	// Token: 0x04000A35 RID: 2613
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A35")]
	public SortingGroup sortingGroup;

	// Token: 0x04000A36 RID: 2614
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A36")]
	public HealthSlider healthSlider;

	// Token: 0x04000A37 RID: 2615
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A37")]
	public GameObject levelIcon;

	// Token: 0x04000A38 RID: 2616
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A38")]
	public GameObject cheatIcon;

	// Token: 0x04000A39 RID: 2617
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A39")]
	public Plant targetPlant;

	// Token: 0x04000A3A RID: 2618
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A3A")]
	public Zombie targetZombie;

	// Token: 0x04000A3B RID: 2619
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A3B")]
	public Transform shoot;

	// Token: 0x04000A3C RID: 2620
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A3C")]
	public Transform shoot2;

	// Token: 0x04000A3D RID: 2621
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A3D")]
	public Plant next;

	// Token: 0x04000A3E RID: 2622
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A3E")]
	public Plant pre;

	// Token: 0x04000A3F RID: 2623
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A3F")]
	public Plant snakeNext;

	// Token: 0x04000A40 RID: 2624
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A40")]
	public Plant snakePre;

	// Token: 0x04000A41 RID: 2625
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A41")]
	public Rigidbody2D rb;

	// Token: 0x04000A42 RID: 2626
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A42")]
	public Plant connectPlant;

	// Token: 0x04000A43 RID: 2627
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A43")]
	public Plant jalapuff;

	// Token: 0x04000A44 RID: 2628
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A44")]
	[Header("基本信息1")]
	public int skinType;

	// Token: 0x04000A45 RID: 2629
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000A45")]
	public int thePlantMaxHealth;

	// Token: 0x04000A46 RID: 2630
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A46")]
	public int thePlantHealth;

	// Token: 0x04000A47 RID: 2631
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000A47")]
	public int theShieldHealth;

	// Token: 0x04000A48 RID: 2632
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000A48")]
	public int attackDamage;

	// Token: 0x04000A49 RID: 2633
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000A49")]
	public int thePlantColumn;

	// Token: 0x04000A4A RID: 2634
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000A4A")]
	public int thePlantRow;

	// Token: 0x04000A4B RID: 2635
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000A4B")]
	public int magnetCount;

	// Token: 0x04000A4C RID: 2636
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000A4C")]
	public int theLevel;

	// Token: 0x04000A4D RID: 2637
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000A4D")]
	public int wheatType;

	// Token: 0x04000A4E RID: 2638
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000A4E")]
	public int disableCount;

	// Token: 0x04000A4F RID: 2639
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000A4F")]
	public int attributeCount;

	// Token: 0x04000A50 RID: 2640
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000A50")]
	public int shootingLevel;

	// Token: 0x04000A51 RID: 2641
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000A51")]
	public int killCount;

	// Token: 0x04000A52 RID: 2642
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A52")]
	public int puffPlace;

	// Token: 0x04000A53 RID: 2643
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000A53")]
	public int baseLayer;

	// Token: 0x04000A54 RID: 2644
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000A54")]
	public int currentLightLevel;

	// Token: 0x04000A55 RID: 2645
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000A55")]
	public int butterP;

	// Token: 0x04000A56 RID: 2646
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000A56")]
	public int thePlantStage;

	// Token: 0x04000A57 RID: 2647
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000A57")]
	[Header("基本信息2")]
	public float defence;

	// Token: 0x04000A58 RID: 2648
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000A58")]
	public float moveSpeed;

	// Token: 0x04000A59 RID: 2649
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000A59")]
	public float thePlantAttackInterval;

	// Token: 0x04000A5A RID: 2650
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000A5A")]
	public float thePlantProduceInterval;

	// Token: 0x04000A5B RID: 2651
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000A5B")]
	public float thePlantSpeed;

	// Token: 0x04000A5C RID: 2652
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000A5C")]
	public float brightness;

	// Token: 0x04000A5D RID: 2653
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Token(Token = "0x4000A5D")]
	public float moveTime;

	// Token: 0x04000A5E RID: 2654
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000A5E")]
	public float attackSpeedAdder;

	// Token: 0x04000A5F RID: 2655
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000A5F")]
	public float attributeSpeed;

	// Token: 0x04000A60 RID: 2656
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000A60")]
	public float attributeFloat;

	// Token: 0x04000A61 RID: 2657
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000A61")]
	protected float theOriginSpeed;

	// Token: 0x04000A62 RID: 2658
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000A62")]
	protected float vision;

	// Token: 0x04000A63 RID: 2659
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000A63")]
	[Header("基本信息3")]
	public Vector3 startPos;

	// Token: 0x04000A64 RID: 2660
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000A64")]
	public Vector3 cannonTarget;

	// Token: 0x04000A65 RID: 2661
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Token(Token = "0x4000A65")]
	public Plant.PlantTag plantTag;

	// Token: 0x04000A66 RID: 2662
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Token(Token = "0x4000A66")]
	public PlantStatus theStatus;

	// Token: 0x04000A67 RID: 2663
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x4000A67")]
	public PlantType thePlantType;

	// Token: 0x04000A68 RID: 2664
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000A68")]
	public PlantType theLilyType;

	// Token: 0x04000A69 RID: 2665
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000A69")]
	public PlantType firstParent;

	// Token: 0x04000A6A RID: 2666
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000A6A")]
	public PlantType secondParent;

	// Token: 0x04000A6B RID: 2667
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000A6B")]
	public HashSet<EveBuff> eveBuffs;

	// Token: 0x04000A6C RID: 2668
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000A6C")]
	public Action defaultAction;

	// Token: 0x04000A6D RID: 2669
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000A6D")]
	public Vector2Int size;

	// Token: 0x04000A6E RID: 2670
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000A6E")]
	public Plant.DieReason dieReason;

	// Token: 0x04000A6F RID: 2671
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000A6F")]
	public LayerMask bulletLayer;

	// Token: 0x04000A70 RID: 2672
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000A70")]
	public LayerMask potLayer;

	// Token: 0x04000A71 RID: 2673
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4000A71")]
	public LayerMask airLayer;

	// Token: 0x04000A72 RID: 2674
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000A72")]
	[Header("倒计时")]
	public float thePlantAttackCountDown;

	// Token: 0x04000A73 RID: 2675
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4000A73")]
	public float thePlantProduceCountDown;

	// Token: 0x04000A74 RID: 2676
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000A74")]
	public float attributeCountdown;

	// Token: 0x04000A75 RID: 2677
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000A75")]
	public float lightCountDown;

	// Token: 0x04000A76 RID: 2678
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000A76")]
	public float flashCountDown;

	// Token: 0x04000A77 RID: 2679
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000A77")]
	public float wheatTime;

	// Token: 0x04000A78 RID: 2680
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000A78")]
	public float lastTakeDamgeTime;

	// Token: 0x04000A79 RID: 2681
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4000A79")]
	[Header("开关")]
	public bool isLily;

	// Token: 0x04000A7A RID: 2682
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E5")]
	[Token(Token = "0x4000A7A")]
	public bool imitatless;

	// Token: 0x04000A7B RID: 2683
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E6")]
	[Token(Token = "0x4000A7B")]
	public bool invincible;

	// Token: 0x04000A7C RID: 2684
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E7")]
	[Token(Token = "0x4000A7C")]
	public bool isShort;

	// Token: 0x04000A7D RID: 2685
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000A7D")]
	public bool dying;

	// Token: 0x04000A7E RID: 2686
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
	[Token(Token = "0x4000A7E")]
	public bool alwaysLightUp;

	// Token: 0x04000A7F RID: 2687
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
	[Token(Token = "0x4000A7F")]
	public bool isCrashed;

	// Token: 0x04000A80 RID: 2688
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
	[Token(Token = "0x4000A80")]
	public bool melonSputter;

	// Token: 0x04000A81 RID: 2689
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000A81")]
	public bool dieMeansLose;

	// Token: 0x04000A82 RID: 2690
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1ED")]
	[Token(Token = "0x4000A82")]
	public bool isConnected;

	// Token: 0x04000A83 RID: 2691
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EE")]
	[Token(Token = "0x4000A83")]
	public bool keepShooting;

	// Token: 0x04000A84 RID: 2692
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EF")]
	[Token(Token = "0x4000A84")]
	public bool waitingDestory;

	// Token: 0x04000A85 RID: 2693
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000A85")]
	public bool hid;

	// Token: 0x04000A86 RID: 2694
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F1")]
	[Token(Token = "0x4000A86")]
	public bool uncrashable;

	// Token: 0x04000A87 RID: 2695
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F2")]
	[Token(Token = "0x4000A87")]
	public bool isFlashing;

	// Token: 0x04000A88 RID: 2696
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F3")]
	[Token(Token = "0x4000A88")]
	public bool undead;

	// Token: 0x04000A89 RID: 2697
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000A89")]
	public bool garlic;

	// Token: 0x04000A8A RID: 2698
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F5")]
	[Token(Token = "0x4000A8A")]
	public bool freeMoving;

	// Token: 0x04000A8B RID: 2699
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F6")]
	[Token(Token = "0x4000A8B")]
	public bool starUp;

	// Token: 0x04000A8C RID: 2700
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000A8C")]
	public Dictionary<PlantDamageAdder, float> damageAdder;

	// Token: 0x04000A8D RID: 2701
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000A8D")]
	public readonly Dictionary<PlantHealthAdder, float> healthAdder;

	// Token: 0x04000A8E RID: 2702
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000A8E")]
	public readonly Dictionary<PlantSpeedAdder, float> speedAdder;

	// Token: 0x04000A8F RID: 2703
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000A8F")]
	private float[] _timers;

	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public struct PlantHealthChangeData
	{
		// Token: 0x04000A90 RID: 2704
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A90")]
		public Plant plant;

		// Token: 0x04000A91 RID: 2705
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A91")]
		public int value;

		// Token: 0x04000A92 RID: 2706
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000A92")]
		public bool real;
	}

	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	[Serializable]
	public struct PlantTag
	{
		// Token: 0x04000A93 RID: 2707
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A93")]
		public bool flyingPlant;

		// Token: 0x04000A94 RID: 2708
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000A94")]
		public bool hardLandPlant;

		// Token: 0x04000A95 RID: 2709
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000A95")]
		public bool waterPlant;

		// Token: 0x04000A96 RID: 2710
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000A96")]
		public bool pumpkinPlant;

		// Token: 0x04000A97 RID: 2711
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000A97")]
		public bool lanternPlant;

		// Token: 0x04000A98 RID: 2712
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000A98")]
		public bool smallLanternPlant;

		// Token: 0x04000A99 RID: 2713
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000A99")]
		public bool puffPlant;

		// Token: 0x04000A9A RID: 2714
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Token(Token = "0x4000A9A")]
		public bool nutPlant;

		// Token: 0x04000A9B RID: 2715
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000A9B")]
		public bool tallNutPlant;

		// Token: 0x04000A9C RID: 2716
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000A9C")]
		public bool potatoPlant;

		// Token: 0x04000A9D RID: 2717
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Token(Token = "0x4000A9D")]
		public bool caltropPlant;

		// Token: 0x04000A9E RID: 2718
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Token(Token = "0x4000A9E")]
		public bool tanglekelpPlant;

		// Token: 0x04000A9F RID: 2719
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000A9F")]
		public bool magnetPlant;

		// Token: 0x04000AA0 RID: 2720
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Token(Token = "0x4000AA0")]
		public bool potPlant;

		// Token: 0x04000AA1 RID: 2721
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Token(Token = "0x4000AA1")]
		public bool doubleBoxPlant;

		// Token: 0x04000AA2 RID: 2722
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xF")]
		[Token(Token = "0x4000AA2")]
		public bool spickRockPlant;

		// Token: 0x04000AA3 RID: 2723
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AA3")]
		public bool icePlant;

		// Token: 0x04000AA4 RID: 2724
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000AA4")]
		public bool firePlant;
	}

	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public enum DieReason
	{
		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		Default,
		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		ByWheat,
		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		ByMix,
		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		ByDisMix,
		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		ByLevelUp,
		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		BySteal,
		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		ByBejeweled,
		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		ByShovel,
		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		BySelf,
		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		ByFreeze,
		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		Hid,
		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		CrashInWater,
		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		Crash,
		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		Wheel
	}
}
