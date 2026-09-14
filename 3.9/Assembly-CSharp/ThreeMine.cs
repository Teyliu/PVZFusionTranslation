using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005C0 RID: 1472
[Token(Token = "0x20005C0")]
public class ThreeMine : ThreePeater
{
	// Token: 0x06001B2F RID: 6959 RVA: 0x00091AF8 File Offset: 0x0008FCF8
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x54E0C0", Offset = "0x54C6C0", VA = "0x18054E0C0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)29L);
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001B30 RID: 6960 RVA: 0x00091B20 File Offset: 0x0008FD20
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x54EEC0", Offset = "0x54D4C0", VA = "0x18054EEC0")]
	private void UpdateShootingCD()
	{
		float num = this.shootingCD;
		float deltaTime = Time.deltaTime;
		this.shootingCD = num;
		float attributeFloat = this.attributeFloat;
		this.shootingCD = 10f;
		this.shooting = true;
		this.shootingTimer = attributeFloat;
	}

	// Token: 0x06001B31 RID: 6961 RVA: 0x00091B68 File Offset: 0x0008FD68
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x54EF40", Offset = "0x54D540", VA = "0x18054EF40")]
	private void UpdateShootingTimer()
	{
		float num = this.shootingTimer;
		float deltaTime = Time.deltaTime;
		this.shootingTimer = num;
		this.shooting = false;
		this.shootingTimer = 0f;
	}

	// Token: 0x06001B32 RID: 6962 RVA: 0x00091BA0 File Offset: 0x0008FDA0
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x54EF90", Offset = "0x54D590", VA = "0x18054EF90", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Board board = this.board;
		float num = this.shootingTimer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			float num3 = this.shootingCD;
			float deltaTime = Time.deltaTime;
			this.shootingCD = num3;
			float attributeFloat = this.attributeFloat;
			this.shootingCD = 10f;
			this.shooting = true;
			this.shootingTimer = attributeFloat;
			return;
		}
		float deltaTime2 = Time.deltaTime;
		this.shooting = false;
		this.shootingTimer = 0f;
	}

	// Token: 0x06001B33 RID: 6963 RVA: 0x00091C24 File Offset: 0x0008FE24
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x54EEA0", Offset = "0x54D4A0", VA = "0x18054EEA0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		if (!this.shooting)
		{
			base.PlantShootUpdate();
			return;
		}
	}

	// Token: 0x06001B34 RID: 6964 RVA: 0x00091C44 File Offset: 0x0008FE44
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x54E820", Offset = "0x54CE20", VA = "0x18054E820", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num2;
		float num3;
		do
		{
			base.FixedUpdate();
			Zombie zombie = this.DetectFirstZombie();
			int num = 0;
			bool flag = zombie != num;
			num2 = 0;
			if (!flag)
			{
				goto IL_004C;
			}
			Transform axis = zombie.axis;
			Transform axis2 = this.axis;
		}
		while (num2 <= (int)num3 && num3 <= 1f);
		float num4 = (float)(0 * (int)1.2f);
		this.thePlantAttackInterval = num4;
		IL_004C:
		if (this.shooting)
		{
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			BulletType bulletType = this.GetBulletType();
			Bullet bullet;
			bullet.Damage = 0;
			float num5 = this.shootingTimer * 3.1415927f;
			Transform shoot3 = this.shoot;
			float num6 = num5 * 45f;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform shoot4 = this.shoot;
			BulletType bulletType2 = this.GetBulletType();
			Bullet bullet2;
			Transform transform = bullet2.transform;
			float num7 = num6 * 0.017453292f;
			Transform shoot5 = this.shoot;
			CreateBullet instance3 = CreateBullet.Instance;
			Transform shoot6 = this.shoot;
			BulletType bulletType3 = this.GetBulletType();
			Bullet bullet3;
			Transform transform2 = bullet3.transform;
			float num8 = num6 * 0.017453292f;
			Quaternion quaternion;
			GameAPP.PlaySound((int)quaternion.x, 0.5f, 1f);
		}
	}

	// Token: 0x06001B35 RID: 6965 RVA: 0x00091D6C File Offset: 0x0008FF6C
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x54DFD0", Offset = "0x54C5D0", VA = "0x18054DFD0", Slot = "39")]
	protected override void AttributeEvent()
	{
		base.OnFixedUpdate();
		this.anim.SetTrigger("rise");
		this.theStatus = (PlantStatus)((ulong)30L);
		this.invincible = true;
		GameAPP.PlaySound(48, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001B36 RID: 6966 RVA: 0x00091DC8 File Offset: 0x0008FFC8
	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x54ED80", Offset = "0x54D380", VA = "0x18054ED80")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		float num = this.shootingTimer;
		int num2 = 0;
		bool flag;
		if (num <= (float)num2 && flag)
		{
			int thePlantRow = this.thePlantRow;
			ulong num3;
			if (num3 > (ulong)10L)
			{
				if (thePlantRow <= 8)
				{
				}
				if (num3 == (ulong)31L || num3 == (ulong)44L)
				{
					return;
				}
			}
			else
			{
				while (collision == (ulong)3L)
				{
				}
			}
			return;
		}
	}

	// Token: 0x06001B37 RID: 6967 RVA: 0x00091E18 File Offset: 0x00090018
	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x54E100", Offset = "0x54C700", VA = "0x18054E100")]
	private bool CheckZombie(Zombie zombie)
	{
		int thePlantRow = this.thePlantRow;
		if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
		{
			ZombieStatus theStatus = zombie.theStatus;
			if (theStatus > ZombieStatus.Flying)
			{
				if (thePlantRow <= 8)
				{
				}
				if (theStatus == ZombieStatus.SnowMonster_jump || theStatus == ZombieStatus.Bungi_awake)
				{
					goto IL_0037;
				}
			}
			if (theStatus != ZombieStatus.Pol_jump)
			{
			}
		}
		IL_0037:
		throw new NullReferenceException();
	}

	// Token: 0x06001B38 RID: 6968 RVA: 0x00091E68 File Offset: 0x00090068
	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x54E1F0", Offset = "0x54C7F0", VA = "0x18054E1F0")]
	private Zombie DetectFirstZombie()
	{
		Transform shoot = this.shoot;
		int num = 0;
		Vector3 vector;
		float z = vector.z;
		int num2 = this.zombieLayer;
		RaycastHit2D[] array;
		if (num < array.Length)
		{
			Collider2D collider2D;
			if (collider2D.TryGetComponent<Zombie>(num))
			{
				int thePlantRow = this.thePlantRow;
				if (thePlantRow <= 8)
				{
				}
				num++;
				if (thePlantRow > 1)
				{
					Transform axis = this.axis;
				}
			}
			num++;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001B39 RID: 6969 RVA: 0x00091ED8 File Offset: 0x000900D8
	[Token(Token = "0x6001B39")]
	[Address(RVA = "0x54E1A0", Offset = "0x54C7A0", VA = "0x18054E1A0", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.Explode();
	}

	// Token: 0x06001B3A RID: 6970 RVA: 0x00091EF4 File Offset: 0x000900F4
	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x54E500", Offset = "0x54CB00", VA = "0x18054E500")]
	private void Explode()
	{
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		uint num;
		GameAPP.PlaySound((int)num, 0.5f, 1f);
		ScreenShake.TriggerShake(0.15f);
		Transform axis2 = this.axis;
		LayerMask zombieLayer = this.zombieLayer;
		Vector3 vector2;
		float z2 = vector2.z;
		int attackDamage = this.attackDamage;
		PlantType thePlantType = this.thePlantType;
		if (ThreeMine.<>c.<>9__14_0 == 0)
		{
			Action<Zombie> action;
			ThreeMine.<>c.<>9__14_0 = action;
		}
		long num2 = (long)(attackDamage * (int)((uint)180));
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)30L);
		this.invincible = false;
		anim.SetTrigger("down");
		Board board = this.board;
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001B3B RID: 6971 RVA: 0x00091FC4 File Offset: 0x000901C4
	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x54ED50", Offset = "0x54D350", VA = "0x18054ED50", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)12003));
		return BulletType.Bullet_potato_explode;
	}

	// Token: 0x06001B3C RID: 6972 RVA: 0x00091FE4 File Offset: 0x000901E4
	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ThreeMine()
	{
	}

	// Token: 0x04000F1C RID: 3868
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F1C")]
	private bool shooting;

	// Token: 0x04000F1D RID: 3869
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000F1D")]
	private float shootingTimer;

	// Token: 0x04000F1E RID: 3870
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F1E")]
	[SerializeField]
	private float shootingCD;
}
