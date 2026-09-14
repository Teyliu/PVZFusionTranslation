using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000CCE RID: 3278
	[Token(Token = "0x2000CCE")]
	public static class Config
	{
		// Token: 0x060044B6 RID: 17590 RVA: 0x0015D200 File Offset: 0x0015B400
		[Token(Token = "0x60044B6")]
		[Address(RVA = "0x82F9B0", Offset = "0x82DFB0", VA = "0x18082F9B0")]
		static Config()
		{
			int num;
			do
			{
				num = 0;
				Dictionary<PlantType, BaseConfig> dictionary = new Dictionary();
				Config.configs = dictionary;
				IEnumerator enumerator = dictionary.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator();
				IEnumerable<Type> enumerable;
				if (enumerable != 0)
				{
					if (num < typeof(IEnumerator).TypeHandle)
					{
						num += num;
						if (num != typeof(IEnumerator).TypeHandle)
						{
							num++;
						}
					}
					object obj;
					obj += obj;
					Dictionary<PlantType, BaseConfig> dictionary2 = Config.configs;
				}
				if ("{il2cpp array field local8->}" != (ulong)0L)
				{
				}
			}
			while (num != 0);
		}

		// Token: 0x04003145 RID: 12613
		[Token(Token = "0x4003145")]
		public static Dictionary<PlantType, BaseConfig> configs;
	}
}
