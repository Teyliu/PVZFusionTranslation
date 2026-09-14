using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000F6")]
public class Zuma : MonoBehaviour
{
	// Token: 0x060004A2 RID: 1186 RVA: 0x0001837C File Offset: 0x0001657C
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x5B9860", Offset = "0x5B7E60", VA = "0x1805B9860")]
	private void Awake()
	{
		Zuma.Instance = this;
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00018390 File Offset: 0x00016590
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x5BBFD0", Offset = "0x5BA5D0", VA = "0x1805BBFD0")]
	private IEnumerator Start()
	{
		Zuma.<Start>d__17 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x000183B4 File Offset: 0x000165B4
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x5BC110", Offset = "0x5BA710", VA = "0x1805BC110")]
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

	// Token: 0x060004A5 RID: 1189 RVA: 0x000184B8 File Offset: 0x000166B8
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x5BA560", Offset = "0x5B8B60", VA = "0x1805BA560")]
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

	// Token: 0x060004A6 RID: 1190 RVA: 0x00018658 File Offset: 0x00016858
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x5BA160", Offset = "0x5B8760", VA = "0x1805BA160")]
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

	// Token: 0x060004A7 RID: 1191 RVA: 0x000186C4 File Offset: 0x000168C4
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x5BB6E0", Offset = "0x5B9CE0", VA = "0x1805BB6E0")]
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

	// Token: 0x060004A8 RID: 1192 RVA: 0x000188E0 File Offset: 0x00016AE0
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x5BAA20", Offset = "0x5B9020", VA = "0x1805BAA20")]
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

	// Token: 0x060004A9 RID: 1193 RVA: 0x00018C08 File Offset: 0x00016E08
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x5B9CD0", Offset = "0x5B82D0", VA = "0x1805B9CD0")]
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

	// Token: 0x060004AA RID: 1194 RVA: 0x00018D28 File Offset: 0x00016F28
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x5BC040", Offset = "0x5BA640", VA = "0x1805BC040")]
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

	// Token: 0x060004AB RID: 1195 RVA: 0x00018D74 File Offset: 0x00016F74
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x5B99E0", Offset = "0x5B7FE0", VA = "0x1805B99E0")]
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

	// Token: 0x060004AC RID: 1196 RVA: 0x00018E80 File Offset: 0x00017080
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x5BBDB0", Offset = "0x5BA3B0", VA = "0x1805BBDB0")]
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

	// Token: 0x060004AD RID: 1197 RVA: 0x00018EBC File Offset: 0x000170BC
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x5B98C0", Offset = "0x5B7EC0", VA = "0x1805B98C0")]
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

	// Token: 0x060004AE RID: 1198 RVA: 0x00018F00 File Offset: 0x00017100
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x5BB3E0", Offset = "0x5B99E0", VA = "0x1805BB3E0")]
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

	// Token: 0x060004AF RID: 1199 RVA: 0x00018F7C File Offset: 0x0001717C
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x5BA2B0", Offset = "0x5B88B0", VA = "0x1805BA2B0")]
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

	// Token: 0x060004B0 RID: 1200 RVA: 0x00018FC0 File Offset: 0x000171C0
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x5BC430", Offset = "0x5BAA30", VA = "0x1805BC430")]
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

	// Token: 0x060004B1 RID: 1201 RVA: 0x0001900C File Offset: 0x0001720C
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x5BA370", Offset = "0x5B8970", VA = "0x1805BA370")]
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

	// Token: 0x060004B2 RID: 1202 RVA: 0x000190A4 File Offset: 0x000172A4
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x5BA980", Offset = "0x5B8F80", VA = "0x1805BA980")]
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

	// Token: 0x060004B3 RID: 1203 RVA: 0x000190E8 File Offset: 0x000172E8
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x5BA9E0", Offset = "0x5B8FE0", VA = "0x1805BA9E0")]
	public static ZumaBall.BallType GetShootBallType()
	{
		if (global::UnityEngine.Random.Range(0, 10) != 0)
		{
			int num = global::UnityEngine.Random.Range(0, 5);
		}
		return ZumaBall.BallType.ExplodeBall;
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00019114 File Offset: 0x00017314
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x5BC5E0", Offset = "0x5BABE0", VA = "0x1805BC5E0")]
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

	// Token: 0x040002C2 RID: 706
	[Token(Token = "0x40002C2")]
	public static Zuma Instance;

	// Token: 0x040002C3 RID: 707
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002C3")]
	public int nextLayer;

	// Token: 0x040002C4 RID: 708
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40002C4")]
	public float maxSpeed = 10f;

	// Token: 0x040002C5 RID: 709
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002C5")]
	public float headSpeed = 10f;

	// Token: 0x040002C6 RID: 710
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40002C6")]
	private readonly int maxBallCount = (int)((ulong)300L);

	// Token: 0x040002C7 RID: 711
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002C7")]
	private int summonBallCount;

	// Token: 0x040002C8 RID: 712
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40002C8")]
	private ZumaBall.BallType lastType;

	// Token: 0x040002C9 RID: 713
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40002C9")]
	public bool gameOver;

	// Token: 0x040002CA RID: 714
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40002CA")]
	public List<GameObject> ballPrefab;

	// Token: 0x040002CB RID: 715
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40002CB")]
	public List<ZumaBall> ballSegmentList;

	// Token: 0x040002CC RID: 716
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40002CC")]
	[SerializeField]
	private bool isBomb;

	// Token: 0x040002CD RID: 717
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40002CD")]
	[SerializeField]
	private List<Zuma.BackSegment> backSegmentList;

	// Token: 0x040002CE RID: 718
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40002CE")]
	[SerializeField]
	private float backTime;

	// Token: 0x040002CF RID: 719
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40002CF")]
	private readonly float backSpeed;

	// Token: 0x040002D0 RID: 720
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40002D0")]
	private readonly List<ZumaBall> searchDestoryList;

	// Token: 0x040002D1 RID: 721
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40002D1")]
	private readonly List<ZumaBall> fallBackList;

	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	[Serializable]
	public struct BackSegment
	{
		// Token: 0x040002D2 RID: 722
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40002D2")]
		public int segment;

		// Token: 0x040002D3 RID: 723
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40002D3")]
		public float speed;

		// Token: 0x040002D4 RID: 724
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40002D4")]
		public int combo;
	}
}
