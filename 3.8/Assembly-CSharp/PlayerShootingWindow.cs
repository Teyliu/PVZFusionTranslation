using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000868 RID: 2152
[Token(Token = "0x2000868")]
public class PlayerShootingWindow : BaseWindow
{
	// Token: 0x06002C01 RID: 11265 RVA: 0x000F1A28 File Offset: 0x000EFC28
	[Token(Token = "0x6002C01")]
	[Address(RVA = "0x671320", Offset = "0x66F920", VA = "0x180671320")]
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
			Func<PlayerWeapon, bool> func;
			PlayerWeapon playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(player.playerWeapons, func);
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

	// Token: 0x06002C02 RID: 11266 RVA: 0x000F1BC8 File Offset: 0x000EFDC8
	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x671270", Offset = "0x66F870", VA = "0x180671270", Slot = "11")]
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

	// Token: 0x06002C03 RID: 11267 RVA: 0x000F1C14 File Offset: 0x000EFE14
	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x65B2B0", Offset = "0x6598B0", VA = "0x18065B2B0")]
	public PlayerShootingWindow()
	{
	}

	// Token: 0x04001A25 RID: 6693
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001A25")]
	public PlayerWeaponBuff buffType;

	// Token: 0x04001A26 RID: 6694
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4001A26")]
	public PlayerWeaponType weaponType;

	// Token: 0x04001A27 RID: 6695
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001A27")]
	public bool set;

	// Token: 0x04001A28 RID: 6696
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4001A28")]
	private PlantType plantType;
}
