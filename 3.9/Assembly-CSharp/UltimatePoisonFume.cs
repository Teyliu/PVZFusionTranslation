using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005EA RID: 1514
[Token(Token = "0x20005EA")]
public class UltimatePoisonFume : Shooter
{
	// Token: 0x06001C30 RID: 7216 RVA: 0x00096928 File Offset: 0x00094B28
	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x568840", Offset = "0x566E40", VA = "0x180568840", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup sortingGroup = this.particle.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		sortingGroup.sortingLayerName = "particle11";
		ParticleSystem.MainModule main = this.particle.main;
		this.emission = main;
		throw new NullReferenceException();
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x00096974 File Offset: 0x00094B74
	[Token(Token = "0x6001C31")]
	[Address(RVA = "0x568950", Offset = "0x566F50", VA = "0x180568950", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		Animator anim = this.anim;
		GameObject gameObject = base.SearchZombie();
		int num = 0;
		if (gameObject != num)
		{
		}
		Zombie zombie = base.SearchBoss();
		int num2 = 0;
		bool flag = zombie != num2;
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x000969E0 File Offset: 0x00094BE0
	[Token(Token = "0x6001C32")]
	[Address(RVA = "0x568930", Offset = "0x566F30", VA = "0x180568930")]
	private void EnableParticle()
	{
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000969F0 File Offset: 0x00094BF0
	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x568900", Offset = "0x566F00", VA = "0x180568900")]
	private void DisableParticle()
	{
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x00096A08 File Offset: 0x00094C08
	[Token(Token = "0x6001C34")]
	[Address(RVA = "0x568590", Offset = "0x566B90", VA = "0x180568590")]
	private void Attack2()
	{
		this.AttackZombie();
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x00096A20 File Offset: 0x00094C20
	[Token(Token = "0x6001C35")]
	[Address(RVA = "0x5685B0", Offset = "0x566BB0", VA = "0x1805685B0")]
	private void Attack3()
	{
		this.AttackZombie();
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x00096A38 File Offset: 0x00094C38
	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x5685D0", Offset = "0x566BD0", VA = "0x1805685D0")]
	private void AttackZombie()
	{
		int size = this.board.zombieArray._size;
		int num = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num];
			int num2 = 0;
			if (zombie != num2)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
				{
					Transform axis = zombie.axis;
					Transform axis2 = this.axis;
					if (Lawnf.InLandStatus(zombie.theStatus))
					{
						zombie.SetPoison(10f);
						long currentFirstHealth = zombie.CurrentFirstHealth;
						int num3 = 0;
						long totalFirstHealth = zombie.TotalFirstHealth;
						if (0 > num3)
						{
							long totalFirstHealth2 = zombie.TotalFirstHealth;
							PlantType thePlantType = this.thePlantType;
						}
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x00096AF4 File Offset: 0x00094CF4
	[Token(Token = "0x6001C37")]
	[Address(RVA = "0x568A80", Offset = "0x567080", VA = "0x180568A80", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Board board = this.board;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot2;
		Bullet bullet;
		return bullet;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x00096B9C File Offset: 0x00094D9C
	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public UltimatePoisonFume()
	{
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x00096BB0 File Offset: 0x00094DB0
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x568ED0", Offset = "0x5674D0", VA = "0x180568ED0")]
	[CompilerGenerated]
	private Bullet <Shoot1>g__Shoot|9_0(Vector2 v, BulletMoveWay m)
	{
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		return bullet;
	}

	// Token: 0x04000F93 RID: 3987
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F93")]
	public ParticleSystem particle;

	// Token: 0x04000F94 RID: 3988
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F94")]
	private ParticleSystem.EmissionModule emission;
}
