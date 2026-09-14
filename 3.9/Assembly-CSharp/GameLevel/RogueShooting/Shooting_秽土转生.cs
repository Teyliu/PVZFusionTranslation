using System;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	public class Shooting_秽土转生 : BaseDebuff
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x0015C874 File Offset: 0x0015AA74
		[Token(Token = "0x170005A4")]
		public override int Point
		{
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x89F050", Offset = "0x89D650", VA = "0x18089F050", Slot = "21")]
			get
			{
				return 600;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0015C888 File Offset: 0x0015AA88
		[Token(Token = "0x170005A5")]
		public override TravelDebuff BuffType
		{
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x8A0210", Offset = "0x89E810", VA = "0x1808A0210", Slot = "12")]
			get
			{
				return TravelDebuff.Shooting_秽土转生;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x0015C89C File Offset: 0x0015AA9C
		[Token(Token = "0x170005A6")]
		public override string Description
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x8A0220", Offset = "0x89E820", VA = "0x1808A0220", Slot = "13")]
			get
			{
				return "秽土转生：僵尸死亡后有概率从本行最右侧复活为其他僵尸（对领袖和boss无效），概率随波次增加";
			}
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x0015C8B0 File Offset: 0x0015AAB0
		[Token(Token = "0x60042AE")]
		[Address(RVA = "0x8A0130", Offset = "0x89E730", VA = "0x1808A0130", Slot = "17")]
		public override void OnSelect(Board board)
		{
			new Shooting_秽土转生.<>c__DisplayClass6_0().board = board;
			int num = 0;
			Action<object> action;
			EventManager.AddListener_obj((GameEvent)((uint)2), action, num != 0);
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x0015C8DC File Offset: 0x0015AADC
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x88C790", Offset = "0x88AD90", VA = "0x18088C790")]
		public Shooting_秽土转生()
		{
		}
	}
}
