using System;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RhythmGameEditor
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	public class NoteObject : MonoBehaviour
	{
		// Token: 0x060034C9 RID: 13513 RVA: 0x0011A680 File Offset: 0x00118880
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x735520", Offset = "0x733B20", VA = "0x180735520")]
		public void Initialize(NoteData note, int index, Camera camera, TimelineRendererLineRenderer renderer)
		{
			this.lineRenderer = 0;
			this.noteData = note;
			this.noteIndex = index;
			this.uiCamera = camera;
			if (note.type != NoteType.Hold)
			{
				Image image;
				this.headImage = image;
			}
			this.CreateHoldNoteVisuals();
			this.UpdatePosition();
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0011A6CC File Offset: 0x001188CC
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x7354B0", Offset = "0x733AB0", VA = "0x1807354B0")]
		private void CreateNormalNoteVisuals()
		{
			Image image;
			this.headImage = image;
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x0011A6E0 File Offset: 0x001188E0
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x734F60", Offset = "0x733560", VA = "0x180734F60")]
		private void CreateHoldNoteVisuals()
		{
			GameObject gameObject = new GameObject("BodyLine");
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			int num = 0;
			transform.SetParent(transform2, num != 0);
			UILine uiline = gameObject.AddComponent<UILine>();
			uiline.width = 0.04f;
			this.bodyLine = uiline;
			Image image;
			this.headImage = image;
			GameObject gameObject2 = new GameObject("Tail");
			this.tailObject = gameObject2;
			Transform transform3 = this.tailObject.transform;
			Transform transform4 = base.transform;
			int num2 = 0;
			transform3.SetParent(transform4, num2 != 0);
			Transform transform5 = this.tailObject.transform;
			GameObject gameObject3 = new GameObject("TailEnd");
			Transform transform6 = gameObject3.transform;
			int num3 = 0;
			transform6.SetParent(transform5, num3 != 0);
			RectTransform rectTransform = gameObject3.AddComponent<RectTransform>();
			Image image2 = gameObject3.AddComponent<Image>();
			Sprite sprite = this.CreateCircleSprite();
			image2.sprite = sprite;
			image2.raycastTarget = true;
			this.tailEndImage = image2;
			throw new NullReferenceException();
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x0011A7D4 File Offset: 0x001189D4
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x735B00", Offset = "0x734100", VA = "0x180735B00")]
		public void UpdatePosition()
		{
			TimelineRendererLineRenderer timelineRendererLineRenderer = this.lineRenderer;
			float timelineWidth = timelineRendererLineRenderer.timelineWidth;
			float timelineHeight = timelineRendererLineRenderer.timelineHeight;
			float num = timelineRendererLineRenderer.clipLength;
			TimelineRendererLineRenderer timelineRendererLineRenderer2 = this.lineRenderer;
			int num2 = 0;
			float num3 = num * timelineRendererLineRenderer2.timelineScroll;
			if (num2 > (int)num3 || num3 > num)
			{
			}
			float time = this.noteData.time;
			if (num2 < (int)time && time < timelineWidth)
			{
				GameObject gameObject = base.gameObject;
			}
			GameObject gameObject2 = base.gameObject;
			int num4 = 0;
			gameObject2.SetActive(num4 != 0);
			num = timelineWidth;
			if (time > num)
			{
			}
			int num5 = this.noteData.track;
			num5++;
			Transform transform = base.transform;
			num = timelineWidth;
			float num6 = num * 0.5f;
			if (this.noteData.type == NoteType.Hold)
			{
				GameObject gameObject3 = this.tailObject;
				int num7 = 0;
				if (gameObject3 != num7)
				{
					float endTime = this.noteData.endTime;
					num6 = timelineWidth;
					if (endTime > num6)
					{
					}
					Transform transform2 = this.tailObject.transform;
				}
			}
			if (this.noteData.type == NoteType.Hold)
			{
				UILine uiline = this.bodyLine;
				int num8 = 0;
				if (uiline != num8)
				{
					float endTime2 = this.noteData.endTime;
					if (endTime2 > timelineWidth)
					{
					}
					UILine uiline2 = this.bodyLine;
					Vector2 zeroVector = Vector2.zeroVector;
					uiline2.startPosition = zeroVector;
					uiline2.startPosition.y = timelineWidth;
					this.bodyLine.endPosition.y = 0f;
					this.bodyLine.UpdateRectPosition();
				}
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0011A958 File Offset: 0x00118B58
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x7353B0", Offset = "0x7339B0", VA = "0x1807353B0")]
		private UILine CreateLineRenderer(string name, Color color, float width)
		{
			GameObject gameObject = new GameObject(name);
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			int num = 0;
			transform.SetParent(transform2, num != 0);
			UILine uiline = gameObject.AddComponent<UILine>();
			uiline.width = width;
			return uiline;
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0011A9A0 File Offset: 0x00118BA0
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x734BA0", Offset = "0x7331A0", VA = "0x180734BA0")]
		private Image CreateCircleImage(string name, Color color, int size)
		{
			GameObject gameObject = new GameObject(name);
			Transform transform = gameObject.transform;
			Transform transform2 = base.transform;
			int num = 0;
			transform.SetParent(transform2, num != 0);
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			Sprite sprite = this.CreateCircleSprite();
			image.sprite = sprite;
			image.raycastTarget = true;
			EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
			return image;
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0011AA08 File Offset: 0x00118C08
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x734D60", Offset = "0x733360", VA = "0x180734D60")]
		private Sprite CreateCircleSprite()
		{
			Color32[] array = new Color32[4096];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			Color32 color = 0;
			Color32 color2;
			int rgba = color2.rgba;
			num3++;
			num4++;
			array[0] = rgba;
			uint num5;
			num5 += (uint)1;
			num2 += 64;
			num += 64;
			Texture2D texture2D;
			texture2D.SetPixels32(array);
			texture2D.Apply();
			Sprite sprite;
			return sprite;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0011AA84 File Offset: 0x00118C84
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x7352D0", Offset = "0x7338D0", VA = "0x1807352D0")]
		private UILine CreateLineRendererForParent(Transform parent, string name, Color color, float width)
		{
			GameObject gameObject = new GameObject(name);
			Transform transform = gameObject.transform;
			int num = 0;
			transform.SetParent(parent, num != 0);
			UILine uiline = gameObject.AddComponent<UILine>();
			uiline.width = (float)0;
			return uiline;
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0011AAC0 File Offset: 0x00118CC0
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x734A10", Offset = "0x733010", VA = "0x180734A10")]
		private Image CreateCircleImageForParent(Transform parent, string name, Color color, int size)
		{
			GameObject gameObject = new GameObject(name);
			Transform transform = gameObject.transform;
			int num = 0;
			transform.SetParent(parent, num != 0);
			RectTransform rectTransform = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			Sprite sprite = this.CreateCircleSprite();
			image.sprite = sprite;
			image.raycastTarget = true;
			return image;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x0011AB18 File Offset: 0x00118D18
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x735680", Offset = "0x733C80", VA = "0x180735680")]
		public void SetHighlight(bool isHighlighted)
		{
			if (isHighlighted)
			{
			}
			UILine uiline = this.bodyLine;
			int num = 0;
			if (uiline != num)
			{
				UILine uiline2 = this.bodyLine;
			}
			Image image = this.headImage;
			int num2 = 0;
			if (image != num2)
			{
				Image image2 = this.headImage;
			}
			UILine uiline3 = this.tailLine;
			int num3 = 0;
			if (uiline3 != num3)
			{
				UILine uiline4 = this.tailLine;
			}
			Image image3 = this.tailEndImage;
			int num4 = 0;
			if (image3 != num4)
			{
				Image image4 = this.tailEndImage;
			}
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0011ABA8 File Offset: 0x00118DA8
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x7358F0", Offset = "0x733EF0", VA = "0x1807358F0")]
		public void StartDragHead(Vector2 mousePosition)
		{
			int num = this.noteIndex;
			this.isDraggingHead = true;
			Debug.Log(string.Format("\ud83c\udfaf 开始拖动头部: 音符{0}", num));
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0011ABD4 File Offset: 0x00118DD4
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x7359A0", Offset = "0x733FA0", VA = "0x1807359A0")]
		public void StartDragTail(Vector2 mousePosition)
		{
			int num = this.noteIndex;
			this.isDraggingHead = false;
			Debug.Log(string.Format("\ud83c\udfaf 开始拖动尾部: 音符{0}", num));
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0011AC00 File Offset: 0x00118E00
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x735620", Offset = "0x733C20", VA = "0x180735620")]
		public void OnDrag(Vector2 mousePosition, bool enableSnap)
		{
			if ((!this.isDraggingHead && !this.isDraggingTail) || this.onDragWhole != 0)
			{
			}
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0011AC2C File Offset: 0x00118E2C
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x735A50", Offset = "0x734050", VA = "0x180735A50")]
		public void StopDrag()
		{
			if (this.isDraggingHead || this.isDraggingTail)
			{
				int num = this.noteIndex;
				Debug.Log(string.Format("⏹\ufe0f 停止拖动: 音符{0}", num));
			}
			this.isDraggingHead = false;
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0011AC6C File Offset: 0x00118E6C
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public NoteObject()
		{
		}

		// Token: 0x0400280B RID: 10251
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400280B")]
		[Header("音符数据")]
		public NoteData noteData;

		// Token: 0x0400280C RID: 10252
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400280C")]
		public int noteIndex;

		// Token: 0x0400280D RID: 10253
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400280D")]
		[Header("渲染组件")]
		public UILine bodyLine;

		// Token: 0x0400280E RID: 10254
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400280E")]
		public Image headImage;

		// Token: 0x0400280F RID: 10255
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400280F")]
		[Header("Hold音符专用")]
		public GameObject tailObject;

		// Token: 0x04002810 RID: 10256
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002810")]
		public UILine tailLine;

		// Token: 0x04002811 RID: 10257
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002811")]
		public Image tailEndImage;

		// Token: 0x04002812 RID: 10258
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002812")]
		[Header("拖动控制")]
		public bool isDraggingHead;

		// Token: 0x04002813 RID: 10259
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4002813")]
		public bool isDraggingTail;

		// Token: 0x04002814 RID: 10260
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002814")]
		[Header("拖动回调")]
		public Action<int, Vector2, Vector2, bool> onDragWhole;

		// Token: 0x04002815 RID: 10261
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002815")]
		public Action<int, Vector2, Vector2, bool> onDragTail;

		// Token: 0x04002816 RID: 10262
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002816")]
		private Vector2 dragOffset;

		// Token: 0x04002817 RID: 10263
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002817")]
		private Camera uiCamera;

		// Token: 0x04002818 RID: 10264
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002818")]
		private TimelineRendererLineRenderer lineRenderer;
	}
}
