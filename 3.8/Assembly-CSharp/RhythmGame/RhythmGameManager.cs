using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A52 RID: 2642
	[Token(Token = "0x2000A52")]
	public class RhythmGameManager : MonoBehaviour
	{
		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x001248F8 File Offset: 0x00122AF8
		// (set) Token: 0x06003649 RID: 13897 RVA: 0x0012490C File Offset: 0x00122B0C
		[Token(Token = "0x17000242")]
		public static RhythmGameManager Instance
		{
			[Token(Token = "0x6003648")]
			[Address(RVA = "0x774010", Offset = "0x772610", VA = "0x180774010")]
			get;
			[Token(Token = "0x6003649")]
			[Address(RVA = "0x774060", Offset = "0x772660", VA = "0x180774060")]
			private set;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x00124920 File Offset: 0x00122B20
		[Token(Token = "0x17000243")]
		public float FallTime
		{
			[Token(Token = "0x600364A")]
			[Address(RVA = "0x773FF0", Offset = "0x7725F0", VA = "0x180773FF0")]
			get
			{
				return this.currentLevel.fallTime;
			}
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00124940 File Offset: 0x00122B40
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x770BB0", Offset = "0x76F1B0", VA = "0x180770BB0")]
		private void Awake()
		{
			RhythmGameManager.<Instance>k__BackingField = this;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00124954 File Offset: 0x00122B54
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x773AD0", Offset = "0x7720D0", VA = "0x180773AD0")]
		private void Start()
		{
			Transform transform = Camera.main.transform;
			Camera.main.orthographicSize = 7f;
			Transform transform2 = base.transform;
			Transform transform3 = Camera.main.transform;
			Vector3 vector;
			float z = vector.z;
			Vector3 vector2;
			float z2 = vector2.z;
			ComboManager comboManager = new ComboManager();
			this.comboManager = comboManager;
			BoardStatistics boardStatistics = this.board.boardStatistics;
			ComboManager comboManager2 = this.comboManager;
			boardStatistics.comboManager = comboManager2;
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x001249E0 File Offset: 0x00122BE0
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x7714B0", Offset = "0x76FAB0", VA = "0x1807714B0")]
		private void InitializeSubSystems()
		{
			ComboManager comboManager = new ComboManager();
			this.comboManager = comboManager;
			BoardStatistics boardStatistics = this.board.boardStatistics;
			ComboManager comboManager2 = this.comboManager;
			boardStatistics.comboManager = comboManager2;
			throw new NullReferenceException();
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00124A1C File Offset: 0x00122C1C
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x773800", Offset = "0x771E00", VA = "0x180773800")]
		public void StartRhythmGame(RhythmLevelData levelData)
		{
			while (levelData != 0)
			{
				AudioSource music = GameAPP.music;
				this.bgmSource = music;
				this.currentLevel = levelData;
				List<NoteData> list = new List(levelData.notes);
				this.pendingNotes = list;
				List<NoteData> list2 = this.pendingNotes;
				bool flag;
				if (flag)
				{
				}
				ulong num;
				if (num == (ulong)0L)
				{
					Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
					break;
				}
			}
			Debug.LogError("关卡数据为空！");
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00124A94 File Offset: 0x00122C94
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x773750", Offset = "0x771D50", VA = "0x180773750")]
		private void StartGame()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00124AB8 File Offset: 0x00122CB8
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x771390", Offset = "0x76F990", VA = "0x180771390")]
		private Task<AudioClip> FindMusicFromFile(string name)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00124ADC File Offset: 0x00122CDC
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x773D80", Offset = "0x772380", VA = "0x180773D80")]
		private void Update()
		{
			if (this.isPlaying)
			{
				this.CheckPauseState();
				if (!this.isPaused)
				{
					if (!this.isPaused)
					{
						AudioSource audioSource = this.bgmSource;
						int num = 0;
						if (audioSource != num && this.bgmSource.isPlaying)
						{
							double dspTime = AudioSettings.dspTime;
							int num2 = 0;
							this.currentBGMTime = (float)num2;
						}
					}
					this.SpawnNotes();
					this.AutoPlayNotes();
					this.ComboUpdate();
					return;
				}
			}
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00124B58 File Offset: 0x00122D58
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x770EB0", Offset = "0x76F4B0", VA = "0x180770EB0")]
		private void ComboUpdate()
		{
			Transform transform = this.comboText.transform;
			Transform transform2 = this.comboText.transform;
			float num = this.targetScale;
			float num2 = Time.deltaTime * 15f;
			int num3 = 0;
			if (num3 > (int)num2 || num2 > 1f)
			{
			}
			float num4 = this.targetScale;
			if (num4 > 0.8f)
			{
				num = num4;
				float deltaTime = Time.deltaTime;
				this.targetScale = num;
				this.targetScale = 0.8f;
			}
			Transform transform3 = this.comboText2.transform;
			Transform transform4 = this.comboText2.transform;
			float num5 = this.targetScale2;
			float num6 = Time.deltaTime * 15f;
			if (num3 > (int)num6 || num6 > 1f)
			{
			}
			float num7 = this.targetScale2;
			if (num7 > 1f)
			{
				num5 = num7;
				float deltaTime2 = Time.deltaTime;
				this.targetScale2 = num5;
				this.targetScale2 = 1f;
			}
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00124C60 File Offset: 0x00122E60
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x770C10", Offset = "0x76F210", VA = "0x180770C10")]
		private void CheckPauseState()
		{
			if (!this.isPaused && this.isPlaying && !this.isPaused)
			{
				this.isPaused = true;
				double dspTime = AudioSettings.dspTime;
				float num = this.currentBGMTime;
				int num2 = 0;
				AudioSource audioSource = this.bgmSource;
				this.pauseBGMTime = num;
				this.pauseTime = (float)num2;
				int num3 = 0;
				if (audioSource != num3 && this.bgmSource.isPlaying)
				{
					this.bgmSource.Pause();
				}
				float num4 = this.pauseBGMTime;
				if ("音游暂停 (BGM时间: {0:F2}s)" != 0 && this.isPlaying && this.isPaused)
				{
					AudioSource audioSource2 = this.bgmSource;
					this.isPaused = false;
					int num5 = 0;
					if (audioSource2 != num5)
					{
						this.bgmSource.UnPause();
					}
					double dspTime2 = AudioSettings.dspTime;
					int num6 = 0;
					this.songStartTime = (float)num6;
					float num7;
					Debug.Log(string.Format("音游恢复 (暂停了{0:F2}s)", num7));
				}
			}
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00124D60 File Offset: 0x00122F60
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x773CE0", Offset = "0x7722E0", VA = "0x180773CE0")]
		private void UpdateMusicTime()
		{
			if (!this.isPaused)
			{
				AudioSource audioSource = this.bgmSource;
				int num = 0;
				if (audioSource != num && this.bgmSource.isPlaying)
				{
					double dspTime = AudioSettings.dspTime;
					int num2 = 0;
					this.currentBGMTime = (float)num2;
				}
			}
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00124DB0 File Offset: 0x00122FB0
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x7734D0", Offset = "0x771AD0", VA = "0x1807734D0")]
		private void SpawnNotes()
		{
			ulong num2;
			do
			{
				int num = 0;
				List<NoteData> list = this.pendingNotes;
				Func<NoteData, bool> <>9__35_ = RhythmGameManager.<>c.<>9__35_0;
				if (<>9__35_ == 0)
				{
					Func<NoteData, bool> func;
					RhythmGameManager.<>c.<>9__35_0 = func;
				}
				List<NoteData> list2 = Enumerable.ToList<NoteData>(Enumerable.Where<NoteData>(list, <>9__35_));
				bool flag;
				if (flag)
				{
					float fallTime = this.currentLevel.fallTime;
					this.CreateNote(num);
				}
			}
			while (num2 != (ulong)0L);
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00124E1C File Offset: 0x0012301C
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x770920", Offset = "0x76EF20", VA = "0x180770920")]
		private void AutoPlayNotes()
		{
			int num;
			do
			{
				List<NoteTrack> list = this.tracks;
				num = 0;
				bool flag;
				if (flag)
				{
					bool flag2;
					if (flag2)
					{
					}
					if (num != 0)
					{
						goto IL_002B;
					}
				}
			}
			while (num != 0);
			return;
			IL_002B:
			throw new NullReferenceException();
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00124E60 File Offset: 0x00123060
		[Token(Token = "0x6003657")]
		[Address(RVA = "0x771230", Offset = "0x76F830", VA = "0x180771230")]
		private void CreateNote(NoteData noteData)
		{
			Board board = this.board;
			GameObject gameObject = this.notePrefab;
			Transform transform = board.transform;
			GameObject gameObject2 = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform);
			bool flag;
			if (!flag)
			{
				FallingNote fallingNote = gameObject2.AddComponent<FallingNote>();
			}
			int size = this.tracks._size;
			if (noteData.track < size)
			{
				int track = noteData.track;
				NoteTrack noteTrack = this.tracks[track];
			}
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00124ED0 File Offset: 0x001230D0
		[Token(Token = "0x6003658")]
		[Address(RVA = "0x772210", Offset = "0x770810", VA = "0x180772210")]
		public void OnNoteClicked(FallingNote note, float clickTime)
		{
			int num = 0;
			Board board = this.board;
			if (this.comboManager != num)
			{
				this.comboManager.AddCombo((NoteJudgeSystem.JudgeResult)num);
				ComboManager comboManager = this.comboManager;
				TextMeshPro textMeshPro = this.comboText;
				int num2;
				string text = string.Format("{0}", num2);
				textMeshPro.text = text;
				this.targetScale = 1.6f;
				this.targetScale2 = 0.9f;
			}
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_01E4;
						}
						ParticleManager instance = ParticleManager.Instance;
						Transform transform = note.transform;
					}
					ParticleManager instance2 = ParticleManager.Instance;
					Transform transform2 = note.transform;
					Particle particle = this.particle;
					int num3 = 0;
					if (particle != num3 && this.particle.gameObject.activeSelf)
					{
						this.particle.Die();
					}
					ParticleManager instance3 = ParticleManager.Instance;
					Transform transform3 = base.transform;
				}
				ParticleManager instance4 = ParticleManager.Instance;
				Transform transform4 = note.transform;
				Particle particle2;
				Transform transform5 = particle2.transform;
				ParticleManager instance5 = ParticleManager.Instance;
				Transform transform6 = note.transform;
				Particle particle3;
				Transform transform7 = particle3.transform;
				Particle particle4 = this.particle;
				int num4 = 0;
				if (particle4 != num4 && this.particle.gameObject.activeSelf)
				{
					this.particle.Die();
				}
				ParticleManager instance6 = ParticleManager.Instance;
				Transform transform8 = base.transform;
			}
			ParticleManager instance7 = ParticleManager.Instance;
			Transform transform9 = note.transform;
			Particle particle5;
			Transform transform10 = particle5.transform;
			ParticleManager instance8 = ParticleManager.Instance;
			Transform transform11 = note.transform;
			Particle particle6;
			Transform transform12 = particle6.transform;
			ParticleManager instance9 = ParticleManager.Instance;
			Transform transform13 = note.transform;
			Particle particle7;
			Transform transform14 = particle7.transform;
			Particle particle8 = this.particle;
			int num5 = 0;
			if (particle8 != num5 && this.particle.gameObject.activeSelf)
			{
				this.particle.Die();
			}
			ParticleManager instance10 = ParticleManager.Instance;
			Transform transform15 = base.transform;
			Particle particle9;
			this.particle = particle9;
			IL_01E4:
			this.Shoot((NoteJudgeSystem.JudgeResult)num);
			int size = this.tracks._size;
			if (note.trackIndex < size)
			{
				int trackIndex = note.trackIndex;
				this.tracks[trackIndex].RemoveNote(note);
			}
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00125104 File Offset: 0x00123304
		[Token(Token = "0x6003659")]
		[Address(RVA = "0x772E40", Offset = "0x771440", VA = "0x180772E40")]
		public void OnNoteMissed(FallingNote note)
		{
			if (this.comboManager != (ulong)0L)
			{
				this.comboManager.ResetCombo();
			}
			int size = this.tracks._size;
			if (note.trackIndex < size)
			{
				int trackIndex = note.trackIndex;
				this.tracks[trackIndex].RemoveNote(note);
			}
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0012515C File Offset: 0x0012335C
		[Token(Token = "0x600365A")]
		[Address(RVA = "0x773150", Offset = "0x771750", VA = "0x180773150")]
		private void Shoot(NoteJudgeSystem.JudgeResult result)
		{
			ComboManager comboManager = this.comboManager;
			int num = 0;
			int num2 = comboManager.GetExtraBulletCount();
			num2++;
			if (num < num2)
			{
				if (result == NoteJudgeSystem.JudgeResult.Perfect || result == NoteJudgeSystem.JudgeResult.Perfect || result == NoteJudgeSystem.JudgeResult.Great)
				{
					int num3 = 0;
					uint num4;
					float boxXFromColumn = Lawnf.GetBoxXFromColumn((int)num4);
					int num5 = this.board.rowNum;
					num5 -= num3;
					uint num7;
					float num6 = Lawnf.GetBoxYFromRow(num5, (int)num7);
					if (RhythmGameManager.<>c.<>9__40_0 == 0)
					{
						Func<Zombie, bool> func;
						RhythmGameManager.<>c.<>9__40_0 = func;
					}
					int num8 = 0;
					Zombie zombie;
					uint num9;
					int num10;
					if (zombie != num8 && global::UnityEngine.Random.Range(0, (int)num9) != 0)
					{
						num10 = zombie.theZombieRow;
					}
					int rowNum = this.board.rowNum;
					num10 = global::UnityEngine.Random.Range(0, rowNum);
					uint num11;
					num6 = Lawnf.GetBoxYFromRow(num10, (int)num11);
					BulletType bulletType;
					uint num12;
					CreateBullet.Instance.SetBullet(boxXFromColumn, num6, num10, bulletType, (BulletMoveWay)num, num != 0).Damage = (int)num12;
				}
				ComboManager comboManager2 = this.comboManager;
				num++;
			}
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x00125248 File Offset: 0x00123448
		[Token(Token = "0x600365B")]
		[Address(RVA = "0x772EE0", Offset = "0x7714E0", VA = "0x180772EE0")]
		public void PauseGame()
		{
			if (this.isPlaying && !this.isPaused)
			{
				this.isPaused = true;
				double dspTime = AudioSettings.dspTime;
				float num = this.currentBGMTime;
				int num2 = 0;
				AudioSource audioSource = this.bgmSource;
				this.pauseBGMTime = num;
				this.pauseTime = (float)num2;
				int num3 = 0;
				bool flag = audioSource != num3;
				if (flag && this.bgmSource.isPlaying)
				{
					this.bgmSource.Pause();
				}
				float num4 = this.pauseBGMTime;
				Debug.Log(string.Format("音游暂停 (BGM时间: {0:F2}s)", flag));
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x001252E4 File Offset: 0x001234E4
		[Token(Token = "0x600365C")]
		[Address(RVA = "0x773020", Offset = "0x771620", VA = "0x180773020")]
		public void ResumeGame()
		{
			if (this.isPlaying && this.isPaused)
			{
				AudioSource audioSource = this.bgmSource;
				this.isPaused = false;
				int num = 0;
				if (audioSource != num)
				{
					this.bgmSource.UnPause();
				}
				double dspTime = AudioSettings.dspTime;
				int num2 = 0;
				this.songStartTime = (float)num2;
				float num3;
				Debug.Log(string.Format("音游恢复 (暂停了{0:F2}s)", num3));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x00125354 File Offset: 0x00123554
		[Token(Token = "0x17000244")]
		public float CurrentTime
		{
			[Token(Token = "0x600365D")]
			[Address(RVA = "0x3B0410", Offset = "0x3AEA10", VA = "0x1803B0410")]
			get
			{
				return this.currentBGMTime;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x00125368 File Offset: 0x00123568
		[Token(Token = "0x17000245")]
		public bool IsPaused
		{
			[Token(Token = "0x600365E")]
			[Address(RVA = "0x774050", Offset = "0x772650", VA = "0x180774050")]
			get
			{
				return this.isPaused;
			}
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0012537C File Offset: 0x0012357C
		[Token(Token = "0x600365F")]
		[Address(RVA = "0x771540", Offset = "0x76FB40", VA = "0x180771540")]
		public bool IsHoldKeyPressed(int trackIndex)
		{
			if (trackIndex <= 3)
			{
				bool[] array = this.holdKeyPressed;
				bool flag;
				return flag;
			}
			throw new IndexOutOfRangeException();
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x001253A0 File Offset: 0x001235A0
		[Token(Token = "0x6003660")]
		[Address(RVA = "0x7720B0", Offset = "0x7706B0", VA = "0x1807720B0")]
		public void OnHoldNoteStart(FallingNote note, float startTime)
		{
			bool[] array = this.holdKeyPressed;
			int trackIndex = note.trackIndex;
			int num = 0;
			num += 2;
			int trackIndex2 = note.trackIndex;
			NoteJudgeSystem.JudgeResult judgeResult;
			Debug.Log(string.Format("Hold音符开始: 轨道{0}, 判定{1}", trackIndex2, judgeResult));
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x001253E8 File Offset: 0x001235E8
		[Token(Token = "0x6003661")]
		[Address(RVA = "0x771A90", Offset = "0x770090", VA = "0x180771A90")]
		public void OnHoldNoteComplete(FallingNote note, float endTime)
		{
			bool[] array = this.holdKeyPressed;
			int trackIndex = note.trackIndex;
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = note.transform;
			int num = 0;
			int num2 = 0;
			ulong num3;
			Transform transform2 = instance.SetParticle((ParticleType)((uint)62), num, 11, num3 != 0UL, (float)num2).transform;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform transform3 = note.transform;
			int num4 = 0;
			ulong num5;
			Transform transform4 = instance2.SetParticle((ParticleType)((uint)62), num4, 11, num5 != 0UL, (float)num2).transform;
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform5 = note.transform;
			int num6 = 0;
			ulong num7;
			Transform transform6 = instance3.SetParticle((ParticleType)((uint)62), num6, 11, num7 != 0UL, (float)num2).transform;
			Board board = this.board;
			float thePoints = board.thePoints;
			board.thePoints = thePoints;
			if (this.comboManager != (ulong)0L)
			{
				ComboManager comboManager = this.comboManager;
				int num8 = 0;
				comboManager.AddCombo((NoteJudgeSystem.JudgeResult)num8);
				ComboManager comboManager2 = this.comboManager;
				TextMeshPro textMeshPro = this.comboText;
				int num9;
				string text = string.Format("{0}", num9);
				textMeshPro.text = text;
				this.targetScale = 1.6f;
				this.targetScale2 = 0.9f;
			}
			int trackIndex2 = note.trackIndex;
			Debug.Log(string.Format("Hold音符完成: 轨道{0}, 得分{1}", trackIndex2, trackIndex2));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0012551C File Offset: 0x0012371C
		[Token(Token = "0x6003662")]
		[Address(RVA = "0x771F50", Offset = "0x770550", VA = "0x180771F50")]
		public void OnHoldNoteFailed(FallingNote note)
		{
			bool[] array = this.holdKeyPressed;
			int trackIndex = note.trackIndex;
			if (this.comboManager != (ulong)0L)
			{
				this.comboManager.ResetCombo();
				this.comboText.text = "0";
			}
			GameAPP.PlaySound(26, 0.5f, 1f);
			int trackIndex2 = note.trackIndex;
			Debug.Log(string.Format("Hold音符失败: 轨道{0} (松开过早)", trackIndex2));
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0012558C File Offset: 0x0012378C
		[Token(Token = "0x6003663")]
		[Address(RVA = "0x771A60", Offset = "0x770060", VA = "0x180771A60")]
		public void OnHoldKeyReleased(int trackIndex)
		{
			bool[] array = this.holdKeyPressed;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x001255A8 File Offset: 0x001237A8
		[Token(Token = "0x6003664")]
		[Address(RVA = "0x771580", Offset = "0x76FB80", VA = "0x180771580")]
		public void OnHoldBeatJudge(FallingNote note, float judgeTime)
		{
			Board board = this.board;
			float thePoints = board.thePoints;
			board.thePoints = thePoints;
			if (this.comboManager != (ulong)0L)
			{
				ComboManager comboManager = this.comboManager;
				int num = 0;
				comboManager.AddCombo((NoteJudgeSystem.JudgeResult)num);
				ComboManager comboManager2 = this.comboManager;
				TextMeshPro textMeshPro = this.comboText;
				int num2;
				string text = string.Format("{0}", num2);
				textMeshPro.text = text;
				this.targetScale = 1.6f;
				this.targetScale2 = 0.9f;
			}
			ParticleManager instance = ParticleManager.Instance;
			Transform transform = note.transform;
			int num3 = 0;
			int num4 = 0;
			ulong num5;
			Transform transform2 = instance.SetParticle((ParticleType)((uint)62), num3, 11, num5 != 0UL, (float)num4).transform;
			ParticleManager instance2 = ParticleManager.Instance;
			Transform transform3 = note.transform;
			int num6 = 0;
			ulong num7;
			Transform transform4 = instance2.SetParticle((ParticleType)((uint)62), num6, 11, num7 != 0UL, (float)num4).transform;
			ParticleManager instance3 = ParticleManager.Instance;
			Transform transform5 = note.transform;
			int num8 = 0;
			ulong num9;
			Transform transform6 = instance3.SetParticle((ParticleType)((uint)62), num8, 11, num9 != 0UL, (float)num4).transform;
			int trackIndex = note.trackIndex;
			ComboManager comboManager3 = this.comboManager;
			Debug.Log(string.Format("Hold拍子Perfect: 轨道{0}, 得分{1}, 连击{2}", trackIndex, trackIndex, trackIndex));
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x001256D8 File Offset: 0x001238D8
		[Token(Token = "0x6003665")]
		[Address(RVA = "0x773EB0", Offset = "0x7724B0", VA = "0x180773EB0")]
		public RhythmGameManager()
		{
			List<NoteTrack> list = new List(4);
			this.tracks = list;
			List<NoteData> list2;
			this.pendingNotes = list2;
			NoteJudgeSystem noteJudgeSystem = new NoteJudgeSystem();
			this.judgeSystem = noteJudgeSystem;
			this.targetScale = 0.8f;
			this.targetScale2 = 0.7f;
			bool[] array = new bool[4];
			this.holdKeyPressed = array;
			base..ctor();
		}

		// Token: 0x0400299F RID: 10655
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400299F")]
		[Header("音频配置")]
		public AudioSource bgmSource;

		// Token: 0x040029A0 RID: 10656
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029A0")]
		public float songStartTime;

		// Token: 0x040029A1 RID: 10657
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40029A1")]
		public float currentBGMTime;

		// Token: 0x040029A2 RID: 10658
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40029A2")]
		[Header("音符配置")]
		public List<NoteTrack> tracks;

		// Token: 0x040029A3 RID: 10659
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40029A3")]
		public GameObject notePrefab;

		// Token: 0x040029A4 RID: 10660
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40029A4")]
		[Header("关卡数据")]
		public RhythmLevelData currentLevel;

		// Token: 0x040029A5 RID: 10661
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40029A5")]
		private List<NoteData> pendingNotes;

		// Token: 0x040029A6 RID: 10662
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40029A6")]
		[Header("子系统")]
		public NoteJudgeSystem judgeSystem;

		// Token: 0x040029A7 RID: 10663
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40029A7")]
		public ComboManager comboManager;

		// Token: 0x040029A8 RID: 10664
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40029A8")]
		public TextMeshPro comboText;

		// Token: 0x040029A9 RID: 10665
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40029A9")]
		public TextMeshPro comboText2;

		// Token: 0x040029AA RID: 10666
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40029AA")]
		private float targetScale;

		// Token: 0x040029AB RID: 10667
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x40029AB")]
		private float targetScale2;

		// Token: 0x040029AC RID: 10668
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40029AC")]
		[Header("棋盘引用")]
		public Board board;

		// Token: 0x040029AD RID: 10669
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40029AD")]
		[Header("游戏状态")]
		public bool isPlaying;

		// Token: 0x040029AE RID: 10670
		[FieldOffset(Offset = "0x81")]
		[Token(Token = "0x40029AE")]
		public bool isPaused;

		// Token: 0x040029AF RID: 10671
		[FieldOffset(Offset = "0x82")]
		[Token(Token = "0x40029AF")]
		public bool allSet;

		// Token: 0x040029B0 RID: 10672
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40029B0")]
		public bool[] holdKeyPressed;

		// Token: 0x040029B1 RID: 10673
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40029B1")]
		private Particle particle;

		// Token: 0x040029B2 RID: 10674
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40029B2")]
		private float pauseTime;

		// Token: 0x040029B3 RID: 10675
		[FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x40029B3")]
		private float pauseBGMTime;
	}
}
