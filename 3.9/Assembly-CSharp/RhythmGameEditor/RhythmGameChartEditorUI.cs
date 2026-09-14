using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using GameLevel;
using RhythmGame;
using SimpleFileBrowser;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RhythmGameEditor
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	public class RhythmGameChartEditorUI : BaseMenu
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06003634 RID: 13876 RVA: 0x001208D0 File Offset: 0x0011EAD0
		// (set) Token: 0x06003635 RID: 13877 RVA: 0x001208F0 File Offset: 0x0011EAF0
		[Token(Token = "0x1700027B")]
		public string SongName
		{
			[Token(Token = "0x6003634")]
			[Address(RVA = "0x7A4CF0", Offset = "0x7A32F0", VA = "0x1807A4CF0")]
			get
			{
				return this.levelData.musicName;
			}
			[Token(Token = "0x6003635")]
			[Address(RVA = "0x7A4D50", Offset = "0x7A3350", VA = "0x1807A4D50")]
			set
			{
				this.levelData.musicName = value;
				throw new NullReferenceException();
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x00120910 File Offset: 0x0011EB10
		[Token(Token = "0x1700027C")]
		public List<NoteData> RecordedNotes
		{
			[Token(Token = "0x6003636")]
			[Address(RVA = "0x7A4CD0", Offset = "0x7A32D0", VA = "0x1807A4CD0")]
			get
			{
				return this.levelData.notes;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x00120930 File Offset: 0x0011EB30
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x00120950 File Offset: 0x0011EB50
		[Token(Token = "0x1700027D")]
		public float BPM
		{
			[Token(Token = "0x6003637")]
			[Address(RVA = "0x7A4CB0", Offset = "0x7A32B0", VA = "0x1807A4CB0")]
			get
			{
				return this.levelData.bpm;
			}
			[Token(Token = "0x6003638")]
			[Address(RVA = "0x7A4D30", Offset = "0x7A3330", VA = "0x1807A4D30")]
			set
			{
				this.levelData.bpm = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x00120970 File Offset: 0x0011EB70
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x00120990 File Offset: 0x0011EB90
		[Token(Token = "0x1700027E")]
		public float AudioOffset
		{
			[Token(Token = "0x6003639")]
			[Address(RVA = "0x7A4C90", Offset = "0x7A3290", VA = "0x1807A4C90")]
			get
			{
				return this.levelData.audioOffset;
			}
			[Token(Token = "0x600363A")]
			[Address(RVA = "0x7A4D10", Offset = "0x7A3310", VA = "0x1807A4D10")]
			set
			{
				this.levelData.audioOffset = value;
			}
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x001209B0 File Offset: 0x0011EBB0
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x79F340", Offset = "0x79D940", VA = "0x18079F340", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			AudioSource music = GameAPP.music;
			this.audioSource = music;
			SerializedLevelData serializedLevelData = CustomMenu._levelData;
			if (serializedLevelData.rhythmLevelData == (ulong)0L)
			{
				RhythmLevelData rhythmLevelData = new RhythmLevelData();
				serializedLevelData.rhythmLevelData = rhythmLevelData;
			}
			if ((ulong)1L == 0UL)
			{
			}
			RhythmLevelData rhythmLevelData2 = CustomMenu._levelData.rhythmLevelData;
			this.levelData = rhythmLevelData2;
			throw new NullReferenceException();
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00120A0C File Offset: 0x0011EC0C
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x7A1B60", Offset = "0x7A0160", VA = "0x1807A1B60", Slot = "8")]
		public override void OnExit()
		{
			base.OnExit();
			GameAPP.Instance.PlayMusic((MusicType)((uint)1));
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00120A34 File Offset: 0x0011EC34
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x7A2F30", Offset = "0x7A1530", VA = "0x1807A2F30")]
		private void Start()
		{
			this.InitializeSubSystems();
			this.BindUIEvents();
			Slider slider = this.zoomSlider;
			int num = 0;
			if (slider != num)
			{
				this.zoomSlider.maxValue = 50f;
				Slider slider2 = this.zoomSlider;
				float value = slider2.value;
				slider2.value = value;
			}
			if (this.levelData.musicType != MusicType.Loon)
			{
				SoundManager soundManager = GameAPP.soundManager;
				RhythmLevelData rhythmLevelData = this.levelData;
				Dictionary<MusicType, AudioClip> musics = soundManager.musics;
				MusicType musicType = rhythmLevelData.musicType;
				if (musics.ContainsKey(musicType))
				{
					AudioSource audioSource = this.audioSource;
					SoundManager soundManager2 = GameAPP.soundManager;
					RhythmLevelData rhythmLevelData2 = this.levelData;
					Dictionary<MusicType, AudioClip> musics2 = soundManager2.musics;
					MusicType musicType2 = rhythmLevelData2.musicType;
					AudioClip audioClip = musics2[musicType2];
					audioSource.clip = audioClip;
					MusicType musicType3 = this.levelData.musicType;
					Debug.Log(string.Format("✅ 编辑器初始化：已加载音乐 {0}", musicType3));
				}
			}
			this.UpdateUI();
			Debug.Log("\ud83c\udfb5 音游踩点编辑器已初始化");
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00120B38 File Offset: 0x0011ED38
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x7A48F0", Offset = "0x7A2EF0", VA = "0x1807A48F0")]
		private void Update()
		{
			if (this.selectedNoteIndex != -1 && Input.GetMouseButtonDown(0))
			{
				TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
				int num = 0;
				if (timelineRendererLineRenderer != num)
				{
					RectTransform timelineContainer = this.timelineRenderer.timelineContainer;
					int num2 = 0;
					if (timelineContainer != num2)
					{
						RectTransform timelineContainer2 = this.timelineRenderer.timelineContainer;
						int num3 = 0;
						if (timelineContainer2 != num3)
						{
							int num4 = 0;
							Vector3 mousePosition = Input.mousePosition;
							Camera main = Camera.main;
							if (!RectTransformUtility.RectangleContainsScreenPoint(timelineContainer2, num4, main))
							{
								this.ClearNoteSelection();
								Debug.Log("\ud83d\udeab 点击外部区域，已取消选中音符");
								this.UpdateSelectedNoteInfo();
							}
						}
					}
				}
			}
			if (this.isPlaying)
			{
				this.UpdateTimeDisplay();
				TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.timelineRenderer;
				int num5 = 0;
				if (timelineRendererLineRenderer2 != num5)
				{
					RhythmLevelData rhythmLevelData = this.levelData;
					TimelineRendererLineRenderer timelineRendererLineRenderer3 = this.timelineRenderer;
					List<NoteData> notes = rhythmLevelData.notes;
					AudioSource audioSource = this.audioSource;
					int num6 = 0;
					if (audioSource != num6)
					{
						float time = this.audioSource.time;
					}
					int num7 = 0;
					Toggle toggle = this.snapToggle;
					int num8 = 0;
					if (!(toggle != num8))
					{
					}
					bool flag = this.snapToggle.m_IsOn;
					timelineRendererLineRenderer3.UpdateTimeline(notes, (float)num7, flag);
				}
				if (this.autoFollow)
				{
					AudioSource audioSource2 = this.audioSource;
					int num9 = 0;
					if (audioSource2 != num9 && this.audioSource.isPlaying)
					{
						this.UpdateAutoScroll();
					}
				}
			}
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00120CB8 File Offset: 0x0011EEB8
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x7A0660", Offset = "0x79EC60", VA = "0x1807A0660")]
		private void InitializeSubSystems()
		{
			int num2;
			NoteRecorder noteRecorder5;
			Delegate delegate3;
			for (;;)
			{
				TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
				int num = 0;
				bool flag = timelineRendererLineRenderer != num;
				num2 = 0;
				if (flag)
				{
					RhythmLevelData rhythmLevelData = this.levelData;
					TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.timelineRenderer;
					float bpm = rhythmLevelData.bpm;
					AudioSource audioSource = this.audioSource;
					timelineRendererLineRenderer2.Initialize(audioSource, bpm);
					TimelineRendererLineRenderer timelineRendererLineRenderer3 = this.timelineRenderer;
					Action<int> action;
					Delegate @delegate = Delegate.Combine(timelineRendererLineRenderer3.OnNoteSelected, action);
					if (@delegate == 0)
					{
						timelineRendererLineRenderer3.OnNoteSelected = num2;
					}
					if (@delegate == 0)
					{
						goto IL_02F3;
					}
					timelineRendererLineRenderer3.OnNoteSelected = @delegate;
					if (@delegate == 0)
					{
						goto IL_02ED;
					}
					TimelineRendererLineRenderer timelineRendererLineRenderer4 = this.timelineRenderer;
					Action<NoteData> action2;
					if (Delegate.Combine(timelineRendererLineRenderer4.OnNoteDragged, action2) == 0)
					{
						timelineRendererLineRenderer4.OnNoteDragged = num2;
					}
					if (num2 == 0)
					{
						goto IL_02ED;
					}
					timelineRendererLineRenderer4.OnNoteDragged = num2;
					if (num2 == 0)
					{
						goto IL_02ED;
					}
					TimelineRendererLineRenderer timelineRendererLineRenderer5 = this.timelineRenderer;
					Action<float> action3;
					if (Delegate.Combine(timelineRendererLineRenderer5.OnPositionClicked, action3) == 0)
					{
						timelineRendererLineRenderer5.OnPositionClicked = num2;
					}
					if (num2 == 0)
					{
						goto IL_02ED;
					}
					timelineRendererLineRenderer5.OnPositionClicked = num2;
					if (num2 == 0)
					{
						goto IL_02ED;
					}
				}
				NoteRecorder noteRecorder = this.noteRecorder;
				int num3 = 0;
				if (!(noteRecorder != num3))
				{
					goto IL_02B0;
				}
				RhythmLevelData rhythmLevelData2 = this.levelData;
				NoteRecorder noteRecorder2 = this.noteRecorder;
				float bpm2 = rhythmLevelData2.bpm;
				AudioSource audioSource2 = this.audioSource;
				noteRecorder2.audioSource = audioSource2;
				noteRecorder2.bpm = bpm2;
				NoteRecorder noteRecorder3 = this.noteRecorder;
				Action<int, float, float> action4;
				if (Delegate.Combine(noteRecorder3.OnNoteRecorded, action4) == 0)
				{
					noteRecorder3.OnNoteRecorded = num2;
				}
				if (num2 != 0)
				{
					noteRecorder3.OnNoteRecorded = num2;
					if (num2 != 0)
					{
						NoteRecorder noteRecorder4 = this.noteRecorder;
						Action onPauseToggle = noteRecorder4.OnPauseToggle;
						Action action5 = new Action(this.TogglePause);
						Delegate delegate2 = Delegate.Combine(onPauseToggle, action5);
						if (delegate2 == 0)
						{
							noteRecorder4.OnPauseToggle = num2;
						}
						if (delegate2 != 0)
						{
							noteRecorder4.OnPauseToggle = delegate2;
							if (delegate2 != 0)
							{
								noteRecorder5 = this.noteRecorder;
								Action onStepForward = noteRecorder5.OnStepForward;
								Action action6 = new Action(this.PlayOneBeat);
								delegate3 = Delegate.Combine(onStepForward, action6);
								if (delegate3 == 0)
								{
									noteRecorder5.OnStepForward = num2;
								}
								if (delegate3 != 0)
								{
									break;
								}
							}
						}
					}
				}
			}
			noteRecorder5.OnStepForward = delegate3;
			if (delegate3 == 0)
			{
				goto IL_02F3;
			}
			NoteRecorder noteRecorder6 = this.noteRecorder;
			Action onStepBackward = noteRecorder6.OnStepBackward;
			Action action7 = new Action(this.GoBackOneBeat);
			Delegate delegate4 = Delegate.Combine(onStepBackward, action7);
			if (delegate4 == 0)
			{
				noteRecorder6.OnStepBackward = num2;
			}
			if (delegate4 == 0)
			{
				goto IL_02F3;
			}
			noteRecorder6.OnStepBackward = delegate4;
			if (delegate4 == 0)
			{
				goto IL_02F3;
			}
			NoteRecorder noteRecorder7 = this.noteRecorder;
			Action onNoteDeleted = noteRecorder7.OnNoteDeleted;
			Action action8 = new Action(this.OnNoteDeleted);
			Delegate delegate5 = Delegate.Combine(onNoteDeleted, action8);
			if (delegate5 == 0)
			{
				noteRecorder7.OnNoteDeleted = num2;
			}
			if (delegate5 == 0)
			{
				goto IL_02F3;
			}
			noteRecorder7.OnNoteDeleted = delegate5;
			if (delegate5 == 0)
			{
				goto IL_02F3;
			}
			IL_02B0:
			RhythmEditorDataManager rhythmEditorDataManager = this.dataManager;
			int num4 = 0;
			if (rhythmEditorDataManager == num4)
			{
				RhythmEditorDataManager rhythmEditorDataManager2 = base.gameObject.AddComponent<RhythmEditorDataManager>();
				this.dataManager = rhythmEditorDataManager2;
			}
			Debug.Log("✅ 子系统初始化完成");
			return;
			IL_02ED:
			throw new InvalidCastException();
			IL_02F3:
			throw new InvalidCastException();
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00120FC0 File Offset: 0x0011F1C0
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x79F4E0", Offset = "0x79DAE0", VA = "0x18079F4E0")]
		private void BindUIEvents()
		{
			TheButton theButton = this.loadBgmButton;
			int num = 0;
			if (theButton != num)
			{
				UnityEvent theEvent_up = this.loadBgmButton.theEvent_up;
				UnityAction unityAction = new UnityAction(this.LoadBGM);
				theEvent_up.AddListener(unityAction);
			}
			TheButton theButton2 = this.playButton;
			int num2 = 0;
			if (theButton2 != num2)
			{
				UnityEvent theEvent_up2 = this.playButton.theEvent_up;
				UnityAction unityAction2 = new UnityAction(this.StartRecording);
				theEvent_up2.AddListener(unityAction2);
			}
			TheButton theButton3 = this.pauseButton;
			int num3 = 0;
			if (theButton3 != num3)
			{
				UnityEvent theEvent_up3 = this.pauseButton.theEvent_up;
				UnityAction unityAction3 = new UnityAction(this.TogglePause);
				theEvent_up3.AddListener(unityAction3);
			}
			TheButton theButton4 = this.stopButton;
			int num4 = 0;
			if (theButton4 != num4)
			{
				UnityEvent theEvent_up4 = this.stopButton.theEvent_up;
				UnityAction unityAction4 = new UnityAction(this.StopRecording);
				theEvent_up4.AddListener(unityAction4);
			}
			TheButton theButton5 = this.saveJsonButton;
			int num5 = 0;
			if (theButton5 != num5)
			{
				UnityEvent theEvent_up5 = this.saveJsonButton.theEvent_up;
				UnityAction unityAction5 = new UnityAction(this.SaveAsJSON);
				theEvent_up5.AddListener(unityAction5);
			}
			TheButton theButton6 = this.loadJsonButton;
			int num6 = 0;
			if (theButton6 != num6)
			{
				UnityEvent theEvent_up6 = this.loadJsonButton.theEvent_up;
				UnityAction unityAction6 = new UnityAction(this.LoadFromJSON);
				theEvent_up6.AddListener(unityAction6);
			}
			TheButton theButton7 = this.copyCodeButton;
			int num7 = 0;
			if (theButton7 != num7)
			{
				UnityEvent theEvent_up7 = this.copyCodeButton.theEvent_up;
				UnityAction unityAction7 = new UnityAction(this.CopyToClipboard);
				theEvent_up7.AddListener(unityAction7);
			}
			TheButton theButton8 = this.clearDataButton;
			int num8 = 0;
			if (theButton8 != num8)
			{
				UnityEvent theEvent_up8 = this.clearDataButton.theEvent_up;
				UnityAction unityAction8 = new UnityAction(this.ClearData);
				theEvent_up8.AddListener(unityAction8);
			}
			TheButton theButton9 = this.closeButton;
			int num9 = 0;
			if (theButton9 != num9)
			{
				UnityAction unityAction9;
				this.closeButton.theEvent_up.AddListener(unityAction9);
			}
			Slider slider = this.zoomSlider;
			int num10 = 0;
			if (slider != num10)
			{
				UnityAction<float> unityAction10;
				this.zoomSlider.m_OnValueChanged.AddListener(unityAction10);
			}
			Scrollbar scrollbar = this.scrollScrollbar;
			int num11 = 0;
			if (scrollbar != num11)
			{
				UnityAction<float> unityAction11;
				this.scrollScrollbar.m_OnValueChanged.AddListener(unityAction11);
			}
			TMP_InputField tmp_InputField = this.bpmInputField;
			int num12 = 0;
			if (tmp_InputField != num12)
			{
				UnityAction<string> unityAction12;
				this.bpmInputField.m_OnEndEdit.AddListener(unityAction12);
			}
			TMP_InputField tmp_InputField2 = this.songNameInputField;
			int num13 = 0;
			if (tmp_InputField2 != num13)
			{
				UnityAction<string> unityAction13;
				this.songNameInputField.m_OnEndEdit.AddListener(unityAction13);
			}
			TMP_InputField tmp_InputField3 = this.audioOffsetInputField;
			int num14 = 0;
			if (tmp_InputField3 != num14)
			{
				UnityAction<string> unityAction14;
				this.audioOffsetInputField.m_OnEndEdit.AddListener(unityAction14);
			}
			Toggle toggle = this.autoFollowToggle;
			int num15 = 0;
			if (toggle != num15)
			{
				Toggle.ToggleEvent onValueChanged = this.autoFollowToggle.onValueChanged;
				UnityAction<bool> unityAction15 = delegate(bool value)
				{
					this.autoFollow = value;
				};
				onValueChanged.AddListener(unityAction15);
			}
			TMP_Dropdown tmp_Dropdown = this.dropdown;
			int num16 = 0;
			if (tmp_Dropdown != num16)
			{
				List<TMP_Dropdown.OptionData> list = new List();
				new TMP_Dropdown.OptionData().m_Text = "预设BGM";
				MusicType[] enumValues = global::Core.Lawnf.GetEnumValues<MusicType>();
				int num17 = 0;
				if (num17 < enumValues.Length)
				{
					TMP_Dropdown.OptionData optionData = new TMP_Dropdown.OptionData();
					int num18 = 0;
					string text = SoundManager.MusicNames[num18];
					optionData.m_Text = text;
					int size = list._size;
					num17++;
					list._size = num17;
					num17++;
				}
				this.dropdown.AddOptions(list);
				UnityAction<int> unityAction16;
				this.dropdown.m_OnValueChanged.AddListener(unityAction16);
			}
			Debug.Log("✅ UI事件绑定完成");
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00121384 File Offset: 0x0011F584
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x7A0E70", Offset = "0x79F470", VA = "0x1807A0E70")]
		private void LoadBGM()
		{
			ulong num;
			FileBrowser.SetFilters(num != 0UL, new string[] { ".mp3", ".wav", ".ogg" });
			bool flag = FileBrowser.SetDefaultFilter(".mp3");
			FileBrowser.OnSuccess onSuccess = delegate(string[] paths)
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			FileBrowser.OnCancel <>9__54_ = RhythmGameChartEditorUI.<>c.<>9__54_1;
			if (<>9__54_ == 0)
			{
				RhythmGameChartEditorUI.<>c.<>9__54_1 = delegate
				{
				};
			}
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			string text;
			string text2;
			bool flag2 = FileBrowser.ShowLoadDialog(onSuccess, <>9__54_, (FileBrowser.PickMode)num4, num3 != 0, num2, num2, text, text2);
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00121424 File Offset: 0x0011F624
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x7A2CB0", Offset = "0x7A12B0", VA = "0x1807A2CB0")]
		private void StartRecording()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				AudioClip clip = this.audioSource.clip;
				int num2 = 0;
				if (!(clip == num2))
				{
					this.audioSource.Stop();
					AudioSource audioSource2 = this.audioSource;
					int num3 = 0;
					audioSource2.time = (float)num3;
					this.audioSource.Play();
					NoteRecorder noteRecorder = this.noteRecorder;
					this.isPlaying = true;
					int num4 = 0;
					if (noteRecorder != num4)
					{
						this.noteRecorder.isRecording = true;
						Debug.Log("\ud83c\udfb5 开始录制音符");
					}
					RhythmLevelData rhythmLevelData = this.levelData;
					float bpm = rhythmLevelData.bpm;
					Debug.Log(string.Format("\ud83c\udfb5 开始踩点录制！BPM: {0}", rhythmLevelData));
					Debug.Log("\ud83c\udfb9 按键盘 1/2/3/4 打点");
					this.UpdateUI();
					return;
				}
			}
			Debug.LogWarning("❌ 请先加载BGM！");
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00121504 File Offset: 0x0011F704
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x7A3200", Offset = "0x7A1800", VA = "0x1807A3200")]
		private void StopRecording()
		{
			AudioSource audioSource = this.audioSource;
			this.isPlaying = false;
			int num = 0;
			if (audioSource != num)
			{
				this.audioSource.Stop();
			}
			NoteRecorder noteRecorder = this.noteRecorder;
			int num2 = 0;
			if (noteRecorder != num2)
			{
				this.noteRecorder.isRecording = false;
				Debug.Log("⏹\ufe0f 停止录制音符");
			}
			List<NoteData> notes = this.levelData.notes;
			Comparison<NoteData> comparison;
			if (RhythmGameChartEditorUI.<>c.<>9__56_0 == 0)
			{
				RhythmGameChartEditorUI.<>c.<>9__56_0 = comparison;
			}
			notes.Sort(comparison);
			int size = this.levelData.notes._size;
			Debug.Log(string.Format("⏹\ufe0f 停止录制！共记录 {0} 个音符", size));
			this.UpdateUI();
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x001215B4 File Offset: 0x0011F7B4
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x7A34D0", Offset = "0x7A1AD0", VA = "0x1807A34D0")]
		private void TogglePause()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				bool flag = this.audioSource.isPlaying;
				AudioSource audioSource2 = this.audioSource;
				if (!flag)
				{
					audioSource2.UnPause();
				}
				audioSource2.Pause();
				Debug.Log("⏸\ufe0f 已暂停");
				this.UpdateUI();
			}
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00121610 File Offset: 0x0011F810
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x7A2B80", Offset = "0x7A1180", VA = "0x1807A2B80")]
		private void PlayOneBeat()
		{
			NoteRecorder noteRecorder = this.noteRecorder;
			int num = 0;
			if (noteRecorder != num)
			{
				this.noteRecorder.PlayOneBeat();
			}
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00121644 File Offset: 0x0011F844
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x7A05E0", Offset = "0x79EBE0", VA = "0x1807A05E0")]
		private void GoBackOneBeat()
		{
			NoteRecorder noteRecorder = this.noteRecorder;
			int num = 0;
			if (noteRecorder != num)
			{
				this.noteRecorder.GoBackOneBeat();
			}
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00121678 File Offset: 0x0011F878
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x7A1E30", Offset = "0x7A0430", VA = "0x1807A1E30")]
		private void OnNoteRecorded(int trackIndex, float time, float bpm)
		{
			Toggle toggle = this.holdModeToggle;
			int num = 0;
			if (toggle != num && this.holdModeToggle.m_IsOn)
			{
				if (this.isRecordingHold)
				{
					if (this.currentHoldNote != (ulong)0L)
					{
						NoteData noteData = this.currentHoldNote;
						if (noteData.track == trackIndex)
						{
							noteData.endTime = time;
							this.isRecordingHold = false;
							this.currentHoldNote = (ulong)0L;
							int num2 = trackIndex + 1;
							Debug.Log(string.Format("✅ 结束Hold音符: 轨道{0} 结束时间:{1:F3}s", num2, num2));
							InGameText instance = InGameText.Instance;
							int num3 = trackIndex + 1;
							string text = string.Format("结束Hold音符 (轨道{0})", instance);
						}
					}
					Debug.LogWarning("⚠\ufe0f 请在同一轨道完成Hold音符");
					InGameText instance2 = InGameText.Instance;
				}
				this.currentHoldNote = new NoteData
				{
					time = time,
					track = trackIndex,
					type = (NoteType)((ulong)1L),
					spawned = false,
					endTime = 0f
				};
				List<NoteData> notes = this.levelData.notes;
				int num4 = trackIndex + 1;
				this.isRecordingHold = true;
				Debug.Log(string.Format("\ud83c\udfb5 开始Hold音符: 轨道{0} 开始时间:{1:F3}s", num4, num4));
				InGameText instance3 = InGameText.Instance;
				int num5 = trackIndex + 1;
				string text2 = string.Format("开始Hold音符 (轨道{0})", instance3);
			}
			NoteData noteData2 = new NoteData();
			noteData2.time = time;
			noteData2.track = trackIndex;
			noteData2.type = (NoteType)((ulong)0L);
			noteData2.spawned = false;
			List<NoteData> notes2 = this.levelData.notes;
			int num6 = trackIndex + 1;
			Debug.Log(string.Format("✅ 记录音符: 轨道{0} 时间:{1:F3}s", num6, num6));
			this.UpdateUI();
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00121810 File Offset: 0x0011FA10
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x7A2320", Offset = "0x7A0920", VA = "0x1807A2320")]
		private void OnNoteSelected(int noteIndex)
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
			this.selectedNoteIndex = noteIndex;
			int num = 0;
			bool flag = timelineRendererLineRenderer != num;
			if (flag)
			{
				this.timelineRenderer.selectedNoteIndex = noteIndex;
			}
			Debug.Log(string.Format("✅ 已选中音符: {0}", flag));
			this.UpdateSelectedNoteInfo();
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00121864 File Offset: 0x0011FA64
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x7A0370", Offset = "0x79E970", VA = "0x1807A0370")]
		private void ClearNoteSelection()
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
			this.selectedNoteIndex = (int)((ulong)4294967295L);
			int num = 0;
			if (timelineRendererLineRenderer != num)
			{
				this.timelineRenderer.selectedNoteIndex = (int)((ulong)4294967295L);
				this.timelineRenderer.ClearSelection();
			}
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x001218BC File Offset: 0x0011FABC
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x7A00D0", Offset = "0x79E6D0", VA = "0x1807A00D0")]
		private void CheckClickOutsideToDeselect()
		{
			if (this.selectedNoteIndex != -1 && Input.GetMouseButtonDown(0))
			{
				TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
				int num = 0;
				if (timelineRendererLineRenderer != num)
				{
					RectTransform timelineContainer = this.timelineRenderer.timelineContainer;
					int num2 = 0;
					if (timelineContainer != num2)
					{
						RectTransform timelineContainer2 = this.timelineRenderer.timelineContainer;
						int num3 = 0;
						if (timelineContainer2 != num3)
						{
							int num4 = 0;
							Vector3 mousePosition = Input.mousePosition;
							Camera main = Camera.main;
							if (!RectTransformUtility.RectangleContainsScreenPoint(timelineContainer2, num4, main))
							{
								this.ClearNoteSelection();
								Debug.Log("\ud83d\udeab 点击外部区域，已取消选中音符");
								this.UpdateSelectedNoteInfo();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00121968 File Offset: 0x0011FB68
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x7A2430", Offset = "0x7A0A30", VA = "0x1807A2430")]
		private void OnPositionClicked(float clickTime)
		{
			if (this.selectedNoteIndex == -1)
			{
				AudioSource audioSource = this.audioSource;
				int num = 0;
				if (audioSource != num)
				{
					AudioSource audioSource2 = this.audioSource;
					AudioClip clip = audioSource2.clip;
					float length = clip.length;
					int num2;
					if (0 > (int)clickTime || clickTime > length)
					{
						num2 = 0;
					}
					audioSource2.time = (float)num2;
					Debug.Log(string.Format("⏭\ufe0f 跳转到 {0:F3}s", clip));
				}
				return;
			}
			this.ClearNoteSelection();
			Debug.Log("\ud83d\udeab 已取消选中音符");
			this.UpdateSelectedNoteInfo();
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x001219EC File Offset: 0x0011FBEC
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x7A1E10", Offset = "0x7A0410", VA = "0x1807A1E10")]
		private void OnNoteDragged(NoteData note)
		{
			this.UpdateUI();
			this.UpdateSelectedNoteInfo();
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00121A08 File Offset: 0x0011FC08
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x7A3A20", Offset = "0x7A2020", VA = "0x1807A3A20")]
		private void UpdateSelectedNoteInfo()
		{
			TextMeshProUGUI textMeshProUGUI = this.selectedNoteInfoText;
			int num = 0;
			if (!(textMeshProUGUI == num))
			{
				int size = this.levelData.notes._size;
				if (this.selectedNoteIndex >= size)
				{
					TextMeshProUGUI textMeshProUGUI2 = this.selectedNoteInfoText;
					throw new NullReferenceException();
				}
				List<NoteData> notes = this.levelData.notes;
				int num2 = this.selectedNoteIndex;
				NoteData noteData = notes[num2];
				string text = "Normal";
				if (noteData.type == NoteType.Hold)
				{
					text = "Hold";
				}
				int num3 = this.selectedNoteIndex;
				num3++;
				int num4 = noteData.track;
				num4++;
				string text2 = string.Format("选中: 音符#{0} | 轨道: {1} | 类型: {2}", noteData, noteData, text);
				RhythmLevelData rhythmLevelData = this.levelData;
				if (noteData.type != NoteType.Hold)
				{
					float bpm = rhythmLevelData.bpm;
					float num5;
					int num6;
					int num7;
					string text3 = string.Format(" | 时间: {0:F3}s ({1}.{2}拍)", num5, num6, num7);
					string text4 = text2 + text3;
				}
				float bpm2 = rhythmLevelData.bpm;
				float bpm3 = rhythmLevelData.bpm;
				float num9;
				float num8 = num9 * 4f;
				float num10;
				int num11;
				int num12;
				string text5 = string.Format(" | 开始: {0:F3}s ({1}.{2}拍)", num10, num11, num12);
				string text6 = " | 开始: {0:F3}s ({1}.{2}拍)" + text5;
				string text7 = string.Format(" | 结束: {0:F3}s ({1}.{2}拍)", text6, text6, text6);
				string text8 = text6 + text7;
				string text9 = string.Format(" | 持续: {0:F3}s", text8);
				string text10 = text8 + text9;
				this.selectedNoteInfoText.text = text10;
			}
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00121B78 File Offset: 0x0011FD78
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x7A2A00", Offset = "0x7A1000", VA = "0x1807A2A00")]
		public void OpenFile()
		{
			string dataPath = SaveInfo.GetDataPath();
			if (!Directory.Exists(dataPath))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(dataPath);
			}
			string fullPath = Path.GetFullPath(dataPath);
			string text = "file://" + fullPath;
			Application.OpenURL(text);
			InGameText instance = InGameText.Instance;
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00121BCC File Offset: 0x0011FDCC
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x7A2C00", Offset = "0x7A1200", VA = "0x1807A2C00")]
		private void SaveAsJSON()
		{
			RhythmEditorDataManager rhythmEditorDataManager = this.dataManager;
			int num = 0;
			if (rhythmEditorDataManager != num)
			{
				RhythmLevelData rhythmLevelData = this.levelData;
				RhythmEditorDataManager rhythmEditorDataManager2 = this.dataManager;
				MusicType musicType = rhythmLevelData.musicType;
				float audioOffset = rhythmLevelData.audioOffset;
				float bpm = rhythmLevelData.bpm;
				string musicName = rhythmLevelData.musicName;
				List<NoteData> notes = rhythmLevelData.notes;
				rhythmEditorDataManager2.SaveAsJSON(notes, musicName, bpm, audioOffset, musicType);
			}
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00121C38 File Offset: 0x0011FE38
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x7A1100", Offset = "0x79F700", VA = "0x1807A1100")]
		private void LoadFromJSON()
		{
			string text;
			for (;;)
			{
				string[] files = Directory.GetFiles(Path.Combine(Application.persistentDataPath, "RhythmCharts"), "*.json");
				if (files.Length == 0)
				{
					break;
				}
				int length = files.Length;
				text = files[length];
				RhythmEditorDataManager rhythmEditorDataManager = this.dataManager;
				int num = 0;
				if (rhythmEditorDataManager != num)
				{
					goto Block_1;
				}
			}
			Debug.LogWarning("❌ 没有找到保存的谱面文件");
			return;
			Block_1:
			RhythmLevelData rhythmLevelData = this.dataManager.LoadFromJSON(text);
			while (rhythmLevelData == 0)
			{
			}
			this.LoadLevelData(rhythmLevelData);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00121CBC File Offset: 0x0011FEBC
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x7A12A0", Offset = "0x79F8A0", VA = "0x1807A12A0")]
		private void LoadLevelData(RhythmLevelData data)
		{
			int num;
			List<NoteData> notes3;
			do
			{
				List<NoteData> notes = this.levelData.notes;
				int size = notes._size;
				num = 0;
				notes._size = num;
				if (size > 0)
				{
				}
				List<NoteData> notes2 = data.notes;
				bool flag;
				if (flag)
				{
					notes3 = this.levelData.notes;
					NoteData noteData = new NoteData();
					noteData.time = (float)num;
					noteData.track = noteData;
					noteData.type = noteData;
					noteData.spawned = false;
					noteData.endTime = noteData;
					int size2 = notes3._size;
					notes3._size = noteData;
					noteData.endTime = noteData;
				}
			}
			while (num != 0);
			Comparison<NoteData> comparison;
			if (RhythmGameChartEditorUI.<>c.<>9__70_0 == 0)
			{
				RhythmGameChartEditorUI.<>c <> = RhythmGameChartEditorUI.<>c.<>9;
				RhythmGameChartEditorUI.<>c.<>9__70_0 = comparison;
			}
			notes3.Sort(comparison);
			notes3._size = comparison;
			notes3._size = typeof(RhythmGameChartEditorUI.<>c).TypeHandle;
			notes3._size = typeof(RhythmGameChartEditorUI.<>c).TypeHandle;
			Dictionary<MusicType, AudioClip> musics = GameAPP.soundManager.musics;
			bool flag2;
			string text;
			if (flag2)
			{
				Dictionary<MusicType, AudioClip> musics2 = GameAPP.soundManager.musics;
				AudioClip audioClip;
				text = string.Format("✅ 已恢复预设音乐: {0}", audioClip);
				Debug.Log(text);
			}
			bool flag3;
			if (flag3)
			{
			}
			bool flag4;
			if (flag4)
			{
			}
			Debug.Log(string.Format("✅ 成功加载谱面: {0} ({1}个音符)", text, flag4));
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00121E1C File Offset: 0x0012001C
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x7A0410", Offset = "0x79EA10", VA = "0x1807A0410")]
		private void CopyToClipboard()
		{
			RhythmEditorDataManager rhythmEditorDataManager = this.dataManager;
			int num = 0;
			if (rhythmEditorDataManager != num)
			{
				RhythmLevelData rhythmLevelData = this.levelData;
				RhythmEditorDataManager rhythmEditorDataManager2 = this.dataManager;
				float bpm = rhythmLevelData.bpm;
				string musicName = rhythmLevelData.musicName;
				List<NoteData> notes = rhythmLevelData.notes;
				string text = rhythmEditorDataManager2.GenerateCSharpCode(notes, musicName, bpm);
				if (!string.IsNullOrEmpty(text))
				{
					GUIUtility.systemCopyBuffer = text;
					Debug.Log("\ud83d\udccb 已复制到剪贴板");
				}
				int size = this.levelData.notes._size;
				Debug.Log(string.Format("\ud83d\udccb 已复制{0}个音符的C#代码到剪贴板", size));
			}
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00121EB4 File Offset: 0x001200B4
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x7A02B0", Offset = "0x79E8B0", VA = "0x1807A02B0")]
		private void ClearData()
		{
			List<NoteData> notes = this.levelData.notes;
			int size = notes._size;
			notes._size = (int)((ulong)0L);
			if (size > 0)
			{
			}
			this.ClearNoteSelection();
			Debug.Log("\ud83d\uddd1\ufe0f 已清空所有记录的音符数据");
			this.UpdateUI();
			this.UpdateSelectedNoteInfo();
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00121F08 File Offset: 0x00120108
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x7A4370", Offset = "0x7A2970", VA = "0x1807A4370")]
		private void UpdateUI()
		{
			TextMeshProUGUI textMeshProUGUI = this.songNameText;
			int num = 0;
			if (textMeshProUGUI != num)
			{
				RhythmLevelData rhythmLevelData = this.levelData;
				TextMeshProUGUI textMeshProUGUI2 = this.songNameText;
				string musicName = rhythmLevelData.musicName;
				string text = "歌曲: " + musicName;
				textMeshProUGUI2.text = text;
			}
			TextMeshProUGUI textMeshProUGUI3 = this.bpmText;
			int num2 = 0;
			if (textMeshProUGUI3 != num2)
			{
				RhythmLevelData rhythmLevelData2 = this.levelData;
				TextMeshProUGUI textMeshProUGUI4 = this.bpmText;
				float bpm = rhythmLevelData2.bpm;
				string text2 = string.Format("BPM: {0}", rhythmLevelData2);
				textMeshProUGUI4.text = text2;
			}
			TextMeshProUGUI textMeshProUGUI5 = this.noteCountText;
			int num3 = 0;
			if (textMeshProUGUI5 != num3)
			{
				RhythmLevelData rhythmLevelData3 = this.levelData;
				TextMeshProUGUI textMeshProUGUI6 = this.noteCountText;
				int size = rhythmLevelData3.notes._size;
				string text3 = string.Format("已记录: {0} 个音符", size);
				textMeshProUGUI6.text = text3;
			}
			TMP_InputField tmp_InputField = this.bpmInputField;
			int num4 = 0;
			if (tmp_InputField != num4)
			{
				RhythmLevelData rhythmLevelData4 = this.levelData;
				TMP_InputField tmp_InputField2 = this.bpmInputField;
				float bpm2 = rhythmLevelData4.bpm;
				string text4;
				tmp_InputField2.text = text4;
			}
			TMP_InputField tmp_InputField3 = this.songNameInputField;
			int num5 = 0;
			if (tmp_InputField3 != num5)
			{
				RhythmLevelData rhythmLevelData5 = this.levelData;
				TMP_InputField tmp_InputField4 = this.songNameInputField;
				string musicName2 = rhythmLevelData5.musicName;
				tmp_InputField4.text = musicName2;
			}
			TMP_InputField tmp_InputField5 = this.audioOffsetInputField;
			int num6 = 0;
			if (tmp_InputField5 != num6)
			{
				RhythmLevelData rhythmLevelData6 = this.levelData;
				TMP_InputField tmp_InputField6 = this.audioOffsetInputField;
				float audioOffset = rhythmLevelData6.audioOffset;
				string text5;
				tmp_InputField6.text = text5;
			}
			TheButton theButton = this.playButton;
			int num7 = 0;
			if (theButton != num7)
			{
				GameObject gameObject = this.playButton.gameObject;
				bool flag = !this.isPlaying;
				gameObject.SetActive(flag);
			}
			TheButton theButton2 = this.pauseButton;
			int num8 = 0;
			if (theButton2 != num8)
			{
				GameObject gameObject2 = this.pauseButton.gameObject;
				bool flag2 = this.isPlaying;
				gameObject2.SetActive(flag2);
				TextMeshProUGUI componentInChildren = this.pauseButton.GetComponentInChildren<TextMeshProUGUI>();
				bool flag3 = this.audioSource.isPlaying;
				string text6 = "继续";
				if (flag3)
				{
					text6 = "暂停";
				}
				componentInChildren.text = text6;
			}
			TheButton theButton3 = this.stopButton;
			int num9 = 0;
			if (theButton3 != num9)
			{
				GameObject gameObject3 = this.stopButton.gameObject;
				bool flag4 = this.isPlaying;
				gameObject3.SetActive(flag4);
			}
			TMP_Dropdown tmp_Dropdown = this.dropdown;
			int num10 = 0;
			if (tmp_Dropdown != num10)
			{
				RhythmLevelData rhythmLevelData7 = this.levelData;
				TMP_Dropdown tmp_Dropdown2 = this.dropdown;
				MusicType musicType = rhythmLevelData7.musicType;
			}
			CursorChange.SetDefaultCursor();
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x001221AC File Offset: 0x001203AC
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x7A3F70", Offset = "0x7A2570", VA = "0x1807A3F70")]
		private void UpdateTimeDisplay()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				float time = this.audioSource.time;
				TextMeshProUGUI textMeshProUGUI = this.timeText;
				int num2 = 0;
				bool flag = textMeshProUGUI != num2;
				if (flag)
				{
					TextMeshProUGUI textMeshProUGUI2 = this.timeText;
					string text = string.Format("时间: {0:F2}s", flag);
					textMeshProUGUI2.text = text;
				}
				AudioClip clip = this.audioSource.clip;
				int num3 = 0;
				if (clip != num3)
				{
					TextMeshProUGUI textMeshProUGUI3 = this.timeText;
					string text2 = textMeshProUGUI3.text;
					AudioClip clip2 = this.audioSource.clip;
					float length = clip2.length;
					string text3 = string.Format("/{0:F2}s", clip2);
					string text4 = text2 + text3;
					textMeshProUGUI3.text = text4;
				}
				TextMeshProUGUI textMeshProUGUI4 = this.beatText;
				int num4 = 0;
				if (textMeshProUGUI4 != num4)
				{
					RhythmLevelData rhythmLevelData = this.levelData;
					float num6;
					float num5 = num6 * 4f;
					string text5;
					this.beatText.text = text5;
				}
			}
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x001222B8 File Offset: 0x001204B8
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x7A3800", Offset = "0x7A1E00", VA = "0x1807A3800")]
		private void UpdateAutoScroll()
		{
			AudioSource audioSource = this.audioSource;
			int num = 0;
			if (!(audioSource == num))
			{
				AudioClip clip = this.audioSource.clip;
				int num2 = 0;
				if (!(clip == num2))
				{
					TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
					int num3 = 0;
					if (!(timelineRendererLineRenderer == num3))
					{
						float length = this.audioSource.clip.length;
						float time = this.audioSource.time;
						TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.timelineRenderer;
						if (length < length)
						{
							float num4 = length * timelineRendererLineRenderer2.timelineScroll;
							if (time > 0.8f)
							{
								int num5 = 0;
								num4 = length;
								int num6;
								if (num5 > (int)time || time > num4)
								{
									num6 = 0;
								}
								if (num5 <= num6)
								{
								}
								Scrollbar scrollbar = this.scrollScrollbar;
								timelineRendererLineRenderer2.timelineScroll = (float)num6;
								int num7 = 0;
								if (scrollbar != num7)
								{
									this.scrollScrollbar.value = (float)num6;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x001223A8 File Offset: 0x001205A8
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x7A26A0", Offset = "0x7A0CA0", VA = "0x1807A26A0")]
		private void OnZoomChanged(float value)
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
			int num = 0;
			if (!(timelineRendererLineRenderer == num))
			{
				AudioSource audioSource = this.audioSource;
				int num2 = 0;
				if (!(audioSource == num2))
				{
					AudioClip clip = this.audioSource.clip;
					int num3 = 0;
					if (!(clip == num3))
					{
						float length = this.audioSource.clip.length;
						float num4 = this.audioSource.time;
						TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.timelineRenderer;
						num4 = length;
						int num5 = 0;
						float num6 = num4 * timelineRendererLineRenderer2.timelineScroll;
						if (num5 > (int)num6 || num6 > length)
						{
						}
						if (length <= (float)num5 || num5 > (int)num4 || num4 > (float)1065353216)
						{
						}
						timelineRendererLineRenderer2.timelineZoom = value;
						int num7;
						if (num5 > (int)num4 || num4 > length)
						{
							num7 = 0;
						}
						if (length > length)
						{
						}
						int num8;
						if (num5 > num7 || num7 > 1065353216)
						{
							num8 = 0;
						}
						TimelineRendererLineRenderer timelineRendererLineRenderer3 = this.timelineRenderer;
						Scrollbar scrollbar = this.scrollScrollbar;
						timelineRendererLineRenderer3.timelineScroll = (float)num8;
						int num9 = 0;
						if (scrollbar != num9)
						{
							this.scrollScrollbar.value = (float)num8;
							if (1065353216 > 1065353216)
							{
							}
							this.scrollScrollbar.size = 0.05f;
						}
						TextMeshProUGUI textMeshProUGUI = this.zoomText;
						int num10 = 0;
						bool flag = textMeshProUGUI != num10;
						if (flag)
						{
							TextMeshProUGUI textMeshProUGUI2 = this.zoomText;
							string text = string.Format("{0:F1}x", flag);
							textMeshProUGUI2.text = text;
						}
					}
				}
			}
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00122524 File Offset: 0x00120724
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x7A25D0", Offset = "0x7A0BD0", VA = "0x1807A25D0")]
		private void OnScrollChanged(float value)
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
			int num = 0;
			if (timelineRendererLineRenderer != num)
			{
				this.timelineRenderer.timelineScroll = value;
			}
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00122558 File Offset: 0x00120758
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x7A1A30", Offset = "0x7A0030", VA = "0x1807A1A30")]
		private void OnBPMChanged(string value)
		{
			ulong num;
			if (!this.isPlaying && float.TryParse(value, (float)num))
			{
				this.levelData.bpm = (float)num;
				NoteRecorder noteRecorder = this.noteRecorder;
				int num2 = 0;
				if (noteRecorder != num2)
				{
					RhythmLevelData rhythmLevelData = this.levelData;
					NoteRecorder noteRecorder2 = this.noteRecorder;
					float bpm = rhythmLevelData.bpm;
					noteRecorder2.bpm = bpm;
				}
				TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
				int num3 = 0;
				if (timelineRendererLineRenderer != num3)
				{
					RhythmLevelData rhythmLevelData2 = this.levelData;
					TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.timelineRenderer;
					float bpm2 = rhythmLevelData2.bpm;
					timelineRendererLineRenderer2.bpm = bpm2;
				}
				this.UpdateUI();
			}
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00122604 File Offset: 0x00120804
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x7A2660", Offset = "0x7A0C60", VA = "0x1807A2660")]
		private void OnSongNameChanged(string value)
		{
			this.levelData.musicName = value;
			this.UpdateUI();
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0012262C File Offset: 0x0012082C
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x7A1950", Offset = "0x79FF50", VA = "0x1807A1950")]
		private void OnAudioOffsetChanged(string value)
		{
			ulong num;
			if (float.TryParse(value, (float)num))
			{
				this.levelData.audioOffset = (float)num;
				float num2;
				Debug.Log(string.Format("\ud83c\udfb5 音频偏移已更新: {0}秒", num2));
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x00122668 File Offset: 0x00120868
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x7A1BE0", Offset = "0x7A01E0", VA = "0x1807A1BE0")]
		private void OnNoteDeleted()
		{
			int size = this.levelData.notes._size;
			if (this.selectedNoteIndex < size)
			{
				List<NoteData> notes = this.levelData.notes;
				int num = this.selectedNoteIndex;
				NoteData noteData = notes[num];
				List<NoteData> notes2 = this.levelData.notes;
				int num2 = this.selectedNoteIndex;
				notes2.RemoveAt(num2);
				int num3 = this.selectedNoteIndex;
				num3++;
				float time = noteData.time;
				int num4 = noteData.track;
				num4++;
				Debug.Log(string.Format("\ud83d\uddd1\ufe0f 已删除音符 #{0} | 时间: {1:F3}s, 轨道: {2}", num3, num3, num3));
				this.ClearNoteSelection();
				this.UpdateUI();
				return;
			}
			Debug.Log("⚠\ufe0f 没有选中的音符可以删除");
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x00122720 File Offset: 0x00120920
		[Token(Token = "0x600365D")]
		[Address(RVA = "0x7A4C70", Offset = "0x7A3270", VA = "0x1807A4C70")]
		public RhythmGameChartEditorUI()
		{
		}

		// Token: 0x04002996 RID: 10646
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002996")]
		[Header("主面板")]
		[Tooltip("主面板GameObject")]
		public GameObject mainPanel;

		// Token: 0x04002997 RID: 10647
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002997")]
		[Header("顶部信息")]
		[Tooltip("歌曲名称文本")]
		public TextMeshProUGUI songNameText;

		// Token: 0x04002998 RID: 10648
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002998")]
		[Tooltip("BPM文本")]
		public TextMeshProUGUI bpmText;

		// Token: 0x04002999 RID: 10649
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002999")]
		[Tooltip("当前时间文本")]
		public TextMeshProUGUI timeText;

		// Token: 0x0400299A RID: 10650
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400299A")]
		[Tooltip("节拍文本")]
		public TextMeshProUGUI beatText;

		// Token: 0x0400299B RID: 10651
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400299B")]
		[Tooltip("音符数量文本")]
		public TextMeshProUGUI noteCountText;

		// Token: 0x0400299C RID: 10652
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400299C")]
		[Tooltip("选中音符信息文本")]
		public TextMeshProUGUI selectedNoteInfoText;

		// Token: 0x0400299D RID: 10653
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400299D")]
		[Header("控制按钮")]
		[Tooltip("加载BGM按钮")]
		public TheButton loadBgmButton;

		// Token: 0x0400299E RID: 10654
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400299E")]
		[Tooltip("预设BGM按钮")]
		public TMP_Dropdown dropdown;

		// Token: 0x0400299F RID: 10655
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400299F")]
		[Tooltip("播放按钮")]
		public TheButton playButton;

		// Token: 0x040029A0 RID: 10656
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40029A0")]
		[Tooltip("暂停按钮")]
		public TheButton pauseButton;

		// Token: 0x040029A1 RID: 10657
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40029A1")]
		[Tooltip("停止按钮")]
		public TheButton stopButton;

		// Token: 0x040029A2 RID: 10658
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40029A2")]
		[Tooltip("保存JSON按钮")]
		public TheButton saveJsonButton;

		// Token: 0x040029A3 RID: 10659
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40029A3")]
		[Tooltip("加载JSON按钮")]
		public TheButton loadJsonButton;

		// Token: 0x040029A4 RID: 10660
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40029A4")]
		[Tooltip("复制代码按钮")]
		public TheButton copyCodeButton;

		// Token: 0x040029A5 RID: 10661
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40029A5")]
		[Tooltip("清空数据按钮")]
		public TheButton clearDataButton;

		// Token: 0x040029A6 RID: 10662
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40029A6")]
		[Tooltip("关闭按钮")]
		public TheButton closeButton;

		// Token: 0x040029A7 RID: 10663
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40029A7")]
		[Header("设置")]
		[Tooltip("吸附开关")]
		public Toggle snapToggle;

		// Token: 0x040029A8 RID: 10664
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40029A8")]
		[Tooltip("自动跟随开关")]
		public Toggle autoFollowToggle;

		// Token: 0x040029A9 RID: 10665
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40029A9")]
		[Tooltip("Hold模式开关")]
		public Toggle holdModeToggle;

		// Token: 0x040029AA RID: 10666
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x40029AA")]
		[Tooltip("BPM输入框")]
		public TMP_InputField bpmInputField;

		// Token: 0x040029AB RID: 10667
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x40029AB")]
		[Tooltip("歌曲名输入框")]
		public TMP_InputField songNameInputField;

		// Token: 0x040029AC RID: 10668
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x40029AC")]
		[Tooltip("音频偏移输入框")]
		public TMP_InputField audioOffsetInputField;

		// Token: 0x040029AD RID: 10669
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x40029AD")]
		[Tooltip("缩放滑块")]
		[Header("缩放控制")]
		public Slider zoomSlider;

		// Token: 0x040029AE RID: 10670
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x40029AE")]
		[Tooltip("缩放文本")]
		public TextMeshProUGUI zoomText;

		// Token: 0x040029AF RID: 10671
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x40029AF")]
		[Tooltip("滚动条")]
		public Scrollbar scrollScrollbar;

		// Token: 0x040029B0 RID: 10672
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x40029B0")]
		[Header("子系统")]
		[Tooltip("时间轴渲染器")]
		public TimelineRendererLineRenderer timelineRenderer;

		// Token: 0x040029B1 RID: 10673
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x40029B1")]
		[Tooltip("音符录制器")]
		public NoteRecorder noteRecorder;

		// Token: 0x040029B2 RID: 10674
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x40029B2")]
		[Tooltip("数据管理器")]
		public RhythmEditorDataManager dataManager;

		// Token: 0x040029B3 RID: 10675
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x40029B3")]
		public RhythmLevelData levelData;

		// Token: 0x040029B4 RID: 10676
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x40029B4")]
		[Header("播放状态")]
		[Tooltip("是否正在录制")]
		private bool isPlaying;

		// Token: 0x040029B5 RID: 10677
		[FieldOffset(Offset = "0x131")]
		[Token(Token = "0x40029B5")]
		[Tooltip("是否正在录制")]
		private bool isRecording;

		// Token: 0x040029B6 RID: 10678
		[FieldOffset(Offset = "0x132")]
		[Token(Token = "0x40029B6")]
		[Tooltip("是否自动跟随")]
		private bool autoFollow = true;

		// Token: 0x040029B7 RID: 10679
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x40029B7")]
		[Tooltip("音频源")]
		private AudioSource audioSource;

		// Token: 0x040029B8 RID: 10680
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x40029B8")]
		[Tooltip("当前选中的音符索引")]
		private int selectedNoteIndex = (int)((ulong)4294967295L);

		// Token: 0x040029B9 RID: 10681
		[FieldOffset(Offset = "0x144")]
		[Token(Token = "0x40029B9")]
		[Header("Hold录制状态")]
		[Tooltip("是否正在录制Hold音符")]
		private bool isRecordingHold;

		// Token: 0x040029BA RID: 10682
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x40029BA")]
		[Tooltip("当前正在录制的Hold音符")]
		private NoteData currentHoldNote;
	}
}
