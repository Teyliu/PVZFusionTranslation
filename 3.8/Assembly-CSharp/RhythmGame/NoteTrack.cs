using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A50 RID: 2640
	[Token(Token = "0x2000A50")]
	public class NoteTrack : MonoBehaviour
	{
		// Token: 0x06003637 RID: 13879 RVA: 0x00124464 File Offset: 0x00122664
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x76D550", Offset = "0x76BB50", VA = "0x18076D550")]
		private void Start()
		{
			LineRenderer lineRenderer = this.lineRenderer;
			int num = 0;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			LineRenderer lineRenderer2 = this.lineRenderer;
			Transform transform2 = base.transform;
			Vector3 vector2;
			float z2 = vector2.z;
			Vector3 vector3;
			float z3 = vector3.z;
			GameConfig config = GameAPP.config;
			KeyCode keyCode = this.keyCode;
			PlayerSettings rhythmSettings = config.rhythmSettings;
			if ((keyCode <= KeyCode.J || ((keyCode != KeyCode.K || rhythmSettings.k4 != (KeyCode)num) && keyCode == KeyCode.S && rhythmSettings.k1 != (KeyCode)num)) && (keyCode != KeyCode.D || rhythmSettings.k2 != (KeyCode)num) && keyCode == KeyCode.J && rhythmSettings.k3 != (KeyCode)num)
			{
				KeyCode k = rhythmSettings.k3;
				this.keyCode = k;
			}
			TextMeshPro componentInChildren = base.GetComponentInChildren<TextMeshPro>();
			KeyCode keyCode2 = this.keyCode;
			string text;
			componentInChildren.text = text;
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0012453C File Offset: 0x0012273C
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x76CAB0", Offset = "0x76B0B0", VA = "0x18076CAB0")]
		public void AddNote(FallingNote note, NoteData noteData)
		{
			int num = 0;
			bool flag = note != num;
			if (flag)
			{
				List<FallingNote> list = this.activeNotes;
				int size = list._size;
				list._size = (flag ? 1 : 0);
				float fallTime = RhythmGameManager.<Instance>k__BackingField.currentLevel.fallTime;
				Transform transform = base.transform;
				Vector3 vector;
				float y = vector.y;
				note.Initialize(noteData, fallTime, y);
				Transform transform2 = note.transform;
				Transform transform3 = base.transform;
				Vector3 vector2;
				float z = vector2.z;
				Transform transform4 = note.transform;
				Vector3 vector3;
				float z2 = vector3.z;
			}
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x001245D0 File Offset: 0x001227D0
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x76D4A0", Offset = "0x76BAA0", VA = "0x18076D4A0")]
		public void RemoveNote(FallingNote note)
		{
			if (this.activeNotes.Contains(note))
			{
				bool flag = this.activeNotes.Remove(note);
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00124600 File Offset: 0x00122800
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x5B7FE0", Offset = "0x5B65E0", VA = "0x1805B7FE0")]
		public List<FallingNote> GetActiveNotes()
		{
			return this.activeNotes;
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00124614 File Offset: 0x00122814
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x76D7E0", Offset = "0x76BDE0", VA = "0x18076D7E0")]
		private void Update()
		{
			if (Input.GetKeyDownInt(this.keyCode))
			{
				this.OnKeyDown();
			}
			if (Input.GetKeyUpInt(this.keyCode))
			{
				FallingNote fallingNote = this.currentHoldNote;
				int num = 0;
				if (fallingNote != num)
				{
					FallingNote fallingNote2 = this.currentHoldNote;
					int num2 = 0;
					if (fallingNote2 != num2)
					{
						bool[] holdKeyPressed = RhythmGameManager.<Instance>k__BackingField.holdKeyPressed;
						int num3 = this.trackIndex;
						this.currentHoldNote = (ulong)0L;
					}
				}
			}
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00124690 File Offset: 0x00122890
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x76D040", Offset = "0x76B640", VA = "0x18076D040")]
		private int GetTrackIndex()
		{
			Transform transform = base.transform;
			int num = 0;
			return num + 2;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x001246B8 File Offset: 0x001228B8
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x76D0E0", Offset = "0x76B6E0", VA = "0x18076D0E0")]
		private void OnKeyDown()
		{
			SpriteRenderer spriteRenderer = this.trackRenderer;
			Sprite sprite = this.highlightSprite;
			spriteRenderer.sprite = sprite;
			FallingNote holdNoteAtJudgmentLine = this.GetHoldNoteAtJudgmentLine();
			int num = 0;
			if (!(holdNoteAtJudgmentLine != num))
			{
				List<FallingNote> list = this.activeNotes;
				Func<FallingNote, float> <>9__18_ = NoteTrack.<>c.<>9__18_0;
				if (<>9__18_ == 0)
				{
					Func<FallingNote, float> func;
					NoteTrack.<>c.<>9__18_0 = func;
				}
				FallingNote fallingNote = Enumerable.FirstOrDefault<FallingNote>(Enumerable.OrderBy<FallingNote, float>(list, <>9__18_));
				int num2 = 0;
				int num3 = 0;
				bool flag;
				if (!(num2 != num3) || !flag)
				{
					goto IL_007D;
				}
			}
			holdNoteAtJudgmentLine.OnClick();
			holdNoteAtJudgmentLine.OnHoldStart();
			this.currentHoldNote = holdNoteAtJudgmentLine;
			IL_007D:
			base.CancelInvoke("ResetHighlight");
			base.Invoke("ResetHighlight", 0.2f);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00124764 File Offset: 0x00122964
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x76D3C0", Offset = "0x76B9C0", VA = "0x18076D3C0")]
		private void OnKeyUp()
		{
			FallingNote fallingNote = this.currentHoldNote;
			int num = 0;
			if (fallingNote != num)
			{
				bool[] holdKeyPressed = RhythmGameManager.<Instance>k__BackingField.holdKeyPressed;
				int num2 = this.trackIndex;
				this.currentHoldNote = (ulong)0L;
			}
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x001247A8 File Offset: 0x001229A8
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x76D490", Offset = "0x76BA90", VA = "0x18076D490")]
		private void OnMouseDown()
		{
			this.OnKeyDown();
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x001247BC File Offset: 0x001229BC
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x76CE80", Offset = "0x76B480", VA = "0x18076CE80")]
		private FallingNote GetHoldNoteAtJudgmentLine()
		{
			ulong num;
			do
			{
				RhythmGameManager <Instance>k__BackingField = RhythmGameManager.<Instance>k__BackingField;
				List<FallingNote> list = this.activeNotes;
				bool flag;
				if (flag)
				{
					bool flag2;
					while (!flag2)
					{
					}
				}
			}
			while (num != (ulong)0L);
			throw new NullReferenceException();
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x001247F8 File Offset: 0x001229F8
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x76CD20", Offset = "0x76B320", VA = "0x18076CD20")]
		private FallingNote FindBottomMostNote()
		{
			List<FallingNote> list = this.activeNotes;
			Func<FallingNote, float> <>9__18_ = NoteTrack.<>c.<>9__18_0;
			if (<>9__18_ == 0)
			{
				Func<FallingNote, float> func;
				NoteTrack.<>c.<>9__18_0 = func;
			}
			return Enumerable.FirstOrDefault<FallingNote>(Enumerable.OrderBy<FallingNote, float>(list, <>9__18_));
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00124834 File Offset: 0x00122A34
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x76D0B0", Offset = "0x76B6B0", VA = "0x18076D0B0")]
		public void Highlight()
		{
			SpriteRenderer spriteRenderer = this.trackRenderer;
			Sprite sprite = this.highlightSprite;
			spriteRenderer.sprite = sprite;
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x0012485C File Offset: 0x00122A5C
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x76D520", Offset = "0x76BB20", VA = "0x18076D520")]
		public void ResetHighlight()
		{
			SpriteRenderer spriteRenderer = this.trackRenderer;
			Sprite sprite = this.trackSprite;
			spriteRenderer.sprite = sprite;
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00124884 File Offset: 0x00122A84
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x76D920", Offset = "0x76BF20", VA = "0x18076D920")]
		public NoteTrack()
		{
			List<FallingNote> list = new List();
			this.activeNotes = list;
			base..ctor();
		}

		// Token: 0x04002994 RID: 10644
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002994")]
		[Header("视觉配置")]
		public KeyCode keyCode;

		// Token: 0x04002995 RID: 10645
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002995")]
		public Sprite trackSprite;

		// Token: 0x04002996 RID: 10646
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002996")]
		public Sprite highlightSprite;

		// Token: 0x04002997 RID: 10647
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002997")]
		public SpriteRenderer trackRenderer;

		// Token: 0x04002998 RID: 10648
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002998")]
		public LineRenderer lineRenderer;

		// Token: 0x04002999 RID: 10649
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002999")]
		public List<FallingNote> activeNotes;

		// Token: 0x0400299A RID: 10650
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400299A")]
		public FallingNote currentHoldNote;

		// Token: 0x0400299B RID: 10651
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400299B")]
		public int trackIndex;
	}
}
