﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvilDICOM.Core.Enums
{
    public enum ItemType
    {
        APPLICATION_CONTEXT = 0x10,
        PRESENTATION_CONTEXT_REQUEST = 0x20,
        PRESENTATION_CONTEXT_ACCEPT = 0x21,
        ABSTRACT_SYNTAX = 0x30,
        TRANSFER_SYNTAX = 0x40,
        USER_INFO = 0x50,
        MAXIMUM_LENGTH = 0x51,
        IMPLEMENTATION_CLASS_UID = 0x52,
        ASYNCHRONOUS_OPERATIONS_WINDOW = 0x53,
        SCPSCU_ROLE_SELECTION = 0x54,
        IMPLEMENTATION_VERSION_NAME = 0x55,
        SOP_CLASS_EXTENDED_NEGOTIATION = 0x56
    }
}
