﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer8.Events;

namespace IdentityServer8.Services
{
    /// <summary>
    /// Models persistence of events
    /// </summary>
    public interface IEventSink
    {
        /// <summary>
        /// Raises the specified event.
        /// </summary>
        /// <param name="evt">The event.</param>
        Task PersistAsync(Event evt);
    }
}