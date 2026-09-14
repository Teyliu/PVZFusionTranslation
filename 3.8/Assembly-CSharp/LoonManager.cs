using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x20000C3")]
public class LoonManager
{
	// Token: 0x0600037E RID: 894 RVA: 0x00010624 File Offset: 0x0000E824
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x4B4980", Offset = "0x4B2F80", VA = "0x1804B4980")]
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

	// Token: 0x0600037F RID: 895 RVA: 0x000106E4 File Offset: 0x0000E8E4
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public LoonManager()
	{
	}

	// Token: 0x06000380 RID: 896 RVA: 0x000106F8 File Offset: 0x0000E8F8
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000380")]
	[Address(RVA = "0x4B4D30", Offset = "0x4B3330", VA = "0x1804B4D30")]
	static LoonManager()
	{
		throw new NullReferenceException();
	}

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
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
