namespace KdlCore.Native.Commons.Win32Types
{
    public enum SystemInformationClass
    {
        SystemBasicInformation,
        SystemProcessorInformation,
        SystemPerformanceInformation,
        SystemTimeOfDayInformation,
        SystemPathInformation,
        SystemProcessInformation,
        SystemCallCountInformation,
        SystemDeviceInformation,
        SystemProcessorPerformanceInformation,
        SystemFlagsInformation,
        SystemCallTimeInformation, // 10
        SystemModuleInformation,
        SystemLocksInformation,
        SystemStackTraceInformation,
        SystemPagedPoolInformation,
        SystemNonPagedPoolInformation,
        SystemHandleInformation,
        SystemObjectInformation,
        SystemPageFileInformation,
        SystemVdmInstemulInformation,
        SystemVdmBopInformation, // 20
        SystemFileCacheInformation,
        SystemPoolTagInformation,
        SystemInterruptInformation,
        SystemDpcBehaviorInformation,
        SystemFullMemoryInformation,
        SystemLoadGdiDriverInformation,
        SystemUnloadGdiDriverInformation,
        SystemTimeAdjustmentInformation,
        SystemSummaryMemoryInformation,
        SystemMirrorMemoryInformation, // 30
        SystemPerformanceTraceInformation,
        SystemCrashDumpInformation,
        SystemExceptionInformation,
        SystemCrashDumpStateInformation,
        SystemKernelDebuggerInformation,
        SystemContextSwitchInformation,
        SystemRegistryQuotaInformation,
        SystemExtendServiceTableInformation, // used to be SystemLoadAndCallImage
        SystemPrioritySeparation,
        SystemVerifierAddDriverInformation, // 40
        SystemVerifierRemoveDriverInformation,
        SystemProcessorIdleInformation,
        SystemLegacyDriverInformation,
        SystemCurrentTimeZoneInformation,
        SystemLookasideInformation,
        SystemTimeSlipNotification,
        SystemSessionCreate,
        SystemSessionDetach,
        SystemSessionInformation,
        SystemRangeStartInformation, // 50
        SystemVerifierInformation,
        SystemVerifierThunkExtend,
        SystemSessionProcessInformation,
        SystemLoadGdiDriverInSystemSpace,
        SystemNumaProcessorMap,
        SystemPrefetcherInformation,
        SystemExtendedProcessInformation,
        SystemRecommendedSharedDataAlignment,
        SystemComPlusPackage,
        SystemNumaAvailableMemory, // 60
        SystemProcessorPowerInformation,
        SystemEmulationBasicInformation,
        SystemEmulationProcessorInformation,
        SystemExtendedHandleInformation,
        SystemLostDelayedWriteInformation,
        SystemBigPoolInformation,
        SystemSessionPoolTagInformation,
        SystemSessionMappedViewInformation,
        SystemHotpatchInformation,
        SystemObjectSecurityMode, // 70
        SystemWatchdogTimerHandler, // doesn't seem to be implemented
        SystemWatchdogTimerInformation,
        SystemLogicalProcessorInformation,
        SystemWow64SharedInformation,
        SystemRegisterFirmwareTableInformationHandler,
        SystemFirmwareTableInformation,
        SystemModuleInformationEx,
        SystemVerifierTriageInformation,
        SystemSuperfetchInformation,
        SystemMemoryListInformation, // 80
        SystemFileCacheInformationEx,
        SystemNotImplemented19,
        SystemProcessorDebugInformation,
        SystemVerifierInformation2,
        SystemNotImplemented20,
        SystemRefTraceInformation,
        SystemSpecialPoolTag, // MmSpecialPoolTag, then MmSpecialPoolCatchOverruns != 0
        SystemProcessImageName,
        SystemNotImplemented21,
        SystemBootEnvironmentInformation, // 90
        SystemEnlightenmentInformation,
        SystemVerifierInformationEx,
        SystemNotImplemented22,
        SystemNotImplemented23,
        SystemCovInformation,
        SystemNotImplemented24,
        SystemNotImplemented25,
        SystemPartitionInformation,
        SystemSystemDiskInformation, // this and SystemPartitionInformation both call IoQuerySystemDeviceName
        SystemPerformanceDistributionInformation, // 100
        SystemNumaProximityNodeInformation,
        SystemTimeZoneInformation2,
        SystemCodeIntegrityInformation,
        SystemNotImplemented26,
        SystemUnknownInformation, // No symbols for this case, very strange...
        SystemVaInformation // 106, calls MmQuerySystemVaInformation
    }
}