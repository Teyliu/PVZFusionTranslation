using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A59 RID: 2649
	[Token(Token = "0x2000A59")]
	public class GardenBackground : MonoBehaviour
	{
		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06003690 RID: 13968 RVA: 0x0012388C File Offset: 0x00121A8C
		// (set) Token: 0x06003691 RID: 13969 RVA: 0x001238A0 File Offset: 0x00121AA0
		[Token(Token = "0x17000281")]
		public GardenSceneType CurrentSceneType
		{
			[Token(Token = "0x6003690")]
			[Address(RVA = "0x7B68A0", Offset = "0x7B4EA0", VA = "0x1807B68A0")]
			get;
			[Token(Token = "0x6003691")]
			[Address(RVA = "0x7B6980", Offset = "0x7B4F80", VA = "0x1807B6980")]
			private set;
		} = (GardenSceneType)((ulong)1L);

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x001238B4 File Offset: 0x00121AB4
		// (set) Token: 0x06003693 RID: 13971 RVA: 0x001238C8 File Offset: 0x00121AC8
		[Token(Token = "0x17000282")]
		public SpriteRenderer CurrentSceneRenderer
		{
			[Token(Token = "0x6003692")]
			[Address(RVA = "0x7B6890", Offset = "0x7B4E90", VA = "0x1807B6890")]
			get;
			[Token(Token = "0x6003693")]
			[Address(RVA = "0x7B6970", Offset = "0x7B4F70", VA = "0x1807B6970")]
			private set;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06003694 RID: 13972 RVA: 0x001238DC File Offset: 0x00121ADC
		// (remove) Token: 0x06003695 RID: 13973 RVA: 0x0012390C File Offset: 0x00121B0C
		[Token(Token = "0x14000001")]
		public event Action<GardenSceneType> OnSceneChanged
		{
			[Token(Token = "0x6003694")]
			[Address(RVA = "0x7B67E0", Offset = "0x7B4DE0", VA = "0x1807B67E0")]
			[CompilerGenerated]
			add
			{
				Action<GardenSceneType> onSceneChanged = this.OnSceneChanged;
				Delegate @delegate = Delegate.Combine(onSceneChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x6003695")]
			[Address(RVA = "0x7B68C0", Offset = "0x7B4EC0", VA = "0x1807B68C0")]
			[CompilerGenerated]
			remove
			{
				Action<GardenSceneType> onSceneChanged = this.OnSceneChanged;
				Delegate @delegate = Delegate.Remove(onSceneChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSceneChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x0012393C File Offset: 0x00121B3C
		// (set) Token: 0x06003697 RID: 13975 RVA: 0x00123950 File Offset: 0x00121B50
		[Token(Token = "0x17000283")]
		public bool IsSwitching
		{
			[Token(Token = "0x6003696")]
			[Address(RVA = "0x7B68B0", Offset = "0x7B4EB0", VA = "0x1807B68B0")]
			get;
			[Token(Token = "0x6003697")]
			[Address(RVA = "0x7B6990", Offset = "0x7B4F90", VA = "0x1807B6990")]
			private set;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00123964 File Offset: 0x00121B64
		[Token(Token = "0x6003698")]
		[Address(RVA = "0x7B59E0", Offset = "0x7B3FE0", VA = "0x1807B59E0")]
		private void Awake()
		{
			SpriteRenderer spriteRenderer = this.main;
			int num = 0;
			if (spriteRenderer != num)
			{
				SpriteRenderer spriteRenderer2 = this.main;
				this.SwitchSceneImmediate(spriteRenderer2);
				SpriteRenderer spriteRenderer3 = this.main;
				this.<CurrentSceneRenderer>k__BackingField = spriteRenderer3;
				this.<CurrentSceneType>k__BackingField = (GardenSceneType)((ulong)1L);
			}
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x001239AC File Offset: 0x00121BAC
		[Token(Token = "0x6003699")]
		[Address(RVA = "0x7B59E0", Offset = "0x7B3FE0", VA = "0x1807B59E0")]
		private void InitializeCurrentScene()
		{
			SpriteRenderer spriteRenderer = this.main;
			int num = 0;
			if (spriteRenderer != num)
			{
				SpriteRenderer spriteRenderer2 = this.main;
				this.SwitchSceneImmediate(spriteRenderer2);
				SpriteRenderer spriteRenderer3 = this.main;
				this.<CurrentSceneRenderer>k__BackingField = spriteRenderer3;
				this.<CurrentSceneType>k__BackingField = (GardenSceneType)((ulong)1L);
			}
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x001239F4 File Offset: 0x00121BF4
		[Token(Token = "0x600369A")]
		[Address(RVA = "0x7B6290", Offset = "0x7B4890", VA = "0x1807B6290")]
		public UniTask SwitchToNextSceneAsync(float duration = -1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00123A14 File Offset: 0x00121C14
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x7B5A70", Offset = "0x7B4070", VA = "0x1807B5A70")]
		private GardenSceneType GetNextSceneType(GardenSceneType currentType)
		{
			return GardenSceneType.None;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00123A2C File Offset: 0x00121C2C
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x7B6490", Offset = "0x7B4A90", VA = "0x1807B6490")]
		public UniTask SwitchToSceneAsync(GardenSceneType sceneType, float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00123A4C File Offset: 0x00121C4C
		[Token(Token = "0x600369D")]
		[Address(RVA = "0x7B66E0", Offset = "0x7B4CE0", VA = "0x1807B66E0")]
		private void UpdateCurrentScene(SpriteRenderer sceneRenderer, GardenSceneType sceneType)
		{
			this.<CurrentSceneRenderer>k__BackingField = sceneRenderer;
			Action<GardenSceneType> onSceneChanged = this.OnSceneChanged;
			this.<CurrentSceneType>k__BackingField = sceneType;
			if (onSceneChanged != 0)
			{
			}
			Debug.Log(string.Format("场景已切换到：{0}", "场景已切换到：{0}"));
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00123A8C File Offset: 0x00121C8C
		[Token(Token = "0x600369E")]
		[Address(RVA = "0x7B5A90", Offset = "0x7B4090", VA = "0x1807B5A90")]
		private SpriteRenderer GetSceneByType(GardenSceneType sceneType)
		{
			if (sceneType != GardenSceneType.Main)
			{
			}
			return this.morning;
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00123AB8 File Offset: 0x00121CB8
		[Token(Token = "0x600369F")]
		[Address(RVA = "0x7B65B0", Offset = "0x7B4BB0", VA = "0x1807B65B0")]
		public UniTask TransitionSceneAsync(SpriteRenderer fromScene, SpriteRenderer toScene, float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x00123AD8 File Offset: 0x00121CD8
		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x7B6190", Offset = "0x7B4790", VA = "0x1807B6190")]
		public UniTask SwitchToMorningAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00123AF8 File Offset: 0x00121CF8
		[Token(Token = "0x60036A1")]
		[Address(RVA = "0x7B6390", Offset = "0x7B4990", VA = "0x1807B6390")]
		public UniTask SwitchToNightAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00123B18 File Offset: 0x00121D18
		[Token(Token = "0x60036A2")]
		[Address(RVA = "0x7B6090", Offset = "0x7B4690", VA = "0x1807B6090")]
		public UniTask SwitchToMainAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00123B38 File Offset: 0x00121D38
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x7B5D80", Offset = "0x7B4380", VA = "0x1807B5D80")]
		public void SwitchSceneImmediate(SpriteRenderer targetScene)
		{
			int num = 0;
			if (!(targetScene == num))
			{
				SpriteRenderer spriteRenderer = this.main;
				int num2 = 0;
				if (spriteRenderer != num2)
				{
					GameObject gameObject = this.main.gameObject;
					int num3 = 0;
					gameObject.SetActive(num3 != 0);
				}
				SpriteRenderer spriteRenderer2 = this.morning;
				int num4 = 0;
				if (spriteRenderer2 != num4)
				{
					GameObject gameObject2 = this.morning.gameObject;
					int num5 = 0;
					gameObject2.SetActive(num5 != 0);
				}
				SpriteRenderer spriteRenderer3 = this.night;
				int num6 = 0;
				if (spriteRenderer3 != num6)
				{
					GameObject gameObject3 = this.night.gameObject;
					int num7 = 0;
					gameObject3.SetActive(num7 != 0);
				}
				targetScene.gameObject.SetActive(true);
				Color color;
				float g = color.g;
				Color color2;
				float b = color2.b;
				SpriteRenderer spriteRenderer4 = this.main;
				if (!(targetScene == spriteRenderer4))
				{
					SpriteRenderer spriteRenderer5 = this.night;
					if (!(targetScene == spriteRenderer5))
					{
						SpriteRenderer spriteRenderer6 = this.morning;
						if (!(targetScene == spriteRenderer6))
						{
							return;
						}
					}
				}
				this.UpdateCurrentScene(targetScene, (GardenSceneType)((uint)1));
				return;
			}
			Debug.LogError("切换场景失败：目标场景为null");
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00123C50 File Offset: 0x00121E50
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x7B5B50", Offset = "0x7B4150", VA = "0x1807B5B50")]
		private GardenSceneType GetSceneTypeByRenderer(SpriteRenderer renderer)
		{
			SpriteRenderer spriteRenderer = this.main;
			if (!(renderer == spriteRenderer))
			{
				SpriteRenderer spriteRenderer2 = this.night;
				if (!(renderer == spriteRenderer2))
				{
					SpriteRenderer spriteRenderer3 = this.morning;
					bool flag = renderer == spriteRenderer3;
				}
				return GardenSceneType.Night;
			}
			return GardenSceneType.Main;
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00123C9C File Offset: 0x00121E9C
		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x7B58C0", Offset = "0x7B3EC0", VA = "0x1807B58C0")]
		public UniTask AutoSwitchSceneAsync(float transitionDuration = 2f, float sceneStayDuration = 10f, bool loop = true, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00123CBC File Offset: 0x00121EBC
		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x7B5C40", Offset = "0x7B4240", VA = "0x1807B5C40")]
		public void HideAllScenes()
		{
			SpriteRenderer spriteRenderer = this.main;
			int num = 0;
			if (spriteRenderer != num)
			{
				GameObject gameObject = this.main.gameObject;
				int num2 = 0;
				gameObject.SetActive(num2 != 0);
			}
			SpriteRenderer spriteRenderer2 = this.morning;
			int num3 = 0;
			if (spriteRenderer2 != num3)
			{
				GameObject gameObject2 = this.morning.gameObject;
				int num4 = 0;
				gameObject2.SetActive(num4 != 0);
			}
			SpriteRenderer spriteRenderer3 = this.night;
			int num5 = 0;
			if (spriteRenderer3 != num5)
			{
				GameObject gameObject3 = this.night.gameObject;
				int num6 = 0;
				gameObject3.SetActive(num6 != 0);
			}
			this.<CurrentSceneRenderer>k__BackingField = (ulong)0L;
			throw new NullReferenceException();
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00123D60 File Offset: 0x00121F60
		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x7B5AC0", Offset = "0x7B40C0", VA = "0x1807B5AC0")]
		public string GetSceneName(GardenSceneType sceneType)
		{
			int num = sceneType - GardenSceneType.Main;
			if (num == 0)
			{
				return "主场景";
			}
			if (num == 0)
			{
				return "夜晚场景";
			}
			if (num != 1)
			{
				return "未知场景";
			}
			return "早晨场景";
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00123D94 File Offset: 0x00121F94
		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x7B67C0", Offset = "0x7B4DC0", VA = "0x1807B67C0")]
		public GardenBackground()
		{
		}

		// Token: 0x040029F5 RID: 10741
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029F5")]
		public SpriteRenderer main;

		// Token: 0x040029F6 RID: 10742
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029F6")]
		public SpriteRenderer morning;

		// Token: 0x040029F7 RID: 10743
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40029F7")]
		public SpriteRenderer night;

		// Token: 0x040029FB RID: 10747
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40029FB")]
		[SerializeField]
		private float defaultTransitionDuration = 1f;
	}
}
