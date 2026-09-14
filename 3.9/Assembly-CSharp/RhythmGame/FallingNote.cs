using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class FallingNote : MonoBehaviour
	{
		// Token: 0x0600375C RID: 14172 RVA: 0x00128AE8 File Offset: 0x00126CE8
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x7B45D0", Offset = "0x7B2BD0", VA = "0x1807B45D0")]
		public void Initialize(NoteData noteData, float notePreTime, float targetYPos)
		{
			float time = noteData.time;
			this.targetTime = time;
			int track = noteData.track;
			this.trackIndex = track;
			NoteType type = noteData.type;
			this.noteType = type;
			this.spawnY = targetYPos;
			this.targetY = targetYPos;
			Transform transform = base.transform;
			Transform transform2 = base.transform;
			if (this.noteType == NoteType.Hold)
			{
				float duration = noteData.duration;
				this.holdDuration = duration;
				this.CreateHoldBar();
				RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
				int num = 0;
				bool flag = <Instance>k__BackingField != num;
				if (flag)
				{
					RhythmLevelData currentLevel = RhythmGameManager.<Instance>k__BackingField.currentLevel;
				}
				float num2 = this.beatDuration;
				Debug.Log(string.Format("Hold音符初始化: BPM={0}, beatDuration={1:F4}s", flag, flag));
			}
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00128BA8 File Offset: 0x00126DA8
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x7B38E0", Offset = "0x7B1EE0", VA = "0x1807B38E0")]
		private void CreateHoldBar()
		{
			GameObject gameObject = Resources.Load<GameObject>("Board/Game/Rhyhm/HoldBarSprite");
			int num = 0;
			if (!(gameObject != num))
			{
				this.CreateHoldBarDynamic();
			}
			Transform transform = base.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			this.holdBar = gameObject2;
			this.holdBar.name = "HoldBar";
			Debug.Log("HoldBar预制体加载成功");
			GameObject gameObject3 = this.holdBar;
			int num2 = 0;
			if (!(gameObject3 == num2))
			{
				GameObject gameObject4 = this.holdBar;
				float num3 = this.holdDuration * this.fallSpeed;
				Transform transform2 = gameObject4.transform;
				Transform transform3 = this.holdBar.transform;
			}
			this.CreateHoldTail();
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00128C58 File Offset: 0x00126E58
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x7B44C0", Offset = "0x7B2AC0", VA = "0x1807B44C0")]
		private void InitializeHoldBarLength()
		{
			GameObject gameObject = this.holdBar;
			int num = 0;
			if (!(gameObject == num))
			{
				GameObject gameObject2 = this.holdBar;
				float num2 = this.holdDuration * this.fallSpeed;
				Transform transform = gameObject2.transform;
				Transform transform2 = this.holdBar.transform;
			}
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00128CAC File Offset: 0x00126EAC
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x7B3B30", Offset = "0x7B2130", VA = "0x1807B3B30")]
		private void CreateHoldTail()
		{
			int num = 0;
			RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
			int num2 = 0;
			if (<Instance>k__BackingField != num2)
			{
				GameObject notePrefab = RhythmGameManager.<Instance>k__BackingField.notePrefab;
				int num3 = 0;
				if (notePrefab != num3)
				{
					GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(RhythmGameManager.<Instance>k__BackingField.notePrefab);
					this.holdTail = gameObject;
					Transform transform = this.holdTail.transform;
					Transform transform2 = base.transform;
					transform.parentInternal = transform2;
					this.holdTail.name = "HoldTail";
					if (this.holdTail.TryGetComponent<FallingNote>(num))
					{
						global::UnityEngine.Object.Destroy(num);
					}
					if (this.holdTail.TryGetComponent<Collider>(num))
					{
						global::UnityEngine.Object.Destroy(num);
					}
					GameObject gameObject2 = this.holdTail;
					float num4 = this.holdDuration;
					Transform transform3 = gameObject2.transform;
					Debug.Log("Hold尾部音符创建成功");
					return;
				}
			}
			Debug.LogWarning("无法创建Hold尾部音符：notePrefab未找到");
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00128D98 File Offset: 0x00126F98
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x7B3720", Offset = "0x7B1D20", VA = "0x1807B3720")]
		private void CreateHoldBarDynamic()
		{
			GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)((uint)3));
			this.holdBar = gameObject;
			this.holdBar.name = "HoldBar";
			Transform transform = this.holdBar.transform;
			Transform transform2 = base.transform;
			transform.parentInternal = transform2;
			Material material = this.holdBar.GetComponent<Renderer>().GetMaterial();
			Collider component = this.holdBar.GetComponent<Collider>();
			int num = 0;
			if (component != num)
			{
				global::UnityEngine.Object.Destroy(component);
			}
			Debug.LogWarning("HoldBar预制体未找到，使用动态创建");
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00128E24 File Offset: 0x00127024
		[Token(Token = "0x6003761")]
		[Address(RVA = "0x7B5660", Offset = "0x7B3C60", VA = "0x1807B5660")]
		private void Update()
		{
			RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
			int num = 0;
			if (!(<Instance>k__BackingField != num) || !<Instance>k__BackingField.isPaused)
			{
				float currentBGMTime = <Instance>k__BackingField.currentBGMTime;
				if (this.noteType == NoteType.Hold)
				{
					this.UpdateHoldNote(currentBGMTime);
					throw new NullReferenceException();
				}
				float num2 = this.targetTime;
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				Vector3 vector;
				float z = vector.z;
				Vector3 vector2;
				float z2 = vector2.z;
				if (!this.isClicked && !this.hasMissed)
				{
					this.OnMiss();
				}
			}
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00128EAC File Offset: 0x001270AC
		[Token(Token = "0x6003762")]
		[Address(RVA = "0x7B4870", Offset = "0x7B2E70", VA = "0x1807B4870")]
		public void OnClick()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00128ECC File Offset: 0x001270CC
		[Token(Token = "0x6003763")]
		[Address(RVA = "0x7B4AE0", Offset = "0x7B30E0", VA = "0x1807B4AE0")]
		private void OnMiss()
		{
			this.hasMissed = true;
			RhythmGameManager.<Instance>k__BackingField.OnNoteMissed(this);
			this.HideNote();
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00128EF8 File Offset: 0x001270F8
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x7B3E80", Offset = "0x7B2480", VA = "0x1807B3E80")]
		private void FireZombies()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x00128F18 File Offset: 0x00127118
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x7B3F40", Offset = "0x7B2540", VA = "0x1807B3F40")]
		private void HideNote()
		{
			ulong num6;
			do
			{
				if (RhythmGameManager.<Instance>k__BackingField.allSet)
				{
					if ((ulong)1L == 0UL)
					{
					}
					List<NoteTrack> tracks = RhythmGameManager.<Instance>k__BackingField.tracks;
					bool flag;
					int num;
					if (flag)
					{
						num = 0;
					}
					ulong num2;
					if (num2 != (ulong)0L)
					{
						goto IL_0115;
					}
					if (num != 0)
					{
						Board.Instance.boardTag.disableSummonZombie = true;
						Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
						Board.Instance.boardVicotry.Win();
					}
				}
				GameObject gameObject = this.holdBar;
				int num3 = 0;
				if (gameObject != num3)
				{
					global::UnityEngine.Object.Destroy(this.holdBar);
				}
				GameObject gameObject2 = this.holdTail;
				int num4 = 0;
				if (gameObject2 != num4)
				{
					global::UnityEngine.Object.Destroy(this.holdTail);
				}
				RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
				int num5 = 0;
				if (!(<Instance>k__BackingField != num5) || RhythmGameManager.<Instance>k__BackingField.tracks == (ulong)0L)
				{
					break;
				}
				if ((ulong)1L == 0UL)
				{
				}
				List<NoteTrack> tracks2 = RhythmGameManager.<Instance>k__BackingField.tracks;
				bool flag2;
				if (flag2)
				{
					bool flag3;
					while (!flag3)
					{
					}
				}
			}
			while (num6 != (ulong)0L);
			GameObject gameObject3;
			global::UnityEngine.Object.Destroy(gameObject3);
			return;
			IL_0115:
			throw new NullReferenceException();
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00129048 File Offset: 0x00127248
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x7B3F10", Offset = "0x7B2510", VA = "0x1807B3F10")]
		public float GetYPosition()
		{
			Transform transform = base.transform;
			Vector3 vector;
			return vector.y;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x00129070 File Offset: 0x00127270
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x7B4850", Offset = "0x7B2E50", VA = "0x1807B4850")]
		public bool IsClickable()
		{
			if (this.isClicked)
			{
			}
			return !this.hasMissed;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00129094 File Offset: 0x00127294
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x7B4DF0", Offset = "0x7B33F0", VA = "0x1807B4DF0")]
		private void UpdateHoldNote(float currentTime)
		{
			float num = this.holdDuration;
			int num2 = 0;
			int num3 = 0;
			if ((this.isHolding ? 1 : 0) != num2)
			{
				Transform transform = base.transform;
				Transform transform2 = base.transform;
				GameObject gameObject = this.holdBar;
				int num4 = 0;
				if (gameObject == num4)
				{
					goto IL_00F1;
				}
				GameObject gameObject2 = this.holdBar;
				float num5 = (float)(0 * (int)this.fallSpeed);
				int num6 = 0;
				gameObject2.transform.localScale = num6;
				GameObject gameObject3 = this.holdBar;
				int num7 = 0;
				gameObject3.transform.localPosition = num7;
				GameObject gameObject4 = this.holdTail;
				int num8 = 0;
				if (!(gameObject4 != num8))
				{
					goto IL_00F1;
				}
				GameObject gameObject5 = this.holdTail;
				int num9 = 0;
				gameObject5.transform.localPosition = num9;
			}
			float num10 = this.targetTime;
			Transform transform3 = base.transform;
			Transform transform4 = base.transform;
			float num11 = this.targetTime;
			float num12 = this.targetTime;
			int num13 = this.trackIndex;
			Debug.Log(string.Format("Hold音符等待点击: trackIndex={0}, currentTime={1:F2}, targetTime={2:F2}", num13, num13, num13));
			IL_00F1:
			string text;
			if ((this.isHolding ? 1 : 0) == num2)
			{
				float num14 = this.targetTime;
				if (currentTime > num14)
				{
					if ((this.hasMissed ? 1 : 0) != num2)
					{
						return;
					}
					int num15;
					float num16;
					float num17;
					text = string.Format("Hold音符错过: trackIndex={0}, currentTime={1:F2}, targetTime={2:F2}", num15, num16, num17);
					Debug.Log(text);
					this.OnMiss();
				}
				if (this.isHolding == text)
				{
					goto IL_01BB;
				}
			}
			if (this.holdCompleted == text && num > currentTime)
			{
				RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
				int num18 = this.trackIndex;
				if (!<Instance>k__BackingField.IsHoldKeyPressed(num18))
				{
					int num19;
					Debug.Log(string.Format("Hold音符松开过早: trackIndex={0}", num19));
					this.hasMissed = true;
					RhythmGameManager.<Instance>k__BackingField.OnHoldNoteFailed(this);
					throw new NullReferenceException();
				}
				if (num3 > (int)this.lastBeatJudgeTime)
				{
					float num20 = this.targetTime;
					this.lastBeatJudgeTime = num20;
				}
				float num21 = this.beatDuration;
				RhythmGameManager.<Instance>k__BackingField.OnHoldBeatJudge(this, currentTime);
				int num22 = this.trackIndex;
				Debug.Log(string.Format("Hold拍子判定: 轨道{0}, 时间={1:F3}", num22, num22));
				this.lastBeatJudgeTime = num21;
			}
			IL_01BB:
			if (this.isHolding && !this.holdCompleted)
			{
				int num23;
				float num24;
				Debug.Log(string.Format("Hold音符完成: trackIndex={0}, duration={1:F2}s", num23, num24));
				this.holdCompleted = true;
				RhythmGameManager <Instance>k__BackingField2 = RhythmGameManager.<Instance>k__BackingField;
				if ((ulong)1L == 0UL)
				{
				}
				float currentBGMTime = RhythmGameManager.<Instance>k__BackingField.currentBGMTime;
				<Instance>k__BackingField2.OnHoldNoteComplete(this, currentBGMTime);
				this.HideNote();
			}
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x001292DC File Offset: 0x001274DC
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x7B4C50", Offset = "0x7B3250", VA = "0x1807B4C50")]
		private void UpdateHoldBarLength(float currentTime, float endTime)
		{
			GameObject gameObject = this.holdBar;
			int num = 0;
			if (!(gameObject == num))
			{
				GameObject gameObject2 = this.holdBar;
				int num2 = 0;
				float num3 = (float)(num2 * (int)this.fallSpeed);
				Transform transform = gameObject2.transform;
				Transform transform2 = this.holdBar.transform;
				GameObject gameObject3 = this.holdTail;
				int num4 = 0;
				if (gameObject3 != num4)
				{
					Transform transform3 = this.holdTail.transform;
				}
			}
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00129354 File Offset: 0x00127554
		[Token(Token = "0x600376A")]
		[Address(RVA = "0x7B4B40", Offset = "0x7B3140", VA = "0x1807B4B40")]
		private void TriggerHoldBeatJudge(float currentTime)
		{
			RhythmGameManager.<Instance>k__BackingField.OnHoldBeatJudge(this, currentTime);
			int num = this.trackIndex;
			Debug.Log(string.Format("Hold拍子判定: 轨道{0}, 时间={1:F3}", num, num));
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x0012938C File Offset: 0x0012758C
		[Token(Token = "0x600376B")]
		[Address(RVA = "0x7B4A20", Offset = "0x7B3020", VA = "0x1807B4A20")]
		public void OnHoldStart()
		{
			if (!this.isHolding && !this.holdCompleted && !this.hasMissed)
			{
				this.isHolding = true;
				RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
				if ((ulong)1L == 0UL)
				{
				}
				float currentBGMTime = RhythmGameManager.<Instance>k__BackingField.currentBGMTime;
				<Instance>k__BackingField.OnHoldNoteStart(this, currentBGMTime);
			}
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x001293E0 File Offset: 0x001275E0
		[Token(Token = "0x600376C")]
		[Address(RVA = "0x7B4920", Offset = "0x7B2F20", VA = "0x1807B4920")]
		private void OnHoldComplete()
		{
			this.holdCompleted = true;
			RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
			if ((ulong)1L == 0UL)
			{
			}
			float currentBGMTime = RhythmGameManager.<Instance>k__BackingField.currentBGMTime;
			<Instance>k__BackingField.OnHoldNoteComplete(this, currentBGMTime);
			this.HideNote();
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00129420 File Offset: 0x00127620
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x7B49C0", Offset = "0x7B2FC0", VA = "0x1807B49C0")]
		private void OnHoldFailed()
		{
			this.hasMissed = true;
			RhythmGameManager.<Instance>k__BackingField.OnHoldNoteFailed(this);
			this.HideNote();
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0012944C File Offset: 0x0012764C
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x7B58A0", Offset = "0x7B3EA0", VA = "0x1807B58A0")]
		public FallingNote()
		{
		}

		// Token: 0x04002AE6 RID: 10982
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AE6")]
		[Header("音符数据")]
		public float targetTime;

		// Token: 0x04002AE7 RID: 10983
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002AE7")]
		public int trackIndex;

		// Token: 0x04002AE8 RID: 10984
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002AE8")]
		public NoteType noteType;

		// Token: 0x04002AE9 RID: 10985
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002AE9")]
		[Header("运动参数")]
		public float fallSpeed;

		// Token: 0x04002AEA RID: 10986
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002AEA")]
		public float spawnY;

		// Token: 0x04002AEB RID: 10987
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002AEB")]
		public float targetY;

		// Token: 0x04002AEC RID: 10988
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002AEC")]
		private bool isClicked;

		// Token: 0x04002AED RID: 10989
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x4002AED")]
		private bool hasMissed;

		// Token: 0x04002AEE RID: 10990
		[FieldOffset(Offset = "0x3A")]
		[Token(Token = "0x4002AEE")]
		public bool hasAutoPlayed;

		// Token: 0x04002AEF RID: 10991
		[FieldOffset(Offset = "0x3B")]
		[Token(Token = "0x4002AEF")]
		private bool isHolding;

		// Token: 0x04002AF0 RID: 10992
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4002AF0")]
		private bool holdCompleted;

		// Token: 0x04002AF1 RID: 10993
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002AF1")]
		private GameObject holdBar;

		// Token: 0x04002AF2 RID: 10994
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002AF2")]
		private GameObject holdTail;

		// Token: 0x04002AF3 RID: 10995
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002AF3")]
		private float holdDuration;

		// Token: 0x04002AF4 RID: 10996
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4002AF4")]
		private float lastBeatJudgeTime = -1f;

		// Token: 0x04002AF5 RID: 10997
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002AF5")]
		private float beatDuration = 0.09375f;

		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		private const float MISS_WINDOW = 0.2f;
	}
}
