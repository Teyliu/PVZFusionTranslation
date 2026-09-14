using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007F2 RID: 2034
[Token(Token = "0x20007F2")]
public class PlantDamageMenu : BaseMenu
{
	// Token: 0x0600298F RID: 10639 RVA: 0x000E2E58 File Offset: 0x000E1058
	[Token(Token = "0x600298F")]
	[Address(RVA = "0x641060", Offset = "0x63F660", VA = "0x180641060", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		Board instance = Board.Instance;
		this.board = instance;
		Board board = this.board;
		int num = 0;
		if (board != num)
		{
			DamageReporter damageReporter = this.board.damageReporter;
			this.damageReporter = damageReporter;
		}
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x000E2EA4 File Offset: 0x000E10A4
	[Token(Token = "0x6002990")]
	[Address(RVA = "0x641A10", Offset = "0x640010", VA = "0x180641A10")]
	private void Start()
	{
		if (this.damageReporter != (ulong)0L)
		{
			this.InitCards();
			return;
		}
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x000E2EC4 File Offset: 0x000E10C4
	[Token(Token = "0x6002991")]
	[Address(RVA = "0x641120", Offset = "0x63F720", VA = "0x180641120")]
	private void InitCards()
	{
		List<KeyValuePair<PlantType, long>> list;
		ulong num8;
		do
		{
			Dictionary<PlantType, long> reportDic = this.damageReporter.ReportDic;
			Func<KeyValuePair<PlantType, long>, long> <>9__7_ = PlantDamageMenu.<>c.<>9__7_0;
			if (<>9__7_ == 0)
			{
				Func<KeyValuePair<PlantType, long>, long> func;
				PlantDamageMenu.<>c.<>9__7_0 = func;
			}
			list = Enumerable.ToList<KeyValuePair<PlantType, long>>(Enumerable.OrderByDescending<KeyValuePair<PlantType, long>, long>(reportDic, <>9__7_));
			bool flag;
			if (flag)
			{
				GameObject gameObject = this.cardPrefab;
				Transform transform = this.cardParent;
				CardWithDamage component = global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<CardWithDamage>();
				int num;
				if (num == 0)
				{
					component.totalDamage.text = "";
					bool flag2;
					Match match;
					if (flag2)
					{
						string text;
						match = Regex.Match(text, "Synergy_(.*)");
						if (match.Success)
						{
							TextMeshProUGUI totalDamage = component.totalDamage;
							string text2 = totalDamage.text;
							uint num2;
							string value = match.Groups[(int)num2].Value;
							string text3 = text2 + value + "\n";
							totalDamage.text = text3;
						}
					}
					TextMeshProUGUI totalDamage2 = component.totalDamage;
					if (match < (ulong)100000000L)
					{
						if (match < (ulong)10000L)
						{
							string text4 = totalDamage2.text;
						}
						string text5 = totalDamage2.text;
					}
					string text6 = totalDamage2.text;
					float num3;
					string text7 = string.Format("总伤害：{0:F2}亿", num3);
					string text8 = text6 + text7;
					totalDamage2.text = text8;
				}
				float num4;
				string text9 = string.Format("总伤害：{0:F2}万", num4);
				float num5;
				string text10 = string.Format("总伤害：{0:F2}亿", num5);
				string text11 = string.Format("平均伤害：{0}", text10);
				float num6;
				string text12 = string.Format("平均伤害：{0:F2}万", num6);
				float num7;
				string text13 = string.Format("平均伤害：{0:F2}亿", num7);
				string text14 = string.Format("数量：{0}\n{1}\n{2}", text13, text10, text13);
			}
		}
		while (num8 != (ulong)0L);
		int size = list._size;
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x000E30C0 File Offset: 0x000E12C0
	[Token(Token = "0x6002992")]
	[Address(RVA = "0x603FF0", Offset = "0x6025F0", VA = "0x180603FF0")]
	public PlantDamageMenu()
	{
	}

	// Token: 0x040017DF RID: 6111
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017DF")]
	public RectTransform cardContent;

	// Token: 0x040017E0 RID: 6112
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017E0")]
	public GameObject cardPrefab;

	// Token: 0x040017E1 RID: 6113
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40017E1")]
	public Transform cardParent;

	// Token: 0x040017E2 RID: 6114
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40017E2")]
	private Board board;

	// Token: 0x040017E3 RID: 6115
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40017E3")]
	public DamageReporter damageReporter;
}
