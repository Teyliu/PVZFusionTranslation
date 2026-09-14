using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace AutoChess
{
	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2000AF3")]
	public class SynergyManager : MonoBehaviour
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060039EA RID: 14826 RVA: 0x001311C4 File Offset: 0x0012F3C4
		// (set) Token: 0x060039EB RID: 14827 RVA: 0x001311D8 File Offset: 0x0012F3D8
		[Token(Token = "0x170003DB")]
		public static SynergyManager Instance
		{
			[Token(Token = "0x60039EA")]
			[Address(RVA = "0x7E5490", Offset = "0x7E3A90", VA = "0x1807E5490")]
			get;
			[Token(Token = "0x60039EB")]
			[Address(RVA = "0x7E5780", Offset = "0x7E3D80", VA = "0x1807E5780")]
			private set;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x001311EC File Offset: 0x0012F3EC
		[Token(Token = "0x170003DC")]
		public IReadOnlyDictionary<SynergyType, int> CurrentSynergies
		{
			[Token(Token = "0x60039EC")]
			[Address(RVA = "0x515920", Offset = "0x513F20", VA = "0x180515920")]
			get
			{
				Dictionary<SynergyType, int> dictionary = this.currentSynergies;
				return null;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x0013120C File Offset: 0x0012F40C
		[Token(Token = "0x170003DD")]
		public IReadOnlyDictionary<SynergyType, int> ActiveSynergies
		{
			[Token(Token = "0x60039ED")]
			[Address(RVA = "0x515950", Offset = "0x513F50", VA = "0x180515950")]
			get
			{
				Dictionary<SynergyType, int> dictionary = this.activeSynergies;
				return null;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060039EE RID: 14830 RVA: 0x0013122C File Offset: 0x0012F42C
		// (remove) Token: 0x060039EF RID: 14831 RVA: 0x0013125C File Offset: 0x0012F45C
		[Token(Token = "0x1400000F")]
		public event Action<SynergyType, int> OnSynergyChanged
		{
			[Token(Token = "0x60039EE")]
			[Address(RVA = "0x7E5330", Offset = "0x7E3930", VA = "0x1807E5330")]
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
			[Token(Token = "0x60039EF")]
			[Address(RVA = "0x7E5620", Offset = "0x7E3C20", VA = "0x1807E5620")]
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
		// (add) Token: 0x060039F0 RID: 14832 RVA: 0x0013128C File Offset: 0x0012F48C
		// (remove) Token: 0x060039F1 RID: 14833 RVA: 0x001312BC File Offset: 0x0012F4BC
		[Token(Token = "0x14000010")]
		public event Action<SynergyType, int> OnSynergyActivated
		{
			[Token(Token = "0x60039F0")]
			[Address(RVA = "0x7E5280", Offset = "0x7E3880", VA = "0x1807E5280")]
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
			[Token(Token = "0x60039F1")]
			[Address(RVA = "0x7E5570", Offset = "0x7E3B70", VA = "0x1807E5570")]
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
		// (add) Token: 0x060039F2 RID: 14834 RVA: 0x001312EC File Offset: 0x0012F4EC
		// (remove) Token: 0x060039F3 RID: 14835 RVA: 0x0013131C File Offset: 0x0012F51C
		[Token(Token = "0x14000011")]
		public event Action<SynergyType> OnSynergyDeactivated
		{
			[Token(Token = "0x60039F2")]
			[Address(RVA = "0x7E53E0", Offset = "0x7E39E0", VA = "0x1807E53E0")]
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
			[Token(Token = "0x60039F3")]
			[Address(RVA = "0x7E56D0", Offset = "0x7E3CD0", VA = "0x1807E56D0")]
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
		// (add) Token: 0x060039F4 RID: 14836 RVA: 0x0013134C File Offset: 0x0012F54C
		// (remove) Token: 0x060039F5 RID: 14837 RVA: 0x0013137C File Offset: 0x0012F57C
		[Token(Token = "0x14000012")]
		public event Action OnAllSynergiesRefreshed
		{
			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x7E51E0", Offset = "0x7E37E0", VA = "0x1807E51E0")]
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
			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x7E54D0", Offset = "0x7E3AD0", VA = "0x1807E54D0")]
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

		// Token: 0x060039F6 RID: 14838 RVA: 0x001313AC File Offset: 0x0012F5AC
		[Token(Token = "0x60039F6")]
		[Address(RVA = "0x7E0860", Offset = "0x7DEE60", VA = "0x1807E0860")]
		private void Awake()
		{
			SynergyManager.<Instance>k__BackingField = this;
			this.InitializeSynergies();
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x001313C8 File Offset: 0x0012F5C8
		[Token(Token = "0x60039F7")]
		[Address(RVA = "0x7E1C70", Offset = "0x7E0270", VA = "0x1807E1C70")]
		private void InitializeSynergies()
		{
			int num2;
			do
			{
				int num = 0;
				Dictionary<PlantType, PlantData> dictionary = new Dictionary();
				this.plantDatas = dictionary;
				Func<Type, bool> <>9__26_ = SynergyManager.<>c.<>9__26_0;
				if (<>9__26_ == 0)
				{
					SynergyManager.<>c.<>9__26_0 = delegate(Type t)
					{
						if (typeof(PlantData).IsAssignableFrom(t) && !t.IsInterface)
						{
							return t.IsAbstract;
						}
						throw new NullReferenceException();
					};
				}
				if (Enumerable.Where<Type>(dictionary, <>9__26_) != 0)
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
				if ("{il2cpp array field local9->}" != (ulong)0L)
				{
				}
				if (num != 0)
				{
					goto IL_00FF;
				}
				num2 = 0;
				Dictionary<SynergyType, int> dictionary3 = new Dictionary();
				Dictionary<SynergyType, int> dictionary4 = new Dictionary();
				Array values = Enum.GetValues(typeof(SynergyType));
				int num3 = 0;
				IEnumerator enumerator = values.GetEnumerator();
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
				while (enumerator == 0)
				{
				}
			}
			while (num2 != 0);
			Debug.Log("[SynergyManager] 羁绊系统初始化完成");
			return;
			IL_00FF:
			throw new NullReferenceException();
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x001314F8 File Offset: 0x0012F6F8
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x7E23F0", Offset = "0x7E09F0", VA = "0x1807E23F0")]
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

		// Token: 0x060039F9 RID: 14841 RVA: 0x00131D78 File Offset: 0x0012FF78
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x7E00F0", Offset = "0x7DE6F0", VA = "0x1807E00F0")]
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

		// Token: 0x060039FA RID: 14842 RVA: 0x00131E40 File Offset: 0x00130040
		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x7E4F90", Offset = "0x7E3590", VA = "0x1807E4F90")]
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

		// Token: 0x060039FB RID: 14843 RVA: 0x00131EE0 File Offset: 0x001300E0
		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x7E08C0", Offset = "0x7DEEC0", VA = "0x1807E08C0")]
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

		// Token: 0x060039FC RID: 14844 RVA: 0x00131F60 File Offset: 0x00130160
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x7E0AB0", Offset = "0x7DF0B0", VA = "0x1807E0AB0")]
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

		// Token: 0x060039FD RID: 14845 RVA: 0x00131FF4 File Offset: 0x001301F4
		[Token(Token = "0x60039FD")]
		[Address(RVA = "0x7E4950", Offset = "0x7E2F50", VA = "0x1807E4950")]
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

		// Token: 0x060039FE RID: 14846 RVA: 0x001320D8 File Offset: 0x001302D8
		[Token(Token = "0x60039FE")]
		[Address(RVA = "0x7E1330", Offset = "0x7DF930", VA = "0x1807E1330")]
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

		// Token: 0x060039FF RID: 14847 RVA: 0x00132114 File Offset: 0x00130314
		[Token(Token = "0x60039FF")]
		[Address(RVA = "0x7E0410", Offset = "0x7DEA10", VA = "0x1807E0410")]
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

		// Token: 0x06003A00 RID: 14848 RVA: 0x001321DC File Offset: 0x001303DC
		[Token(Token = "0x6003A00")]
		[Address(RVA = "0x7E1420", Offset = "0x7DFA20", VA = "0x1807E1420")]
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

		// Token: 0x06003A01 RID: 14849 RVA: 0x00132208 File Offset: 0x00130408
		[Token(Token = "0x6003A01")]
		[Address(RVA = "0x7E14B0", Offset = "0x7DFAB0", VA = "0x1807E14B0")]
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

		// Token: 0x06003A02 RID: 14850 RVA: 0x00132234 File Offset: 0x00130434
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x7E1BE0", Offset = "0x7E01E0", VA = "0x1807E1BE0")]
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

		// Token: 0x06003A03 RID: 14851 RVA: 0x00132260 File Offset: 0x00130460
		[Token(Token = "0x6003A03")]
		[Address(RVA = "0x7E0F70", Offset = "0x7DF570", VA = "0x1807E0F70")]
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

		// Token: 0x06003A04 RID: 14852 RVA: 0x001322FC File Offset: 0x001304FC
		[Token(Token = "0x6003A04")]
		[Address(RVA = "0x7E1540", Offset = "0x7DFB40", VA = "0x1807E1540")]
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

		// Token: 0x06003A05 RID: 14853 RVA: 0x0013244C File Offset: 0x0013064C
		[Token(Token = "0x6003A05")]
		[Address(RVA = "0x7E0CF0", Offset = "0x7DF2F0", VA = "0x1807E0CF0")]
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

		// Token: 0x06003A06 RID: 14854 RVA: 0x001324C4 File Offset: 0x001306C4
		[Token(Token = "0x6003A06")]
		[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
		public SynergyManager()
		{
		}

		// Token: 0x04002BFB RID: 11259
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BFB")]
		private Dictionary<SynergyType, int> currentSynergies;

		// Token: 0x04002BFC RID: 11260
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BFC")]
		private Dictionary<SynergyType, int> activeSynergies;

		// Token: 0x04002BFD RID: 11261
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BFD")]
		private Dictionary<PlantType, PlantData> plantDatas;

		// Token: 0x04002BFE RID: 11262
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002BFE")]
		private Dictionary<SynergyType, SynergyManager.SynergyConfig> synergyConfigs;

		// Token: 0x02000AF4 RID: 2804
		[Token(Token = "0x2000AF4")]
		[Serializable]
		public class SynergyConfig
		{
			// Token: 0x06003A07 RID: 14855 RVA: 0x001324D8 File Offset: 0x001306D8
			[Token(Token = "0x6003A07")]
			[Address(RVA = "0x7FA600", Offset = "0x7F8C00", VA = "0x1807FA600")]
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

			// Token: 0x06003A08 RID: 14856 RVA: 0x0013250C File Offset: 0x0013070C
			[Token(Token = "0x6003A08")]
			[Address(RVA = "0x7FA690", Offset = "0x7F8C90", VA = "0x1807FA690")]
			public int GetLevel(int count)
			{
				int length = this.thresholds.Length;
				int[] array = this.thresholds;
				return 0;
			}

			// Token: 0x06003A09 RID: 14857 RVA: 0x0013253C File Offset: 0x0013073C
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
			public SynergyConfig()
			{
			}

			// Token: 0x04002C03 RID: 11267
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4002C03")]
			public SynergyType synergyType;

			// Token: 0x04002C04 RID: 11268
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4002C04")]
			public string displayName;

			// Token: 0x04002C05 RID: 11269
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4002C05")]
			public int[] thresholds;

			// Token: 0x04002C06 RID: 11270
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4002C06")]
			public float[] level1Bonus;

			// Token: 0x04002C07 RID: 11271
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4002C07")]
			public float[] level2Bonus;

			// Token: 0x04002C08 RID: 11272
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4002C08")]
			public float[] level3Bonus;

			// Token: 0x04002C09 RID: 11273
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4002C09")]
			public string bonusDescription;
		}
	}
}
