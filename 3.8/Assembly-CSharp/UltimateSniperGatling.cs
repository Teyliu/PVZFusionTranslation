using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x0200033B RID: 827
[Token(Token = "0x200033B")]
public class UltimateSniperGatling : Shooter
{
	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000584FC File Offset: 0x000566FC
	[Token(Token = "0x170000D4")]
	public override int LimDamage
	{
		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x42B670", Offset = "0x429C70", VA = "0x18042B670", Slot = "66")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0005850C File Offset: 0x0005670C
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x42DDF0", Offset = "0x42C3F0", VA = "0x18042DDF0", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x0005851C File Offset: 0x0005671C
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x42D3A0", Offset = "0x42B9A0", VA = "0x18042D3A0", Slot = "29")]
	protected override void ReplaceSprite()
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0005852C File Offset: 0x0005672C
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x42D610", Offset = "0x42BC10", VA = "0x18042D610", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		Board board = this.board;
		Vector3 vector;
		float z = vector.z;
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

	// Token: 0x06000F2A RID: 3882 RVA: 0x00058624 File Offset: 0x00056824
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x42D280", Offset = "0x42B880", VA = "0x18042D280")]
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

	// Token: 0x06000F2B RID: 3883 RVA: 0x0005868C File Offset: 0x0005688C
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x42DD40", Offset = "0x42C340", VA = "0x18042DD40")]
	private void SuperShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x000586AC File Offset: 0x000568AC
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x42D9E0", Offset = "0x42BFE0", VA = "0x18042D9E0", Slot = "70")]
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

	// Token: 0x06000F2D RID: 3885 RVA: 0x00058790 File Offset: 0x00056990
	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x42D3D0", Offset = "0x42B9D0", VA = "0x18042D3D0", Slot = "44")]
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

	// Token: 0x06000F2E RID: 3886 RVA: 0x0005880C File Offset: 0x00056A0C
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x42D390", Offset = "0x42B990", VA = "0x18042D390", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_chomper;
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00058820 File Offset: 0x00056A20
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimateSniperGatling()
	{
	}

	// Token: 0x04000B31 RID: 2865
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000B31")]
	public GameObject changeSprite;

	// Token: 0x04000B32 RID: 2866
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000B32")]
	public Transform shoot3;

	// Token: 0x04000B33 RID: 2867
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000B33")]
	private bool superShoot;

	// Token: 0x04000B34 RID: 2868
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000B34")]
	public Sprite wallnutSprite;
}
