using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E0 RID: 1248
[Token(Token = "0x20004E0")]
public class AbyssSwordStar : SwordStarfruit
{
	// Token: 0x06001788 RID: 6024 RVA: 0x000809D8 File Offset: 0x0007EBD8
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x506FF0", Offset = "0x5055F0", VA = "0x180506FF0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		if (!global::Lawnf.TravelAdvanced((AdvBuff)((uint)5002)))
		{
			AbyssSwordStar instance = AbyssSwordStar.Instance;
			int num = 0;
			if (instance != num)
			{
				AbyssSwordStar instance2 = AbyssSwordStar.Instance;
				int num2 = 0;
				instance2.Die((Plant.DieReason)num2);
				InGameText instance3 = InGameText.Instance;
			}
			AbyssSwordStar.Instance = this;
		}
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00080A34 File Offset: 0x0007EC34
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x507D70", Offset = "0x506370", VA = "0x180507D70", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		Board board = this.board;
		this.anim.Play("idle2");
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x00080A68 File Offset: 0x0007EC68
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x5075C0", Offset = "0x505BC0", VA = "0x1805075C0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (base.Shootable())
		{
			Board board = this.board;
			string text;
			this.anim.SetTrigger(text);
			return;
		}
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00080AB8 File Offset: 0x0007ECB8
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x5076B0", Offset = "0x505CB0", VA = "0x1805076B0")]
	public void SetStatus(PlantStatus plantStatus)
	{
		this.theStatus = plantStatus;
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x00080ACC File Offset: 0x0007ECCC
	[Token(Token = "0x600178C")]
	[Address(RVA = "0x5076C0", Offset = "0x505CC0", VA = "0x1805076C0")]
	private void SetSwords()
	{
		int num = this.attributeCount;
		int num2 = 0;
		num++;
		if (num > 0)
		{
			GameObject gameObject = this.bigSwordPrefab;
			float num3 = global::UnityEngine.Random.Range(-3f, 8f);
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			Transform transform = this.board.transform;
			GameObject gameObject2;
			BigSword component = gameObject2.GetComponent<BigSword>();
			int size = this.bigSwords._size;
			component.targetPosition = component;
			component.plant = this;
			Action<Vector2> action;
			component.action = action;
			int num4 = this.attributeCount;
			num2++;
			num4++;
		}
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x00080B60 File Offset: 0x0007ED60
	[Token(Token = "0x600178D")]
	[Address(RVA = "0x507300", Offset = "0x505900", VA = "0x180507300", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		int num = 0;
		int num2 = 0;
		base.OnFixedUpdate();
		Board board = this.board;
		num2 += num2;
		Transform shoot = this.shoot;
		int num3 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag)
			{
				goto IL_0060;
			}
			int num4 = 0;
			if (num4 > 12)
			{
				if (18446744073709551600UL <= (ulong)8L)
				{
				}
				if (num4 != 44)
				{
					PlantType thePlantType = this.thePlantType;
					int num5 = num.System.IConvertible.ToInt32(num4);
					goto IL_0060;
				}
				goto IL_0060;
			}
			IL_0064:
			while (flag > true)
			{
			}
			return;
			IL_0060:
			num++;
			goto IL_0064;
		}
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x00080BE0 File Offset: 0x0007EDE0
	[Token(Token = "0x600178E")]
	[Address(RVA = "0x507250", Offset = "0x505850", VA = "0x180507250")]
	public bool CheckStatus(Zombie zombie)
	{
		ZombieStatus theStatus = zombie.theStatus;
		if (theStatus <= ZombieStatus.Miner_digging || theStatus == ZombieStatus.Bungi_awake)
		{
			while (theStatus == ZombieStatus.Pol_jump)
			{
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x00080C0C File Offset: 0x0007EE0C
	[Token(Token = "0x600178F")]
	[Address(RVA = "0x506DB0", Offset = "0x5053B0", VA = "0x180506DB0")]
	private void AttackZombie(Vector2 position)
	{
		LayerMask zombieLayer = this.zombieLayer;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
			}
			num2++;
		}
		float num3 = global::UnityEngine.Random.Range(1.2f, 1.4f);
		uint num4;
		GameAPP.PlaySound((int)num4, 0.5f, num3);
		ParticleManager instance = ParticleManager.Instance;
		Mouse instance2 = Mouse.Instance;
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x00080C7C File Offset: 0x0007EE7C
	[Token(Token = "0x6001790")]
	[Address(RVA = "0x507990", Offset = "0x505F90", VA = "0x180507990", Slot = "68")]
	protected override Bullet Shoot1()
	{
		bool flag;
		if (flag)
		{
			uint num;
			uint num2;
			GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
			int num3 = this.attributeCount;
			int num4 = 0;
			num3++;
			Transform shoot = this.shoot;
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot2 = this.shoot;
			PlantType thePlantType = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType;
			int num5 = this.attackDamage;
			num5 -= shoot2;
			bullet.Damage = num5;
			float normalSpeed = bullet.normalSpeed;
			bullet.normalSpeed = normalSpeed;
			Transform transform = bullet.transform;
			Transform transform2 = bullet.transform;
			num4++;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00080D34 File Offset: 0x0007EF34
	[Token(Token = "0x6001791")]
	[Address(RVA = "0x507170", Offset = "0x505770", VA = "0x180507170")]
	private void BulletUpdate(Bullet bullet)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x00080D58 File Offset: 0x0007EF58
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x507DE0", Offset = "0x5063E0", VA = "0x180507DE0")]
	public AbyssSwordStar()
	{
		List<BigSword> list = new List();
		this.bigSwords = list;
		base..ctor();
	}

	// Token: 0x04000E3E RID: 3646
	[Token(Token = "0x4000E3E")]
	public static AbyssSwordStar Instance;

	// Token: 0x04000E3F RID: 3647
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E3F")]
	private readonly List<BigSword> bigSwords;

	// Token: 0x04000E40 RID: 3648
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E40")]
	public GameObject bigSwordPrefab;
}
