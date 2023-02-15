using System.Runtime.CompilerServices;
#if NET452
using LinqToDB.Common.Internal;
#endif

namespace System.Threading.Tasks
{
	static class TaskEx
	{
		public static Task CompletedTask
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
#if NET452
				return TaskCache.False;
#else
				return Task.CompletedTask;
#endif
			}
		}
	}
}
