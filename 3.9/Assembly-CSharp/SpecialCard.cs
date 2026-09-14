using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001FE RID: 510
[Token(Token = "0x20001FE")]
public class SpecialCard : CardUI
{
	// Token: 0x060008AA RID: 2218 RVA: 0x0002C66C File Offset: 0x0002A86C
	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x8FE240", Offset = "0x8FC840", VA = "0x1808FE240", Slot = "4")]
	protected override void Awake()
	{
		Board instance = Board.Instance;
		this.board = instance;
		int num = 0;
		this.d = 1f;
		this.CD = (float)num;
		TextMeshProUGUI component = base.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
		this.text = component;
		throw new NullReferenceException();
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x8FEDE0", Offset = "0x8FD3E0", VA = "0x1808FEDE0", Slot = "5")]
	protected override void Start()
	{
		Slider component = base.transform.GetChild(2).gameObject.GetComponent<Slider>();
		this.slider = component;
		throw new NullReferenceException();
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x8FE300", Offset = "0x8FC900", VA = "0x1808FE300", Slot = "7")]
	protected override void CDUpdate()
	{
		base.CDUpdate();
		if (!this.cool)
		{
			float fullCD = this.fullCD;
			this.CD = fullCD;
		}
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002C714 File Offset: 0x0002A914
	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x8FE330", Offset = "0x8FC930", VA = "0x1808FE330", Slot = "10")]
	public virtual void ClickedEvent()
	{
		List<PlantType> list;
		for (;;)
		{
			int num = 0;
			Board instance = Board.Instance;
			int theSeedCost = this.theSeedCost;
			if ((this.cool ? 1 : 0) != num)
			{
				float fullCD = this.fullCD;
			}
			bool flag = LevelManager.TryGetLevelData(num);
			if (flag && flag)
			{
				return;
			}
			FunctionCardType functionCardType = this.theCardType;
			if (num != 0 && num != 0)
			{
				if (num == 0)
				{
					goto IL_00D7;
				}
				if (num == 0)
				{
					goto IL_00AB;
				}
				if (num == 1)
				{
					goto IL_0077;
				}
				if (functionCardType == FunctionCardType.InfoCard)
				{
					break;
				}
			}
			uint num2;
			list = DrawCardManager.Instance.Pull((int)num2);
			IReadOnlyList<CardUI> readOnlyList = InGameUI.Instance._cardSlotManager.Cards;
			if (readOnlyList != 0)
			{
				if (num < typeof(IEnumerator).TypeHandle)
				{
					num += num;
					if (num != typeof(IEnumerator).TypeHandle)
					{
						num++;
					}
				}
				IL_0148:
				readOnlyList += readOnlyList;
				num += 312;
				GameObject gameObject;
				global::UnityEngine.Object.Destroy(gameObject);
				CardSlotManager cardSlotManager = InGameUI.Instance._cardSlotManager;
				goto IL_016A;
				goto IL_0148;
			}
			IL_016A:
			if ("{il2cpp array field local45->}" != (ulong)0L)
			{
			}
			if (num == 0)
			{
				goto Block_11;
			}
		}
		if (this.onClicked != 0)
		{
		}
		if (this.onClickedThis == 0)
		{
			return;
		}
		IL_0077:
		Board instance2 = Board.Instance;
		PlayerShootingManager.Instance.player.Upgrade();
		uint num3;
		GameAPP.PlaySound((int)num3, 0.5f, 1f);
		this.theSeedCost = (int)((ulong)9999999L);
		IL_00AB:
		Board.Instance.UseSun(0.5f);
		PlayerShootingManager instance3 = PlayerShootingManager.Instance;
		int num4 = 0;
		PlayerShootingMenu playerShootingMenu = instance3.ShowBuff(num4 != 0);
		float num5 = this.d;
		IL_00D7:
		Board.Instance.UseSun(0.5f);
		ChessManager instance4 = ChessManager.Instance;
		ChessManager.Instance.UpdateText();
		uint num6;
		GameAPP.PlaySound((int)num6, 0.5f, 1f);
		return;
		Block_11:
		int num7 = 0;
		int num8 = list[num7];
		CardUI cardUI;
		cardUI.useLimited = true;
		cardUI.theSeedCost = num7;
		cardUI.fullCD = (float)num7;
		int num9 = list[num7];
		bool flag2;
		if (!flag2)
		{
			int num10 = list[num7];
			bool flag3;
			if (!flag3)
			{
				int num11 = list[num7];
				bool flag4;
				if (!flag4 && list[num7] != 245)
				{
					int num12 = list[num7];
					bool flag5;
					if (flag5)
					{
						goto IL_01FC;
					}
				}
			}
		}
		uint num13;
		cardUI.SetImage((int)num13);
		IL_01FC:
		ulong num14;
		bool flag6 = InGameUI.Instance.AddCardToBank(cardUI, num14 != 0UL);
		Transform transform = cardUI.transform;
		Vector3 vector;
		float z = vector.z;
		num7++;
		uint num15;
		GameAPP.PlaySound((int)num15, 0.5f, 1f);
		Board.Instance.UseSun(0.5f);
		throw new NullReferenceException();
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002C98C File Offset: 0x0002AB8C
	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x8FEBE0", Offset = "0x8FD1E0", VA = "0x1808FEBE0")]
	public static SpecialCard GetCard(FunctionCardType functionCardType)
	{
		Dictionary<FunctionCardType, GameObject> specialCards = GameAPP.resourcesManager.specialCards;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		GameObject gameObject;
		SpecialCard component = gameObject.GetComponent<SpecialCard>();
		component.theCardType = functionCardType;
		return component;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0002C9D4 File Offset: 0x0002ABD4
	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x8DF910", Offset = "0x8DDF10", VA = "0x1808DF910")]
	public SpecialCard()
	{
	}

	// Token: 0x04000423 RID: 1059
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000423")]
	public FunctionCardType theCardType;

	// Token: 0x04000424 RID: 1060
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000424")]
	public Action onClicked;

	// Token: 0x04000425 RID: 1061
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000425")]
	public Action<SpecialCard> onClickedThis;

	// Token: 0x04000426 RID: 1062
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000426")]
	public float d = 1f;

	// Token: 0x04000427 RID: 1063
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x4000427")]
	public bool cool;
}
