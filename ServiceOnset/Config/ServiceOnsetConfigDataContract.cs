﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ServiceOnset.Config
{
    [DataContract]
    public partial class ServiceOnsetConfig
    {
        [DataMember(Name = "enableLog")]
        private bool _enableLog;
        [DataMember(Name = "services")]
        private ServiceStartInfo[] _startInfos;
    }

    [DataContract]
    public partial class ServiceStartInfo
    {
        [DataMember(Name = "name")]
        private string _name;
        [DataMember(Name = "command")]
        private string _command;
        [DataMember(Name = "arguments")]
        private string _arguments;
        [DataMember(Name = "workingDirectory")]
        private string _workingDirectory;
        [DataMember(Name = "runMode")]
        private string _runModeText;
        [DataMember(Name = "intervalInSeconds")]
        private int _intervalInSeconds;
        [DataMember(Name = "useShellExecute")]
        private bool _useShellExecute;
        [DataMember(Name = "allowWindow")]
        private bool _allowWindow;
        [DataMember(Name = "killExistingProcess")]
        private bool _killExistingProcess;
        [DataMember(Name = "enableLog")]
        private bool _enableLog;
    }
}
