using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000799 RID: 1945
[Token(Token = "0x2000799")]
public class PlayerWeapon : MonoBehaviour, IDamageMaker
{
	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06002782 RID: 10114 RVA: 0x000D6644 File Offset: 0x000D4844
	[Token(Token = "0x17000193")]
	protected int AttackDamage
	{
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x604F30", Offset = "0x603530", VA = "0x180604F30")]
		get
		{
			float num = this.player.basicDamage * this.damageAdder;
			int num2 = global::UnityEngine.Random.Range(0, 1);
			float strikeRate = this.player.strikeRate;
			return num2;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06002783 RID: 10115 RVA: 0x000D6684 File Offset: 0x000D4884
	[Token(Token = "0x17000194")]
	protected int FireDamage
	{
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x604FC0", Offset = "0x6035C0", VA = "0x180604FC0")]
		get
		{
			int attackDamage = this.AttackDamage;
			Player player = this.player;
			return attackDamage;
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06002784 RID: 10116 RVA: 0x000D66A8 File Offset: 0x000D48A8
	// (set) Token: 0x06002785 RID: 10117 RVA: 0x000D66C0 File Offset: 0x000D48C0
	[Token(Token = "0x17000195")]
	public Team Team
	{
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "4")]
		get
		{
			return Team.Player;
		}
		[Token(Token = "0x6002785")]
		[Address(RVA = "0x605000", Offset = "0x603600", VA = "0x180605000", Slot = "5")]
		set
		{
			NotImplementedException ex = new NotImplementedException();
		}
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x000D66D4 File Offset: 0x000D48D4
	[Token(Token = "0x6002786")]
	[Address(RVA = "0x604510", Offset = "0x602B10", VA = "0x180604510", Slot = "7")]
	protected virtual void Awake()
	{
		LayerMask layerMask = LayerMask.GetMask(new string[] { "Zombie" });
		this.zombieLayer = layerMask;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x000D6710 File Offset: 0x000D4910
	[Token(Token = "0x6002787")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "8")]
	public virtual void OnEvoluted()
	{
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x000D6720 File Offset: 0x000D4920
	[Token(Token = "0x6002788")]
	[Address(RVA = "0x604C80", Offset = "0x603280", VA = "0x180604C80", Slot = "9")]
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

	// Token: 0x06002789 RID: 10121 RVA: 0x000D6790 File Offset: 0x000D4990
	[Token(Token = "0x6002789")]
	[Address(RVA = "0x604C40", Offset = "0x603240", VA = "0x180604C40")]
	private void Load()
	{
		int num = this.maxMagazine;
		this.magazine = num;
		float num2 = this.shootInterval;
		this.shootTimer = num2;
		this.Shoot();
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x000D67C0 File Offset: 0x000D49C0
	[Token(Token = "0x600278A")]
	[Address(RVA = "0x604D30", Offset = "0x603330", VA = "0x180604D30", Slot = "10")]
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

	// Token: 0x0600278B RID: 10123 RVA: 0x000D6810 File Offset: 0x000D4A10
	[Token(Token = "0x600278B")]
	[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "11")]
	protected virtual BulletType GetBulletType()
	{
		return BulletType.Bullet_pea;
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x000D6828 File Offset: 0x000D4A28
	[Token(Token = "0x600278C")]
	[Address(RVA = "0x6045F0", Offset = "0x602BF0", VA = "0x1806045F0")]
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

	// Token: 0x0600278D RID: 10125 RVA: 0x000D6910 File Offset: 0x000D4B10
	[Token(Token = "0x600278D")]
	[Address(RVA = "0x604B50", Offset = "0x603150", VA = "0x180604B50", Slot = "12")]
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

	// Token: 0x0600278E RID: 10126 RVA: 0x000D69A0 File Offset: 0x000D4BA0
	[Token(Token = "0x600278E")]
	[Address(RVA = "0x6045B0", Offset = "0x602BB0", VA = "0x1806045B0", Slot = "6")]
	public bool CanAttack(IDamageable target)
	{
		NotImplementedException ex = new NotImplementedException();
		return false;
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x000D69B4 File Offset: 0x000D4BB4
	[Token(Token = "0x600278F")]
	[Address(RVA = "0x604E90", Offset = "0x603490", VA = "0x180604E90")]
	public PlayerWeapon()
	{
		Dictionary<PlayerWeaponBuff, int> dictionary = new Dictionary();
		this.BuffDic = dictionary;
		base..ctor();
	}

	// Token: 0x040015E1 RID: 5601
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40015E1")]
	public Player player;

	// Token: 0x040015E2 RID: 5602
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40015E2")]
	public PlayerWeaponType theWeaponType;

	// Token: 0x040015E3 RID: 5603
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40015E3")]
	[Header("攻速参数")]
	public float shootTimer;

	// Token: 0x040015E4 RID: 5604
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40015E4")]
	public float shootInterval = 1.5f;

	// Token: 0x040015E5 RID: 5605
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40015E5")]
	[Header("装填参数")]
	public int magazine = (int)((ulong)4L);

	// Token: 0x040015E6 RID: 5606
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40015E6")]
	public float loadingTimer = 1.5f;

	// Token: 0x040015E7 RID: 5607
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40015E7")]
	public float loadingInterval = 1.5f;

	// Token: 0x040015E8 RID: 5608
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40015E8")]
	[Header("伤害参数")]
	public int damage;

	// Token: 0x040015E9 RID: 5609
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40015E9")]
	[Header("升级参数")]
	public int maxMagazine;

	// Token: 0x040015EA RID: 5610
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40015EA")]
	public int shootCount;

	// Token: 0x040015EB RID: 5611
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40015EB")]
	public int level;

	// Token: 0x040015EC RID: 5612
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40015EC")]
	public int evolution;

	// Token: 0x040015ED RID: 5613
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40015ED")]
	public float loadingSpeed;

	// Token: 0x040015EE RID: 5614
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40015EE")]
	public float shootSpeed;

	// Token: 0x040015EF RID: 5615
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40015EF")]
	public float damageAdder;

	// Token: 0x040015F0 RID: 5616
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40015F0")]
	public Dictionary<PlayerWeaponBuff, int> BuffDic;

	// Token: 0x040015F1 RID: 5617
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40015F1")]
	protected float attributeTimer;

	// Token: 0x040015F2 RID: 5618
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40015F2")]
	protected LayerMask zombieLayer;
}
