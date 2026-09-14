using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008DD RID: 2269
[Token(Token = "0x20008DD")]
public class UIZombieNum : MonoBehaviour
{
	// Token: 0x06002E33 RID: 11827 RVA: 0x000FCBF4 File Offset: 0x000FADF4
	[Token(Token = "0x6002E33")]
	[Address(RVA = "0x70F4F0", Offset = "0x70DAF0", VA = "0x18070F4F0")]
	private void Awake()
	{
		UIZombieNum.Instance = this;
	}

	// Token: 0x06002E34 RID: 11828 RVA: 0x000FCC08 File Offset: 0x000FAE08
	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x70F550", Offset = "0x70DB50", VA = "0x18070F550")]
	private void Start()
	{
		TextMeshProUGUI component = base.GetComponent<TextMeshProUGUI>();
		this.t = component;
		Board instance = Board.Instance;
		this.board = instance;
	}

	// Token: 0x06002E35 RID: 11829 RVA: 0x000FCC30 File Offset: 0x000FAE30
	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x70F5D0", Offset = "0x70DBD0", VA = "0x18070F5D0")]
	private void Update()
	{
		if (this.textUpdate == (ulong)0L)
		{
			int enermyCount = this.board.enermyCount;
			TextMeshProUGUI textMeshProUGUI = this.t;
			string text = string.Format("场上敌人数量：{0}", "场上敌人数量：{0}\t\t\t\t\t\t植物限制：{1}/{2}");
			textMeshProUGUI.text = text;
			Board board = this.board;
			TextMeshProUGUI textMeshProUGUI2 = this.t;
			string text2 = textMeshProUGUI2.text;
			Board board2 = this.board;
			string text3 = string.Format("\n当前分数：{0}", text2);
			string text4 = text2 + text3;
			textMeshProUGUI2.text = text4;
			return;
		}
		Action<TextMeshProUGUI> action = this.textUpdate;
		throw new NullReferenceException();
	}

	// Token: 0x06002E36 RID: 11830 RVA: 0x000FCD04 File Offset: 0x000FAF04
	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public UIZombieNum()
	{
	}

	// Token: 0x04001C0E RID: 7182
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001C0E")]
	private TextMeshProUGUI t;

	// Token: 0x04001C0F RID: 7183
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001C0F")]
	private Board board;

	// Token: 0x04001C10 RID: 7184
	[Token(Token = "0x4001C10")]
	public static UIZombieNum Instance;

	// Token: 0x04001C11 RID: 7185
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001C11")]
	public Action<TextMeshProUGUI> textUpdate;
}
