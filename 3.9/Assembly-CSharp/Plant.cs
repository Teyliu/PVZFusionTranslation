using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using com.cyborgAssets.inspectorButtonPro;
using Core;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel;
using GameLevel.EventNodes;
using GameLevel.RogueShooting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
public class Plant : Entity
{
	// Token: 0x06000DB5 RID: 3509 RVA: 0x0004E2C0 File Offset: 0x0004C4C0
	[Token(Token = "0x6000DB5")]
	[Address(RVA = "0x44A450", Offset = "0x448A50", VA = "0x18044A450", Slot = "10")]
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

	// Token: 0x06000DB6 RID: 3510 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
	[Token(Token = "0x6000DB6")]
	[Address(RVA = "0x44CCC0", Offset = "0x44B2C0", VA = "0x18044CCC0")]
	public void Hid()
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
	[Token(Token = "0x6000DB7")]
	[Address(RVA = "0x451B80", Offset = "0x450180", VA = "0x180451B80", Slot = "15")]
	protected virtual void Start()
	{
		this.board.OnPlantCreate(this);
		if (this.jigsawType.Contains((uint)4))
		{
			int num = 0;
			this.ModifySpeed((PlantSpeedAdder)num, 0.3f);
		}
		this.UpdateText();
		throw new NullReferenceException();
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x0004E41C File Offset: 0x0004C61C
	[Token(Token = "0x6000DB8")]
	[Address(RVA = "0x4532A0", Offset = "0x4518A0", VA = "0x1804532A0", Slot = "16")]
	protected virtual void Update()
	{
		this.PlantUpdate();
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x0004E430 File Offset: 0x0004C630
	[Token(Token = "0x6000DB9")]
	[Address(RVA = "0x44C1F0", Offset = "0x44A7F0", VA = "0x18044C1F0", Slot = "17")]
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

	// Token: 0x06000DBA RID: 3514 RVA: 0x0004E47C File Offset: 0x0004C67C
	[Token(Token = "0x6000DBA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "18")]
	protected virtual void OnFixedUpdate()
	{
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x0004E48C File Offset: 0x0004C68C
	[Token(Token = "0x6000DBB")]
	[Address(RVA = "0x44CCE0", Offset = "0x44B2E0", VA = "0x18044CCE0")]
	public bool InRow(int row)
	{
		if (row < this.thePlantRow)
		{
		}
		int y = this.size.m_Y;
		return row <= y;
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x0004E4BC File Offset: 0x0004C6BC
	[Token(Token = "0x6000DBC")]
	[Address(RVA = "0x44CA40", Offset = "0x44B040", VA = "0x18044CA40")]
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

	// Token: 0x06000DBD RID: 3517 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x451790", Offset = "0x44FD90", VA = "0x180451790", Slot = "19")]
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

	// Token: 0x06000DBE RID: 3518 RVA: 0x0004E530 File Offset: 0x0004C730
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x44E030", Offset = "0x44C630", VA = "0x18044E030", Slot = "20")]
	public virtual void KillZombie(Zombie zombie)
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x0004E540 File Offset: 0x0004C740
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x44A720", Offset = "0x448D20", VA = "0x18044A720", Slot = "21")]
	public virtual void Charge()
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x0004E550 File Offset: 0x0004C750
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x452C90", Offset = "0x451290", VA = "0x180452C90", Slot = "22")]
	public virtual void TryBeDisable(float timer = 0f, bool force = false)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0004E574 File Offset: 0x0004C774
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x44C010", Offset = "0x44A610", VA = "0x18044C010")]
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

	// Token: 0x06000DC2 RID: 3522 RVA: 0x0004E5CC File Offset: 0x0004C7CC
	[Token(Token = "0x6000DC2")]
	[Address(RVA = "0x452750", Offset = "0x450D50", VA = "0x180452750")]
	public void TryBeActive(bool force = false)
	{
		int num5;
		for (;;)
		{
			int num = 0;
			if (this.plantTag != num)
			{
				goto IL_003C;
			}
			PlantType plantType = this.thePlantType;
			if ((plantType > PlantType.BigSunNut && (plantType == PlantType.BigWallNut || plantType == PlantType.CherryJalapeno)) || plantType == PlantType.Firecracker || plantType == PlantType.BigSunNut)
			{
				goto IL_003C;
			}
			IL_0043:
			Animator anim = this.anim;
			float speed = anim.speed;
			if (anim == 0)
			{
				return;
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
				break;
			}
			continue;
			IL_003C:
			if (force)
			{
				goto IL_0043;
			}
			return;
		}
		int num6 = 0;
		bool flag2;
		if (!flag2 && MapData_cs.SnowMaps.Contains(num6))
		{
			Vector3 vector;
			float z = vector.z;
			GameObject gameObject = Resources.Load<GameObject>("Particle/Prefabs/IceTrap");
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform;
			Renderer component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num5, identityQuaternion, transform).GetComponent<ParticleSystem>().GetComponent<Renderer>();
			string text = string.Format("particle{0}", component);
			component.sortingLayerName = text;
		}
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x0004E6EC File Offset: 0x0004C8EC
	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x44AA60", Offset = "0x449060", VA = "0x18044AA60")]
	private bool CheckOrActive()
	{
		if (this.plantTag == (ulong)0L)
		{
			PlantType plantType = this.thePlantType;
			if (plantType > PlantType.BigSunNut)
			{
				if (plantType == PlantType.BigWallNut || plantType == PlantType.CherryJalapeno || plantType == PlantType.PuffChomper)
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
		return true;
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x0004E744 File Offset: 0x0004C944
	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x44CD10", Offset = "0x44B310", VA = "0x18044CD10")]
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
			healthSlider2.Show(showPlantHealth);
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

	// Token: 0x06000DC5 RID: 3525 RVA: 0x0004E874 File Offset: 0x0004CA74
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "23")]
	protected virtual void OnAfterInitText()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x0004E884 File Offset: 0x0004CA84
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x4531A0", Offset = "0x4517A0", VA = "0x1804531A0", Slot = "24")]
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
			this.healthSlider.HealthValue = (float)num2;
			this.healthSlider.ShieldValue = (float)num3;
			this.healthSlider.UpdateText();
		}
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x0004E8E8 File Offset: 0x0004CAE8
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x44FEC0", Offset = "0x44E4C0", VA = "0x18044FEC0", Slot = "25")]
	public virtual void Recover(float health, DamageType damageType = DamageType.Normal, bool particle = true, bool continuous = false)
	{
		int num;
		float num4;
		int num6;
		do
		{
			num = 0;
			float num2 = this.Timers[0];
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
				goto IL_0150;
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
		if (Plant.<>c.<>9__111_0 == 0)
		{
			func = (Zombie a) => !a.isMindControlled;
			Plant.<>c.<>9__111_0 = func;
		}
		List<Zombie> list2;
		Zombie zombie = Enumerable.FirstOrDefault<Zombie>(list2, func);
		int num8 = 0;
		if (zombie != num8)
		{
			float num9 = health * 0.1f;
			float num10 = (float)(0 * (int)0.01f);
			if (num10 <= num9)
			{
			}
			throw new NullReferenceException();
		}
		Vector3 vector;
		float z = vector.z;
		ParticleManager instance = ParticleManager.Instance;
		int num11 = 0;
		Particle particle2;
		if (particle2 != num11)
		{
			Transform transform = particle2.transform;
		}
		return;
		IL_0150:
		throw new NullReferenceException();
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x0004EA54 File Offset: 0x0004CC54
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x44CA70", Offset = "0x44B070", VA = "0x18044CA70", Slot = "26")]
	public virtual void GetShield(float value)
	{
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x0004EA68 File Offset: 0x0004CC68
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x44D030", Offset = "0x44B630", VA = "0x18044D030")]
	private bool InsteadRecover()
	{
		PlantType plantType = this.thePlantType;
		if ((plantType > PlantType.CherryUltimatePumpkin && (plantType == PlantType.CherryNut || plantType == PlantType.CherryPumpkin)) || plantType == PlantType.UltimateChomper || plantType == PlantType.CherryUltimatePumpkin)
		{
			int num = this.thePlantRow;
			List<Plant> list = global::Lawnf.Get3x3Plants(this.thePlantColumn, num);
			Predicate<Plant> <>9__113_ = Plant.<>c.<>9__113_0;
			if (<>9__113_ == 0)
			{
				Predicate<Plant> predicate;
				Plant.<>c.<>9__113_0 = predicate;
			}
			int num2 = list.RemoveAll(<>9__113_);
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

	// Token: 0x06000DCA RID: 3530 RVA: 0x0004EB18 File Offset: 0x0004CD18
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x44E040", Offset = "0x44C640", VA = "0x18044E040", Slot = "27")]
	protected virtual void LimHealth()
	{
		int num = this.thePlantMaxHealth;
		if (this.thePlantHealth > num)
		{
			this.thePlantHealth = num;
		}
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x0004EB3C File Offset: 0x0004CD3C
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "28")]
	protected virtual void ReplaceSprite()
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0004EB4C File Offset: 0x0004CD4C
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x44A700", Offset = "0x448D00", VA = "0x18044A700")]
	public void Broken()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0004EB5C File Offset: 0x0004CD5C
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x44A740", Offset = "0x448D40", VA = "0x18044A740")]
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

	// Token: 0x06000DCE RID: 3534 RVA: 0x0004EC0C File Offset: 0x0004CE0C
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x44FDD0", Offset = "0x44E3D0", VA = "0x18044FDD0")]
	public void RealTakeDamage(int damage)
	{
		this.UpdateText();
		this.ReplaceSprite();
		this.lastTakeDamgeTime = 0f;
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x0004EC34 File Offset: 0x0004CE34
	[Token(Token = "0x6000DCF")]
	[Address(RVA = "0x451D90", Offset = "0x450390", VA = "0x180451D90", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		for (;;)
		{
			int num = 0;
			Plant.<>c__DisplayClass119_0 CS$<>8__locals1;
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
						goto IL_01F9;
					}
					bool flag4;
					if (flag4)
					{
					}
					ulong num7;
					if (num7 != (ulong)0L)
					{
						goto IL_0205;
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
					goto IL_01F3;
				}
				List<TalentType> talents = AdvantureConfig.data.talents;
				bool flag5;
				if (flag5)
				{
					Plant.<>c__DisplayClass119_1 CS$<>8__locals2;
					CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
					DelayAction delayAction;
					if (num == 22)
					{
						Func<Zombie, float> func;
						if (Plant.<>c.<>9__119_0 == 0)
						{
							Plant.<>c.<>9__119_0 = func;
						}
						List<Zombie> list2;
						Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.OrderBy<Zombie, float>(list2, func));
						CS$<>8__locals2.zombie = zombie;
						Zombie zombie2 = CS$<>8__locals2.zombie;
						int num12 = 0;
						if (!(zombie2 != num12) || CS$<>8__locals2.zombie.theStatus == ZombieStatus.Dying)
						{
							continue;
						}
						delayAction = GameAPP.delayAction;
						Action action = delegate
						{
							Zombie zombie3 = CS$<>8__locals2.zombie;
							int num14 = 0;
							if (zombie3 != num14)
							{
								Plant.<>c__DisplayClass119_0 CS$<>8__locals4 = CS$<>8__locals2.CS$<>8__locals1;
								Plant <>4__this = CS$<>8__locals4.<>4__this;
								int damage5 = CS$<>8__locals4.damage;
								Zombie zombie4 = CS$<>8__locals2.zombie;
							}
						};
						delayAction.SetAction(action, (float)num8);
					}
					while (delayAction != (ulong)24L)
					{
					}
					DelayAction delayAction2 = GameAPP.delayAction;
					Action action2;
					if (CS$<>8__locals2.CS$<>8__locals1.<>9__2 == 0)
					{
						Plant.<>c__DisplayClass119_0 CS$<>8__locals3 = CS$<>8__locals2.CS$<>8__locals1;
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
					goto IL_01F3;
				}
			}
		}
		return;
		IL_01F3:
		throw new NullReferenceException();
		IL_01F9:
		throw new NullReferenceException();
		IL_0205:
		throw new NullReferenceException();
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x0004EE64 File Offset: 0x0004D064
	[Token(Token = "0x6000DD0")]
	[Address(RVA = "0x44B3E0", Offset = "0x4499E0", VA = "0x18044B3E0", Slot = "29")]
	protected virtual void DecreateShield(int value)
	{
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x0004EE74 File Offset: 0x0004D074
	[Token(Token = "0x6000DD1")]
	[Address(RVA = "0x44B220", Offset = "0x449820", VA = "0x18044B220", Slot = "30")]
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

	// Token: 0x06000DD2 RID: 3538 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
	[Token(Token = "0x6000DD2")]
	[Address(RVA = "0x44C4F0", Offset = "0x44AAF0", VA = "0x18044C4F0", Slot = "31")]
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
		if (Plant.<>c.<>9__122_0 == 0)
		{
			func = (Zombie a) => a.isMindControlled;
			Plant.<>c.<>9__122_0 = func;
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
			num12 = num11 * 1.5f;
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

	// Token: 0x06000DD3 RID: 3539 RVA: 0x0004F03C File Offset: 0x0004D23C
	[Token(Token = "0x6000DD3")]
	[Address(RVA = "0x44D260", Offset = "0x44B860", VA = "0x18044D260", Slot = "32")]
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
				goto IL_01D0;
			}
			List<JigsawType> list = this.jigsawType;
			bool flag;
			if (flag)
			{
				goto IL_01D0;
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
					goto IL_01D6;
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
				goto IL_021E;
			}
			num11 = 0;
			if (Plant.<>c.<>9__123_0 == 0)
			{
				Plant.<>c.<>9__123_0 = (Plant p) => p.thePlantType == PlantType.ObsidianJalapeno || p.thePlantType == PlantType.UltimateMachineNut;
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
		IL_01D0:
		throw new NullReferenceException();
		IL_01D6:
		throw new NullReferenceException();
		IL_021E:
		throw new NullReferenceException();
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x0004F270 File Offset: 0x0004D470
	[Token(Token = "0x6000DD4")]
	[Address(RVA = "0x44C300", Offset = "0x44A900", VA = "0x18044C300")]
	public void FlashOnce()
	{
		if (!this.alwaysLightUp)
		{
			this.lightCountDown = 0.2f;
		}
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x0004F294 File Offset: 0x0004D494
	[Token(Token = "0x6000DD5")]
	[Address(RVA = "0x44B3F0", Offset = "0x4499F0", VA = "0x18044B3F0", Slot = "33")]
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
			this.dieReason = reason;
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
				goto IL_0149;
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
					goto IL_0149;
				}
				continue;
			}
			IL_0164:
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
			IL_0149:
			bool flag4;
			if (flag4 && flag4 > true && !flag4)
			{
				Vector3 vector;
				float z = vector.z;
				goto IL_0164;
			}
			goto IL_0164;
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

	// Token: 0x06000DD6 RID: 3542 RVA: 0x0004F524 File Offset: 0x0004D724
	[Token(Token = "0x6000DD6")]
	[Address(RVA = "0x44AB20", Offset = "0x449120", VA = "0x18044AB20", Slot = "34")]
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

	// Token: 0x06000DD7 RID: 3543 RVA: 0x0004F728 File Offset: 0x0004D928
	[Token(Token = "0x6000DD7")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "35")]
	protected virtual bool OnCrash()
	{
		return false;
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x0004F738 File Offset: 0x0004D938
	[Token(Token = "0x6000DD8")]
	[Address(RVA = "0x44A1E0", Offset = "0x4487E0", VA = "0x18044A1E0")]
	public void AdjustPosition(Vector3 targetPosition)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0004F764 File Offset: 0x0004D964
	[Token(Token = "0x6000DD9")]
	[Address(RVA = "0x44E780", Offset = "0x44CD80", VA = "0x18044E780")]
	public UniTask ModifyScaleAsync(float target, float timer)
	{
		int num = 0;
		int num2 = 0;
		if (num != 0 || num == 0)
		{
		}
		int num3 = 0;
		if (num3 < num2)
		{
			num3 += num3;
			num3++;
			return default(UniTask);
		}
		return default(UniTask);
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x0004F7A8 File Offset: 0x0004D9A8
	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x44A140", Offset = "0x448740", VA = "0x18044A140")]
	public void AdjustPositionY(float y)
	{
		Transform axis = this.axis;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
	[Token(Token = "0x6000DDB")]
	[Address(RVA = "0x44A2E0", Offset = "0x4488E0", VA = "0x18044A2E0")]
	public void AdjustY(float y)
	{
		Transform axis = this.axis;
		Rigidbody2D rigidbody2D = this.rb;
		int num = 0;
		Vector2 position = rigidbody2D.position;
		this.rb.MovePosition(num);
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x0004F80C File Offset: 0x0004DA0C
	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "36")]
	public virtual void ProducerUpdate()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x0004F81C File Offset: 0x0004DA1C
	[Token(Token = "0x6000DDD")]
	[Address(RVA = "0x451720", Offset = "0x44FD20", VA = "0x180451720", Slot = "37")]
	public virtual void SetBrightness(float b)
	{
		this.brightness = b;
		GameMaterial.SetBrightness(this.spriteRenderers, b);
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x0004F83C File Offset: 0x0004DA3C
	[Token(Token = "0x6000DDE")]
	[Address(RVA = "0x44C320", Offset = "0x44A920", VA = "0x18044C320")]
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

	// Token: 0x06000DDF RID: 3551 RVA: 0x0004F910 File Offset: 0x0004DB10
	[Token(Token = "0x6000DDF")]
	[Address(RVA = "0x44F220", Offset = "0x44D820", VA = "0x18044F220")]
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
				if (Plant.<>c.<>9__135_0 == 0)
				{
					func = delegate(Plant p)
					{
						if (p.thePlantType != PlantType.UltimateJalapeno)
						{
						}
						return p.attributeCount > 0;
					};
					Plant.<>c.<>9__135_0 = func;
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

	// Token: 0x06000DE0 RID: 3552 RVA: 0x0004FC9C File Offset: 0x0004DE9C
	[Token(Token = "0x6000DE0")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "38")]
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x0004FCAC File Offset: 0x0004DEAC
	[Token(Token = "0x6000DE1")]
	[Address(RVA = "0x44FD70", Offset = "0x44E370", VA = "0x18044FD70")]
	private void PositionUpdate()
	{
		Board board = this.board;
		Vector2 vector;
		this.MovePosition(vector);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x0004FCCC File Offset: 0x0004DECC
	[Token(Token = "0x6000DE2")]
	[Address(RVA = "0x44ECB0", Offset = "0x44D2B0", VA = "0x18044ECB0")]
	private void MovePosition(Vector2 position)
	{
		Transform axis = this.axis;
		bool flag;
		if (!flag)
		{
			Transform axis2 = this.axis;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			float deltaTime = Time.deltaTime;
			Transform axis3 = this.axis;
			Vector3 position2 = transform2.position;
			bool flag2;
			if (flag2)
			{
				CreatePlant instance = CreatePlant.Instance;
				int num = this.thePlantRow;
				int num2 = this.thePlantColumn;
				instance.SetLayer(this, num2, num);
				int num3 = 0;
				base.transform.position = num3;
			}
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0004FD58 File Offset: 0x0004DF58
	[Token(Token = "0x6000DE3")]
	[Address(RVA = "0x44F0A0", Offset = "0x44D6A0", VA = "0x18044F0A0")]
	private bool Near(Vector2 startPosition, Vector2 endPosition)
	{
		float timeScale = Time.timeScale;
		return typeof(Math).TypeHandle != null;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0004FD78 File Offset: 0x0004DF78
	[Token(Token = "0x6000DE4")]
	[Address(RVA = "0x44EB30", Offset = "0x44D130", VA = "0x18044EB30")]
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

	// Token: 0x06000DE5 RID: 3557 RVA: 0x0004FE20 File Offset: 0x0004E020
	[Token(Token = "0x6000DE5")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "39")]
	protected virtual void AttributeEvent()
	{
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x0004FE30 File Offset: 0x0004E030
	[Token(Token = "0x6000DE6")]
	[Address(RVA = "0x454040", Offset = "0x452640", VA = "0x180454040")]
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
				Predicate<PlantType> <>9__142_ = Plant.<>c.<>9__142_0;
				if (<>9__142_ == 0)
				{
					Plant.<>c.<>9__142_0 = delegate(PlantType p)
					{
						bool flag2;
						bool flag3;
						bool flag4;
						bool flag5;
						bool flag6;
						return flag2 || flag3 || flag4 || flag5 || flag6;
					};
				}
				int num2 = ultimatePlants.RemoveAll(<>9__142_);
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

	// Token: 0x06000DE7 RID: 3559 RVA: 0x0004FF40 File Offset: 0x0004E140
	[Token(Token = "0x6000DE7")]
	[Address(RVA = "0x451910", Offset = "0x44FF10", VA = "0x180451910")]
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

	// Token: 0x06000DE8 RID: 3560 RVA: 0x0004FF74 File Offset: 0x0004E174
	[Token(Token = "0x6000DE8")]
	[Address(RVA = "0x450D70", Offset = "0x44F370", VA = "0x180450D70", Slot = "40")]
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

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0004FFBC File Offset: 0x0004E1BC
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "41")]
	protected virtual void AnimSuperShoot()
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x0004FFCC File Offset: 0x0004E1CC
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x451C30", Offset = "0x450230", VA = "0x180451C30", Slot = "42")]
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

	// Token: 0x06000DEB RID: 3563 RVA: 0x00050040 File Offset: 0x0004E240
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x4514D0", Offset = "0x44FAD0", VA = "0x1804514D0", Slot = "43")]
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

	// Token: 0x06000DEC RID: 3564 RVA: 0x000500BC File Offset: 0x0004E2BC
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x44F160", Offset = "0x44D760", VA = "0x18044F160", Slot = "44")]
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

	// Token: 0x06000DED RID: 3565 RVA: 0x00050110 File Offset: 0x0004E310
	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x452D70", Offset = "0x451370", VA = "0x180452D70", Slot = "45")]
	protected virtual void UpdateAttackCountDown()
	{
		float num = this.thePlantAttackCountDown;
		float deltaTime = Time.deltaTime;
		this.thePlantAttackCountDown = num;
		float deltaTime2 = Time.deltaTime;
		this.thePlantAttackCountDown = num;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00050144 File Offset: 0x0004E344
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x451A60", Offset = "0x450060", VA = "0x180451A60", Slot = "46")]
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

	// Token: 0x06000DEF RID: 3567 RVA: 0x00050180 File Offset: 0x0004E380
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x450F10", Offset = "0x44F510", VA = "0x180450F10")]
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

	// Token: 0x06000DF0 RID: 3568 RVA: 0x0005025C File Offset: 0x0004E45C
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x451260", Offset = "0x44F860", VA = "0x180451260", Slot = "47")]
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

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00050368 File Offset: 0x0004E568
	[Token(Token = "0x6000DF1")]
	[Address(RVA = "0x44A380", Offset = "0x448980", VA = "0x18044A380")]
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

	// Token: 0x06000DF2 RID: 3570 RVA: 0x000503AC File Offset: 0x0004E5AC
	[Token(Token = "0x6000DF2")]
	[Address(RVA = "0x44AAC0", Offset = "0x4490C0", VA = "0x18044AAC0", Slot = "48")]
	public virtual void Connected(Plant plant)
	{
		this.isConnected = true;
		this.connectPlant = plant;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x000503D0 File Offset: 0x0004E5D0
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x44BFB0", Offset = "0x44A5B0", VA = "0x18044BFB0", Slot = "49")]
	public virtual void DisConnected()
	{
		this.isConnected = false;
		this.connectPlant = (ulong)0L;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x000503F0 File Offset: 0x0004E5F0
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x452DD0", Offset = "0x4513D0", VA = "0x180452DD0", Slot = "50")]
	public virtual void UpdateMagnetCount(int count)
	{
		this.magnetCount = count;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00050404 File Offset: 0x0004E604
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x450850", Offset = "0x44EE50", VA = "0x180450850")]
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

	// Token: 0x06000DF6 RID: 3574 RVA: 0x0005063C File Offset: 0x0004E83C
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	protected virtual void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x0005064C File Offset: 0x0004E84C
	[Token(Token = "0x6000DF7")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "52")]
	protected virtual void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0005065C File Offset: 0x0004E85C
	[Token(Token = "0x6000DF8")]
	[Address(RVA = "0x44CAD0", Offset = "0x44B0D0", VA = "0x18044CAD0")]
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

	// Token: 0x06000DF9 RID: 3577 RVA: 0x000506F0 File Offset: 0x0004E8F0
	[Token(Token = "0x6000DF9")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public virtual void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00050700 File Offset: 0x0004E900
	[Token(Token = "0x6000DFA")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public virtual void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00050710 File Offset: 0x0004E910
	[Token(Token = "0x6000DFB")]
	[Address(RVA = "0x44EA40", Offset = "0x44D040", VA = "0x18044EA40")]
	public void ModifyTempDamage(PlantDamageAdder index, float value, float during)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00050734 File Offset: 0x0004E934
	[Token(Token = "0x6000DFC")]
	[Address(RVA = "0x44E060", Offset = "0x44C660", VA = "0x18044E060")]
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

	// Token: 0x06000DFD RID: 3581 RVA: 0x000507B0 File Offset: 0x0004E9B0
	[Token(Token = "0x6000DFD")]
	[Address(RVA = "0x449F40", Offset = "0x448540", VA = "0x180449F40")]
	public void AddSpeed(float value)
	{
		this.thePlantSpeed = value;
		this.attributeSpeed = value;
		this.attackSpeedAdder = value;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x000507D4 File Offset: 0x0004E9D4
	[Token(Token = "0x6000DFE")]
	[Address(RVA = "0x44E970", Offset = "0x44CF70", VA = "0x18044E970")]
	public void ModifySpeed(PlantSpeedAdder index, float value)
	{
		Dictionary<PlantSpeedAdder, float> dictionary = this.speedAdder;
		Dictionary<PlantSpeedAdder, float> dictionary2 = this.speedAdder;
		this.attributeSpeed = value;
		this.attackSpeedAdder = value;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00050804 File Offset: 0x0004EA04
	[Token(Token = "0x6000DFF")]
	[Address(RVA = "0x449D90", Offset = "0x448390", VA = "0x180449D90")]
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

	// Token: 0x06000E00 RID: 3584 RVA: 0x0005085C File Offset: 0x0004EA5C
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x44E450", Offset = "0x44CA50", VA = "0x18044E450", Slot = "55")]
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

	// Token: 0x06000E01 RID: 3585 RVA: 0x000508B0 File Offset: 0x0004EAB0
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x449F80", Offset = "0x448580", VA = "0x180449F80")]
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

	// Token: 0x06000E02 RID: 3586 RVA: 0x000508D8 File Offset: 0x0004EAD8
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x452DE0", Offset = "0x4513E0", VA = "0x180452DE0")]
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

	// Token: 0x06000E03 RID: 3587 RVA: 0x000509A0 File Offset: 0x0004EBA0
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x453310", Offset = "0x451910", VA = "0x180453310")]
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
						goto IL_00F2;
					}
					GameObject[] itemPrefab = GameAPP.itemPrefab;
					instance = InGameText.Instance;
					int num6;
					string text = string.Format("升级植物需要消耗{0}阳光", num6);
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
						goto IL_00F2;
					}
					GameObject[] itemPrefab4 = GameAPP.itemPrefab;
				}
				GameObject[] itemPrefab5 = GameAPP.itemPrefab;
			}
			GameObject gameObject = GameAPP.itemPrefab[43];
			IL_00F2:
			int num7 = 0;
			if (gameObject != num7)
			{
				bool flag;
				int num8;
				if (flag)
				{
					num8 = 0;
				}
				int num9 = 0;
				GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, num8, num9);
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

	// Token: 0x06000E04 RID: 3588 RVA: 0x00050AF8 File Offset: 0x0004ECF8
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x451B30", Offset = "0x450130", VA = "0x180451B30")]
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

	// Token: 0x06000E05 RID: 3589 RVA: 0x00050B28 File Offset: 0x0004ED28
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "56")]
	protected virtual bool OnStarUp()
	{
		return false;
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00050B38 File Offset: 0x0004ED38
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "57")]
	protected virtual void UpgradeEvent(int theCurrentLevel)
	{
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00050B48 File Offset: 0x0004ED48
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public virtual void InfluenceByIceShroom()
	{
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00050B58 File Offset: 0x0004ED58
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "59")]
	public virtual void InfluenceByJalapeno()
	{
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00050B68 File Offset: 0x0004ED68
	[Token(Token = "0x6000E09")]
	[Address(RVA = "0x453BF0", Offset = "0x4521F0", VA = "0x180453BF0", Slot = "60")]
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

	// Token: 0x06000E0A RID: 3594 RVA: 0x00050CFC File Offset: 0x0004EEFC
	[Token(Token = "0x6000E0A")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "61")]
	public virtual bool OnClicked(Mouse mouse)
	{
		return false;
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00050D0C File Offset: 0x0004EF0C
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x44B030", Offset = "0x449630", VA = "0x18044B030")]
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

	// Token: 0x06000E0C RID: 3596 RVA: 0x00050D68 File Offset: 0x0004EF68
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "62")]
	public virtual void SetTargetByMouse(Mouse mouse)
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00050D78 File Offset: 0x0004EF78
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "63")]
	public virtual bool OnEat(Zombie zombie)
	{
		return false;
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00050D88 File Offset: 0x0004EF88
	[Token(Token = "0x170000F4")]
	public virtual PlantType PreviewType
	{
		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x454B90", Offset = "0x453190", VA = "0x180454B90", Slot = "64")]
		get
		{
			return this.thePlantType;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00050D9C File Offset: 0x0004EF9C
	// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00050DB0 File Offset: 0x0004EFB0
	[Token(Token = "0x170000F5")]
	public float AttributeCountdown
	{
		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x454770", Offset = "0x452D70", VA = "0x180454770")]
		get
		{
			return this.attributeCountdown;
		}
		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x455C00", Offset = "0x454200", VA = "0x180455C00")]
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
				healthSlider3.ProgressFill = (float)num2;
			}
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00050E0C File Offset: 0x0004F00C
	[Token(Token = "0x170000F6")]
	public bool Active
	{
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x4546E0", Offset = "0x452CE0", VA = "0x1804546E0")]
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

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00050E40 File Offset: 0x0004F040
	[Token(Token = "0x170000F7")]
	public BoxType BoxType
	{
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x4547F0", Offset = "0x452DF0", VA = "0x1804547F0")]
		get
		{
			GridSystem gridSystem = this.board.gridSystem;
			int num = this.thePlantRow;
			int num2 = this.thePlantColumn;
			return gridSystem.GetBoxType(num2, num);
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00050E78 File Offset: 0x0004F078
	[Token(Token = "0x170000F8")]
	public float[] Timers
	{
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x455910", Offset = "0x453F10", VA = "0x180455910")]
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

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00050EC4 File Offset: 0x0004F0C4
	[Token(Token = "0x170000F9")]
	public virtual int LimDamage
	{
		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x4549D0", Offset = "0x452FD0", VA = "0x1804549D0", Slot = "65")]
		get
		{
			return int.MaxValue;
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00050ED8 File Offset: 0x0004F0D8
	[Token(Token = "0x170000FA")]
	public Plant SameUpper
	{
		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x455740", Offset = "0x453D40", VA = "0x180455740")]
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

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00050F4C File Offset: 0x0004F14C
	[Token(Token = "0x170000FB")]
	public Plant SameLower
	{
		[Token(Token = "0x6000E16")]
		[Address(RVA = "0x455380", Offset = "0x453980", VA = "0x180455380")]
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

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00050FD8 File Offset: 0x0004F1D8
	[Token(Token = "0x170000FC")]
	public Plant SameLeft
	{
		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x4551B0", Offset = "0x4537B0", VA = "0x1804551B0")]
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

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000E18 RID: 3608 RVA: 0x0005104C File Offset: 0x0004F24C
	[Token(Token = "0x170000FD")]
	public Plant SameRight
	{
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x455560", Offset = "0x453B60", VA = "0x180455560")]
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

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000510D8 File Offset: 0x0004F2D8
	[Token(Token = "0x170000FE")]
	public bool WithGoldPot
	{
		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x455A40", Offset = "0x454040", VA = "0x180455A40")]
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

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00051140 File Offset: 0x0004F340
	[Token(Token = "0x170000FF")]
	public PlantType PotType
	{
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x4549E0", Offset = "0x452FE0", VA = "0x1804549E0")]
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

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000511B0 File Offset: 0x0004F3B0
	[Token(Token = "0x17000100")]
	public Plant Pumpkin
	{
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x454EB0", Offset = "0x4534B0", VA = "0x180454EB0")]
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

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00051240 File Offset: 0x0004F440
	[Token(Token = "0x17000101")]
	public bool BlockedByPumpkin
	{
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x454780", Offset = "0x452D80", VA = "0x180454780")]
		get
		{
			Plant pumpkin = this.Pumpkin;
			int num = 0;
			return pumpkin != num;
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00051264 File Offset: 0x0004F464
	[Token(Token = "0x17000102")]
	public PlantType PumpkinType
	{
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x454BA0", Offset = "0x4531A0", VA = "0x180454BA0")]
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

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000512FC File Offset: 0x0004F4FC
	[Token(Token = "0x17000103")]
	public GridItem Ladder
	{
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x454830", Offset = "0x452E30", VA = "0x180454830")]
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

	// Token: 0x06000E1F RID: 3615 RVA: 0x00051354 File Offset: 0x0004F554
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "66")]
	public virtual void BeforeSerialized(SavePlantData data)
	{
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00051364 File Offset: 0x0004F564
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "67")]
	public virtual void AfterDeserialized(SavePlantData data)
	{
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00051374 File Offset: 0x0004F574
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x454480", Offset = "0x452A80", VA = "0x180454480")]
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

	// Token: 0x04000A72 RID: 2674
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A72")]
	[Header("引用")]
	public List<JigsawType> jigsawType;

	// Token: 0x04000A73 RID: 2675
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A73")]
	protected List<Zombie> zombieList;

	// Token: 0x04000A74 RID: 2676
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A74")]
	public SortingGroup sortingGroup;

	// Token: 0x04000A75 RID: 2677
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A75")]
	public HealthSlider healthSlider;

	// Token: 0x04000A76 RID: 2678
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A76")]
	public GameObject levelIcon;

	// Token: 0x04000A77 RID: 2679
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A77")]
	public GameObject cheatIcon;

	// Token: 0x04000A78 RID: 2680
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A78")]
	public Plant targetPlant;

	// Token: 0x04000A79 RID: 2681
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A79")]
	public Zombie targetZombie;

	// Token: 0x04000A7A RID: 2682
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A7A")]
	public Transform shoot;

	// Token: 0x04000A7B RID: 2683
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A7B")]
	public Transform shoot2;

	// Token: 0x04000A7C RID: 2684
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A7C")]
	public Plant next;

	// Token: 0x04000A7D RID: 2685
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A7D")]
	public Plant pre;

	// Token: 0x04000A7E RID: 2686
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A7E")]
	public Plant snakeNext;

	// Token: 0x04000A7F RID: 2687
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A7F")]
	public Plant snakePre;

	// Token: 0x04000A80 RID: 2688
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A80")]
	public Rigidbody2D rb;

	// Token: 0x04000A81 RID: 2689
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A81")]
	public Plant connectPlant;

	// Token: 0x04000A82 RID: 2690
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A82")]
	public Plant jalapuff;

	// Token: 0x04000A83 RID: 2691
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A83")]
	[Header("基本信息1")]
	public int skinType;

	// Token: 0x04000A84 RID: 2692
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000A84")]
	public int thePlantMaxHealth;

	// Token: 0x04000A85 RID: 2693
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A85")]
	public int thePlantHealth;

	// Token: 0x04000A86 RID: 2694
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Token(Token = "0x4000A86")]
	public int theShieldHealth;

	// Token: 0x04000A87 RID: 2695
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000A87")]
	public int attackDamage;

	// Token: 0x04000A88 RID: 2696
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Token(Token = "0x4000A88")]
	public int thePlantColumn;

	// Token: 0x04000A89 RID: 2697
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000A89")]
	public int thePlantRow;

	// Token: 0x04000A8A RID: 2698
	[global::Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x4000A8A")]
	public int magnetCount;

	// Token: 0x04000A8B RID: 2699
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000A8B")]
	public int theLevel;

	// Token: 0x04000A8C RID: 2700
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Token(Token = "0x4000A8C")]
	public int wheatType;

	// Token: 0x04000A8D RID: 2701
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000A8D")]
	public int disableCount;

	// Token: 0x04000A8E RID: 2702
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000A8E")]
	public int attributeCount;

	// Token: 0x04000A8F RID: 2703
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000A8F")]
	public int shootingLevel;

	// Token: 0x04000A90 RID: 2704
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000A90")]
	public int shootingCurse;

	// Token: 0x04000A91 RID: 2705
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A91")]
	public int killCount;

	// Token: 0x04000A92 RID: 2706
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000A92")]
	public int puffPlace;

	// Token: 0x04000A93 RID: 2707
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000A93")]
	public int baseLayer;

	// Token: 0x04000A94 RID: 2708
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Token(Token = "0x4000A94")]
	public int currentLightLevel;

	// Token: 0x04000A95 RID: 2709
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000A95")]
	public int butterP;

	// Token: 0x04000A96 RID: 2710
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4000A96")]
	public int thePlantStage;

	// Token: 0x04000A97 RID: 2711
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000A97")]
	[Header("基本信息2")]
	public float defence;

	// Token: 0x04000A98 RID: 2712
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Token(Token = "0x4000A98")]
	public float moveSpeed;

	// Token: 0x04000A99 RID: 2713
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000A99")]
	public float thePlantAttackInterval;

	// Token: 0x04000A9A RID: 2714
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Token(Token = "0x4000A9A")]
	public float thePlantProduceInterval;

	// Token: 0x04000A9B RID: 2715
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000A9B")]
	public float thePlantSpeed;

	// Token: 0x04000A9C RID: 2716
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Token(Token = "0x4000A9C")]
	public float brightness;

	// Token: 0x04000A9D RID: 2717
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000A9D")]
	public float moveTime;

	// Token: 0x04000A9E RID: 2718
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000A9E")]
	public float attackSpeedAdder;

	// Token: 0x04000A9F RID: 2719
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000A9F")]
	public float attributeSpeed;

	// Token: 0x04000AA0 RID: 2720
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000AA0")]
	public float attributeFloat;

	// Token: 0x04000AA1 RID: 2721
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000AA1")]
	protected float theOriginSpeed;

	// Token: 0x04000AA2 RID: 2722
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000AA2")]
	protected float vision;

	// Token: 0x04000AA3 RID: 2723
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000AA3")]
	[Header("基本信息3")]
	public Vector3 startPos;

	// Token: 0x04000AA4 RID: 2724
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Token(Token = "0x4000AA4")]
	public Vector3 cannonTarget;

	// Token: 0x04000AA5 RID: 2725
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Token(Token = "0x4000AA5")]
	public Plant.PlantTag plantTag;

	// Token: 0x04000AA6 RID: 2726
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Token(Token = "0x4000AA6")]
	public PlantStatus theStatus;

	// Token: 0x04000AA7 RID: 2727
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Token(Token = "0x4000AA7")]
	public PlantType thePlantType;

	// Token: 0x04000AA8 RID: 2728
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Token(Token = "0x4000AA8")]
	public PlantType theLilyType;

	// Token: 0x04000AA9 RID: 2729
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Token(Token = "0x4000AA9")]
	public PlantType firstParent;

	// Token: 0x04000AAA RID: 2730
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Token(Token = "0x4000AAA")]
	public PlantType secondParent;

	// Token: 0x04000AAB RID: 2731
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x4000AAB")]
	public HashSet<EveBuff> eveBuffs;

	// Token: 0x04000AAC RID: 2732
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000AAC")]
	public Action defaultAction;

	// Token: 0x04000AAD RID: 2733
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x4000AAD")]
	public Vector2Int size;

	// Token: 0x04000AAE RID: 2734
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x4000AAE")]
	public Plant.DieReason dieReason;

	// Token: 0x04000AAF RID: 2735
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x4000AAF")]
	public LayerMask bulletLayer;

	// Token: 0x04000AB0 RID: 2736
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000AB0")]
	public LayerMask potLayer;

	// Token: 0x04000AB1 RID: 2737
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Token(Token = "0x4000AB1")]
	public LayerMask airLayer;

	// Token: 0x04000AB2 RID: 2738
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000AB2")]
	[Header("倒计时")]
	public float thePlantAttackCountDown;

	// Token: 0x04000AB3 RID: 2739
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Token(Token = "0x4000AB3")]
	public float thePlantProduceCountDown;

	// Token: 0x04000AB4 RID: 2740
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000AB4")]
	public float attributeCountdown;

	// Token: 0x04000AB5 RID: 2741
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Token(Token = "0x4000AB5")]
	public float lightCountDown;

	// Token: 0x04000AB6 RID: 2742
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000AB6")]
	public float flashCountDown;

	// Token: 0x04000AB7 RID: 2743
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Token(Token = "0x4000AB7")]
	public float wheatTime;

	// Token: 0x04000AB8 RID: 2744
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000AB8")]
	public float lastTakeDamgeTime;

	// Token: 0x04000AB9 RID: 2745
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Token(Token = "0x4000AB9")]
	[Header("开关")]
	public bool isLily;

	// Token: 0x04000ABA RID: 2746
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E5")]
	[Token(Token = "0x4000ABA")]
	public bool imitatless;

	// Token: 0x04000ABB RID: 2747
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E6")]
	[Token(Token = "0x4000ABB")]
	public bool invincible;

	// Token: 0x04000ABC RID: 2748
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E7")]
	[Token(Token = "0x4000ABC")]
	public bool isShort;

	// Token: 0x04000ABD RID: 2749
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000ABD")]
	public bool dying;

	// Token: 0x04000ABE RID: 2750
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
	[Token(Token = "0x4000ABE")]
	public bool alwaysLightUp;

	// Token: 0x04000ABF RID: 2751
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EA")]
	[Token(Token = "0x4000ABF")]
	public bool isCrashed;

	// Token: 0x04000AC0 RID: 2752
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EB")]
	[Token(Token = "0x4000AC0")]
	public bool melonSputter;

	// Token: 0x04000AC1 RID: 2753
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000AC1")]
	public bool dieMeansLose;

	// Token: 0x04000AC2 RID: 2754
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1ED")]
	[Token(Token = "0x4000AC2")]
	public bool isConnected;

	// Token: 0x04000AC3 RID: 2755
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EE")]
	[Token(Token = "0x4000AC3")]
	public bool keepShooting;

	// Token: 0x04000AC4 RID: 2756
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1EF")]
	[Token(Token = "0x4000AC4")]
	public bool waitingDestory;

	// Token: 0x04000AC5 RID: 2757
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000AC5")]
	public bool hid;

	// Token: 0x04000AC6 RID: 2758
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F1")]
	[Token(Token = "0x4000AC6")]
	public bool uncrashable;

	// Token: 0x04000AC7 RID: 2759
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F2")]
	[Token(Token = "0x4000AC7")]
	public bool isFlashing;

	// Token: 0x04000AC8 RID: 2760
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F3")]
	[Token(Token = "0x4000AC8")]
	public bool undead;

	// Token: 0x04000AC9 RID: 2761
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000AC9")]
	public bool garlic;

	// Token: 0x04000ACA RID: 2762
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F5")]
	[Token(Token = "0x4000ACA")]
	public bool freeMoving;

	// Token: 0x04000ACB RID: 2763
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F6")]
	[Token(Token = "0x4000ACB")]
	public bool starUp;

	// Token: 0x04000ACC RID: 2764
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000ACC")]
	public Dictionary<PlantDamageAdder, float> damageAdder;

	// Token: 0x04000ACD RID: 2765
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000ACD")]
	public readonly Dictionary<PlantHealthAdder, float> healthAdder;

	// Token: 0x04000ACE RID: 2766
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000ACE")]
	public readonly Dictionary<PlantSpeedAdder, float> speedAdder;

	// Token: 0x04000ACF RID: 2767
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000ACF")]
	private float[] _timers;

	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	public struct PlantHealthChangeData
	{
		// Token: 0x04000AD0 RID: 2768
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD0")]
		public Plant plant;

		// Token: 0x04000AD1 RID: 2769
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000AD1")]
		public int value;

		// Token: 0x04000AD2 RID: 2770
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000AD2")]
		public bool real;
	}

	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	[Serializable]
	public struct PlantTag
	{
		// Token: 0x04000AD3 RID: 2771
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000AD3")]
		public bool flyingPlant;

		// Token: 0x04000AD4 RID: 2772
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000AD4")]
		public bool hardLandPlant;

		// Token: 0x04000AD5 RID: 2773
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000AD5")]
		public bool waterPlant;

		// Token: 0x04000AD6 RID: 2774
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000AD6")]
		public bool snowPlant;

		// Token: 0x04000AD7 RID: 2775
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000AD7")]
		public bool pumpkinPlant;

		// Token: 0x04000AD8 RID: 2776
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000AD8")]
		public bool lanternPlant;

		// Token: 0x04000AD9 RID: 2777
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000AD9")]
		public bool smallLanternPlant;

		// Token: 0x04000ADA RID: 2778
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Token(Token = "0x4000ADA")]
		public bool puffPlant;

		// Token: 0x04000ADB RID: 2779
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000ADB")]
		public bool nutPlant;

		// Token: 0x04000ADC RID: 2780
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000ADC")]
		public bool tallNutPlant;

		// Token: 0x04000ADD RID: 2781
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Token(Token = "0x4000ADD")]
		public bool potatoPlant;

		// Token: 0x04000ADE RID: 2782
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Token(Token = "0x4000ADE")]
		public bool caltropPlant;

		// Token: 0x04000ADF RID: 2783
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000ADF")]
		public bool tanglekelpPlant;

		// Token: 0x04000AE0 RID: 2784
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Token(Token = "0x4000AE0")]
		public bool magnetPlant;

		// Token: 0x04000AE1 RID: 2785
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Token(Token = "0x4000AE1")]
		public bool potPlant;

		// Token: 0x04000AE2 RID: 2786
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xF")]
		[Token(Token = "0x4000AE2")]
		public bool doubleBoxPlant;

		// Token: 0x04000AE3 RID: 2787
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AE3")]
		public bool spickRockPlant;

		// Token: 0x04000AE4 RID: 2788
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Token(Token = "0x4000AE4")]
		public bool icePlant;

		// Token: 0x04000AE5 RID: 2789
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Token(Token = "0x4000AE5")]
		public bool firePlant;
	}

	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public enum DieReason
	{
		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		Default,
		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		ByWheat,
		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		ByMix,
		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		ByDisMix,
		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		ByLevelUp,
		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		BySteal,
		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		ByBejeweled,
		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		ByShovel,
		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		BySelf,
		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		ByFreeze,
		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		Hid,
		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		CrashInWater,
		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		Crash,
		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		Wheel
	}
}
