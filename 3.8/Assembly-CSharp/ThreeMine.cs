using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200058F RID: 1423
[Token(Token = "0x200058F")]
public class ThreeMine : ThreePeater
{
	// Token: 0x06001A49 RID: 6729 RVA: 0x0008D74C File Offset: 0x0008B94C
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x4EFB20", Offset = "0x4EE120", VA = "0x1804EFB20", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)29L);
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x0008D774 File Offset: 0x0008B974
	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x4F0920", Offset = "0x4EEF20", VA = "0x1804F0920")]
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

	// Token: 0x06001A4B RID: 6731 RVA: 0x0008D7BC File Offset: 0x0008B9BC
	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x4F09A0", Offset = "0x4EEFA0", VA = "0x1804F09A0")]
	private void UpdateShootingTimer()
	{
		float num = this.shootingTimer;
		float deltaTime = Time.deltaTime;
		this.shootingTimer = num;
		this.shooting = false;
		this.shootingTimer = 0f;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x0008D7F4 File Offset: 0x0008B9F4
	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x4F09F0", Offset = "0x4EEFF0", VA = "0x1804F09F0", Slot = "16")]
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

	// Token: 0x06001A4D RID: 6733 RVA: 0x0008D878 File Offset: 0x0008BA78
	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x4F0900", Offset = "0x4EEF00", VA = "0x1804F0900", Slot = "45")]
	protected override void PlantShootUpdate()
	{
		if (!this.shooting)
		{
			base.PlantShootUpdate();
			return;
		}
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x0008D898 File Offset: 0x0008BA98
	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x4F0280", Offset = "0x4EE880", VA = "0x1804F0280", Slot = "17")]
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

	// Token: 0x06001A4F RID: 6735 RVA: 0x0008D9C0 File Offset: 0x0008BBC0
	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x4EFA30", Offset = "0x4EE030", VA = "0x1804EFA30", Slot = "40")]
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

	// Token: 0x06001A50 RID: 6736 RVA: 0x0008DA1C File Offset: 0x0008BC1C
	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x4F07E0", Offset = "0x4EEDE0", VA = "0x1804F07E0")]
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

	// Token: 0x06001A51 RID: 6737 RVA: 0x0008DA6C File Offset: 0x0008BC6C
	[Token(Token = "0x6001A51")]
	[Address(RVA = "0x4EFB60", Offset = "0x4EE160", VA = "0x1804EFB60")]
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

	// Token: 0x06001A52 RID: 6738 RVA: 0x0008DABC File Offset: 0x0008BCBC
	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x4EFC50", Offset = "0x4EE250", VA = "0x1804EFC50")]
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

	// Token: 0x06001A53 RID: 6739 RVA: 0x0008DB2C File Offset: 0x0008BD2C
	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x4EFC00", Offset = "0x4EE200", VA = "0x1804EFC00", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.Explode();
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x0008DB48 File Offset: 0x0008BD48
	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x4EFF60", Offset = "0x4EE560", VA = "0x1804EFF60")]
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

	// Token: 0x06001A55 RID: 6741 RVA: 0x0008DC18 File Offset: 0x0008BE18
	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x4F07B0", Offset = "0x4EEDB0", VA = "0x1804F07B0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)12003));
		return BulletType.Bullet_potato_explode;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x0008DC38 File Offset: 0x0008BE38
	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public ThreeMine()
	{
	}

	// Token: 0x04000E5D RID: 3677
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E5D")]
	private bool shooting;

	// Token: 0x04000E5E RID: 3678
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Token(Token = "0x4000E5E")]
	private float shootingTimer;

	// Token: 0x04000E5F RID: 3679
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E5F")]
	[SerializeField]
	private float shootingCD;
}
