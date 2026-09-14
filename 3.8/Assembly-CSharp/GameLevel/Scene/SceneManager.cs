using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000BF4 RID: 3060
	[Token(Token = "0x2000BF4")]
	public static class SceneManager
	{
		// Token: 0x06003FD3 RID: 16339 RVA: 0x001520E8 File Offset: 0x001502E8
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x81B030", Offset = "0x819630", VA = "0x18081B030")]
		static SceneManager()
		{
			Action<GameScene> action;
			SceneManager.scenes = global::Core.Lawnf.ReflectGetDic<SceneType, GameScene>("SceneType", action);
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x00152110 File Offset: 0x00150310
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x81AFA0", Offset = "0x8195A0", VA = "0x18081AFA0")]
		public static bool TryGetScene(SceneType sceneType, [Out] GameScene scene)
		{
			Dictionary<SceneType, GameScene> dictionary = SceneManager.scenes;
			bool flag;
			return flag;
		}

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		public static readonly Dictionary<SceneType, GameScene> scenes = new Dictionary();
	}
}
