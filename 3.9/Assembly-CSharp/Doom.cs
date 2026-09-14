using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000220 RID: 544
[Token(Token = "0x2000220")]
public class Doom : MonoBehaviour
{
	// Token: 0x0600095D RID: 2397 RVA: 0x00032910 File Offset: 0x00030B10
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x907C40", Offset = "0x906240", VA = "0x180907C40")]
	public void Start()
	{
		GameObject gameObject = this.sprit;
		int num = 0;
		if (gameObject != num)
		{
			Board instance = Board.Instance;
			global::UnityEngine.Object.Destroy(this.sprit);
		}
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00032948 File Offset: 0x00030B48
	[Token(Token = "0x600095E")]
	[Address(RVA = "0x907940", Offset = "0x905F40", VA = "0x180907940")]
	public static Doom SetDoom(Board board, Vector2 position, DoomType doomType, [Optional] Action action, bool sprit = true)
	{
		Dictionary<DoomType, string> dictionary = Doom.dic;
		bool flag;
		if (!flag)
		{
		}
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform = board.transform;
		GameObject gameObject;
		Doom component = gameObject.GetComponent<Doom>();
		global::UnityEngine.Object.Destroy(component.sprit);
		component.doomType = doomType;
		ScreenShake.TriggerShake(0.15f);
		GameAPP.PlaySound(41, 0.5f, 1f);
		if (action != 0)
		{
		}
		SortingGroup sortingGroup = component.AddComponent<SortingGroup>();
		sortingGroup.sortingLayerName = "particle11";
		sortingGroup.sortingOrder = 100;
		throw new NullReferenceException();
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x000329D8 File Offset: 0x00030BD8
	[Token(Token = "0x600095F")]
	[Address(RVA = "0x9078E0", Offset = "0x905EE0", VA = "0x1809078E0")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x000329F0 File Offset: 0x00030BF0
	[Token(Token = "0x6000960")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public Doom()
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00032A04 File Offset: 0x00030C04
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x6000961")]
	[Address(RVA = "0x907D00", Offset = "0x906300", VA = "0x180907D00")]
	static Doom()
	{
		Dictionary<DoomType, string> dictionary = new Dictionary();
		int num = 0;
		dictionary.Add(num, "Particle/Prefabs/Doom_fire");
		dictionary.Add((uint)1, "Particle/Prefabs/Doom_nuclear");
		dictionary.Add((uint)2, "Particle/Prefabs/Doom_nuclear2");
		dictionary.Add((uint)3, "Particle/Prefabs/Doom_fire_big");
		dictionary.Add((uint)4, "Particle/Prefabs/Doom_portal_big");
		dictionary.Add((uint)6, "Particle/Prefabs/IceDoom_big");
		dictionary.Add((uint)5, "Particle/Prefabs/IceDoom");
		Doom.dic = dictionary;
		throw new NullReferenceException();
	}

	// Token: 0x040004B8 RID: 1208
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B8")]
	public GameObject sprit;

	// Token: 0x040004B9 RID: 1209
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B9")]
	public DoomType doomType;

	// Token: 0x040004BA RID: 1210
	[Token(Token = "0x40004BA")]
	private static readonly Dictionary<DoomType, string> dic;
}
