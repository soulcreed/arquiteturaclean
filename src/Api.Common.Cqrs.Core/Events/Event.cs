﻿using Api.Common.Cqrs.Core.Bus;

namespace Api.Common.Cqrs.Core.Events
{
    public abstract class Event : Message, IEvent
    {
    }
}