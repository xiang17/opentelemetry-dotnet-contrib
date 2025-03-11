// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

#if NET

using System.Diagnostics.Tracing;
using Microsoft.LinuxTracepoints.Provider;

namespace OpenTelemetry.Exporter.Geneva.Transports;

internal sealed class UnixUserEventsDataTransport : IDisposable
{
    public const ulong LogsTracepointKeyword = 1;  // TODO: This will be a constant in the future. The actual value is TBD.

    private readonly string eventHeaderDynamicProviderName;
    private readonly EventHeaderDynamicProvider eventHeaderDynamicProvider;
    private readonly EventHeaderDynamicTracepoint[] logsTracepoints;

    public UnixUserEventsDataTransport(string providerName)
    {
        this.eventHeaderDynamicProviderName = providerName;
        this.eventHeaderDynamicProvider = new EventHeaderDynamicProvider(this.eventHeaderDynamicProviderName);
        EventLevel[] levels = [
            EventLevel.LogAlways,
            EventLevel.Critical,
            EventLevel.Error,
            EventLevel.Warning,
            EventLevel.Informational,
            EventLevel.Verbose,
        ];

        this.logsTracepoints = new EventHeaderDynamicTracepoint[levels.Length];

        for (var i = 0; i < levels.Length; ++i)
        {
            var logsTracepoint = this.eventHeaderDynamicProvider.Register(levels[i], LogsTracepointKeyword);
            if (logsTracepoint.RegisterResult != 0)
            {
                // ENOENT (2): No such file or directory
                if (logsTracepoint.RegisterResult == 2)
                {
                    throw new NotSupportedException(
                        $"Tracepoint registration for 'geneva_logs' failed with result: '{logsTracepoint.RegisterResult}'. Verify your distribution/kernel supports user_events: https://docs.kernel.org/trace/user_events.html.");
                }

                ExporterEventSource.Log.TransportInformation(
                    nameof(UnixUserEventsDataTransport),
                    $"Tracepoint registration operation for 'geneva_logs' returned result '{logsTracepoint.RegisterResult}' which is considered recoverable. Entering running state.");
            }

            this.logsTracepoints[(int)levels[i]] = logsTracepoint;
        }
    }

    public EventHeaderDynamicTracepoint FindLogsTracepoint(EventLevel eventLevel)
    {
        return this.logsTracepoints[(int)eventLevel];
    }

    public void Dispose()
    {
        this.eventHeaderDynamicProvider.Dispose();
    }
}

#endif
