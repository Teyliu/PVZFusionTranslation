using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200069E RID: 1694
[Token(Token = "0x200069E")]
public class FootballBoss : Zombie
{
	// Token: 0x0600203B RID: 8251 RVA: 0x000AAAA8 File Offset: 0x000A8CA8
	[Token(Token = "0x600203B")]
	[Address(RVA = "0x5A9A60", Offset = "0x5A8060", VA = "0x1805A9A60", Slot = "16")]
	protected override void Start()
	{
		base.Start();
		this.anim.Play("enter");
		this.theStatus = (ZombieStatus)((ulong)43L);
		this.theZombieRow = (int)((ulong)1L);
		int rowNum = this.board.rowNum;
		int rowNum2 = this.board.rowNum;
		this.theZombieRow = rowNum2;
		int theZombieRow = this.theZombieRow;
		SortingGroup sortingGroup = this.sortingGroup;
		string text = string.Format("zombie{0}", theZombieRow);
		sortingGroup.sortingLayerName = text;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Mouse instance = Mouse.Instance;
		int theZombieRow2 = this.theZombieRow;
		float landY = instance.GetLandY(boxXFromColumn, theZombieRow2);
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000AAB58 File Offset: 0x000A8D58
	[Token(Token = "0x600203C")]
	[Address(RVA = "0x5A8E20", Offset = "0x5A7420", VA = "0x1805A8E20", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.SetMindControl(num);
		this.towards = (Towards)((ulong)0L);
		Transform transform = base.transform;
		int num2 = 0;
		base.ChangeStatus((ZombieStatus)num2);
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000AAB94 File Offset: 0x000A8D94
	[Token(Token = "0x600203D")]
	[Address(RVA = "0x5A91A0", Offset = "0x5A77A0", VA = "0x1805A91A0", Slot = "23")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		float attributeCountDown = this.attributeCountDown;
		int num = 0;
		if (attributeCountDown <= (float)num)
		{
			int column = base.Column;
			if (base.Alive)
			{
				Transform transform = this.roll;
				ParticleManager instance = ParticleManager.Instance;
				int num2 = 0;
				ulong num3;
				Particle particle = instance.SetParticle(ParticleType.RandomCloud, num2, 11, num3 != 0UL, (float)num);
				base.ChangeStatus((ZombieStatus)((uint)43));
				this.anim.SetTrigger("jump");
			}
			return;
		}
		if (base.Column > 1)
		{
			int column2 = base.Column;
			int num4 = 0;
			int num5 = 0;
			base.Garliced(num5 != 0, num4 != 0);
			ShootingManager instance2 = ShootingManager.Instance;
			int num6 = 0;
			if (instance2 != num6)
			{
				ShootingManager instance3 = ShootingManager.Instance;
				int num7 = 0;
				instance3.BossSpawn(num7);
			}
			this.towards = (Towards)((ulong)0L);
			Transform transform2 = base.transform;
		}
		int num8 = 0;
		int num9 = 0;
		base.Garliced(num9 != 0, num8 != 0);
		ShootingManager instance4 = ShootingManager.Instance;
		int num10 = 0;
		if (instance4 != num10)
		{
			ShootingManager instance5 = ShootingManager.Instance;
			int num11 = 0;
			instance5.BossSpawn(num11);
		}
		this.towards = (Towards)((ulong)1L);
		Transform transform3 = base.transform;
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000AACB0 File Offset: 0x000A8EB0
	[Token(Token = "0x600203E")]
	[Address(RVA = "0x5A8B30", Offset = "0x5A7130", VA = "0x1805A8B30")]
	private void AnimJump()
	{
		List<int> list = new List();
		Board board = this.board;
		int num = 0;
		int num2 = 0;
		if (num < board.rowNum)
		{
			int size = list._size;
			BoxType[] roadType = board.roadType;
			list._size = board;
			Board board2 = this.board;
			num2++;
		}
		int size2 = list._size;
		int num3 = size2 - 1;
		if (size2 > 0)
		{
			BoxType[] roadType2 = this.board.roadType;
			list.RemoveAt(num3);
		}
		Mouse instance = Mouse.Instance;
		Board board3 = this.board;
		int num4 = 0;
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(global::UnityEngine.Random.Range(-4, num4));
		int random = ListExtensions.GetRandom<int>(list);
		ulong num5;
		bool flag = instance.MoveZombie(this, boxXFromColumn, random, num5 != 0UL);
		Animator anim = this.anim;
		if (flag)
		{
			anim.Play("enter2");
			float num6 = global::UnityEngine.Random.Range(10f, 20f);
			this.attributeCountDown = num6;
			return;
		}
		anim.Play("enter");
		throw new NullReferenceException();
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000AADAC File Offset: 0x000A8FAC
	[Token(Token = "0x600203F")]
	[Address(RVA = "0x5A9070", Offset = "0x5A7670", VA = "0x1805A9070")]
	private void FlagUpdate(Transform flag, int row)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000AADD0 File Offset: 0x000A8FD0
	[Token(Token = "0x6002040")]
	[Address(RVA = "0x5A88F0", Offset = "0x5A6EF0", VA = "0x1805A88F0")]
	private void AnimFlagLand()
	{
		Transform transform = this.flag1;
		Transform parent = transform.transform.parent;
		Transform transform2 = global::UnityEngine.Object.Instantiate<Transform>(transform, parent);
		Transform transform3 = this.flag2;
		Transform parent2 = transform3.transform.parent;
		Transform transform4 = global::UnityEngine.Object.Instantiate<Transform>(transform3, parent2);
		Transform transform5 = this.flag3;
		Transform parent3 = transform5.transform.parent;
		Transform transform6 = global::UnityEngine.Object.Instantiate<Transform>(transform5, parent3);
		Transform transform7 = transform2.transform;
		Transform transform8 = this.board.transform;
		transform7.parentInternal = transform8;
		Transform transform9 = transform4.transform;
		Transform transform10 = this.board.transform;
		transform9.parentInternal = transform10;
		Transform transform11 = transform6.transform;
		Transform transform12 = this.board.transform;
		transform11.parentInternal = transform12;
		int theZombieRow = this.theZombieRow;
		int num = theZombieRow - 1;
		this.FlagUpdate(transform2, num);
		num = theZombieRow;
		this.FlagUpdate(transform4, num);
		int num2 = theZombieRow + 1;
		this.FlagUpdate(transform6, num2);
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x000AAED0 File Offset: 0x000A90D0
	[Token(Token = "0x6002041")]
	[Address(RVA = "0x5A94B0", Offset = "0x5A7AB0", VA = "0x1805A94B0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num;
		for (;;)
		{
			num = 0;
			if (collision.TryGetComponent<Plant>(num))
			{
				break;
			}
			if (collision.TryGetComponent<Zombie>(num))
			{
				goto Block_1;
			}
		}
		int theZombieRow = this.theZombieRow;
		GameAPP.PlaySound((SoundType)((uint)8), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)9), 0.5f, 1f);
		float attributeCountDown = this.attributeCountDown;
		int num2 = 0;
		CreateZombie instance = CreateZombie.Instance;
		ParticleManager instance2 = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		ulong num3;
		Particle particle = instance2.SetParticle((ParticleType)((uint)11), num, num, num3 != 0UL, (float)num2);
		return;
		Block_1:
		int theZombieRow2 = this.theZombieRow;
		GameAPP.PlaySound((SoundType)((uint)8), 0.5f, 1f);
		GameAPP.PlaySound((SoundType)((uint)9), 0.5f, 1f);
		throw new NullReferenceException();
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000AAF80 File Offset: 0x000A9180
	[Token(Token = "0x6002042")]
	[Address(RVA = "0x5A8840", Offset = "0x5A6E40", VA = "0x1805A8840")]
	private void AnimCloud()
	{
		ParticleManager instance = ParticleManager.Instance;
		Transform transform = this.roll;
		int num = 0;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle(ParticleType.RandomCloud, num, 11, num3 != 0UL, (float)num2);
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000AAFB8 File Offset: 0x000A91B8
	[Token(Token = "0x6002043")]
	[Address(RVA = "0x5A9870", Offset = "0x5A7E70", VA = "0x1805A9870")]
	private void SetZombie(int row, Transform flag)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		Vector3 vector;
		float z = vector.z;
		int num2 = 0;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)11), num, row, num3 != 0UL, (float)num2);
		List<ZombieType> list = this.zombies;
		CreateZombie instance2 = CreateZombie.Instance;
		ZombieType random = ListExtensions.GetRandom<ZombieType>(list);
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000AB008 File Offset: 0x000A9208
	[Token(Token = "0x6002044")]
	[Address(RVA = "0x5A8EB0", Offset = "0x5A74B0", VA = "0x1805A8EB0", Slot = "30")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000AB040 File Offset: 0x000A9240
	[Token(Token = "0x6002045")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000AB050 File Offset: 0x000A9250
	[Token(Token = "0x6002046")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "27")]
	public override void SetMindControl(int controlLevel = 0)
	{
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000AB060 File Offset: 0x000A9260
	[Token(Token = "0x6002047")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "53")]
	public override void SetFreeze(float time, int theFreezeLevel = 0)
	{
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000AB070 File Offset: 0x000A9270
	[Token(Token = "0x6002048")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "58")]
	public override void Buttered(float time = 4f, bool sprite = true)
	{
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000AB080 File Offset: 0x000A9280
	[Token(Token = "0x6002049")]
	[Address(RVA = "0x5A9020", Offset = "0x5A7620", VA = "0x1805A9020", Slot = "26")]
	public override void Charred(int damage = 1800, PlantType reportType = PlantType.Nothing, bool fix = false, DamageType damageType = DamageType.Carred)
	{
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000AB090 File Offset: 0x000A9290
	[Token(Token = "0x600204A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "60")]
	public override void EatGarlic(Plant plant, float time = 1f, bool withSound = true)
	{
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x000AB0A0 File Offset: 0x000A92A0
	[Token(Token = "0x600204B")]
	[Address(RVA = "0x5A9160", Offset = "0x5A7760", VA = "0x1805A9160", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		long num;
		return num;
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x000AB0B4 File Offset: 0x000A92B4
	[Token(Token = "0x600204C")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x000AB0C4 File Offset: 0x000A92C4
	[Token(Token = "0x600204D")]
	[Address(RVA = "0x5A9C10", Offset = "0x5A8210", VA = "0x1805A9C10")]
	public FootballBoss()
	{
		List<ZombieType> list = new List();
		int size = list._size;
		int size2 = list._size;
		int size3 = list._size;
		int size4 = list._size;
		int size5 = list._size;
		int size6 = list._size;
		int size7 = list._size;
		int size8 = list._size;
		int size9 = list._size;
		int size10 = list._size;
		int size11 = list._size;
		int size12 = list._size;
		int size13 = list._size;
		this.zombies = list;
		base..ctor();
	}

	// Token: 0x04001144 RID: 4420
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001144")]
	public Transform flag1;

	// Token: 0x04001145 RID: 4421
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001145")]
	public Transform flag2;

	// Token: 0x04001146 RID: 4422
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001146")]
	public Transform flag3;

	// Token: 0x04001147 RID: 4423
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4001147")]
	public Transform roll;

	// Token: 0x04001148 RID: 4424
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4001148")]
	public List<ZombieType> zombies;
}
