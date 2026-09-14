using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AB3 RID: 2739
	[Token(Token = "0x2000AB3")]
	public class SynergyManager : MonoBehaviour
	{
		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x0012BFA8 File Offset: 0x0012A1A8
		// (set) Token: 0x060038A7 RID: 14503 RVA: 0x0012BFBC File Offset: 0x0012A1BC
		[Token(Token = "0x17000393")]
		public static SynergyManager Instance
		{
			[Token(Token = "0x60038A6")]
			[Address(RVA = "0x77E5F0", Offset = "0x77CBF0", VA = "0x18077E5F0")]
			get;
			[Token(Token = "0x60038A7")]
			[Address(RVA = "0x77E8E0", Offset = "0x77CEE0", VA = "0x18077E8E0")]
			private set;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x0012BFD0 File Offset: 0x0012A1D0
		[Token(Token = "0x17000394")]
		public IReadOnlyDictionary<SynergyType, int> CurrentSynergies
		{
			[Token(Token = "0x60038A8")]
			[Address(RVA = "0x4A9CF0", Offset = "0x4A82F0", VA = "0x1804A9CF0")]
			get
			{
				Dictionary<SynergyType, int> dictionary = this.currentSynergies;
				return null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x0012BFF0 File Offset: 0x0012A1F0
		[Token(Token = "0x17000395")]
		public IReadOnlyDictionary<SynergyType, int> ActiveSynergies
		{
			[Token(Token = "0x60038A9")]
			[Address(RVA = "0x4A9D20", Offset = "0x4A8320", VA = "0x1804A9D20")]
			get
			{
				Dictionary<SynergyType, int> dictionary = this.activeSynergies;
				return null;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060038AA RID: 14506 RVA: 0x0012C010 File Offset: 0x0012A210
		// (remove) Token: 0x060038AB RID: 14507 RVA: 0x0012C040 File Offset: 0x0012A240
		[Token(Token = "0x1400000F")]
		public event Action<SynergyType, int> OnSynergyChanged
		{
			[Token(Token = "0x60038AA")]
			[Address(RVA = "0x77E490", Offset = "0x77CA90", VA = "0x18077E490")]
			[CompilerGenerated]
			add
			{
				Action<SynergyType, int> onSynergyChanged = this.OnSynergyChanged;
				Delegate @delegate = Delegate.Combine(onSynergyChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60038AB")]
			[Address(RVA = "0x77E780", Offset = "0x77CD80", VA = "0x18077E780")]
			[CompilerGenerated]
			remove
			{
				Action<SynergyType, int> onSynergyChanged = this.OnSynergyChanged;
				Delegate @delegate = Delegate.Remove(onSynergyChanged, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060038AC RID: 14508 RVA: 0x0012C070 File Offset: 0x0012A270
		// (remove) Token: 0x060038AD RID: 14509 RVA: 0x0012C0A0 File Offset: 0x0012A2A0
		[Token(Token = "0x14000010")]
		public event Action<SynergyType, int> OnSynergyActivated
		{
			[Token(Token = "0x60038AC")]
			[Address(RVA = "0x77E3E0", Offset = "0x77C9E0", VA = "0x18077E3E0")]
			[CompilerGenerated]
			add
			{
				Action<SynergyType, int> onSynergyActivated = this.OnSynergyActivated;
				Delegate @delegate = Delegate.Combine(onSynergyActivated, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60038AD")]
			[Address(RVA = "0x77E6D0", Offset = "0x77CCD0", VA = "0x18077E6D0")]
			[CompilerGenerated]
			remove
			{
				Action<SynergyType, int> onSynergyActivated = this.OnSynergyActivated;
				Delegate @delegate = Delegate.Remove(onSynergyActivated, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyActivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060038AE RID: 14510 RVA: 0x0012C0D0 File Offset: 0x0012A2D0
		// (remove) Token: 0x060038AF RID: 14511 RVA: 0x0012C100 File Offset: 0x0012A300
		[Token(Token = "0x14000011")]
		public event Action<SynergyType> OnSynergyDeactivated
		{
			[Token(Token = "0x60038AE")]
			[Address(RVA = "0x77E540", Offset = "0x77CB40", VA = "0x18077E540")]
			[CompilerGenerated]
			add
			{
				Action<SynergyType> onSynergyDeactivated = this.OnSynergyDeactivated;
				Delegate @delegate = Delegate.Combine(onSynergyDeactivated, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyDeactivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60038AF")]
			[Address(RVA = "0x77E830", Offset = "0x77CE30", VA = "0x18077E830")]
			[CompilerGenerated]
			remove
			{
				Action<SynergyType> onSynergyDeactivated = this.OnSynergyDeactivated;
				Delegate @delegate = Delegate.Remove(onSynergyDeactivated, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onSynergyDeactivated)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060038B0 RID: 14512 RVA: 0x0012C130 File Offset: 0x0012A330
		// (remove) Token: 0x060038B1 RID: 14513 RVA: 0x0012C160 File Offset: 0x0012A360
		[Token(Token = "0x14000012")]
		public event Action OnAllSynergiesRefreshed
		{
			[Token(Token = "0x60038B0")]
			[Address(RVA = "0x77E340", Offset = "0x77C940", VA = "0x18077E340")]
			[CompilerGenerated]
			add
			{
				Action onAllSynergiesRefreshed = this.OnAllSynergiesRefreshed;
				Delegate @delegate = Delegate.Combine(onAllSynergiesRefreshed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onAllSynergiesRefreshed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Token(Token = "0x60038B1")]
			[Address(RVA = "0x77E630", Offset = "0x77CC30", VA = "0x18077E630")]
			[CompilerGenerated]
			remove
			{
				Action onAllSynergiesRefreshed = this.OnAllSynergiesRefreshed;
				Delegate @delegate = Delegate.Remove(onAllSynergiesRefreshed, value);
				if (@delegate == 0 || @delegate != 0)
				{
					while (@delegate != onAllSynergiesRefreshed)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x0012C190 File Offset: 0x0012A390
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x7799C0", Offset = "0x777FC0", VA = "0x1807799C0")]
		private void Awake()
		{
			SynergyManager.<Instance>k__BackingField = this;
			this.InitializeSynergies();
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x0012C1AC File Offset: 0x0012A3AC
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x77ADD0", Offset = "0x7793D0", VA = "0x18077ADD0")]
		private void InitializeSynergies()
		{
			int num2;
			do
			{
				int num = 0;
				Dictionary<PlantType, PlantData> dictionary = new Dictionary();
				this.plantDatas = dictionary;
				IEnumerator enumerator = dictionary.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
				if (SynergyManager.<>c.<>9__26_0 == 0)
				{
					Func<Type, bool> func;
					SynergyManager.<>c.<>9__26_0 = func;
				}
				IEnumerable<Type> enumerable;
				if (enumerable != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num != typeof(IEnumerator).TypeHandle)
						{
							num++;
						}
					}
					Dictionary<PlantType, PlantData> dictionary2 = this.plantDatas;
				}
				if ("{il2cpp array field local10->}" != (ulong)0L)
				{
				}
				if (num != 0)
				{
					goto IL_00F0;
				}
				num2 = 0;
				Dictionary<SynergyType, int> dictionary3 = new Dictionary();
				Dictionary<SynergyType, int> dictionary4 = new Dictionary();
				Array values = Enum.GetValues(typeof(SynergyType));
				int num3 = 0;
				IEnumerator enumerator2 = values.GetEnumerator();
				if (num2 < num3)
				{
					num2 += num2;
					num2++;
				}
				if (num2 < num2)
				{
					num2 += num2;
					num2++;
				}
				while (enumerator2 == 0)
				{
				}
			}
			while (num2 != 0);
			Debug.Log("[SynergyManager] 羁绊系统初始化完成");
			return;
			IL_00F0:
			throw new NullReferenceException();
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x0012C2D0 File Offset: 0x0012A4D0
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x77B550", Offset = "0x779B50", VA = "0x18077B550")]
		private void InitializeSynergyConfigs()
		{
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary = new Dictionary();
			this.synergyConfigs = dictionary;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig = new SynergyManager.SynergyConfig();
			synergyConfig.synergyType = (SynergyType)((ulong)1L);
			synergyConfig.displayName = "列车同行";
			int[] array = new int[] { 2, 4, 6 };
			synergyConfig.thresholds = array;
			synergyConfig.level1Bonus = new float[] { (float)((ulong)1092616192L) };
			synergyConfig.level2Bonus = new float[] { (float)((ulong)1101004800L) };
			synergyConfig.level3Bonus = new float[] { (float)((ulong)1108082688L) };
			synergyConfig.bonusDescription = "前台植物攻击力+10%/20%/35%";
			dictionary2[(uint)1] = synergyConfig;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary3 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig2 = new SynergyManager.SynergyConfig();
			synergyConfig2.synergyType = (SynergyType)((ulong)2L);
			synergyConfig2.displayName = "银河学者";
			int[] array2 = new int[] { 2, 4, 6 };
			synergyConfig2.thresholds = array2;
			synergyConfig2.level1Bonus = new float[] { (float)((ulong)1097859072L) };
			synergyConfig2.level2Bonus = new float[] { (float)((ulong)1106247680L) };
			synergyConfig2.level3Bonus = new float[] { (float)((ulong)1112014848L) };
			synergyConfig2.bonusDescription = "技能伤害+15%/30%/50%";
			dictionary3[(uint)2] = synergyConfig2;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary4 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig3 = new SynergyManager.SynergyConfig();
			synergyConfig3.synergyType = (SynergyType)((ulong)3L);
			synergyConfig3.displayName = "盛会之星";
			int[] array3 = new int[2];
			array3[0] = (int)((ulong)2L);
			array3[0] = (int)((ulong)4L);
			synergyConfig3.thresholds = array3;
			float[] array4 = new float[2];
			array4[0] = (float)((ulong)1092616192L);
			array4[0] = (float)((ulong)1036831949L);
			synergyConfig3.level1Bonus = array4;
			float[] array5 = new float[2];
			array5[0] = (float)((ulong)1101004800L);
			array5[0] = (float)((ulong)1045220557L);
			synergyConfig3.level2Bonus = array5;
			float[] array6 = new float[2];
			array6[0] = (float)((ulong)1106247680L);
			array6[0] = (float)((ulong)1050253722L);
			synergyConfig3.level3Bonus = array6;
			synergyConfig3.bonusDescription = "暴击率/暴击伤害+10%/20%/30%";
			dictionary4[(uint)3] = synergyConfig3;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary5 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig4 = new SynergyManager.SynergyConfig();
			synergyConfig4.synergyType = (SynergyType)((ulong)4L);
			synergyConfig4.displayName = "昼之半神";
			synergyConfig4.thresholds = new int[] { (int)((ulong)2L) };
			synergyConfig4.level1Bonus = new float[] { (float)((ulong)1120403456L) };
			synergyConfig4.level2Bonus = new float[] { (float)((ulong)1132068864L) };
			synergyConfig4.level3Bonus = new float[] { (float)((ulong)1140457472L) };
			synergyConfig4.bonusDescription = "最大生命值+100/250/500";
			dictionary5[(uint)4] = synergyConfig4;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary6 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig5 = new SynergyManager.SynergyConfig();
			synergyConfig5.synergyType = (SynergyType)((ulong)5L);
			synergyConfig5.displayName = "夜之半神";
			synergyConfig5.thresholds = new int[] { (int)((ulong)2L) };
			synergyConfig5.level1Bonus = new float[] { (float)((ulong)1097859072L) };
			synergyConfig5.level2Bonus = new float[] { (float)((ulong)1106247680L) };
			synergyConfig5.level3Bonus = new float[] { (float)((ulong)1112014848L) };
			synergyConfig5.bonusDescription = "攻击速度+15%/30%/50%";
			dictionary6[(uint)5] = synergyConfig5;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary7 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig6 = new SynergyManager.SynergyConfig();
			synergyConfig6.synergyType = (SynergyType)((ulong)6L);
			synergyConfig6.displayName = "巡海游侠";
			int[] array7 = new int[2];
			array7[0] = (int)((ulong)2L);
			array7[0] = (int)((ulong)4L);
			synergyConfig6.thresholds = array7;
			synergyConfig6.level1Bonus = new float[] { (float)((ulong)1101004800L) };
			synergyConfig6.level2Bonus = new float[] { (float)((ulong)1109393408L) };
			synergyConfig6.level3Bonus = new float[] { (float)((ulong)1116471296L) };
			synergyConfig6.bonusDescription = "追击子弹伤害+20%/40%/70%";
			dictionary7[(uint)6] = synergyConfig6;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary8 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig7 = new SynergyManager.SynergyConfig();
			synergyConfig7.synergyType = (SynergyType)((ulong)7L);
			synergyConfig7.displayName = "公司";
			synergyConfig7.thresholds = new int[] { (int)((ulong)2L) };
			synergyConfig7.level1Bonus = new float[] { (float)((ulong)1065353216L) };
			synergyConfig7.level2Bonus = new float[] { (float)((ulong)1073741824L) };
			synergyConfig7.level3Bonus = new float[] { (float)((ulong)1077936128L) };
			synergyConfig7.bonusDescription = "击杀敌人金币+1/2/3";
			dictionary8[(uint)7] = synergyConfig7;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary9 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig8 = new SynergyManager.SynergyConfig();
			synergyConfig8.synergyType = (SynergyType)((ulong)8L);
			synergyConfig8.displayName = "仙舟";
			int[] array8 = new int[2];
			array8[0] = (int)((ulong)2L);
			array8[0] = (int)((ulong)4L);
			synergyConfig8.thresholds = array8;
			synergyConfig8.level1Bonus = new float[] { (float)((ulong)1036831949L) };
			synergyConfig8.level2Bonus = new float[] { (float)((ulong)1045220557L) };
			synergyConfig8.level3Bonus = new float[] { (float)((ulong)1051931443L) };
			synergyConfig8.bonusDescription = "大招充能速度+10%/20%/35%";
			dictionary9[(uint)8] = synergyConfig8;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary10 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig9 = new SynergyManager.SynergyConfig();
			synergyConfig9.synergyType = (SynergyType)((ulong)9L);
			synergyConfig9.displayName = "狼狩";
			int[] array9 = new int[2];
			array9[0] = (int)((ulong)2L);
			array9[0] = (int)((ulong)4L);
			synergyConfig9.thresholds = array9;
			synergyConfig9.level1Bonus = new float[] { (float)((ulong)1092616192L) };
			synergyConfig9.level2Bonus = new float[] { (float)((ulong)1101004800L) };
			synergyConfig9.level3Bonus = new float[] { (float)((ulong)1108082688L) };
			synergyConfig9.bonusDescription = "移动速度+10%/20%/35%";
			dictionary10[(uint)9] = synergyConfig9;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary11 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig10 = new SynergyManager.SynergyConfig();
			synergyConfig10.synergyType = (SynergyType)((ulong)10L);
			synergyConfig10.displayName = "贝洛伯格";
			int[] array10 = new int[2];
			array10[0] = (int)((ulong)2L);
			array10[0] = (int)((ulong)4L);
			synergyConfig10.thresholds = array10;
			synergyConfig10.level1Bonus = new float[] { (float)((ulong)1097859072L) };
			synergyConfig10.level2Bonus = new float[] { (float)((ulong)1106247680L) };
			synergyConfig10.level3Bonus = new float[] { (float)((ulong)1112014848L) };
			synergyConfig10.bonusDescription = "护甲+15/30/50";
			dictionary11[(uint)10] = synergyConfig10;
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary12 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig11 = new SynergyManager.SynergyConfig();
			synergyConfig11.synergyType = (SynergyType)((ulong)11L);
			synergyConfig11.displayName = "星间旅人";
			synergyConfig11.thresholds = new int[] { (int)((ulong)2L) };
			synergyConfig11.level1Bonus = new float[] { (float)((ulong)1092616192L) };
			synergyConfig11.level2Bonus = new float[] { (float)((ulong)1101004800L) };
			synergyConfig11.level3Bonus = new float[] { (float)((ulong)1108082688L) };
			synergyConfig11.bonusDescription = "全体伤害+10%/20%/35%";
			dictionary12[(uint)11] = synergyConfig11;
			SynergyManager.SynergyConfig synergyConfig12 = new SynergyManager.SynergyConfig();
			synergyConfig12.synergyType = (SynergyType)((ulong)12L);
			synergyConfig12.displayName = "星核猎手";
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x0012CB50 File Offset: 0x0012AD50
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x779250", Offset = "0x777850", VA = "0x180779250")]
		public void AddPlant(Plant plant)
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				int num3 = 0;
				if (plant == num3)
				{
					goto IL_00A3;
				}
				Dictionary<PlantType, PlantData> dictionary = this.plantDatas;
				PlantType thePlantType = plant.thePlantType;
				if (!dictionary.TryGetValue(thePlantType, num))
				{
					break;
				}
				bool flag;
				if (flag)
				{
					while (num2 == 0)
					{
					}
					Dictionary<SynergyType, int> dictionary2 = this.currentSynergies;
					int num4 = dictionary2[num2] + 1;
					dictionary2[num2] = num4;
					if (this.OnSynergyChanged != 0)
					{
						int num5 = this.currentSynergies[num2];
					}
					this.CheckSynergyActivation((SynergyType)num2);
				}
			}
			while (num != 0);
			if (this.OnAllSynergiesRefreshed != 0)
			{
			}
			string name = Lawnf.GetName(plant.thePlantType);
			Debug.Log("[SynergyManager] 添加植物: " + name);
			return;
			IL_00A3:
			Debug.LogWarning("[SynergyManager] 尝试添加空植物");
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x0012CC18 File Offset: 0x0012AE18
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x77E0F0", Offset = "0x77C6F0", VA = "0x18077E0F0")]
		public void RemovePlant(Plant plant)
		{
			int num;
			do
			{
				num = 0;
				int num2 = 0;
				Dictionary<PlantType, PlantData> dictionary = this.plantDatas;
				PlantType thePlantType = plant.thePlantType;
				if (!dictionary.TryGetValue(thePlantType, num))
				{
					break;
				}
				bool flag;
				if (flag)
				{
					while (num2 == 0)
					{
					}
					Dictionary<SynergyType, int> dictionary2 = this.currentSynergies;
					int num3 = dictionary2[num2] - 1;
					dictionary2[num2] = num3;
					if (this.OnSynergyChanged != 0)
					{
						int num4 = this.currentSynergies[num2];
					}
					this.CheckSynergyDeactivation((SynergyType)num2);
				}
			}
			while (num != 0);
			Action onAllSynergiesRefreshed = this.OnAllSynergiesRefreshed;
			if (onAllSynergiesRefreshed != 0)
			{
				IntPtr invoke_impl = onAllSynergiesRefreshed.invoke_impl;
			}
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x0012CCB8 File Offset: 0x0012AEB8
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x779A20", Offset = "0x778020", VA = "0x180779A20")]
		private void CheckSynergyActivation(SynergyType synergyType)
		{
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary = this.synergyConfigs;
			bool flag;
			if (flag)
			{
				Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
				Dictionary<SynergyType, int> dictionary3 = this.currentSynergies;
				int num2;
				int num = num2;
				SynergyManager.SynergyConfig synergyConfig;
				int num3 = synergyConfig.GetLevel(num);
				Dictionary<SynergyType, int> dictionary4 = this.activeSynergies;
				int num4;
				if (num3 > num4)
				{
					Dictionary<SynergyType, int> dictionary5 = this.activeSynergies;
					if (this.OnSynergyActivated != 0)
					{
					}
					string displayName = synergyConfig.displayName;
					num3 = num4;
					Debug.Log(string.Format("[SynergyManager] 羁绊激活: {0} {1}级 ({2}个植物)", displayName, num3, num4));
				}
			}
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x0012CD38 File Offset: 0x0012AF38
		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x779C10", Offset = "0x778210", VA = "0x180779C10")]
		private void CheckSynergyDeactivation(SynergyType synergyType)
		{
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary = this.synergyConfigs;
			bool flag;
			if (flag)
			{
				Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
				Dictionary<SynergyType, int> dictionary3 = this.currentSynergies;
				int num2;
				int num = num2;
				SynergyManager.SynergyConfig synergyConfig;
				int num3 = synergyConfig.GetLevel(num);
				Dictionary<SynergyType, int> dictionary4 = this.activeSynergies;
				int num4;
				if (num3 < num4)
				{
					Dictionary<SynergyType, int> dictionary5 = this.activeSynergies;
					Dictionary<SynergyType, int> dictionary6 = this.activeSynergies;
					if (num3 == 0)
					{
						if (this.OnSynergyDeactivated != 0)
						{
						}
						throw new NullReferenceException();
					}
					if (this.OnSynergyActivated != 0)
					{
					}
					string displayName = synergyConfig.displayName;
					int num5;
					num3 = num5;
					Debug.Log(string.Format("[SynergyManager] 羁绊降级: {0} {1}级 → {2}级", displayName, num3, num5));
				}
			}
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		[Token(Token = "0x60038B9")]
		[Address(RVA = "0x77DAB0", Offset = "0x77C0B0", VA = "0x18077DAB0")]
		public void RecalculateAllSynergies()
		{
			int num8;
			for (;;)
			{
				int num = 0;
				int num2 = 0;
				List<SynergyType> list = Enumerable.ToList<SynergyType>(this.currentSynergies.Keys);
				bool flag;
				if (flag)
				{
					Dictionary<SynergyType, int> dictionary = this.currentSynergies;
					int num3 = 0;
					dictionary[num] = num3;
				}
				if (num2 != 0)
				{
					goto IL_00B3;
				}
				int num4 = 0;
				Dictionary.KeyCollection keyCollection;
				List<SynergyType> list2 = Enumerable.ToList<SynergyType>(keyCollection);
				bool flag2;
				if (flag2)
				{
				}
				if (num4 != 0)
				{
					goto IL_00B9;
				}
				int num5 = 0;
				List<Plant> allPlants = Lawnf.GetAllPlants();
				bool flag3;
				if (flag3)
				{
					bool flag4;
					while (!flag4)
					{
					}
					bool flag5;
					if (flag5)
					{
						while (num == 0)
						{
						}
						int num7;
						int num6 = num7 + 1;
					}
					if (num5 != 0)
					{
						goto IL_00BF;
					}
				}
				if (num5 == 0)
				{
					num8 = 0;
					bool flag6;
					if (flag6)
					{
					}
					if (num8 == 0)
					{
						break;
					}
				}
			}
			if (num8 != 0)
			{
			}
			Debug.Log("[SynergyManager] 所有羁绊已重新计算");
			return;
			IL_00B3:
			throw new NullReferenceException();
			IL_00B9:
			throw new NullReferenceException();
			IL_00BF:
			throw new NullReferenceException();
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x0012CEB0 File Offset: 0x0012B0B0
		[Token(Token = "0x60038BA")]
		[Address(RVA = "0x77A490", Offset = "0x778A90", VA = "0x18077A490")]
		public float[] GetSynergyBonus(SynergyType synergyType)
		{
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary = this.synergyConfigs;
			bool flag;
			if (flag)
			{
				Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
				Dictionary<SynergyType, int> dictionary3 = this.activeSynergies;
				int num2;
				int num = num2;
				SynergyManager.SynergyConfig synergyConfig;
				return synergyConfig.GetBonus(num);
			}
			throw new NullReferenceException();
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0012CEEC File Offset: 0x0012B0EC
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x779570", Offset = "0x777B70", VA = "0x180779570")]
		public ValueTuple<float, float, float> ApplySynergyBonuses(PlantData plant, float baseAttack, float baseHP, float baseArmor)
		{
			ulong num3;
			do
			{
				int num = 0;
				bool flag;
				if (flag)
				{
					while (num == 0)
					{
					}
					bool flag2;
					while (!flag2)
					{
					}
					int num2;
					while (num2 == 0)
					{
					}
					SynergyManager.SynergyConfig synergyConfig;
					float[] bonus = synergyConfig.GetBonus(num2);
					if (18446744073709551615UL <= (ulong)10L)
					{
					}
					while (num != 17)
					{
					}
				}
			}
			while (num3 != (ulong)0L);
			throw new NullReferenceException();
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0012CFB4 File Offset: 0x0012B1B4
		[Token(Token = "0x60038BC")]
		[Address(RVA = "0x77A580", Offset = "0x778B80", VA = "0x18077A580")]
		public SynergyManager.SynergyConfig GetSynergyConfig(SynergyType synergyType)
		{
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary = this.synergyConfigs;
			bool flag;
			if (!flag)
			{
			}
			Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
			SynergyManager.SynergyConfig synergyConfig;
			return synergyConfig;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0012CFE0 File Offset: 0x0012B1E0
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x77A610", Offset = "0x778C10", VA = "0x18077A610")]
		public int GetSynergyCount(SynergyType synergyType)
		{
			Dictionary<SynergyType, int> dictionary = this.currentSynergies;
			bool flag;
			if (!flag)
			{
				return 0;
			}
			Dictionary<SynergyType, int> dictionary2 = this.currentSynergies;
			int num;
			return num;
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0012D00C File Offset: 0x0012B20C
		[Token(Token = "0x60038BE")]
		[Address(RVA = "0x77AD40", Offset = "0x779340", VA = "0x18077AD40")]
		public int GetSynergyLevel(SynergyType synergyType)
		{
			Dictionary<SynergyType, int> dictionary = this.activeSynergies;
			bool flag;
			if (!flag)
			{
				return 0;
			}
			Dictionary<SynergyType, int> dictionary2 = this.activeSynergies;
			int num;
			return num;
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x0012D038 File Offset: 0x0012B238
		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x77A0D0", Offset = "0x7786D0", VA = "0x18077A0D0")]
		public List<ValueTuple<string, int, int, string>> GetActiveSynergiesInfo()
		{
			List<ValueTuple<string, int, int, string>> list;
			ulong num;
			do
			{
				list = new List();
				Dictionary<SynergyType, int> dictionary = this.activeSynergies;
				bool flag;
				if (flag)
				{
					Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
					bool flag2;
					while (!flag2)
					{
					}
					Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary3 = this.synergyConfigs;
					Dictionary<SynergyType, int> dictionary4 = this.currentSynergies;
					SynergyManager.SynergyConfig synergyConfig;
					string bonusDescription = synergyConfig.bonusDescription;
				}
			}
			while (num != (ulong)0L);
			Comparison<ValueTuple<string, int, int, string>> comparison;
			if (SynergyManager.<>c.<>9__38_0 == 0)
			{
				SynergyManager.<>c.<>9__38_0 = comparison;
			}
			list.Sort(comparison);
			return list;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x0012D0D4 File Offset: 0x0012B2D4
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x77A6A0", Offset = "0x778CA0", VA = "0x18077A6A0")]
		public string GetSynergyInfo()
		{
			string text6;
			ulong num3;
			do
			{
				int num = 0;
				int size = Lawnf.GetAllPlants()._size;
				string text = string.Format("场上植物数量: {0}\n", size);
				string text2 = "=== 羁绊系统信息 ===\n" + text + "\n=== 激活的羁绊 ===\n";
				List<ValueTuple<string, int, int, string>> activeSynergiesInfo = this.GetActiveSynergiesInfo();
				bool flag;
				if (flag)
				{
					object[] array = new object[4];
					if (array != 0)
					{
					}
					array[0] = array;
					if (array != 0)
					{
					}
					array[2] = array;
					if (num != 0)
					{
					}
					array[3] = num;
					string text3 = string.Format("[{0}级] {1} ({2}个): {3}\n", array);
					string text4 = text2 + text3;
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_0130;
				}
				string text5 = text2 + "（无激活羁绊）\n" + "\n=== 所有羁绊统计 ===\n";
				Dictionary<SynergyType, int> dictionary = this.currentSynergies;
				bool flag2;
				if (flag2)
				{
					Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary2 = this.synergyConfigs;
					bool flag3;
					if (flag3)
					{
						Dictionary<SynergyType, SynergyManager.SynergyConfig> dictionary3 = this.synergyConfigs;
						SynergyManager.SynergyConfig synergyConfig;
						string displayName = synergyConfig.displayName;
					}
					string text7;
					text6 = text5 + text7;
				}
			}
			while (num3 != (ulong)0L);
			return text6;
			IL_0130:
			throw new NullReferenceException();
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x0012D224 File Offset: 0x0012B424
		[Token(Token = "0x60038C1")]
		[Address(RVA = "0x779E50", Offset = "0x778450", VA = "0x180779E50")]
		public void ClearAllSynergies()
		{
			ulong num4;
			do
			{
				int num = 0;
				List<SynergyType> list = Enumerable.ToList<SynergyType>(this.currentSynergies.Keys);
				bool flag;
				if (flag)
				{
					Dictionary<SynergyType, int> dictionary = this.currentSynergies;
					int num2 = 0;
					dictionary[num] = num2;
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_0062;
				}
				Dictionary.KeyCollection keyCollection;
				List<SynergyType> list2 = Enumerable.ToList<SynergyType>(keyCollection);
				bool flag2;
				if (flag2)
				{
				}
			}
			while (num4 != (ulong)0L);
			if (num4 != (ulong)0L)
			{
			}
			return;
			IL_0062:
			throw new NullReferenceException();
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x0012D29C File Offset: 0x0012B49C
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
		public SynergyManager()
		{
		}

		// Token: 0x04002A88 RID: 10888
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002A88")]
		private Dictionary<SynergyType, int> currentSynergies;

		// Token: 0x04002A89 RID: 10889
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A89")]
		private Dictionary<SynergyType, int> activeSynergies;

		// Token: 0x04002A8A RID: 10890
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002A8A")]
		private Dictionary<PlantType, PlantData> plantDatas;

		// Token: 0x04002A8B RID: 10891
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002A8B")]
		private Dictionary<SynergyType, SynergyManager.SynergyConfig> synergyConfigs;

		// Token: 0x02000AB4 RID: 2740
		[Token(Token = "0x2000AB4")]
		[Serializable]
		public class SynergyConfig
		{
			// Token: 0x060038C3 RID: 14531 RVA: 0x0012D2B0 File Offset: 0x0012B4B0
			[Token(Token = "0x60038C3")]
			[Address(RVA = "0x793D90", Offset = "0x792390", VA = "0x180793D90")]
			public float[] GetBonus(int level)
			{
				int num = level - 1;
				if (num == 0)
				{
					return this.level1Bonus;
				}
				if (num != 0)
				{
					if (num != 1)
					{
					}
					return this.level3Bonus;
				}
				return this.level2Bonus;
			}

			// Token: 0x060038C4 RID: 14532 RVA: 0x0012D2E4 File Offset: 0x0012B4E4
			[Token(Token = "0x60038C4")]
			[Address(RVA = "0x793E20", Offset = "0x792420", VA = "0x180793E20")]
			public int GetLevel(int count)
			{
				int length = this.thresholds.Length;
				int[] array = this.thresholds;
				return 0;
			}

			// Token: 0x060038C5 RID: 14533 RVA: 0x0012D314 File Offset: 0x0012B514
			[Token(Token = "0x60038C5")]
			[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
			public SynergyConfig()
			{
			}

			// Token: 0x04002A90 RID: 10896
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002A90")]
			public SynergyType synergyType;

			// Token: 0x04002A91 RID: 10897
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002A91")]
			public string displayName;

			// Token: 0x04002A92 RID: 10898
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002A92")]
			public int[] thresholds;

			// Token: 0x04002A93 RID: 10899
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002A93")]
			public float[] level1Bonus;

			// Token: 0x04002A94 RID: 10900
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002A94")]
			public float[] level2Bonus;

			// Token: 0x04002A95 RID: 10901
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4002A95")]
			public float[] level3Bonus;

			// Token: 0x04002A96 RID: 10902
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4002A96")]
			public string bonusDescription;
		}
	}
}
