using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007FF RID: 2047
[Token(Token = "0x20007FF")]
public class RogueStartMenu : BaseMenu
{
	// Token: 0x060029C8 RID: 10696 RVA: 0x000E4664 File Offset: 0x000E2864
	[Token(Token = "0x60029C8")]
	[Address(RVA = "0x646150", Offset = "0x644750", VA = "0x180646150")]
	public void EnterGame()
	{
		Board instance;
		int num4;
		do
		{
			RogueLeaderCard rogueLeaderCard = this.currentSelected;
			int num = 0;
			if (rogueLeaderCard == num)
			{
				goto IL_021F;
			}
			instance = Board.Instance;
			int size = instance.mowerArray._size;
			int num2 = size - 1;
			if (size > 0)
			{
				Mower mower = instance.mowerArray[num2];
				int num3 = 0;
				if (mower != num3)
				{
					mower.Die();
				}
			}
			RogueManager instance2 = RogueManager.Instance;
			LeaderType leaderType = this.currentSelected.leaderType;
			instance2.leaderType = leaderType;
			if (this.currentSelected > (ulong)8L)
			{
				goto IL_017E;
			}
			HashSet<CardUI> cards = InGameUI.Instance.cards;
			num4 = 0;
			bool flag;
			if (flag)
			{
			}
		}
		while (num4 != 0);
		CreatePlant instance3 = CreatePlant.Instance;
		Plant plant;
		plant.imitatless = true;
		CreatePlant instance4 = CreatePlant.Instance;
		Plant plant2;
		plant2.imitatless = true;
		RogueManager.Instance.campType = (CampType)((ulong)1L);
		RogueManager.Instance.campType = (CampType)((ulong)1L);
		TravelMgr instance5 = TravelMgr.Instance;
		RogueManager.Instance.campType = (CampType)((ulong)1L);
		TravelMgr instance6 = TravelMgr.Instance;
		instance.boardTag.isConvey = true;
		instance.boardTag.disableSelectCard = true;
		instance.cardBank = false;
		instance.boardTag.enableAllTravelPlant = true;
		instance.boardTag.isSuperRandom = true;
		RogueManager instance7 = RogueManager.Instance;
		int num5 = 0;
		instance7.campType = (CampType)num5;
		RogueManager.Instance.campType = (CampType)((ulong)1L);
		TravelMgr instance8 = TravelMgr.Instance;
		IL_017E:
		int num6 = 0;
		Vector3 vector;
		if (RogueManager.Instance.campType == CampType.Land)
		{
			if (num6 >= instance.rowNum)
			{
				goto IL_01FD;
			}
			CreateMower instance9 = CreateMower._instance;
			num6++;
			CreateMower instance10 = CreateMower._instance;
			Mower mower2;
			Transform transform = mower2.transform;
			float z = vector.z;
		}
		if (vector == (ulong)1L)
		{
			global::UnityEngine.Object.Destroy(instance.background);
			SceneType sceneType;
			instance.sceneType = sceneType;
			GameObject gameObject;
			instance.ChangeMap(gameObject);
			SceneType sceneType2 = instance.sceneType;
			MapData_cs.SceneSettings(instance, sceneType2);
		}
		IL_01FD:
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		CursorChange.SetDefaultCursor();
		return;
		IL_021F:
		uint num7;
		GameAPP.PlaySound((int)num7, 0.5f, 1f);
		InGameText instance11 = InGameText.Instance;
		int num8 = 0;
		instance11.ShowText("你还没有选择你的英雄", 3f, num8 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x060029C9 RID: 10697 RVA: 0x000E48D0 File Offset: 0x000E2AD0
	[Token(Token = "0x60029C9")]
	[Address(RVA = "0x646A20", Offset = "0x645020", VA = "0x180646A20")]
	public void SetLeader(RogueLeaderCard card)
	{
		RogueLeaderCard rogueLeaderCard = this.currentSelected;
		int num = 0;
		if (rogueLeaderCard != num)
		{
			if (this.currentSelected == card)
			{
				return;
			}
			RogueLeaderCard rogueLeaderCard2 = this.currentSelected;
		}
		this.currentSelected = card;
		RogueLeaderCard rogueLeaderCard3 = this.currentSelected;
		RogueLeaderCard rogueLeaderCard4 = this.currentSelected;
		int num2 = 0;
		if (rogueLeaderCard4 != num2)
		{
			RogueLeaderCard rogueLeaderCard5 = this.currentSelected;
			Dictionary<LeaderType, string> leaderDescriptionDic = RogueStartMenu.LeaderDescriptionDic;
			bool flag;
			if (flag)
			{
				TextMeshProUGUI textMeshProUGUI = this.leaderDescription;
			}
		}
	}

	// Token: 0x060029CA RID: 10698 RVA: 0x000E4950 File Offset: 0x000E2B50
	[Token(Token = "0x60029CA")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public RogueStartMenu()
	{
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x000E4964 File Offset: 0x000E2B64
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x60029CB")]
	[Address(RVA = "0x646BE0", Offset = "0x6451E0", VA = "0x180646BE0")]
	static RogueStartMenu()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04001808 RID: 6152
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001808")]
	public RogueLeaderCard currentSelected;

	// Token: 0x04001809 RID: 6153
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001809")]
	public TextMeshProUGUI leaderDescription;

	// Token: 0x0400180A RID: 6154
	[Token(Token = "0x400180A")]
	private static readonly Dictionary<LeaderType, string> LeaderDescriptionDic = new Dictionary();

	// Token: 0x0400180B RID: 6155
	[Token(Token = "0x400180B")]
	public static readonly Dictionary<LeaderType, string> LeaderNameDic = new Dictionary();
}
