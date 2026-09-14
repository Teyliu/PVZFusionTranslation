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
	// Token: 0x02000A11 RID: 2577
	[Token(Token = "0x2000A11")]
	public class RhythmGameChartEditorUI : BaseMenu
	{
		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060034F3 RID: 13555 RVA: 0x0011B778 File Offset: 0x00119978
		// (set) Token: 0x060034F4 RID: 13556 RVA: 0x0011B798 File Offset: 0x00119998
		[Token(Token = "0x17000233")]
		public string SongName
		{
			[Token(Token = "0x60034F3")]
			[Address(RVA = "0x73E210", Offset = "0x73C810", VA = "0x18073E210")]
			get
			{
				return this.levelData.musicName;
			}
			[Token(Token = "0x60034F4")]
			[Address(RVA = "0x73E270", Offset = "0x73C870", VA = "0x18073E270")]
			set
			{
				this.levelData.musicName = value;
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060034F5 RID: 13557 RVA: 0x0011B7B8 File Offset: 0x001199B8
		[Token(Token = "0x17000234")]
		public List<NoteData> RecordedNotes
		{
			[Token(Token = "0x60034F5")]
			[Address(RVA = "0x73E1F0", Offset = "0x73C7F0", VA = "0x18073E1F0")]
			get
			{
				return this.levelData.notes;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0011B7D8 File Offset: 0x001199D8
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0011B7F8 File Offset: 0x001199F8
		[Token(Token = "0x17000235")]
		public float BPM
		{
			[Token(Token = "0x60034F6")]
			[Address(RVA = "0x73E1D0", Offset = "0x73C7D0", VA = "0x18073E1D0")]
			get
			{
				return this.levelData.bpm;
			}
			[Token(Token = "0x60034F7")]
			[Address(RVA = "0x73E250", Offset = "0x73C850", VA = "0x18073E250")]
			set
			{
				this.levelData.bpm = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x0011B818 File Offset: 0x00119A18
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0011B838 File Offset: 0x00119A38
		[Token(Token = "0x17000236")]
		public float AudioOffset
		{
			[Token(Token = "0x60034F8")]
			[Address(RVA = "0x73E1B0", Offset = "0x73C7B0", VA = "0x18073E1B0")]
			get
			{
				return this.levelData.audioOffset;
			}
			[Token(Token = "0x60034F9")]
			[Address(RVA = "0x73E230", Offset = "0x73C830", VA = "0x18073E230")]
			set
			{
				this.levelData.audioOffset = value;
			}
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x0011B858 File Offset: 0x00119A58
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x738890", Offset = "0x736E90", VA = "0x180738890", Slot = "6")]
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

		// Token: 0x060034FB RID: 13563 RVA: 0x0011B8B4 File Offset: 0x00119AB4
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x73B0B0", Offset = "0x7396B0", VA = "0x18073B0B0", Slot = "8")]
		public override void OnExit()
		{
			base.OnExit();
			GameAPP.Instance.PlayMusic((MusicType)((uint)1));
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0011B8DC File Offset: 0x00119ADC
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x73C450", Offset = "0x73AA50", VA = "0x18073C450")]
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

		// Token: 0x060034FD RID: 13565 RVA: 0x0011B9E0 File Offset: 0x00119BE0
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x73DE10", Offset = "0x73C410", VA = "0x18073DE10")]
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

		// Token: 0x060034FE RID: 13566 RVA: 0x0011BB60 File Offset: 0x00119D60
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x739BB0", Offset = "0x7381B0", VA = "0x180739BB0")]
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

		// Token: 0x060034FF RID: 13567 RVA: 0x0011BE68 File Offset: 0x0011A068
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x738A30", Offset = "0x737030", VA = "0x180738A30")]
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

		// Token: 0x06003500 RID: 13568 RVA: 0x0011C22C File Offset: 0x0011A42C
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x73A3C0", Offset = "0x7389C0", VA = "0x18073A3C0")]
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

		// Token: 0x06003501 RID: 13569 RVA: 0x0011C2CC File Offset: 0x0011A4CC
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x73C1D0", Offset = "0x73A7D0", VA = "0x18073C1D0")]
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

		// Token: 0x06003502 RID: 13570 RVA: 0x0011C3AC File Offset: 0x0011A5AC
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x73C720", Offset = "0x73AD20", VA = "0x18073C720")]
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

		// Token: 0x06003503 RID: 13571 RVA: 0x0011C45C File Offset: 0x0011A65C
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x73C9F0", Offset = "0x73AFF0", VA = "0x18073C9F0")]
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

		// Token: 0x06003504 RID: 13572 RVA: 0x0011C4B8 File Offset: 0x0011A6B8
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x73C0A0", Offset = "0x73A6A0", VA = "0x18073C0A0")]
		private void PlayOneBeat()
		{
			NoteRecorder noteRecorder = this.noteRecorder;
			int num = 0;
			if (noteRecorder != num)
			{
				this.noteRecorder.PlayOneBeat();
			}
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x0011C4EC File Offset: 0x0011A6EC
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x739B30", Offset = "0x738130", VA = "0x180739B30")]
		private void GoBackOneBeat()
		{
			NoteRecorder noteRecorder = this.noteRecorder;
			int num = 0;
			if (noteRecorder != num)
			{
				this.noteRecorder.GoBackOneBeat();
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0011C520 File Offset: 0x0011A720
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x73B380", Offset = "0x739980", VA = "0x18073B380")]
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
							int num4 = 0;
							instance.ShowText(text, 1f, num4 != 0);
						}
					}
					Debug.LogWarning("⚠\ufe0f 请在同一轨道完成Hold音符");
					InGameText instance2 = InGameText.Instance;
					int num5 = 0;
					instance2.ShowText("请先完成当前Hold音符！", time, num5 != 0);
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
				int num6 = trackIndex + 1;
				this.isRecordingHold = true;
				Debug.Log(string.Format("\ud83c\udfb5 开始Hold音符: 轨道{0} 开始时间:{1:F3}s", num6, num6));
				InGameText instance3 = InGameText.Instance;
				int num7 = trackIndex + 1;
				string text2 = string.Format("开始Hold音符 (轨道{0})", instance3);
			}
			NoteData noteData2 = new NoteData();
			noteData2.time = time;
			noteData2.track = trackIndex;
			noteData2.type = (NoteType)((ulong)0L);
			noteData2.spawned = false;
			List<NoteData> notes2 = this.levelData.notes;
			int num8 = trackIndex + 1;
			Debug.Log(string.Format("✅ 记录音符: 轨道{0} 时间:{1:F3}s", num8, num8));
			this.UpdateUI();
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0011C6E0 File Offset: 0x0011A8E0
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x73B850", Offset = "0x739E50", VA = "0x18073B850")]
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

		// Token: 0x06003508 RID: 13576 RVA: 0x0011C734 File Offset: 0x0011A934
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x7398C0", Offset = "0x737EC0", VA = "0x1807398C0")]
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

		// Token: 0x06003509 RID: 13577 RVA: 0x0011C78C File Offset: 0x0011A98C
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x739620", Offset = "0x737C20", VA = "0x180739620")]
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

		// Token: 0x0600350A RID: 13578 RVA: 0x0011C838 File Offset: 0x0011AA38
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x73B960", Offset = "0x739F60", VA = "0x18073B960")]
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

		// Token: 0x0600350B RID: 13579 RVA: 0x0011C8BC File Offset: 0x0011AABC
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x73B360", Offset = "0x739960", VA = "0x18073B360")]
		private void OnNoteDragged(NoteData note)
		{
			this.UpdateUI();
			this.UpdateSelectedNoteInfo();
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0011C8D8 File Offset: 0x0011AAD8
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x73CF40", Offset = "0x73B540", VA = "0x18073CF40")]
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

		// Token: 0x0600350D RID: 13581 RVA: 0x0011CA48 File Offset: 0x0011AC48
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x73BF30", Offset = "0x73A530", VA = "0x18073BF30")]
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
			int num = 0;
			string text2;
			instance.ShowText(text2, 10f, num != 0);
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x0011CAB0 File Offset: 0x0011ACB0
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x73C120", Offset = "0x73A720", VA = "0x18073C120")]
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

		// Token: 0x0600350F RID: 13583 RVA: 0x0011CB1C File Offset: 0x0011AD1C
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x73A650", Offset = "0x738C50", VA = "0x18073A650")]
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

		// Token: 0x06003510 RID: 13584 RVA: 0x0011CBA0 File Offset: 0x0011ADA0
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x73A7F0", Offset = "0x738DF0", VA = "0x18073A7F0")]
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

		// Token: 0x06003511 RID: 13585 RVA: 0x0011CD00 File Offset: 0x0011AF00
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x739960", Offset = "0x737F60", VA = "0x180739960")]
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

		// Token: 0x06003512 RID: 13586 RVA: 0x0011CD98 File Offset: 0x0011AF98
		[Token(Token = "0x6003512")]
		[Address(RVA = "0x739800", Offset = "0x737E00", VA = "0x180739800")]
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

		// Token: 0x06003513 RID: 13587 RVA: 0x0011CDEC File Offset: 0x0011AFEC
		[Token(Token = "0x6003513")]
		[Address(RVA = "0x73D890", Offset = "0x73BE90", VA = "0x18073D890")]
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

		// Token: 0x06003514 RID: 13588 RVA: 0x0011D090 File Offset: 0x0011B290
		[Token(Token = "0x6003514")]
		[Address(RVA = "0x73D490", Offset = "0x73BA90", VA = "0x18073D490")]
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

		// Token: 0x06003515 RID: 13589 RVA: 0x0011D19C File Offset: 0x0011B39C
		[Token(Token = "0x6003515")]
		[Address(RVA = "0x73CD20", Offset = "0x73B320", VA = "0x18073CD20")]
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

		// Token: 0x06003516 RID: 13590 RVA: 0x0011D28C File Offset: 0x0011B48C
		[Token(Token = "0x6003516")]
		[Address(RVA = "0x73BBD0", Offset = "0x73A1D0", VA = "0x18073BBD0")]
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

		// Token: 0x06003517 RID: 13591 RVA: 0x0011D408 File Offset: 0x0011B608
		[Token(Token = "0x6003517")]
		[Address(RVA = "0x73BB00", Offset = "0x73A100", VA = "0x18073BB00")]
		private void OnScrollChanged(float value)
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.timelineRenderer;
			int num = 0;
			if (timelineRendererLineRenderer != num)
			{
				this.timelineRenderer.timelineScroll = value;
			}
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x0011D43C File Offset: 0x0011B63C
		[Token(Token = "0x6003518")]
		[Address(RVA = "0x73AF80", Offset = "0x739580", VA = "0x18073AF80")]
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

		// Token: 0x06003519 RID: 13593 RVA: 0x0011D4E8 File Offset: 0x0011B6E8
		[Token(Token = "0x6003519")]
		[Address(RVA = "0x73BB90", Offset = "0x73A190", VA = "0x18073BB90")]
		private void OnSongNameChanged(string value)
		{
			this.levelData.musicName = value;
			this.UpdateUI();
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x0011D510 File Offset: 0x0011B710
		[Token(Token = "0x600351A")]
		[Address(RVA = "0x73AEA0", Offset = "0x7394A0", VA = "0x18073AEA0")]
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

		// Token: 0x0600351B RID: 13595 RVA: 0x0011D54C File Offset: 0x0011B74C
		[Token(Token = "0x600351B")]
		[Address(RVA = "0x73B130", Offset = "0x739730", VA = "0x18073B130")]
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

		// Token: 0x0600351C RID: 13596 RVA: 0x0011D604 File Offset: 0x0011B804
		[Token(Token = "0x600351C")]
		[Address(RVA = "0x73E190", Offset = "0x73C790", VA = "0x18073E190")]
		public RhythmGameChartEditorUI()
		{
		}

		// Token: 0x04002828 RID: 10280
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002828")]
		[Tooltip("主面板GameObject")]
		[Header("主面板")]
		public GameObject mainPanel;

		// Token: 0x04002829 RID: 10281
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002829")]
		[Header("顶部信息")]
		[Tooltip("歌曲名称文本")]
		public TextMeshProUGUI songNameText;

		// Token: 0x0400282A RID: 10282
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400282A")]
		[Tooltip("BPM文本")]
		public TextMeshProUGUI bpmText;

		// Token: 0x0400282B RID: 10283
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400282B")]
		[Tooltip("当前时间文本")]
		public TextMeshProUGUI timeText;

		// Token: 0x0400282C RID: 10284
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400282C")]
		[Tooltip("节拍文本")]
		public TextMeshProUGUI beatText;

		// Token: 0x0400282D RID: 10285
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400282D")]
		[Tooltip("音符数量文本")]
		public TextMeshProUGUI noteCountText;

		// Token: 0x0400282E RID: 10286
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400282E")]
		[Tooltip("选中音符信息文本")]
		public TextMeshProUGUI selectedNoteInfoText;

		// Token: 0x0400282F RID: 10287
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400282F")]
		[Header("控制按钮")]
		[Tooltip("加载BGM按钮")]
		public TheButton loadBgmButton;

		// Token: 0x04002830 RID: 10288
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002830")]
		[Tooltip("预设BGM按钮")]
		public TMP_Dropdown dropdown;

		// Token: 0x04002831 RID: 10289
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002831")]
		[Tooltip("播放按钮")]
		public TheButton playButton;

		// Token: 0x04002832 RID: 10290
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002832")]
		[Tooltip("暂停按钮")]
		public TheButton pauseButton;

		// Token: 0x04002833 RID: 10291
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002833")]
		[Tooltip("停止按钮")]
		public TheButton stopButton;

		// Token: 0x04002834 RID: 10292
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002834")]
		[Tooltip("保存JSON按钮")]
		public TheButton saveJsonButton;

		// Token: 0x04002835 RID: 10293
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002835")]
		[Tooltip("加载JSON按钮")]
		public TheButton loadJsonButton;

		// Token: 0x04002836 RID: 10294
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002836")]
		[Tooltip("复制代码按钮")]
		public TheButton copyCodeButton;

		// Token: 0x04002837 RID: 10295
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4002837")]
		[Tooltip("清空数据按钮")]
		public TheButton clearDataButton;

		// Token: 0x04002838 RID: 10296
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4002838")]
		[Tooltip("关闭按钮")]
		public TheButton closeButton;

		// Token: 0x04002839 RID: 10297
		[FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x4002839")]
		[Tooltip("吸附开关")]
		[Header("设置")]
		public Toggle snapToggle;

		// Token: 0x0400283A RID: 10298
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400283A")]
		[Tooltip("自动跟随开关")]
		public Toggle autoFollowToggle;

		// Token: 0x0400283B RID: 10299
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400283B")]
		[Tooltip("Hold模式开关")]
		public Toggle holdModeToggle;

		// Token: 0x0400283C RID: 10300
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400283C")]
		[Tooltip("BPM输入框")]
		public TMP_InputField bpmInputField;

		// Token: 0x0400283D RID: 10301
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x400283D")]
		[Tooltip("歌曲名输入框")]
		public TMP_InputField songNameInputField;

		// Token: 0x0400283E RID: 10302
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x400283E")]
		[Tooltip("音频偏移输入框")]
		public TMP_InputField audioOffsetInputField;

		// Token: 0x0400283F RID: 10303
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400283F")]
		[Header("缩放控制")]
		[Tooltip("缩放滑块")]
		public Slider zoomSlider;

		// Token: 0x04002840 RID: 10304
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x4002840")]
		[Tooltip("缩放文本")]
		public TextMeshProUGUI zoomText;

		// Token: 0x04002841 RID: 10305
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4002841")]
		[Tooltip("滚动条")]
		public Scrollbar scrollScrollbar;

		// Token: 0x04002842 RID: 10306
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4002842")]
		[Tooltip("时间轴渲染器")]
		[Header("子系统")]
		public TimelineRendererLineRenderer timelineRenderer;

		// Token: 0x04002843 RID: 10307
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x4002843")]
		[Tooltip("音符录制器")]
		public NoteRecorder noteRecorder;

		// Token: 0x04002844 RID: 10308
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4002844")]
		[Tooltip("数据管理器")]
		public RhythmEditorDataManager dataManager;

		// Token: 0x04002845 RID: 10309
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4002845")]
		public RhythmLevelData levelData;

		// Token: 0x04002846 RID: 10310
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x4002846")]
		[Tooltip("是否正在录制")]
		[Header("播放状态")]
		private bool isPlaying;

		// Token: 0x04002847 RID: 10311
		[FieldOffset(Offset = "0x131")]
		[Token(Token = "0x4002847")]
		[Tooltip("是否正在录制")]
		private bool isRecording;

		// Token: 0x04002848 RID: 10312
		[FieldOffset(Offset = "0x132")]
		[Token(Token = "0x4002848")]
		[Tooltip("是否自动跟随")]
		private bool autoFollow = true;

		// Token: 0x04002849 RID: 10313
		[FieldOffset(Offset = "0x138")]
		[Token(Token = "0x4002849")]
		[Tooltip("音频源")]
		private AudioSource audioSource;

		// Token: 0x0400284A RID: 10314
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x400284A")]
		[Tooltip("当前选中的音符索引")]
		private int selectedNoteIndex = (int)((ulong)4294967295L);

		// Token: 0x0400284B RID: 10315
		[FieldOffset(Offset = "0x144")]
		[Token(Token = "0x400284B")]
		[Header("Hold录制状态")]
		[Tooltip("是否正在录制Hold音符")]
		private bool isRecordingHold;

		// Token: 0x0400284C RID: 10316
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x400284C")]
		[Tooltip("当前正在录制的Hold音符")]
		private NoteData currentHoldNote;
	}
}
