using Il2CppTMPro;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PvZ_Fusion_Translator.AssetStore
{
	public static class StringStore
	{
		internal static Dictionary<string, string> stringsDict = [];

		public static Dictionary<string, string> translationStringRegex = new()
		{
			#if !RELEASE && !OBFUSCATE
			// UI
			{ @"-------Main UI" , "Main UI-------" },
			{ @"主菜单(.*)" , "Main Menu{0}" },
			{ @"^(\d+)轮" , "{0} Flags" },
			{ @"^开发人员名单\s+", "<size=16>Credits\r\nProgram, Director: 蓝飘飘fly\r\nAnimation: 蓝飘飘fly\r\nArtist, Visual Director: 机鱼吐司\r\nVideo Editor: 梦珞\r\nAnimation Helper: 射命丸文\r\nArt Helper: 蓝蝶</size>" },
			{ @"第(\d+)已完成" , "Level {0} Completed" },
			{ @"^确定退出吗？\s+" , "Are you sure you want to exit?\r\nProgress will not be saved!\r\nExcept for Survival Mode." },			
			{ @"下一阶段：(\d+)分(\d+)秒\s+当前水分：(\d+)/100\s+当前成长阶段：(\d+)/2\s+成长值：(\d+)/100" , "<size=40>Cooldown: {0}:{1}\nHydration: {2}/100\nStage: {3}/2\nFavorability: {4}/100" },

			// UI - Buttons
			{ @"-------UI - Buttons" , "UI - Buttons-------" },
			{ @"查看([^\s：]+)" , "View {0}" },
			{ @"返回([^\s：]+)" , "<size=34>Back to {0}" },
			{ @"回到([^\s：]+)" , "Back to {0}" },

			// UI - Playing
			{ @"-------UI - Playing" , "UI - Playing-------" },
			{ @"快捷键：(\d+)" , "<size=20>Hotkey: {0}" },
			{ @"场上敌人数量：(\d+)" , "Zombies: {0}" },
			{ @"难度：(\d+)" , "Difficulty: {0}" },

			// UI - Adventure Mode
			{ @"-------UI - Adventure Mode" , "UI - Adventure Mode-------" },
			{ @"^第(\d+)关" , "Level {0}" },
			{ @"^冒险模式(：)?(?:第)?(\d+)(?:关)?" , "Adventure Mode: Level {1}" },

			// UI - Challenge Mode
			{ @"-------UI - Challenge Mode" , "UI - Challenge Mode-------" },
			//// Advanced
			// { @"^超级([^\s+])(：|\n)?(挑战关卡|挑战)?([\d]*)?" , "{0} {2}" },
			{ @"^超级([^\s：]+)(：?挑战1?)" , "Fusion Challenge: {0}" },
			{ @"^超级随机：(无尽|模仿)" , "Odyssey Gacha\n{0}" }, // {0} = "无尽" or "模仿"
			//// Ten-Flag
			// { @"^十旗挑战([\s\n]*?(?:[\s：]))([^\s：]+)" , "Ten-Flag\n{1}" },
			{ @"^十旗挑战：([^\s]+)" , "Ten-Flag: {0}" },
			{ @"^十旗挑战\s([^\s]+)" , "Ten-Flag\n{0}" },
			//// Odyssey
			{ @"^旅行体验(：)?(?:第)?(\d+)(?:关)?" , "Odyssey\nDemo {1}" },
			//// Mini Games
			{ @"^经典塔防(\d+)?" , "ZombiesTD {0}" },
			// { @"^经典塔防([\s\n]*?(?:[\s：]))([^\s：]+)" , "ZombiesTD{0}{1}" },
			//// Garden Defense
			{ @"^花园保卫战(\d+)?" , "Garden Defense {0}" },	

			// UI - Puzzle Mode
			{ @"-------UI - Puzzle Mode" , "UI - Puzzle Mode-------" },
			{ @"^决战([^\s]+)！" , "<size=14>Ultimate Battle:\n{0}" },

			// UI - Survival Mode
			{ @"-------UI - Survival Mode" , "UI - Survival Mode-------" },
			{ @"^黑夜：([^\s]+)" , "Night\n{0}" },
			{ @"^白天：([^\s]+)" , "Day\n{0}" },
			{ @"^泳池：([^\s]+)" , "Pool\n{0}" },
			{ @"^浓雾：([^\s]+)" , "Fog\n{0}" },
			{ @"^屋顶：([^\s]+)" , "Roof\n{0}" },
			{ @"^生存(模式)?(：)([^\s]+)" , "Survival {0} \n{2}" },

			// UI - Odyssey Mode
			{ @"-------UI - Odyssey Mode" , "UI - Odyssey Mode-------" },
			{ @"^1,([^\s]+)" , "1. {0}" },
			{ @"^2,([^\s]+)" , "2. {0}" },
			{ @"^3,([^\s]+)" , "3. {0}" },
			{ @"^1、([^\s]+)" , "1. {0}" },
			{ @"^2、([^\s]+)" , "2. {0}" },
			{ @"^3、([^\s]+)" , "3. {0}" },
			{ @"^([^\s]+)1、([^\s]+)<\/color>" , "{0}1. {1}</color>" },
			{ @"^([^\s]+)2、([^\s]+)<\/color>" , "{0}2. {1}</color>" },
			{ @"^([^\s]+)3、([^\s]+)<\/color>" , "{0}3. {1}</color>" },
			{ @"^选择(\d+)" , "<size=20>Select {0}" },

			// UI - Level Editor
			{ @"-------UI - Level Editor" , "UI - Level Editor-------" },
			{ @"^设置([^\s]+)数" , "<size=15> Set {0}" },
			{ @"^允许([^\s]+)" , "<size=15>{0} - On</size>" },
			{ @"^禁用([^\s]+)" , "<size=15>{0} - Off</size>" },
			{ @"^目标场景：(6路)?([^\s]*)" , "Scene: {0} {1}" },
			{ @"^Scene： (6路)?([^\s]+)" , "Scene: {0} {1}" },
			{ @"^自定义关卡使用条款，开发者在此声明：\s+" , "<size=11>Custom Level Terms of Use, Developer's Statement:\r\nCustom levels are created by players themselves. If a map violates laws or regulations, or infringes on the rights of others, please immediately exit and delete the level. Playing the level implies that the player agrees to bear any risks and responsibilities associated with using custom levels." },
			{ @"^地图编辑器使用条款，开发者在此声明：\s+" , "<size=11>Map Editor Terms of Use, Developer's Statement:\r\nThe editor is only for normal level creation use. Any behavior that violates laws and regulations or infringes on the rights of others is strictly prohibited. Players agree to assume the risks and responsibilities associated with using the editor." },
			{ @"^按Tab切换鼠标位置格子类型\s+" , "Press Tab to switch the mouse grid type.\r\nHold A or D and move the mouse to switch to grass or dirt.\r\nPress C to save; the saved level will take effect in Custom Level." },
			{ @"^保存关卡完毕！前往自定义关卡游玩\s+" , "<size=14>Level saved successfully! Go to Custom Level to play it.\r\nYou can also share the levels you created with your friends to challenge them.\r\nThe location of the level file is as here:\r\nC:\\Users\\[Your Username]\\AppData\\LocalLow\\LanPiaoPiao\\PlantsVsZombiesRH\\CustomBlock.json</size>" },
			{ @"^保存成功，前往我是僵尸的自定义关卡游玩\s+" , "<size=14>Level saved successfully! Go to Custom Level of I, Zombie to play it.\r\nThe zombies that can be used in the level is the zombies that are currently on the loadout, and the initial Sun is the Sun currently on the level.\r\nThe name of the file level is CustomIZ.json." },
			// UI - Almanac
			{ @"^图鉴————(.*)" , "The Suburban Almanac — {0}" },
			
			// UI - Settings
			{ @"-------UI - Settings" , "UI - Settings-------" },
			{ @"当前大小：([^\s]+)" , "Current Zoom: {0}" },
			{ @"UI高度匹配：([^\s]+)" , "UI Height Match: {0}" },
			{ @"当前设置：([^\s]+)" , "Current: {0}" },
			{ @"切换全屏(\d+)\*(\d+)" , "<size=16>Screen Mode" },

			// Strings - Playing
			//// Notifications
			{ @"-------Strings - Playing" , "Strings - Playing-------" },
			{ @"升级需要(\d+)金币" , "Upgrade requires {0} Coins." },
			{ @"第(\d+)页" , "Page {0}" },
			// Strings - ZombiesTD 5
			{ @"^干得好！\s+下一个任务：(\d+)旗" , "Mission Completed\nNext Mission: Flag {0}"},
			{ @"^任务失败！\s+下一个任务：(\d+)旗" , "Mission Failed\nNext Mission: Flag {0}"},
			{ @"^任务目标：在(\d+)秒内击杀(\d+)个僵尸\s+任务奖励：究极加农炮x1" , "Current Mission: Kill {1} zombies within {0} seconds.\nCompletion Reward: Cob-livion Cannon x1" },
			{ @"^任务目标：在(\d+)秒内击杀(\d+)个僵尸\s+任务奖励：解锁全部究极植物" , "Current Mission: Kill {1} zombies within {0} seconds.\nCompletion Reward: Unlock all Odyssey Fusions" },

			{ @"-------Strings - Others" , "Strings - Others-------" },
			// { @"HP：(\d+)/(\d+)\s+一类：(\d+)/(\d+)" , "HP: {0}/{1}\nArmor: {2}/{3}" },
			// { @"HP：(\d+)/(\d+)\s+二类：(\d+)/(\d+)" , "HP: {0}/{1}\nArmor: {2}/{3}" },
			{ @"^HP：(\d+)/(\d+)\s+([^\s+])类：(\d+)/(\d+)" , "HP: {0}/{1}\nArmor: {3}/{4}" },
			{ @"^HP：(\d+)/(\d+)" , "HP: {0}/{1}" },
			// { @"平衡性调整（([^\s]+)）" , "Balance Adjustment ({0})" },
			{ @"旅行：守护 (\d+)轮已经完成" , "Odyssey: Last Stand | {0} Rounds Completed"},

			{ @"-------Strings - New Update" , "Strings - New Update-------" },
			{ @"^余额不足，购买需要：(\d+)" , "Insufficient Balance: ${0} Needed"},
			{ @"^砸罐子(\d+)" , "Vasebreaker {0}" },
			{ @"^作战植物已达上限(\d+)/(\d+)" , "Max Amount of Plants in Combat Reached: {0}/{1}" },
			{ @"^参战植物数量增加到(\d+)" , "Number of Plants in Combat Increased to {0}." },
			{ @"^距离植物休息完毕还有(\d+)秒" , "Time Until Recharged: {0} Seconds" },
			{ @"^补给已到达，参战植物数量增加到(\d+)" , "Reinforcements Are Here! Plants in Combat Increased to {0}." },
			{ @"^请按左中右的顺序放置以下植物\s+([^\s]+)，([^\s]+)，([^\s]+)" , "Please place the following plants in order\n{0}, {1}, {2}" },
			{ @"^当前分数：(\d+)" , "<size=12>Current Points: {0}" },
			{ @"^本次消耗分数：(\d+)" , "<size=12>Reroll Cost: {0}" },
			{ @"^生存模式：旅行 (\\d+)轮已经完成" , "Odyssey: Survival | {0} Rounds Completed" },
			{ @"^旅行：轮回 (\d+)轮已经完成" , "Odyssey: Reincarnation | {0} Rounds Completed"},
			{ @"^旅行：炼狱 (\d+)轮已经完成" , "Odyssey: Purgatory | {0} Rounds Completed"},
			{ @"^升级植物需要消耗(\d+)点阳光" , "Upgrading Requires {0} Sun" },
			{ @"^生存(模式)?(：)([^\\s]+) (\\d+)轮已经完成" , "Survival: {2} | {3} Flags Completed" },
			{ @"^升级植物需要消耗(\d+)阳光" , "Upgrading Requires {0} Sun" },

			{ @"^制作组名单：\s+制作人：蓝飘飘fly\s+策划：蓝飘飘fly、机鱼\s+" , " " }, // <size=16>Credits:\nProgram, Director: 蓝飘飘fly\nAnimation: 蓝飘飘fly\nArtist, Visual Director: 机鱼吐司\nVideo Editor: 梦珞\nAnimation Helper: 射命丸文\nArt Helper: 蓝蝶</size>\n\nThanks to the following friends for their help:\nBeichuang Yaowang, Lue ND, MC-Da Mai, Submarine Weiwei Fan, Rongying, Sheming Wanwen, Apostle, Tip Yangshan Muyan, Xiaohuangji, Yunyao Yoke, Zhuang Buchun
			{ @"^快捷键一览：\s+1：铲子\s+" , " "}, // Shortcut keys: \n1: Shovel\tQ: Show Plant Health\n2: Gloves\tW: Show Zombie Health\n3: Time Stop\tE: Coffee Bean\n4: Mallet\tP: Switch Kirov SFX\n\t\tV: Switch Gloves

			{ @"-------Strings - New Update v2" , "Strings - New Update 2.3.1-------" },
			{ @"^<color=red>红温</color>\s+效果：僵尸受到的伤害增加50%，且死亡时对小范围内僵尸造成100点伤害并施加红温效果\s+" , "<size=3.5><color=#720026>Enflamed</color>\nZombies take 50% more damage, and upon death, they deal 100 damage to nearby zombies and apply the Enflamed debuff.\n\n<color=#0077b6>Cryo System</color>\nZombies start with a Cryo Points cap of 100. When the accumulated Cryo Points reaches the cap, the zombie will be frozen for 4 seconds, then the cap increases by 100, up to a maximum of 400.\n\n<color=#006400>Tangled</color>\nEach time Tangled is applied, it deals extra max HP percentage damage based on the zombie’s current Tangle Value:\n6~10: 1%, 11~15: 3%, 16~29: 5%, 30+: 100%\n\n<color=#5E1675>Poison Value</color>\nA zombie’s Poison Value cap is 5. When it reaches 5, any further accumulation will put the zombie in a poisoned state, losing HP every second equal to 20 × Poison Value. If the Poison Value is at 5 and the zombie is hit by a Garlic Butter projectile, this cap will be removed.\n\n<color=yellow>Lumos Level</color>\nPlanterns provides 1 Lumos Level to all tiles in a 3x3 area. There is no cap on a tile’s Lumos Level.\n\n<color=#666699>Magnetic System</color>\nWhen a magnetic plant is within a 3x3 range of another magnetic plant, they are considered to be in the same Magnetic System." },
			{ @"^坚果台球(\d+)?" , "Wall-nut Billiards {0}" },
			{ @"^旅行冒险：第(\d+)关" , "Odyssey Adventure: Level {0}" },
			{ @"^剩余积分：(\d+)点" , "Remaining Points: {0}" },
			{ @"^但(.*)" , "Odyssey Negative Modifier | {0}" },
			{ @"^成功击败领袖，获得(\d+)积分" , "Supreme Zombie successfully defeated. You have earned {0} Points." },
			{ @"^大招需要(\d+)金币" , "Using the Ultimate requires {0} Coins." },


			{ @"-------Outdated Regex Below" , "You Can Safely Ignore or Delete-------"},
			#endif
		};

		public static Dictionary<string, string> translationString = new()
		{
			#if !RELEASE && !OBFUSCATE
			// UI - Main Menu
			{ "-------UI - Main Menu" , "UI - Main Menu-------" },
			{ "游戏完全免费，点击这里关注作者蓝飘飘fly，获取最新更新动态" , "The game will always be free————click here to follow the author LanPiaoPiaoFly!" },
			{ "点击这里关注画师机鱼吐司" , "Click here to follow the artist Gfishtus!" },
			// { "屋顶测试版（上半）" , " " }, // <size=18>discord.gg/FTfz45NGxh
			{ "屋顶测试版（中）" , " " },
			{ "设置" , "Settings" },

			// UI - Settings
			{ "-------UI - Settings" , "UI - Settings-------" },
			{ "手机版可能导致画质降低\n重启恢复" , "Click to change to Windowed Mode or Fullscreen." },
			// { "一键通关泳池版本" , "<size=16>Clear Pool Levels" },
			{ "一键通关冒险模式" , "<size=14>Clear\nAdventure Levels" },
			{ "一键通关所有关卡" , "<size=16>Clear All levels" },
			{ "重置所有关卡" , "<size=16>Reset All Levels" },
			{ "再按一次确定" , "Press Again" },
			{ "调整相机投影大小" , "<size=16>Camera Zoom" },
			{ "修改画布匹配" , "<size=16>Canvas Size" },
			// { "诸神是否需要手套" , "Does 'The Gods' need Gloves?" },
			{ "诸神移动植物方式" , "The Gods: Playing Method"},
			{ "当前方式：用手套" , "<size=12>Current: Manual\nUse Gloves" },
			{ "当前方式：点击即可" , "<size=12>Current: Automatic\nUse Click" },
			{ "关卡内教学" , "<size=16>Level Tutorials"},
			{ "大麦植物变色" , "<size=14>Barley Color Changes" },
			{ "关闭" , "Disabled" },
			{ "开启" , "Enabled" },

			// UI - Buttons
			{ "-------UI - Buttons" , "UI - Buttons-------" },
			{ "其它" , "Other" },
			{ "确定" , "OK" },
			{ "接受" , "Accept" },
			{ "返回" , "Return" },
			{ "合上" , "Close" },
			{ "取消" , "Cancel" },
			{ "暂停" , "Pause" },
			{ "退出" , "Exit"},
			{ "下一页" , "Next" },
			{ "上一页" , "Previous" },
			{ "再次尝试" , "Try Again" },
			{ "游戏结束" , "Game Over" },
			{ "回到索引" , "Return to Index" },
			{ "重新开始这一轮\n（生存模式专用）" , "Restart the Round\n(Survival Mode Only)" }, // Game Over
			{ "选卡界面" , "Plant Select" }, // Equal Exchange

			// UI - Other

			{ "挑战" , "Challenge" },

			// UI - Plant Select
			{ "-------UI - Plant Select" , "UI - Plant Select-------" },
			{ "选择你的植物" , "<size=20>Choose Your Plants" },
			{ "一起摇滚吧！" , "<size=20>Let's Rock!" },
			{ "重选上次卡牌" , "Select Previous Loadout" },

			// UI - Playing
			{ "-------UI - Playing" , "UI - Playing-------" },
			{ "开始战斗" , "Start Round" },
			{ "时停" , "Slow Mode" },

			// UI - Options
			{ "-------UI - Options" , "UI - Options-------" },
			{ "主菜单" , "Main Menu" },
			{ "查看图鉴" , "Open Almanac" },
			{ "重新开始" , "Restart" },
			{ "确定重新开始吗？" , "Are you sure\nyou want to restart?" },
			{ "返回游戏" , "Resume" }, // Resume
			{ "音乐" , "<size=20>BGM" },
			{ "音效" , "<size=20>SFX" },
			{ "简单模式" , "<size=20><color=#00C853>Easy Mode" },
			{ "普通模式" , "<size=20><color=#64DD17>Casual Mode" },
			{ "正常模式" , "<size=20><color=#AEEA00>Normal Mode" },
			{ "困难模式" , "<size=20><color=#FFD600>Veteran Mode" },
			{ "极难模式" , "<size=20><color=#FF6D00>Merciless Mode" },
			{ "你确定？" , "<size=20><color=#D50000>Are You Sure?" },
			{ "游戏速度" , "<size=20>Game Speed" },

			// UI - I, Zombie
			{ "-------UI - I, Zombie" , "UI - I, Zombie-------" },
			{ "开启斗蛐蛐" , "Start Fight" },
			{ "自选僵尸卡牌" , "Pick Zombies"},
			{ "一键全选", "Quick Select" },
			{ "保存为自定义阵容" , "Save for Custom Level"},
			{ "自选植物卡牌" , "Pick Plants" },
			{ "平衡性调整（开）" , "Balance Adjustment - On" },
			{ "平衡性调整（关）" , "Balance Adjustment - Off" },
			{ "全自动斗蛐蛐" , "Automatic Fight" },
			{ "填充随机植物" , "Random Fill" },
			{ "加载植物阵容" , "Load Plant Setup" },
			{ "保存植物阵容" , "Save Plant Setup" },
			{ "开始/关闭出怪" , "On/Off Spawn" },

			// UI - Back to _ // UI - Almanac
			{ "-------UI - Back to _" , "UI - Back to _-------" },
			{ "索引" , "Index" },
			{ "植物" , "Plants" },
			{ "僵尸" , "Zombies" },
			{ "菜单" , "Menu" },

			// UI - Almanac
			{ "-------UI - Almanac" , "UI - Almanac-------" },
			{ "更多" , "Other" },
			{ "超级" , "Adv."},
			{ "究极" , "Odys." },

			// UI - Zen Garden
			{ "-------UI - Zen Garden" , "UI - Zen Garden-------" },
			{ "禅境花园" , "<size=26>Zen Garden" },
			{ "帮助" , "Info" },
			{ "将植物挪到最下面一行为花园保卫战的出战区，使用培养的植物战斗吧！\n使用手套可以融合植物，但只能融合长大以后的植物\n快捷键123456等为对应左上角的道具" , "Fully grown plants in the bottom row of the first page are used for Garden Defense.\nUse the Gloves to fuse fully grown plants.\nUse (1-7) as Hotkeys for the Garden Tools." },
			{ "请先将手推车中的植物放下" , "Please put down the plant in your Wheelbarrow first."},
			{ "你确定要移除该植物吗" , "Are you sure you want to remove this plant?"},

			// UI - Level Editor
			{ "-------UI - Level Editor" , "UI - Level Editor-------" },
			{ "修改格子只对大地图有效" , "Grid modification is only\neffective for Large Maps." },
			{ "请选择禁用的植物" , "<size=20>Choose Plants to Disable" },
			{ "阳光" , "Starting Sun" },
			{ "旗帜" , "Flags" },
			{ "前往设置僵尸" , "Set Zombies" },
			{ "坚不可摧" , "Last Stand" },
			{ "旅行植物" , "Odyssey Plants" },
			{ "旅行词条" , "Odyssey Modifiers" },
			{ "更换场景" , "Change Scene" },
			{ "保存关卡" , "Save Level" },
			{ "大地图" , "Large Map" },
			{ "6路" , "6 Lane" },
			{ "绿幕" , "Green Screen" },
			{ "加入出怪(Q)" , "Add (Q)" },
			{ "移除出怪(W)" , "Remove (W)" },
			{ "允许排山倒海" , "<size=14>Column Planting - On</size>" },
			{ "禁用排山倒海" , "<size=14>Column Planting - Off</size>" },
			{ "允许种子雨" , "<size=15>Seed Rain - On</size>" },
			{ "禁用种子雨" , "<size=15>Seed Rain - Off</size>" },
			{ "允许胆小菇之梦" , "<size=14>Scaredy's Dream - On</size>" },
			{ "禁用胆小菇之梦" , "<size=14>Scaredy's Dream - Off</size>" },
			{ "允许超级随机" , "<size=14>Advanced Gacha - On</size>" },
			{ "禁用超级随机" , "<size=14>Advanced Gacha - Off</size>" },

			// UI - Large Maps
			{ "-------UI - Large Maps" , "UI - Large Maps-------" },
			{ "切换鼠标反转" , "Invert Mouse" },
			{ "更改屏幕缩放" , "Zoom" },
			{ "切换小地图" , "Minimap" },
			{ "可以优化性能" , "<size=14>Impacts Performance</size>" },

			// UI - Modes	
			{ "-------UI - Modes" , "UI - Modes-------" },
			{ "冒险模式" , "Adventure Mode" },
			{ "挑战模式" , "Challenge Mode" },
			{ "解谜模式" , "Puzzle Mode" },
			{ "生存模式" , "Survival Mode" },

			// UI - Challenge Mode
			{ "-------UI - Challenge Mode" , "UI - Challenge Mode-------" },
			{ "高级挑战" , "Fusion Challenge" },
			{ "十旗挑战" , "Ten-Flag\nChallenge" },
			{ "迷你游戏" , "Mini Games" },
			{ "花园保卫战" , "Garden Defense" },

			// UI - Fusion Challenge
			{ "-------UI - Fusion Challenge" , "UI - Fusion Challenge-------" },
			{ "挑战关卡" , "Challenge" },			
			{ "超级樱桃射手\n挑战关卡" , "<size=12> Explod-o-shooter</size>\nChallenge" },
			{ "樱桃射手" , "Explod-o-shooter" },
			{ "超级大嘴花\n挑战关卡" , "<size=12>Chewzilla</size>\nChallenge" },
			{ "大嘴花" , "Chewzilla" },
			{ "超级魅惑菇\n挑战关卡" , "<size=12>Charm-shroom</size>\nChallenge" },
			{ "魅惑菇" , "Charm-shroom" },			
			{ "超级大喷菇\n挑战关卡" , "<size=12>Doomberg-shroom</size>\nChallenge" },
			{ "大喷菇" , "Doomberg-shroom" },
			{ "超级火炬\n挑战关卡" , "<size=12>Infernowood</size>\nChallenge" },
			{ "火炬" , "Infernowood" },
			{ "超级窝草\n挑战关卡" , "<size=12>Krakerberus</size>\nChallenge" },
			{ "窝草" , "Krakerberus" },			
			{ "超级南瓜\n挑战关卡" , "<size=12>Bloverthorn Pumpkin</size>\nChallenge" },
			{ "南瓜" , "Bloverthorn Pumpkin" },
			{ "超级杨桃\n挑战关卡" , "<size=12>Stardrop</size>\nChallenge" },
			{ "杨桃" , "Stardrop" },
			{ "超级投手\n挑战关卡" , "<size=12>Salad-pult</size>\nChallenge" },
			{ "投手" , "Salad-pult" },
			{ "超级伞\n挑战关卡" , "<size=12>Alchemist Umbrella\nChallenge" },
			{ "伞" , "Alchemist Umbrella" },

			// UI - Ten Flag Challenge
			{ "-------UI - Ten-Flag Challenge" , "UI - Ten-Flag Challenge-------" },
			// Ten-Flag Day
			// Ten-Flag Night
			// Ten-Flag Pool
			// Ten-Flag Fog
			// Ten-Flag Roof
			{ "随机僵尸" , "Zombie Gacha" },
			{ "植物僵尸" , "Zombotany" },
			{ "黑夜舞会" , "Night Disco" },
			// Ten-Flag Scaredy's Dream
			{ "随机植物" , "Plant Gacha" },
			{ "等价交换" , "Equal Exchange" },
			{ "全员随机" , "Multi Gacha" },
			{ "随机植物VS随机僵尸" , "Plant Gacha vs Zombie Gacha" }, // In-Game

			// UI - Mini Games
			{ "-------UI - Mini Games" , "UI - Mini Games-------" },
			{ "胆小菇之梦" , "Scaredy's Dream" }, // Custom Level
			{ "撑杆舞会" , "Pole Vaulting\nDisco" },
			{ "合理密植" , "Compact\nPlanting" },
			{ "二爷战争" , "Newspaper\nWar" },
			{ "泳池激斗" , "Pool Battle" },
			// ZombiesTD 1
			// ZombiesTD 2
			{ "套娃" , "Matryoshka" },
			{ "全是套娃" , "Matryoshka" }, // In-Game
			{ "排山倒海" , "Columns Like\nYou See 'Em" },
			{ "镜像" , "Mirrors Like\nYou See 'Em" },
			{ "你看，他们像镜子一样" , "Mirrors Like You See 'Em" }, // In-Game
			{ "种子雨" , "It's Raining\nSeeds" }, // Custom Level
			{ "谁能笑到最后" , "Last Stand" },
			{ "空袭" , "Air Raid" },
			{ "10.0版本前瞻\n超级预览版" , "<size=12>Advanced Challenge\n12-Lane Day</size>" },
			{ "10.1版本前瞻\n超级预览版" , "<size=12>Advanced Challenge\n12-Lane Pool</size>" },
			{ "超级白天" , "Advanced Challenge: 12-Lane Day" }, // In-Game
			{ "超级泳池" , "Advanced Challenge: 12-Lane Pool" }, // In-Game
			// ZombiesTD 3
			{ "关卡编辑器" , "Level Editor" },
			{ "自定义关卡" , "Custom Level" },
			{ "艺术就是爆炸" , "True Art is\n an Explosion!" },
			{ "跳跳舞会" , "Pogo Party!" },
			{ "巨人之怒" , "Attack on\nGargantuar!" },
			{ "祖玛保龄球" , "Zum-nut!" },
			{ "严肃窝瓜" , "Squash Showdown!"},
			{ "魅惑坚果" , "Hypno-tism!" },
			{ "保卫吸金磁" , "Protect the \nGold Magnet" },
			{ "合理密植2" , "Compact Planting 2" },
			
			// UI - Puzzle
			{ "-------UI - Puzzle" , "UI - Puzzle-------" },
			{ "我是僵尸！" , "<size=14>I, Zombie" },
			{ "我也是僵尸！" , "<size=14>I, Zombie Too" },
			{ "你能吃了它吗！" , "<size=14>All You\nCan Quaff" },
			{ "雷区！" , "<size=14>Mine Field" },
			{ "完全傻了！" , "<size=14>Totally Nuts" },
			// Ultimate Battle: Day
			{ "卑鄙的低矮植物！" , "<size=14>Huff 'n Puff" },
			{ "QQ弹弹！" , "<size=14>Extra Bouncy" },
			{ "当代女大学生！" , "<size=14>Mushroom's\nDay Out" },
			{ "胆小菇前传！" , "<size=14>Scaredy-shroom\nPrequel" },
			{ "冰冻关卡！" , "<size=14>Frozen Level" },
			// Ultimate Battle: Night
			{ "初见泳池！" , "<size=14>First Look\nat the Pool" },
			{ "三三得九！" , "<size=14>3 Times 3\nEquals 9" },
			{ "嗯？" , "<size=14>Hmmm?" },
			{ "尸愁之路！" , "<size=14>Rough Road" },
			{ "严肃火炬！" , "<size=14>Forest Fire" },
			{ "决战泳池！" , "<size=14>Ultimate Battle:\nPool" },
			{ "你是僵尸！" , "<size=14>U, Zombie" }, // In-Game
			{ "你是僵尸" , "<size=14>U, Zombie" },
			{ "你也是僵尸！" , "<size=14>U, Zombie Too" },
			{ "看星星！" , "<size=14>Seeing Stars" },
			{ "万磁王！" , "<size=14>Magneto" },
			{ "十面埋伏！" , "<size=14>Absolute Ambush" },
			{ "马奇诺防线！" , "<size=14>Maginot Line" },
			{ "攻守兼备！" , "<size=14>The Best Defense\nis a Good Offense" },
			{ "势不可挡！" , "<size=14>Unstoppable" },
			{ "自定义！" , "Custom Level" }, // I Zombie

			// UI - Survival
			{ "-------UI - Survival" , "UI - Survival-------" },
			{ "困难" , "Hard" },
			{ "无尽" , "Endless" },
			{ "（困难）" , "(Hard)" },
			{ "（无尽）" , "(Endless)" },
			{ "白天（困难）" , "Day (Hard)" },
			{ "黑夜（困难）" , "Night (Hard)" },
			{ "泳池（困难）" , "Pool (Hard)" },
			{ "浓雾（困难）" , "Fog (Hard)" },
			{ "屋顶（困难）" , "Roof (Hard)" },
			{ "泳池（无尽）" , "Pool (Endless)" },
			{ "白天（无尽）" , "Day (Endless)" },
			{ "黑夜（无尽）" , "Night (Endless)" },
			{ "浓雾（无尽）" , "Fog (Endless)" },
			{ "屋顶（无尽）" , "Roof (Endless)" },
			{ "白天" , "Day" },
			{ "黑夜" , "Night" },
			{ "泳池" , "Pool" },
			{ "旅行" , "Odyssey" },
			{ "浓雾" , "Fog" },
			{ "屋顶" , "Roof" },
			{ "无尽塔防" , "Endless\nZombiesTD" },

			// UI - Odyssey Mode
			{ "-------UI - Odyssey Mode" , "UI - Odyssey Mode-------"},
			{ "究极模式" , "The Odyssey" }, 
			{ "--- OM - Category" , "OM - Category ---"},
			{ "旅行模式" , "Odyssey Mode" },
			{ "随机模式" , "Odyssey Gacha" }, // Category
			{ "旅行体验" , "Odyssey Demo" },
			// Mini Games
			{ "--- OM - Odyssey Mode" , "OM - Odyssey Mode ---" },
			{ "旅行：生存" , "Odyssey\nSurvival" },
			{ "旅行：守护" , "Odyssey\nLast Stand" },
			// { "旅行：炼狱" , "Odyssey\nPurgatory" },
			{ "--- OM - Odyssey Gacha" , "OM - Odyssey Gacha ---" },
			{ "随机塔防" , "Randomized\nZombiesTD" },
			{ "超级随机" , "Odyssey Gacha" }, // Level
			{ "十旗挑战\n究极随机" , "Odyssey Gacha\n12-Lane" }, // 12-Lane
			{ "等价交换2" , "Equal Exchange 2" },
			{ "超级传送带" , "Arsenal Delivery" },
			{ "大麦之战" , "Barley Battle!" },
			// Odyssey Gacha - Endless
			{ "模仿" , "Imitater" },
			{ "真正的超级随机" , "Odyssey Gacha\nUnleashed" },
			{ "大麦之战2\n拆拆乐" , "Barley Battle 2!\nFission" },
			{ "大麦之战2：拆拆乐" , "Barley Battle 2! Fission" },
			// Odyssey Demo
			{ "--- OM - Mini Games" , "OM - Mini Games ---" },
			{ "诸神" , "The Gods" },
			{ "诸神：升级" , "The Gods: Trial of Ascension" }, // In-Game
			{ "诸神2" , "The Gods 2" },
			{ "诸神：末世重生" , "The Gods: Trial of Rebirth" }, // In-Game
			{ "末世重生" , "The Gods 2" }, // Ten-Flag String
			// ZombiesTD 4
			{ "阳光保龄球" , "Solar-nut Bowling" },
			// ZombiesTD 5
			{ "诸神3" , "The Gods 3" },
			{ "诸神：坚如磐石" , "The Gods: Trial of Endurance" },
			{ "黑曜石巨人的复仇" , "<size=12>Abyssal Gargantuar's\n Vengeance" },
			{ "黑曜石武装巨人的复仇" , "Abyssal Gargantuar's Vengeance"},
			{ "诸神：全军出击" , "The Gods\nPantheon" },

			// UI - Odyssey Gameplay
			{ "-------UI - Odyssey Gameplay" , "UI - Odyssey Gameplay-------" },
			{ "刷新选项" , "Reroll" },
			{ "放弃增益" , "<size=20>Skip" },
			{ "增益" , "Modifiers" },
			{ "当前增益" , "Current Modifiers" },

			// Strings - Adventure Mode
			{ "-------Strings - Adventure Mode" , "Strings - Adventure Mode-------" },
			{ "--- AM - Old Version" , "AM - Old Version ---" },
			{ "试试把豌豆种到向日葵上面" , "Try planting Peashooters on top of Sunflowers." },
			{ "手里拿着植物时可以融合的植物会发光" , "Plants eligible for fusion will glow when you're holding another plant." },
			{ "坚果融合后可以回满血哦" , "When Wall-nuts are fused, their Toughness is restored." },
			{ "手套可以自由移动或融合植物" , "Gloves can be used to move or fuse plants manually." },
			{ "礼盒可开出基础植物，亦可作为任意基础植物进行融合" , "Plant Giftbox can spawn basic plants.\nIt can also be used as any basic plant for fusion." },
			{ "僵尸掉落的铁桶可以放到豌豆射手和坚果墙上" , "The buckets dropped by zombies \ncan be placed on the Peashooters and Wall-Nuts." },
			{ "高坚果作为紫卡只能放在坚果墙上" , "Tall-nuts can only be planted on top of existing Wall-nuts." },
			{ "一个格子里可以放3个小喷菇" , "You can stack upto three Puff-shrooms in one grid." },
			{ "小秘密：小喷菇+向日葵=阳光菇" , "Try to use Sun-shrooms instead of Sunflowers in this map.\nFusion Formula: Puff-shrooms + Sunflower = Sun-shroom" },
			{ "肥料可用于给植物回血，更多用法自行探索" , "Fertilizer can be used to restore plants' Toughness.\nThere are other uses you can explore." },
			{ "毁灭大喷菇要手动点击哦" , "You can make a Soot-shroom by fusing a Fume-shroom and Doom-shroom.\nTo make Soot-shroom attack, you need to click it manually." },
			{ "橄榄帽可以放到高坚果上" , "Football Helmets can be placed on Tall-Nuts." },
			{ "忧郁菇作为紫卡只能放在大喷菇上" , "Gloom-shrooms can only be planted on top of existing Fume-shrooms." },
			{ "听说了吗？有的睡莲头上会长植物" , "Have you heard that Lily Pad can have plants grow on their heads?" },
			{ "传说有些僵尸被刺红温了更容易受伤" , "Legend has it that some zombies are \nmore vulnerable to damage when they look red...\nTry fusing a Scorchweed to inflict the Enflamed debuff." },
			{ "地刺王作为紫卡只能放在地刺上" , "Spikerocks can only be planted on top of existing Spikeweed." },
			{ "海光菇的效率似乎比阳光菇还要高" , "Sea Sun-shroom, when fully grown, can release 50 Suns per output.\nTry planting a couple or more to boost your efficiency." },
			{ "猫尾草作为紫卡只能放在睡莲上" , "Cattail can only be planted on top of existing Lily Pads." },
			{ "路灯花会为周围3*3范围格子提供1点光照等级" , "Plantern can provide 1 Lumos Level in a 3x3 Grid."}, 
			{ "光系植物随着所在格子的光照等级增加而变强" , "Lumos plants become stronger as the Lumos Level of the grid they are on increases." },
			{ "木锤会送一只僵尸归西" , "The Mallet can send a group of zombies towards their doom." },
			{ "试试将磁力菇吸到的物体放到磁力南瓜或磁力杨桃上" , "Try placing the objects attracted by the Magnet-shroom\nonto the Pumpkin Lure or Starlure." },
			{ "注意到磁力菇边上白色的线了吗，将他们都连起来" , "Did you notice the white lines next to the Magnet-shroom? Connect them all together\n to strengthen some of your Magnet-shroom fusions." },
			{ "使用金盏花赚钱！对金银植物使用咖啡豆吧！花钱也送阳光！" , "Use Marigolds to earn money!\nUse Coffee Beans on Gold and Silver Plants!\nSpending Coins earns you Sun!" },	
			{ "--- AM - New Version" , "AM - New Version ---" },
			// Level 1
			{ "--- AM - Level 1" , "AM - Level 1 ---" },
			{ "欢迎来到植物大战僵尸融合版。" , "Welcome to Plants vs. Zombies Fusion" },
			{ "这里有着许多有趣的新植物和新玩法。" , "There are many interesting new plants and new ways to play here." },
			{ "让我们先从资源获取开始吧！" , "Let’s start with resource acquisition!" },
			{ "请先种下一株向日葵。" , "Please plant a Sunflower first." },
			{ "向日葵是很重要的生产植物，未来的阳光资源都靠她了！\n现在，试着把豌豆种到向日葵上" , "Sunflowers are very important Sun producers.\nNow try planting a Peashooter on top of the Sunflower." },
			{ "很好，你已经学会了融合版最基础的操作！\n现在试试融合一个机枪射手！在豌豆上不断种豌豆就好！" , "Very good, you have learned the most basic operation of PvZ Fusion!\nNow try to fuse a Gatling Pea! Just keep planting Peashooters on top of another Pea." },
			{ "干得不错！种植更多的植物，抵御僵尸的入侵吧！" , "Good job! Grow more plants to resist the invasion of zombies!" },
			// Level 4
			{ "--- AM - Level 4" , "AM - Level 4 ---" },
			{ "恭喜你解锁了手套，这是非常重要的道具" , "Congratulations on unlocking the Gloves, this is a very important item." },
			{ "使用手套可以挪动植物，也可以使用手套挪动植物进行融合" , "You can use the Gloves to move plants somewhere else, or move a plant over another plant to initialize fusion." },
			{ "现在试试将这个双子向日葵移动到坚果后面去" , "Now try moving the Twin Sunflowers behind the Cherry-nut." },
			{ "你已经学会使用手套了！种植更多的植物，抵御僵尸的入侵吧！" , "You've learned how to use the Gloves! Grow more plants to resist the invasion of zombies!" },
			// Level 7
			{ "--- AM - Level 7" , "AM - Level 7 ---" },
			{ "礼盒，能开出全部的基础植物" , "The Plant Giftbox can produce all basic plants." },
			{ "现在试试将礼盒放到这个双发射手上" , "Now try putting the Plant Giftbox on this Repeater." },
			{ "你已经学会了如何使用礼盒！让我们进行下一步吧！" , "You've learned how to use the Plant Giftbox! Let’s move on to the next step!" },
			{ "注意看1路有一个樱桃读报僵尸！用樱桃坚果防御他的子弹吧！" , "Pay attention to the Cherryshooter Newspaper Zombie on the first row!\nDefend against his bullets with Cherry-nuts!" },
			{ "干得好！种植更多的植物，抵御僵尸的入侵吧！" , "Well done! Grow more plants to resist the zombie invasion!" },
			// Level 8
			{ "--- AM - Level 8" , "AM - Level 8 ---" },
			{ "你是否想过把僵尸的装备放到植物身上？" , "Have you ever thought about putting zombie equipment on plants?" },
			{ "击败1路这个铁桶坚果僵尸！注意不要使用樱桃炸弹和大嘴花！" , "Defeat this Buck-nut Zombie by using peas! Be careful not to use Cherry Bombs and Chompers!" },
			{ "点击僵尸掉落的铁桶，放到豌豆射手或者坚果墙上吧！" , "Click on the Iron Bucket dropped by the zombie and place it on the Peashooter or Wall-nut!" },
			{ "铁系植物！你前期的好伙伴！" , "It's an Iron plant! A good partner in the early stage!" },
			{ "种植更多的植物，抵御僵尸的入侵吧！" , "Excellent! Grow more plants to resist the zombie invasion!" },
			// Level 10
			{ "--- AM - Level 10" , "AM - Level 10 ---" },
			{ "小喷菇是黑夜里十分重要的植物" , "The Puff-shroom is a very important plant in this dark night..." },
			{ "往小喷菇聚落里面融合可以直接得到3个小喷菇的融合体" , "You can get a fusion of 3 Puff-shrooms by fusing into a Puff-shroom stack." },
			// Level 13
			{ "--- AM - Level 13" , "AM - Level 13 ---" },
			{ "你解锁了肥料，定期在地图左上角出现" , "You unlocked the Fertilizer, which appears periodically in the upper left corner of the map." },
			{ "肥料可以让阳光菇立即长大" , "Fertilizers can make the Sun-shroom grow immediately." },
			{ "可以让大嘴花立即吞咽" , "It also enables Chomper and its fusions to swallow instantly, allowing them to eat another zombie right away." },
			{ "总之肥料总是可以让植物进入下一阶段" , "In short, the Fertilizer always allows plants to progress to the next stage." },
			{ "这里有一个坚果墙，试试给他肥料会有什么效果" , "Here's a Wall-nut, try giving it a Fertilizer to see what happens." },
			{ "肥料可以充当紫卡的作用，直接升级一些植物" , "Fertilizers can act as a purple card, directly upgrading certain plants." },
			{ "现在试试用肥料点击这个大嘴坚果" , "Now try using Fertilizer on this Chomp-nut." },
			{ "肥料可以给植物回满血" , "Fertilizer can fully restore a plant's Toughness." },
			// Level 15
			{ "--- AM - Level 15" , "AM - Level 15 ---" },
			{ "让我们来看看寒冰系的新功能：冻结值" , "Let's take a look at the mechanics of the Cryo System: Cryo Points" },
			{ "寒冰类植物的攻击都会附带冻结值\n当冻结值满时僵尸会被冻结并清空冻结值，冻结的僵尸受到寒冰类子弹的伤害都将x4" , "Ice-type plants' attacks will add Cryo Points to the Cryo Value. \r\nWhen the Cryo Value is full, zombies will be inflicted with the Frozen debuff and the Cryo Value will be reset. \r\nFrozen zombies will take x4 damage from ice-type projectiles." },
			{ "僵尸的冻结值上限会随着冻结次数的增加而增加" , "The Cryo Value threshold of zombies will increase with each Frozen debuff inflicted.\r\n The first threshold is 100 Cryo Points, the next will be 200, then 300, then 400.\r\n The max threshold is 400 Cryo Points." },
			// Level 22
			{ "--- AM - Level 22" , "AM - Level 22 ---" },
			{ "水草子弹是水路中最强大的子弹" , "Kelps are the most powerful bullets in the water lanes." },
			{ "让我们来看看这个一百万血的机械海豚僵尸是怎么被轻松干掉的" , "Let's see how this one million health Zombarine is easily taken down." },
			{ "水草子弹命中水里的僵尸会造成额外的百分比伤害\n击中30次以上会直接秒杀僵尸！" , "Kelps deal additional percentage damage to zombies in the water.\r\nHitting more than 30 times will instantly kill the zombie!" },
			// Level 24
			{ "--- AM - Level 24" , "AM - Level 24 ---" },
			{ "让我们来看看僵尸的一种新状态：红温" , "Let's take a look at the mechanics of a new zombie debuff: Enflamed." },
			{ "当僵尸处于红温状态时会额外受到50%的伤害" , "When a zombie is inflicted with the Enflamed debuff, it will take an additional 50% damage." },
			{ "红温的僵尸死亡时会对附近的僵尸造成100点伤害并传递红温效果" , "When an Enflamed zombie dies, it will deal 100 damage to nearby zombies and spread the Enflamed debuff." },
			// Level 30
			{ "--- AM - Level 30" , "AM - Level 30 ---" },
			{ "路灯花在这里发挥着比原版更强大的作用" , "The Plantern plays a more powerful role here than in the original version." },
			{ "让我们来看看路灯花的新系统：光照系统" , "Let's take a look at the new system for the Plantern: the Lumos System." },
			{ "路灯花会以自己为中心3x3范围的格子提供1点光照等级" , "The Plantern provides 1 Lumos Level in a 3x3 grid centered around itself." },
			{ "路灯花的融合植物在路灯花的影响下会变得更加强大" , "The fused plants of the Plantern become even stronger under its influence." },
			{ "光照越高，植物就越强，一般的光系植物在3点光照等级达到最强状态" , "The higher the Lumos Level, the stronger the plant. Most light-based plants reach their maximum strength at 3 Lumos Levels." },
			{ "光系植物在路灯花的影响下会变得更加强大，种植更多的植物，抵御僵尸的入侵吧！" , "Plantern-based fusions become even stronger under the influence of the Plantern.\nPlant more to fend off the zombie invasion!" },
			// Level 35
			{ "--- AM - Level 35" , "AM - Level 35 ---" },
			{ "让我们来看看磁力菇带来的新系统\n磁力系统" , "Let's take a look at the new system brought by the Magnet-shroom: the Magnetic System." },
			{ "如果一株磁性植物周围8格有另一株磁性植物\n则称两个植物处于同一个磁力系统中，并且中间会有白线连接" , "If a magnetic plant has another magnetic plant within the 8 surrounding tiles, \r\nthey are considered to be in the same magnetic system, and a white line will connect them." },
			{ "同一个磁力系统中的植物是可以无限多的\n只需任意一株植物满足要求都可以纳入系统中" , "Plants within the same magnetic system can be unlimited in number. \r\nAs long as any plant meets the requirements, it can be included in the system." },
			{ "只要磁力链没有断开，都看成在是同一个磁力系统中" , "As long as the magnetic chain remains unbroken, all plants are considered to be in the same magnetic system." },
			{ "但是如果没有相连，那就是另一个磁力系统" , "However, if they are not connected, they belong to a different magnetic system." },
			{ "你可以在中间补充一些植物将两个系统连起来" , "You can place plants in between to connect the two systems." },
			{ "部分植物如超级杨桃等会受到磁力系统的影响\n种植更多的植物，抵御僵尸的入侵吧！" , "Some plants, such as Stardrop, will be buffed by the magnetic system. \r\nPlant more to defend against the zombie invasion!" },
			// Level 42
			{ "--- AM - Level 42" , "AM - Level 42 ---" },
			{ "让我们来看看金盏花带来的新系统\n金钱系统" , "Let’s take a look at the new system brought by Marigold: the Money System." },
			{ "种植金盏花会在屏幕左下角启用钱币" , "Planting Marigolds will activate coins in the bottom-left corner of the screen." },
			{ "赚的钱可以对银植物升级\n点击屏幕左下角的咖啡豆，对卷心菜使用吧" , "The money earned can be used to upgrade Silver Plants.\r\nClick on the coffee bean (or use the hotkey) in the bottom-left corner of the screen to use it on the Cabbage-Pult." },
			{ "升级时植物会释放一次大招，给予金植物也可以释放大招\n同时每次花钱都能赠送阳光！" , "When upgrading, plants will unleash an ultimate, and Golden Plants can also unleash their ultimate.\r\nAdditionally, every time you spend money, you will receive Sun as a bonus!\r\nEach 500 coins spent will give 25 Suns." },
			{ "在金盆上给植物释放大招时会根据花费联动其他金盆上的植物释放大招\n现在试试给金玉米投手释放大招" , "When releasing an ultimate on the Golden Pot,\r\nit will trigger the ultimates of other plants on nearby Golden Pots based on the cost.\r\nNow, let's try using the ultimate on the Golden Kernel!" },

			// Strings - Advanced Challenge
			{ "-------Strings - Advanced Challenge" , "Strings - Advanced Challenge-------" },
			{ "豌豆+樱桃+樱桃" , "Unlock Explod-o-shooter when you finish the challenge.\nFusion Formula: Peashooter + Cherry Bomb + Cherry Bomb" },
			{ "豌豆+坚果+大嘴花" , "Unlock Chewzilla when you finish the challenge.\nFusion Formula: Peashooter + Wall-Nut + Chomper" },
			{ "大喷菇+胆小菇+魅惑菇" , "Unlock Charm-shroom when you finish the challenge.\nFusion Formula: Fume-shroom + Scaredy-shroom + Hypno-shroom" },
			{ "火炬+辣椒+辣椒" , "Unlock Infernowood when you finish the challenge.\nFusion Formula: Torchwood + Jalapeno + Jalapeno" },
			{ "水草+窝瓜+三线" , "Unlock Krakerberus when you finish the challenge.\nFusion Formula: Tangle Kelp + Squash + Threepeater" },
			{ "大喷菇+寒冰菇+毁灭菇" , "Unlock Doomberg-shroom when you finish the challenge.\nFusion Formula: Fume-shroom + Ice-shroom + Doom-shroom" },
			{ "杨桃+路灯花+磁力菇" , "Unlock Stardrop when you finish the challenge.\nFusion Formula: Starfruit + Plantern + Magnet-shroom" },
			{ "仙人掌+南瓜+三叶草" , "Unlock Bloverthorn Pumpkin when you finish the challenge.\nFusion Formula: Cactus + Pumpkin + Blover" },
			{ "西瓜+卷心菜+玉米" , "Unlock Salad-pult when you finish the challenge.\nFusion Formula: Cabbage-pult + Kernel-pult + Melon-pult" },
			{ "金伞+大蒜或金蒜+伞" , "Unlock Alchemist Umbrella when you finish the challenge.\nFusion Formula:\nGolden Umbrella + Garlic OR Golden Garlic + Umbrella Leaf" },

			// Strings - Odyssey Demo
			{ "-------Strings - Odyssey Demo" , "Strings - Odyssey Demo-------" },
			{ "小心你没见过的僵尸！" , "Let's do a showcase of the first five Odyssey Plants of the game!\nBe careful of new zombies that you haven't seen before..." },	// Odyssey Demo 6
			{ "超级樱桃射手+樱桃机枪射手" , "Fusion Formula: Explod-o-shooter + Gatling Cherry" },
			{ "火爆窝瓜+窝炬" , "Fusion Formula: Spicy Squash + Infernowood" },
			{ "火爆窝瓜+超级火炬" , "Fusion Formula: Spicy Squash + Infernowood" },
			{ "魅惑菇+魅惑菇" , "Fusion Formula: Hypno-shroom + Hypno-shroom" },
			{ "超级大喷菇+寒冰魅惑菇" , "Fusion Formula: Frostveil-shroom + Doomberg-shroom" },
			{ "超级大嘴花+樱桃大嘴花" , "Fusion Formula: Chewzilla + Cherry Chomper" },
			{ "超级杨桃+磁力仙人掌" , "Fusion Formula: Stardrop + Magnethorn" },
			{ "超级大喷菇+寒冰忧郁菇" , "Fusion Formula: Doomberg-shroom + Snowgloom-shroom" },
			{ "超级南瓜+磁力三叶草" , "Fusion Formula: Bloverthorn Pumpkin + Magblover" },	
			{ "超级投手+蒜瓜" , "Fusion Formula: Salad-pult + Garlic-pult" },
			{ "寒冰加农炮+寒冰毁灭菇" , "Fusion Formula: Cryo Cannon + Cryodoom-shroom" },
			{ "超级伞+菜伞" , "Fusion Formula: Alchemist Umbrella + Umbrella Kale" },
			{ "三线+火爆辣椒x3" , "Fusion Formula: Threepeater + Jalapeno x3" },
			{ "超级魅惑菇+磁力魅惑菇" , "Fusion Formula: Charm-shroom + Charm Magnet" },

			// Strings - Mini Games
			{ "-------Strings - Mini Games" , "Strings - Mini Games-------" },
			{ "这一关只能种植或融合小喷菇！" , "In this level, you can only grow or fuse Puff-shrooms." }, // Compact Planting
			{ "击败僵尸以获取阳光" , "Zombies will only move on the darkened soil, so plan your\ndefenses accordingly. You can only obtain Sun by defeating zombies." }, // ZombiesTD
			{ "这关手套没有冷却，请放心使用" , "The Glove's cooldown is reduced to 0. Use it effectively to win this mini-game." }, // The Gods
			{ "右键拖拽移动屏幕，滚轮缩放屏幕" , "Hold your right mouse key and drag to move the screen.\n Use your scroll wheel to zoom in or zoom out." }, // Preview 10.0
			{ "向狙击豌豆售卖机枪来获得奖励" , "Drag over a Gatling Pea on top of a Sniper Pea to spawn another Sniper Pea." }, // ZombiesTD 3
			{ "无法抓取下半部分植物" , "You can only grab plants from the top half of the lawn." }, // Mirrors Like You See 'Em
			{ "只能在上半地图放植物" , "You can only place plants on the upper half of the lawn." }, // Mirrors Like You See 'Em
			{ "保护你的吸金磁" , "Protect your Gold Magnet from the zombies.\nIf the plant is destroyed, the game will end." }, // Protect The Gold Magnet
			{ "使用豌豆、双发、裂荚、机枪来传递胆小菇的子弹", "Use your Scaredy-shroom to make your Peashooters, Repeaters,\nSplit Peas and Gatling Pea shoot peas. When your peas hit other\nprojectile-firing plants, they will also fire their projectiles at a constant rate." }, // Scaredy's Dream
			
			// Strings - Garden Defense
			{ "-------Strings - Garden Defense" , "Strings - Garden Defense-------" },
			{ "使用花园中第1页第4行的植物参战！" , "Only the plants in the 1st page, 4th row of your Zen Garden \ncan be used in this mode.\nTake care of your plants and they will return the favor in your lawn!" },

			// Strings - Odyssey Mode
			{ "-------Strings - Odyssey Mode" , "Strings - Odyssey Mode-------" },
			//// Unlocks
			{ "解锁究极樱桃战神，超级大嘴花+樱桃大嘴花" , "Unlock Cherrizilla: Chewzilla + Cherry Chomper" },
			{ "解锁究极樱桃机枪，樱桃机枪+超级樱桃射手" , "Unlock Gatling Cherrybomber: Gatling Cherry + Explod-o-shooter" },
			{ "解锁究极大喷菇，超级大喷菇+寒冰魅惑菇" , "Unlock Doominator-shroom: Doomberg-shroom + Frostveil-shroom" },
			{ "解锁究极窝炬，超级火炬+火爆窝瓜" , "Unlock Squashed Infernowood: Spicy Squash + Infernowood" },
			{ "解锁究极杨桃，超级杨桃+磁力仙人掌" , "Unlock Magnetar: Stardrop + Magnethorn" },
			{ "解锁究极忧郁菇，超级大喷菇+寒冰忧郁菇" , "Unlock Oblivion-shroom: Doomberg-shroom + Snowgloom-shroom" },
			{ "解锁究极高坚果，寒冰高坚果+火焰高坚果" , "Unlock Obsidian Tall-nut: Frost Tall-nut + Scorch Tall-nut"},
			{ "解锁究极投手，超级投手+蒜瓜" , "Unlock Wither-pult: Salad-pult + Garlic-pult" },
			{ "解锁究极加农炮，寒冰加农炮+寒冰毁灭菇" , "Unlock Cob-livion Cannon: Cryo Cannon + Cryodoom-shroom"},
			{ "解锁究极魅惑菇，超级魅惑菇+魅惑磁力菇" , "Unlock Charmatron-shroom: Charm-shroom + Charm Magnet" },
			{ "解锁究极炮台，机枪炮台+黑曜石辣椒" , "Unlock Titan Apeacalypse Turret: Titan Pea Turret + Frostburnt Jalapeno" },
			//// Advanced Buffs
			{ "撒豆成兵：魅帝召唤间隔从30秒减为10秒，并解锁亚种魅后菇" , "Empress-shroom: Summon Interval → 10 Seconds | Enchantress-shroom Subspecies Unlocked" },
			{ "精兵强将：魅帝能召唤究极僵尸" , "Empress-shroom: Can now summon Ultimate Zombies" },
			{ "枕戈待旦：毁灭机枪不再需要休息，并解锁亚种毁灭机枪胆小菇" , "Gatling Doom: No more rest between every attack | Gatling Frenzy-shroom Subspecies Unlocked" },
			{ "核能威慑：毁灭机枪每轮都能发射大子弹" , "Gatling Doom: Can now fire bullets of doom between every attack" },
			{ "妙手回春：阳光帝果每次都能回满血" , "Twin Solar-nut: Can now restore to full health instead of 1500 each time" },
			{ "无关痛痒：阳光帝果单次受伤降为10点" , "Twin Solar-nut: Toughness reduces by 10 for each hit instead of 50" },
			{ "尸愁之路：玄钢地刺王伤害x5，并解锁亚种玄钢坚果" , "Spikesidian: Damage multiplied by 5 | Obsidian Spike-nut Subspecies Unlocked" },
			{ "百炼成钢：玄钢地刺王现在获得95%减伤" , "Spikesidian: Gains 95% DMG Reduction" },
			{ "熠熠生辉：单个阳光提供的阳光量大幅增加" , "Each Sun now gives double the value" },
			{ "极速战备：手套冷却速度翻倍" , "Glove's cooldown is halved" },
			{ "强力打击：植物的攻击力增加20%" , "Plants' Damage is increased by 20%" },
			{ "精准打击：僵尸受到的伤害增加20%" , "Zombies' receive 20% more damage" },
			{ "腐化：僵尸每受到一次伤害，下次受到的伤害增加5%" , "Each time a Zombie is damaged, the next instance of damage to it is increased by 5%" },
			{ "全副武装：开启在游戏过程中自选卡牌的功能" , "You now have to option to re-pick your Plant Loadout during the game" },
			{ "合理投资：词条刷新次数+2" , "Modifier reroll times + 2" },
			{ "怒火攻心：红温增伤幅度从50%增至150%，并且火焰豌豆类会对僵尸附加红温效果" , "Enflamed damage multiplier → 150%, and ignited peas can now inflict the debuff" },
			{ "至极手速：手套挪动植物不再消耗冷却" , "Moving plants no longer has a cooldown" },
			{ "势如破竹：冰锥的可以无限穿透，小冰机和小光机的攻击力增加50%" , "Gatling Icicle-shroom & Sunburst-shroom: Icicles Pierce Infinitely | 50% Increased Damage" },
			{ "冻彻心扉：冰锥的对冻结的单位造成伤害提升至10倍，并解锁亚种阳光机枪小喷菇" , "Gatling Icicle-shroom: Increased damage to Frozen zombies by 10 times | Gatling Sunburst-shroom Subspecies Unlocked" },
			{ "斗转星移：所有的流星冷却缩短为原来的1/2，且场上每多一个究极杨桃则伤害提升150" , "All Meteors' attack cooldowns are halved | DMG increased by 150 for every Magnetar in the field | Gravitron Subspecies Unlocked" },
			{ "灯火通明：全场光照等级+4" , "Adds 4 Lumos Levels for the entire field" },
			{ "三位一体：激光南瓜的僚机增加至3个" , "Laser Pumpkin: Wingmen Amount → 3" },
			{ "连锁反应：激光南瓜与丑壳在同一磁力系统中时也享受丑壳效果，并解锁亚种樱桃南瓜" , "Laser Pumpkin: Inherits Joker Pumpkin's effects when in the same Magnetic System | Blast Pumpkin Subspecies Unlocked" },
			{ "人工智能：绿宝石伞现在可以自动开大，并解锁亚种红宝石伞" , "Midas Umbrella: Activates ultimate automatically if zombies are near. 7.5 seconds cooldown | Aegis Umbrella Subspecies Unlocked" },
			{ "弹射起步：绿宝石伞可以让子弹弹到前方其他绿宝石伞上并叠加伤害（无上限）" , "Midas Umbrella: Now bounce bullets with other Midas Umbrella" },
			{ "聚光盆：获得3000阳光然后使你的阳光翻倍" , "Gain 3000 Sun, then double your total amount of Sun after" },
			{ "运斤如风：锤子冷却降低为6秒" , "Mallet's cooldown is reduced to 6 seconds" },
			{ "全息制冷：卡牌冷却减半" , "Plants' recharge are halved" },
			{ "致命一击：僵尸受到超过1800伤害（计算减伤之后）时额外受到1800伤害" , "Zombies take an additional 1800 damage when they take more than 1800 damage (after damage reduction)" },
			{ "拆分：使用手套点击植物后可以拆解植物，有强制20秒的拆解冷却" , "Clicking on the same plant when you have it on your Gloves will disassemble it | 20 seconds cooldown" },
			{ "肉身成圣：魅惑僵尸获得1000%啃咬伤害加成和80%减伤" , "Charmed Zombies gain 1000% bite damage bonus and 80% damage reduction"},
			{ "百步穿杨：浴火三线的子弹可以无限穿透" , "Phoenix Threepeater: Bullets can now pierce infinitely"},
			{ "复制中心：模仿者冷却时间大幅降低" , "Imitater's recharge is greatly reduced" },
			{ "连连看：两株相同植物一上一下时获得50%伤害加成和50%伤害减免" , "When two identical plants are placed one above the other, they gain a 50% damage bonus and a 50% damage reduction"},
			{ "特制弹药：魔法猫尾草的僚机攻击力x3" , "Magicat Nettle: Wingman deals 3x more DMG" },
			{ "一针见血：魔法猫尾草的基础攻击力x5" , "Magicat Nettle: Basic attack deals 5x more DMG" },
			{ "我是传奇：究极樱桃战神和究极高坚果同时在场时，战神的攻击变成范围伤害，血量不再有上限，究高额外获得90%伤害减免" , "When Cherrizilla and Obsidian Tall-nut are both present, Cherrizilla's attack deals AoE damage and no longer has a max Toughness cap, and Obsidian Tall-Nut gains a 90% DMG Reduction" },
			{ "真正的樱桃炸弹：植物的爆炸樱桃子弹在接下来的3轮内升级为纯粹的樱桃爆炸" , "True Cherry Bomb: Plant's Cherry Bomb Bullets upgrades to Cherry Bomb Explosions for the next 3 rounds" },
			{ "真正的毁灭菇：植物的毁灭菇子弹在接下来的3轮内升级为纯粹的毁灭菇爆炸" , "True Doom-shroom: Plant's Doom Bullets upgrades to Doom-shroom Explosions for the next 3 rounds" },
			{ "可控核聚变：所有毁灭菇爆炸不留弹坑" , "Calamity-shroom: ALL Doom-shroom explosions no longer leave a crater" },
			{ "人多势众：幻灭菇爆炸时召唤额外的魅惑巨人僵尸和魅惑冰车" , "Calamity-shroom: Now spawns extra Charmed Gargantuars and Zombonis when it explodes" },
			//// Ultimate Buffs
			{ "湮灭一击：究极樱桃战神能斩杀血量低于自己的僵尸" , "Cherrizilla: Can now kill zombies with less health than itself" },
			{ "泰坦之躯：究极樱桃战神获得200%治疗加成，且单次受伤不超过500" , "Cherrizilla: 200% healing bonus and zombie damage is capped at 500" },
			{ "力大砖飞：植物的爆炸樱桃子弹伤害x3" , "Gatling Cherrybomber: Cherry bomb bullets now deal 3x more DMG" },
			{ "快速填装：降低究极樱桃机枪的攻击间隔至1秒" , "Gatling Cherrybomber: Attack Interval → 1 Second" },
			{ "凛风刺骨：究极大喷菇的攻击力x3" , "Doominator-shroom: Fumes now deal 3x more DMG" },
			{ "三尺之寒：提升究极大喷菇的冻结速度为3倍" , "Doominator-shroom: Increased freezing speed by 3 times" },
			{ "事半功倍：降低究极窝炬生成窝瓜需要的子弹数至10" , "Squashed Infernowood: Bullets required to spawn a Spicy Squash → 10" },
			{ "好事成双：究极窝炬每次可以生成两个窝瓜" , "Squashed Infernowood: Now spawns two Spicy Squash at a time" },
			{ "流星雨：降低究极杨桃的攻击间隔至0.5秒" , "Magnetar: Attack Interval → 0.5 Seconds" },
			{ "众星之力：究极杨桃的子弹基础攻击力翻倍并且攻击力不再有上限" , "Magnetar: Base damage is doubled and limiter (120) is removed" },
			{ "万籁俱寂：究极忧郁菇亡语伤害增加到1000000" , "Oblivion-shroom: Damage on Death → 1,000,000" },
			{ "以爆制爆：究极忧郁菇免疫爆炸，每吸收10000点爆炸伤害将释放毁灭菇爆炸" , "Oblivion-shroom: Now absorbs explosion damage. When 10,000 damage is absorbed, a Doom-shroom explosion is released" },
			{ "见者有份：究极投手散射概率提升至100%" , "Wither-pult: Spread-fire is now a 100% chance"},
			{ "瓜熟蒂落：究极投手附带瓜盆效果" , "Wither-pult: Melon Pot's traits are now inherited" },
			{ "中心爆破：究极大炮的中心点爆炸伤害x4" , "Cob-livion Cannon: Main Blast damage is multiplied by 4" },
			{ "兵贵神速：究极大炮的装填时间降为原来的1/3" , "Cob-livion Cannon: Reload Time → 12 Seconds" },
			{ "冰淬火炼：黑曜石高坚果受到寒冰菇效果回血10000，火爆辣椒效果回满血" , "Obsidian Tall-nut: Recovers 10,000 HP when affected by Ice-shrooms, and recover full HP when affected by Jalapeno" },
			{ "两肋插刀：黑曜石高坚果会代替左右两株植物受伤" , "Obsidian Tall-nut: Can now absorb the damage directed to the two plants on its left and right" },
			{ "普度众生：究极魅惑菇子弹的魅惑血量阈值从50%提高到100%" , "Charmatron-shroom: Charm HP threshold increased from 50% to 100%" },
			{ "永动机：究极魅惑菇永远处于高能状态，且攻击间隔缩短至1秒" , "Charmatron-shroom: Now always in a fully-charged state | Attack Interval → 1 Second" },
			{ "阻冲之：究极炮塔的攻击力和击退强度大幅提高" , "Titan Apeacalypse Turret: Attack Power and Knockback Massively Increased" },
			{ "狂战士：究极炮塔血量越低防御力越高，当血量低于100时免疫低于100的伤害" , "Titan Apeacalypse Turret: Lower Health → Higher Defense | Immune to damage below 100" },
			// Other
			{ "获得5000阳光" , "Gain 5000 Sun" },

			// Odyssey Gacha
			{ "-------Strings - Odyssey Gacha" , "Strings - Odyssey Gacha-------" },
			{ "抓取植物后点击自身即可拆解" , "When holding a fused plant, clicking on it again will disassemble it." },

			// Strings - Playing
			{ "-------Strings - Playing" , "Strings - Playing-------" },
			//// More Zombies
			{ "更多的僵尸要来了" , "More zombies are coming..." },
			{ "更多的僵尸要来了！" , "More zombies are coming..." },
			{ "一大波僵尸正在接近！" , "A HUGE WAVE OF ZOMBIES IS APPROACHING" },
			//// Ineligible Fusions
			{ "通关挑战模式解锁配方" , "This fusion has not been unlocked yet.\n Complete its Advanced Challenge first in Challenge Mode." },
			{ "该配方仅旅行模式可用" , "This fusion is only available in Odyssey Mode." },
			{ "不能在陆地上融合！" , "This cannot be fused on land." },
			{ "不能在水上融合！" , "This cannot be fused on water." },
			{ "只能融合小喷菇！" , "Only fusions involving Puff-shrooms can be done." }, // Compact Planting
			{ "旅行到下一场景时抽取" , "This Odyssey fusion has not been unlocked yet.\n Unlock it by completing 3 rounds of a map and \nchoosing it in the Modifier Selection." },
			{ "进入下一轮时抽取" , "This Odyssey fusion subspecies has not been unlocked yet.\nUnlock it by completing 1 round and choosing the Modifier that unlocks it." },
			{ "这一关不能融合！" , "Fusions are not allowed in this game mode." }, // The Gods
			//// Notification
			{ "你为你的卡库新增了一种卡牌" , "A new plant is available in Plant Select." },
			{ "你为你的花园找到了一株植物" , "You've found a new plant for your Zen Garden."},
			{ "花园放不下更多的植物了" , "There is no more room for more plants in your Zen Garden." },
			{ "无法抓取梯子下的植物" , "You can't move plants that are laddered." },
			{ "拆解需要500阳光" , "Fission requires 500 Sun in order to activate."},
			{ "该模式不能移动需要保护的植物" , "You cannot move plants that need to be protected on this mode." }, // ZombiesTD 4 and 5
			//// Coffee Bean
			{ "咖啡豆对这株植物似乎没有效果" , "The Coffee Bean has no effect on this plant." },
			//// Ultimate
			{ "大招需要一份咖啡豆" , "This ultimate requires 1 Coffee Bean." },
			{ "大招需要两份咖啡豆" , "This ultimate requires 2 Coffee Beans." },
			{ "大招需要三份咖啡豆" , "This ultimate requires 3 Coffee Beans." },
			{ "大招需要四份咖啡豆" , "This ultimate requires 4 Coffee Beans." },
			{ "大招需要五份咖啡豆" , "This ultimate requires 5 Coffee Beans." },
			{ "大招需要六份咖啡豆" , "This ultimate requires 6 Coffee Beans." },
			{ "大招需要七份咖啡豆" , "This ultimate requires 7 Coffee Beans." },
			{ "大招需要八份咖啡豆" , "This ultimate requires 8 Coffee Beans." },
			{ "大招需要九份咖啡豆" , "This ultimate requires 9 Coffee Beans." },
			{ "大招需要十份咖啡豆" , "This ultimate requires 10 Coffee Beans." },

			// Strings - ZombiesTD 4
			{ "-------Strings - ZombiesTD 4" , "Strings - ZombiesTD 4" },
			{ "保护你的胆小菇" , "Protect your Shivery-shroom from the zombies. If the plant is destroyed, the game will end." },
			{ "你证明了你的实力，为了迎接血量不断增加的僵尸，现在可以使用究极植物了" , "You've proven your worth, now you can use the Odyssey Plants." },
			
			// Strings - ZombiesTD 5
			{ "-------Strings - ZombiesTD 5" , "Strings - ZombiesTD 5" },
			{ "保护你的超级保龄球坚果" , "Protect your Mecha-nuts from the zombies. If the plants are destroyed, the game will end." },
			//// Missions
			{ "当前任务：融合一个超级大喷菇\n任务奖励：手套无cd" , "Current Mission: Fuse a Doomberg-shroom\nCompletion Reward: Instant Gloves" },
			{ "任务目标：存储5000阳光\n任务奖励：樱桃南瓜x2+究极忧郁菇x1" , "Current Mission: Have 5000 Total Sun\nCompletion Reward: Blast Pumpkin x2 & Oblivion-shroom x1" },
			{ "任务目标：击败地图右侧出现的武装巨人！\n任务奖励：究极樱桃战神x2" , "Current Mission: Kill the Armed Gargantuar\nCompletion Reward: Cherrizilla x2" },
			{ "任务目标：种植8个究极投手（已开放究极投手配方）\n任务奖励：究极忧郁菇*6" , "Current Mission: Plant 8 Wither-pults (Wither-pult Unlocked)\nCompletion Reward: Oblivion-shroom x6" },
			{ "任务目标：击杀地图右侧出现的武装巨人\n任务奖励：究极加农炮x1" , "Current Mission: Kill the Armed Gargantuars\nCompletion Reward: Cob-livion Cannon x1" },
			{ "任务目标：种植6个樱桃机枪射手\n任务奖励：解锁究极樱桃射手配方以及他的两个词条" , "Current Mission: Plant 6 Gatling Cherry\nCompletion Reward: Unlock Gatling Cherrybomber and its 2 Modifiers" },
			{ "【僵尸血量获得大幅提升】任务目标：献祭你的全部究极加农炮\n任务奖励：解锁全部旅行词条" , "Zombies' HP have been greatly increased\nFinal Mission: Shovel ALL your Cob-livion Cannons\nCompletion Reward: Unlock all Odyssey Modifiers" },
			{ "已经完成全部任务，解锁全部旅行词条，祝你好运！" , "All missions have been completed. The full strength of the Odyssey Fusions as well as its Modifiers\nis at your disposal. Good luck!" },

			// Strings - NEW UPDATE
			{ "-------Strings - New Update" , "Strings - 2.2-------"},
			{ "Player" , " " },
			{ "冒险二周目戴夫选卡" , "Dave Picks Cards on\nAdventure NG+"},
			{ "毁灭菇特效" , "Doom-shroom Visual Effect" },
			{ "选卡" , "Selects Cards" },
			{ "不选卡" , "Does Not Select Cards" },
			{ "开启特效" , "Turned On" },
			{ "关闭特效" , "Turned Off" },
			{ "草坪" , "Lawn" },
			{ "商店" , "Shop" },
			{ "你确定要出售该植物吗" , "Are you sure you want to sell this plant?" },
			{ "你确定要购买该植物吗" , "Are you sure you want to buy this plant?" },
			{ "点击图鉴文本框即可翻页" , "Click on the text box to turn the page." },
			{ "按下鼠标左键返回" , "Click anywhere to return." },
			{ "点击任意位置返回" , "Click anywhere to return." },
			{ "普通僵尸" , "Normal Zombies" },
			{ "究极僵尸" , "Odyssey Zombies" },
			{ "砸罐子" , "Vasebreaker" },
			{ "连锁反应" , "Chain Reaction" },
			{ "僵王博士的复仇" , "Dr. Zomboss' Revenge" },
			{ "蹦极闪电战" , "Bungee Blitz" },
			{ "宝石迷阵" , "Beghouled" },
			{ "看星星" , "Seeing Stars" },
			{ "诸神：花园保卫战" , "The Gods: Garden Defense" },
			{ "使用花园中2~4行植物参战，相同类型的植物只能使用一株" , "Use the plants from the 2nd to 4th rows of the 1st Page of your Zen Garden\nto participate in this mini game. Only one plant of the same type can be used." },
			{ "完成75次配对以赢得游戏" , "Complete 75 matches to finish this mini game." },
			{ "词条" , "Modifiers" },
			{ "配方已更新" , "Formulae Changed" },
			{ "立即冷却手套完毕" , "The Gloves are instantly recharged." },
			{ "通关冒险模式45关后解锁" , "Unlocked after completing Level 45 in Adventure Mode" },
			{ "没有配对的植物了" , "There are no more plants left to make matches with." },

			{ "在三线射手上放置融合洋芋" , "Place the Jicamagic on top of the Threepeater." },
			{ "双发射手" , "Repeater" },
			{ "三线射手" , "Threepeater" },
			{ "在磁力菇上放置融合洋芋" , "Place the Jicamagic on top of the Magnet-shroom." },
			{ "小丑南瓜" , "Joker Pumpkin" },
			{ "磁力菇" , "Magnet-shroom" },
			{ "樱桃南瓜" , "Pump-Kaboom" },
			{ "在中间的大嘴花上放置融合洋芋" , "Place the Jicamagic on top of the middle Chomper." },
			{ "请按左中右的顺序放置以下植物\n大嘴花，大嘴花，大嘴花" , "Please place the following plants in order\nChomper, Chomper, Chomper"},

			{ "探索模式" , "Fusion Showcase" },
			{ "机枪炮塔" , "Titan Pea Turret" },
			{ "机枪炮台" , "Titan Pea Turret" }, // In-Game
			{ "更多的土豆雷" , "Explod-o-tato Mine" },
			{ "南瓜武装" , "Titan Pumpkin\nBunker" },
			{ "土豆小喷菇" , "Nugget-shroom" },
			{ "土豆胆小菇" , "Spuddy-shroom" },
			{ "巨型大嘴花" , "Titan Chomper Maw" },
			{ "蒜喷菇" , "Foul-shroom" },
			{ "魅惑三叶草" , "Hypnoblover" },
			{ "樱桃火炬" , "Boomwood" },

			{ "传送带" , "Conveyor Belt" },
			{ "已开启全部词条" , "Odyssey Modifiers - On" },
			{ "未开启全部词条" , "Odyssey Modifiers - Off" },
			{ "当前词条" , "Current Modifiers" },
			{ "词条中可以自选开启某种词条" , "Modifiers in the Menu to select which Odyssey Modifiers to activate." },

			// Strings - Dr. Zomboss' Revenge
			{ "锤子已解锁" , "Wooden Mallet Unlocked" },
			{ "手套已解锁" , "Gloves Unlocked" },

			{ "进度（测试版）" , "Achievements" },
			{ "植物大战僵尸融合版" , "PvZ Fusion"},

			{ "猫瓜+香蒲" , "Fusion Formula: Neko Squash + Cattail" },
			{ "机枪炮台+黑曜石辣椒" , "Fusion Formula: Titan Pea Turret + Frostburnt Jalapeno" },

			{ "旅行挑战" , "Odyssey: Challenges" },
			{ "旅行：炼狱" , "Odyssey\nPurgatory"},
			{ "此模式难度极高，且锁定难度！祝你好运！" , "The difficulty in this mode is locked to the highest difficulty. Good luck!" }, // Odyssey: Purgatory
			{ "炼狱" , "Purgatory" },
			{ "3旗前临时解锁《真正的毁灭菇》《真正的樱桃炸弹》词条", "Unlock the True Doom-shroom and True Cherry Bomb Modifiers before the 3 flags." }, // Purgatory
			{ "炼狱随机模式" , "Purgatory\nGacha" },
			{ "群贤毕至" , "The Cream of\nthe Crop" },

			// Strings - ZombiesTD6

			{ "当前任务：融合2个超级火炬\n任务奖励：4樱桃机枪", "Current Mission: Fuse 2 Infernowood\nCompletion Reward: 2 Gatling Cherry" },
			{ "任务目标：融合4个火炮\n任务奖励：浴火三线x2" , "Current Mission: Fuse 4 Pyro Cannon\nCompletion Reward: 2 Phoenix Threepeater" },
			{ "任务目标：融合4个焦黑三线\n任务奖励：浴火三线的配方和他的两个词条" , "Current Mission: Fuse 4 Scorched Threepeater\nCompletion Reward: Phoenix Threepeater Fusion and its Modifiers Unlocked" },
			{ "任务目标：存储5000阳光\n任务奖励：连连看词条和模仿者减cd词条" , "Current Mission: Have 5000 Sun\nCompletion Reward: Unlocks the following Modifiers: Imitator CD Reduced & Identical Plants Modifier\n(When two identical plants are placed one above the other, they gain a 50% damage bonus and a 50% damage reduction)" },
			{ "任务目标：合成8个寒冰机枪\n任务奖励：手套无cd+究极窝炬+他的两个词条" , "Current Mission: Fuse 8 Gatling Snow\nCompletion Reward: Gloves No CD, Squashed Infernowood, and its Modifiers Unlocked" },
			{ "你已经完成全部任务，祝你好运！" , "You have completed all missions! Good luck!" },

			{ "旅行游戏" , "Odyssey: Mini Games" },
			{ "诸神4" , "The Gods 4" },
			{ "诸神：逆流而上" , "The Gods: Trial of Valor" }, // In-Game
			{ "僵尸对战" , "Zombie Battle" },
			{ "按V键切换僵尸手套来挪动僵尸" , "Press V to Toggle Zombie Gloves to move Zombies." },
			{ "单枪匹马" , "Solitary Spear" },
			{ "冰天雪地" , "ZombiesTD 6" },
			{ "塔防：冰天雪地" , "ZombiesTD: A World of Ice and Snow" },
			{ "旅行：轮回" , "Odyssey\nReincarnation" },
			{ "随机融合模式" , "Odyssey Gacha\nFusion Mode" },
			{ "随机融合模式2" , "Odyssey Gacha\nFusion Mode 2" },
			{ "随机：升级" , "Odyssey Gacha\nUpgrade" },
			{ "点击射手、投手来操控（按WASD）（僵尸显血由W调整为R）\n使用手套点击植物点击自己来升级，融合时重置植物等级，但会返还升级消耗的阳光\n阳光来源为铲植物或者击杀僵尸，礼盒前期不会开强力植物，会随关卡进程逐步解锁\n卡槽中的4个空位不定期刷新，可用于直接购买植物" , "Control attack plants with WASD (Zombie Health Display: R). Use Gloves to click a plant, \nthen click again to upgrade. Fusing resets plant level but refunds Sun. Get Sun by \nshoveling plants or killing zombies. Plant Giftbox unlocks \nstronger plants as you progress. The 4 empty card slots refresh \nperiodically for direct plant purchases."},

			{ "旅行冒险（敬请期待）" , "Odyssey: Adventure" },

			// Odyssey

			{ "免费刷新" , "Free Reroll" },
			{ "消耗分数刷新" , "Reroll (Costs Points)" },
			{ "分数不够" , "Not Enough Points" },
			// Solitary Spear Strings
			{ "WASD控制植物移动，Q植物显血，R僵尸显血\n植物碰撞道具箱视为拾取道具" , "Use WASD to move the plant. Q will show the plant's health. R will show the zombie's health.\nColliding with a Giftbox will give you a buff." }, // Solitary Spear
			{ "随机道具箱已刷新" , "A Giftbox has been refreshed." }, // Solitary Spear
			{ "获得10%生命偷取，持续15秒！" , "Gain 10% lifesteal for 15 seconds!" },
			{ "植物血量已满" , "Toughness Fully Restored!" },
			{ "僵尸军团前来助阵！", "The Zombie reinforcements have come to help!" },
			{ "僵尸受到伤害x2，持续15秒！" , "Zombies take 2x damage for 15 seconds!" },
			{ "意外之喜！" , "What a pleasant surprise!" },
			{ "寒冰菇支援！" , "Ice-shroom has come to assist!" },
			{ "大荒星陨！" , "A star falls on your lawn!" },
			{ "火爆辣椒支援！" , "Jalapeno has come to assist!" },
			{ "坚果保龄球！" , "Giant-nut has come to assist!" },

			// Purgatory
			{ "机枪读报愤怒的时候会无视植物" , "Gatling Cherry Newspaper Zombie: Ability to walk through plants when its newspaper's broken" },
			{ "机枪读报免疫减速和黄油" , "Gatling Cherry Newspaper Zombie: Immunity to Slow and Butter" },
			{ "被黑橄榄攻击的植物在短时间内无法回血" , "Giga Rubgy-nut Zombie: Plants bitten by it won't recover Toughness for a short time" },
			{ "被黑橄榄攻击的植物在短时间内受到的伤害x3" , "Giga Rubgy-nut Zombie: Plants bitten by it will take 3x more damage for a short time" },
			{ "超级机械海豚的移动速度翻倍" , "Sharkmarine: Movement speed is now doubled" },
			{ "超级机械海豚获得50%伤害减免" , "Sharkmarine: Gains 50% Damage Reduction" },
			{ "基洛夫免疫三叶草效果，且飞行速度加快" , "Kirov Zomppelin: Immunity to Blovers | Increased Movement Speed" },
			{ "基洛夫的僚机血量大幅增加" , "Kirov Zomppelin: Drones' HP Greatly Increased" },
			{ "丑跳一定爆炸，且蓄力时间大幅降低" , "Pogo King Clown: Will always explode regardless of its state, and its charging time is reduced" },
			{ "被小丑爆炸影响的小丑类僵尸会变成丑跳" , "Pogo King Clown: Jack-in-the-Box Zombies affected by the explosion will turn into Pogo King Clowns" },
			{ "三叉戟伤害x5" , "Giga-trident Zombie: Tridents deal 5x more damage" },
			{ "三叉戟僵尸现在随机挑选目标攻击" , "Giga-trident Zombie: Now target random plants to attack" },
			{ "白舞王现在能召唤白色撑杆舞王僵尸" , "Superstar Zombie: Can now summon Super Dancing Zombies" },
			{ "白舞王遇到植物不会停下" , "Superstar Zombie: Will now phase through plants when charging" },
			{ "尸王死亡的爆炸伤害不可被小丑南瓜等免疫" , "Undying Wraith: Explosion damage will now ignore immunities by Joker Pumpkins and other relevant plants" },
			{ "尸王的冲刺间隔降低，且攻击力大幅增加" , "Undying Wraith: Sprint Interval Reduced | Attack Power Greatly Increased" },
			{ "三叉戟冲车免疫减速和黄油" , "Trident Hwacha: Immunity to Slow and Butter" },
			{ "损失场上一半的植物" , "Lose half of the plants on the field" },
			{ "令你的阳光数除以10" , "Your current Sun will be divided by 10" },
			{ "令你阳光归零" , "Lose all the Sun you currently have." },
			{ "所有僵尸的血量翻倍" , "Double the health of all zombies" },
			{ "每一波出现的僵尸数量最大值增加到100" , "Increase the maximum limit of zombies per wave to 100" },
			{ "每关都会出现舞王冰车，且死亡时额外召唤一个白舞王" , "Michael Zomboni: Spawns Every Round | Spawns Superstar Zombies when it dies" },
			{ "舞王冰车的移动速度大幅增加" , "Michael Zomboni: Increased Movement Speed" },
			{ "黑曜石巨人出现时也会出现究极三叉戟僵尸" , "Abyssal Gargantuar: Also spawns Pozeidon when it appears" },
			{ "黑曜石巨人死亡时会召唤僵王博士" , "Abyssal Gargantuar: Spawns Dr. Zomboss when it dies" },
			{ "黑曜石巨人出现时也会出现究极机械坚果僵尸" , "Abyssal Gargantuar: Also spawns an Ultra Mecha-nut Zombie when it appears" },
			{ "黑曜石巨人出现时也会出现黑橄榄将军" , "Abyssal Gargantuar: Also spawns a Giga Football Striker when it appears" },
			{ "黑曜石巨人出现时也会出现究极裂空机甲" , "Abyssal Gargantuar: Also spawns a Zomppelin Skystrider when it appears" },
			{ "黑曜石巨人出现时也会出现究极白舞台车僵尸" , "Abyssal Gargantuar: Also spawns a Jackson Worldwide when it appears" },
			{ "黑曜石巨人出现时也会出现究极读报僵尸" , "Abyssal Gargantuar: Also spawns a Professor Cherryz when it appears" },

			{ "-------Strings - New Update v2" , "Strings - 2.2.1-------"},
			{ "融合版唯一官方：\r\n哔哩哔哩up主-蓝飘飘fly\r\n\r\n一切外部渠道如233乐园等均为盗版！因盗版带来的一切损失由玩家自行承担！", "The Official source of PvZ Fusion is only on the author, 蓝飘飘fly's Bilibili</color>\nThe only valid source of this translation is from this community:\n<color=#64DD17>discord.gg/DPAC5ZVJ8T</color>.\n\nStray away from other sources as they may contain viruses.\nPlease visit our community for future updates." },
			{ "烈焰爆竹" , "Bamboom" },
			{ "临时词条已失效" , "The temporary Modifier has expired." },

			{ "-------Strings - New Update v3" , "Strings - 2.2.1-------"},
			{ "太阳神流星特效" , "Helios Cabbage Visual Effect" },
			{ "游戏机制" , "Game Mechanics" },
			{ "机制" , "Game Mechanics" },
			{ "切换图鉴样式" , "Switch View" },
			{ "强究" , "Strong" },
			{ "弱究" , "Weak" },
			{ "地刺坚果" , "Spike-nut" },
			{ "海妖菇" , "Titan Kraken-shroom" },
			{ "在中间的海蘑菇上放置融合洋芋" , "Place the Jicamagic on the Sea-shroom in the middle." },
			{ "水草, 海蘑菇, 水草" , "Tangle Kelp, Sea-shroom, Tangle Kelp" },
			{ "选择" , "Select" },
			{ "诸神5" , "The Gods 5" },
			{ "诸神：阳光普照" , "The Gods: Trial of the Sun" },
			{ "随机：福祸相依" , "Odyssey Gacha\nBlessings and Curses" },
			{ "旅行冒险" , "Odyssey: Adventure" },
			{ "购买" , "Buy" },
			{ "刷新" , "Reroll" },
			{ "购买成功\t\t\t\t\t\t\t\t\t\t购买成功", "\n\nPurchase Successful" },
			{ "从中选择10个植物" , "Select 10 plants among the selection." },
			{ "必须选10个\t\t\t\t\t\t\t\t\t\t\t\t必须选10个" , "\n\nYou must select 10 plants." },
			{ "弱究可用" , "Initially Selected" },
			{ "放弃增益\n（获得1000积分)" , "Skip Selection\n(Gain 1000 Points)" },
			{ "已达最大刷新次数\t\t\t\t\t\t\t\t\t\t已达最大刷新次数" , "\n\nMax amount of Rerolls reached." },
			{ "一键通关\n冒险模式和旅行冒险" , "Clear All\nAdventure (Normal and Odyssey)" },
			{ "旧版平衡（关）" , "Legacy Adjustment - On" },
			{ "旧版平衡（开）" , "Legacy Adjustment - Off" },
			{ "PVP砸罐子" , "Vasebreaker PVP" },
			{ "挑\n战\n者\n\n\n\n主\n播" , "<size=14>C\nH\nA\nL\nL\nE\nN\nG\nE\nR\n\n\nS\nT\nR\nE\nA\nM\nE\nR" },
			{ "挑\n战\n者\n\n\n\n擂\n主" , "<size=14>C\nH\nA\nL\nL\nE\nN\nG\nE\nR\n\n\nR\nE\nC\nO\nR\nD\n\n\nH\nO\nL\nD\nE\nR" },
			{ "切换背景" , "<size=12>Switch Background" },
			{ "清除僵尸（Y）" , "<size=12>Clear Zombies (Y)" },
			{ "清除植物（U）" , "<size=12>Clear Plants (U)" },
			{ "未开启右键放罐（I）" , "<size=12>Right Click To Place \nVases (I) - Disabled" },
			{ "未开启随机卡槽（O）" , "<size=12>Randomize Plants\n in Slots (O) - Disabled" },
			{ "已开启右键放罐（I）" , "<size=12>Right Click To Place \nVases (I) - Enabled" },
			{ "已开启随机卡槽（O）" , "<size=12>Randomize Plants\n in Slots (O) - Enabled" },
			{ "炼狱随机2" , "Purgatory\nGacha 2" },
			{ "每轮只能使用一次" , "This can only be used once per round."},
			{ "该配方仅旅行生存系列可用" , "This fusion is only available in Odyssey." },
			{ "闪电洋葱不能死亡" , "You must protect your Electronion from the zombies. If it dies, the game ends." },
			{ "球杆力度大幅增加" , "The power of the cue stick has been greatly increased." },
			{ "推进旅行冒险解锁" , "Unlock this fusion by completing its Odyssey - Adventure level." },
			{ "请选择你要购买的词条\t\t\t\t\t\t\t\t\t\t请选择你要购买的词条" , "Please select the Modifier you want to purchase." },
			{ "购买的词条" , "Purchased Modifiers" },
			{ "该配方需要抽取" , "This fusion must be bought first in the Modifier Shop before it can be used." },
			{ "坚如磐石" , "The Gods 3" },
			{ "究极随机" , "Odyssey Gacha - 12 Lane" },
			{ "超级随机模式" , "Ten Flag: Odyssey Gacha" },
			{ "积分不足\t\t\t\t\t\t\t\t\t\t积分不足" , "You have insufficient points." },
			{ "未选取此植物" , "This Weak Odyssey Fusion was not selected in the Initial Selection Phase. You can't fuse this plant." }, 

			{ "排山倒海：一种种一列" , "Enable Column Planting" },
			{ "解锁究极卷心菜，阳光卷心菜+金卷心菜" , "Unlock Helios Cabbage: Solar-pult + Golden Cabbage" },
			{ "解锁究极南瓜，超级南瓜+磁力三叶草" , "Unlock Laser Pumpkin: Bloverthorn Pumpkin + Magblover" },
			{ "妙手回春：阳光帝果召唤消耗降低至200阳光", "Twin Solar-nut: The cost of spawning a Giant Solar-nut is reduced to 200 Sun" },
			{ "势如破竹：冰锥可以无限穿透，小冰机和小光机的攻击力增加50%" , "Gatling Icicle-shroom: Ice cones can pierce infinitely | Gatling Icicle/Sunburst-shroom DMG +50%" },
			{ "冻彻心扉：冰锥对冻结的单位造成伤害提升至10倍，并解锁亚种阳光机枪小喷菇" , "Gatling Icicle-shroom: Ice cones DMG to Frozen zombies x10 | Gatling Sunburst-shroom Subspecies Unlocked" },
			{ "斗转星移：所有的流星冷却缩短为原来的1/2，且场上每多一个究极杨桃则提升300基础伤害" , "Meteor Cooldowns Halved | Each Magnetar increases the damage of a Meteor by 300" },
			{ "多多益善：升级金盆的消耗不会超过8000", "Radiant Pot: Upgrade costs from Silver Pots to Golden Pots will not exceed 8000" },
			{ "等价交换：金币数超出上限的部分将转化为阳光，转化率为2:1", "Radiant Pot: Gold coins exceeding the maximum amount will be converted into half the Sun" },
			{ "弹射起步：绿宝石伞可以让子弹弹到前方其他绿宝石伞上并叠加伤害（无上限），且伤害增幅从75%增加到125%" , "Midas Umbrella: Now bounce bullets with other Midas Umbrella, buffing its damage | Damage buff increased from 75% to 125%" },
			{ "聚光盆：获得3000阳光然后使你的阳光翻倍，并使阳光上限增加到10万" , "Gain 3000 Sun, then double your total Sun | Sun Limit increased to 100,000" },
			{ "可控核聚变：所有毁灭菇爆炸不留弹坑，并解锁亚种贪欲菇" , "Calamity-shroom: Doom-shroom explosions no longer leave craters | Avarice-shroom Subspecies Unlocked" },
			{ "大富翁：基于当前金钱数量增加摇钱火炬的子弹伤害比例，每1000增加2%", "Tycoon Torch: 2% Damage increase to Tycoon Torched bullets for every 1000 coins you have" },
			{ "好运连连：摇钱三线火炬的子弹附带火焰豌豆一样的溅射效果" , "Tycoon Torch: Bullets that pass through it gain a Splash effect like flaming peas" },
			{ "过载：僵尸一段时间没有受到攻击后，下次受到的伤害大幅增加" , "After a period of time without being attacked, the next time a zombie is attacked, the damage it takes is greatly increased" },

			{ "星神合一：当场上有至少10个究极杨桃大帝和10个究极太阳神卷心菜，大帝将会牵引太阳神陨星，太阳神召唤的小太阳不会消失且伤害翻倍，且持续召唤普通流星" , "When there are at least 10 Magnetars and 10 Helios Cabbages on the field, the Magnetar will summon the Helios Meteor instead, while Helios' summoned Mini Sun will not disappear and will also continue to summon ordinary Meteors." },
			{ "量子护盾：仙萤伞能量上限x10，回复速度x20，治疗速度x2" , "Tesla Umbrella: Energy Limit x10 | Recovery Speed x20 | Healing Speed x2" },
			{ "高能射线：仙萤伞的普通攻击的倍率增加至300%，爆炸倍率增加至1000%，间隔降低为2秒" , "Tesla Umbrella: Normal Attack Multiplier → 300% | Explosion Multiplier → 1000% | Attack Interval → 2 Seconds" },
			{ "窝红温了：究极窝炬没有位置生产窝瓜时将会直接燃烧一整行的僵尸" , "Squashed Infernowood: When there's no space to produce a Spicy Squash, ignite the lane instead" },
			{ "金光闪闪：太阳神卷心菜的子弹获得阳光卷心菜子弹的效果" , "Helios Cabbage: Its projectiles gain the effect of Solar-pult's projectiles" },
			{ "人造太阳：太阳神卷心菜召唤的小太阳伤害x3" , "Helios Cabbage: Its summoned Mini Sun will deal 3x more damage" },
			{ "三位一体：究极南瓜的僚机增加至3个" , "Laser Pumpkin: Wingmen increased to 3" },
			{ "镭射激光：究极南瓜的僚机攻击力x3" , "Laser Pumpkin: Wingmen damage multiplied by 3" },

			{ "究极三叉戟僵尸将会出现" , "Pozeidon will appear in the next round" },
			{ "究极机械坚果僵尸将会出现" , "Ultra Mecha-nut will appear in the next round" },
			{ "黑橄榄将军将会出现" , "Giga Football Striker will appear in the next round"},
			{ "究极裂空机甲将会出现" , "Skystrider Mecha will appear in the next round"},
			{ "究极白舞台车僵尸将会出现" , "Jackson Worldwide will appear in the next round"},
			{ "究极读报僵尸将会出现" , "Professor Cherryz will appear in the next round"},
			{ "蹦极有概率空投究极僵尸,且额外获得90%减伤" , "Bungee Jumpers have a chance to drop an Ultimate Zombie and will gain 90% DMG Reduction"},
			{ "究极小丑僵尸将会出现" , "Queen Jill-in-the-Box will appear in the next round"},

			// Strings - No Clue
			{ "-------Strings - No Clue" , "Strings - No Clue-------"},
			{ "错误：尝试生成不存在的植物！" , "Error: Attempting to spawn a plant that doesn't exist." },
			{ "错误：尝试生成不存在的植物！用豌豆代替" , "Error: Attempting to spawn a plant that doesn't exist. Use Peashooters instead." },
			{ "错误：尝试生成不存在的种植预览！" , "Error: Trying to generate a planting preview that doesn't exist." },			
			{ "已解锁全部植物" , "All Plants Unlocked" },
			{ "数据异常" , "Data Anomalies" },
			{ "模式" , "Mode" },
			{ "需要" , "Required" },
			{ "不需要" , "Not Required" },	
			{ "轮已经完成" , "The round is completed." },
			{ "究极植物" , "Odyssey Plants"},
			{ "究极词条" , "Odyssey Modifiers"},
			{ "笨蛋:梦珞" , " ??? Where" },
			{ "是否抽取一种究极植物" , " ??? Where" },
			{ "：" , ": " },
			{ "敬请期待" , "Stay Tuned!" },
			// Testing
			{ "¥" , "$" },

			// None Of This Shit Works!
			{ "-------Translation Doesn't Work" , "Needs Patching-------" },
			{ "植物掉落阳光数" , "Sun Drop Multiplier" },
			{ "僵尸血量倍率" , "Zombie HP Multiplier" },

			{ "-------Outdated Strings Below" , "You Can Safely Ignore or Delete-------"},
			#endif
		};

		public static Dictionary<string, Dictionary<string, string>> patchesStore = new()
		{
			{ "Difficulty", new Dictionary<string, string>
				{
					{ "English" , "Difficulty:" },
					{ "French" , "Difficulté:" },
					{ "Italian" , "Difficoltà:" },
					{ "German" , "Schwierigkeit:" },
					{ "Spanish" , "Dificultad:" },
					{ "Portuguese" , "Dificuldade:" },
					{ "Filipino" , "Ang Hirap:" },
					{ "Vietnamese" , "Độ Khó:" },
					{ "Indonesian" , "Kesulitan:" },
					{ "Russian" , "Сложность:" },
					{ "Japanese" , "困難:" },
					{ "Korean", "난이도:" },
					{ "Javanese" , "Kesulitan:" },
					// { "Ukrainian" , "Складність:" },
					// { "Slovak" , "Náročnosť:" },
				}
			},
			{ "Zombies", new Dictionary<string, string>
				{
					{ "English" , "Zombies:" },
					{ "French" , "Les Zombies:" },
					{ "Italian" , "Zombi:" },
					{ "German" , "Zombies:" },
					{ "Spanish" , "Zombis:" },
					{ "Portuguese" , "Zumbis:" },
					{ "Filipino" , "Mga Zombie:" },
					{ "Vietnamese" , "Thây Ma:" },
					{ "Indonesian" , "Zombi:" },
					{ "Russian" , "Зомби:" },
					{ "Japanese" , "ゾンビ:" },
					{ "Korean", "좀비:" },
					{ "Javanese" , "Mayit:" },
					// { "Ukrainian" , "Зомбі:" },
					// { "Slovak" , "Zombíci:"}
				}
			}

		};

		internal static void Init()
		{
			FileLoader.LoadStrings();
		}

		internal static void Reload()
		{
			translationString.Clear();
			translationStringRegex.Clear();
			FileLoader.LoadStrings();
		}

		public static TextMeshPro TranslateText(TextMeshPro originalTMP, bool isLog = false)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			string translatedText = TranslateText(originalTMP.text);
			originalTMP.font = fontAsset;
			originalTMP.text = translatedText;

			return originalTMP;
		}

		public static TextMeshProUGUI TranslateText(TextMeshProUGUI originalTMP, bool isLog = false)
		{
			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			string translatedText = TranslateText(originalTMP.text);
			originalTMP.font = fontAsset;
			originalTMP.text = translatedText;

			return originalTMP;
		}

		public static string TranslateText(string originalText, bool isLog = false)
		{
			string text = DoTranslateText(originalText, false);
			string checkText;
			#if DEBUG
			Regex regex = new("\\p{IsCJKUnifiedIdeographs}+");
			Match match = regex.Match(text);

			if(match.Success)
			{
				// Log.LogDebug("Untranslated String: " + match.Value);
				FileLoader.DumpUntranslatedStrings(text);
			}
			#endif
			checkText = text;
			
			return checkText;

		}

		public static string DoTranslateText(string originalText, bool isLog = false)
		{
			if (string.IsNullOrEmpty(originalText))
			{
				if (isLog)
					Log.LogError("Text Null or Empty");

				return string.Empty;
			}

			if (translationString.ContainsKey(originalText))
			{
				if (isLog)
					Log.LogDebug($"Text '{originalText} found in translationString");
				return translationString[originalText];
			}

			// Regex-based dynamic translation
			foreach (var entry in translationStringRegex)
			{
				var regex = new Regex(entry.Key);
				if (regex.IsMatch(originalText))
				{
					// Extract dynamic parts from the original text
					var match = regex.Match(originalText);
					int groupCount = match.Groups.Count;

					if (isLog)
						Log.LogDebug("Text found in translationStringRegex {0}: {1}", match, groupCount);

					// List to hold formatted dynamic parts
					List<string> dynamicParts = [];

					// Loop through each group and determine its translation
					for (int i = 1; i < groupCount; i++)
					{
						string groupValue = match.Groups[i].Value;
						string translatedValue = translationString.ContainsKey(groupValue)
							? translationString[groupValue]
							: groupValue;
						dynamicParts.Add(translatedValue);
					}

					// Format the output string with dynamic parts
					return string.Format(entry.Value, [.. dynamicParts]);
				}
			}

			if (isLog)
				Log.LogDebug($"Text '{originalText}' not translated");
			return originalText;
		}

		private static TextAlignmentOptions TextAnchorToTMPAlignment(TextAnchor anchor)
		{
			return anchor switch
			{
				TextAnchor.UpperLeft => TextAlignmentOptions.TopLeft,
				TextAnchor.UpperCenter => TextAlignmentOptions.Top,
				TextAnchor.UpperRight => TextAlignmentOptions.TopRight,
				TextAnchor.MiddleLeft => TextAlignmentOptions.MidlineLeft,
				TextAnchor.MiddleCenter => TextAlignmentOptions.Center,
				TextAnchor.MiddleRight => TextAlignmentOptions.MidlineRight,
				TextAnchor.LowerLeft => TextAlignmentOptions.BottomLeft,
				TextAnchor.LowerCenter => TextAlignmentOptions.Bottom,
				TextAnchor.LowerRight => TextAlignmentOptions.BottomRight,
				_ => TextAlignmentOptions.Center
			};
		}

		static TextMeshProUGUI ConvertToTextMeshPro(UnityEngine.UI.Text oldText, TMP_FontAsset fontAsset, bool isLog = false)
		{
			if (oldText == null)
			{
				Log.LogError("UnityEngine.UI.Text component is null.");
				return null;
			}

			if (fontAsset == null)
			{
				Log.LogError("TMP_FontAsset is null. Conversion cannot proceed.");
				return null;
			}

			// Log.LogInfo($"Converting UnityEngine.UI.Text: {oldText.name}");

			GameObject textObject = oldText.gameObject;

			// Preserve text content and settings
			string originalText = oldText.text;
			originalText = TranslateText(originalText, isLog);
			TextAnchor alignment = oldText.alignment;
			Color color = oldText.color;

			// Remove old Text component
			UnityEngine.Object.DestroyImmediate(oldText);

			// Add TextMeshProUGUI component
			TextMeshProUGUI newTMP = textObject.AddComponent<TextMeshProUGUI>();
			if (newTMP == null)
			{
				Log.LogError($"Failed to add TextMeshProUGUI to object: {textObject.name}");
				return null;
			}

			// Configure TextMeshProUGUI
			newTMP.text = originalText;
			newTMP.color = color;
			newTMP.alignment = TextAnchorToTMPAlignment(alignment);
			newTMP.font = fontAsset;

			// Log.LogInfo($"Successfully converted {textObject.name} to TextMeshProUGUI.");

			return newTMP;
		}

		public static void TranslateTextTransform(Transform baseTransform, bool isAutoTextContainer = false, bool isLog = false)
		{
			if (!baseTransform) return;

			#if MULTI_LANGUAGE
			string currentLanguage = Utils.Language.ToString();
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont(currentLanguage);
			#else
			TMP_FontAsset fontAsset = FontStore.LoadTMPFont();
			#endif

			if (fontAsset == null)
			{
				#if MULTI_LANGUAGE
				Log.LogError($"Font for language '{currentLanguage}' not found. Translation aborted.");
				#else
				Log.LogError("Font not found. Translation aborted.");
				#endif
				return;
			}

			// Local function for processing transforms
			void ProcessTextTransform(Transform textTransform)
			{
				if (!textTransform) return;

				// Handle TextMeshPro components
				TextMeshPro textTMP = textTransform.GetComponent<TextMeshPro>();
				if (textTMP)
				{
					textTMP.text = TranslateText(textTMP.text, isLog);
					textTMP.autoSizeTextContainer = isAutoTextContainer;
					textTMP.font = fontAsset;
				}

				TextMeshProUGUI textTMPUGUI = textTransform.GetComponent<TextMeshProUGUI>();
				if (textTMPUGUI)
				{
					textTMPUGUI.text = TranslateText(textTMPUGUI.text, isLog);
					textTMPUGUI.enableAutoSizing = isAutoTextContainer;
					textTMPUGUI.font = fontAsset;
				}

				// Handle UnityEngine.UI.Text components
				UnityEngine.UI.Text textUI = textTransform.GetComponent<UnityEngine.UI.Text>();
				if (textUI)
				{
					ConvertToTextMeshPro(textUI, fontAsset, isLog);
				}
			}

			// Process specific text paths
			ProcessTextTransform(baseTransform.Find("text"));
			ProcessTextTransform(baseTransform.Find("text1"));
			// ProcessTextTransform(baseTransform.Find("text2"));

			Transform shadowTransform = baseTransform.Find("text/shadow");
			if (shadowTransform) ProcessTextTransform(shadowTransform);

			shadowTransform = baseTransform.Find("text1/shadow");
			if (shadowTransform) ProcessTextTransform(shadowTransform);
			
			#if TESTING
			Transform childTransform = baseTransform.GetChild(0);
			if (childTransform) ProcessTextTransform(childTransform);
			#endif
		}

		public static void TranslateTextUI(TextMeshPro textTMP, bool? isAutoTextContainer = null, bool isLog = false)
		{
			string currentLanguage = Utils.Language.ToString();
			if (textTMP)
			{
				textTMP.text = TranslateText(textTMP.text, isLog);
				if (isAutoTextContainer!=null) textTMP.autoSizeTextContainer = isAutoTextContainer.Value;
				textTMP.font = FontStore.LoadTMPFont(currentLanguage);
			}
		}
		public static void TranslateTextUI(TextMeshProUGUI textTMP, bool? isAutoTextContainer = null, bool isLog = false)
		{
			string currentLanguage = Utils.Language.ToString();
			if (textTMP)
			{
				string origText = textTMP.text;

				textTMP.text = TranslateText(origText, isLog) == "" ? origText : TranslateText(origText, isLog);
				if (isAutoTextContainer != null) textTMP.autoSizeTextContainer = isAutoTextContainer.Value;
				if (origText != textTMP.text)
					textTMP.font = FontStore.LoadTMPFont(currentLanguage);
			}
		}

		public static void TranslateTextUI(TMP_InputField TextInput)
		{
			string currentLanguage = Utils.Language.ToString();
			if (TextInput)
			{
				string oriText = TextInput.m_Text;
				TextInput.m_Text = TranslateText(oriText);
				TextInput.m_OriginalText = TranslateText(oriText);
				TextInput.fontAsset = FontStore.LoadTMPFont(currentLanguage);
			}
		}

		public static void LogAll()
		{
			Log.LogInfo("Logging all StringStore entries.");
			Log.LogInfo("Regex Entries: {0}", translationStringRegex.Count);
			Log.LogInfo("String Entries: {0}", translationString.Count);
		}
	}
}