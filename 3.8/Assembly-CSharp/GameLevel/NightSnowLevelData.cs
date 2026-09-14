using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF0 RID: 2800
	[Token(Token = "0x2000AF0")]
	public abstract class NightSnowLevelData : LevelData
	{
		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06003A3E RID: 14910 RVA: 0x001335C0 File Offset: 0x001317C0
		[Token(Token = "0x1700040E")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003A3E")]
			[Address(RVA = "0x3AAD70", Offset = "0x3A9370", VA = "0x1803AAD70", Slot = "14")]
			get
			{
				return LevelType.NewAdvanture;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x001335D0 File Offset: 0x001317D0
		[Token(Token = "0x1700040F")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A3F")]
			[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "12")]
			get
			{
				return SceneType.NightSnow;
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x001335E0 File Offset: 0x001317E0
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x78B790", Offset = "0x789D90", VA = "0x18078B790", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x0013360C File Offset: 0x0013180C
		[Token(Token = "0x6003A41")]
		[Address(RVA = "0x78B850", Offset = "0x789E50", VA = "0x18078B850")]
		private void Update(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00133630 File Offset: 0x00131830
		[Token(Token = "0x6003A42")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		protected NightSnowLevelData()
		{
		}
	}
}
