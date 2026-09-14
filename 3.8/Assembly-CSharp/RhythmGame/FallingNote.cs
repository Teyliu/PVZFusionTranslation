using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	public class FallingNote : MonoBehaviour
	{
		// Token: 0x06003618 RID: 13848 RVA: 0x0012386C File Offset: 0x00121A6C
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x74DC10", Offset = "0x74C210", VA = "0x18074DC10")]
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

		// Token: 0x06003619 RID: 13849 RVA: 0x0012392C File Offset: 0x00121B2C
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x74CF20", Offset = "0x74B520", VA = "0x18074CF20")]
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

		// Token: 0x0600361A RID: 13850 RVA: 0x001239DC File Offset: 0x00121BDC
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x74DB00", Offset = "0x74C100", VA = "0x18074DB00")]
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

		// Token: 0x0600361B RID: 13851 RVA: 0x00123A30 File Offset: 0x00121C30
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x74D170", Offset = "0x74B770", VA = "0x18074D170")]
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

		// Token: 0x0600361C RID: 13852 RVA: 0x00123B1C File Offset: 0x00121D1C
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x74CD60", Offset = "0x74B360", VA = "0x18074CD60")]
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

		// Token: 0x0600361D RID: 13853 RVA: 0x00123BA8 File Offset: 0x00121DA8
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x74ECA0", Offset = "0x74D2A0", VA = "0x18074ECA0")]
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

		// Token: 0x0600361E RID: 13854 RVA: 0x00123C30 File Offset: 0x00121E30
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x74DEB0", Offset = "0x74C4B0", VA = "0x18074DEB0")]
		public void OnClick()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x00123C50 File Offset: 0x00121E50
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x74E120", Offset = "0x74C720", VA = "0x18074E120")]
		private void OnMiss()
		{
			this.hasMissed = true;
			RhythmGameManager.<Instance>k__BackingField.OnNoteMissed(this);
			this.HideNote();
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x00123C7C File Offset: 0x00121E7C
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x74D4C0", Offset = "0x74BAC0", VA = "0x18074D4C0")]
		private void FireZombies()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x00123C9C File Offset: 0x00121E9C
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x74D580", Offset = "0x74BB80", VA = "0x18074D580")]
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

		// Token: 0x06003622 RID: 13858 RVA: 0x00123DCC File Offset: 0x00121FCC
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x74D550", Offset = "0x74BB50", VA = "0x18074D550")]
		public float GetYPosition()
		{
			Transform transform = base.transform;
			Vector3 vector;
			return vector.y;
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x00123DF4 File Offset: 0x00121FF4
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x74DE90", Offset = "0x74C490", VA = "0x18074DE90")]
		public bool IsClickable()
		{
			if (this.isClicked)
			{
			}
			return !this.hasMissed;
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x00123E18 File Offset: 0x00122018
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x74E430", Offset = "0x74CA30", VA = "0x18074E430")]
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

		// Token: 0x06003625 RID: 13861 RVA: 0x00124060 File Offset: 0x00122260
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x74E290", Offset = "0x74C890", VA = "0x18074E290")]
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

		// Token: 0x06003626 RID: 13862 RVA: 0x001240D8 File Offset: 0x001222D8
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x74E180", Offset = "0x74C780", VA = "0x18074E180")]
		private void TriggerHoldBeatJudge(float currentTime)
		{
			RhythmGameManager.<Instance>k__BackingField.OnHoldBeatJudge(this, currentTime);
			int num = this.trackIndex;
			Debug.Log(string.Format("Hold拍子判定: 轨道{0}, 时间={1:F3}", num, num));
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x00124110 File Offset: 0x00122310
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x74E060", Offset = "0x74C660", VA = "0x18074E060")]
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

		// Token: 0x06003628 RID: 13864 RVA: 0x00124164 File Offset: 0x00122364
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x74DF60", Offset = "0x74C560", VA = "0x18074DF60")]
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

		// Token: 0x06003629 RID: 13865 RVA: 0x001241A4 File Offset: 0x001223A4
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x74E000", Offset = "0x74C600", VA = "0x18074E000")]
		private void OnHoldFailed()
		{
			this.hasMissed = true;
			RhythmGameManager.<Instance>k__BackingField.OnHoldNoteFailed(this);
			this.HideNote();
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x001241D0 File Offset: 0x001223D0
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x74EEE0", Offset = "0x74D4E0", VA = "0x18074EEE0")]
		public FallingNote()
		{
		}

		// Token: 0x04002973 RID: 10611
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002973")]
		[Header("音符数据")]
		public float targetTime;

		// Token: 0x04002974 RID: 10612
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002974")]
		public int trackIndex;

		// Token: 0x04002975 RID: 10613
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002975")]
		public NoteType noteType;

		// Token: 0x04002976 RID: 10614
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002976")]
		[Header("运动参数")]
		public float fallSpeed;

		// Token: 0x04002977 RID: 10615
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002977")]
		public float spawnY;

		// Token: 0x04002978 RID: 10616
		[FieldOffset(Offset = "0x34")]
		[Token(Token = "0x4002978")]
		public float targetY;

		// Token: 0x04002979 RID: 10617
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002979")]
		private bool isClicked;

		// Token: 0x0400297A RID: 10618
		[FieldOffset(Offset = "0x39")]
		[Token(Token = "0x400297A")]
		private bool hasMissed;

		// Token: 0x0400297B RID: 10619
		[FieldOffset(Offset = "0x3A")]
		[Token(Token = "0x400297B")]
		public bool hasAutoPlayed;

		// Token: 0x0400297C RID: 10620
		[FieldOffset(Offset = "0x3B")]
		[Token(Token = "0x400297C")]
		private bool isHolding;

		// Token: 0x0400297D RID: 10621
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400297D")]
		private bool holdCompleted;

		// Token: 0x0400297E RID: 10622
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400297E")]
		private GameObject holdBar;

		// Token: 0x0400297F RID: 10623
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400297F")]
		private GameObject holdTail;

		// Token: 0x04002980 RID: 10624
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002980")]
		private float holdDuration;

		// Token: 0x04002981 RID: 10625
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4002981")]
		private float lastBeatJudgeTime = -1f;

		// Token: 0x04002982 RID: 10626
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002982")]
		private float beatDuration = 0.09375f;

		// Token: 0x04002983 RID: 10627
		[Token(Token = "0x4002983")]
		private const float MISS_WINDOW = 0.2f;
	}
}
