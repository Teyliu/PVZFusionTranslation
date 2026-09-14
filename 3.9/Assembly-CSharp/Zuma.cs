using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000FB RID: 251
[Token(Token = "0x20000FB")]
public class Zuma : MonoBehaviour
{
	// Token: 0x060004BD RID: 1213 RVA: 0x00018780 File Offset: 0x00016980
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x5EF330", Offset = "0x5ED930", VA = "0x1805EF330")]
	private void Awake()
	{
		Zuma.Instance = this;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00018794 File Offset: 0x00016994
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x5F1AA0", Offset = "0x5F00A0", VA = "0x1805F1AA0")]
	private IEnumerator Start()
	{
		Zuma.<Start>d__17 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x000187B8 File Offset: 0x000169B8
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x5F1BE0", Offset = "0x5F01E0", VA = "0x1805F1BE0")]
	private void Update()
	{
		if (!this.gameOver)
		{
			this.FirstSegmentMove();
			List<ZumaBall> list = this.ballSegmentList;
			int num = 0;
			int size = list._size;
			ZumaBall zumaBall = list[size];
			ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
			int num2 = 0;
			if (!(<Next>k__BackingField == num2))
			{
				ZumaBall <Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
			}
			MapConfig instance = MapConfig.Instance;
			float progress = zumaBall.progress;
			if (num == 0)
			{
				UIMgr.EnterLoseMenu("");
				this.gameOver = true;
			}
			this.ShootBallInsert();
			this.SearchDestory();
			int size2 = this.backSegmentList._size;
			int num3 = size2 - 1;
			if (size2 > 0)
			{
				List<Zuma.BackSegment> list2 = this.backSegmentList;
				List<Zuma.BackSegment> list3 = this.backSegmentList;
				Zuma.BackSegment backSegment;
				int combo = backSegment.combo;
			}
			this.CheckFallbackBall();
			this.BallSegmentConnect();
			int num4 = this.maxBallCount;
			List<ZumaBall> list4 = this.ballSegmentList;
			int num5 = 0;
			ZumaBall zumaBall2 = list4[num5];
			int num6 = 0;
			if (zumaBall2 == num6)
			{
				this.Victory();
			}
		}
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x000188BC File Offset: 0x00016ABC
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x5F0030", Offset = "0x5EE630", VA = "0x1805F0030")]
	private void FirstSegmentMove()
	{
		List<ZumaBall> list = this.ballSegmentList;
		int num = 0;
		ZumaBall zumaBall = list[num];
		int num2 = 0;
		if (!(zumaBall == num2))
		{
			float progress = zumaBall.progress;
			if (0 == 0)
			{
				int num3 = this.maxBallCount;
				if (this.summonBallCount < num3)
				{
					MapConfig instance = MapConfig.Instance;
					Vector3 vector;
					float z = vector.z;
					Quaternion identityQuaternion = Quaternion.identityQuaternion;
					ZumaBall.BallType roadBallType = this.GetRoadBallType();
					ZumaBall zumaBall2;
					zumaBall2.theBallStatus = (ZumaBall.BallStatus)((ulong)2L);
					zumaBall2.progress = 0f;
					zumaBall2.<Next>k__BackingField = zumaBall;
					zumaBall.<Pre>k__BackingField = zumaBall2;
					List<ZumaBall> list2 = this.ballSegmentList;
					int num4 = 0;
					list2[num4] = zumaBall2;
				}
			}
			if (this.maxSpeed <= this.headSpeed)
			{
				float num5 = this.maxSpeed;
				this.headSpeed = num5;
			}
			float deltaTime = Time.deltaTime;
			this.headSpeed = deltaTime;
			float num6 = this.headSpeed;
			float deltaTime2 = Time.deltaTime;
			zumaBall.progress = num6;
			ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
			int num7 = 0;
			if (!(<Next>k__BackingField != num7))
			{
				return;
			}
			ZumaBall <Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
			if (zumaBall.progress > <Next>k__BackingField2.progress)
			{
				float progress2 = zumaBall.progress;
				<Next>k__BackingField2.progress = progress2;
			}
			ZumaBall <Next>k__BackingField3 = zumaBall.<Next>k__BackingField;
		}
		List<ZumaBall> list3 = this.ballSegmentList;
		int num8 = 0;
		list3.RemoveAt(num8);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00018A5C File Offset: 0x00016C5C
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x5EFC30", Offset = "0x5EE230", VA = "0x1805EFC30")]
	private void CheckGameFail()
	{
		List<ZumaBall> list = this.ballSegmentList;
		int size = list._size;
		ZumaBall zumaBall = list[size];
		ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
		int num = 0;
		if (!(<Next>k__BackingField == num))
		{
			ZumaBall <Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
		}
		MapConfig instance = MapConfig.Instance;
		float progress = zumaBall.progress;
		if (0 == 0)
		{
			UIMgr.EnterLoseMenu("");
			this.gameOver = true;
		}
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00018AC8 File Offset: 0x00016CC8
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x5F11B0", Offset = "0x5EF7B0", VA = "0x1805F11B0")]
	private void ShootBallInsert()
	{
		int num;
		ZumaBall zumaBall;
		int num2;
		ZumaBall <Next>k__BackingField;
		int num3;
		do
		{
			List<ZumaBall> shootBallList = ZumaShooter.Instance.shootBallList;
			int size = shootBallList._size;
			num = size - 1;
			if (size <= 0)
			{
				return;
			}
			zumaBall = shootBallList[num];
			int size2 = this.ballSegmentList._size;
			num2 = size2 - 1;
			if (size2 <= 0)
			{
				goto IL_0201;
			}
			List<ZumaBall> list = this.ballSegmentList;
			num = num2;
			ZumaBall zumaBall2 = list[num];
			Transform transform = zumaBall2.transform;
			MapConfig instance = MapConfig.Instance;
			Vector3 vector;
			float z = vector.z;
			bool flag;
			if (flag)
			{
				break;
			}
			<Next>k__BackingField = zumaBall2.<Next>k__BackingField;
			num3 = 0;
		}
		while (<Next>k__BackingField != num3);
		Transform transform3;
		if (zumaBall.theBallType == ZumaBall.BallType.ExplodeBall)
		{
			zumaBall.Die();
			ZumaBall <Pre>k__BackingField = <Next>k__BackingField.<Pre>k__BackingField;
			<Next>k__BackingField.deleteFlag = true;
			int num4 = 0;
			if (<Pre>k__BackingField != num4 && (uint)2 > 0U)
			{
				<Pre>k__BackingField.deleteFlag = true;
			}
			ZumaBall <Next>k__BackingField2 = <Next>k__BackingField.<Next>k__BackingField;
			int num5 = 0;
			if (<Next>k__BackingField2 != num5 && (uint)2 > 0U)
			{
				<Next>k__BackingField2.deleteFlag = true;
			}
			this.isBomb = true;
			GameObject gameObject = GameAPP.particlePrefab[14];
			Transform transform2 = zumaBall.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Quaternion identityQuaternion = Quaternion.identityQuaternion;
			transform3 = base.transform;
		}
		Rigidbody2D rb = zumaBall.rb;
		Vector2 vector3;
		rb.velocity = vector3;
		zumaBall.<Pre>k__BackingField = transform3;
		zumaBall.<Next>k__BackingField = rb;
		int num6 = 0;
		if (rb != num6)
		{
		}
		SortingGroup component = zumaBall.GetComponent<SortingGroup>();
		int sortingOrder = transform3.GetComponent<SortingGroup>().sortingOrder;
		component.sortingOrder = sortingOrder;
		SortingGroup component2 = zumaBall.GetComponent<SortingGroup>();
		int sortingLayerID = transform3.GetComponent<SortingGroup>().sortingLayerID;
		component2.sortingLayerID = sortingLayerID;
		Transform transform4 = zumaBall.transform;
		Quaternion identityQuaternion2 = Quaternion.identityQuaternion;
		transform4.rotation = identityQuaternion2;
		List<ZumaBall> list2 = this.searchDestoryList;
		GameAPP.PlaySound(54, 0.5f, 1f);
		bool flag2 = ZumaShooter.Instance.shootBallList.Remove(zumaBall);
		if ((ulong)1L != 0UL || !this.isBomb)
		{
			ZumaBall zumaBall3 = this.ballSegmentList[num2];
			this.UpdateBallProgress(zumaBall3);
		}
		IL_0201:
		if (num > 0)
		{
		}
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00018CE4 File Offset: 0x00016EE4
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x5F04F0", Offset = "0x5EEAF0", VA = "0x1805F04F0")]
	private void SearchDestory()
	{
		int num4;
		ZumaBall <Pre>k__BackingField2;
		ZumaBall <Next>k__BackingField2;
		ZumaBall <Next>k__BackingField4;
		int num11;
		do
		{
			int num = 0;
			int num2 = 0;
			int size = this.searchDestoryList._size;
			List<ZumaBall> list = this.searchDestoryList;
			if (size > 0)
			{
				int num3 = list[size].SameColorCount(num);
				bool flag;
				if (flag)
				{
				}
				if (num != 0)
				{
					continue;
				}
			}
			int size2 = list._size;
			list._size = num;
			if (size2 > 0)
			{
			}
			if (num2 == 0 && (this.isBomb ? 1 : 0) == num2)
			{
				return;
			}
			this.isBomb = false;
			int size3 = this.ballSegmentList._size;
			num4 = size3 - 1;
			if (size3 <= 0)
			{
				return;
			}
			ZumaBall zumaBall = this.ballSegmentList[num4];
			ZumaBall <Pre>k__BackingField = zumaBall.<Pre>k__BackingField;
			int num5 = 0;
			if (!(<Pre>k__BackingField == num5))
			{
				<Pre>k__BackingField2 = zumaBall.<Pre>k__BackingField;
			}
			ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
			int num6 = 0;
			if (!(<Next>k__BackingField == num6))
			{
				<Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
			}
			if (zumaBall.deleteFlag)
			{
				ZumaBall <Pre>k__BackingField3 = zumaBall.<Pre>k__BackingField;
				int num7 = 0;
				if (<Pre>k__BackingField3 != num7)
				{
					zumaBall.<Pre>k__BackingField.<Next>k__BackingField = num;
				}
				ZumaBall <Next>k__BackingField3 = zumaBall.<Next>k__BackingField;
				int num8 = 0;
				if (<Next>k__BackingField3 != num8)
				{
					zumaBall.<Next>k__BackingField.<Pre>k__BackingField = num;
				}
				bool flag2 = zumaBall == <Pre>k__BackingField2;
				bool flag3 = <Next>k__BackingField2 == zumaBall;
				GameObject gameObject = GameAPP.particlePrefab[65];
				Transform transform = zumaBall.transform;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform2 = base.transform;
				GameObject gameObject2;
				gameObject2.GetComponent<ParticleSystemRenderer>().sortingLayerName = "particle0";
				if (zumaBall.theBallType == ZumaBall.BallType.BlueBall)
				{
					float num9 = this.headSpeed;
					this.headSpeed = num9;
				}
				zumaBall.Die();
				uint num10;
				GameAPP.PlaySound((int)num10, 0.5f, 1f);
			}
			<Next>k__BackingField4 = zumaBall.<Next>k__BackingField;
			num11 = 0;
		}
		while (<Next>k__BackingField4 != num11);
		int num12 = 0;
		if (!(<Pre>k__BackingField2 != num12))
		{
			int num13 = 0;
			bool flag4 = <Next>k__BackingField2 != num13;
			List<ZumaBall> list2 = this.ballSegmentList;
			if (!flag4)
			{
				list2.RemoveAt(num4);
			}
			ZumaBall head = <Next>k__BackingField2.Head;
			list2[num4] = head;
		}
		this.ballSegmentList[num4] = <Pre>k__BackingField2;
		int num14 = 0;
		if (<Next>k__BackingField2 != num14)
		{
			List<ZumaBall> list3 = this.ballSegmentList;
			ZumaBall head2 = <Next>k__BackingField2.Head;
			int num15 = num4 + 1;
			list3.Insert(num15, head2);
		}
		int num16 = 0;
		if (!(<Pre>k__BackingField2 != num16))
		{
			if (num4 <= 0)
			{
				goto IL_0292;
			}
			List<ZumaBall> list4 = this.ballSegmentList;
			int num17 = num4 - 1;
			ZumaBall zumaBall2 = list4[num17];
		}
		ZumaBall tail = <Pre>k__BackingField2.Tail;
		IL_0292:
		int num18 = 0;
		if (tail != num18)
		{
			int num19 = 0;
			if (!(<Next>k__BackingField2 != num19))
			{
				List<ZumaBall> list5 = this.ballSegmentList;
				int num20 = num4 + 1;
				int num21 = num4 + 1;
				ZumaBall zumaBall3 = list5[num21];
			}
			ZumaBall head3 = <Next>k__BackingField2.Head;
			int num22 = 0;
			if (head3 != num22)
			{
				ZumaBall.BallType theBallType = tail.theBallType;
				if (head3.theBallType == theBallType)
				{
					head3.fallbackTarget = tail;
					List<ZumaBall> list6 = this.fallBackList;
				}
			}
		}
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x0001900C File Offset: 0x0001720C
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x5EF7A0", Offset = "0x5EDDA0", VA = "0x1805EF7A0")]
	private void CheckFallbackBall()
	{
		List<ZumaBall> list = this.fallBackList;
		int num = 0;
		int size = list._size;
		int num2 = size - 1;
		if (size > 0)
		{
			ZumaBall zumaBall = this.fallBackList[num2];
			float progress = zumaBall.progress;
			float deltaTime = Time.deltaTime;
			zumaBall.progress = progress;
			int num3 = 0;
			if (zumaBall != num3)
			{
				ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
				int num4 = 0;
				if (<Next>k__BackingField != num4)
				{
					ZumaBall <Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
					float progress2 = zumaBall.progress;
					<Next>k__BackingField2.progress = progress2;
				}
			}
			if (this.ballSegmentList.Contains(zumaBall))
			{
				ZumaBall fallbackTarget = zumaBall.fallbackTarget;
				int num5 = 0;
				if (fallbackTarget == num5)
				{
					Debug.LogWarning(zumaBall.ToString() + "没有找到fallbackTarget");
					return;
				}
			}
			List<ZumaBall> list2 = this.searchDestoryList;
			List<ZumaBall> list3 = this.fallBackList;
			ZumaBall zumaBall2;
			if (this.ballSegmentList[num] == zumaBall2)
			{
				int num6;
				int num7;
				num6 += num7;
				List<Zuma.BackSegment> list4 = this.backSegmentList;
				List<Zuma.BackSegment> list5 = this.backSegmentList;
				num++;
			}
			num++;
			throw new NullReferenceException();
		}
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x0001912C File Offset: 0x0001732C
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x5F1B10", Offset = "0x5F0110", VA = "0x1805F1B10")]
	private void UpdateBallProgress(ZumaBall ball)
	{
		int num = 0;
		if (ball != num)
		{
			ZumaBall <Next>k__BackingField = ball.<Next>k__BackingField;
			int num2 = 0;
			if (<Next>k__BackingField != num2)
			{
				ZumaBall <Next>k__BackingField2 = ball.<Next>k__BackingField;
				float progress = ball.progress;
				<Next>k__BackingField2.progress = progress;
			}
		}
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00019178 File Offset: 0x00017378
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x5EF4B0", Offset = "0x5EDAB0", VA = "0x1805EF4B0")]
	private void BallSegmentConnect()
	{
		int size = this.ballSegmentList._size;
		int num = size - 1;
		if (size > 1)
		{
			ZumaBall zumaBall = this.ballSegmentList[num];
			List<ZumaBall> list = this.ballSegmentList;
			int num2 = num - 1;
			ZumaBall zumaBall2 = list[num2];
			int num3 = 0;
			if (!(zumaBall == num3))
			{
				int num4 = 0;
				if (!(zumaBall2 == num4))
				{
					ZumaBall tail = zumaBall2.Tail;
					float progress = zumaBall.progress;
					float progress2 = tail.progress;
					zumaBall.progress = progress2;
					int num5 = 0;
					if (zumaBall != num5)
					{
						ZumaBall <Next>k__BackingField = zumaBall.<Next>k__BackingField;
						int num6 = 0;
						if (<Next>k__BackingField != num6)
						{
							ZumaBall <Next>k__BackingField2 = zumaBall.<Next>k__BackingField;
							float progress3 = zumaBall.progress;
							<Next>k__BackingField2.progress = progress3;
						}
					}
					tail.<Next>k__BackingField = zumaBall;
					zumaBall.<Pre>k__BackingField = tail;
					int num7 = 0;
					List<Zuma.BackSegment> list2 = this.backSegmentList;
					num7++;
					this.backSegmentList.RemoveAt(num7);
					this.ballSegmentList.RemoveAt(num);
				}
			}
		}
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00019284 File Offset: 0x00017484
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x5F1880", Offset = "0x5EFE80", VA = "0x1805F1880")]
	private void StartBack(int segment, float speed, int combo = 1)
	{
		if (0 < (int)speed)
		{
			List<Zuma.BackSegment> list = this.backSegmentList;
			int num = 0;
			List<Zuma.BackSegment> list2 = this.backSegmentList;
			num++;
			List<Zuma.BackSegment> list3 = this.backSegmentList;
			List<Zuma.BackSegment> list4 = this.backSegmentList;
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x000192C0 File Offset: 0x000174C0
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x5EF390", Offset = "0x5ED990", VA = "0x1805EF390")]
	private void BackSegments()
	{
		int size = this.backSegmentList._size;
		int num = size - 1;
		if (size > 0)
		{
			List<Zuma.BackSegment> list = this.backSegmentList;
			List<Zuma.BackSegment> list2 = this.backSegmentList;
			Zuma.BackSegment backSegment;
			int combo = backSegment.combo;
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00019304 File Offset: 0x00017504
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x5F0EB0", Offset = "0x5EF4B0", VA = "0x1805F0EB0")]
	private Zuma.BackSegment SegmentBack(Zuma.BackSegment segment, int index)
	{
		int num = 0;
		float deltaTime = Time.deltaTime;
		ZumaBall zumaBall;
		ZumaBall tail = zumaBall.Tail;
		float progress = tail.progress;
		float deltaTime2 = Time.deltaTime;
		tail.progress = progress;
		ZumaBall zumaBall2;
		if (tail == zumaBall2 && num > (int)tail.progress)
		{
			tail.Die();
		}
		bool flag;
		while (!flag)
		{
		}
		bool flag2;
		if (flag2)
		{
		}
		bool flag3;
		while (flag3)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00019380 File Offset: 0x00017580
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x5EFD80", Offset = "0x5EE380", VA = "0x1805EFD80")]
	private void CheckVictory()
	{
		int num = this.maxBallCount;
		List<ZumaBall> list = this.ballSegmentList;
		int num2 = 0;
		ZumaBall zumaBall = list[num2];
		int num3 = 0;
		if (zumaBall == num3)
		{
			this.Victory();
			return;
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000193C4 File Offset: 0x000175C4
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x5F1F00", Offset = "0x5F0500", VA = "0x1805F1F00")]
	private void Victory()
	{
		Transform cannonPos = ZumaShooter.Instance.cannonPos;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject = Resources.Load<GameObject>("Board/Award/TrophyZuma");
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = base.transform;
		this.gameOver = true;
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00019410 File Offset: 0x00017610
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x5EFE40", Offset = "0x5EE440", VA = "0x1805EFE40")]
	public ZumaBall CreateBall(Vector2 position, Quaternion quaternion, ZumaBall.BallType ballType)
	{
		GameObject gameObject = this.ballPrefab[(int)ballType];
		Transform transform = base.transform;
		string name = this.ballPrefab[(int)ballType].name;
		GameObject gameObject2;
		gameObject2.name = name;
		SortingGroup component = gameObject2.GetComponent<SortingGroup>();
		int num = this.nextLayer;
		num++;
		this.nextLayer = num;
		component.sortingOrder = num;
		gameObject2.GetComponent<SortingGroup>().sortingLayerName = "plant0";
		ZumaBall component2 = gameObject2.GetComponent<ZumaBall>();
		component2.theBallType = ballType;
		return component2;
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x000194A8 File Offset: 0x000176A8
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x5F0450", Offset = "0x5EEA50", VA = "0x1805F0450")]
	private ZumaBall.BallType GetRoadBallType()
	{
		int num = global::UnityEngine.Random.Range(0, 5);
		int num2 = global::UnityEngine.Random.Range(0, 5);
		if (num2 == 0)
		{
			ZumaBall.BallType ballType = this.lastType;
			this.lastType = ballType;
			return ballType;
		}
		this.lastType = (ZumaBall.BallType)num;
		return ZumaBall.BallType.BrownBall;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x000194EC File Offset: 0x000176EC
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x5F04B0", Offset = "0x5EEAB0", VA = "0x1805F04B0")]
	public static ZumaBall.BallType GetShootBallType()
	{
		if (global::UnityEngine.Random.Range(0, 10) != 0)
		{
			int num = global::UnityEngine.Random.Range(0, 5);
		}
		return ZumaBall.BallType.ExplodeBall;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00019518 File Offset: 0x00017718
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x5F20B0", Offset = "0x5F06B0", VA = "0x1805F20B0")]
	public Zuma()
	{
		List<GameObject> list = new List();
		this.ballPrefab = list;
		List<ZumaBall> list2 = new List();
		this.ballSegmentList = list2;
		List<Zuma.BackSegment> list3 = new List();
		this.backSegmentList = list3;
		this.backSpeed = 15f;
		List<ZumaBall> list4 = new List();
		this.searchDestoryList = list4;
		List<ZumaBall> list5 = new List();
		this.fallBackList = list5;
		base..ctor();
	}

	// Token: 0x040002D0 RID: 720
	[Token(Token = "0x40002D0")]
	public static Zuma Instance;

	// Token: 0x040002D1 RID: 721
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D1")]
	public int nextLayer;

	// Token: 0x040002D2 RID: 722
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002D2")]
	public float maxSpeed = 10f;

	// Token: 0x040002D3 RID: 723
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D3")]
	public float headSpeed = 10f;

	// Token: 0x040002D4 RID: 724
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002D4")]
	private readonly int maxBallCount = (int)((ulong)300L);

	// Token: 0x040002D5 RID: 725
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D5")]
	private int summonBallCount;

	// Token: 0x040002D6 RID: 726
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002D6")]
	private ZumaBall.BallType lastType;

	// Token: 0x040002D7 RID: 727
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002D7")]
	public bool gameOver;

	// Token: 0x040002D8 RID: 728
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002D8")]
	public List<GameObject> ballPrefab;

	// Token: 0x040002D9 RID: 729
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002D9")]
	public List<ZumaBall> ballSegmentList;

	// Token: 0x040002DA RID: 730
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002DA")]
	[SerializeField]
	private bool isBomb;

	// Token: 0x040002DB RID: 731
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002DB")]
	[SerializeField]
	private List<Zuma.BackSegment> backSegmentList;

	// Token: 0x040002DC RID: 732
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002DC")]
	[SerializeField]
	private float backTime;

	// Token: 0x040002DD RID: 733
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002DD")]
	private readonly float backSpeed;

	// Token: 0x040002DE RID: 734
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002DE")]
	private readonly List<ZumaBall> searchDestoryList;

	// Token: 0x040002DF RID: 735
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002DF")]
	private readonly List<ZumaBall> fallBackList;

	// Token: 0x020000FC RID: 252
	[Token(Token = "0x20000FC")]
	[Serializable]
	public struct BackSegment
	{
		// Token: 0x040002E0 RID: 736
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002E0")]
		public int segment;

		// Token: 0x040002E1 RID: 737
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002E1")]
		public float speed;

		// Token: 0x040002E2 RID: 738
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002E2")]
		public int combo;
	}
}
