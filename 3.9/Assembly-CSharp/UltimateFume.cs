using System;
using System.Collections;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020005DA RID: 1498
[Token(Token = "0x20005DA")]
public class UltimateFume : IceDoomFume
{
	// Token: 0x06001BCB RID: 7115 RVA: 0x000947D4 File Offset: 0x000929D4
	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x55A620", Offset = "0x558C20", VA = "0x18055A620", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SortingGroup sortingGroup = this.particle.AddComponent<SortingGroup>();
		sortingGroup.sortAtRoot = true;
		sortingGroup.sortingLayerName = "particle11";
		SortingGroup sortingGroup2 = this.particle2.AddComponent<SortingGroup>();
		sortingGroup2.sortAtRoot = true;
		sortingGroup2.sortingLayerName = "particle11";
		ParticleSystem.MainModule main = this.particle.main;
		this.emission = main;
		ParticleSystem.MainModule main2 = this.particle2.main;
		this.emission2 = main2;
		throw new NullReferenceException();
	}

	// Token: 0x06001BCC RID: 7116 RVA: 0x00094850 File Offset: 0x00092A50
	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x55A810", Offset = "0x558E10", VA = "0x18055A810", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		Animator anim = this.anim;
		GameObject gameObject = this.SearchZombie();
		int num = 0;
		if (gameObject != num)
		{
		}
		Zombie zombie = base.SearchBoss();
		int num2 = 0;
		bool flag = zombie != num2;
		anim.SetBool("shooting", flag);
	}

	// Token: 0x06001BCD RID: 7117 RVA: 0x000948BC File Offset: 0x00092ABC
	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x55A940", Offset = "0x558F40", VA = "0x18055A940", Slot = "43")]
	protected override GameObject SearchZombie()
	{
		return base.SearchZombie();
	}

	// Token: 0x06001BCE RID: 7118 RVA: 0x00094930 File Offset: 0x00092B30
	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x55A770", Offset = "0x558D70", VA = "0x18055A770")]
	private void EnableParticle()
	{
	}

	// Token: 0x06001BCF RID: 7119 RVA: 0x00094940 File Offset: 0x00092B40
	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x55A740", Offset = "0x558D40", VA = "0x18055A740")]
	private void DisableParticle()
	{
	}

	// Token: 0x06001BD0 RID: 7120 RVA: 0x00094950 File Offset: 0x00092B50
	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x55A1C0", Offset = "0x5587C0", VA = "0x18055A1C0")]
	private void AttackZombie2()
	{
		if (Lawnf.TravelUltimate((UltiBuff)((uint)4)))
		{
			this.AttackZombie();
			return;
		}
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00094970 File Offset: 0x00092B70
	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x55A1F0", Offset = "0x5587F0", VA = "0x18055A1F0")]
	private void AttackZombie()
	{
		int num = 0;
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		float num2 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		Transform shoot2 = this.shoot;
		float num3 = global::UnityEngine.Random.Range(-0.2f, 0.2f);
		PlantType thePlantType = this.thePlantType;
		num++;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int size = this.board.zombieArray._size;
		int num4 = size - 1;
		if (size > 0)
		{
			Zombie zombie = this.board.zombieArray[num4];
			int num5 = 0;
			if (zombie != num5)
			{
				int thePlantRow = this.thePlantRow;
				if (zombie.theZombieRow == thePlantRow && !zombie.isMindControlled)
				{
					Transform axis = zombie.axis;
					Transform axis2 = this.axis;
					if (Lawnf.InLandStatus(zombie.theStatus))
					{
						PlantType thePlantType2 = this.thePlantType;
						int num6 = 0;
						zombie.AddfreezeLevel(20, num6);
						this.TrySetMindControl(zombie);
					}
				}
			}
			if ((ulong)1L != 0UL)
			{
				int num7 = global::UnityEngine.Random.Range(0, 3);
				GameAPP.PlaySound(num7, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00094AA8 File Offset: 0x00092CA8
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x55AEA0", Offset = "0x5594A0", VA = "0x18055AEA0")]
	private IEnumerator StarAttack()
	{
		int num;
		UltimateFume.<StarAttack>d__11 <StarAttack>d__ = new UltimateFume.<StarAttack>d__11(num);
		num = 0;
		<StarAttack>d__.<>4__this = this;
		throw new NullReferenceException();
	}

	// Token: 0x06001BD3 RID: 7123 RVA: 0x00094ACC File Offset: 0x00092CCC
	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x55A7A0", Offset = "0x558DA0", VA = "0x18055A7A0", Slot = "56")]
	protected override bool OnStarUp()
	{
		Animator anim = this.anim;
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.thePlantAttackCountDown = thePlantAttackInterval;
		int num = 0;
		anim.SetBool("shooting", num != 0);
		return true;
	}

	// Token: 0x06001BD4 RID: 7124 RVA: 0x00094B08 File Offset: 0x00092D08
	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x55AF10", Offset = "0x559510", VA = "0x18055AF10")]
	private void TrySetMindControl(Zombie zombie)
	{
		if (zombie <= 0)
		{
		}
		float value = global::UnityEngine.Random.value;
		if (zombie <= 0)
		{
		}
		int num = 0;
		zombie.SetMindControl(num);
		this.SmallDoom(zombie);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		if (zombie.isMindControlled && zombie.BoxType != BoxType.Water)
		{
			CreateZombie instance = CreateZombie.Instance;
			Transform axis = zombie.axis;
			bool flag;
			bool flag2;
			if (!flag || flag2)
			{
			}
			uint num3;
			zombie.Die((int)num3);
		}
	}

	// Token: 0x06001BD5 RID: 7125 RVA: 0x00094B84 File Offset: 0x00092D84
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x55AC50", Offset = "0x559250", VA = "0x18055AC50")]
	private void SmallDoom(Zombie z)
	{
		Transform axis = z.axis;
		Vector3 vector;
		float z2 = vector.z;
		int num = this.zombieLayer;
		int num2 = 0;
		int num3 = 0;
		Collider2D[] array;
		if (num2 < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus(z.theStatus))
			{
				int theZombieRow = z.theZombieRow;
				PlantType thePlantType = this.thePlantType;
			}
			num3++;
		}
		Transform axis2 = z.axis;
		ParticleManager instance = ParticleManager.Instance;
	}

	// Token: 0x06001BD6 RID: 7126 RVA: 0x00094C04 File Offset: 0x00092E04
	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateFume()
	{
	}

	// Token: 0x04000F61 RID: 3937
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000F61")]
	public ParticleSystem particle;

	// Token: 0x04000F62 RID: 3938
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000F62")]
	public ParticleSystem particle2;

	// Token: 0x04000F63 RID: 3939
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000F63")]
	private ParticleSystem.EmissionModule emission;

	// Token: 0x04000F64 RID: 3940
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000F64")]
	private ParticleSystem.EmissionModule emission2;
}
