using System;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace PVPScaryPot
{
	// Token: 0x02000A5E RID: 2654
	[Token(Token = "0x2000A5E")]
	public class PVP : ScaryPotLevel
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x00126390 File Offset: 0x00124590
		[Token(Token = "0x17000248")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600368B")]
			[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "12")]
			get
			{
				return SceneType.PVPScaryPot;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600368C RID: 13964 RVA: 0x001263A0 File Offset: 0x001245A0
		[Token(Token = "0x17000249")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x600368C")]
			[Address(RVA = "0x4CFB80", Offset = "0x4CE180", VA = "0x1804CFB80", Slot = "42")]
			get
			{
				return ChallengeLevel.PVPScaryPot;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x001263B0 File Offset: 0x001245B0
		[Token(Token = "0x1700024A")]
		public override string Name
		{
			[Token(Token = "0x600368D")]
			[Address(RVA = "0x76FCC0", Offset = "0x76E2C0", VA = "0x18076FCC0", Slot = "8")]
			get
			{
				return "PVP砸罐子";
			}
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x001263C4 File Offset: 0x001245C4
		[Token(Token = "0x600368E")]
		[Address(RVA = "0x76F6E0", Offset = "0x76DCE0", VA = "0x18076F6E0", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			int theMaxWave = board.theMaxWave;
			board.theWave = theMaxWave;
			ScaryPotManager.SetPVPPots();
			InGameUI instance = InGameUI.Instance;
			Action<UIButton> <>9__6_ = PVP.<>c.<>9__6_0;
			if (<>9__6_ == 0)
			{
				Action<UIButton> action;
				PVP.<>c.<>9__6_0 = action;
			}
			UIButton uibutton = instance.CreateLeftButton(" 随机卡槽（O）", <>9__6_);
			InGameUI instance2 = InGameUI.Instance;
			Action<UIButton> action2;
			if (PVP.<>c.<>9__6_1 == 0)
			{
				PVP.<>c.<>9__6_1 = action2;
			}
			UIButton uibutton2 = instance2.CreateLeftButton(" 右键放罐（I）", action2);
			InGameUI instance3 = InGameUI.Instance;
			Action<UIButton> action3;
			if (PVP.<>c.<>9__6_2 == 0)
			{
				PVP.<>c.<>9__6_2 = action3;
			}
			UIButton uibutton3 = instance3.CreateLeftButton(" 清除植物（U）", action3);
			InGameUI instance4 = InGameUI.Instance;
			Action<UIButton> action4;
			if (PVP.<>c.<>9__6_3 == 0)
			{
				PVP.<>c.<>9__6_3 = action4;
			}
			UIButton uibutton4 = instance4.CreateLeftButton(" 清除僵尸（Y）", action4);
			Action<UIButton> action5;
			UIButton uibutton5 = InGameUI.Instance.CreateLeftButton("切换标题", action5);
			PVPScareyPot pvpscareyPot = board.AddComponent<PVPScareyPot>();
			pvpscareyPot.player1.textMesh.text = "玩家A";
			Color color = pvpscareyPot.player2.textMesh.m_Color;
			throw new NullReferenceException();
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x001264C8 File Offset: 0x001246C8
		[Token(Token = "0x600368F")]
		[Address(RVA = "0x76F540", Offset = "0x76DB40", VA = "0x18076F540")]
		private void ChangeTitle()
		{
			PVPScareyPot instance = PVPScareyPot.Instance;
			PVPScareyPot.streamerMode = "{il2cpp field on {'constant9' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x8}" == (ulong)0L;
			instance.player1.textMesh.text = "玩家A";
			instance.player2.textMesh.text = "主播";
			TextMeshPro textMesh = instance.player2.textMesh;
			throw new NullReferenceException();
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x00126528 File Offset: 0x00124728
		[Token(Token = "0x6003690")]
		[Address(RVA = "0x76F6A0", Offset = "0x76DCA0", VA = "0x18076F6A0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			board.boardTag.disableInInterlude = true;
			board.boardTag.isScaryPot = true;
			board.boardTag.pvpScaryPot = true;
			board.boardTag.isSuperRandom = true;
			board.boardTag.enableTravelPlant = true;
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x00126578 File Offset: 0x00124778
		[Token(Token = "0x6003691")]
		[Address(RVA = "0x76FCB0", Offset = "0x76E2B0", VA = "0x18076FCB0")]
		public PVP()
		{
		}
	}
}
