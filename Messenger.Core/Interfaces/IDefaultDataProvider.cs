﻿using System.Threading.Tasks;

namespace Messenger.Core.Interfaces
{
	public interface IDefaultDataProvider
    {
		Task CheckAndCreateDefaultChat();
    }
}