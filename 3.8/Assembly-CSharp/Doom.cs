using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
public class Doom : MonoBehaviour
{
	// Token: 0x06000947 RID: 2375 RVA: 0x00032AE0 File Offset: 0x00030CE0
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x8781B0", Offset = "0x8767B0", VA = "0x1808781B0")]
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

	// Token: 0x06000948 RID: 2376 RVA: 0x00032B18 File Offset: 0x00030D18
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x877EB0", Offset = "0x8764B0", VA = "0x180877EB0")]
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

	// Token: 0x06000949 RID: 2377 RVA: 0x00032BA8 File Offset: 0x00030DA8
	[Token(Token = "0x6000949")]
	[Address(RVA = "0x877E50", Offset = "0x876450", VA = "0x180877E50")]
	private void Die()
	{
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00032BC0 File Offset: 0x00030DC0
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public Doom()
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00032BD4 File Offset: 0x00030DD4
	// Note: this type is marked as 'beforefieldinit'.
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x878270", Offset = "0x876870", VA = "0x180878270")]
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

	// Token: 0x040004B3 RID: 1203
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B3")]
	public GameObject sprit;

	// Token: 0x040004B4 RID: 1204
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40004B4")]
	public DoomType doomType;

	// Token: 0x040004B5 RID: 1205
	[Token(Token = "0x40004B5")]
	private static readonly Dictionary<DoomType, string> dic;
}
