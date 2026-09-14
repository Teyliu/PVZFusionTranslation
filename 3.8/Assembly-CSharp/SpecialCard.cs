using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public class SpecialCard : CardUI
{
	// Token: 0x06000890 RID: 2192 RVA: 0x0002C690 File Offset: 0x0002A890
	[Token(Token = "0x6000890")]
	[Address(RVA = "0x86E740", Offset = "0x86CD40", VA = "0x18086E740", Slot = "4")]
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

	// Token: 0x06000891 RID: 2193 RVA: 0x0002C6DC File Offset: 0x0002A8DC
	[Token(Token = "0x6000891")]
	[Address(RVA = "0x86F140", Offset = "0x86D740", VA = "0x18086F140", Slot = "5")]
	protected override void Start()
	{
		Slider component = base.transform.GetChild(2).gameObject.GetComponent<Slider>();
		this.slider = component;
		throw new NullReferenceException();
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002C70C File Offset: 0x0002A90C
	[Token(Token = "0x6000892")]
	[Address(RVA = "0x86E800", Offset = "0x86CE00", VA = "0x18086E800", Slot = "7")]
	protected override void CDUpdate()
	{
		base.CDUpdate();
		if (!this.cool)
		{
			float fullCD = this.fullCD;
			this.CD = fullCD;
		}
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002C738 File Offset: 0x0002A938
	[Token(Token = "0x6000893")]
	[Address(RVA = "0x86E830", Offset = "0x86CE30", VA = "0x18086E830", Slot = "10")]
	public virtual void ClickedEvent()
	{
		int num = 0;
		Board instance = Board.Instance;
		int theSeedCost = this.theSeedCost;
		if ((this.cool ? 1 : 0) != num)
		{
			float fullCD = this.fullCD;
		}
		bool flag = LevelManager.TryGetLevelData(num);
		if (!flag || !flag)
		{
			FunctionCardType functionCardType = this.theCardType;
			if (num != 0 && num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							if (functionCardType != FunctionCardType.InfoCard)
							{
								goto IL_0109;
							}
							if (this.onClicked != 0)
							{
							}
							if (this.onClickedThis == 0)
							{
								return;
							}
						}
						Board instance2 = Board.Instance;
						PlayerShootingManager.Instance.player.Upgrade();
						uint num2;
						GameAPP.PlaySound((int)num2, 0.5f, 1f);
						this.theSeedCost = (int)((ulong)9999999L);
					}
					Board.Instance.UseSun(0.5f);
					PlayerShootingManager instance3 = PlayerShootingManager.Instance;
					int num3 = 0;
					PlayerShootingMenu playerShootingMenu = instance3.ShowBuff(num3 != 0);
					float num4 = this.d;
				}
				Board.Instance.UseSun(0.5f);
				ChessManager instance4 = ChessManager.Instance;
				ChessManager.Instance.UpdateText();
				uint num5;
				GameAPP.PlaySound((int)num5, 0.5f, 1f);
				return;
			}
			IL_0109:
			uint num6;
			List<PlantType> list = DrawCardManager.Instance.Pull((int)num6);
			CardUI cardAtIndex = InGameUI.Instance._cardSlotManager.GetCardAtIndex(2);
			int num7 = 0;
			if (cardAtIndex != num7)
			{
				global::UnityEngine.Object.Destroy(cardAtIndex.gameObject);
				ulong num8;
				bool flag2 = InGameUI.Instance._cardSlotManager.RemoveCard(cardAtIndex, num8 != 0UL);
			}
			int num9 = list[num];
			CardUI cardUI;
			cardUI.useLimited = true;
			cardUI.theSeedCost = num;
			cardUI.fullCD = (float)num;
			int num10 = list[num];
			bool flag3;
			if (!flag3)
			{
				int num11 = list[num];
				bool flag4;
				if (!flag4)
				{
					int num12 = list[num];
					bool flag5;
					if (!flag5 && list[num] != 245)
					{
						int num13 = list[num];
						bool flag6;
						if (flag6)
						{
							goto IL_01CF;
						}
					}
				}
			}
			uint num14;
			cardUI.SetImage((int)num14);
			IL_01CF:
			ulong num15;
			bool flag7 = InGameUI.Instance.AddCardToBank(cardUI, num15 != 0UL);
			Transform transform = cardUI.transform;
			Vector3 vector;
			float z = vector.z;
			num++;
			uint num16;
			GameAPP.PlaySound((int)num16, 0.5f, 1f);
			Board.Instance.UseSun(0.5f);
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002C960 File Offset: 0x0002AB60
	[Token(Token = "0x6000894")]
	[Address(RVA = "0x86EF40", Offset = "0x86D540", VA = "0x18086EF40")]
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

	// Token: 0x06000895 RID: 2197 RVA: 0x0002C9A8 File Offset: 0x0002ABA8
	[Token(Token = "0x6000895")]
	[Address(RVA = "0x8516E0", Offset = "0x84FCE0", VA = "0x1808516E0")]
	public SpecialCard()
	{
	}

	// Token: 0x04000419 RID: 1049
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000419")]
	public FunctionCardType theCardType;

	// Token: 0x0400041A RID: 1050
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400041A")]
	public Action onClicked;

	// Token: 0x0400041B RID: 1051
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x400041B")]
	public Action<SpecialCard> onClickedThis;

	// Token: 0x0400041C RID: 1052
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400041C")]
	public float d = 1f;

	// Token: 0x0400041D RID: 1053
	[FieldOffset(Offset = "0xE4")]
	[Token(Token = "0x400041D")]
	public bool cool;
}
