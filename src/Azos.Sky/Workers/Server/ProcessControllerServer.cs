﻿using System.Collections.Generic;

using Azos.Apps.Injection;

namespace Azos.Sky.Workers.Server
{
  /// <summary>
  /// Glue trampoline for ProcessControllerService
  /// </summary>
  public class ProcessControllerServer : Contracts.IProcessController
  {

    [Inject] IApplication m_App;

    public ProcessControllerService Service => m_App.NonNull(nameof(m_App))
                                              .Singletons
                                              .Get<ProcessControllerService>()
                                              .NonNull(nameof(ProcessControllerService));

    public void Spawn(ProcessFrame frame) => Service.Spawn(frame);

    public ProcessFrame Get(PID pid) => Service.Get(pid);

    public ProcessDescriptor GetDescriptor(PID pid) => Service.GetDescriptor(pid);

    public SignalFrame Dispatch(SignalFrame signal) => Dispatch(signal);

    public IEnumerable<ProcessDescriptor> List(int processorID)=> List(processorID);
  }

}
