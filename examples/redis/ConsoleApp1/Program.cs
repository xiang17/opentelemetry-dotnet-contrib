// <copyright file="Program.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using OpenTelemetry;
using OpenTelemetry.Exporter.Geneva;
using OpenTelemetry.Metrics;
using System.Diagnostics.Metrics;

await EmitMetrics("one");
await EmitMetrics("two");

static async Task EmitMetrics(string attempt)
{
    using var meterProvider = Sdk.CreateMeterProviderBuilder()
        .AddMeter("*")
        .AddGenevaMetricExporter(x =>
        {
            x.MetricExportIntervalMilliseconds = 1000;
            x.ConnectionString = "Account=OTelGeneva;Namespace=MeteringSample";
        })
        .Build();

    using var meter = new Meter("GenevaMetricExporterBug");

    meter.CreateCounter<long>("counter_" + attempt)
        .Add(1);

    // Give the exporter some time to send the metrics
    await Task.Delay(2000).ConfigureAwait(false);
}
