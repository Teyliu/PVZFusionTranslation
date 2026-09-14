using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002EF RID: 751
[Token(Token = "0x20002EF")]
public class UltimateWinterCloud : MonoBehaviour
{
	// Token: 0x06000D7B RID: 3451 RVA: 0x0004D3E4 File Offset: 0x0004B5E4
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x4432E0", Offset = "0x4418E0", VA = "0x1804432E0")]
	private void Awake()
	{
		UltimateWinterCloud.Instance = this;
		Board instance = Board.Instance;
		this.board = instance;
		Transform transform = base.transform;
		bool flag = Lawnf.TravelUltimate((UltiBuff)((uint)40));
		this.raised = flag;
		bool flag2 = Lawnf.TravelAdvanced((AdvBuff)((uint)3004));
		this.lianxie = flag2;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x0004D43C File Offset: 0x0004B63C
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x443580", Offset = "0x441B80", VA = "0x180443580")]
	private void Update()
	{
		int num = 0;
		int num2 = 0;
		if ((this.raised ? 1 : 0) != num && this.maxTimer > this.timer)
		{
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			Func<Zombie, bool> <>9__11_ = UltimateWinterCloud.<>c.<>9__11_0;
			if (<>9__11_ == 0)
			{
				UltimateWinterCloud.<>c.<>9__11_0 = delegate(Zombie z)
				{
					if (!z.isMindControlled && !z.beforeDying)
					{
						return Lawnf.InLandStatus(z.theStatus);
					}
					throw new NullReferenceException();
				};
			}
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(allZombies, <>9__11_);
			Func<Zombie, long> func;
			if (UltimateWinterCloud.<>c.<>9__11_1 == 0)
			{
				UltimateWinterCloud.<>c.<>9__11_1 = func;
			}
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.ToList<Zombie>(Enumerable.OrderBy<Zombie, long>(enumerable, func)));
			this.targetZombie = zombie;
			Zombie zombie2 = this.targetZombie;
			int num3 = 0;
			if (!(zombie2 != num3))
			{
				goto IL_0138;
			}
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z2 = vector.z;
			Transform axis = this.targetZombie.axis;
			Transform transform3 = base.transform;
			float num4 = Time.deltaTime * 5f;
			if (num2 > (int)num4 || num4 > 1f)
			{
			}
		}
		this.targetZombie = num;
		Transform transform4 = base.transform;
		float num5 = Time.deltaTime;
		int num6 = 0;
		int num7 = 0;
		transform4.Translate(num5, (float)num7, (float)num6);
		Transform transform5 = base.transform;
		global::UnityEngine.Object.Destroy(base.gameObject);
		int num8;
		if (UltimateWinterCloud.Instance == this)
		{
			num8 = 0;
			UltimateWinterCloud.Instance = num;
		}
		IL_0138:
		float deltaTime = Time.deltaTime;
		float num9 = this.shootTimer;
		this.timer = deltaTime;
		float deltaTime2 = Time.deltaTime;
		this.shootTimer = num9;
		Board board = this.board;
		this.shootTimer = 0.5f;
		PlantStatus plantStatus = this.theStatus;
		int num10 = board.columnNum;
		if (board != 0)
		{
			if (board != 0)
			{
			}
			num10 -= num8;
		}
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
		float num11 = Lawnf.GetBoxXFromColumn(this.board.columnNum);
		Zombie zombie3 = this.targetZombie;
		int num12 = 0;
		if (!(zombie3 != num12))
		{
			Transform transform6 = base.transform;
			num5 = num11;
			num11 = boxXFromColumn;
			float num13 = global::UnityEngine.Random.Range(num11, num5);
		}
		Transform axis2 = this.targetZombie.axis;
		Transform axis3 = this.targetZombie.axis;
		bool flag;
		if (!flag)
		{
			Zombie zombie4 = this.targetZombie;
			int num14 = 0;
			if (!(zombie4 != num14))
			{
				goto IL_02F5;
			}
		}
		Transform transform7 = base.transform;
		float num15 = global::UnityEngine.Random.Range(1f, 3f);
		Board board2 = this.board;
		CreateBullet instance = CreateBullet.Instance;
		int num16 = board2.rowNum;
		num16 -= num;
		Bullet bullet;
		uint num17;
		bullet.Damage = (int)num17;
		Zombie zombie5 = this.targetZombie;
		int num18 = 0;
		if (zombie5 == num18)
		{
			uint num20;
			uint num21;
			int num19 = global::UnityEngine.Random.Range((int)num20, (int)num21);
			bullet.velocity = num15;
		}
		Vector2 gravity = Physics2D.gravity;
		float num22 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		bullet.velocity.y = num22;
		Transform transform8 = bullet.transform;
		float num23 = global::UnityEngine.Random.Range(0.4f, 0.8f);
		bool flag2 = this.melonSputter;
		bullet.melonSputter = flag2;
		if ((this.lianxie ? 1 : 0) != num)
		{
			bullet.theStatus = (BulletStatus)((ulong)9L);
		}
		IL_02F5:
		Board board3 = this.board;
		num++;
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x0004D754 File Offset: 0x0004B954
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x4433D0", Offset = "0x4419D0", VA = "0x1804433D0")]
	public static void SetCloud(bool melonSputter)
	{
		UltimateWinterCloud instance = UltimateWinterCloud.Instance;
		int num = 0;
		if (!(instance != num))
		{
			GameObject gameObject = Resources.Load<GameObject>("Plants/Melonpult/UltimateWinterMelon/UltimateWinterCloud");
			Transform transform = Board.Instance.transform;
			global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<UltimateWinterCloud>().melonSputter = melonSputter;
			return;
		}
		Transform transform2 = UltimateWinterCloud.Instance.transform;
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x0004D7B4 File Offset: 0x0004B9B4
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x443FC0", Offset = "0x4425C0", VA = "0x180443FC0")]
	public UltimateWinterCloud()
	{
	}

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	public static UltimateWinterCloud Instance;

	// Token: 0x040009A8 RID: 2472
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009A8")]
	public bool raised;

	// Token: 0x040009A9 RID: 2473
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40009A9")]
	public PlantStatus theStatus = (PlantStatus)((ulong)35L);

	// Token: 0x040009AA RID: 2474
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009AA")]
	public bool melonSputter;

	// Token: 0x040009AB RID: 2475
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009AB")]
	private Board board;

	// Token: 0x040009AC RID: 2476
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009AC")]
	private float shootTimer;

	// Token: 0x040009AD RID: 2477
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40009AD")]
	private float timer;

	// Token: 0x040009AE RID: 2478
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009AE")]
	private readonly float maxTimer = 6f;

	// Token: 0x040009AF RID: 2479
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40009AF")]
	private Zombie targetZombie;

	// Token: 0x040009B0 RID: 2480
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40009B0")]
	private bool lianxie;
}
