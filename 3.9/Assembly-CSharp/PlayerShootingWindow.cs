using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008A4 RID: 2212
[Token(Token = "0x20008A4")]
public class PlayerShootingWindow : BaseWindow
{
	// Token: 0x06002D33 RID: 11571 RVA: 0x000F66B8 File Offset: 0x000F48B8
	[Token(Token = "0x6002D33")]
	[Address(RVA = "0x6D5EF0", Offset = "0x6D44F0", VA = "0x1806D5EF0")]
	public void SetType(PlayerWeaponBuff buffType)
	{
		int num;
		Player player;
		for (;;)
		{
			num = 0;
			this.set = true;
			this.buffType = buffType;
			player = PlayerShootingManager.Instance.player;
			PlayerShootingManager instance = PlayerShootingManager.Instance;
			string text;
			this.introduce.text = text;
			if (buffType != PlayerWeaponBuff.GetNewWeapon)
			{
				break;
			}
			Dictionary<PlayerWeaponType, PlantType> weaponPlantPairs = PlayerShootingData.WeaponPlantPairs;
			PlayerWeaponType playerWeaponType = this.weaponType;
			if (weaponPlantPairs.TryGetValue(playerWeaponType, num))
			{
				goto Block_4;
			}
		}
		Type typeFromHandle = typeof(PlayerWeaponBuff);
		string name = Enum.GetName(typeFromHandle, typeFromHandle);
		string[] array;
		string text2 = array[0];
		Type typeFromHandle2 = typeof(PlayerWeaponType);
		int num2 = 0;
		if (Enum.TryParse(typeFromHandle2, text2, num))
		{
			int num3 = 0;
			PlayerShootingWindow.<>c__DisplayClass4_0 CS$<>8__locals1;
			CS$<>8__locals1.FieldGetter(num3, num, num2);
			int num4 = num;
			CS$<>8__locals1._result = (PlayerWeaponType)num4;
			PlayerWeaponType result = CS$<>8__locals1._result;
			PlayerWeaponType valueOrDefault = CollectionExtensions.GetValueOrDefault<PlayerWeaponType, PlantType>(PlayerShootingData.WeaponPlantPairs, (PlantType)result);
			this.plantType = (PlantType)valueOrDefault;
			List<PlayerWeapon> playerWeapons = player.playerWeapons;
			Func<PlayerWeapon, bool> func = delegate(PlayerWeapon w)
			{
				PlayerWeaponType result2 = CS$<>8__locals1._result;
				return w.theWeaponType == result2;
			};
			PlayerWeapon playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(playerWeapons, func);
			int num5 = 0;
			if (playerWeapon != num5)
			{
				Dictionary<PlayerWeaponBuff, int> buffDic = playerWeapon.BuffDic;
				TextMeshProUGUI introduce = this.introduce;
				bool flag;
				if (!flag)
				{
					string text3 = introduce.text;
				}
				string text4 = introduce.text;
				int num6;
				string text5 = string.Format("\n\n该词条已拥有{0}个", num6);
				string text6 = text4 + text5;
				introduce.text = text6;
				TextMeshProUGUI introduce2 = this.introduce;
				string text7 = introduce2.text;
				int level = playerWeapon.level;
				int level2 = player.level;
				string text8 = string.Format("\n\n当前武器词条上限：\n{0}/{1}", text7, text7);
				string text9 = text7 + text8;
				introduce2.text = text9;
			}
		}
		return;
		Block_4:
		this.plantType = (PlantType)num;
		throw new NullReferenceException();
	}

	// Token: 0x06002D34 RID: 11572 RVA: 0x000F686C File Offset: 0x000F4A6C
	[Token(Token = "0x6002D34")]
	[Address(RVA = "0x6D5E40", Offset = "0x6D4440", VA = "0x1806D5E40", Slot = "11")]
	public override void OnAnimOver()
	{
		base.OnAnimOver();
		GameObject show = this.show;
		int num = 0;
		if (show != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		if (this.set)
		{
			PlantType plantType = this.plantType;
			GameObject gameObject = base.SetPlant(plantType);
		}
	}

	// Token: 0x06002D35 RID: 11573 RVA: 0x000F68B8 File Offset: 0x000F4AB8
	[Token(Token = "0x6002D35")]
	[Address(RVA = "0x6BF110", Offset = "0x6BD710", VA = "0x1806BF110")]
	public PlayerShootingWindow()
	{
	}

	// Token: 0x04001B13 RID: 6931
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001B13")]
	public PlayerWeaponBuff buffType;

	// Token: 0x04001B14 RID: 6932
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4001B14")]
	public PlayerWeaponType weaponType;

	// Token: 0x04001B15 RID: 6933
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001B15")]
	public bool set;

	// Token: 0x04001B16 RID: 6934
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4001B16")]
	private PlantType plantType;
}
