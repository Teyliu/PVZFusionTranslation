using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RhythmGame;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace RhythmGameEditor
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	public class TimelineRendererLineRenderer : MonoBehaviour
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x0011D7EC File Offset: 0x0011B9EC
		// (set) Token: 0x06003528 RID: 13608 RVA: 0x0011D800 File Offset: 0x0011BA00
		[Token(Token = "0x17000237")]
		public float currentTime
		{
			[Token(Token = "0x6003527")]
			[Address(RVA = "0x75E910", Offset = "0x75CF10", VA = "0x18075E910")]
			get;
			[Token(Token = "0x6003528")]
			[Address(RVA = "0x75E920", Offset = "0x75CF20", VA = "0x18075E920")]
			private set;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06003529 RID: 13609 RVA: 0x0011D814 File Offset: 0x0011BA14
		[Token(Token = "0x17000238")]
		public float clipLength
		{
			[Token(Token = "0x6003529")]
			[Address(RVA = "0x75E830", Offset = "0x75CE30", VA = "0x18075E830")]
			get
			{
				AudioSource audioSource = this.audioSource;
				int num = 0;
				if (audioSource != num)
				{
					AudioClip clip = this.audioSource.clip;
					int num2 = 0;
					if (clip != num2)
					{
						return this.audioSource.clip.length;
					}
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x0011D868 File Offset: 0x0011BA68
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x75D010", Offset = "0x75B610", VA = "0x18075D010")]
		public void Initialize(AudioSource source, float beatsPerMinute)
		{
			this.audioSource = source;
			this.bpm = beatsPerMinute;
			Camera main = Camera.main;
			this.uiCamera = main;
			if (this.debugMode)
			{
				Debug.Log("TimelineRendererLineRenderer: 初始化完成");
			}
			this.CreateBeatLinePool();
			GameObject gameObject = new GameObject("Background");
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.timelineContainer;
			int num = 0;
			transform.SetParent(rectTransform, num != 0);
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			Color color = this.backgroundColor;
			image.color = color;
			this.CreateTrackLines();
			this.CreatePlayheadLine();
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x0011D908 File Offset: 0x0011BB08
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x75BA30", Offset = "0x75A030", VA = "0x18075BA30")]
		private void CreateBeatLinePool()
		{
			Action<GameObject> <>9__31_ = TimelineRendererLineRenderer.<>c.<>9__31_1;
			if (<>9__31_ == 0)
			{
				Action<GameObject> action;
				TimelineRendererLineRenderer.<>c.<>9__31_1 = action;
			}
			Action<GameObject> action2;
			if (TimelineRendererLineRenderer.<>c.<>9__31_2 == 0)
			{
				TimelineRendererLineRenderer.<>c.<>9__31_2 = action2;
			}
			Action<GameObject> action3;
			if (TimelineRendererLineRenderer.<>c.<>9__31_3 == 0)
			{
				TimelineRendererLineRenderer.<>c.<>9__31_3 = action3;
			}
			Func<GameObject> func;
			ulong num;
			ulong num2;
			ulong num3;
			ObjectPool<GameObject> objectPool = new ObjectPool(func, <>9__31_, action2, action3, num != 0UL, (int)num2, (int)num3);
			this.beatLinePool = objectPool;
			throw new NullReferenceException();
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x0011D964 File Offset: 0x0011BB64
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x75B8B0", Offset = "0x759EB0", VA = "0x18075B8B0")]
		private void CreateBackground()
		{
			GameObject gameObject = new GameObject("Background");
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.timelineContainer;
			int num = 0;
			transform.SetParent(rectTransform, num != 0);
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			Color color = this.backgroundColor;
			image.color = color;
			this.CreateTrackLines();
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x0011D9C4 File Offset: 0x0011BBC4
		[Token(Token = "0x600352D")]
		[Address(RVA = "0x75C090", Offset = "0x75A690", VA = "0x18075C090")]
		private void CreateTrackLines()
		{
			int num;
			GameObject gameObject = new GameObject(string.Format("TrackLine{0}", num));
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.timelineContainer;
			int num2 = 0;
			transform.SetParent(rectTransform, num2 != 0);
			RectTransform rectTransform2 = gameObject.AddComponent<RectTransform>();
			Image image = gameObject.AddComponent<Image>();
			Color color = this.gridColor;
			image.color = color;
			uint num3;
			num3 += (uint)1;
			while (num3 <= (uint)4)
			{
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x0011DA30 File Offset: 0x0011BC30
		[Token(Token = "0x600352E")]
		[Address(RVA = "0x75BED0", Offset = "0x75A4D0", VA = "0x18075BED0")]
		private void CreatePlayheadLine()
		{
			GameObject gameObject = this.playheadLine;
			int num = 0;
			if (!(gameObject != num))
			{
				GameObject gameObject2 = new GameObject("PlayheadLine");
				this.playheadLine = gameObject2;
				Transform transform = this.playheadLine.transform;
				RectTransform rectTransform = this.timelineContainer;
				int num2 = 0;
				transform.SetParent(rectTransform, num2 != 0);
				RectTransform rectTransform2 = this.playheadLine.AddComponent<RectTransform>();
				float num3 = this.timelineWidth;
				Image image = this.playheadLine.AddComponent<Image>();
				Color color = this.playheadColor;
				image.color = color;
			}
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x0011DAC0 File Offset: 0x0011BCC0
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x75E650", Offset = "0x75CC50", VA = "0x18075E650")]
		public void UpdateTimeline(List<NoteData> notes, float time, bool enableSnap)
		{
			this.<currentTime>k__BackingField = time;
			this.UpdatePlayheadLine();
			this.UpdateBeatLines();
			this.UpdateNoteObjects(notes);
			if (Input.GetMouseButtonDown(0))
			{
				this.HandleMouseDown(notes, enableSnap);
			}
			if (Input.GetMouseButton(0))
			{
				this.HandleMouseDrag(notes, enableSnap);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.HandleMouseUp();
			}
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x0011DB18 File Offset: 0x0011BD18
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x75E4C0", Offset = "0x75CAC0", VA = "0x18075E4C0")]
		private void UpdatePlayheadLine()
		{
			GameObject gameObject = this.playheadLine;
			int num = 0;
			if (!(gameObject == num))
			{
				float clipLength = this.clipLength;
				float clipLength2 = this.clipLength;
				float clipLength3 = this.clipLength;
				if (0 > (int)clipLength2 || clipLength2 > clipLength3)
				{
				}
				float num2 = this.<currentTime>k__BackingField;
				float num3 = this.timelineWidth;
				RectTransform component = this.playheadLine.GetComponent<RectTransform>();
				this.playheadLine.SetActive(true);
			}
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x0011DB94 File Offset: 0x0011BD94
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x75D980", Offset = "0x75BF80", VA = "0x18075D980")]
		private void UpdateBeatLines()
		{
			ulong num3;
			do
			{
				int num = 0;
				HashSet<GameObject> hashSet = this.activeBeatLines;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					this.beatLinePool.Release(num);
				}
			}
			while (num3 != (ulong)0L);
			int num4 = 0;
			float num5;
			float num6;
			if (num4 <= (int)num5)
			{
				if (num5 <= num6)
				{
					goto IL_004A;
				}
				num5 = num6;
			}
			int num7 = 0;
			IL_004A:
			if (num6 >= 7f || num6 < 4f)
			{
			}
			float num8;
			if (num7 <= (int)num8 && num4 <= num7 && num7 <= 1065353216)
			{
				if (num7 < 1065353216)
				{
				}
				if (num7 < 1065353216)
				{
				}
				GameObject gameObject;
				RectTransform component = gameObject.GetComponent<RectTransform>();
				Transform transform = gameObject.transform.Find("Label");
				int num9 = 0;
				if (transform != num9)
				{
					GameObject gameObject2 = transform.gameObject;
					int num10 = 0;
					gameObject2.SetActive(num10 != 0);
				}
			}
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x0011DC74 File Offset: 0x0011BE74
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x75DF30", Offset = "0x75C530", VA = "0x18075DF30")]
		private void UpdateNoteObjects(List<NoteData> notes)
		{
			int num3;
			ulong num5;
			do
			{
				int num = 0;
				if (notes == 0)
				{
					return;
				}
				if (this.lastNotesCount == -1)
				{
					int size = notes._size;
					this.lastNotesCount = size;
					List<NoteObject> list = this.noteObjects;
					int size2 = notes._size;
					this.CreateNoteObject();
					List<NoteObject> list2 = this.noteObjects;
				}
				int num2 = this.lastNotesCount;
				int size3 = notes._size;
				this.lastNotesCount = size3;
				while (num2 == size3)
				{
				}
				List<NoteObject> list3 = this.noteObjects;
				bool flag;
				if (flag)
				{
					num3 = 0;
					int num4 = 0;
					if (!(num != num4))
					{
						continue;
					}
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
				}
			}
			while (num5 != (ulong)0L);
			if (num3 > 0)
			{
			}
			int num6 = 0;
			num6++;
			List<NoteObject> list4 = this.noteObjects;
			int num7 = 0;
			NoteObject noteObject;
			GameObject gameObject2;
			if (noteObject != num7)
			{
				NoteObject noteObject2;
				gameObject2 = noteObject2.gameObject;
				global::UnityEngine.Object.Destroy(gameObject2);
			}
			while (gameObject2 != 0)
			{
			}
			int num8 = 0;
			NoteObject noteObject3;
			if (noteObject3.noteData != (ulong)0L)
			{
				NoteData noteData = noteObject3.noteData;
				NoteData noteData2;
				NoteType type = noteData2.type;
				if (noteData.type == type)
				{
					noteObject3.noteData = noteData2;
					noteObject3.noteIndex = num8;
				}
			}
			Action<int, Vector2, Vector2, bool> action;
			noteObject3.onDragWhole = action;
			Action<int, Vector2, Vector2, bool> action2;
			noteObject3.onDragTail = action2;
			noteObject3.UpdatePosition();
			bool flag2 = num8 == "{il2cpp field on {'constant40' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StackPointer)}, offset 0x90}";
			noteObject3.SetHighlight(flag2);
			num8++;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0011DDD4 File Offset: 0x0011BFD4
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x75BD40", Offset = "0x75A340", VA = "0x18075BD40")]
		private void CreateNoteObject()
		{
			int size = this.noteObjects._size;
			GameObject gameObject = new GameObject(string.Format("Note_{0}", size));
			Transform transform = gameObject.transform;
			RectTransform rectTransform = this.timelineContainer;
			int num = 0;
			transform.SetParent(rectTransform, num != 0);
			NoteObject noteObject = gameObject.AddComponent<NoteObject>();
			int size2 = this.noteObjects._size;
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x0011DE40 File Offset: 0x0011C040
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x75D4C0", Offset = "0x75BAC0", VA = "0x18075D4C0")]
		private void RemoveNoteObject(int index)
		{
			NoteObject noteObject = this.noteObjects[index];
			int num = 0;
			if (noteObject != num)
			{
				global::UnityEngine.Object.Destroy(this.noteObjects[index].gameObject);
			}
			this.noteObjects.RemoveAt(index);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x0011DE90 File Offset: 0x0011C090
		[Token(Token = "0x6003535")]
		[Address(RVA = "0x75CE20", Offset = "0x75B420", VA = "0x18075CE20")]
		private void HandleMouseInput(List<NoteData> notes, bool enableSnap)
		{
			if (Input.GetMouseButtonDown(0))
			{
				this.HandleMouseDown(notes, enableSnap);
			}
			if (Input.GetMouseButton(0))
			{
				this.HandleMouseDrag(notes, enableSnap);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.HandleMouseUp();
			}
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x0011DED0 File Offset: 0x0011C0D0
		[Token(Token = "0x6003536")]
		[Address(RVA = "0x75C800", Offset = "0x75AE00", VA = "0x18075C800")]
		private void HandleMouseDown(List<NoteData> notes, bool enableSnap)
		{
			int num = 0;
			if (this.GetLocalMousePosition(num))
			{
				List<NoteObject> list = this.noteObjects;
				int num2 = 0;
				NoteObject noteObject = this.noteObjects[num2];
				int num3 = 0;
				if (!(noteObject == num3))
				{
					Transform transform = noteObject.transform;
					if (0 == 0)
					{
						goto IL_009C;
					}
					if (noteObject.noteData.type == NoteType.Hold)
					{
						GameObject tailObject = noteObject.tailObject;
						int num4 = 0;
						if (tailObject != num4)
						{
							Transform transform2 = noteObject.tailObject.transform;
							Transform transform3 = noteObject.transform;
							if (0 == 0)
							{
								goto IL_0094;
							}
						}
					}
				}
				List<NoteObject> list2 = this.noteObjects;
				num2++;
				IL_0094:
				noteObject.StartDragTail(num);
				IL_009C:
				noteObject.StartDragHead(num);
				Action<int> onNoteSelected = this.OnNoteSelected;
				this.selectedNoteIndex = num2;
				if (onNoteSelected != 0)
				{
					float clipLength = this.clipLength;
					float clipLength2 = this.clipLength;
					float clipLength3 = this.clipLength;
					int num5 = 0;
					if (num5 > (int)clipLength2 || clipLength2 > clipLength3)
					{
					}
					if (this.selectedNoteIndex != -1)
					{
						this.selectedNoteIndex = (int)((ulong)4294967295L);
						throw new NullReferenceException();
					}
					AudioSource audioSource = this.audioSource;
					float clipLength4 = this.clipLength;
					int num6;
					if (num5 > num || num > (int)clipLength4)
					{
						num6 = 0;
					}
					audioSource.time = (float)num6;
					this.isDraggingTimeline = true;
					if (this.OnPositionClicked != 0)
					{
					}
				}
			}
		}

		// Token: 0x06003537 RID: 13623 RVA: 0x0011E018 File Offset: 0x0011C218
		[Token(Token = "0x6003537")]
		[Address(RVA = "0x75CBE0", Offset = "0x75B1E0", VA = "0x18075CBE0")]
		private void HandleMouseDrag(List<NoteData> notes, bool enableSnap)
		{
			int num = 0;
			if (this.GetLocalMousePosition(num))
			{
				List<NoteObject> list = this.noteObjects;
				int num2 = 0;
				NoteObject noteObject = this.noteObjects[num2];
				int num3 = 0;
				bool flag = noteObject == num3;
				if (flag || (noteObject.isDraggingHead == flag && noteObject.isDraggingTail == flag))
				{
					List<NoteObject> list2 = this.noteObjects;
					num2++;
				}
				noteObject.OnDrag(num, enableSnap);
			}
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x0011E0F4 File Offset: 0x0011C2F4
		[Token(Token = "0x6003538")]
		[Address(RVA = "0x75CEA0", Offset = "0x75B4A0", VA = "0x18075CEA0")]
		private void HandleMouseUp()
		{
			ulong num3;
			do
			{
				int num = 0;
				List<NoteObject> list = this.noteObjects;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
				}
			}
			while (num3 != (ulong)0L);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x0011E134 File Offset: 0x0011C334
		[Token(Token = "0x6003539")]
		[Address(RVA = "0x75D240", Offset = "0x75B840", VA = "0x18075D240")]
		private bool IsPointOnCircle(Vector2 point, Vector3 circleCenter, float radius)
		{
			return false;
		}

		// Token: 0x0600353A RID: 13626 RVA: 0x0011E144 File Offset: 0x0011C344
		[Token(Token = "0x600353A")]
		[Address(RVA = "0x75D5F0", Offset = "0x75BBF0", VA = "0x18075D5F0")]
		private float SnapToBeat(float time)
		{
			int num = 0;
			if (time == (float)num)
			{
				return 0f;
			}
			return 0f;
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x0011E164 File Offset: 0x0011C364
		[Token(Token = "0x600353B")]
		[Address(RVA = "0x75C640", Offset = "0x75AC40", VA = "0x18075C640")]
		private bool GetLocalMousePosition([Out] Vector2 localPoint)
		{
			Vector2 zeroVector = Vector2.zeroVector;
			localPoint.x = zeroVector;
			RectTransform rectTransform = this.timelineContainer;
			int num = 0;
			if (!(rectTransform == num))
			{
				RectTransform rectTransform2 = this.timelineContainer;
				int num2 = 0;
				if (!(rectTransform2 == num2))
				{
					int num3 = 0;
					float z = Input.mousePosition.z;
					Camera camera = this.uiCamera;
					if (RectTransformUtility.RectangleContainsScreenPoint(rectTransform2, num3, camera))
					{
						int num4 = 0;
						Vector3 mousePosition = Input.mousePosition;
						Camera camera2 = this.uiCamera;
						bool flag = RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform2, num4, camera2, localPoint);
					}
				}
			}
			return false;
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0011E1F0 File Offset: 0x0011C3F0
		[Token(Token = "0x600353C")]
		[Address(RVA = "0x75C460", Offset = "0x75AA60", VA = "0x18075C460")]
		public void DragNoteWhole(int noteIndex, Vector2 mousePosition, Vector2 dragOffset, bool enableSnap)
		{
			NoteData noteData = this.noteObjects[noteIndex].noteData;
			if (noteData != 0)
			{
				float clipLength = this.clipLength;
				float clipLength2 = this.clipLength;
				float clipLength3 = this.clipLength;
				int num = 0;
				if (num > (int)clipLength2 || clipLength2 > clipLength3)
				{
				}
				int num3;
				if (noteData.type != NoteType.Hold)
				{
					float clipLength4 = this.clipLength;
					float num2;
					if (num <= (int)num2)
					{
						if (num2 <= clipLength4)
						{
							goto IL_0068;
						}
						num2 = clipLength4;
						noteData.time = num2;
					}
					num3 = 0;
					IL_0068:
					noteData.time = (float)num3;
				}
				float clipLength5 = this.clipLength;
				int num4;
				if (num > num3 || num3 > (int)clipLength5)
				{
					num4 = 0;
				}
				noteData.time = (float)num4;
				float clipLength6 = this.clipLength;
				noteData.endTime = (float)num4;
				if (this.OnNoteDragged != 0)
				{
				}
			}
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0011E2AC File Offset: 0x0011C4AC
		[Token(Token = "0x600353D")]
		[Address(RVA = "0x75C2C0", Offset = "0x75A8C0", VA = "0x18075C2C0")]
		public void DragNoteTail(int noteIndex, Vector2 mousePosition, Vector2 dragOffset, bool enableSnap)
		{
			NoteData noteData = this.noteObjects[noteIndex].noteData;
			if (noteData != 0 && noteData.type == NoteType.Hold)
			{
				float clipLength = this.clipLength;
				float clipLength2 = this.clipLength;
				float clipLength3 = this.clipLength;
				if (0 > (int)clipLength2 || clipLength2 > clipLength3)
				{
				}
				float time = noteData.time;
				float clipLength4 = this.clipLength;
				float num;
				if (time <= num)
				{
					if (num <= clipLength4)
					{
						goto IL_0062;
					}
					num = clipLength4;
				}
				num = time;
				IL_0062:
				noteData.endTime = num;
				if (this.OnNoteDragged != 0)
				{
				}
			}
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x0011E334 File Offset: 0x0011C534
		[Token(Token = "0x600353E")]
		[Address(RVA = "0x75B8A0", Offset = "0x759EA0", VA = "0x18075B8A0")]
		public void ClearSelection()
		{
			this.selectedNoteIndex = (int)((ulong)4294967295L);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x0011E354 File Offset: 0x0011C554
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x75D290", Offset = "0x75B890", VA = "0x18075D290")]
		private void OnDestroy()
		{
			ulong num3;
			do
			{
				int num = 0;
				List<NoteObject> list = this.noteObjects;
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (!(num != num2))
					{
						continue;
					}
					GameObject gameObject;
					global::UnityEngine.Object.Destroy(gameObject);
				}
			}
			while (num3 != (ulong)0L);
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x0011E39C File Offset: 0x0011C59C
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x75E700", Offset = "0x75CD00", VA = "0x18075E700")]
		public TimelineRendererLineRenderer()
		{
			List<NoteObject> list = new List();
			this.noteObjects = list;
			this.lastNotesCount = (int)((ulong)4294967295L);
			HashSet<GameObject> hashSet = new HashSet();
			this.activeBeatLines = hashSet;
			base..ctor();
		}

		// Token: 0x04002858 RID: 10328
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002858")]
		[Header("UI引用")]
		public RectTransform timelineContainer;

		// Token: 0x04002859 RID: 10329
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002859")]
		[Header("渲染设置")]
		public float timelineWidth = 1400f;

		// Token: 0x0400285A RID: 10330
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400285A")]
		public float timelineHeight = 160f;

		// Token: 0x0400285B RID: 10331
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400285B")]
		[Range(0.1f, 10f)]
		public float timelineZoom = 1f;

		// Token: 0x0400285C RID: 10332
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x400285C")]
		[Range(0f, 1f)]
		public float timelineScroll;

		// Token: 0x0400285D RID: 10333
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400285D")]
		public float bpm;

		// Token: 0x0400285E RID: 10334
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400285E")]
		[Header("颜色设置")]
		public Color backgroundColor;

		// Token: 0x0400285F RID: 10335
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x400285F")]
		public Color noteColor;

		// Token: 0x04002860 RID: 10336
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4002860")]
		public Color selectedNoteColor;

		// Token: 0x04002861 RID: 10337
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4002861")]
		public Color playheadColor;

		// Token: 0x04002862 RID: 10338
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4002862")]
		public Color gridColor;

		// Token: 0x04002863 RID: 10339
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4002863")]
		[Header("调试设置")]
		public bool debugMode;

		// Token: 0x04002864 RID: 10340
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4002864")]
		public int selectedNoteIndex = (int)((ulong)4294967295L);

		// Token: 0x04002866 RID: 10342
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4002866")]
		private List<NoteObject> noteObjects;

		// Token: 0x04002867 RID: 10343
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4002867")]
		private int lastNotesCount;

		// Token: 0x04002868 RID: 10344
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4002868")]
		private ObjectPool<GameObject> beatLinePool;

		// Token: 0x04002869 RID: 10345
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4002869")]
		private HashSet<GameObject> activeBeatLines;

		// Token: 0x0400286A RID: 10346
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400286A")]
		private GameObject playheadLine;

		// Token: 0x0400286B RID: 10347
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x400286B")]
		private AudioSource audioSource;

		// Token: 0x0400286C RID: 10348
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x400286C")]
		private Camera uiCamera;

		// Token: 0x0400286D RID: 10349
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400286D")]
		private bool isDraggingTimeline;

		// Token: 0x0400286E RID: 10350
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x400286E")]
		public Action<int> OnNoteSelected;

		// Token: 0x0400286F RID: 10351
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400286F")]
		public Action<float> OnPositionClicked;

		// Token: 0x04002870 RID: 10352
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4002870")]
		public Action<NoteData> OnNoteDragged;
	}
}
