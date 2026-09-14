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
	// Token: 0x02000A53 RID: 2643
	[Token(Token = "0x2000A53")]
	public class TimelineRendererLineRenderer : MonoBehaviour
	{
		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06003668 RID: 13928 RVA: 0x00122908 File Offset: 0x00120B08
		// (set) Token: 0x06003669 RID: 13929 RVA: 0x0012291C File Offset: 0x00120B1C
		[Token(Token = "0x1700027F")]
		public float currentTime
		{
			[Token(Token = "0x6003668")]
			[Address(RVA = "0x7C5570", Offset = "0x7C3B70", VA = "0x1807C5570")]
			get;
			[Token(Token = "0x6003669")]
			[Address(RVA = "0x7C5580", Offset = "0x7C3B80", VA = "0x1807C5580")]
			private set;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x00122930 File Offset: 0x00120B30
		[Token(Token = "0x17000280")]
		public float clipLength
		{
			[Token(Token = "0x600366A")]
			[Address(RVA = "0x7C5490", Offset = "0x7C3A90", VA = "0x1807C5490")]
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

		// Token: 0x0600366B RID: 13931 RVA: 0x00122984 File Offset: 0x00120B84
		[Token(Token = "0x600366B")]
		[Address(RVA = "0x7C3C70", Offset = "0x7C2270", VA = "0x1807C3C70")]
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

		// Token: 0x0600366C RID: 13932 RVA: 0x00122A24 File Offset: 0x00120C24
		[Token(Token = "0x600366C")]
		[Address(RVA = "0x7C2690", Offset = "0x7C0C90", VA = "0x1807C2690")]
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

		// Token: 0x0600366D RID: 13933 RVA: 0x00122A80 File Offset: 0x00120C80
		[Token(Token = "0x600366D")]
		[Address(RVA = "0x7C2510", Offset = "0x7C0B10", VA = "0x1807C2510")]
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

		// Token: 0x0600366E RID: 13934 RVA: 0x00122AE0 File Offset: 0x00120CE0
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x7C2CF0", Offset = "0x7C12F0", VA = "0x1807C2CF0")]
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

		// Token: 0x0600366F RID: 13935 RVA: 0x00122B4C File Offset: 0x00120D4C
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x7C2B30", Offset = "0x7C1130", VA = "0x1807C2B30")]
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

		// Token: 0x06003670 RID: 13936 RVA: 0x00122BDC File Offset: 0x00120DDC
		[Token(Token = "0x6003670")]
		[Address(RVA = "0x7C52B0", Offset = "0x7C38B0", VA = "0x1807C52B0")]
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

		// Token: 0x06003671 RID: 13937 RVA: 0x00122C34 File Offset: 0x00120E34
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x7C5120", Offset = "0x7C3720", VA = "0x1807C5120")]
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

		// Token: 0x06003672 RID: 13938 RVA: 0x00122CB0 File Offset: 0x00120EB0
		[Token(Token = "0x6003672")]
		[Address(RVA = "0x7C45E0", Offset = "0x7C2BE0", VA = "0x1807C45E0")]
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

		// Token: 0x06003673 RID: 13939 RVA: 0x00122D90 File Offset: 0x00120F90
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x7C4B90", Offset = "0x7C3190", VA = "0x1807C4B90")]
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

		// Token: 0x06003674 RID: 13940 RVA: 0x00122EF0 File Offset: 0x001210F0
		[Token(Token = "0x6003674")]
		[Address(RVA = "0x7C29A0", Offset = "0x7C0FA0", VA = "0x1807C29A0")]
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

		// Token: 0x06003675 RID: 13941 RVA: 0x00122F5C File Offset: 0x0012115C
		[Token(Token = "0x6003675")]
		[Address(RVA = "0x7C4120", Offset = "0x7C2720", VA = "0x1807C4120")]
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

		// Token: 0x06003676 RID: 13942 RVA: 0x00122FAC File Offset: 0x001211AC
		[Token(Token = "0x6003676")]
		[Address(RVA = "0x7C3A80", Offset = "0x7C2080", VA = "0x1807C3A80")]
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

		// Token: 0x06003677 RID: 13943 RVA: 0x00122FEC File Offset: 0x001211EC
		[Token(Token = "0x6003677")]
		[Address(RVA = "0x7C3460", Offset = "0x7C1A60", VA = "0x1807C3460")]
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

		// Token: 0x06003678 RID: 13944 RVA: 0x00123134 File Offset: 0x00121334
		[Token(Token = "0x6003678")]
		[Address(RVA = "0x7C3840", Offset = "0x7C1E40", VA = "0x1807C3840")]
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

		// Token: 0x06003679 RID: 13945 RVA: 0x00123210 File Offset: 0x00121410
		[Token(Token = "0x6003679")]
		[Address(RVA = "0x7C3B00", Offset = "0x7C2100", VA = "0x1807C3B00")]
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

		// Token: 0x0600367A RID: 13946 RVA: 0x00123250 File Offset: 0x00121450
		[Token(Token = "0x600367A")]
		[Address(RVA = "0x7C3EA0", Offset = "0x7C24A0", VA = "0x1807C3EA0")]
		private bool IsPointOnCircle(Vector2 point, Vector3 circleCenter, float radius)
		{
			return false;
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x00123260 File Offset: 0x00121460
		[Token(Token = "0x600367B")]
		[Address(RVA = "0x7C4250", Offset = "0x7C2850", VA = "0x1807C4250")]
		private float SnapToBeat(float time)
		{
			int num = 0;
			if (time == (float)num)
			{
				return 0f;
			}
			return 0f;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x00123280 File Offset: 0x00121480
		[Token(Token = "0x600367C")]
		[Address(RVA = "0x7C32A0", Offset = "0x7C18A0", VA = "0x1807C32A0")]
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

		// Token: 0x0600367D RID: 13949 RVA: 0x0012330C File Offset: 0x0012150C
		[Token(Token = "0x600367D")]
		[Address(RVA = "0x7C30C0", Offset = "0x7C16C0", VA = "0x1807C30C0")]
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

		// Token: 0x0600367E RID: 13950 RVA: 0x001233C8 File Offset: 0x001215C8
		[Token(Token = "0x600367E")]
		[Address(RVA = "0x7C2F20", Offset = "0x7C1520", VA = "0x1807C2F20")]
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

		// Token: 0x0600367F RID: 13951 RVA: 0x00123450 File Offset: 0x00121650
		[Token(Token = "0x600367F")]
		[Address(RVA = "0x7C2500", Offset = "0x7C0B00", VA = "0x1807C2500")]
		public void ClearSelection()
		{
			this.selectedNoteIndex = (int)((ulong)4294967295L);
		}

		// Token: 0x06003680 RID: 13952 RVA: 0x00123470 File Offset: 0x00121670
		[Token(Token = "0x6003680")]
		[Address(RVA = "0x7C3EF0", Offset = "0x7C24F0", VA = "0x1807C3EF0")]
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

		// Token: 0x06003681 RID: 13953 RVA: 0x001234B8 File Offset: 0x001216B8
		[Token(Token = "0x6003681")]
		[Address(RVA = "0x7C5360", Offset = "0x7C3960", VA = "0x1807C5360")]
		public TimelineRendererLineRenderer()
		{
			List<NoteObject> list = new List();
			this.noteObjects = list;
			this.lastNotesCount = (int)((ulong)4294967295L);
			HashSet<GameObject> hashSet = new HashSet();
			this.activeBeatLines = hashSet;
			base..ctor();
		}

		// Token: 0x040029C6 RID: 10694
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029C6")]
		[Header("UI引用")]
		public RectTransform timelineContainer;

		// Token: 0x040029C7 RID: 10695
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029C7")]
		[Header("渲染设置")]
		public float timelineWidth = 1400f;

		// Token: 0x040029C8 RID: 10696
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40029C8")]
		public float timelineHeight = 160f;

		// Token: 0x040029C9 RID: 10697
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40029C9")]
		[Range(0.1f, 10f)]
		public float timelineZoom = 1f;

		// Token: 0x040029CA RID: 10698
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Token(Token = "0x40029CA")]
		[Range(0f, 1f)]
		public float timelineScroll;

		// Token: 0x040029CB RID: 10699
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40029CB")]
		public float bpm;

		// Token: 0x040029CC RID: 10700
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x40029CC")]
		[Header("颜色设置")]
		public Color backgroundColor;

		// Token: 0x040029CD RID: 10701
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40029CD")]
		public Color noteColor;

		// Token: 0x040029CE RID: 10702
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x40029CE")]
		public Color selectedNoteColor;

		// Token: 0x040029CF RID: 10703
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x40029CF")]
		public Color playheadColor;

		// Token: 0x040029D0 RID: 10704
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x40029D0")]
		public Color gridColor;

		// Token: 0x040029D1 RID: 10705
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40029D1")]
		[Header("调试设置")]
		public bool debugMode;

		// Token: 0x040029D2 RID: 10706
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40029D2")]
		public int selectedNoteIndex = (int)((ulong)4294967295L);

		// Token: 0x040029D4 RID: 10708
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40029D4")]
		private List<NoteObject> noteObjects;

		// Token: 0x040029D5 RID: 10709
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x40029D5")]
		private int lastNotesCount;

		// Token: 0x040029D6 RID: 10710
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x40029D6")]
		private ObjectPool<GameObject> beatLinePool;

		// Token: 0x040029D7 RID: 10711
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x40029D7")]
		private HashSet<GameObject> activeBeatLines;

		// Token: 0x040029D8 RID: 10712
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x40029D8")]
		private GameObject playheadLine;

		// Token: 0x040029D9 RID: 10713
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x40029D9")]
		private AudioSource audioSource;

		// Token: 0x040029DA RID: 10714
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Token(Token = "0x40029DA")]
		private Camera uiCamera;

		// Token: 0x040029DB RID: 10715
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x40029DB")]
		private bool isDraggingTimeline;

		// Token: 0x040029DC RID: 10716
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x40029DC")]
		public Action<int> OnNoteSelected;

		// Token: 0x040029DD RID: 10717
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x40029DD")]
		public Action<float> OnPositionClicked;

		// Token: 0x040029DE RID: 10718
		[global::Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x40029DE")]
		public Action<NoteData> OnNoteDragged;
	}
}
