using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x0200034B RID: 843
[Token(Token = "0x200034B")]
public class UltimateSniperGatling : Shooter
{
	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000F71 RID: 3953 RVA: 0x000594A4 File Offset: 0x000576A4
	[Token(Token = "0x17000116")]
	public override int LimDamage
	{
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x46C280", Offset = "0x46A880", VA = "0x18046C280", Slot = "65")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x000594B4 File Offset: 0x000576B4
	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x484C70", Offset = "0x483270", VA = "0x180484C70", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x000594C4 File Offset: 0x000576C4
	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x484220", Offset = "0x482820", VA = "0x180484220", Slot = "28")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x000594D4 File Offset: 0x000576D4
	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x484490", Offset = "0x482A90", VA = "0x180484490", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
		Func<Zombie, bool> func = new Func(this.CheckZombie);
		int num = 0;
		Zombie zombie;
		if (!(zombie == num))
		{
			this.targetZombie = zombie;
			Collider2D col = zombie.col;
			Transform shoot2 = this.shoot;
			Vector3 vector2;
			float z2 = vector2.z;
			int theZombieRow = zombie.theZombieRow;
			int thePlantRow = this.thePlantRow;
			Board board2 = this.board;
			if (thePlantRow <= theZombieRow)
			{
			}
			Transform transform = board2.transform;
			CancellationToken cancellationTokenOnDestroy = this.board.GetCancellationTokenOnDestroy();
			int num2 = this.attributeCount;
			num2++;
			this.attributeCount = num2;
			PlantType thePlantType = this.thePlantType;
			uint num3;
			if (num2 < (int)num3)
			{
				this.superShoot = false;
			}
			this.attributeCount = (int)((ulong)0L);
			this.superShoot = true;
			uint num4;
			GameAPP.PlaySound((int)num4, 0.2f, 1f);
			this.anim.SetTrigger("shoot2");
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x000595D8 File Offset: 0x000577D8
	[Token(Token = "0x6000F75")]
	[Address(RVA = "0x484100", Offset = "0x482700", VA = "0x180484100")]
	private bool CheckZombie(Zombie zombie)
	{
		Transform axis = zombie.axis;
		Transform shoot = this.shoot;
		if ((Lawnf.InLandStatus(zombie.theStatus) || zombie.theStatus == ZombieStatus.Flying) && zombie.Alive)
		{
			Collider2D col = zombie.col;
			int num = 0;
			if (col != num)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				bool flag;
				return flag;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x00059640 File Offset: 0x00057840
	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x484BC0", Offset = "0x4831C0", VA = "0x180484BC0")]
	private void SuperShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00059660 File Offset: 0x00057860
	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x484860", Offset = "0x482E60", VA = "0x180484860", Slot = "69")]
	protected override Bullet Shoot2()
	{
		if (!this.superShoot)
		{
			Transform shoot = this.shoot2;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot2;
			BulletType bulletType = this.GetBulletType();
			int attackDamage = this.attackDamage;
			Bullet bullet;
			bullet.Damage = 0;
			PlantType thePlantType = this.thePlantType;
			bullet.fromType = thePlantType;
			Zombie targetZombie = this.targetZombie;
			bullet.targetZombie = targetZombie;
			Transform transform = this.shoot3;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform transform2 = this.shoot3;
			BulletType bulletType2 = this.GetBulletType();
			int attackDamage2 = this.attackDamage;
			PlantType thePlantType2 = this.thePlantType;
			Bullet bullet2;
			bullet2.fromType = thePlantType2;
			Zombie targetZombie2 = this.targetZombie;
			bullet2.targetZombie = targetZombie2;
			GameAPP.PlaySound(attackDamage2, 0.5f, 1f);
		}
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		throw new NullReferenceException();
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00059744 File Offset: 0x00057944
	[Token(Token = "0x6000F78")]
	[Address(RVA = "0x484250", Offset = "0x482850", VA = "0x180484250", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		for (;;)
		{
			int num = 0;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					Team <Team>k__BackingField = this.<Team>k__BackingField;
					float vision = this.vision;
					Transform axis = this.axis;
					if (base.SearchUniqueZombie(num))
					{
						break;
					}
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		GameObject gameObject;
		return gameObject;
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x000597C0 File Offset: 0x000579C0
	[Token(Token = "0x6000F79")]
	[Address(RVA = "0x484210", Offset = "0x482810", VA = "0x180484210", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_chomper;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x000597D4 File Offset: 0x000579D4
	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimateSniperGatling()
	{
	}

	// Token: 0x04000B82 RID: 2946
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B82")]
	public GameObject changeSprite;

	// Token: 0x04000B83 RID: 2947
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B83")]
	public Transform shoot3;

	// Token: 0x04000B84 RID: 2948
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B84")]
	private bool superShoot;

	// Token: 0x04000B85 RID: 2949
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B85")]
	public Sprite wallnutSprite;
}
