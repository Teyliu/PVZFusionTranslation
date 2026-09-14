using System;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RhythmGameEditor
{
	// Token: 0x02000A4C RID: 2636
	[Token(Token = "0x2000A4C")]
	public class NoteObject : MonoBehaviour
	{
		// Token: 0x0600360A RID: 13834 RVA: 0x0011F83C File Offset: 0x0011DA3C
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x79BF70", Offset = "0x79A570", VA = "0x18079BF70")]
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

		// Token: 0x0600360B RID: 13835 RVA: 0x0011F888 File Offset: 0x0011DA88
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x79BF00", Offset = "0x79A500", VA = "0x18079BF00")]
		private void CreateNormalNoteVisuals()
		{
			Image image;
			this.headImage = image;
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x0011F89C File Offset: 0x0011DA9C
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x79B9B0", Offset = "0x799FB0", VA = "0x18079B9B0")]
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

		// Token: 0x0600360D RID: 13837 RVA: 0x0011F990 File Offset: 0x0011DB90
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x79C550", Offset = "0x79AB50", VA = "0x18079C550")]
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

		// Token: 0x0600360E RID: 13838 RVA: 0x0011FB14 File Offset: 0x0011DD14
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x79BE00", Offset = "0x79A400", VA = "0x18079BE00")]
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

		// Token: 0x0600360F RID: 13839 RVA: 0x0011FB5C File Offset: 0x0011DD5C
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x79B5F0", Offset = "0x799BF0", VA = "0x18079B5F0")]
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

		// Token: 0x06003610 RID: 13840 RVA: 0x0011FBC4 File Offset: 0x0011DDC4
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x79B7B0", Offset = "0x799DB0", VA = "0x18079B7B0")]
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

		// Token: 0x06003611 RID: 13841 RVA: 0x0011FC40 File Offset: 0x0011DE40
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x79BD20", Offset = "0x79A320", VA = "0x18079BD20")]
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

		// Token: 0x06003612 RID: 13842 RVA: 0x0011FC7C File Offset: 0x0011DE7C
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x79B460", Offset = "0x799A60", VA = "0x18079B460")]
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

		// Token: 0x06003613 RID: 13843 RVA: 0x0011FCD4 File Offset: 0x0011DED4
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x79C0D0", Offset = "0x79A6D0", VA = "0x18079C0D0")]
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

		// Token: 0x06003614 RID: 13844 RVA: 0x0011FD64 File Offset: 0x0011DF64
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x79C340", Offset = "0x79A940", VA = "0x18079C340")]
		public void StartDragHead(Vector2 mousePosition)
		{
			int num = this.noteIndex;
			this.isDraggingHead = true;
			Debug.Log(string.Format("\ud83c\udfaf 开始拖动头部: 音符{0}", num));
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0011FD90 File Offset: 0x0011DF90
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x79C3F0", Offset = "0x79A9F0", VA = "0x18079C3F0")]
		public void StartDragTail(Vector2 mousePosition)
		{
			int num = this.noteIndex;
			this.isDraggingHead = false;
			Debug.Log(string.Format("\ud83c\udfaf 开始拖动尾部: 音符{0}", num));
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0011FDBC File Offset: 0x0011DFBC
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x79C070", Offset = "0x79A670", VA = "0x18079C070")]
		public void OnDrag(Vector2 mousePosition, bool enableSnap)
		{
			if ((!this.isDraggingHead && !this.isDraggingTail) || this.onDragWhole != 0)
			{
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0011FDE8 File Offset: 0x0011DFE8
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x79C4A0", Offset = "0x79AAA0", VA = "0x18079C4A0")]
		public void StopDrag()
		{
			if (this.isDraggingHead || this.isDraggingTail)
			{
				int num = this.noteIndex;
				Debug.Log(string.Format("⏹\ufe0f 停止拖动: 音符{0}", num));
			}
			this.isDraggingHead = false;
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0011FE28 File Offset: 0x0011E028
		[Token(Token = "0x6003618")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public NoteObject()
		{
		}

		// Token: 0x04002979 RID: 10617
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002979")]
		[Header("音符数据")]
		public NoteData noteData;

		// Token: 0x0400297A RID: 10618
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400297A")]
		public int noteIndex;

		// Token: 0x0400297B RID: 10619
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400297B")]
		[Header("渲染组件")]
		public UILine bodyLine;

		// Token: 0x0400297C RID: 10620
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400297C")]
		public Image headImage;

		// Token: 0x0400297D RID: 10621
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400297D")]
		[Header("Hold音符专用")]
		public GameObject tailObject;

		// Token: 0x0400297E RID: 10622
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400297E")]
		public UILine tailLine;

		// Token: 0x0400297F RID: 10623
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400297F")]
		public Image tailEndImage;

		// Token: 0x04002980 RID: 10624
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002980")]
		[Header("拖动控制")]
		public bool isDraggingHead;

		// Token: 0x04002981 RID: 10625
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4002981")]
		public bool isDraggingTail;

		// Token: 0x04002982 RID: 10626
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002982")]
		[Header("拖动回调")]
		public Action<int, Vector2, Vector2, bool> onDragWhole;

		// Token: 0x04002983 RID: 10627
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4002983")]
		public Action<int, Vector2, Vector2, bool> onDragTail;

		// Token: 0x04002984 RID: 10628
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4002984")]
		private Vector2 dragOffset;

		// Token: 0x04002985 RID: 10629
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002985")]
		private Camera uiCamera;

		// Token: 0x04002986 RID: 10630
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002986")]
		private TimelineRendererLineRenderer lineRenderer;
	}
}
