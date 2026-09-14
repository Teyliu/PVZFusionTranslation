using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel
{
	// Token: 0x02000AEE RID: 2798
	[Token(Token = "0x2000AEE")]
	public class TimeTrackLevel : ChallengeLevelData
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00133264 File Offset: 0x00131464
		[Token(Token = "0x17000409")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A31")]
			[Address(RVA = "0x4E6B70", Offset = "0x4E5170", VA = "0x1804E6B70", Slot = "42")]
			get
			{
				return ChallengeLevel.TimeTrack;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00133278 File Offset: 0x00131478
		[Token(Token = "0x1700040A")]
		public override string Name
		{
			[Token(Token = "0x6003A32")]
			[Address(RVA = "0x7943A0", Offset = "0x7929A0", VA = "0x1807943A0", Slot = "8")]
			get
			{
				return "时间陷阱";
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x0013328C File Offset: 0x0013148C
		[Token(Token = "0x1700040B")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06003A34 RID: 14900 RVA: 0x0013329C File Offset: 0x0013149C
		[Token(Token = "0x1700040C")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x69CF20", Offset = "0x69B520", VA = "0x18069CF20", Slot = "10")]
			get
			{
				return 40;
			}
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x001332AC File Offset: 0x001314AC
		[Token(Token = "0x6003A35")]
		[Address(RVA = "0x793E80", Offset = "0x792480", VA = "0x180793E80", Slot = "40")]
		public override void OnAnimUIOver(Board board)
		{
			base.OnAnimUIOver(board);
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("每当你击杀一只僵尸后，获得0.2秒时间\n每当你种下一株新植物后，获得1秒，如果这是第一次种下该植物，则获得10秒时间\n你需要在规定的时间内通关", 10f, num != 0);
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.plants.Clear();
			UnityEvent dieEvent = board.DieEvent;
			UnityAction unityAction = delegate
			{
				this.plants.Clear();
			};
			dieEvent.AddListener(unityAction);
			int num2 = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)2), action, num2 != 0);
			int num3 = 0;
			Action<object> action2;
			EventManager.AddListener_obj((GameEvent)((uint)8), action2, num3 != 0);
		}

		// Token: 0x06003A36 RID: 14902 RVA: 0x00133340 File Offset: 0x00131540
		[Token(Token = "0x6003A36")]
		[Address(RVA = "0x794250", Offset = "0x792850", VA = "0x180794250")]
		private void Update(Board board)
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x00133364 File Offset: 0x00131564
		[Token(Token = "0x1700040D")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A37")]
			[Address(RVA = "0x7943D0", Offset = "0x7929D0", VA = "0x1807943D0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				int size9 = list._size;
				int size10 = list._size;
				int size11 = list._size;
				int size12 = list._size;
				return list;
			}
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x001333F4 File Offset: 0x001315F4
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x794320", Offset = "0x792920", VA = "0x180794320")]
		public TimeTrackLevel()
		{
			HashSet<PlantType> hashSet = new HashSet();
			this.plants = hashSet;
			base..ctor();
		}

		// Token: 0x04002B53 RID: 11091
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4002B53")]
		private float restTimer;

		// Token: 0x04002B54 RID: 11092
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4002B54")]
		private readonly HashSet<PlantType> plants;
	}
}
