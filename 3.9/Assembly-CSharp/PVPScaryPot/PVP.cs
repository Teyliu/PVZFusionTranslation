using System;
using Cpp2IlInjected;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace PVPScaryPot
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	public class PVP : ScaryPotLevel
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x0012B5C0 File Offset: 0x001297C0
		[Token(Token = "0x17000290")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60037CF")]
			[Address(RVA = "0x715870", Offset = "0x713E70", VA = "0x180715870", Slot = "12")]
			get
			{
				return SceneType.PVPScaryPot;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x0012B5D0 File Offset: 0x001297D0
		[Token(Token = "0x17000291")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60037D0")]
			[Address(RVA = "0x52C4B0", Offset = "0x52AAB0", VA = "0x18052C4B0", Slot = "42")]
			get
			{
				return ChallengeLevel.PVPScaryPot;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x0012B5E0 File Offset: 0x001297E0
		[Token(Token = "0x17000292")]
		public override string Name
		{
			[Token(Token = "0x60037D1")]
			[Address(RVA = "0x7D6B30", Offset = "0x7D5130", VA = "0x1807D6B30", Slot = "8")]
			get
			{
				return "PVP砸罐子";
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x0012B5F4 File Offset: 0x001297F4
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x7D6550", Offset = "0x7D4B50", VA = "0x1807D6550", Slot = "36")]
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

		// Token: 0x060037D3 RID: 14291 RVA: 0x0012B6F8 File Offset: 0x001298F8
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x7D63B0", Offset = "0x7D49B0", VA = "0x1807D63B0")]
		private void ChangeTitle()
		{
			PVPScareyPot instance = PVPScareyPot.Instance;
			PVPScareyPot.streamerMode = "{il2cpp field on {'constant9' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0x8}" == (ulong)0L;
			instance.player1.textMesh.text = "玩家A";
			instance.player2.textMesh.text = "挑战者";
			TextMeshPro textMesh = instance.player2.textMesh;
			throw new NullReferenceException();
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x0012B758 File Offset: 0x00129958
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x7D6510", Offset = "0x7D4B10", VA = "0x1807D6510", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			board.boardTag.disableInInterlude = true;
			board.boardTag.isScaryPot = true;
			board.boardTag.pvpScaryPot = true;
			board.boardTag.isSuperRandom = true;
			board.boardTag.enableTravelPlant = true;
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x0012B7A8 File Offset: 0x001299A8
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x7D6B20", Offset = "0x7D5120", VA = "0x1807D6B20")]
		public PVP()
		{
		}
	}
}
