using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;

namespace GameLevel.RogueShooting
{
	// Token: 0x02000DB3 RID: 3507
	[Token(Token = "0x2000DB3")]
	public static class Config
	{
		// Token: 0x06004903 RID: 18691 RVA: 0x0016ADA0 File Offset: 0x00168FA0
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x8AA510", Offset = "0x8A8B10", VA = "0x1808AA510")]
		static Config()
		{
			for (;;)
			{
				int num = 0;
				Dictionary<PlantType, BaseConfig> dictionary = new Dictionary();
				Config.configs = dictionary;
				Func<Type, bool> func = delegate(Type t)
				{
					if (typeof(BaseConfig).IsAssignableFrom(t) && !t.IsInterface)
					{
						return t.IsAbstract;
					}
					throw new NullReferenceException();
				};
				IEnumerable<Type> enumerable = Enumerable.Where<Type>(dictionary, func);
				if (num >= func)
				{
					goto IL_0037;
				}
				num += num;
				if (num != func)
				{
					num++;
					goto IL_0037;
				}
				IL_0056:
				object obj;
				obj += obj;
				Dictionary<PlantType, BaseConfig> dictionary2 = Config.configs;
				if (num == 0)
				{
					break;
				}
				continue;
				IL_0037:
				if (num < typeof(IEnumerable<Type>).TypeHandle)
				{
					num += num;
					num++;
				}
				if (num >= num)
				{
					goto IL_0056;
				}
				num += num;
				if (num != 0)
				{
					num++;
					goto IL_0056;
				}
				goto IL_0056;
			}
		}

		// Token: 0x040033D6 RID: 13270
		[Token(Token = "0x40033D6")]
		public static Dictionary<PlantType, BaseConfig> configs;
	}
}
