// Guids.cs
// MUST match guids.h
using System;

namespace NBSCompany.VaRsSwitch
{
    static class GuidList
    {
        public const string guidVaRsSwitchPkgString = "fedce980-2431-480b-b205-c16d67cb95ac";
        public const string guidVaRsSwitchCmdSetString = "45706c85-de92-417b-a9f8-0d41ed0a6cd3";

        public static readonly Guid guidVaRsSwitchCmdSet = new Guid(guidVaRsSwitchCmdSetString);
    };
}