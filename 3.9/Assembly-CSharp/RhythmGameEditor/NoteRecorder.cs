using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RhythmGameEditor
{
	// Token: 0x02000A4D RID: 2637
	[Token(Token = "0x2000A4D")]
	public class NoteRecorder : MonoBehaviour
	{
		// Token: 0x06003619 RID: 13849 RVA: 0x0011FE3C File Offset: 0x0011E03C
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x79CF10", Offset = "0x79B510", VA = "0x18079CF10")]
		public void Initialize(AudioSource source, float beatsPerMinute)
		{
			this.audioSource = source;
			this.bpm = beatsPerMinute;
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x0011FE58 File Offset: 0x0011E058
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x79D740", Offset = "0x79BD40", VA = "0x18079D740")]
		public void SetBPM(float newBpm)
		{
			this.bpm = newBpm;
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x0011FE6C File Offset: 0x0011E06C
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x79D7A0", Offset = "0x79BDA0", VA = "0x18079D7A0")]
		public void StartRecording()
		{
			this.isRecording = true;
			Debug.Log("\ud83c\udfb5 开始录制音符");
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x0011FE8C File Offset: 0x0011E08C
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x79D800", Offset = "0x79BE00", VA = "0x18079D800")]
		public void StopRecording()
		{
			this.isRecording = false;
			Debug.Log("⏹\ufe0f 停止录制音符");
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0011FEAC File Offset: 0x0011E0AC
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x79D980", Offset = "0x79BF80", VA = "0x18079D980")]
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

		// Token: 0x0600361E RID: 13854 RVA: 0x0011FEFC File Offset: 0x0011E0FC
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x79CB50", Offset = "0x79B150", VA = "0x18079CB50")]
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

		// Token: 0x0600361F RID: 13855 RVA: 0x0011FF3C File Offset: 0x0011E13C
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x79CBF0", Offset = "0x79B1F0", VA = "0x18079CBF0")]
		private int GetTrackIndexFromKey(KeyCode key)
		{
			if (this == 0 || this == 0 || this == 0 || this == (ulong)1L || this == 0 || this == 0 || this == 0 || this != (ulong)1L)
			{
			}
			return 0;
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0011FF70 File Offset: 0x0011E170
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x79D320", Offset = "0x79B920", VA = "0x18079D320")]
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

		// Token: 0x06003621 RID: 13857 RVA: 0x00120028 File Offset: 0x0011E228
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x79D750", Offset = "0x79BD50", VA = "0x18079D750")]
		public float SnapToBeat(float time)
		{
			return 0f;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0012003C File Offset: 0x0011E23C
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x79C9B0", Offset = "0x79AFB0", VA = "0x18079C9B0")]
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

		// Token: 0x06003623 RID: 13859 RVA: 0x001200FC File Offset: 0x0011E2FC
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x79CFC0", Offset = "0x79B5C0", VA = "0x18079CFC0")]
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

		// Token: 0x06003624 RID: 13860 RVA: 0x001201BC File Offset: 0x0011E3BC
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x79CF40", Offset = "0x79B540", VA = "0x18079CF40")]
		private IEnumerator PlayOneBeatCoroutine(float targetTime)
		{
			NoteRecorder.<PlayOneBeatCoroutine>d__21 <PlayOneBeatCoroutine>d__;
			<PlayOneBeatCoroutine>d__.System.IDisposable.Dispose();
			<PlayOneBeatCoroutine>d__.<>1__state = (int)((ulong)0L);
			<PlayOneBeatCoroutine>d__.<>4__this = this;
			<PlayOneBeatCoroutine>d__.targetTime = targetTime;
			return null;
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x001201E8 File Offset: 0x0011E3E8
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x79CC40", Offset = "0x79B240", VA = "0x18079CC40")]
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

		// Token: 0x06003626 RID: 13862 RVA: 0x0012023C File Offset: 0x0011E43C
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x79D860", Offset = "0x79BE60", VA = "0x18079D860")]
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

		// Token: 0x06003627 RID: 13863 RVA: 0x00120298 File Offset: 0x0011E498
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x79DA40", Offset = "0x79C040", VA = "0x18079DA40")]
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

		// Token: 0x04002987 RID: 10631
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002987")]
		[Header("录制设置")]
		[Tooltip("是否启用拍子吸附（自动对齐到最近的1/4拍）")]
		public bool enableSnap = true;

		// Token: 0x04002988 RID: 10632
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002988")]
		[Header("按键映射")]
		[Tooltip("轨道按键映射")]
		public KeyCode[] trackKeys;

		// Token: 0x04002989 RID: 10633
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002989")]
		public Action<int, float, float> OnNoteRecorded;

		// Token: 0x0400298A RID: 10634
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400298A")]
		public Action OnPauseToggle;

		// Token: 0x0400298B RID: 10635
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400298B")]
		public Action OnStepForward;

		// Token: 0x0400298C RID: 10636
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400298C")]
		public Action OnStepBackward;

		// Token: 0x0400298D RID: 10637
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400298D")]
		public Action OnNoteDeleted;

		// Token: 0x0400298E RID: 10638
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400298E")]
		private AudioSource audioSource;

		// Token: 0x0400298F RID: 10639
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400298F")]
		private float bpm;

		// Token: 0x04002990 RID: 10640
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4002990")]
		private bool isRecording;
	}
}
