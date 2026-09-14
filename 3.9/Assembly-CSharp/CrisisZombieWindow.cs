using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000856 RID: 2134
[Token(Token = "0x2000856")]
public class CrisisZombieWindow : BaseWindow
{
	// Token: 0x06002B64 RID: 11108 RVA: 0x000EBA30 File Offset: 0x000E9C30
	[Token(Token = "0x6002B64")]
	[Address(RVA = "0x69D170", Offset = "0x69B770", VA = "0x18069D170", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		ZombieType zombieType = this.zombieType;
		base.SetZombie(zombieType, 0.85f);
		int num = (int)this.zombieType;
		bool flag;
		if (flag)
		{
			Transform transform = base.transform;
			int num2 = 0;
			Transform child = transform.GetChild(num2);
			int num3 = 0;
			GameObject gameObject = child.GetChild(num3).gameObject;
			Image component = gameObject.GetComponent<Image>();
			int num4 = 0;
			component.enabled = num4 != 0;
			gameObject.transform.GetChild(1).gameObject.SetActive(true);
		}
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x000EBABC File Offset: 0x000E9CBC
	[Token(Token = "0x6002B65")]
	[Address(RVA = "0x69D040", Offset = "0x69B640", VA = "0x18069D040")]
	public void SetZombieType(ZombieType zombieType, int round)
	{
		this.zombieType = zombieType;
		Dictionary<ZombieType, string> zombieDescriptions = CrisisZombieWindow.ZombieDescriptions;
		bool flag;
		if (flag)
		{
			string text = string.Format("最早出现：第{0}轮", flag);
			string text2;
			this.introduce.text = text2;
		}
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x000EBB00 File Offset: 0x000E9D00
	[Token(Token = "0x6002B66")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public CrisisZombieWindow()
	{
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x000EBB14 File Offset: 0x000E9D14
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6002B67")]
	[Address(RVA = "0x69D2C0", Offset = "0x69B8C0", VA = "0x18069D2C0")]
	static CrisisZombieWindow()
	{
		throw new NullReferenceException();
	}

	// Token: 0x04001961 RID: 6497
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001961")]
	public ZombieType zombieType;

	// Token: 0x04001962 RID: 6498
	[Token(Token = "0x4001962")]
	private static readonly Dictionary<ZombieType, string> ZombieDescriptions = new Dictionary
	{
		{
			(uint)336,
			"战象\n僵尸等级：1\n韧性：高\n攻击力：低\n特点：无\n"
		},
		{
			(uint)337,
			"中型战象\n僵尸等级：2\n韧性：很高\n攻击力：低\n特点：会把僵尸往前顶\n"
		},
		{
			(uint)338,
			"精锐战象\n僵尸等级：3\n韧性：极高\n攻击力：低\n特点：不可阻挡\n"
		},
		{
			(uint)333,
			"轻装三叉戟冲车\n僵尸等级：1\n韧性：低\n攻击力：低\n特点：投掷少量三叉戟\n"
		},
		{
			(uint)334,
			"重装三叉戟冲车\n僵尸等级：2\n韧性：中\n攻击力：低\n特点：投掷大量三叉戟\n"
		},
		{
			(uint)335,
			"殉爆三叉戟冲车\n僵尸等级：3\n韧性：高\n攻击力：低\n特点：死亡时散射三叉戟\n"
		},
		{
			(uint)330,
			"百年毛僵\n僵尸等级：1\n韧性：低\n攻击力：低\n特点：死亡物理爆炸\n"
		},
		{
			(uint)331,
			"千年飞僵\n僵尸等级：2\n韧性：中\n攻击力：低\n特点：定期突进\n"
		},
		{
			(uint)332,
			"万年尸皇\n僵尸等级：3\n韧性：高\n攻击力：中\n特点：定期穿梭\n"
		},
		{
			(uint)327,
			"基洛夫轰炸飞艇\n僵尸等级：1\n韧性：低\n攻击力：极高\n特点：近程投弹\n"
		},
		{
			(uint)328,
			"基洛夫母舰飞艇\n僵尸等级：2\n韧性：中\n攻击力：极高\n特点：持续召唤轰炸机\n"
		},
		{
			(uint)329,
			"航空引导者飞艇\n僵尸等级：3\n韧性：高\n攻击力：极高\n特点：远程爆破一行\n"
		},
		{
			(uint)324,
			"玩偶匣跳跳僵尸\n僵尸等级：1\n韧性：低\n攻击力：极高\n特点：持杆死亡自爆\n弱点：磁力菇王\n"
		},
		{
			(uint)325,
			"玩偶匣跳跳王\n僵尸等级：2\n韧性：中\n攻击力：极高\n特点：大跳\n弱点：磁力菇王\n"
		},
		{
			(uint)326,
			"惊魂玩偶匣跳跳王\n僵尸等级：3\n韧性：高\n攻击力：极高\n特点：加速大跳，自爆复活\n弱点：磁力菇王\n"
		},
		{
			(uint)321,
			"舞装战车僵尸\n僵尸等级：1\n韧性：高\n攻击力：碾压\n特点：免控\n"
		},
		{
			(uint)322,
			"轻甲舞装战车僵尸\n僵尸等级：2\n韧性：很高\n攻击力：碾压\n特点：免控，套娃\n"
		},
		{
			(uint)323,
			"重甲舞装战车僵尸\n僵尸等级：3\n韧性：极高\n攻击力：碾压\n特点：免控，套娃\n"
		},
		{
			(uint)318,
			"下界合金矿镐僵尸\n僵尸等级：1\n韧性：低\n攻击力：高\n特点：正面进攻\n弱点：击退\n"
		},
		{
			(uint)319,
			"下界合金钻僵尸\n僵尸等级：2\n韧性：中\n攻击力：很高\n特点：地下进攻\n弱点：击退\n"
		},
		{
			(uint)320,
			"武装下界合金钻僵尸\n僵尸等级：3\n韧性：高\n攻击力：极高\n特点：携带僵尸地下进攻\n弱点：击退\n"
		},
		{
			(uint)315,
			"橄榄三叉戟僵尸\n僵尸等级：1\n韧性：低\n攻击力：低\n特点：攻击最后一列\n"
		},
		{
			(uint)316,
			"碧海三叉戟僵尸\n僵尸等级：2\n韧性：中\n攻击力：高\n特点：随机攻击\n"
		},
		{
			(uint)317,
			"深海三叉戟骁将\n僵尸等级：3\n韧性：高\n攻击力：极高\n特点：散射攻击\n"
		},
		{
			(uint)300,
			"樱桃机枪学者僵尸\n僵尸等级：1\n韧性：很低\n攻击力：很高\n特点：发怒时远程打击\n"
		},
		{
			(uint)301,
			"樱桃机枪学士僵尸\n僵尸等级：2\n韧性：低\n攻击力：很高\n特点：远程打击\n"
		},
		{
			(uint)302,
			"樱桃机枪硕士僵尸\n僵尸等级：3\n韧性：中\n攻击力：极高\n特点：远程打击\n"
		},
		{
			(uint)303,
			"黑橄榄僵尸\n僵尸等级：1\n韧性：高\n攻击力：低\n特点：无\n"
		},
		{
			(uint)304,
			"黑橄榄队长\n僵尸等级：2\n韧性：很高\n攻击力：低\n特点：可回血\n"
		},
		{
			(uint)305,
			"黑橄榄副将\n僵尸等级：3\n韧性：极高\n攻击力：低\n特点：禁疗易伤，免控\n"
		},
		{
			(uint)306,
			"黑橄榄机枪副将\n僵尸等级：3\n韧性：极高\n攻击力：极高\n特点：远程射击，免控\n"
		},
		{
			(uint)307,
			"白衣舞王僵尸\n僵尸等级：1\n韧性：很低\n攻击力：低\n特点：持续召唤\n"
		},
		{
			(uint)308,
			"白衣舞王指挥官\n僵尸等级：2\n韧性：低\n攻击力：低\n特点：极速进场，召唤\n"
		},
		{
			(uint)309,
			"巡演舞王指挥官\n僵尸等级：3\n韧性：中\n攻击力：低\n特点：无视植物极速进场，大量召唤 \n"
		},
		{
			(uint)310,
			"机械舰艇僵尸\n僵尸等级：1\n韧性：很低\n攻击力：碾压\n特点：快速\n"
		},
		{
			(uint)311,
			"导弹机械舰艇僵尸\n僵尸等级：2\n韧性：低\n攻击力：极高\n特点：近程爆破\n"
		},
		{
			(uint)312,
			"冲锋机械舰艇僵尸\n僵尸等级：2\n韧性：低\n攻击力：碾压\n特点：超快速\n"
		},
		{
			(uint)313,
			"雷鸣机械潜艇僵尸\n僵尸等级：3\n韧性：中\n攻击力：极高\n特点：远程爆破\n"
		},
		{
			(uint)314,
			"雷鸣冲锋舰艇僵尸\n僵尸等级：3\n韧性：中\n攻击力：碾压\n特点：极速，使附近加速\n"
		}
	};
}
