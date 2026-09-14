using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200082D RID: 2093
[Token(Token = "0x200082D")]
public class PlantDamageMenu : BaseMenu
{
	// Token: 0x06002AC5 RID: 10949 RVA: 0x000E7FD0 File Offset: 0x000E61D0
	[Token(Token = "0x6002AC5")]
	[Address(RVA = "0x6A5710", Offset = "0x6A3D10", VA = "0x1806A5710", Slot = "6")]
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

	// Token: 0x06002AC6 RID: 10950 RVA: 0x000E801C File Offset: 0x000E621C
	[Token(Token = "0x6002AC6")]
	[Address(RVA = "0x6A60C0", Offset = "0x6A46C0", VA = "0x1806A60C0")]
	private void Start()
	{
		if (this.damageReporter != (ulong)0L)
		{
			this.InitCards();
			return;
		}
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x000E803C File Offset: 0x000E623C
	[Token(Token = "0x6002AC7")]
	[Address(RVA = "0x6A57D0", Offset = "0x6A3DD0", VA = "0x1806A57D0")]
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

	// Token: 0x06002AC8 RID: 10952 RVA: 0x000E8238 File Offset: 0x000E6438
	[Token(Token = "0x6002AC8")]
	[Address(RVA = "0x667800", Offset = "0x665E00", VA = "0x180667800")]
	public PlantDamageMenu()
	{
	}

	// Token: 0x040018CA RID: 6346
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018CA")]
	public RectTransform cardContent;

	// Token: 0x040018CB RID: 6347
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018CB")]
	public GameObject cardPrefab;

	// Token: 0x040018CC RID: 6348
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40018CC")]
	public Transform cardParent;

	// Token: 0x040018CD RID: 6349
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40018CD")]
	private Board board;

	// Token: 0x040018CE RID: 6350
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40018CE")]
	public DamageReporter damageReporter;
}
