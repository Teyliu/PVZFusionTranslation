using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F9 RID: 249
[Token(Token = "0x20000F9")]
public class ZumaBall : MonoBehaviour
{
	// Token: 0x060004BB RID: 1211 RVA: 0x000192A8 File Offset: 0x000174A8
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x5B7630", Offset = "0x5B5C30", VA = "0x1805B7630")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x000192C4 File Offset: 0x000174C4
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x5B7C80", Offset = "0x5B6280", VA = "0x1805B7C80")]
	private void Update()
	{
		if (this.theBallStatus != ZumaBall.BallStatus.OnRoad)
		{
			Camera main = Camera.main;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			this.Die();
		}
		float num = this.progress;
		int num2 = 0;
		if (this.lastProgress <= this.progress)
		{
			MapConfig instance = MapConfig.Instance;
			Transform transform2 = base.transform;
			Transform transform3 = base.transform;
			float maxSpeed = Zuma.Instance.maxSpeed;
			float deltaTime = Time.deltaTime;
			if (num2 > (int)deltaTime || deltaTime > 1f)
			{
			}
			float num3 = this.progress;
			this.lastProgress = num3;
			return;
		}
		Transform transform4 = base.transform;
		MapConfig instance2 = MapConfig.Instance;
		Vector3 vector2;
		float z2 = vector2.z;
		throw new NullReferenceException();
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00019384 File Offset: 0x00017584
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x5B7980", Offset = "0x5B5F80", VA = "0x1805B7980")]
	public int SameColorCount([Out] List<ZumaBall> list)
	{
		ZumaBall zumaBall6;
		int num5;
		do
		{
			int size = new List()._size;
			this.progress = this;
			ZumaBall zumaBall = this.<Pre>k__BackingField;
			int num = 0;
			uint num2;
			if (zumaBall != num)
			{
				ZumaBall zumaBall2 = this.<Pre>k__BackingField;
				ZumaBall.BallType ballType = this.theBallType;
				if (zumaBall2.theBallType == ballType)
				{
					num2 += (uint)1;
					ZumaBall zumaBall3 = this.<Pre>k__BackingField;
					int num3 = 0;
					if (zumaBall3 != num3)
					{
						continue;
					}
				}
			}
			ZumaBall zumaBall4 = this.<Next>k__BackingField;
			int num4 = 0;
			if (!(zumaBall4 != num4))
			{
				break;
			}
			ZumaBall zumaBall5 = this.<Next>k__BackingField;
			ZumaBall.BallType ballType2 = this.theBallType;
			if (zumaBall5.theBallType != ballType2)
			{
				break;
			}
			num2 += (uint)1;
			zumaBall6 = this.<Next>k__BackingField;
			num5 = 0;
		}
		while (zumaBall6 != num5);
		throw new NullReferenceException();
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x0001944C File Offset: 0x0001764C
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x5B7680", Offset = "0x5B5C80", VA = "0x1805B7680")]
	private void CheckOutOfScreen()
	{
		Camera main = Camera.main;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.Die();
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00019480 File Offset: 0x00017680
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x5B7730", Offset = "0x5B5D30", VA = "0x1805B7730")]
	public void Die()
	{
		if (this.theBallStatus == ZumaBall.BallStatus.Moving)
		{
			bool flag = ZumaShooter.Instance.shootBallList.Remove(this);
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x000194B8 File Offset: 0x000176B8
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x5B77E0", Offset = "0x5B5DE0", VA = "0x1805B77E0")]
	public bool ISExitStartHole()
	{
		float num = this.progress;
		return false;
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x000194D0 File Offset: 0x000176D0
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x5B77F0", Offset = "0x5B5DF0", VA = "0x1805B77F0")]
	public bool IsArriveFailHole()
	{
		MapConfig instance = MapConfig.Instance;
		float num = this.progress;
		throw new NullReferenceException();
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000194F4 File Offset: 0x000176F4
	// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00019508 File Offset: 0x00017708
	[Token(Token = "0x1700005C")]
	public ZumaBall Next
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x5B7FE0", Offset = "0x5B65E0", VA = "0x1805B7FE0")]
		get;
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3BE880", Offset = "0x3BCE80", VA = "0x1803BE880")]
		set;
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001951C File Offset: 0x0001771C
	// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00019530 File Offset: 0x00017730
	[Token(Token = "0x1700005D")]
	public ZumaBall Pre
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5B7FF0", Offset = "0x5B65F0", VA = "0x1805B7FF0")]
		get;
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x5B8270", Offset = "0x5B6870", VA = "0x1805B8270")]
		set;
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00019544 File Offset: 0x00017744
	[Token(Token = "0x1700005E")]
	public int SegmentIndex
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x5B8000", Offset = "0x5B6600", VA = "0x1805B8000")]
		get
		{
			int num = 0;
			List<ZumaBall> ballSegmentList = Zuma.Instance.ballSegmentList;
			ZumaBall zumaBall = Zuma.Instance.ballSegmentList[num];
			ZumaBall zumaBall2 = this.<Pre>k__BackingField;
			int num2 = 0;
			ZumaBall zumaBall3;
			if (!(zumaBall2 == num2))
			{
				zumaBall3 = this.<Pre>k__BackingField;
			}
			if (!(zumaBall == zumaBall3))
			{
				num++;
				Zuma instance = Zuma.Instance;
			}
			return num;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060004C7 RID: 1223 RVA: 0x000195A8 File Offset: 0x000177A8
	[Token(Token = "0x1700005F")]
	public ZumaBall Tail
	{
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x5B81E0", Offset = "0x5B67E0", VA = "0x1805B81E0")]
		get
		{
			ZumaBall zumaBall = this.<Next>k__BackingField;
			int num = 0;
			if (!(zumaBall == num))
			{
				ZumaBall zumaBall2 = this.<Next>k__BackingField;
			}
			return this;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000195D8 File Offset: 0x000177D8
	[Token(Token = "0x17000060")]
	public ZumaBall Head
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x5B7F50", Offset = "0x5B6550", VA = "0x1805B7F50")]
		get
		{
			ZumaBall zumaBall = this.<Pre>k__BackingField;
			int num = 0;
			if (!(zumaBall == num))
			{
				ZumaBall zumaBall2 = this.<Pre>k__BackingField;
			}
			return this;
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00019608 File Offset: 0x00017808
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x5B7850", Offset = "0x5B5E50", VA = "0x1805B7850")]
	public bool IsCross(Vector3 targetPos, float distance)
	{
		Transform transform = base.transform;
		return typeof(Math).TypeHandle != null;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0001962C File Offset: 0x0001782C
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public ZumaBall()
	{
	}

	// Token: 0x040002D8 RID: 728
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D8")]
	public float progress;

	// Token: 0x040002D9 RID: 729
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002D9")]
	public float lastProgress;

	// Token: 0x040002DA RID: 730
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002DA")]
	public bool deleteFlag;

	// Token: 0x040002DB RID: 731
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002DB")]
	public ZumaBall fallbackTarget;

	// Token: 0x040002DC RID: 732
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002DC")]
	public Rigidbody2D rb;

	// Token: 0x040002DD RID: 733
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002DD")]
	public ZumaBall.BallType theBallType;

	// Token: 0x040002DE RID: 734
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002DE")]
	public ZumaBall.BallStatus theBallStatus;

	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public enum BallType
	{
		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		BrownBall,
		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		IronBall,
		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		DarkBall,
		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		HyponoBall,
		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		BlueBall,
		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		ExplodeBall
	}

	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public enum BallStatus
	{
		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		Moving,
		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		OnShooter,
		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40002EB")]
		OnRoad,
		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		Waiting
	}
}
