using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200083A RID: 2106
[Token(Token = "0x200083A")]
public class RogueStartMenu : BaseMenu
{
	// Token: 0x06002AFE RID: 11006 RVA: 0x000E96F0 File Offset: 0x000E78F0
	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x6AA8E0", Offset = "0x6A8EE0", VA = "0x1806AA8E0")]
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
		throw new NullReferenceException();
	}

	// Token: 0x06002AFF RID: 11007 RVA: 0x000E9948 File Offset: 0x000E7B48
	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x6AB1C0", Offset = "0x6A97C0", VA = "0x1806AB1C0")]
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

	// Token: 0x06002B00 RID: 11008 RVA: 0x000E99C8 File Offset: 0x000E7BC8
	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public RogueStartMenu()
	{
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x000E99DC File Offset: 0x000E7BDC
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x6AB380", Offset = "0x6A9980", VA = "0x1806AB380")]
	static RogueStartMenu()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040018F3 RID: 6387
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018F3")]
	public RogueLeaderCard currentSelected;

	// Token: 0x040018F4 RID: 6388
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018F4")]
	public TextMeshProUGUI leaderDescription;

	// Token: 0x040018F5 RID: 6389
	[Token(Token = "0x40018F5")]
	private static readonly Dictionary<LeaderType, string> LeaderDescriptionDic = new Dictionary();

	// Token: 0x040018F6 RID: 6390
	[Token(Token = "0x40018F6")]
	public static readonly Dictionary<LeaderType, string> LeaderNameDic = new Dictionary();
}
