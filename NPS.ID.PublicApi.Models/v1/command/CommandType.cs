/*
 *  Copyright 2017 Nord Pool.
 *  This library is intended to aid integration with Nord Pool's Intraday API and comes without any warranty. Users of this library are responsible for separately testing and ensuring that it works according to their own standards.
 *  Please send feedback to idapi@nordpoolgroup.com.
 */

using System;
using System.Collections.Generic;

namespace Nordpool.ID.PublicApi.v1.Command
{
	public enum CommandType
	{
		LOGOUT,
		TOKEN_REFRESH,
		DEAC_USER_ORDERS,
		DEAC_COMPANY_ORDERS,
		ACTI_USER_ORDERS,
		ACTI_COMPANY_ORDERS,
		DELETE_USER_ORDERS,
		DELETE_COMPANY_ORDERS
	}
}
