using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DF RID: 1503
[Token(Token = "0x20005DF")]
public class Tower_threeMine : TowerPlant
{
	// Token: 0x06001C46 RID: 7238 RVA: 0x00096DB4 File Offset: 0x00094FB4
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x514210", Offset = "0x512810", VA = "0x180514210", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetSpeed(1f);
		this.theStatus = (PlantStatus)((ulong)29L);
		base.AttributeCountdown = 15f;
		this.attributeFloat = 60f;
	}

	// Token: 0x06001C47 RID: 7239 RVA: 0x00096DF4 File Offset: 0x00094FF4
	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x513D50", Offset = "0x512350", VA = "0x180513D50", Slot = "72")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float num = bullet.normalSpeed * -1f;
		bullet.normalSpeed = num;
		int rowNum = this.board.rowNum;
		CreateBullet instance2 = CreateBullet.Instance;
		float num2 = num * this.basicDamage;
		int num3 = this.thePlantRow;
		num3++;
		Bullet bullet2;
		float num4 = bullet2.normalSpeed * -1f;
		bullet2.normalSpeed = num4;
		CreateBullet instance3 = CreateBullet.Instance;
	}

	// Token: 0x06001C48 RID: 7240 RVA: 0x00096E80 File Offset: 0x00095080
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x5152E0", Offset = "0x5138E0", VA = "0x1805152E0", Slot = "74")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x00096EA4 File Offset: 0x000950A4
	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x5151D0", Offset = "0x5137D0", VA = "0x1805151D0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		if (base.Active)
		{
			base.ShootUpdate();
		}
		if (base.Active)
		{
			float num = this.shootingTimer;
			int num2 = 0;
			if (num <= (float)num2)
			{
				float num3 = this.shootingCD;
				float deltaTime = Time.deltaTime;
				this.shootingCD = num3;
				if (num2 > (int)num3)
				{
					float attributeFloat = this.attributeFloat;
					this.shootingCD = attributeFloat;
					this.shootingTimer = 5f;
					this.shooting = true;
					return;
				}
			}
			else
			{
				float deltaTime2 = Time.deltaTime;
				float deltaTime;
				this.shootingTimer = deltaTime;
				this.shooting = false;
				this.shootingTimer = 0f;
			}
		}
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x00096F3C File Offset: 0x0009513C
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x515120", Offset = "0x513720", VA = "0x180515120")]
	private void SuperUpdate()
	{
		float num = this.shootingTimer;
		int num2 = 0;
		if (num <= (float)num2)
		{
			float num3 = this.shootingCD;
			float deltaTime = Time.deltaTime;
			this.shootingCD = num3;
			if (num2 > (int)num3)
			{
				float attributeFloat = this.attributeFloat;
				this.shootingCD = attributeFloat;
				this.shootingTimer = 5f;
				this.shooting = true;
				return;
			}
		}
		else
		{
			float deltaTime2 = Time.deltaTime;
			this.shootingTimer = num;
			this.shooting = false;
			this.shootingTimer = 0f;
		}
	}

	// Token: 0x06001C4B RID: 7243 RVA: 0x00096FB8 File Offset: 0x000951B8
	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x5150D0", Offset = "0x5136D0", VA = "0x1805150D0", Slot = "47")]
	protected override bool Shootable()
	{
		if (base.Shootable() || this.CheckGrave())
		{
		}
		return !this.shooting;
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x00096FE4 File Offset: 0x000951E4
	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x514B60", Offset = "0x513160", VA = "0x180514B60", Slot = "17")]
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
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = attackDamage;
			float num5 = this.shootingTimer * 3.1415927f * 45f;
			Transform shoot3 = this.shoot;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform shoot4 = this.shoot;
			int attackDamage2 = this.attackDamage;
			Bullet bullet2;
			bullet2.Damage = attackDamage2;
			Transform transform = bullet2.transform;
			float num6 = num5 * 0.017453292f;
			Transform shoot5 = this.shoot;
			CreateBullet instance3 = CreateBullet.Instance;
			Transform shoot6 = this.shoot;
			int attackDamage3 = this.attackDamage;
			Bullet bullet3;
			bullet3.Damage = attackDamage3;
			Transform transform2 = bullet3.transform;
			float num7 = num5 * 0.017453292f;
			Quaternion quaternion;
			GameAPP.PlaySound((int)quaternion.x, 0.5f, 1f);
		}
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x00097118 File Offset: 0x00095318
	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x514120", Offset = "0x512720", VA = "0x180514120", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.anim.SetTrigger("rise");
		this.theStatus = (PlantStatus)((ulong)30L);
		this.invincible = true;
		GameAPP.PlaySound(48, 0.5f, 1f);
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x0009716C File Offset: 0x0009536C
	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x515020", Offset = "0x513620", VA = "0x180515020")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2;
			if (flag2)
			{
				this.Explode();
			}
		}
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x00097198 File Offset: 0x00095398
	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x514440", Offset = "0x512A40", VA = "0x180514440", Slot = "73")]
	protected override bool CheckZombie(Zombie zombie)
	{
		int theZombieRow = zombie.theZombieRow;
		if (base.SearchUniqueZombie(zombie))
		{
			Transform axis = zombie.axis;
			Transform axis2 = this.axis;
			Transform axis3 = zombie.axis;
			Transform axis4 = this.axis;
			Vector3 vector;
			return vector != 0;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000971E8 File Offset: 0x000953E8
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x514260", Offset = "0x512860", VA = "0x180514260", Slot = "70")]
	protected override bool CheckGrave()
	{
		ulong num3;
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
				int thePlantColumn = this.thePlantColumn;
				int thePlantColumn2 = this.thePlantColumn;
			}
		}
		while (num3 != (ulong)0L);
		throw new NullReferenceException();
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x00097240 File Offset: 0x00095440
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x5145D0", Offset = "0x512BD0", VA = "0x1805145D0")]
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
			if (collider2D.TryGetComponent<Zombie>(num) && this.CheckZombie(num))
			{
				Transform axis = this.axis;
			}
			num++;
		}
		throw new IndexOutOfRangeException();
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x000972A4 File Offset: 0x000954A4
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x514580", Offset = "0x512B80", VA = "0x180514580", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.Explode();
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x000972C0 File Offset: 0x000954C0
	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x514860", Offset = "0x512E60", VA = "0x180514860")]
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
		if (Tower_threeMine.<>c.<>9__16_0 == 0)
		{
			Action<Zombie> action;
			Tower_threeMine.<>c.<>9__16_0 = action;
		}
		long num2 = (long)(attackDamage * (int)((uint)270));
		Animator anim = this.anim;
		this.theStatus = (PlantStatus)((ulong)30L);
		this.invincible = false;
		anim.SetTrigger("down");
		base.AttributeCountdown = 15f;
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x0009737C File Offset: 0x0009557C
	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x50C640", Offset = "0x50AC40", VA = "0x18050C640")]
	public Tower_threeMine()
	{
		this.towards = (Towards)((ulong)1L);
		this.basicDamage = 1f;
		this.attackSpeed = 1f;
		base..ctor();
	}

	// Token: 0x04000F0F RID: 3855
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F0F")]
	private bool shooting;

	// Token: 0x04000F10 RID: 3856
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000F10")]
	private float shootingTimer;

	// Token: 0x04000F11 RID: 3857
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F11")]
	private float shootingCD;
}
