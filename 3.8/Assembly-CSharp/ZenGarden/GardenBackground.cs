using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace ZenGarden
{
	// Token: 0x02000A1A RID: 2586
	[Token(Token = "0x2000A1A")]
	public class GardenBackground : MonoBehaviour
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x0011E770 File Offset: 0x0011C970
		// (set) Token: 0x06003550 RID: 13648 RVA: 0x0011E784 File Offset: 0x0011C984
		[Token(Token = "0x17000239")]
		public GardenSceneType CurrentSceneType
		{
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x74FEE0", Offset = "0x74E4E0", VA = "0x18074FEE0")]
			get;
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x74FFC0", Offset = "0x74E5C0", VA = "0x18074FFC0")]
			private set;
		} = (GardenSceneType)((ulong)1L);

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06003551 RID: 13649 RVA: 0x0011E798 File Offset: 0x0011C998
		// (set) Token: 0x06003552 RID: 13650 RVA: 0x0011E7AC File Offset: 0x0011C9AC
		[Token(Token = "0x1700023A")]
		public SpriteRenderer CurrentSceneRenderer
		{
			[Token(Token = "0x6003551")]
			[Address(RVA = "0x74FED0", Offset = "0x74E4D0", VA = "0x18074FED0")]
			get;
			[Token(Token = "0x6003552")]
			[Address(RVA = "0x74FFB0", Offset = "0x74E5B0", VA = "0x18074FFB0")]
			private set;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06003553 RID: 13651 RVA: 0x0011E7C0 File Offset: 0x0011C9C0
		// (remove) Token: 0x06003554 RID: 13652 RVA: 0x0011E7F0 File Offset: 0x0011C9F0
		[Token(Token = "0x14000001")]
		public event Action<GardenSceneType> OnSceneChanged
		{
			[Token(Token = "0x6003553")]
			[Address(RVA = "0x74FE20", Offset = "0x74E420", VA = "0x18074FE20")]
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
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x74FF00", Offset = "0x74E500", VA = "0x18074FF00")]
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x0011E820 File Offset: 0x0011CA20
		// (set) Token: 0x06003556 RID: 13654 RVA: 0x0011E834 File Offset: 0x0011CA34
		[Token(Token = "0x1700023B")]
		public bool IsSwitching
		{
			[Token(Token = "0x6003555")]
			[Address(RVA = "0x74FEF0", Offset = "0x74E4F0", VA = "0x18074FEF0")]
			get;
			[Token(Token = "0x6003556")]
			[Address(RVA = "0x74FFD0", Offset = "0x74E5D0", VA = "0x18074FFD0")]
			private set;
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0011E848 File Offset: 0x0011CA48
		[Token(Token = "0x6003557")]
		[Address(RVA = "0x74F020", Offset = "0x74D620", VA = "0x18074F020")]
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

		// Token: 0x06003558 RID: 13656 RVA: 0x0011E890 File Offset: 0x0011CA90
		[Token(Token = "0x6003558")]
		[Address(RVA = "0x74F020", Offset = "0x74D620", VA = "0x18074F020")]
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

		// Token: 0x06003559 RID: 13657 RVA: 0x0011E8D8 File Offset: 0x0011CAD8
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x74F8D0", Offset = "0x74DED0", VA = "0x18074F8D0")]
		public UniTask SwitchToNextSceneAsync(float duration = -1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0011E8F8 File Offset: 0x0011CAF8
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x74F0B0", Offset = "0x74D6B0", VA = "0x18074F0B0")]
		private GardenSceneType GetNextSceneType(GardenSceneType currentType)
		{
			return GardenSceneType.None;
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0011E910 File Offset: 0x0011CB10
		[Token(Token = "0x600355B")]
		[Address(RVA = "0x74FAD0", Offset = "0x74E0D0", VA = "0x18074FAD0")]
		public UniTask SwitchToSceneAsync(GardenSceneType sceneType, float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0011E930 File Offset: 0x0011CB30
		[Token(Token = "0x600355C")]
		[Address(RVA = "0x74FD20", Offset = "0x74E320", VA = "0x18074FD20")]
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

		// Token: 0x0600355D RID: 13661 RVA: 0x0011E970 File Offset: 0x0011CB70
		[Token(Token = "0x600355D")]
		[Address(RVA = "0x74F0D0", Offset = "0x74D6D0", VA = "0x18074F0D0")]
		private SpriteRenderer GetSceneByType(GardenSceneType sceneType)
		{
			if (sceneType != GardenSceneType.Main)
			{
			}
			return this.morning;
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0011E99C File Offset: 0x0011CB9C
		[Token(Token = "0x600355E")]
		[Address(RVA = "0x74FBF0", Offset = "0x74E1F0", VA = "0x18074FBF0")]
		public UniTask TransitionSceneAsync(SpriteRenderer fromScene, SpriteRenderer toScene, float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0011E9BC File Offset: 0x0011CBBC
		[Token(Token = "0x600355F")]
		[Address(RVA = "0x74F7D0", Offset = "0x74DDD0", VA = "0x18074F7D0")]
		public UniTask SwitchToMorningAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0011E9DC File Offset: 0x0011CBDC
		[Token(Token = "0x6003560")]
		[Address(RVA = "0x74F9D0", Offset = "0x74DFD0", VA = "0x18074F9D0")]
		public UniTask SwitchToNightAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0011E9FC File Offset: 0x0011CBFC
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x74F6D0", Offset = "0x74DCD0", VA = "0x18074F6D0")]
		public UniTask SwitchToMainAsync(float duration = 1f, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0011EA1C File Offset: 0x0011CC1C
		[Token(Token = "0x6003562")]
		[Address(RVA = "0x74F3C0", Offset = "0x74D9C0", VA = "0x18074F3C0")]
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

		// Token: 0x06003563 RID: 13667 RVA: 0x0011EB34 File Offset: 0x0011CD34
		[Token(Token = "0x6003563")]
		[Address(RVA = "0x74F190", Offset = "0x74D790", VA = "0x18074F190")]
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

		// Token: 0x06003564 RID: 13668 RVA: 0x0011EB80 File Offset: 0x0011CD80
		[Token(Token = "0x6003564")]
		[Address(RVA = "0x74EF00", Offset = "0x74D500", VA = "0x18074EF00")]
		public UniTask AutoSwitchSceneAsync(float transitionDuration = 2f, float sceneStayDuration = 10f, bool loop = true, [Optional] CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0011EBA0 File Offset: 0x0011CDA0
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x74F280", Offset = "0x74D880", VA = "0x18074F280")]
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

		// Token: 0x06003566 RID: 13670 RVA: 0x0011EC44 File Offset: 0x0011CE44
		[Token(Token = "0x6003566")]
		[Address(RVA = "0x74F100", Offset = "0x74D700", VA = "0x18074F100")]
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

		// Token: 0x06003567 RID: 13671 RVA: 0x0011EC78 File Offset: 0x0011CE78
		[Token(Token = "0x6003567")]
		[Address(RVA = "0x74FE00", Offset = "0x74E400", VA = "0x18074FE00")]
		public GardenBackground()
		{
		}

		// Token: 0x04002884 RID: 10372
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002884")]
		public SpriteRenderer main;

		// Token: 0x04002885 RID: 10373
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002885")]
		public SpriteRenderer morning;

		// Token: 0x04002886 RID: 10374
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002886")]
		public SpriteRenderer night;

		// Token: 0x0400288A RID: 10378
		[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400288A")]
		[SerializeField]
		private float defaultTransitionDuration = 1f;
	}
}
