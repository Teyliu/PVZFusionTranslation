using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	public abstract class NightSnowLevelData : LevelData
	{
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x001385F4 File Offset: 0x001367F4
		[Token(Token = "0x17000456")]
		public override LevelType LevelType
		{
			[Token(Token = "0x6003B82")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "14")]
			get
			{
				return LevelType.NewAdvanture;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x00138604 File Offset: 0x00136804
		[Token(Token = "0x17000457")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B83")]
			[Address(RVA = "0x717080", Offset = "0x715680", VA = "0x180717080", Slot = "12")]
			get
			{
				return SceneType.NightSnow;
			}
		}

		// Token: 0x06003B84 RID: 15236 RVA: 0x00138614 File Offset: 0x00136814
		[Token(Token = "0x6003B84")]
		[Address(RVA = "0x7F1E10", Offset = "0x7F0410", VA = "0x1807F1E10", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00138640 File Offset: 0x00136840
		[Token(Token = "0x6003B85")]
		[Address(RVA = "0x7F1ED0", Offset = "0x7F04D0", VA = "0x1807F1ED0")]
		private void Update(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00138664 File Offset: 0x00136864
		[Token(Token = "0x6003B86")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		protected NightSnowLevelData()
		{
		}
	}
}
