using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002E1 RID: 737
[Token(Token = "0x20002E1")]
public class UltimateWinterCloud : MonoBehaviour
{
	// Token: 0x06000D38 RID: 3384 RVA: 0x0004C784 File Offset: 0x0004A984
	[Token(Token = "0x6000D38")]
	[Address(RVA = "0x3FF9A0", Offset = "0x3FDFA0", VA = "0x1803FF9A0")]
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

	// Token: 0x06000D39 RID: 3385 RVA: 0x0004C7DC File Offset: 0x0004A9DC
	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x3FFC40", Offset = "0x3FE240", VA = "0x1803FFC40")]
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
				Func<Zombie, bool> func;
				UltimateWinterCloud.<>c.<>9__11_0 = func;
			}
			IEnumerable<Zombie> enumerable = Enumerable.Where<Zombie>(allZombies, <>9__11_);
			Func<Zombie, int> func2;
			if (UltimateWinterCloud.<>c.<>9__11_1 == 0)
			{
				UltimateWinterCloud.<>c.<>9__11_1 = func2;
			}
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.ToList<Zombie>(Enumerable.OrderBy<Zombie, int>(enumerable, func2)));
			this.targetZombie = zombie;
			Zombie zombie2 = this.targetZombie;
			int num3 = 0;
			if (!(zombie2 != num3))
			{
				goto IL_012A;
			}
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			Vector3 vector;
			float z = vector.z;
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
		IL_012A:
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
				goto IL_02E1;
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
			bullet.detaVx = num15;
		}
		Vector2 gravity = Physics2D.gravity;
		float num22 = global::UnityEngine.Random.Range(0.9f, 1.1f);
		bullet.detaVy = (float)0;
		Transform transform8 = bullet.transform;
		float num23 = global::UnityEngine.Random.Range(0.4f, 0.8f);
		bool flag2 = this.melonSputter;
		bullet.melonSputter = flag2;
		if ((this.lianxie ? 1 : 0) != num)
		{
			bullet.theStatus = (BulletStatus)((ulong)9L);
		}
		IL_02E1:
		Board board3 = this.board;
		num++;
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x0004CAE0 File Offset: 0x0004ACE0
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x3FFA90", Offset = "0x3FE090", VA = "0x1803FFA90")]
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

	// Token: 0x06000D3B RID: 3387 RVA: 0x0004CB40 File Offset: 0x0004AD40
	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0x400690", Offset = "0x3FEC90", VA = "0x180400690")]
	public UltimateWinterCloud()
	{
	}

	// Token: 0x0400096A RID: 2410
	[Token(Token = "0x400096A")]
	public static UltimateWinterCloud Instance;

	// Token: 0x0400096B RID: 2411
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400096B")]
	public bool raised;

	// Token: 0x0400096C RID: 2412
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400096C")]
	public PlantStatus theStatus = (PlantStatus)((ulong)35L);

	// Token: 0x0400096D RID: 2413
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400096D")]
	public bool melonSputter;

	// Token: 0x0400096E RID: 2414
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400096E")]
	private Board board;

	// Token: 0x0400096F RID: 2415
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400096F")]
	private float shootTimer;

	// Token: 0x04000970 RID: 2416
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000970")]
	private float timer;

	// Token: 0x04000971 RID: 2417
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000971")]
	private readonly float maxTimer = 6f;

	// Token: 0x04000972 RID: 2418
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000972")]
	private Zombie targetZombie;

	// Token: 0x04000973 RID: 2419
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000973")]
	private bool lianxie;
}
