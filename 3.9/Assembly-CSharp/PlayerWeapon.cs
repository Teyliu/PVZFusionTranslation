using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D2 RID: 2002
[Token(Token = "0x20007D2")]
public class PlayerWeapon : MonoBehaviour, IDamageMaker
{
	// Token: 0x170001DD RID: 477
	// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000DB62C File Offset: 0x000D982C
	[Token(Token = "0x170001DD")]
	protected int AttackDamage
	{
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x668740", Offset = "0x666D40", VA = "0x180668740")]
		get
		{
			float num = this.player.basicDamage * this.damageAdder;
			int num2 = global::UnityEngine.Random.Range(0, 1);
			float strikeRate = this.player.strikeRate;
			return num2;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000DB66C File Offset: 0x000D986C
	[Token(Token = "0x170001DE")]
	protected int FireDamage
	{
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x6687D0", Offset = "0x666DD0", VA = "0x1806687D0")]
		get
		{
			int attackDamage = this.AttackDamage;
			Player player = this.player;
			return attackDamage;
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000DB690 File Offset: 0x000D9890
	// (set) Token: 0x060028B4 RID: 10420 RVA: 0x000DB6A8 File Offset: 0x000D98A8
	[Token(Token = "0x170001DF")]
	public Team Team
	{
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x668810", Offset = "0x666E10", VA = "0x180668810", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x000DB6BC File Offset: 0x000D98BC
	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x667D20", Offset = "0x666320", VA = "0x180667D20", Slot = "7")]
	protected virtual void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x000DB6F8 File Offset: 0x000D98F8
	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "8")]
	public virtual void OnEvoluted()
	{
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x000DB708 File Offset: 0x000D9908
	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x668490", Offset = "0x666A90", VA = "0x180668490", Slot = "9")]
	public virtual void OnUpdate()
	{
		float num = this.loadingTimer;
		float deltaTime = Time.deltaTime;
		this.loadingTimer = num;
		float num2 = this.loadingInterval;
		this.loadingTimer = num2;
		int num3 = this.maxMagazine;
		this.magazine = num3;
		float deltaTime2 = Time.deltaTime;
		this.shootTimer = num;
		float num4 = this.shootInterval;
		this.shootTimer = num4;
		this.Shoot();
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x000DB778 File Offset: 0x000D9978
	[Token(Token = "0x60028B8")]
	[Address(RVA = "0x668450", Offset = "0x666A50", VA = "0x180668450")]
	private void Load()
	{
		int num = this.maxMagazine;
		this.magazine = num;
		float num2 = this.shootInterval;
		this.shootTimer = num2;
		this.Shoot();
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x000DB7A8 File Offset: 0x000D99A8
	[Token(Token = "0x60028B9")]
	[Address(RVA = "0x668540", Offset = "0x666B40", VA = "0x180668540", Slot = "10")]
	protected virtual void Shoot()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		Transform transform = base.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.AttackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x000DB7F8 File Offset: 0x000D99F8
	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "11")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x000DB810 File Offset: 0x000D9A10
	[Token(Token = "0x60028BB")]
	[Address(RVA = "0x667E00", Offset = "0x666400", VA = "0x180667E00")]
	public static PlayerWeapon GetWeapon(PlayerWeaponType playerWeaponType, Player player)
	{
		PlayerWeapon component;
		ulong num4;
		do
		{
			int num = 0;
			Type typeFromHandle = typeof(PlayerWeaponType);
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			GameObject gameObject = Resources.Load<GameObject>("_Other/PlayerWeapon/" + name);
			int num2 = 0;
			if (gameObject == num2)
			{
				goto IL_00CC;
			}
			GameObject gameObject2 = Resources.Load<GameObject>("_Other/PlayerWeapon/" + name);
			Transform transform = player.transform;
			Vector3 vector;
			float z = vector.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			GameObject gameObject3;
			component = gameObject3.GetComponent<PlayerWeapon>();
			component.theWeaponType = playerWeaponType;
			component.InitData();
			component.player = player;
			int size = player.playerWeapons._size;
			List<Transform> weaponTransforms = player.weaponTransforms;
			bool flag;
			if (flag)
			{
				int num3;
				while (num3 != 0)
				{
				}
				component.transform.parentInternal = num;
				Transform transform2 = component.transform;
			}
		}
		while (num4 != (ulong)0L);
		return component;
		IL_00CC:
		string text2;
		string text = text2 + text2 + text2;
		return null;
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x000DB8F8 File Offset: 0x000D9AF8
	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x668360", Offset = "0x666960", VA = "0x180668360", Slot = "12")]
	protected virtual void InitData()
	{
		int num = 0;
		Dictionary<PlayerWeaponType, ValueTuple<int, float, float>> weaponDataDic = PlayerShootingData.WeaponDataDic;
		PlayerWeaponType playerWeaponType = this.theWeaponType;
		if (weaponDataDic.TryGetValue(playerWeaponType, num))
		{
			this.shootInterval = (float)0;
			this.loadingInterval = (float)num;
			this.loadingTimer = (float)num;
			this.damage = num;
			this.maxMagazine = (int)((ulong)1L);
			this.magazine = (int)((ulong)1L);
			this.shootSpeed = 1f;
			this.loadingSpeed = 1f;
			this.shootCount = (int)((ulong)1L);
			this.damageAdder = 1f;
			this.level = (int)((ulong)1L);
		}
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x000DB988 File Offset: 0x000D9B88
	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x667DC0", Offset = "0x6663C0", VA = "0x180667DC0", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x000DB99C File Offset: 0x000D9B9C
	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x6686A0", Offset = "0x666CA0", VA = "0x1806686A0")]
	public PlayerWeapon()
	{
		Dictionary<PlayerWeaponBuff, int> dictionary = new Dictionary();
		this.BuffDic = dictionary;
		base..ctor();
	}

	// Token: 0x040016BD RID: 5821
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40016BD")]
	public Player player;

	// Token: 0x040016BE RID: 5822
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40016BE")]
	public PlayerWeaponType theWeaponType;

	// Token: 0x040016BF RID: 5823
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40016BF")]
	[Header("攻速参数")]
	public float shootTimer;

	// Token: 0x040016C0 RID: 5824
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40016C0")]
	public float shootInterval = 1.5f;

	// Token: 0x040016C1 RID: 5825
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40016C1")]
	[Header("装填参数")]
	public int magazine = (int)((ulong)4L);

	// Token: 0x040016C2 RID: 5826
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40016C2")]
	public float loadingTimer = 1.5f;

	// Token: 0x040016C3 RID: 5827
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40016C3")]
	public float loadingInterval = 1.5f;

	// Token: 0x040016C4 RID: 5828
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40016C4")]
	[Header("伤害参数")]
	public int damage;

	// Token: 0x040016C5 RID: 5829
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40016C5")]
	[Header("升级参数")]
	public int maxMagazine;

	// Token: 0x040016C6 RID: 5830
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40016C6")]
	public int shootCount;

	// Token: 0x040016C7 RID: 5831
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40016C7")]
	public int level;

	// Token: 0x040016C8 RID: 5832
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40016C8")]
	public int evolution;

	// Token: 0x040016C9 RID: 5833
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40016C9")]
	public float loadingSpeed;

	// Token: 0x040016CA RID: 5834
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40016CA")]
	public float shootSpeed;

	// Token: 0x040016CB RID: 5835
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40016CB")]
	public float damageAdder;

	// Token: 0x040016CC RID: 5836
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40016CC")]
	public Dictionary<PlayerWeaponBuff, int> BuffDic;

	// Token: 0x040016CD RID: 5837
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40016CD")]
	protected float attributeTimer;

	// Token: 0x040016CE RID: 5838
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40016CE")]
	protected LayerMask zombieLayer;
}
