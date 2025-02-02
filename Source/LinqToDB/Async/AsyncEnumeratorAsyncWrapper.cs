﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinqToDB.Async
{
	internal sealed class AsyncEnumeratorAsyncWrapper<T> : IAsyncEnumerator<T>
	{
		private IAsyncEnumerator<T>? _enumerator;
#if !NATIVE_ASYNC
		private readonly Func<Task<Tuple<IAsyncEnumerator<T>, IDisposable?>>> _init;
		private IDisposable? _disposable;
#else
		private readonly Func<Task<Tuple<IAsyncEnumerator<T>, IAsyncDisposable?>>> _init;
		private IAsyncDisposable? _disposable;
#endif

#if !NATIVE_ASYNC
		public AsyncEnumeratorAsyncWrapper(Func<Task<Tuple<IAsyncEnumerator<T>, IDisposable?>>> init)
#else
		public AsyncEnumeratorAsyncWrapper(Func<Task<Tuple<IAsyncEnumerator<T>, IAsyncDisposable?>>> init)
#endif
		{
			_init = init;
		}

		T IAsyncEnumerator<T>.Current => _enumerator!.Current;

#if !NATIVE_ASYNC
		async Task IAsyncDisposable.DisposeAsync()
		{
			await _enumerator!.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
			_disposable?.Dispose();
		}

		async Task<bool> IAsyncEnumerator<T>.MoveNextAsync()
		{
			if (_enumerator == null)
			{
				var tuple   = await _init().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
				_enumerator = tuple.Item1;
				_disposable = tuple.Item2;
			}

			return await _enumerator.MoveNextAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
		}
#else
		async ValueTask IAsyncDisposable.DisposeAsync()
		{
			await _enumerator!.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
			if (_disposable != null)
				await _disposable.DisposeAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
		}

		async ValueTask<bool> IAsyncEnumerator<T>.MoveNextAsync()
		{
			if (_enumerator == null)
			{
				var tuple   = await _init().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
				_enumerator = tuple.Item1;
				_disposable = tuple.Item2;
			}

			return await _enumerator.MoveNextAsync().ConfigureAwait(Common.Configuration.ContinueOnCapturedContext);
		}
#endif
	}
}
