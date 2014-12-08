/*
 * Użytkownik: Kamil
 * Data: 2014-12-06
 * Godzina: 21:49
 */
using System;

namespace SegregujInterfejsy
{
	/// <summary>
	/// Abstraction on door objects: what basic ops and self-desc they should provide.
	/// </summary>
	public interface IDoor
	{
		void Lock();
		void Open();
		bool IsOpened();
	}
}
