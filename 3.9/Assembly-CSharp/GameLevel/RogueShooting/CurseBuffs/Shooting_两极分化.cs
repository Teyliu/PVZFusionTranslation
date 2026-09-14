using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.RogueShooting.CurseBuffs
{
	// Token: 0x02000DBC RID: 3516
	[Token(Token = "0x2000DBC")]
	public class Shooting_两极分化 : BaseCurse
	{
		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x0016B448 File Offset: 0x00169648
		[Token(Token = "0x17000929")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x6004920")]
			[Address(RVA = "0x8B46C0", Offset = "0x8B2CC0", VA = "0x1808B46C0", Slot = "12")]
			get
			{
				return AdvBuff.Shooting_两极分化;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06004921 RID: 18721 RVA: 0x0016B45C File Offset: 0x0016965C
		[Token(Token = "0x1700092A")]
		public override string Description
		{
			[Token(Token = "0x6004921")]
			[Address(RVA = "0x8B46D0", Offset = "0x8B2CD0", VA = "0x1808B46D0", Slot = "13")]
			get
			{
				return "两极分化：若你的幸运低于75，则立即将幸运设置为75非保底时，你的白银、黄金词条降级为木头品质，但钻石词条升级为棱彩品质";
			}
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x0016B470 File Offset: 0x00169670
		[Token(Token = "0x6004922")]
		[Address(RVA = "0x8B45E0", Offset = "0x8B2BE0", VA = "0x1808B45E0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ShootingManager instance = ShootingManager.Instance;
			if ((ulong)1L == 0UL)
			{
			}
			float num = Mathf.Max(ShootingManager.Instance._lucky, 0.75f);
			instance.Lucky = num;
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x0016B4AC File Offset: 0x001696AC
		[Token(Token = "0x6004923")]
		[Address(RVA = "0x8A8560", Offset = "0x8A6B60", VA = "0x1808A8560")]
		public Shooting_两极分化()
		{
		}
	}
}
