using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000C8 RID: 200
[Token(Token = "0x20000C8")]
public class LoonManager
{
	// Token: 0x06000399 RID: 921 RVA: 0x00010968 File Offset: 0x0000EB68
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x4F4040", Offset = "0x4F2640", VA = "0x1804F4040")]
	public static LoonNut GetLoon(Board board, int theColumn, int theRow, PlantType thePlantType)
	{
		Dictionary<PlantType, string> loonNutDic = LoonManager.LoonNutDic;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		LoonNut component = gameObject.GetComponent<LoonNut>();
		component.thePlantType = thePlantType;
		component.currentRow = theRow;
		component.damage = (int)((ulong)370L);
		SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
		component.sortingGroup = sortingGroup;
		SortingGroup sortingGroup2 = component.sortingGroup;
		string text = string.Format("bullet{0}", sortingGroup);
		sortingGroup2.sortingLayerName = text;
		GameAPP.PlaySound(22, 0.5f, 1f);
		Transform transform3 = gameObject.transform;
		Vector3 vector;
		float z = vector.z;
		return component;
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00010A28 File Offset: 0x0000EC28
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public LoonManager()
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00010A3C File Offset: 0x0000EC3C
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x4F43F0", Offset = "0x4F29F0", VA = "0x1804F43F0")]
	static LoonManager()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	private static readonly Dictionary<PlantType, string> LoonNutDic = new Dictionary
	{
		{
			(uint)1048,
			"Board/Loon/LoonCaltropNut"
		},
		{
			(uint)1003,
			"Board/Loon/LoonCherryNut"
		},
		{
			(uint)1012,
			"Board/Loon/LoonChomperNut"
		},
		{
			(uint)1236,
			"Board/Loon/LoonDoomNut"
		},
		{
			(uint)1235,
			"Board/Loon/LoonFireNut"
		},
		{
			(uint)1147,
			"Board/Loon/LoonHypnoNut"
		},
		{
			(uint)1189,
			"Board/Loon/LoonIceNut"
		},
		{
			(uint)1215,
			"Board/Loon/LoonPortalNut"
		},
		{
			(uint)1250,
			"Board/Loon/LoonSquashNut"
		},
		{
			(uint)3,
			"Board/Loon/LoonWallNut"
		},
		{
			(uint)1006,
			"Board/Loon/LoonSunNut"
		},
		{
			(uint)931,
			"Board/Loon/LoonObsidianWallNut"
		}
	};
}
