using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A90 RID: 2704
	[Token(Token = "0x2000A90")]
	public class NoteTrack : MonoBehaviour
	{
		// Token: 0x0600377B RID: 14203 RVA: 0x001296E0 File Offset: 0x001278E0
		[Token(Token = "0x600377B")]
		[Address(RVA = "0x7D4390", Offset = "0x7D2990", VA = "0x1807D4390")]
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

		// Token: 0x0600377C RID: 14204 RVA: 0x001297B8 File Offset: 0x001279B8
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x7D38F0", Offset = "0x7D1EF0", VA = "0x1807D38F0")]
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

		// Token: 0x0600377D RID: 14205 RVA: 0x0012984C File Offset: 0x00127A4C
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x7D42E0", Offset = "0x7D28E0", VA = "0x1807D42E0")]
		public void RemoveNote(FallingNote note)
		{
			if (this.activeNotes.Contains(note))
			{
				bool flag = this.activeNotes.Remove(note);
			}
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0012987C File Offset: 0x00127A7C
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x5EDAB0", Offset = "0x5EC0B0", VA = "0x1805EDAB0")]
		public List<FallingNote> GetActiveNotes()
		{
			return this.activeNotes;
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00129890 File Offset: 0x00127A90
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x7D4620", Offset = "0x7D2C20", VA = "0x1807D4620")]
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

		// Token: 0x06003780 RID: 14208 RVA: 0x0012990C File Offset: 0x00127B0C
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x7D3E80", Offset = "0x7D2480", VA = "0x1807D3E80")]
		private int GetTrackIndex()
		{
			Transform transform = base.transform;
			int num = 0;
			return num + 2;
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00129934 File Offset: 0x00127B34
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x7D3F20", Offset = "0x7D2520", VA = "0x1807D3F20")]
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

		// Token: 0x06003782 RID: 14210 RVA: 0x001299E0 File Offset: 0x00127BE0
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x7D4200", Offset = "0x7D2800", VA = "0x1807D4200")]
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

		// Token: 0x06003783 RID: 14211 RVA: 0x00129A24 File Offset: 0x00127C24
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x7D42D0", Offset = "0x7D28D0", VA = "0x1807D42D0")]
		private void OnMouseDown()
		{
			this.OnKeyDown();
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00129A38 File Offset: 0x00127C38
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x7D3CC0", Offset = "0x7D22C0", VA = "0x1807D3CC0")]
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

		// Token: 0x06003785 RID: 14213 RVA: 0x00129A74 File Offset: 0x00127C74
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x7D3B60", Offset = "0x7D2160", VA = "0x1807D3B60")]
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

		// Token: 0x06003786 RID: 14214 RVA: 0x00129AB0 File Offset: 0x00127CB0
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x7D3EF0", Offset = "0x7D24F0", VA = "0x1807D3EF0")]
		public void Highlight()
		{
			SpriteRenderer spriteRenderer = this.trackRenderer;
			Sprite sprite = this.highlightSprite;
			spriteRenderer.sprite = sprite;
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00129AD8 File Offset: 0x00127CD8
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x7D4360", Offset = "0x7D2960", VA = "0x1807D4360")]
		public void ResetHighlight()
		{
			SpriteRenderer spriteRenderer = this.trackRenderer;
			Sprite sprite = this.trackSprite;
			spriteRenderer.sprite = sprite;
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00129B00 File Offset: 0x00127D00
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x7D4760", Offset = "0x7D2D60", VA = "0x1807D4760")]
		public NoteTrack()
		{
			List<FallingNote> list = new List();
			this.activeNotes = list;
			base..ctor();
		}

		// Token: 0x04002B07 RID: 11015
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B07")]
		[Header("视觉配置")]
		public KeyCode keyCode;

		// Token: 0x04002B08 RID: 11016
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B08")]
		public Sprite trackSprite;

		// Token: 0x04002B09 RID: 11017
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B09")]
		public Sprite highlightSprite;

		// Token: 0x04002B0A RID: 11018
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002B0A")]
		public SpriteRenderer trackRenderer;

		// Token: 0x04002B0B RID: 11019
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002B0B")]
		public LineRenderer lineRenderer;

		// Token: 0x04002B0C RID: 11020
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002B0C")]
		public List<FallingNote> activeNotes;

		// Token: 0x04002B0D RID: 11021
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002B0D")]
		public FallingNote currentHoldNote;

		// Token: 0x04002B0E RID: 11022
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002B0E")]
		public int trackIndex;
	}
}
