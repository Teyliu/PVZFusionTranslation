using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005B9 RID: 1465
[Token(Token = "0x20005B9")]
public class UltimatePoisonFume : Shooter
{
	// Token: 0x06001B45 RID: 6981 RVA: 0x00092458 File Offset: 0x00090658
	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x5019D0", Offset = "0x4FFFD0", VA = "0x1805019D0", Slot = "10")]
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

	// Token: 0x06001B46 RID: 6982 RVA: 0x000924A4 File Offset: 0x000906A4
	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x501AE0", Offset = "0x5000E0", VA = "0x180501AE0", Slot = "45")]
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

	// Token: 0x06001B47 RID: 6983 RVA: 0x00092510 File Offset: 0x00090710
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x501AC0", Offset = "0x5000C0", VA = "0x180501AC0")]
	private void EnableParticle()
	{
	}

	// Token: 0x06001B48 RID: 6984 RVA: 0x00092520 File Offset: 0x00090720
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x501A90", Offset = "0x500090", VA = "0x180501A90")]
	private void DisableParticle()
	{
		this.attributeCount = (int)((ulong)0L);
	}

	// Token: 0x06001B49 RID: 6985 RVA: 0x00092538 File Offset: 0x00090738
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x501730", Offset = "0x4FFD30", VA = "0x180501730")]
	private void Attack2()
	{
		this.AttackZombie();
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00092550 File Offset: 0x00090750
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x501750", Offset = "0x4FFD50", VA = "0x180501750")]
	private void Attack3()
	{
		this.AttackZombie();
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00092568 File Offset: 0x00090768
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x501770", Offset = "0x4FFD70", VA = "0x180501770")]
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
						int currentFirstHealth = zombie.CurrentFirstHealth;
						float totalFirstHealth = zombie.TotalFirstHealth;
						float totalFirstHealth2 = zombie.TotalFirstHealth;
						PlantType thePlantType = this.thePlantType;
					}
				}
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x0009261C File Offset: 0x0009081C
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x501C10", Offset = "0x500210", VA = "0x180501C10", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Board board = this.board;
		Transform shoot = this.shoot;
		Transform shoot2 = this.shoot2;
		Bullet bullet;
		return bullet;
	}

	// Token: 0x06001B4D RID: 6989 RVA: 0x000926C4 File Offset: 0x000908C4
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public UltimatePoisonFume()
	{
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x000926D8 File Offset: 0x000908D8
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x502060", Offset = "0x500660", VA = "0x180502060")]
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

	// Token: 0x04000ED4 RID: 3796
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000ED4")]
	public ParticleSystem particle;

	// Token: 0x04000ED5 RID: 3797
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000ED5")]
	private ParticleSystem.EmissionModule emission;
}
