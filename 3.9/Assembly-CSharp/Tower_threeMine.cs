using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000614 RID: 1556
[Token(Token = "0x2000614")]
public class Tower_threeMine : TowerPlant
{
	// Token: 0x06001D45 RID: 7493 RVA: 0x0009B918 File Offset: 0x00099B18
	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x57BB00", Offset = "0x57A100", VA = "0x18057BB00", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.theStatus = (PlantStatus)((ulong)29L);
		base.AttributeCountdown = 15f;
		this.attributeFloat = 60f;
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x0009B94C File Offset: 0x00099B4C
	[Token(Token = "0x6001D46")]
	[Address(RVA = "0x57B660", Offset = "0x579C60", VA = "0x18057B660", Slot = "71")]
	public override void AnimShoot()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletMoveWay towardsMoveWay = base.TowardsMoveWay;
		int damage = base.Damage;
		Bullet bullet;
		bullet.Damage = damage;
		CreateBullet instance2 = CreateBullet.Instance;
		int damage2 = base.Damage;
		Bullet bullet2;
		bullet2.Damage = damage2;
		float num = bullet2.normalSpeed * -1f;
		bullet2.normalSpeed = num;
		int rowNum = this.board.rowNum;
		CreateBullet instance3 = CreateBullet.Instance;
		BulletMoveWay towardsMoveWay2 = base.TowardsMoveWay;
		int damage3 = base.Damage;
		Bullet bullet3;
		bullet3.Damage = damage3;
		int num2 = this.thePlantRow;
		num2++;
		int damage4 = base.Damage;
		Bullet bullet4;
		bullet4.Damage = damage4;
		float num3 = bullet4.normalSpeed * -1f;
		bullet4.normalSpeed = num3;
		CreateBullet instance4 = CreateBullet.Instance;
		BulletMoveWay towardsMoveWay3 = base.TowardsMoveWay;
		int damage5 = base.Damage;
		Bullet bullet5;
		bullet5.Damage = damage5;
		GameAPP.PlaySound(damage5, 0.5f, 1f);
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x0009BA50 File Offset: 0x00099C50
	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x57CB90", Offset = "0x57B190", VA = "0x18057CB90", Slot = "73")]
	public override void Upgrade(TowerUpgradeType towerUpgradeType)
	{
		float basicDamage = this.basicDamage;
		this.basicDamage = basicDamage;
		base.Upgrade(towerUpgradeType);
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x0009BA74 File Offset: 0x00099C74
	[Token(Token = "0x6001D48")]
	[Address(RVA = "0x57CAB0", Offset = "0x57B0B0", VA = "0x18057CAB0", Slot = "16")]
	protected override void Update()
	{
		base.Update();
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
				this.shootingTimer = num;
				this.shooting = false;
				this.shootingTimer = 0f;
			}
		}
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x0009BAFC File Offset: 0x00099CFC
	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x57CA00", Offset = "0x57B000", VA = "0x18057CA00")]
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

	// Token: 0x06001D4A RID: 7498 RVA: 0x0009BB78 File Offset: 0x00099D78
	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x57C9C0", Offset = "0x57AFC0", VA = "0x18057C9C0", Slot = "46")]
	protected override bool Shootable()
	{
		return base.Shootable() && !this.shooting;
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x0009BB9C File Offset: 0x00099D9C
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x57C440", Offset = "0x57AA40", VA = "0x18057C440", Slot = "17")]
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
			BulletMoveWay towardsMoveWay = base.TowardsMoveWay;
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

	// Token: 0x06001D4C RID: 7500 RVA: 0x0009BCD8 File Offset: 0x00099ED8
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x57BA10", Offset = "0x57A010", VA = "0x18057BA10", Slot = "39")]
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

	// Token: 0x06001D4D RID: 7501 RVA: 0x0009BD2C File Offset: 0x00099F2C
	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x57C910", Offset = "0x57AF10", VA = "0x18057C910")]
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

	// Token: 0x06001D4E RID: 7502 RVA: 0x0009BD58 File Offset: 0x00099F58
	[Token(Token = "0x6001D4E")]
	[Address(RVA = "0x57BD20", Offset = "0x57A320", VA = "0x18057BD20", Slot = "72")]
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

	// Token: 0x06001D4F RID: 7503 RVA: 0x0009BDA8 File Offset: 0x00099FA8
	[Token(Token = "0x6001D4F")]
	[Address(RVA = "0x57BB40", Offset = "0x57A140", VA = "0x18057BB40", Slot = "69")]
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

	// Token: 0x06001D50 RID: 7504 RVA: 0x0009BE00 File Offset: 0x0009A000
	[Token(Token = "0x6001D50")]
	[Address(RVA = "0x57BEB0", Offset = "0x57A4B0", VA = "0x18057BEB0")]
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

	// Token: 0x06001D51 RID: 7505 RVA: 0x0009BE64 File Offset: 0x0009A064
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x57BE60", Offset = "0x57A460", VA = "0x18057BE60", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
		this.isCrashed = true;
		this.Explode();
	}

	// Token: 0x06001D52 RID: 7506 RVA: 0x0009BE80 File Offset: 0x0009A080
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x57C140", Offset = "0x57A740", VA = "0x18057C140")]
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

	// Token: 0x06001D53 RID: 7507 RVA: 0x0009BF3C File Offset: 0x0009A13C
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x578AF0", Offset = "0x5770F0", VA = "0x180578AF0")]
	public Tower_threeMine()
	{
	}

	// Token: 0x04000FD7 RID: 4055
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000FD7")]
	private bool shooting;

	// Token: 0x04000FD8 RID: 4056
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Token(Token = "0x4000FD8")]
	private float shootingTimer;

	// Token: 0x04000FD9 RID: 4057
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000FD9")]
	private float shootingCD;
}
