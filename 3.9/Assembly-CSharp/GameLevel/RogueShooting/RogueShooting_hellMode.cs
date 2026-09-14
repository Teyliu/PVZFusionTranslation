using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine.Events;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	public class RogueShooting_hellMode : RogueShooting
	{
		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x001615D4 File Offset: 0x0015F7D4
		[Token(Token = "0x170005EB")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60043B4")]
			[Address(RVA = "0x892EA0", Offset = "0x8914A0", VA = "0x180892EA0", Slot = "42")]
			get
			{
				return ChallengeLevel.RogueShooting_hellMode;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x001615E8 File Offset: 0x0015F7E8
		[Token(Token = "0x170005EC")]
		public override string Name
		{
			[Token(Token = "0x60043B5")]
			[Address(RVA = "0x892EB0", Offset = "0x8914B0", VA = "0x180892EB0", Slot = "8")]
			get
			{
				return "诸神进化：炼狱";
			}
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x001615FC File Offset: 0x0015F7FC
		[Token(Token = "0x60043B6")]
		[Address(RVA = "0x892070", Offset = "0x890670", VA = "0x180892070", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			ShootingManager.Instance.hellMode = true;
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00161624 File Offset: 0x0015F824
		[Token(Token = "0x60043B7")]
		[Address(RVA = "0x892AA0", Offset = "0x8910A0", VA = "0x180892AA0", Slot = "43")]
		protected override void SelectPlantCount()
		{
			ShootingManager.Instance.maxStage = (int)((ulong)3L);
			ShootingManager instance = ShootingManager.Instance;
			ShootingManager.Instance.difficulty = (int)((ulong)4L);
			ShootingManager.Instance.healthMultiplier2 = 7f;
			ShootingManager.Instance.healthMultiplier3 = 49f;
			ShootingManager.Instance.BaseDamageMultiplier = 1f;
			ShootingManager.Instance.BaseHealthMulitpier = 4f;
			ShootingManager.Instance.BaseSpeedMultiplier = 1.5f;
			this.debuffCount = (int)((ulong)5L);
			UIResourcesLoader uimanager = GameAPP.UIManager;
			UnityAction unityAction = delegate
			{
				Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			};
			UnityAction unityAction2 = new UnityAction(this.GetRandomZombieBuff);
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x001616E0 File Offset: 0x0015F8E0
		[Token(Token = "0x60043B8")]
		[Address(RVA = "0x891FF0", Offset = "0x8905F0", VA = "0x180891FF0")]
		private void GetRandomZombieBuff()
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00161700 File Offset: 0x0015F900
		[Token(Token = "0x60043B9")]
		[Address(RVA = "0x8920E0", Offset = "0x8906E0", VA = "0x1808920E0")]
		private void SelectDebuff()
		{
			int num = 0;
			UIResourcesLoader uimanager = GameAPP.UIManager;
			TravelDebuff[] enumValues = global::Core.Lawnf.GetEnumValues<TravelDebuff>();
			Func<TravelDebuff, bool> func;
			if (RogueShooting_hellMode.<>c.<>9__8_0 == 0)
			{
				func = delegate(TravelDebuff a)
				{
					if (a < TravelDebuff.Shooting_丢失幸运)
					{
					}
					bool flag;
					return flag;
				};
				RogueShooting_hellMode.<>c.<>9__8_0 = func;
			}
			List<TravelDebuff> list = Enumerable.ToList<TravelDebuff>(Enumerable.Where<TravelDebuff>(enumValues, func));
			ListExtensions.Shuffle<TravelDebuff>(list);
			uint num2;
			IEnumerable<TravelDebuff> enumerable = Enumerable.Take<TravelDebuff>(list, (int)num2);
			if (num < (int)num2)
			{
				num += num;
				if (num == (int)num2)
				{
					goto IL_0117;
				}
				num++;
			}
			if (num < typeof(IEnumerable<TravelDebuff>).TypeHandle)
			{
				num += num;
				num++;
			}
			int num3 = 0;
			if (num < num3)
			{
				num += num;
				if (num == num3)
				{
					goto IL_011F;
				}
				num++;
			}
			Dictionary<TravelDebuff, BaseBuff<TravelDebuff>> deBuffData = TravelMgr.DeBuffData;
			TravelDebuff item;
			TravelDebuff item3 = item;
			string description = deBuffData[item3].Description;
			int point = num;
			string text = description.Before("：");
			string text2 = description.After("：");
			int point2 = point;
			string text3 = string.Format("\n\n难度积分：{0}", text2);
			string text4 = text2 + text3;
			UnityAction unityAction = delegate
			{
				TravelMgr instance2 = TravelMgr.Instance;
				TravelDebuff item2 = item;
				instance2.GetDebuff(item2);
				ShootingManager instance3 = ShootingManager.Instance;
				int debuffPoint = instance3.debuffPoint;
				instance3.debuffPoint = debuffPoint;
			};
			IL_0117:
			BaseMenu baseMenu;
			baseMenu += baseMenu;
			baseMenu += baseMenu;
			IL_011F:
			baseMenu += baseMenu;
			if (num == 0)
			{
				InGameText instance = InGameText.Instance;
				int num4;
				string text5 = string.Format("炼狱难度需要选择：{0}/5个负面词条", num4);
				Action action;
				if (RogueShooting_hellMode.<>c.<>9__8_2 == 0)
				{
					action = delegate
					{
						InGameText.Instance.TimeOver();
					};
					RogueShooting_hellMode.<>c.<>9__8_2 = action;
				}
				Delegate @delegate;
				Delegate delegate2;
				if (@delegate != 0)
				{
					if (@delegate == 0 || @delegate == 0)
					{
						goto IL_01BA;
					}
					Action action2;
					delegate2 = Delegate.Combine(action, action2);
					if (delegate2 == 0)
					{
					}
				}
				if (delegate2 != 0 && delegate2 != 0)
				{
					return;
				}
				throw new InvalidCastException();
			}
			IL_01BA:
			throw new InvalidCastException();
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x001618D4 File Offset: 0x0015FAD4
		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public RogueShooting_hellMode()
		{
		}

		// Token: 0x04003348 RID: 13128
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4003348")]
		private int debuffCount;
	}
}
