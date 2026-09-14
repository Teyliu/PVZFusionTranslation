using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000C36 RID: 3126
	[Token(Token = "0x2000C36")]
	public static class SceneManager
	{
		// Token: 0x06004124 RID: 16676 RVA: 0x00157318 File Offset: 0x00155518
		[Token(Token = "0x6004124")]
		[Address(RVA = "0x88C5B0", Offset = "0x88ABB0", VA = "0x18088C5B0")]
		static SceneManager()
		{
			Action<GameScene> action;
			SceneManager.scenes = global::Core.Lawnf.ReflectGetDic<SceneType, GameScene>("SceneType", action);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x00157340 File Offset: 0x00155540
		[Token(Token = "0x6004125")]
		[Address(RVA = "0x88C520", Offset = "0x88AB20", VA = "0x18088C520")]
		public static bool TryGetScene(SceneType sceneType, [Out] GameScene scene)
		{
			Dictionary<SceneType, GameScene> dictionary = SceneManager.scenes;
			bool flag;
			return flag;
		}

		// Token: 0x040031F3 RID: 12787
		[Token(Token = "0x40031F3")]
		public static readonly Dictionary<SceneType, GameScene> scenes = new Dictionary();
	}
}
