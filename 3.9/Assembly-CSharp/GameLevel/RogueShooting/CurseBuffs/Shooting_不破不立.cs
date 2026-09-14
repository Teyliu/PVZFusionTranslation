using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting.CurseBuffs
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	public class Shooting_不破不立 : BaseCurse
	{
		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x0016B1A8 File Offset: 0x001693A8
		[Token(Token = "0x17000926")]
		public override AdvBuff BuffType
		{
			[Token(Token = "0x600491A")]
			[Address(RVA = "0x8B44F0", Offset = "0x8B2AF0", VA = "0x1808B44F0", Slot = "12")]
			get
			{
				return AdvBuff.Shooting_不破不立;
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600491B RID: 18715 RVA: 0x0016B1BC File Offset: 0x001693BC
		[Token(Token = "0x17000927")]
		public override bool CanAppear
		{
			[Token(Token = "0x600491B")]
			[Address(RVA = "0x8B4500", Offset = "0x8B2B00", VA = "0x1808B4500", Slot = "20")]
			get
			{
				ShootingManager instance = ShootingManager.Instance;
				if (!global::Lawnf.TravelAdvanced((AdvBuff)((uint)13100)))
				{
					int theWave = Board.Instance.theWave;
					if ((theWave > 40 && theWave == 60) || theWave == 20 || theWave == 40)
					{
						return true;
					}
				}
				throw new NullReferenceException();
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x0016B208 File Offset: 0x00169408
		[Token(Token = "0x17000928")]
		public override string Description
		{
			[Token(Token = "0x600491C")]
			[Address(RVA = "0x8B45B0", Offset = "0x8B2BB0", VA = "0x1808B45B0", Slot = "13")]
			get
			{
				return "不破不立：杀死你的全部植物，并将全场植物的独立伤害增幅和速度增幅减半\n在20波后重复这一操作，但改为增幅翻倍";
			}
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x0016B21C File Offset: 0x0016941C
		[Token(Token = "0x600491D")]
		[Address(RVA = "0x8B3FD0", Offset = "0x8B25D0", VA = "0x1808B3FD0", Slot = "17")]
		public override void OnSelect(Board board)
		{
			ulong num6;
			do
			{
				int num = 0;
				int theWave = board.theWave;
				this.startWave = theWave;
				Action action = new Action(this.OnBoardWaveAdd);
				int num2 = 0;
				EventManager.AddListener(GameEvent.BoardWaveAdd, action, num2 != 0);
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				bool flag;
				if (flag)
				{
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_00D0;
				}
				List<KeyValuePair<PlantType, float>> list = Enumerable.ToList<KeyValuePair<PlantType, float>>(TravelMgr.Instance.data.Speed_plant);
				bool flag2;
				if (flag2)
				{
					float num4 = TravelMgr.Instance.data.Speed_plant[num];
				}
				ulong num5;
				if (num5 != (ulong)0L)
				{
					goto IL_00E2;
				}
				List<KeyValuePair<PlantType, float>> list2 = Enumerable.ToList<KeyValuePair<PlantType, float>>(TravelMgr.Instance.data.Damage_plant);
				bool flag3;
				if (flag3)
				{
					float num4 = TravelMgr.Instance.data.Damage_plant[num];
				}
			}
			while (num6 != (ulong)0L);
			return;
			IL_00D0:
			throw new NullReferenceException();
			IL_00E2:
			throw new NullReferenceException();
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x0016B320 File Offset: 0x00169520
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x8B3A70", Offset = "0x8B2070", VA = "0x1808B3A70")]
		private void OnBoardWaveAdd()
		{
			ulong num7;
			do
			{
				int num = 0;
				Board instance = Board.Instance;
				int num2 = this.startWave;
				num2 += 20;
				Action action = new Action(this.OnBoardWaveAdd);
				EventManager.RemoveListener(GameEvent.BoardWaveAdd, action);
				List<KeyValuePair<PlantType, float>> list = Enumerable.ToList<KeyValuePair<PlantType, float>>(TravelMgr.Instance.data.Speed_plant);
				bool flag;
				if (flag)
				{
					float num3 = TravelMgr.Instance.data.Speed_plant[num];
				}
				ulong num4;
				if (num4 != (ulong)0L)
				{
					goto IL_00EE;
				}
				List<KeyValuePair<PlantType, float>> list2 = Enumerable.ToList<KeyValuePair<PlantType, float>>(TravelMgr.Instance.data.Damage_plant);
				bool flag2;
				if (flag2)
				{
					float num5 = TravelMgr.Instance.data.Damage_plant[num];
				}
				ulong num6;
				if (num6 != (ulong)0L)
				{
					goto IL_0100;
				}
				List<Plant> allPlants = global::Lawnf.GetAllPlants();
				bool flag3;
				if (flag3)
				{
				}
			}
			while (num7 != (ulong)0L);
			InGameText instance2 = InGameText.Instance;
			return;
			IL_00EE:
			throw new NullReferenceException();
			IL_0100:
			throw new NullReferenceException();
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x0016B434 File Offset: 0x00169634
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x8A8560", Offset = "0x8A6B60", VA = "0x1808A8560")]
		public Shooting_不破不立()
		{
		}

		// Token: 0x040033E4 RID: 13284
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40033E4")]
		private int startWave;
	}
}
