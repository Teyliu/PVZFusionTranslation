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
	// Token: 0x02000A92 RID: 2706
	[Token(Token = "0x2000A92")]
	public class RhythmGameManager : MonoBehaviour
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x00129B74 File Offset: 0x00127D74
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x00129B88 File Offset: 0x00127D88
		[Token(Token = "0x1700028A")]
		public static RhythmGameManager Instance
		{
			[Token(Token = "0x600378C")]
			[Address(RVA = "0x7DAEA0", Offset = "0x7D94A0", VA = "0x1807DAEA0")]
			get;
			[Token(Token = "0x600378D")]
			[Address(RVA = "0x7DAEF0", Offset = "0x7D94F0", VA = "0x1807DAEF0")]
			private set;
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x00129B9C File Offset: 0x00127D9C
		[Token(Token = "0x1700028B")]
		public float FallTime
		{
			[Token(Token = "0x600378E")]
			[Address(RVA = "0x7DAE80", Offset = "0x7D9480", VA = "0x1807DAE80")]
			get
			{
				return this.currentLevel.fallTime;
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00129BBC File Offset: 0x00127DBC
		[Token(Token = "0x600378F")]
		[Address(RVA = "0x7D7A40", Offset = "0x7D6040", VA = "0x1807D7A40")]
		private void Awake()
		{
			RhythmGameManager.<Instance>k__BackingField = this;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00129BD0 File Offset: 0x00127DD0
		[Token(Token = "0x6003790")]
		[Address(RVA = "0x7DA960", Offset = "0x7D8F60", VA = "0x1807DA960")]
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

		// Token: 0x06003791 RID: 14225 RVA: 0x00129C5C File Offset: 0x00127E5C
		[Token(Token = "0x6003791")]
		[Address(RVA = "0x7D8340", Offset = "0x7D6940", VA = "0x1807D8340")]
		private void InitializeSubSystems()
		{
			ComboManager comboManager = new ComboManager();
			this.comboManager = comboManager;
			BoardStatistics boardStatistics = this.board.boardStatistics;
			ComboManager comboManager2 = this.comboManager;
			boardStatistics.comboManager = comboManager2;
			throw new NullReferenceException();
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x00129C98 File Offset: 0x00127E98
		[Token(Token = "0x6003792")]
		[Address(RVA = "0x7DA690", Offset = "0x7D8C90", VA = "0x1807DA690")]
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

		// Token: 0x06003793 RID: 14227 RVA: 0x00129D10 File Offset: 0x00127F10
		[Token(Token = "0x6003793")]
		[Address(RVA = "0x7DA5E0", Offset = "0x7D8BE0", VA = "0x1807DA5E0")]
		private void StartGame()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00129D34 File Offset: 0x00127F34
		[Token(Token = "0x6003794")]
		[Address(RVA = "0x7D8220", Offset = "0x7D6820", VA = "0x1807D8220")]
		private Task<AudioClip> FindMusicFromFile(string name)
		{
			AsyncTaskMethodBuilder asyncTaskMethodBuilder = AsyncTaskMethodBuilder.Create();
			Task task;
			return task;
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00129D58 File Offset: 0x00127F58
		[Token(Token = "0x6003795")]
		[Address(RVA = "0x7DAC10", Offset = "0x7D9210", VA = "0x1807DAC10")]
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

		// Token: 0x06003796 RID: 14230 RVA: 0x00129DD4 File Offset: 0x00127FD4
		[Token(Token = "0x6003796")]
		[Address(RVA = "0x7D7D40", Offset = "0x7D6340", VA = "0x1807D7D40")]
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

		// Token: 0x06003797 RID: 14231 RVA: 0x00129EDC File Offset: 0x001280DC
		[Token(Token = "0x6003797")]
		[Address(RVA = "0x7D7AA0", Offset = "0x7D60A0", VA = "0x1807D7AA0")]
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

		// Token: 0x06003798 RID: 14232 RVA: 0x00129FDC File Offset: 0x001281DC
		[Token(Token = "0x6003798")]
		[Address(RVA = "0x7DAB70", Offset = "0x7D9170", VA = "0x1807DAB70")]
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

		// Token: 0x06003799 RID: 14233 RVA: 0x0012A02C File Offset: 0x0012822C
		[Token(Token = "0x6003799")]
		[Address(RVA = "0x7DA360", Offset = "0x7D8960", VA = "0x1807DA360")]
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
					RhythmGameManager.<>c.<>9__35_0 = (NoteData n) => !n.spawned;
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

		// Token: 0x0600379A RID: 14234 RVA: 0x0012A0A4 File Offset: 0x001282A4
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x7D77B0", Offset = "0x7D5DB0", VA = "0x1807D77B0")]
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

		// Token: 0x0600379B RID: 14235 RVA: 0x0012A0E8 File Offset: 0x001282E8
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x7D80C0", Offset = "0x7D66C0", VA = "0x1807D80C0")]
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

		// Token: 0x0600379C RID: 14236 RVA: 0x0012A158 File Offset: 0x00128358
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x7D90A0", Offset = "0x7D76A0", VA = "0x1807D90A0")]
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

		// Token: 0x0600379D RID: 14237 RVA: 0x0012A38C File Offset: 0x0012858C
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x7D9CD0", Offset = "0x7D82D0", VA = "0x1807D9CD0")]
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

		// Token: 0x0600379E RID: 14238 RVA: 0x0012A3E4 File Offset: 0x001285E4
		[Token(Token = "0x600379E")]
		[Address(RVA = "0x7D9FE0", Offset = "0x7D85E0", VA = "0x1807D9FE0")]
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
						RhythmGameManager.<>c.<>9__40_0 = (Zombie z) => true;
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

		// Token: 0x0600379F RID: 14239 RVA: 0x0012A4DC File Offset: 0x001286DC
		[Token(Token = "0x600379F")]
		[Address(RVA = "0x7D9D70", Offset = "0x7D8370", VA = "0x1807D9D70")]
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

		// Token: 0x060037A0 RID: 14240 RVA: 0x0012A578 File Offset: 0x00128778
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x7D9EB0", Offset = "0x7D84B0", VA = "0x1807D9EB0")]
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x0012A5E8 File Offset: 0x001287E8
		[Token(Token = "0x1700028C")]
		public float CurrentTime
		{
			[Token(Token = "0x60037A1")]
			[Address(RVA = "0x3FC6D0", Offset = "0x3FACD0", VA = "0x1803FC6D0")]
			get
			{
				return this.currentBGMTime;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x0012A5FC File Offset: 0x001287FC
		[Token(Token = "0x1700028D")]
		public bool IsPaused
		{
			[Token(Token = "0x60037A2")]
			[Address(RVA = "0x7DAEE0", Offset = "0x7D94E0", VA = "0x1807DAEE0")]
			get
			{
				return this.isPaused;
			}
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0012A610 File Offset: 0x00128810
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x7D83D0", Offset = "0x7D69D0", VA = "0x1807D83D0")]
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

		// Token: 0x060037A4 RID: 14244 RVA: 0x0012A634 File Offset: 0x00128834
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x7D8F40", Offset = "0x7D7540", VA = "0x1807D8F40")]
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

		// Token: 0x060037A5 RID: 14245 RVA: 0x0012A67C File Offset: 0x0012887C
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x7D8920", Offset = "0x7D6F20", VA = "0x1807D8920")]
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

		// Token: 0x060037A6 RID: 14246 RVA: 0x0012A7B0 File Offset: 0x001289B0
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x7D8DE0", Offset = "0x7D73E0", VA = "0x1807D8DE0")]
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

		// Token: 0x060037A7 RID: 14247 RVA: 0x0012A820 File Offset: 0x00128A20
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x7D88F0", Offset = "0x7D6EF0", VA = "0x1807D88F0")]
		public void OnHoldKeyReleased(int trackIndex)
		{
			bool[] array = this.holdKeyPressed;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x0012A83C File Offset: 0x00128A3C
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x7D8410", Offset = "0x7D6A10", VA = "0x1807D8410")]
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

		// Token: 0x060037A9 RID: 14249 RVA: 0x0012A96C File Offset: 0x00128B6C
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x7DAD40", Offset = "0x7D9340", VA = "0x1807DAD40")]
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

		// Token: 0x04002B12 RID: 11026
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B12")]
		[Header("音频配置")]
		public AudioSource bgmSource;

		// Token: 0x04002B13 RID: 11027
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B13")]
		public float songStartTime;

		// Token: 0x04002B14 RID: 11028
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4002B14")]
		public float currentBGMTime;

		// Token: 0x04002B15 RID: 11029
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B15")]
		[Header("音符配置")]
		public List<NoteTrack> tracks;

		// Token: 0x04002B16 RID: 11030
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002B16")]
		public GameObject notePrefab;

		// Token: 0x04002B17 RID: 11031
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002B17")]
		[Header("关卡数据")]
		public RhythmLevelData currentLevel;

		// Token: 0x04002B18 RID: 11032
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002B18")]
		private List<NoteData> pendingNotes;

		// Token: 0x04002B19 RID: 11033
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002B19")]
		[Header("子系统")]
		public NoteJudgeSystem judgeSystem;

		// Token: 0x04002B1A RID: 11034
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002B1A")]
		public ComboManager comboManager;

		// Token: 0x04002B1B RID: 11035
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002B1B")]
		public TextMeshPro comboText;

		// Token: 0x04002B1C RID: 11036
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002B1C")]
		public TextMeshPro comboText2;

		// Token: 0x04002B1D RID: 11037
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002B1D")]
		private float targetScale;

		// Token: 0x04002B1E RID: 11038
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4002B1E")]
		private float targetScale2;

		// Token: 0x04002B1F RID: 11039
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B1F")]
		[Header("棋盘引用")]
		public Board board;

		// Token: 0x04002B20 RID: 11040
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002B20")]
		[Header("游戏状态")]
		public bool isPlaying;

		// Token: 0x04002B21 RID: 11041
		[FieldOffset(Offset = "0x81")]
		[Token(Token = "0x4002B21")]
		public bool isPaused;

		// Token: 0x04002B22 RID: 11042
		[FieldOffset(Offset = "0x82")]
		[Token(Token = "0x4002B22")]
		public bool allSet;

		// Token: 0x04002B23 RID: 11043
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4002B23")]
		public bool[] holdKeyPressed;

		// Token: 0x04002B24 RID: 11044
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002B24")]
		private Particle particle;

		// Token: 0x04002B25 RID: 11045
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002B25")]
		private float pauseTime;

		// Token: 0x04002B26 RID: 11046
		[FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x4002B26")]
		private float pauseBGMTime;
	}
}
