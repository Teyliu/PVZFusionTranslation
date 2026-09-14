using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RhythmGameEditor
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	public class NoteRecorder : MonoBehaviour
	{
		// Token: 0x060034D8 RID: 13528 RVA: 0x0011AC80 File Offset: 0x00118E80
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x7364C0", Offset = "0x734AC0", VA = "0x1807364C0")]
		public void Initialize(AudioSource source, float beatsPerMinute)
		{
			this.audioSource = source;
			this.bpm = beatsPerMinute;
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0011AC9C File Offset: 0x00118E9C
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x736CF0", Offset = "0x7352F0", VA = "0x180736CF0")]
		public void SetBPM(float newBpm)
		{
			this.bpm = newBpm;
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0011ACB0 File Offset: 0x00118EB0
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x736D50", Offset = "0x735350", VA = "0x180736D50")]
		public void StartRecording()
		{
			this.isRecording = true;
			Debug.Log("\ud83c\udfb5 开始录制音符");
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0011ACD0 File Offset: 0x00118ED0
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x736DB0", Offset = "0x7353B0", VA = "0x180736DB0")]
		public void StopRecording()
		{
			this.isRecording = false;
			Debug.Log("⏹\ufe0f 停止录制音符");
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0011ACF0 File Offset: 0x00118EF0
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x736F30", Offset = "0x735530", VA = "0x180736F30")]
		private void Update()
		{
			if (this.isRecording)
			{
				KeyCode[] array = this.trackKeys;
				int num = 0;
				if (num < array.Length)
				{
					int num2 = 0;
					if (num != 0)
					{
						int trackIndexFromKey = this.GetTrackIndexFromKey((KeyCode)num2);
					}
					num++;
					this.RecordNote(num);
				}
				this.DetectControlKeys();
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0011AD40 File Offset: 0x00118F40
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x736100", Offset = "0x734700", VA = "0x180736100")]
		private void DetectTrackKeys()
		{
			KeyCode[] array = this.trackKeys;
			int num = 0;
			if (num < array.Length)
			{
				int num2 = 0;
				if (num != 0)
				{
					int trackIndexFromKey = this.GetTrackIndexFromKey((KeyCode)num2);
				}
				num++;
				this.RecordNote(num);
			}
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0011AD80 File Offset: 0x00118F80
		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x7361A0", Offset = "0x7347A0", VA = "0x1807361A0")]
		private int GetTrackIndexFromKey(KeyCode key)
		{
			if (this == 0 || this == 0 || this == 0 || this == (ulong)1L || this == 0 || this == 0 || this == 0 || this != (ulong)1L)
			{
			}
			return 0;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0011ADB4 File Offset: 0x00118FB4
		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x7368D0", Offset = "0x734ED0", VA = "0x1807368D0")]
		public void RecordNote(int trackIndex)
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			bool flag = audioSource == num;
			if (!flag && flag)
			{
				float time = this.audioSource.time;
				if (this.enableSnap)
				{
				}
				if (this.OnNoteRecorded != 0)
				{
				}
				float num3;
				float num2 = num3 * 4f;
				object[] array = new object[4];
				int num4 = trackIndex + 1;
				if (array != 0)
				{
				}
				array[0] = array;
				if (array != 0)
				{
				}
				array[1] = array;
				if (array != 0)
				{
				}
				array[2] = array;
				if (array != 0)
				{
				}
				array[3] = array;
				Debug.Log(string.Format("✅ 记录音符: 轨道{0} 时间:{1:F3}s | 第{2}.{3}拍", array));
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0011AE6C File Offset: 0x0011906C
		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x736D00", Offset = "0x735300", VA = "0x180736D00")]
		public float SnapToBeat(float time)
		{
			return 0f;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0011AE80 File Offset: 0x00119080
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x735F60", Offset = "0x734560", VA = "0x180735F60")]
		private void DetectControlKeys()
		{
			EventSystem current = EventSystem.current;
			int num = 0;
			if (current != num)
			{
				GameObject currentSelected = EventSystem.current.m_CurrentSelected;
				int num2 = 0;
				if (currentSelected != num2)
				{
					return;
				}
			}
			if (!Input.GetKeyDownInt((KeyCode)((uint)32)) || this.OnPauseToggle != 0)
			{
			}
			if (!Input.GetKeyDownInt((KeyCode)((uint)276)) || this.OnStepBackward != 0)
			{
			}
			if ((!Input.GetKeyDownInt((KeyCode)((uint)275)) && !Input.GetKeyDownInt((KeyCode)((uint)46))) || this.OnStepForward != 0)
			{
			}
			if (Input.GetKeyDownInt((KeyCode)((uint)127)) || Input.GetKeyDownInt((KeyCode)((uint)8)))
			{
				Action onNoteDeleted = this.OnNoteDeleted;
				if (onNoteDeleted != 0)
				{
					IntPtr invoke_impl = onNoteDeleted.invoke_impl;
				}
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0011AF40 File Offset: 0x00119140
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x736570", Offset = "0x734B70", VA = "0x180736570")]
		public void PlayOneBeat()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				base.StopAllCoroutines();
				float time = this.audioSource.time;
				if (this.enableSnap)
				{
				}
				AudioClip clip = this.audioSource.clip;
				int num2 = 0;
				if (clip != num2)
				{
					float length = this.audioSource.clip.length;
				}
				if (!this.audioSource.isPlaying)
				{
					this.audioSource.Play();
				}
				string text;
				Debug.Log(text);
				NoteRecorder.<PlayOneBeatCoroutine>d__21 <PlayOneBeatCoroutine>d__;
				<PlayOneBeatCoroutine>d__.System.IDisposable.Dispose();
				<PlayOneBeatCoroutine>d__.<>1__state = (int)((ulong)0L);
				<PlayOneBeatCoroutine>d__.<>4__this = this;
				<PlayOneBeatCoroutine>d__.targetTime = time;
				Coroutine coroutine = base.StartCoroutine(<PlayOneBeatCoroutine>d__);
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0011B000 File Offset: 0x00119200
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x7364F0", Offset = "0x734AF0", VA = "0x1807364F0")]
		private IEnumerator PlayOneBeatCoroutine(float targetTime)
		{
			NoteRecorder.<PlayOneBeatCoroutine>d__21 <PlayOneBeatCoroutine>d__;
			<PlayOneBeatCoroutine>d__.System.IDisposable.Dispose();
			<PlayOneBeatCoroutine>d__.<>1__state = (int)((ulong)0L);
			<PlayOneBeatCoroutine>d__.<>4__this = this;
			<PlayOneBeatCoroutine>d__.targetTime = targetTime;
			return null;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0011B02C File Offset: 0x0011922C
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x7361F0", Offset = "0x7347F0", VA = "0x1807361F0")]
		public void GoBackOneBeat()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				float time = this.audioSource.time;
				int num2 = 0;
				if (this.enableSnap)
				{
				}
				this.audioSource.time = (float)num2;
				string text;
				Debug.Log(text);
			}
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0011B080 File Offset: 0x00119280
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x736E10", Offset = "0x735410", VA = "0x180736E10")]
		public void TogglePause()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				bool isPlaying = this.audioSource.isPlaying;
				AudioSource audioSource2 = this.audioSource;
				if (!isPlaying)
				{
					audioSource2.UnPause();
				}
				audioSource2.Pause();
				Debug.Log("⏸\ufe0f 已暂停");
				if (this.OnPauseToggle != 0)
				{
				}
			}
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0011B0DC File Offset: 0x001192DC
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x736FF0", Offset = "0x7355F0", VA = "0x180736FF0")]
		public NoteRecorder()
		{
			KeyCode[] array = new KeyCode[]
			{
				KeyCode.Alpha1,
				KeyCode.Alpha2,
				KeyCode.Alpha3,
				KeyCode.Alpha4,
				KeyCode.Keypad1,
				KeyCode.Keypad2,
				KeyCode.Keypad3,
				KeyCode.Keypad4
			};
			this.trackKeys = array;
			base..ctor();
		}

		// Token: 0x04002819 RID: 10265
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002819")]
		[Header("录制设置")]
		[Tooltip("是否启用拍子吸附（自动对齐到最近的1/4拍）")]
		public bool enableSnap = true;

		// Token: 0x0400281A RID: 10266
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400281A")]
		[Header("按键映射")]
		[Tooltip("轨道按键映射")]
		public KeyCode[] trackKeys;

		// Token: 0x0400281B RID: 10267
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400281B")]
		public Action<int, float, float> OnNoteRecorded;

		// Token: 0x0400281C RID: 10268
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400281C")]
		public Action OnPauseToggle;

		// Token: 0x0400281D RID: 10269
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400281D")]
		public Action OnStepForward;

		// Token: 0x0400281E RID: 10270
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400281E")]
		public Action OnStepBackward;

		// Token: 0x0400281F RID: 10271
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400281F")]
		public Action OnNoteDeleted;

		// Token: 0x04002820 RID: 10272
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002820")]
		private AudioSource audioSource;

		// Token: 0x04002821 RID: 10273
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002821")]
		private float bpm;

		// Token: 0x04002822 RID: 10274
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4002822")]
		private bool isRecording;
	}
}
