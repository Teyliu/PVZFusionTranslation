using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000FE RID: 254
[Token(Token = "0x20000FE")]
public class ZumaBall : MonoBehaviour
{
	// Token: 0x060004D6 RID: 1238 RVA: 0x000196AC File Offset: 0x000178AC
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x5ED100", Offset = "0x5EB700", VA = "0x1805ED100")]
	private void Awake()
	{
		Rigidbody2D component = base.GetComponent<Rigidbody2D>();
		this.rb = component;
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000196C8 File Offset: 0x000178C8
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x5ED750", Offset = "0x5EBD50", VA = "0x1805ED750")]
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

	// Token: 0x060004D8 RID: 1240 RVA: 0x00019788 File Offset: 0x00017988
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x5ED450", Offset = "0x5EBA50", VA = "0x1805ED450")]
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

	// Token: 0x060004D9 RID: 1241 RVA: 0x00019850 File Offset: 0x00017A50
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x5ED150", Offset = "0x5EB750", VA = "0x1805ED150")]
	private void CheckOutOfScreen()
	{
		Camera main = Camera.main;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		this.Die();
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00019884 File Offset: 0x00017A84
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x5ED200", Offset = "0x5EB800", VA = "0x1805ED200")]
	public void Die()
	{
		if (this.theBallStatus == ZumaBall.BallStatus.Moving)
		{
			bool flag = ZumaShooter.Instance.shootBallList.Remove(this);
		}
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000198BC File Offset: 0x00017ABC
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x5ED2B0", Offset = "0x5EB8B0", VA = "0x1805ED2B0")]
	public bool ISExitStartHole()
	{
		float num = this.progress;
		return false;
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x000198D4 File Offset: 0x00017AD4
	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x5ED2C0", Offset = "0x5EB8C0", VA = "0x1805ED2C0")]
	public bool IsArriveFailHole()
	{
		MapConfig instance = MapConfig.Instance;
		float num = this.progress;
		throw new NullReferenceException();
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060004DD RID: 1245 RVA: 0x000198F8 File Offset: 0x00017AF8
	// (set) Token: 0x060004DE RID: 1246 RVA: 0x0001990C File Offset: 0x00017B0C
	[Token(Token = "0x17000099")]
	public ZumaBall Next
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x5EDAB0", Offset = "0x5EC0B0", VA = "0x1805EDAB0")]
		get;
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x40B630", Offset = "0x409C30", VA = "0x18040B630")]
		set;
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060004DF RID: 1247 RVA: 0x00019920 File Offset: 0x00017B20
	// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00019934 File Offset: 0x00017B34
	[Token(Token = "0x1700009A")]
	public ZumaBall Pre
	{
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x5EDAC0", Offset = "0x5EC0C0", VA = "0x1805EDAC0")]
		get;
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x5EDD40", Offset = "0x5EC340", VA = "0x1805EDD40")]
		set;
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00019948 File Offset: 0x00017B48
	[Token(Token = "0x1700009B")]
	public int SegmentIndex
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x5EDAD0", Offset = "0x5EC0D0", VA = "0x1805EDAD0")]
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

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000199AC File Offset: 0x00017BAC
	[Token(Token = "0x1700009C")]
	public ZumaBall Tail
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x5EDCB0", Offset = "0x5EC2B0", VA = "0x1805EDCB0")]
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

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060004E3 RID: 1251 RVA: 0x000199DC File Offset: 0x00017BDC
	[Token(Token = "0x1700009D")]
	public ZumaBall Head
	{
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x5EDA20", Offset = "0x5EC020", VA = "0x1805EDA20")]
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

	// Token: 0x060004E4 RID: 1252 RVA: 0x00019A0C File Offset: 0x00017C0C
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x5ED320", Offset = "0x5EB920", VA = "0x1805ED320")]
	public bool IsCross(Vector3 targetPos, float distance)
	{
		Transform transform = base.transform;
		return typeof(Math).TypeHandle != null;
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00019A30 File Offset: 0x00017C30
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public ZumaBall()
	{
	}

	// Token: 0x040002E6 RID: 742
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E6")]
	public float progress;

	// Token: 0x040002E7 RID: 743
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002E7")]
	public float lastProgress;

	// Token: 0x040002E8 RID: 744
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002E8")]
	public bool deleteFlag;

	// Token: 0x040002E9 RID: 745
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002E9")]
	public ZumaBall fallbackTarget;

	// Token: 0x040002EA RID: 746
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002EA")]
	public Rigidbody2D rb;

	// Token: 0x040002EB RID: 747
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002EB")]
	public ZumaBall.BallType theBallType;

	// Token: 0x040002EC RID: 748
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40002EC")]
	public ZumaBall.BallStatus theBallStatus;

	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public enum BallType
	{
		// Token: 0x040002F0 RID: 752
		[Token(Token = "0x40002F0")]
		BrownBall,
		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		IronBall,
		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		DarkBall,
		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		HyponoBall,
		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		BlueBall,
		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		ExplodeBall
	}

	// Token: 0x02000100 RID: 256
	[Token(Token = "0x2000100")]
	public enum BallStatus
	{
		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		Moving,
		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		OnShooter,
		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		OnRoad,
		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		Waiting
	}
}
